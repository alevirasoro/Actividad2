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
        }
        public formArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
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
                    txtNombre.Text = articulo.Nombre;
                    txtDesc.Text = articulo.Descripcion;
                    txtUrl.Text = articulo.UrlImagen;
                  //  txtPrecio = articulo.Precio;

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
            Articulo nuevo = new Articulo();
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            nuevo.CodigoArticulo = txtCodigo.Text;
            nuevo.Nombre = txtNombre.Text;
            // nuevo.CategoriaArticulo = txtCategoria.Text;
            nuevo.Descripcion = txtDesc.Text;
            nuevo.Precio = decimal.Parse(txtPrecio.Text);
            nuevo.UrlImagen = txtUrl.Text;
            nuevo.MarcaArticulo = (Marca)cboMarca.SelectedItem;
            try
            {
                artNegocio.agregar(nuevo);
                MessageBox.Show("Articulo agregado al Catalogo");
            }
            catch (Exception)
            {

                throw;
            }
        }
    
    }
}
