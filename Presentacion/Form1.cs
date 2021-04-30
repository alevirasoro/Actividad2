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
        public Gestor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> listaArticulos = new List<Articulo>();

                listaArticulos = articuloNegocio.listar();
                dgvArticulos.DataSource = listaArticulos;
            
        }
        private void RecargarImagen(string img)
        {
            pbArticulo.Load(img);
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            formArticulo agregar = new formArticulo();
            agregar.ShowDialog();
        }
    }
}
