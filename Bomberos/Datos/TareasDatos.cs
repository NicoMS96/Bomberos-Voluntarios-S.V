using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class TareasDatos
    {
        Conexion cn;

        public TareasDatos()
        {
            cn = new Conexion();
        }

        public DataTable ObtenerTareasPredeterminadas(int areaId)
        {
            string query = $"SELECT * FROM TareasPredeterminadas WHERE areaId = {areaId} OR areaId IS NULL ";
            return cn.ObtenerRegistros(query);
        }

        public bool GuardarTarea(Tarea t)
        {
            using (var oConexion = new SqlConnection(Conexion.cn))
            {
                string query = @"INSERT INTO Tareas 
                 (tareasPredeterminadaId, codigoBombero, observaciones, fecha, sumaPunto)
                 VALUES
                 (@tareasPredeterminadaId, @codigoBombero, @observaciones, @fecha, @sumaPunto)";
                var cmd = new SqlCommand(query, oConexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@tareasPredeterminadaId", t.TareaPredeterminada.TareasPredeterminadaId);
                cmd.Parameters.AddWithValue("@codigoBombero", t.Bombero.CodigoBombero);
                cmd.Parameters.AddWithValue("@observaciones", t.Observaciones);
                cmd.Parameters.AddWithValue("@fecha", t.Fecha.Date);
                cmd.Parameters.AddWithValue("@sumaPunto", t.sumaPunto);

                oConexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }

        }


        public DataTable ObtenerTareas(int areaId)
        {
            string query = $@"SELECT b.codigoBombero AS 'CODIGO BOMBERO', CONCAT(b.nombre, ' ', b.apellido) AS BOMBERO, tp.tareaPredeterminada AS 'TAREA PREDETERMINADA', t.observaciones AS DETALLES from tareas t INNER JOIN TareasPredeterminadas tp ON t.tareasPredeterminadaId=tp.tareasPredeterminadaId
                            INNER JOIN Bomberos b ON t.codigoBombero=b.codigoBombero
                            INNER JOIN Areas a ON a.areaId=b.areaId
                            WHERE b.areaId={areaId}";
            return cn.ObtenerRegistros(query);
        }
    }
}
