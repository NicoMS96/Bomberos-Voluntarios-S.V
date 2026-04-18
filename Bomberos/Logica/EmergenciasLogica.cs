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
    public class EmergenciasLogica
    {
        EmergenciasDatos emergenciasDatos;
        public EmergenciasLogica()
        {
            emergenciasDatos = new EmergenciasDatos();
        }

        public int AgregarEmergencia(Emergencia emergencia)
        {
            return emergenciasDatos.AgregarEmergencia(emergencia);
        }

        public int BomberosEmergencias(int codigoEmergencia, int codigoBombero)
        {
            return emergenciasDatos.BomberosEmergencias(codigoEmergencia, codigoBombero);
        }
        public DataTable ObtenerEmergencias()
        {
            return emergenciasDatos.ObtenerEmergencias();
        }

    }
}
