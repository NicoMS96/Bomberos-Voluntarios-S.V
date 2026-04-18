using Datos;
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

        public DataTable ObtenerAreas()
        {
            return areas.ObtenerAreas();
        }
         
    }
}
