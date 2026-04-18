using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ReunionesDatos
    {
        Conexion cn;
        public ReunionesDatos()
        {
            cn = new Conexion();
        }

        public int AgregarReunion(ReunionArea r)
        {
            string query = $"INSERT INTO ReunionesArea VALUES('{r.Fecha}','{r.Hora}','{r.TemaReunion}')";
            return cn.EjecutarAccionConResultado(query);
        }

        public int BomberosReunion(int codigoReunion, int codigoBombero)
        {
            string query = $"INSERT INTO BomberosReuniones VALUES({codigoBombero},{codigoReunion})";
            return cn.EjecutarAccionConResultado(query);
        }

        public DataTable ObtenerReuniones()
        {
            string query = $@"SELECT 
                            ra.reunionId, 
                            ra.Fecha AS FECHA,
                            ra.Hora AS HORA,
                            ra.TemaReunion AS 'TEMA DE REUNION',
                            STUFF((SELECT ', ' + CONCAT(b.nombre, ' ', b.apellido)
                                FROM Bomberos b
                                INNER JOIN BomberosReuniones br ON b.codigoBombero = br.codigoBombero
                                WHERE br.reunionId = ra.reunionId
                                FOR XML PATH('')
                            ), 1, 2, '') AS ASISTEN
                        FROM 
                            ReunionesArea ra";
            return cn.ObtenerRegistros(query);
        }

        public int EliminarReunion(int idReunion)
        {
            string query = "DELETE FROM BomberosReuniones WHERE reunionId=" + idReunion;
            cn.EjecutarAccion(query);
            query = "DELETE FROM ReunionesArea WHERE reunionId=" + idReunion;
            return cn.EjecutarAccion(query);

        }
    }
}
