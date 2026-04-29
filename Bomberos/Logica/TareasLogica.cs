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

        public List<TareasPredeterminada> ObtenerTareasPredeterminadas(int areaId)
        {
            return tareas.ObtenerTareasPredeterminadas(areaId);
        }

        
        public string GuardarTarea(Tarea tarea)
        {
            try
            {
                tareas.GuardarTarea(tarea);
                return null; 
            }
            catch (Exception ex)
            {
                return ex.Message; 
            }
        }

        public List<TareaVista> ObtenerTareasAreas(int areaId)
        {
            return tareas.ObtenerTareasAreas(areaId);
        }

        public bool AnularPunto(int tareaId, string observacion,int codigoBomberoId )
        {
            return tareas.AnularPunto(tareaId, observacion, codigoBomberoId);
        }
    }
}
