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

namespace Presentacion
{
    public partial class formArticulo : Form
    {
        private Articulo articulo = null;
        public formArticulo()
        {
            InitializeComponent();

            Text = "Agregar Artículo";

            txtCodigo.Enabled = true;
        }
        public formArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }
        private void formArticulo_Load(object sender, EventArgs e)
        {

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
               // cboMarca.ValueMember;
                if(articulo != null)
                {
                    txtCodigo.Text = articulo.CodigoArticulo;
                    txtNombre.Text = articulo.Nombre;
                    txtDesc.Text = articulo.Descripcion;
                    txtUrl.Text = articulo.UrlImagen;
                    
                    txtPrecio.Text = articulo.Precio.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            bool es_nuevo = articulo == null;

            if (es_nuevo)
            {
                // El artículo no existía antes: crear el objeto
                articulo = new Articulo();
            }

            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar un código de artículo.");
                return;
            }
            else
            {
                articulo.CodigoArticulo = txtCodigo.Text;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("El artículo precisa de un nombre.");
                return;
            }
            else
            {
                articulo.Nombre = txtNombre.Text;
            }
            // nuevo.CategoriaArticulo = txtCategoria.Text;
            if (txtDesc.Text == "")
            {
                MessageBox.Show("Se necesita una descripción para el artículo.");
                return;
            }
            else
            {
                articulo.Descripcion = txtDesc.Text;
            }
            try
            {
                articulo.Precio = decimal.Parse(txtPrecio.Text);
            }
            catch
            {
                MessageBox.Show("El valor seleccionado como precio no es un número válido.");
                return;
            }
            if (txtUrl.Text == "")
            {
                MessageBox.Show("Se debe indicar una imagen de Internet.");
                return;
            }
            else
            {
                articulo.UrlImagen = txtUrl.Text;
            }

            articulo.MarcaArticulo = (Marca)cboMarca.SelectedItem;

            ArticuloNegocio artNegocio = new ArticuloNegocio();

            if (es_nuevo)
            {
                try
                {
                    artNegocio.agregar(articulo);
                    MessageBox.Show("Fue agregado el artículo al catálogo.");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    Close();
                }
            }
            else
            {
                try
                {
                    artNegocio.editar(articulo);
                    MessageBox.Show("Se ha modificado el artículo en el catálogo.");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Close();
                }
            }
        }
    }
}
