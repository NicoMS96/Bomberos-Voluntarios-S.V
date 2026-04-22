using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BomberosEmergencia
    {
        public int BomberosEmergenciaId { get; set; }
        public int CodigoBombero { get; set; }
        public Emergencia Emergencia { get; set; } 
        public Bombero Bombero { get; set; }
    }
}
