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
    public partial class Gestor : Form
    {
        public Gestor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<Articulo> listaArticulos = new List<Articulo>();
                Articulo art = new Articulo();
                art.CodigoArticulo = 3;
                art.Descripcion = "Articulo descp";
                art.Nombre = "Tornillo";
                art.UrlImagen = "https://cdn.homedepot.com.mx/productos/239166/239166-d.jpg";

                listaArticulos.Add(art);
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["UrlImagen"].Visible = false;

              //  RecargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
