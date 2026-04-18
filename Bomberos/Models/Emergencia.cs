using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Emergencia
    {
        public int EmergenciaId { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Observacion { get; set; }
    }
}
