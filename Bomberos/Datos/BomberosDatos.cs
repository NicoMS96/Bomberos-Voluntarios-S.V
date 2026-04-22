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
        public List<Bombero> ObtenerBomberos(int activo)
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
                                    AreaId = Convert.ToInt32(dr["areaId"])
                                },
                                Categoria = new Categoria()
                                {
                                    CategoriaId = Convert.ToInt32(dr["categoriaId"])
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
                                    AreaId = Convert.ToInt32(dr["areaId"])
                                },
                                Categoria = new Categoria()
                                {
                                    CategoriaId = Convert.ToInt32(dr["categoriaId"])
                                } 
                            };
                        }
                    }
                }
            }
            catch { bombero = null; }
            return bombero; 
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
            string query = $"INSERT INTO Bomberos VALUES('{bombero.Nombre}','{bombero.Apellido}','{bombero.Dni}','{bombero.Contrasena}',{(bombero.Permisos)},1,{bombero.Area.AreaId},{bombero.Categoria.CategoriaId})";
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
                                areaId='{bombero.Area.AreaId}',
                                categoriaId='{bombero.Categoria.CategoriaId}' WHERE codigoBombero={codigoBombero}";
            return cn.EjecutarAccion(query);

        }

        public int AlternarActividad(int activo, int id)
        {
            string query = $"UPDATE Bomberos SET activo={activo} WHERE codigoBombero={id}";
            return cn.EjecutarAccion(query); 
        }


    }
}
