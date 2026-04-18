using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class EmergenciasDatos
    {
        Conexion cn;
        public EmergenciasDatos()
        {
            cn = new Conexion();
        }

        public int AgregarEmergencia(Emergencia e)
        {
            string query = $"INSERT INTO Emergencias VALUES('{e.FechaEntrada}','{e.Observacion}','{e.FechaSalida}')";

            return cn.EjecutarAccionConResultado(query);
        }

        public int BomberosEmergencias(int codigoEmergencia, int codigoBombero)
        {
            string query = $"INSERT INTO BomberosEmergencias VALUES({codigoBombero},{codigoEmergencia})";
            return cn.EjecutarAccionConResultado(query);
        }

        public DataTable ObtenerEmergencias()
        {
            string query = @"SELECT 
	                        e.emergenciaId, 
	                        e.fechaEntrada AS INICIO,
	                        e.fechaSalida AS FIN, 
	                        E.observacion AS 'DETALLES DE EMERGENCIA',
	                        STUFF((SELECT ', ' + CONCAT(b.nombre, ' ', b.apellido)
		                        FROM Bomberos b
		                        INNER JOIN BomberosEmergencias be ON b.codigoBombero = be.codigoBombero
		                        WHERE be.emergenciaId = e.emergenciaId
		                        FOR XML PATH('')
	                        ), 1, 2, '') AS ASISTIERON
	                        FROM Emergencias e";
            return cn.ObtenerRegistros(query);
        }
    }
}
