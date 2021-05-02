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
        public Marca DesdeID(int ID)
        {
            AccesoDB acceso = new AccesoDB();
            acceso.setearConsulta(
                "select descripcion from MARCAS where id = '" +
                ID + "';");
            acceso.ejecutarLectura();
            Marca marca = new Marca();
            marca.IdMarca = ID;
            acceso.Lector.Read();
            marca.Nombre = (string)acceso.Lector["Descripcion"];
            acceso.cerrarConexion();

            return marca;
        }
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
