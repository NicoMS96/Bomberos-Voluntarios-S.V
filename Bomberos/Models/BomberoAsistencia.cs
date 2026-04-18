using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
     public class BomberoAsistencia
    {
        public int CodigoBombero { get; set; }
        public int FechaId { get; set; }
        public string NombreCompleto { get; set; } // Combina Nombre y Apellido
        public DateTime Fecha { get; set; }
        public float HorasTrabajadas { get; set; }
        public string EstadoAsistencia { get; set; } // Presente, Ausente, etc.


    }
}
