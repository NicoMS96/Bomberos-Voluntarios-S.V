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
    public class ReunionesDatos
    {
        public int AgregarReunion(ReunionArea r)
        {
            using (var oConexion = new SqlConnection(Conexion.cn))
            {
                string query = @"INSERT INTO ReunionesArea (fecha, hora, temaReunion) 
                         VALUES (@fecha, @hora, @temaReunion);
                         SELECT SCOPE_IDENTITY();";

                var cmd = new SqlCommand(query, oConexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fecha", r.Fecha);
                cmd.Parameters.AddWithValue("@hora", r.Hora);
                cmd.Parameters.AddWithValue("@temaReunion", r.TemaReunion);

                oConexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool BomberosReunion(int codigoReunion, int codigoBombero)
        {   
            using (var oConexion = new SqlConnection(Conexion.cn))
            {
                string query = @"INSERT INTO BomberosReuniones VALUES(@codigoBombero ,@codigoReunion)";

                var cmd = new SqlCommand(query, oConexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@codigoBombero", codigoBombero);
                cmd.Parameters.AddWithValue("@codigoReunion", codigoReunion); 

                oConexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<ReunionVista> ObtenerReuniones()
        {
            var lista = new List<ReunionVista>();
            try
            {
                using (var oConexion = new SqlConnection(Conexion.cn))
                {
                    string query = @"
                SELECT 
                    ra.reunionId, 
                    ra.Fecha        AS FECHA,
                    ra.Hora         AS HORA,
                    ra.TemaReunion  AS TEMAREUNION,
                    STUFF((
                        SELECT ', ' + CONCAT(b.nombre, ' ', b.apellido)
                        FROM Bomberos b
                        INNER JOIN BomberosReuniones br ON b.codigoBombero = br.codigoBombero
                        WHERE br.reunionId = ra.reunionId
                        FOR XML PATH('')
                    ), 1, 2, '') AS ASISTEN
                FROM ReunionesArea ra";

                    var cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReunionVista()
                            {
                                ReunionId = Convert.ToInt32(dr["reunionId"]),
                                Fecha = Convert.ToDateTime(dr["FECHA"]),
                                Hora = (TimeSpan)dr["HORA"],
                                TemaReunion = dr["TEMAREUNION"].ToString(),
                                Asisten = dr["ASISTEN"] == DBNull.Value
                                              ? "Sin asistentes"
                                              : dr["ASISTEN"].ToString()
                            });
                        }
                    }
                }
            }
            catch { lista = new List<ReunionVista>(); }
            return lista;
        }

        public bool EliminarReunion(int reunionId)
        {
            using (var oConexion = new SqlConnection(Conexion.cn))
            {
                var cmd = new SqlCommand("sp_EliminarReunion", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@reunionId", reunionId);
                oConexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
