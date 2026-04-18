using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AreasDatos
    {
        Conexion cn;

        public AreasDatos()
        {
            cn = new Conexion();
        }

        public DataTable ObtenerAreas()
        {
            string query = "SELECT * FROM Areas";
            return cn.ObtenerRegistros(query);
        }

        public DataRow ObtenerAreas(int areaId)
        {
            string query = "SELECT * FROM Areas WHERE AreaID="+areaId;
            return cn.ObtenerRegistro(query);
        }

    }
}
