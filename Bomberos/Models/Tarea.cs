using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Tarea
    {
        public int TareaId { get; set; }                  // Llave primaria
        public DateTime Fecha { get; set; }              // Llave foránea con `fechas`   
        public string Observaciones { get; set; }        // Observaciones sobre la tarea
        public int sumaPunto { get; set; }
         
        public TareasPredeterminada TareaPredeterminada { get; set; }
         
        public Bombero Bombero { get; set; }

    }
}
