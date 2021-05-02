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
            txtCodigo.CharacterCasing = CharacterCasing.Upper;
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

                MessageBox.Show(ex.ToString(), "Error al cargar los artículos");
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
                MessageBox.Show("Debe ingresar un código de artículo.", "Error");
                return;
            }
            else
            {
                articulo.CodigoArticulo = txtCodigo.Text;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("El artículo precisa de un nombre.", "Error");
                return;
            }
            else
            {
                articulo.Nombre = txtNombre.Text;
            }
            /*
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Elegir la categoría del artículo.", "Error");
                return;
            }
            else
            {
                articulo.CategoriaArticulo = comboBox1.Text;
            }
            */
            if (txtDesc.Text == "")
            {
                MessageBox.Show("Se necesita una descripción para el artículo.", "Error");
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
                MessageBox.Show("El valor seleccionado como precio no es un número válido.", "Error");
                return;
            }

            articulo.UrlImagen = txtUrl.Text;

            //MarcaNegocio marcaNegocio = new MarcaNegocio();

            //articulo.MarcaArticulo = marcaNegocio.DesdeNombre(
            //    cboMarca.SelectedIndex.ToString());

            /*if (articulo.MarcaArticulo == "")
            {
                MessageBox.Show("Seleccione una marca de la lista desplegable.");
                return;
            }
            */

            ArticuloNegocio artNegocio = new ArticuloNegocio();

            if (es_nuevo)
            {
                try
                {
                    artNegocio.agregar(articulo);
                    MessageBox.Show("Se ha agregado el artículo al catálogo.");
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
