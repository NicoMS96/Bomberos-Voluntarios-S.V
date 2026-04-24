using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class EmergenciaVista
	{ 
        public int EmergenciaId { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Detalles { get; set; }
        public string Asisten { get; set; }
    }
}
