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

        
        public List<Bombero> ObtenerBomberos(bool activo)
        {
            return bomberosDatos.ObtenerBomberos(activo);
        }
         
        public Bombero ObtenerBombero(int codigoBombero)
        {
            return bomberosDatos.ObtenerBombero(codigoBombero);
        } 

        public bool NuevoBombero(Bombero bombero)
        { 
            return bomberosDatos.NuevoBombero(bombero);
        }

        public bool ModificarBombero(Bombero bombero)
        { 
            return bomberosDatos.ModificarBombero(bombero);
        }

        public bool AlternarActividad(int activo, int id)
        {
            return bomberosDatos.AlternarActividad(activo, id);
        }
    }
}
