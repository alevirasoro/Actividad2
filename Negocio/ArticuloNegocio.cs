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
                string valores = "values('"+ nuevo.CodigoArticulo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', '" + nuevo.UrlImagen + "','" + nuevo.Precio + "', 1, 1)";
                acceso.setearConsulta("insert into articulos (Codigo, Nombre, Descripcion, ImagenUrl, Precio, IdMarca, IdCategoria) " + valores);

                acceso.ejecutarAccion();
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
        public void eliminar(Articulo articulo)
        {
            AccesoDB acceso = new AccesoDB();
            try
            {
                acceso.setearConsulta(
                    "delete from articulos where codigo = '" +
                    articulo.CodigoArticulo + "';");
                acceso.ejecutarAccion();
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
        public void editar(Articulo articulo)
        {
            AccesoDB acceso = new AccesoDB();

            try
            {
                acceso.setearConsulta("update articulos set " +
                    "Nombre = '" +
                    articulo.Nombre +
                    "', Descripcion = '" +
                    articulo.Descripcion +
                    "', ImagenUrl = '" +
                    articulo.UrlImagen +
                    "', Precio = " +
                    articulo.Precio.ToString() +
                    //", IdMarca = (select ID from MARCAS where " +
                    //articulo.MarcaArticulo +
                    //", IdCategoria = '" +
                    //articulo.CategoriaArticulo +
                    " where Codigo = '" +
                    articulo.CodigoArticulo + "';");

                acceso.ejecutarAccion();
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
                acceso.setearConsulta(
                    "select A.Codigo Codigo, " +
                    "A.Nombre Nombre, A.Descripcion, A.ImagenUrl, A.Precio, " +
                    "M.Descripcion Marca, C.Descripcion Categoria " +
                    "from ARTICULOS A " +
                    "inner join MARCAS as M " +
                    "on A.IdMarca = M.Id " +
                    "inner join CATEGORIAS as C " +
                    "on A.IdCategoria = C.Id");

                acceso.ejecutarLectura();

                while (acceso.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.CodigoArticulo = (string)acceso.Lector["Codigo"];
                    aux.Nombre = (string)acceso.Lector["Nombre"];
                    aux.Descripcion = (string)acceso.Lector["Descripcion"];
                    aux.UrlImagen = (string)acceso.Lector["ImagenUrl"];
                    aux.Precio = (decimal)acceso.Lector["Precio"];
                    aux.MarcaArticulo = new Marca((string)acceso.Lector["Marca"]);
                    aux.CategoriaArticulo = new Categoria((string)acceso.Lector["Categoria"]);
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