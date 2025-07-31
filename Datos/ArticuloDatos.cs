using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ArticuloDatos
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, M.Id MarcaId, M.Descripcion Marca, C.Id CategoriaId, C.Descripcion Categoria FROM ARTICULOS A JOIN MARCAS M ON M.Id = A.IdMarca JOIN CATEGORIAS C ON C.Id = A.IdCategoria");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo art = new Articulo();
                    art.Id = (int)datos.Lector["Id"];
                    art.Codigo = datos.Lector["Codigo"].ToString();
                    art.Nombre = datos.Lector["Nombre"].ToString();
                    art.Descripcion = datos.Lector["Descripcion"].ToString();
                    art.ImagenUrl = datos.Lector["ImagenUrl"].ToString();
                    art.Precio = (decimal)datos.Lector["Precio"];

                    art.Marca = new Marca
                    {
                        Id = (int)datos.Lector["MarcaId"],
                        Descripcion = datos.Lector["Marca"].ToString()
                    };

                    art.Categoria = new Categoria
                    {
                        Id = (int)datos.Lector["CategoriaId"],
                        Descripcion = datos.Lector["Categoria"].ToString()
                    };

                    lista.Add(art);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, Precio, IdMarca, IdCategoria) " +
                                     "VALUES (@codigo, @nombre, @descripcion, @imagenUrl, @precio, @idMarca, @idCategoria)");
                datos.SetearParametro("@codigo", nuevo.Codigo);
                datos.SetearParametro("@nombre", nuevo.Nombre);
                datos.SetearParametro("@descripcion", nuevo.Descripcion);
                datos.SetearParametro("@imagenUrl", nuevo.ImagenUrl);
                datos.SetearParametro("@precio", nuevo.Precio);
                datos.SetearParametro("@idMarca", nuevo.Marca.Id);
                datos.SetearParametro("@idCategoria", nuevo.Categoria.Id);

                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, ImagenUrl = @imagenUrl, Precio = @precio, IdMarca = @idMarca, IdCategoria = @idCategoria WHERE Id = @id");
                datos.SetearParametro("@codigo", articulo.Codigo);
                datos.SetearParametro("@nombre", articulo.Nombre);
                datos.SetearParametro("@descripcion", articulo.Descripcion);
                datos.SetearParametro("@imagenUrl", articulo.ImagenUrl);
                datos.SetearParametro("@precio", articulo.Precio);
                datos.SetearParametro("@idMarca", articulo.Marca.Id);
                datos.SetearParametro("@idCategoria", articulo.Categoria.Id);
                datos.SetearParametro("@id", articulo.Id);

                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true"))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("DELETE FROM ARTICULOS WHERE Id = @id", conexion);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> Filtrar(string filtro)
        {
            List<Articulo> lista = new List<Articulo>();

            using (SqlConnection conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true"))
            {
                conexion.Open();
                string query = "SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, A.IdMarca, A.IdCategoria " +
                               "FROM ARTICULOS A " +
                               "JOIN MARCAS M ON A.IdMarca = M.Id " +
                               "JOIN CATEGORIAS C ON A.IdCategoria = C.Id " +
                               "WHERE A.Nombre LIKE @filtro OR A.Codigo LIKE @filtro";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo art = new Articulo();
                    art.Id = (int)lector["Id"];
                    art.Codigo = (string)lector["Codigo"];
                    art.Nombre = (string)lector["Nombre"];
                    art.Descripcion = (string)lector["Descripcion"];
                    art.Precio = (decimal)lector["Precio"];
                    art.ImagenUrl = (string)lector["ImagenUrl"];
                    art.Marca = new Marca() { Id = (int)lector["IdMarca"], Descripcion = (string)lector["Marca"] };
                    art.Categoria = new Categoria() { Id = (int)lector["IdCategoria"], Descripcion = (string)lector["Categoria"] };
                    lista.Add(art);
                }
            }

            return lista;
        }
    }
}
