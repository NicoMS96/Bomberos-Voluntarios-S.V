using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class Conexion
    {
        SqlConnection Conector;

        //Luego se instancia en el constructor
        public Conexion()
        {
            //Servidor SQL Server - Base de Datos
            string strConexion = @"Data Source=NICO;Initial Catalog=BVSV;Integrated Security=True"; 
            this.Conector = new SqlConnection(strConexion);
        }

        //Metodo para obtener muchos registros
        public DataTable ObtenerRegistros(string query)
        {
            var Comando = new SqlCommand(query, this.Conector);

            DataTable result = new DataTable();

            this.Conector.Open();

            result.Load(Comando.ExecuteReader());

            this.Conector.Close();

            return result;
        }

        //Metodo para obtener un solo registro
        public DataRow ObtenerRegistro(string query)
        {
            var Tabla = this.ObtenerRegistros(query);

            DataRow result = null;

            //Solo devuelvela primer fila
            if (Tabla.Rows.Count > 0)
            {
                result = Tabla.Rows[0];
            }

            return result;
        }

        //Metodo para ejecutar altas, bajas y modificaciones
        public int EjecutarAccion(string query)
        {
            var Comando = new SqlCommand(query, this.Conector);

            this.Conector.Open();

            int result = Comando.ExecuteNonQuery();

            this.Conector.Close();

            return result;
        }

        public DataTable EjecutarStore(string nombreSP, SqlParameter[] parametros)
        {
            var Comando = new SqlCommand(nombreSP, this.Conector);
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddRange(parametros);

            DataTable result = new DataTable();

            Conector.Open();

            result.Load(Comando.ExecuteReader());

            Conector.Close();

            return result;
        }

        public int EjecutarAccionConResultado(string query)
        {
            var Comando = new SqlCommand(query + "; SELECT SCOPE_IDENTITY();", this.Conector);

            this.Conector.Open();

            int result = Convert.ToInt32(Comando.ExecuteScalar());

            this.Conector.Close();

            return result;
        }
    }
}
