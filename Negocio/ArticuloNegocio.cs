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
        public List<Articulo> listar()
        {
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