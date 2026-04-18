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
    public class BomberosLogica
    {
        BomberosDatos bomberosDatos;
        public BomberosLogica()
        {
            bomberosDatos = new BomberosDatos();
        }

        public DataTable ObtenerBomberos()
        {
            return bomberosDatos.ObtenerBomberos();
        }
        public DataTable ObtenerBomberos(int activo)
        {
            return bomberosDatos.ObtenerBomberos(activo);
        }
         
        public DataRow ObtenerBombero(int codigoBombero)
        {
            return bomberosDatos.ObtenerBombero(codigoBombero);
        }

        public DataTable ObtenerAreas()
        {
            return bomberosDatos.ObtenerAreas();
        }
        public DataTable ObtenerCategorias()
        {
            return bomberosDatos.ObtenerCategorias();
        }

        public int NuevoBombero(Bombero bombero)
        {
            
            return bomberosDatos.NuevoBombero(bombero);
        }

        public int ModificarBombero(Bombero bombero, int codigoBombero)
        {

            return bomberosDatos.ModificarBombero(bombero, codigoBombero);
        }

        public int AlternarActividad(int activo, int id)
        {
            return bomberosDatos.AlternarActividad(activo, id);
        }
    }
}
