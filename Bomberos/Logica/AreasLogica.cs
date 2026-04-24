using Datos;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AreasLogica
    {
        AreasDatos areas;
        public AreasLogica()
        {
            areas = new AreasDatos();
        }

        public List<Area> ObtenerAreas()
        {
            return areas.ObtenerAreas();
        } 
        public List<Categoria> ObtenerCategorias()
        {
            return areas.ObtenerCategorias();
        }
    }
}
