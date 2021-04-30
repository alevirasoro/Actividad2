using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

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
                acceso.setearConsulta("select Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio from ARTICULOS A");
                acceso.ejecutarLectura();
                while (acceso.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.CodigoArticulo = (string)acceso.Lector["Codigo"];
                    aux.Nombre = (string)acceso.Lector["Nombre"];
                    aux.Descripcion = (string)acceso.Lector["Descripcion"];
                    aux.UrlImagen = (string)acceso.Lector["ImagenUrl"];
                    aux.Precio = (decimal)acceso.Lector["Precio"];
                    lista.Add(aux);
                }
                return lista;
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
    }
}