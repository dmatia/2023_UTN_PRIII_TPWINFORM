using System;
using System.Collections.Generic;
using System.Globalization;
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
            AccesoDB datos = new AccesoDB();

            /// Seteo consulta de todos los elementos de la tabla integrada

            try// manejo de excepciones al intentar acceder a DB
            {
                datos.setQuery("Select A.Id,Codigo,Nombre,Precio,A.Descripcion, M.Id as 'MarcasId', M.Descripcion as 'MarcasDescripcion', C.Descripcion as 'CategoriasDescripcion', C.Id as 'CategoriasId' from Articulos A left join Marcas M on M.Id=A.IdMarca left join Categorias C on C.Id =A.IdCategoria");
                datos.executeReader();
                // la query esta en Lector
                while ((datos.Reader.Read())) // Devuelve valor booleano y va cambiando el cursor
                {
                    Articulo aux = new Articulo(); // Crea una instancia de variable Articulo
                    aux.Id = (int)datos.Reader["Id"]; // Carga la Variable Articulo con los datos de la base de datos
                    aux.Codigo = (string)datos.Reader["Codigo"];                 //aux.= lector.GetInt32();
                    aux.Nombre = (string)datos.Reader["Nombre"];
                    aux.Descripcion = (string)datos.Reader["Descripcion"]; // validaciones sobre descripcion y otros
                    aux.Precio = (double)(decimal)datos.Reader["Precio"]; /// Ver tema del float y el casteo de money
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Reader["MarcasId"];
                    aux.Marca.Descripcion = (string)datos.Reader["MarcasDescripcion"];
                    /// POR QUE EL OVERRIDE DE TOSTRING PRODUCE ESTO?
                    aux.Categoria = new Categoria();
                    if (!(datos.Reader["CategoriasDescripcion"] is DBNull))
                    {
                        aux.Categoria.Descripcion = (string)datos.Reader["CategoriasDescripcion"];
                    }
                    else
                    {
                        aux.Categoria.Descripcion = "...";
                    }
                    if (!(datos.Reader["CategoriasId"] is DBNull))
                    {
                        aux.Categoria.Id = (int)datos.Reader["Categoriasid"];
                    }

					//Cargar Imágenes

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
                datos.closeConnection();
            }
        }

		//AGREGAR PRODUCTOS
		public bool agregar(Articulo articulo)
		{
			AccesoDB datoSQL = new AccesoDB();

			try
			{
				datoSQL.setQuery
				 (
					$"INSERT INTO ARTICULOS " +
					$"(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
					$"VALUES('{articulo.Codigo}', '{articulo.Nombre}', '{articulo.Descripcion}', {articulo.Marca.Id}, {articulo.Categoria.Id}, {articulo.Precio.ToString(new CultureInfo("en-US"))})"
				);

				if (datoSQL.executeNonQuery())
				{
					datoSQL.closeConnection();
					return true;
				}
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				datoSQL.closeConnection();
			}

			return false;
		}

		//MODIFICAR PRODUCTOS
		public bool modificar(Articulo articulo)
		{
			AccesoDB datoSQL = new AccesoDB();
			try
			{
				datoSQL.setQuery(
				"UPDATE ARTICULOS " +
				$"SET Codigo = '{articulo.Codigo}', Nombre = '{articulo.Nombre}', Descripcion = '{articulo.Descripcion}', " +
				$"Precio = {articulo.Precio.ToString(new CultureInfo("en-US"))}, IdMarca = {articulo.Marca.Id}, IdCategoria = {articulo.Categoria.Id} " +
				$"WHERE Id = {articulo.Id}"
				);
				if (datoSQL.executeNonQuery())
				{
					datoSQL.closeConnection();
					return true;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				datoSQL.closeConnection();
			}
			return false;
		}

		//TODO: ELIMINAR PRODUCTO

	}
}
