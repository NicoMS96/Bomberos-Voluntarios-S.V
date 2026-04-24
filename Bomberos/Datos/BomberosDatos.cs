using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Datos
{
    public class BomberosDatos
    {

        public List<Bombero> ObtenerBomberos(bool activo)
        { 
            var lista = new List<Bombero>();
            try
            {
                using (var oConexion = new SqlConnection(Conexion.cn))
                {
                    string query = @"SELECT b.codigoBombero, b.nombre, b.apellido, b.dni, b.contrasena,
                                     b.permisos, b.activo, b.areaId, b.categoriaId,
                                     a.area, c.categoria
                                     FROM Bomberos b
                                     INNER JOIN Areas a ON b.areaId = a.areaId
                                     INNER JOIN Categorias c ON c.categoriaId = b.categoriaId
                                     WHERE b.activo = @activo";

                    var cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@activo", activo);

                    oConexion.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Bombero()
                            {
                                CodigoBombero = Convert.ToInt32(dr["codigoBombero"]),
                                Nombre = dr["nombre"].ToString(),
                                Apellido = dr["apellido"].ToString(),
                                Dni = dr["dni"].ToString(),
                                Contrasena = dr["contrasena"].ToString(),
                                Permisos = Convert.ToBoolean(dr["permisos"]),
                                Activo = Convert.ToBoolean(dr["activo"]),
                                Area = new Area()
                                {
                                    AreaId = Convert.ToInt32(dr["areaId"]),
                                    AreaNombre = dr["area"].ToString()
                                },
                                Categoria = new Categoria()
                                {
                                    CategoriaId = Convert.ToInt32(dr["categoriaId"]),
                                     CategoriaNombre= dr["categoria"].ToString()
                                }
                            }); 
                        }
                    }
                }
            }
            catch { lista = new List<Bombero>(); }
            return lista;
        }

        public Bombero ObtenerBombero(int codigoBombero)
        {  
            Bombero bombero = null;
            try
            {
                using (var oConexion = new SqlConnection(Conexion.cn))
                {
                    string query = @"SELECT b.*, a.area, c.categoria
                                     FROM Bomberos b
                                     INNER JOIN Areas a ON b.areaId = a.areaId
                                     INNER JOIN Categorias c ON b.categoriaId = c.categoriaId
                                     WHERE b.codigoBombero = @codigoBombero";

                    var cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@codigoBombero", codigoBombero);

                    oConexion.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            bombero = new Bombero()
                            {
                                CodigoBombero = Convert.ToInt32(dr["codigoBombero"]),
                                Nombre = dr["nombre"].ToString(),
                                Apellido = dr["apellido"].ToString(),
                                Dni = dr["dni"].ToString(),
                                Contrasena = dr["contrasena"].ToString(),
                                Permisos = Convert.ToBoolean(dr["permisos"]),
                                Activo = Convert.ToBoolean(dr["activo"]),
                                Area = new Area()
                                {
                                    AreaId = Convert.ToInt32(dr["areaId"]),
                                    AreaNombre = dr["area"].ToString()
                                },
                                Categoria = new Categoria()
                                {
                                    CategoriaId = Convert.ToInt32(dr["categoriaId"]),
                                    CategoriaNombre = dr["categoria"].ToString()
                                }
                            };
                        }
                    }
                }
            }
            catch { bombero = null; }
            return bombero; 
        }



        public bool NuevoBombero(Bombero bombero)
        {
            using (var oConexion = new SqlConnection(Conexion.cn))
            {
                string query = @"INSERT INTO Bomberos(nombre, apellido, dni, contrasena, permisos, activo, areaId, categoriaId) " +
                "VALUES(@nombre, @apellido, @dni,@contrasena, @permisos,1,@areaId,@categoriaId)";

                var cmd = new SqlCommand(query, oConexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombre", bombero.Nombre);
                cmd.Parameters.AddWithValue("@apellido", bombero.Apellido);
                cmd.Parameters.AddWithValue("@dni", bombero.Dni);
                cmd.Parameters.AddWithValue("@contrasena", bombero.Contrasena);
                cmd.Parameters.AddWithValue("@permisos", bombero.Permisos);
                cmd.Parameters.AddWithValue("@areaId", bombero.Area.AreaId);
                cmd.Parameters.AddWithValue("@categoriaId", bombero.Categoria.CategoriaId);


                oConexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }


        }

        public bool ModificarBombero(Bombero bombero)
        {
            using (var oConexion = new SqlConnection(Conexion.cn))
            {
                string query = @"UPDATE Bomberos SET
                                     nombre      = @nombre,
                                     apellido    = @apellido,
                                     dni         = @dni,
                                     contrasena  = @contrasena,
                                     permisos    = @permisos,
                                     activo      = @activo,
                                     areaId      = @areaId,
                                     categoriaId = @categoriaId
                                     WHERE codigoBombero = @codigoBombero";

                var cmd = new SqlCommand(query, oConexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombre", bombero.Nombre);
                cmd.Parameters.AddWithValue("@apellido", bombero.Apellido);
                cmd.Parameters.AddWithValue("@dni", bombero.Dni);
                cmd.Parameters.AddWithValue("@contrasena", bombero.Contrasena);
                cmd.Parameters.AddWithValue("@permisos", bombero.Permisos);
                cmd.Parameters.AddWithValue("@activo", bombero.Activo);
                cmd.Parameters.AddWithValue("@areaId", bombero.Area.AreaId);
                cmd.Parameters.AddWithValue("@categoriaId", bombero.Categoria.CategoriaId);
                cmd.Parameters.AddWithValue("@codigoBombero", bombero.CodigoBombero);

                oConexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }

        }

        public bool AlternarActividad(int activo, int id)
        {   
            try
            {
                using (var oConexion = new SqlConnection(Conexion.cn))
                {
                    string query = "UPDATE Bomberos SET activo=@activo WHERE codigoBombero=@id";

                    var cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@activo", activo);
                    cmd.Parameters.AddWithValue("@id", id); 

                    oConexion.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }


    }
}
