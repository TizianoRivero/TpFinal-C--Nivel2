using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_articulos
{
    public partial class FrmDetalleArticulo : Form
    {
        private Articulo articulo;
        public FrmDetalleArticulo()
        {
            InitializeComponent();
        }
        public FrmDetalleArticulo(Articulo seleccionado)
        {
            InitializeComponent();
            articulo = seleccionado;
        }

        private void FrmDetalleArticulo_Load(object sender, EventArgs e)
        {
            if (articulo != null)
            {
                lblCodigo.Text = articulo.Codigo;
                lblNombre.Text = articulo.Nombre;
                lblDescripcion.Text = articulo.Descripcion;
                lblMarca.Text = articulo.Marca.ToString();
                lblCategoria.Text = articulo.Categoria.ToString();
                lblPrecio.Text = articulo.Precio.ToString("C");

                try
                {
                    picImagen.Load(articulo.ImagenUrl);
                }
                catch
                {
                    picImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png"); // imagen fallback
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
