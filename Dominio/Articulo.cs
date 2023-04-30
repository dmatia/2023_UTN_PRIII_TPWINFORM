using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Articulo
    {
        public int Id { get; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public Double Precio { get; set; }

        public Articulo{
            this.Id = "";
            this.Codigo = "";
            this.Nombre = "";
            this.Descripcion = "";
            this.Marca = new Marca();
            this.Categoria = new Categoria();
            this.Double = "";
        }
}
