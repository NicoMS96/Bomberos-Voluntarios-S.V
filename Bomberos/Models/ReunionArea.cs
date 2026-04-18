using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ReunionArea
    {
        public int ReunionId { get; set; }            // Llave primaria
        public DateTime Fecha { get; set; }           // Fecha de la reunión
        public TimeSpan Hora { get; set; }            // Hora de la reunión
        public string TemaReunion { get; set; }       // Tema de la reunión
    }
}
