using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            ArticuloDatos datos = new ArticuloDatos();
            return datos.Listar();
        }

        public void Agregar(Articulo nuevo)
        {
            ArticuloDatos datos = new ArticuloDatos();
            datos.Agregar(nuevo);
        }

        public void Modificar(Articulo articulo)
        {
            ArticuloDatos datos = new ArticuloDatos();
            datos.Modificar(articulo);
        }

        public void Eliminar(int id)
        {
            ArticuloDatos datos = new ArticuloDatos();
            datos.Eliminar(id);
        }

        public List<Articulo> Filtrar(string filtro)
        {
            ArticuloDatos datos = new ArticuloDatos();
            return datos.Filtrar(filtro);
        }
    }
}
