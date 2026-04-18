using Datos;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TareasLogica
    {
        TareasDatos tareas;
        AsistenciasDatos asistencias;
        public TareasLogica()
        {
            asistencias = new AsistenciasDatos();
            tareas = new TareasDatos();
        }

        public DataTable ObtenerTareasPredeterminadas(int areaId)
        {
            return tareas.ObtenerTareasPredeterminadas(areaId);
        }

        public int ObtenerFechaId(DateTime fecha)
        {
            return asistencias.ObtenerFechaId(fecha);
        }

        public int GuardarTarea(Tarea tarea)
        {
            return tareas.GuardarTarea(tarea);
        }

        public bool TareaPendiente(int codigoBombero)
        { 
            int fechaId = ObtenerFechaId(DateTime.Now);
            bool result = tareas.TareaPendiente(codigoBombero, fechaId) == null ? true : false;
            return result;
        }

        public DataTable ObtenerTareas(int areaId)
        {
            return tareas.ObtenerTareas(areaId);
        }
    }
}
