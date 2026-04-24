using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class EmergenciasDatos
    {

        public int AgregarEmergencia(Emergencia e)
        {
            using (var oConexion = new SqlConnection(Conexion.cn))
            { 
                string query = @"INSERT INTO Emergencias(fechaEntrada, observacion, fechaSalida)
                         VALUES(@FechaEntrada,@Observacion,@FechaSalida);
                         SELECT SCOPE_IDENTITY();";

                var cmd = new SqlCommand(query, oConexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FechaEntrada", e.FechaEntrada);
                cmd.Parameters.AddWithValue("@Observacion", e.Observacion);
                cmd.Parameters.AddWithValue("@FechaSalida", e.FechaSalida);

                oConexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
             
        }

        public bool BomberosEmergencias(int codigoEmergencia, int codigoBombero)
        {
            using (var oConexion = new SqlConnection(Conexion.cn))
            {
                string query = @"INSERT INTO BomberosEmergencias VALUES(@codigoBombero, @codigoEmergencia)";

                var cmd = new SqlCommand(query, oConexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@codigoBombero", codigoBombero);
                cmd.Parameters.AddWithValue("@codigoEmergencia", codigoEmergencia); 

                oConexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<EmergenciaVista> ObtenerEmergencias()
        {
            var lista = new List<EmergenciaVista>();

            using (var oConexion = new SqlConnection(Conexion.cn))
            {
                string query = @"SELECT 
	                        e.emergenciaId, 
	                        e.fechaEntrada AS INICIO,
	                        e.fechaSalida AS FIN, 
	                        E.observacion AS 'DETALLES',
	                        STUFF((SELECT ', ' + CONCAT(b.nombre, ' ', b.apellido)
		                        FROM Bomberos b
		                        INNER JOIN BomberosEmergencias be ON b.codigoBombero = be.codigoBombero
		                        WHERE be.emergenciaId = e.emergenciaId
		                        FOR XML PATH('')
	                        ), 1, 2, '') AS ASISTEN
	                        FROM Emergencias e";

                var cmd = new SqlCommand(query, oConexion);
                cmd.CommandType = CommandType.Text;

                oConexion.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new EmergenciaVista()
                        {
                            EmergenciaId = Convert.ToInt32(dr["emergenciaId"]),
                            FechaEntrada = Convert.ToDateTime(dr["INICIO"]),
                            FechaSalida = Convert.ToDateTime(dr["FIN"]),
                            Detalles = dr["DETALLES"].ToString(),
                            Asisten = dr["ASISTEN"] == DBNull.Value
                                          ? "Sin asistentes"
                                          : dr["ASISTEN"].ToString()
                        });
                    }
                } 
            }
            return lista;
        }
    }
}
