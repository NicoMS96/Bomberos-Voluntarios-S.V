using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bombero
    {
        public int CodigoBombero { get; set; } // Llave primaria
        public string Nombre { get; set; }    // Nombre del bombero
        public string Apellido { get; set; }  // Apellido del bombero
        public string Dni { get; set; }       // DNI del bombero
        public string Contrasena { get; set; } // Contraseña para autenticación
        public int Permisos { get; set; }    // Indicador de permisos especiales
        public int Activo { get; set; }      // Indicador de estado activo/inactivo

        // Relaciones con otras tablas
        public int AreaId { get; set; }       // Llave foránea con `Areas`
        public int CategoriaId { get; set; } // Llave foránea con `Categorias`
    }
}
