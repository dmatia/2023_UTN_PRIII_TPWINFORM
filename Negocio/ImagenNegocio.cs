using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ImagenNegocio
    {

        // METODO LISTAR - Busca por articulo 
        public List<Imagen> listar(string IdArticulo)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDB datos = new AccesoDB();

            try
            {
                datos.setQuery("SELECT Id, IdArticulo, ImagenUrl FROM Imagenes WHERE IdArticulo = " + IdArticulo);
                datos.executeReader();

                while (datos.Reader.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (Int32)datos.Reader["Id"];
                    aux.IdArticulo = (int)datos.Reader["IdArticulo"];

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
                datos.closeConnection();
            }
        }

    }
}