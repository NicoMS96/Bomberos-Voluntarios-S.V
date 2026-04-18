using Models;
using System;
using System.Collections.Generic;
using System.Data;
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

        public int GuardarTarea(Tarea t)
        {
            string query = $"INSERT INTO Tareas VALUES({t.TareasPredeterminadaId},{t.CodigoBombero},'{t.Observaciones}','{t.FechaId}',{t.sumaPunto})";
            return cn.EjecutarAccion(query);
        }

        public DataRow TareaPendiente(int codigoBombero, int fechaId)
        {
            string query = $"SELECT * FROM Tareas WHERE codigoBombero={codigoBombero} AND fechaId={fechaId}";
            return cn.ObtenerRegistro(query);
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
