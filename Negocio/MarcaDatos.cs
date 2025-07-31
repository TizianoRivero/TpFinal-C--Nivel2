using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaDatos
    {
        public List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = (int)datos.Lector["Id"];
                    marca.Descripcion = datos.Lector["Descripcion"].ToString();
                    lista.Add(marca);
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
    }
}
