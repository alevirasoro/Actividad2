using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class Gestor : Form
    {
        private List<Articulo> listaArticulos;
        public Gestor()
        {
            InitializeComponent();

            pbArticulo.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                listaArticulos = articuloNegocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                //dgvArticulos.Columns["UrlImagen"].Visible = false;
                //dgvArticulos.Columns["Categoria"].Visible = false;

                RecargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void RecargarImagen(string img)
        {
            try
            {
                pbArticulo.Load(img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            formArticulo agregar = new formArticulo();
            agregar.ShowDialog();
        }

        private void dgvArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            RecargarImagen(seleccionado.UrlImagen);
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            if (seleccionado == null)
                return;

            formArticulo editar = new formArticulo(seleccionado);
            editar.ShowDialog();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string texto = txtFiltro.Text.ToLower();

            if (txtFiltro.Text != "")
            {
                List<Articulo> listaFiltrada = listaArticulos.FindAll(
                    X => X.Nombre.ToLower().Contains(texto));
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
            }
            else
            {
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaArticulos;
            }
        }
    }
}
