using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
      public class MarcaNegocio
      {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDB acceso = new AccesoDB();
            try
            {
                acceso.setearConsulta("select id, descripcion from MARCAS");
                acceso.ejecutarLectura();

                while (acceso.Lector.Read())
                {
                    lista.Add(new Marca((int)acceso.Lector["id"], (string)acceso.Lector["Descripcion"]));
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
