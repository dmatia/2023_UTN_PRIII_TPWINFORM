using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class ModificarAtributos : Form
    {
        private IAtributo iAtributo;
		private IAtributosNegocio iAtributoNegocio;

		//public void setIdCategoria(int id)
		//{
		//    categoriaModificar.Id = id;
		//}
		//public void setDescripcionCategoria(string descripcion)
		//{
		//    categoriaModificar.Descripcion = descripcion;
		//}

		public ModificarAtributos(IAtributo iAtributo, IAtributosNegocio iAtributoNegocio)
        {
            InitializeComponent();
            this.iAtributo = iAtributo;
			this.iAtributoNegocio = iAtributoNegocio;
		}

        private void cargarDatos()
        {
            lblId.Text = iAtributo.Id.ToString();
            lblDescripcion.Text = iAtributo.Descripcion.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModificarCategoria_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!(txbxNuevaDescripcion.Text == "doble click aquí" || txbxNuevaDescripcion.Text == ""))
            {
				iAtributo.Descripcion = txbxNuevaDescripcion.Text;

                if (iAtributoNegocio.modificar(iAtributo))
                {
                    MessageBox.Show("CATEGORIA MODIFICADA");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ERROR");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("INGRESE UN VALOR");
            }
        }

        private void txbxNuevaDescripcion_DoubleClick(object sender, EventArgs e)
        {
            txbxNuevaDescripcion.Text = "";
        }
    }
}
