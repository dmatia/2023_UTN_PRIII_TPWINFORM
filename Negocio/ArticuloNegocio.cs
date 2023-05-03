using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
                // la seleccion esta en Lector
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
                        aux.Categoria.Descripcion = string.Empty;
                    }
                    if (!(datos.Reader["CategoriasId"] is DBNull))
                    {
                        aux.Categoria.Id = (int)datos.Reader["Categoriasid"];
                    }
                    else
                    {
                        aux.Categoria.Id = 0;
                    }

					//Cargar Imágenes
					ImagenNegocio imagenNegocio = new ImagenNegocio();
					aux.Imagenes = imagenNegocio.listar(aux.Id.ToString());

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

        //FILTRAR PRODUCTOS
        public List<Articulo> Filtrar (string Busqueda, string Filtroprimario, string Categoria, string Marca) /// reutilizarlas y combinarlas
        {
            // pasar las comparaciones a toupper
            List<Articulo> lista = new List<Articulo>(); // crea una instancia de lista de Articulos
            AccesoDB datos = new AccesoDB();
            
            string select = "Select A.Id,Codigo,Nombre,Precio, A.Descripcion, M.Id as 'MarcasId', M.Descripcion as 'MarcasDescripcion', C.Descripcion as 'CategoriasDescripcion', C.Id as 'CategoriasId' from Articulos A left join Marcas M on M.Id=A.IdMarca left join Categorias C on C.Id =A.IdCategoria ";
            string Restriccion="";
            /// Seteo consulta de todos los elementos de la tabla integrada
            try// manejo de excepciones al intentar acceder a DB
            {
              
                if (Filtroprimario == "Nombre" || Filtroprimario == "Codigo" || Filtroprimario == "Descripcion")
                {
                    if (Filtroprimario == "Descripcion") // SI ES DESCRIPCION HAY QUE CAMBIAR LA QUERY
                    {
                        Restriccion = "where A.Descripcion like '%" + Busqueda + "%'";

                        // SI CATEGORIAS O MARCAS CAMBIO EL TEXTO AGREGA RESTRICCION        
                        if (Categoria != "Categorias")
                        {

                            Restriccion += " and C.Descripcion like '" + Categoria + "'";

                        }
                        if (Marca != "Marcas")
                        {

                            Restriccion += " and M.Descripcion like '" + Marca + "'";

                        }
                       
                    }
                    else // SI NO ES DESCRIPCION SE USA EL NOMBRE DEL FILTRO EN LA QUERY
                    {

                        Restriccion = "where " + Filtroprimario + " like '%" + Busqueda + "%'";
                        
                        // SI CATEGORIAS O MARCAS CAMBIO EL TEXTO AGREGA RESTRICCION
                        if (Categoria != "Categorias")
                        {

                            Restriccion += " and C.Descripcion like '" + Categoria + "'";

                        }
                        if (Marca != "Marcas")
                        {

                            Restriccion += " and M.Descripcion like '" + Marca + "'";

                        }
                        
                    }


                }
                else if(Filtroprimario=="Precio mayor a")
                {

                    Restriccion += "where Precio > " + Busqueda;
                   
                    if (Categoria != "Categorias")
                    {

                        Restriccion += " and C.Descripcion like '" + Categoria + "'";

                    }
                    if (Marca != "Marcas")
                    {

                        Restriccion += " and M.Descripcion like '" + Marca + "'";

                    }

                }
                else {

                    Restriccion += "where Precio < " + Busqueda;
                    if (Categoria != "Categorias")
                    {

                        Restriccion += " and C.Descripcion like '" + Categoria + "'";

                    }
                    if (Marca != "Marcas")
                    {

                        Restriccion += " and M.Descripcion like '" + Marca + "'";

                    }
                }
                

                datos.setQuery(select+Restriccion);
                datos.executeReader();
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
                        aux.Categoria.Descripcion = string.Empty;
                    }
                    if (!(datos.Reader["CategoriasId"] is DBNull))
                    {
                        aux.Categoria.Id = (int)datos.Reader["Categoriasid"];
                    }
                    else
                    {
                        aux.Categoria.Id = 0;
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


/*
             if (Filtroprimario == "Nombre")
             {
                 switch (criterio)
                 {
                     case "Mayor a":
                         consulta += "Numero > " + filtro;
                         break;
                     case "Menor a":
                         consulta += "Numero < " + filtro;
                         break;
                     default:
                         consulta += "Numero = " + filtro;
                         break;
                 }
             }
             else if (campo == "Nombre")
             {
                 switch (criterio)
                 {
                     case "Comienza con":
                         consulta += "Nombre like '" + filtro + "%' ";
                         break;
                     case "Termina con":
                         consulta += "Nombre like '%" + filtro + "'";
                         break;
                     default:
                         consulta += "Nombre like '%" + filtro + "%'";
                         break;
                 }
             }
             else
             {
                 switch (criterio)
                 {
                     case "Comienza con":
                         consulta += "P.Descripcion like '" + filtro + "%' ";
                         break;
                     case "Termina con":
                         consulta += "P.Descripcion like '%" + filtro + "'";
                         break;
                     default:
                         consulta += "P.Descripcion like '%" + filtro + "%'";
                         break;
                 }
             }


           datos.setQuery(
           datos.setearConsulta(consulta);
             datos.ejecutarLectura();
             while (datos.Lector.Read())
             {
                 Pokemon aux = new Pokemon();
                 aux.Id = (int)datos.Lector["Id"];
                 aux.Numero = datos.Lector.GetInt32(0);
                 aux.Nombre = (string)datos.Lector["Nombre"];
                 aux.Descripcion = (string)datos.Lector["Descripcion"];
                 if (!(datos.Lector["UrlImagen"] is DBNull))
                     aux.UrlImagen = (string)datos.Lector["UrlImagen"];

                 aux.Tipo = new Elemento();
                 aux.Tipo.Id = (int)datos.Lector["IdTipo"];
                 aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                 aux.Debilidad = new Elemento();
                 aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
                 aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];

                 lista.Add(aux);
             }
           */
