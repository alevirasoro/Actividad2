using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public void agregar(Articulo nuevo)
        {
            AccesoDB acceso = new AccesoDB();
            try
            {
                string valores = "values(" + nuevo.CodigoArticulo + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', '" + nuevo.UrlImagen + "','" + nuevo.Precio + "'";
                acceso.setearConsulta("insert into articulos (Codigo, Nombre, Descripcion, UrlImagen, Precio)" + valores);
                    }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }
        }
        public List<Articulo> listar()
        {
            AccesoDB acceso = new AccesoDB();
            List<Articulo> lista = new List<Articulo>();

            try
            {
                Articulo aux = new Articulo();
                aux.CodigoArticulo = 3;
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}