using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Models;

namespace Logica
{
    public class AsistenciasLogica
    {
        AsistenciasDatos AsistDatos;
        BomberosDatos bomberosDatos; 



        public AsistenciasLogica()
        {
            AsistDatos = new AsistenciasDatos();
            bomberosDatos = new BomberosDatos(); 
        }

        public List<BomberoAsistencia> AsistenciaInsti()
        {
            return AsistDatos.ObtenerAsistenciaInstitucion();
        }

        public string RegistrarAsistencia(int codigoBombero)
        {
            if (AsistDatos.EstaAdentro(codigoBombero))
                return "Este bombero ya está ingresado.";
             
            return AsistDatos.RegistrarEntrada(codigoBombero) ? null : "Error al registrar entrada.";
        }

        public string RegistrarSalida(int codigoBombero)
        {
            if (!AsistDatos.EstaAdentro(codigoBombero))
                return "El bombero no está actualmente ingresado.";

            return AsistDatos.RegistrarSalida(codigoBombero) ? null : "Error al registrar salida.";
        }


    }
}
