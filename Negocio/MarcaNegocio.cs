using Dominio;
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

        // METODO LISTAR TODAS LAS MARCAS EN DB
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDB datos = new AccesoDB();

            try
            {
                datos.setQuery("SELECT Id, Descripcion FROM Marcas");
                datos.executeReader();

                while (datos.Reader.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (Int32)datos.Reader["Id"];
                    if (datos.Reader["Descripcion"] != null)
                        aux.Descripcion = (string)datos.Reader["Descripcion"];
                    else
                        aux.Descripcion = "...";

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