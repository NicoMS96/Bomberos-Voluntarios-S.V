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

        
        public string GuardarTarea(Tarea tarea)
        {
            try
            {
                tareas.GuardarTarea(tarea);
                return null; // null = éxito
            }
            catch (Exception ex)
            {
                return ex.Message; // devuelve el error como string
            }
        }
         

        public DataTable ObtenerTareas(int areaId)
        {
            return tareas.ObtenerTareas(areaId);
        }
    }
}
