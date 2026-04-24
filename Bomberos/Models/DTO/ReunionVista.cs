using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class ReunionVista
    { 
        public int ReunionId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string TemaReunion { get; set; }
        public string Asisten { get; set; }
    }
}
