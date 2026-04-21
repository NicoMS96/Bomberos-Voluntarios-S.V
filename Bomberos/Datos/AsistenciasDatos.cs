using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AsistenciasDatos
    {
        public List<BomberoAsistencia> ObtenerAsistenciaInstitucion()
        {
            var lista = new List<BomberoAsistencia>();
            try
            {
                using (var oConexion = new SqlConnection(Conexion.cn))
                {
                    string query = @"
                SELECT 
                    b.codigoBombero,
                    CONCAT(b.nombre, ' ', b.apellido) AS nombreCompleto,
                    CAST(rh.fechaEntrada AS DATE)      AS fecha,
                    CASE 
                        WHEN rh.fechaSalida IS NOT NULL 
                        THEN DATEDIFF(MINUTE, rh.fechaEntrada, rh.fechaSalida) / 60.0
                        ELSE NULL 
                    END AS horasTrabajadas
                FROM RegistroHoras rh
                INNER JOIN Bomberos b ON b.codigoBombero = rh.codigoBombero
                ORDER BY b.codigoBombero, rh.fechaEntrada";

                    var cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new BomberoAsistencia()
                            {
                                CodigoBombero = Convert.ToInt32(dr["codigoBombero"]),
                                NombreCompleto = dr["nombreCompleto"].ToString(),
                                Fecha = Convert.ToDateTime(dr["fecha"]),
                                HorasTrabajadas = dr["horasTrabajadas"] == DBNull.Value
                                                  ? 0
                                                  : Convert.ToSingle(dr["horasTrabajadas"])
                            });
                        }
                    }
                }
            }
            catch { lista = new List<BomberoAsistencia>(); }
            return lista;
        }

        public bool RegistrarEntrada(int codigoBombero)
        {
            try
            {
                using (var oConexion = new SqlConnection(Conexion.cn))
                {
                    string query = @"INSERT INTO RegistroHoras (codigoBombero, fechaEntrada) 
                             VALUES (@codigoBombero, GETDATE())";
                    var cmd = new SqlCommand(query, oConexion);
                    cmd.Parameters.AddWithValue("@codigoBombero", codigoBombero);
                    oConexion.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }
         
        public bool RegistrarSalida(int codigoBombero)
        {
            try
            {
                using (var oConexion = new SqlConnection(Conexion.cn))
                {
                    string query = @"UPDATE RegistroHoras 
                             SET fechaSalida = GETDATE()
                             WHERE codigoBombero = @codigoBombero 
                             AND fechaSalida IS NULL";
                    var cmd = new SqlCommand(query, oConexion);
                    cmd.Parameters.AddWithValue("@codigoBombero", codigoBombero);
                    oConexion.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }
         
        public bool EstaAdentro(int codigoBombero)
        {
            try
            {
                using (var oConexion = new SqlConnection(Conexion.cn))
                {
                    string query = @"SELECT COUNT(*) FROM RegistroHoras 
                             WHERE codigoBombero = @codigoBombero 
                             AND fechaSalida IS NULL";
                    var cmd = new SqlCommand(query, oConexion);
                    cmd.Parameters.AddWithValue("@codigoBombero", codigoBombero);
                    oConexion.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch { return false; }
        }
    }
}
