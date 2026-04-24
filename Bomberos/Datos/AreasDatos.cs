using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AreasDatos
    {
        public List<Area> ObtenerAreas()
        {
            var lista = new List<Area>();
            try
            {
                using (var oConexion = new SqlConnection(Conexion.cn))
                {
                    string query = @"SELECT * FROM Areas";

                    var cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Area()
                            {
                                AreaId = Convert.ToInt32(dr["areaId"]),
                                AreaNombre = dr["area"].ToString(),
                                 
                            });
                        }
                    }
                }
            }
            catch { lista = new List<Area>(); }
            return lista;
        }

        public List<Categoria> ObtenerCategorias()
        {
            var lista = new List<Categoria>();
            try
            {
                using (var oConexion = new SqlConnection(Conexion.cn))
                {
                    string query = @"SELECT * FROM Categorias";

                    var cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                CategoriaId = Convert.ToInt32(dr["categoriaId"]),
                                CategoriaNombre = dr["categoria"].ToString(),

                            });
                        }
                    }
                }
            }
            catch { lista = new List<Categoria>(); }
            return lista;
        }
    }
}
