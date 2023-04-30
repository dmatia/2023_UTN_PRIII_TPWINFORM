using Dominio;
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
            List<Articulo> lista = new List<Articulo>(); // crea una instancia de lista de Articulos
            AccesoDatos datos = new AccesoDatos();

            /// Seteo consulta de todos los elementos de la tabla integrada
            /// 
            try// manejo de excepciones al intentar acceder a DB
            {
                datos.setearConsulta("Select A.Id,Codigo,Nombre,Precio,A.Descripcion, M.Id as 'MarcasId', M.Descripcion as 'MarcasDescripcion', C.Descripcion as 'CategoriasDescripcion', C.Id as 'CategoriasId' from Articulos A left join Marcas M on M.Id=A.IdMarca left join Categorias C on C.Id =A.IdCategoria");
                datos.ejecutarLectura();
                // la query esta en Lector
                while ((datos.Lector.Read())) // Devuelve valor booleano y va cambiando el cursor
                {
                    Articulo aux = new Articulo(); // Crea una instancia de variable Articulo
                    aux.Id = (int)datos.Lector["Id"]; // Carga la Variable Articulo con los datos de la base de datos
                    aux.Codigo = (string)datos.Lector["Codigo"];                 //aux.= lector.GetInt32();
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"]; // validaciones sobre descripcion y otros
                    aux.Precio = (double)(decimal)datos.Lector["Precio"]; /// Ver tema del float y el casteo de money
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["MarcasId"];
                    aux.Marca.Descripcion = (string)datos.Lector["MarcasDescripcion"];
                    /// POR QUE EL OVERRIDE DE TOSTRING PRODUCE ESTO?
                    aux.Categoria = new Categoria();
                    if (!(datos.Lector["CategoriasDescripcion"] is DBNull))
                    {
                        aux.Categoria.Descripcion = (string)datos.Lector["CategoriasDescripcion"];
                    }
                    else
                    {
                        aux.Categoria.Descripcion = "...";
                    }
                    if (!(datos.Lector["CategoriasId"] is DBNull))
                    {
                        aux.Categoria.Id = (int)datos.Lector["Categoriasid"];
                    }

                    lista.Add(aux);// Agrega cada variable a la lista
                }

                return lista;// devuelve la lista
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                datos.cerrarConexion();
            }


        }
     



    }
}
