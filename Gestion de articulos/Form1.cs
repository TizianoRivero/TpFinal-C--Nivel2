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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarArticulos();
        }
        private void CargarArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.Listar();
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                if (seleccionado != null && !string.IsNullOrEmpty(seleccionado.ImagenUrl))
                {
                    try
                    {
                        pbxGestion.Load(seleccionado.ImagenUrl);
                    }
                    catch
                    {
                        pbxGestion.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                    }
                }
                else
                {
                    pbxGestion.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo alta = new FrmAltaArticulo();
            alta.ShowDialog();
            CargarArticulos(); // recarga la lista después de agregar
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    FrmAltaArticulo modificar = new FrmAltaArticulo(seleccionado);
                    modificar.ShowDialog();
                    CargarArticulos(); // refrescar lista después de modificar
            }
            else
            {
                    MessageBox.Show("Por favor seleccioná un artículo para modificar.");
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                FrmDetalleArticulo detalle = new FrmDetalleArticulo(seleccionado);
                detalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccioná un artículo primero.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show("¿Estás seguro de que querés eliminar este artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    negocio.Eliminar(seleccionado.Id);
                    CargarArticulos(); // Método para recargar la grilla con artículos
                }
            }
            else
            {
                MessageBox.Show("Primero seleccioná un artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(filtro))
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                dgvArticulos.DataSource = negocio.Filtrar(filtro);
            }
            else
            {
                CargarArticulos(); 
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            ArticuloNegocio negocio = new ArticuloNegocio();

            if (!string.IsNullOrEmpty(filtro))
                dgvArticulos.DataSource = negocio.Filtrar(filtro);
            else
                CargarArticulos();
        }
    }
}
