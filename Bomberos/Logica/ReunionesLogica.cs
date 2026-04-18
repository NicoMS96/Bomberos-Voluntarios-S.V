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
    public class ReunionesLogica
    {
        ReunionesDatos reunionesDatos;
        public ReunionesLogica()
        {
            reunionesDatos = new ReunionesDatos();
        }

        public int AgregarReunion(ReunionArea reunion)
        {
            return reunionesDatos.AgregarReunion(reunion);
        }

        public int BomberosReunion(int codigoReunion,int codigoBombero)
        {

            return reunionesDatos.BomberosReunion(codigoReunion, codigoBombero);
        }

        public DataTable ObtenerReuniones()
        {
            return reunionesDatos.ObtenerReuniones();
        }

        public int EliminarReunion(int idReunion)
        {
            return reunionesDatos.EliminarReunion(idReunion);
        }
    }
}
