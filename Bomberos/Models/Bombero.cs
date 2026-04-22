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
        public bool Permisos { get; set; }    // Indicador de permisos especiales
        public bool Activo { get; set; }      // Indicador de estado activo/inactivo

        // Relaciones con otras tablas
        public Area Area { get; set; }        
        public Categoria Categoria { get; set; }  
    }
}
