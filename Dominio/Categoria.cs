using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria : IAtributos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }

        public Categoria()
        {
            this.Id = -1;
            this.Descripcion = string.Empty;
        }
    }
}
