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
        public char AsistenciaValor { get; set; }             // Llave foránea con `Fechas`
        public TipoAsistencia TipoAsistencia { get; set; }
        public Bombero Bombero { get; set; }        // Llave foránea con `Bomberos`
        public DateTime Fecha { get; set; }
    }
}
