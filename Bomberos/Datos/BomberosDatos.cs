using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Datos
{
    public class BomberosDatos
    {
        Conexion cn;
        public BomberosDatos()
        {
            cn = new Conexion();
        }
        public DataTable ObtenerBomberos()
        {
            string query = "SELECT * FROM Bomberos";
            return cn.ObtenerRegistros(query);
        }
        public DataTable ObtenerBomberos(int activo)
        {
            string query = $@"SELECT b.codigoBombero AS 'COD. BOMB', b.nombre AS NOMBRE, b.apellido as APELLIDO, b.dni as DNI, 
                            b.contrasena, c.categoria as CATEGORIA, b.permisos AS PERMISOS, b.activo, a.area as AREA
                            FROM Bomberos b INNER JOIN Areas a on b.areaId=a.areaId INNER JOIN Categorias c on c.categoriaId=b.categoriaId
                            WHERE activo = {activo}";

            return cn.ObtenerRegistros(query);
        }

        public DataRow ObtenerBombero(int codigoBombero)
        {
            string query = $@"SELECT b.*, a.*, c.*
                            FROM Bomberos b
                            INNER JOIN Areas a ON b.AreaId = a.AreaId
                            INNER JOIN Categorias c ON b.CategoriaId = c.CategoriaId
                            WHERE b.CodigoBombero = {codigoBombero}";
            return cn.ObtenerRegistro(query);
        }
        

        public DataTable ObtenerAreas()
        {
            string query = "SELECT * FROM Areas";

            return cn.ObtenerRegistros(query);
        }

        public DataTable ObtenerCategorias()
        {
            string query = "SELECT * FROM Categorias";

            return cn.ObtenerRegistros(query);
        }

        public int NuevoBombero(Bombero bombero)
        {
            string query = $"INSERT INTO Bomberos VALUES('{bombero.Nombre}','{bombero.Apellido}','{bombero.Dni}','{bombero.Contrasena}',{(bombero.Permisos)},1,{bombero.AreaId},{bombero.CategoriaId})";
            return cn.EjecutarAccion(query);
        }

        public int ModificarBombero(Bombero bombero, int codigoBombero)
        {
            string query = $@"UPDATE Bomberos SET nombre='{bombero.Nombre}',
                                apellido='{bombero.Apellido}',
                                dni='{bombero.Dni}',
                                contrasena='{bombero.Contrasena}',
                                permisos='{bombero.Permisos}',
                                activo='{bombero.Activo}',
                                areaId='{bombero.AreaId}',
                                categoriaId='{bombero.CategoriaId}' WHERE codigoBombero={codigoBombero}";
            return cn.EjecutarAccion(query);

        }

        public int AlternarActividad(int activo, int id)
        {
            string query = $"UPDATE Bomberos SET activo={activo} WHERE codigoBombero={id}";
            return cn.EjecutarAccion(query); 
        }


    }
}
