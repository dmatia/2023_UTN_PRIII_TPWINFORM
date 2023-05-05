using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
	public interface IAtributosNegocio
	{
		List<IAtributos> listar();
		bool agregar(IAtributos atributo);
		bool modificar(IAtributos atributos);
		bool eliminar(IAtributos atributos);
	}
}
