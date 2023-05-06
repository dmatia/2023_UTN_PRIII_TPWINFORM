using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class IAtributos : Form
    {
        private List<IAtributo> listaAtributos;
		
		//Atributo
		private string atributo;
		private IAtributosNegocio iAtributosNegocio;
		
		public IAtributos(string atributo)
        {
			InitializeComponent();
			
			//Determinar si es categoria o marca
			this.atributo = atributo;
			
        }
        private void Categorias_Load(object sender, EventArgs e)
        {
			//Deterinar carga de negocio

		    if(this.atributo == "Marca")
            {
				this.iAtributosNegocio = new MarcaNegocio();
			}
            else if (this.atributo == "Categoria")
            {
				this.iAtributosNegocio = new CategoriaNegocio();
			}
			
				listarAtributos();
        }


        // Lista completa de categorias 
        private void listarAtributos()
        {
            
            listaAtributos = iAtributosNegocio.listar();
            dgvAtributos.DataSource = iAtributosNegocio.listar();
            //Estilos del data grid view
            dgvAtributos.EnableHeadersVisualStyles = false;
            dgvAtributos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbxFiltrarAtributos.Text = "Ingrese búsqueda";
            listarAtributos();
        }


        // MODIFICAR SELECCIONADO DEL GRID
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            if (dgvAtributos == null || dgvAtributos.Rows.Count == 0)
            {
                MessageBox.Show("SIN REGISTROS");
            }
            else
            {
                IAtributo iAtributos = null;
				
				if (this.atributo == "Marca")
				{
					iAtributos = new Marca();
				}
				else if (this.atributo == "Categoria")
				{
					iAtributos = new Categoria();
				}
				
                iAtributos.Id = (int)dgvAtributos.CurrentRow.Cells[0].Value;
                iAtributos.Descripcion = (string)dgvAtributos.CurrentRow.Cells[1].Value;

				ModificarAtributos modificarAtributo = new ModificarAtributos(iAtributos, iAtributosNegocio);
                //modificarCategoria.setIdCategoria((int)dgvCategorias.CurrentRow.Cells[0].Value);
                //modificarCategoria.setDescripcionCategoria((string)dgvCategorias.CurrentRow.Cells[1].Value);
                modificarAtributo.ShowDialog();
                listarAtributos();
            }
        }


        // ELIMINAR SELECCIONADO DEL GRID

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            IAtributo eliminar = null;

			if (this.atributo == "Marca")
			{
				eliminar = new Marca();
			}
			else if (this.atributo == "Categoria")
			{
				eliminar = new Categoria();
			}

            MessageBoxDefaultButton DefaultButton = MessageBoxDefaultButton.Button1;
             {          
                if (dgvAtributos == null || dgvAtributos.Rows.Count == 0)
                    {
                    MessageBox.Show("SIN REGISTROS");
                    }
                else
                {
                    try
                    {
                        if (MessageBox.Show("¿ELIMINAR "+ atributo.ToUpper() + "?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DefaultButton) == DialogResult.Yes)
                            eliminar = (IAtributo)dgvAtributos.CurrentRow.DataBoundItem;
						iAtributosNegocio.eliminar(eliminar);
                        listarAtributos();

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("SIN REGISTROS");
                    }
                }               
            }
        }


        // AGREGAR NUEVO ATRIBUTO

        // validaciones sobre textbox nuevo atributo

        private void agregarTextoDefault()
        {
            txtbxNuevoAtributo.Text = "Ingrese un valor";
        }
        private void txtbxNuevoAtributo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtbxNuevoAtributo.Text != "")
                txtbxNuevoAtributo.Text = "";
        }

        private void txtbxNuevoAtributo_MouseLeave(object sender, EventArgs e)
        {
            if (txtbxNuevoAtributo.Text == "")
            {
                agregarTextoDefault();
            }
        }


        // verificar textxbox, guardar atributo
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!(txtbxNuevoAtributo.Text == "" || txtbxNuevoAtributo.Text == "Ingrese un valor"))
            {
				IAtributo iatributo = null;

				if (this.atributo == "Marca")
				{
					iatributo = new Marca();
				}
				else if (this.atributo == "Categoria")
				{
					iatributo = new Categoria();
				}

				iatributo.Descripcion = txtbxNuevoAtributo.Text;

                
                if (iAtributosNegocio.agregar(iatributo))
                    MessageBox.Show(atributo.ToUpper() + " AGREGADA CORRECTAMENTE");
                else
                    MessageBox.Show("ERROR AL GUARDAR" + atributo.ToUpper());
                agregarTextoDefault();
                listarAtributos();
            }
            else
                MessageBox.Show("Ingrese un valor");
        }
        // cancelar nueva categoria, resetear textbox
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            agregarTextoDefault();
        }


        // CERRAR VENTANA CATEGORIAS
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        // FILTRO
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            List<IAtributo> listaFiltrada;
            string filtro = txbxFiltrarAtributos.Text;
            if (!(filtro == "") && !(filtro == "Ingrese búsqueda"))
            {
                listaFiltrada = listaAtributos.FindAll(categoriaBuscada => categoriaBuscada.Descripcion.ToLower().Contains(filtro.ToLower())
                                                                         || categoriaBuscada.Id.ToString().ToLower() == filtro.ToLower());
                dgvAtributos.DataSource = null;
                dgvAtributos.DataSource = listaFiltrada;
            }
        }

        private void txbxFiltrar_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void txbxFiltrar_DoubleClick(object sender, EventArgs e)
        {
            if (!(txbxFiltrarAtributos.Text == "") || !(txbxFiltrarAtributos.Text == "Ingrese búsqueda"))
            {
                txbxFiltrarAtributos.Text = "";
                listarAtributos();
            }
        }

        private void txbxFiltrar_MouseLeave(object sender, EventArgs e)
        {
            if ((txbxFiltrarAtributos.Text == "") || !(txbxFiltrarAtributos.Text != "Ingrese búsqueda"))
            {
                txbxFiltrarAtributos.Text = "Ingrese búsqueda";
                listarAtributos();
            }
            
        }
    }
}
