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
        public formArticulo()
        {
            InitializeComponent();
        }

        private void formArticulo_Load(object sender, EventArgs e)
        {

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            try
            {
                nuevo.CodigoArticulo = int.Parse(txtCodigo.Text);
                nuevo.Nombre = txtNombre.Text;
               // nuevo.MarcaArticulo = txtMarca.Text;
               // nuevo.CategoriaArticulo = txtCategoria.Text;
                nuevo.Descripcion = txtDesc.Text;
                nuevo.Precio = double.Parse(txtPrecio.Text);
                artNegocio.agregar(nuevo);
                MessageBox.Show("Articulo agregado a el Catalogo");
                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    
    }
}
