using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BomberoReunion
    {
        public int BomberosReunionId { get; set; }
        public Bombero Bombero { get; set; }
        public ReunionArea ReunionArea { get; set; }

    }
}
