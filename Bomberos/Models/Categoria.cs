using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }    // Llave primaria
        public string CategoriaNombre { get; set; }    // Nombre de la categoría
        public override string ToString() => CategoriaNombre;
    }
}
