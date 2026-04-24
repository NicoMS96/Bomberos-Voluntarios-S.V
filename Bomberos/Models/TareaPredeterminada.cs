using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TareasPredeterminada
    {
        public int TareasPredeterminadaId { get; set; }  // Llave primaria
        public string TareaPredeterminada { get; set; }  // Descripción de la tarea
        public override string ToString() => TareaPredeterminada;

    }

}

