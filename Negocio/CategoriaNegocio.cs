using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {

        // METODO LISTAR TODAS LAS CATEGORIAS EN DB
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDB datos = new AccesoDB();

            try
            {
                datos.setQuery("SELECT Id, Descripcion FROM Categorias");
                datos.executeReader();

                while (datos.Reader.Read())
                {
                    Categoria aux = new Categoria();
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


        //  METODO AGREGAR NUEVA CATEGORIA
        public bool agregar(Categoria nueva)
        {
            AccesoDB datos = new AccesoDB();

            try
            {
                datos.setQuery("Insert into CATEGORIAS (Descripcion) values ('" + nueva.Descripcion + "')");
                if (datos.executeNonQuery())
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.closeConnection();
            }
            return false;
        }

        // METODO ELIMINAR CATEGORIA

        public bool eliminar(String id)
        {
            AccesoDB datos = new AccesoDB();

            try
            {
                datos.setQuery("DELETE CATEGORIAS WHERE Id = " + id);
                if (datos.executeNonQuery())
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.closeConnection();
            }
            return false;
        }


    }
}