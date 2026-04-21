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
        public int TareasPredeterminadaId { get; set; }   // Llave foránea con `TareasPredeterminadas`
        public int CodigoBombero { get; set; }           // Llave foránea con `Bomberos`
        public string Observaciones { get; set; }        // Observaciones sobre la tarea
        public int sumaPunto { get; set; }


    }
}
