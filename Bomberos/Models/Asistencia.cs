using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Asistencia
    {
        public int AsistenciaId { get; set; }         // Llave primaria
        public char AsistenciaValor { get; set; }     // Valor de asistencia (e.g., 'P', 'A')
        public int FechaId { get; set; }              // Llave foránea con `Fechas`
        public int TipoAsistenciaId { get; set; }     // Llave foránea con `TipoAsistencia`
        public int CodigoBombero { get; set; }        // Llave foránea con `Bomberos`
    }
}
