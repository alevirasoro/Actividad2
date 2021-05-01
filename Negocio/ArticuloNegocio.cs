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
                //ESTO PUEDE O DEBERIA SER EN UNA LINEA,
                //POR CLARIDAD SE CONCATENA EN 2

                string valores = "values('"+ nuevo.CodigoArticulo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', '" + nuevo.UrlImagen + "','" + nuevo.Precio + "', 1, 1)";
                acceso.setearConsulta("insert into articulos (Codigo, Nombre, Descripcion, ImagenUrl, Precio, IdMarca, IdCategoria)" + valores);

                acceso.ejectutarAccion();
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
                acceso.setearConsulta("select Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, M.Descripcion Marca, C.Descripcion Categoria from ARTICULOS A, MARCAS M, CATEGORIAS C Where A.IdMarca = M.Id and A.IdCategoria = C.Id");
                acceso.ejecutarLectura();
                while (acceso.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.CodigoArticulo = (string)acceso.Lector["Codigo"];
                    aux.Nombre = (string)acceso.Lector["Nombre"];
                    aux.MarcaArticulo = new Marca((string)acceso.Lector["Marca"]);
                    aux.CategoriaArticulo = new Categoria((string)acceso.Lector["Categoria"]);
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