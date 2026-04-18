using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AsistenciasDatos
    {
        Conexion cn;
        public AsistenciasDatos()
        {
            cn = new Conexion();
        }

        public DataRow VerificarFecha(DateTime fecha)
        {
            string query = "SELECT * FROM Fechas WHERE fecha='"+fecha+"'";

            return cn.ObtenerRegistro(query);
        }
        public int RegistrarFecha(DateTime fecha)
        {
            string query = $"INSERT INTO Fechas VALUES('{fecha:dd/MM/yyyy}')";
            return cn.EjecutarAccionConResultado(query);
        }
        public int ObtenerFechaId(DateTime fecha)
        {
            string query = "SELECT fechaId FROM Fechas WHERE fecha='" + fecha + "'";

            return cn.EjecutarAccionConResultado(query);
        }

        public int RegistrarAusencias(Asistencia a)
        { 
            string query = $"INSERT INTO Asistencias VALUES('{a.AsistenciaValor}','{a.FechaId}',{a.TipoAsistenciaId},{a.CodigoBombero})";
            return cn.EjecutarAccion(query);
        }

        public int ActualizarAsistencia(Asistencia asiste)
        { 
            string query = $@"UPDATE Asistencias SET asistencia='{asiste.AsistenciaValor}', tipoAsistenciaId={asiste.TipoAsistenciaId} 
                            WHERE codigoBombero = {asiste.CodigoBombero} AND fechaId={asiste.FechaId}";
            return cn.EjecutarAccion(query);
        }

        public int RegistrarHora(Asistencia asiste, char tipo) 
        {
            string query = $"INSERT INTO RegistroHoras VALUES({asiste.FechaId}, {asiste.CodigoBombero}, GETDATE(), '{tipo}')";
            return cn.EjecutarAccion(query);
        }

        public DataRow ObtenerUltimoRegistro(int codigoBombero)
        {
            string query = $"SELECT TOP 1 tipo, Hora, FechaId FROM RegistroHoras WHERE CodigoBombero = {codigoBombero} ORDER BY Hora DESC ";
            return cn.ObtenerRegistro(query);
        }

        public DataTable AsistenciaInstitucion()
        {
            string query = @"SELECT b.codigoBombero, CONCAT(b.nombre, ' ',b.apellido) AS 'NOMBRE Y APELLIDO', 
                           DAY(f.fecha) AS DIA, MONTH(f.fecha) AS MES, f.fechaId, rh.registroId, 
                           rh.hora, rh.tipo, ta.tipoAsistencia, a.asistencia 
                            FROM Bomberos b 
                            INNER JOIN Asistencias a ON b.codigoBombero=a.codigoBombero
                            INNER JOIN Fechas f ON f.fechaId=a.fechaId
                            INNER JOIN TipoAsistencia ta ON ta.tipoAsistenciaId=a.tipoAsistenciaId
                            INNER JOIN RegistroHoras rh ON rh.fechaId=f.fechaId
                            ORDER BY b.codigoBombero, f.fechaId, rh.hora";
            return cn.ObtenerRegistros(query);
        }


    }
}
