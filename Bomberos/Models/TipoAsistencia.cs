using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TipoAsistencia
    {
        public int TipoAsistenciaId { get; set; }     // Llave primaria
        public string TipoAsistenciaNombre { get; set; } // Descripción del tipo de asistencia (e.g., 'AREA', 'INSTITUCION')
    }
}
