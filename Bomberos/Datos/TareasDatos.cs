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
        public List<TareasPredeterminada> ObtenerTareasPredeterminadas(int areaId)
        {
            var lista = new List<TareasPredeterminada>();
            using (var oConexion = new SqlConnection(Conexion.cn))
            {
                string query = $"SELECT * FROM TareasPredeterminadas WHERE areaId = @areaId OR areaId IS NULL ";
                var cmd = new SqlCommand(query, oConexion);
                cmd.CommandType = CommandType.Text; 
                cmd.Parameters.AddWithValue("@areaId", areaId);

                oConexion.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new TareasPredeterminada()
                        {
                            TareasPredeterminadaId = Convert.ToInt32(dr["TareasPredeterminadaId"]),
                            TareaPredeterminada = dr["TareaPredeterminada"].ToString()
                        });
                           
                    }
                }
            }
            return lista;
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


        public List<TareaVista> ObtenerTareasAreas(int areaId)
        {
            var lista = new List<TareaVista>();

            using (var oConexion = new SqlConnection(Conexion.cn))
            {
                string query = @"SELECT t.tareaId,
                         b.codigoBombero,
                         CONCAT(b.nombre, ' ', b.apellido) AS bombero,
                         tp.tareaPredeterminada,
                         t.observaciones
                         FROM Tareas t 
                         INNER JOIN TareasPredeterminadas tp ON t.tareasPredeterminadaId = tp.tareasPredeterminadaId
                         INNER JOIN Bomberos b ON t.codigoBombero = b.codigoBombero
                         INNER JOIN Areas a ON a.areaId = b.areaId
                         WHERE b.areaId = @areaId";

                var cmd = new SqlCommand(query, oConexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@areaId", areaId);

                oConexion.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new TareaVista()
                        {
                            TareaId = Convert.ToInt32(dr["tareaId"]),
                            CodigoBombero = Convert.ToInt32(dr["codigoBombero"]),
                            Bombero = dr["bombero"].ToString(),
                            TareaPredeterminada = dr["tareaPredeterminada"].ToString(),
                            Detalles = dr["observaciones"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public bool AnularPunto(int tareaId, string observacion, int codigoBomberoId)
        {

                using (var oConexion = new SqlConnection(Conexion.cn))
                {
                    var cmd = new SqlCommand("sp_AnularPunto", oConexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tareaId", tareaId);
                    cmd.Parameters.AddWithValue("@observacion", observacion);
                    cmd.Parameters.AddWithValue("@codigoBomberoId", codigoBomberoId);
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            
        }
    }
}
