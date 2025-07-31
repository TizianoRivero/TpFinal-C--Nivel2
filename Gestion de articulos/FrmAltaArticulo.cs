using Dominio;
using Negocio;
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
    public partial class FrmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public FrmAltaArticulo()
        {
            InitializeComponent();
        }
        public FrmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }


        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.Listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = categoriaNegocio.Listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtUrlimagen.Text = articulo.ImagenUrl;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    CargarImagen(articulo.ImagenUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagen))
                    pbxAltaArticulo.LoadAsync(imagen); // tu PictureBox
                else
                    pbxAltaArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png"); // imagen local de respaldo
            }
            catch
            {
                pbxAltaArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                // cargamos los datos del form al objeto
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtUrlimagen.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if (articulo.Id != 0)
                {
                    negocio.Modificar(articulo);
                    MessageBox.Show("Artículo modificado con éxito!");
                }
                else
                {
                    negocio.Agregar(articulo);
                    MessageBox.Show("Artículo agregado con éxito!");
                }

                Close(); // cerramos el form después de guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUrlimagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtUrlimagen.Text);
        }
    }
}
