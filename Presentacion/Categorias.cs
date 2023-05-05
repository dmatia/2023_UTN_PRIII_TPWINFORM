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
    public partial class Categorias : Form
    {
        private List<IAtributos> listaCategorias;
		
		//Atributo
		private string atributo;
		private IAtributosNegocio iAtributosNegocio;
		
		public Categorias(string atributo)
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
			
				listarCategorias();
        }


        // Lista completa de categorias 
        private void listarCategorias()
        {
            
            listaCategorias = iAtributosNegocio.listar();
            dgvCategorias.DataSource = iAtributosNegocio.listar();
            //Estilos del data grid view
            dgvCategorias.EnableHeadersVisualStyles = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbxFiltrar.Text = "Ingrese búsqueda";
            listarCategorias();
        }


        // MODIFICAR SELECCIONADO DEL GRID
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            if (dgvCategorias == null || dgvCategorias.Rows.Count == 0)
            {
                MessageBox.Show("SIN REGISTROS");
            }
            else
            {
                ModificarCategoria modificarCategoria = new ModificarCategoria();
                modificarCategoria.setIdCategoria((int)dgvCategorias.CurrentRow.Cells[0].Value);
                modificarCategoria.setDescripcionCategoria((string)dgvCategorias.CurrentRow.Cells[1].Value);
                modificarCategoria.Show();
                listarCategorias();
            }
        }


        // ELIMINAR SELECCIONADO DEL GRID

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            IAtributos eliminar = null;

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
                if (dgvCategorias == null || dgvCategorias.Rows.Count == 0)
                    {
                    MessageBox.Show("SIN REGISTROS");
                    }
                else
                {
                    try
                    {
                        if (MessageBox.Show("¿ELIMINAR REGISTRO?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DefaultButton) == DialogResult.Yes)
                            eliminar = (IAtributos)dgvCategorias.CurrentRow.DataBoundItem;
						iAtributosNegocio.eliminar(eliminar);
                        listarCategorias();

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("SIN REGISTROS");
                    }
                }               
            }
        }


        // AGREGAR NUEVA CATEGORIA

        // validaciones sobre textbox nueva categoria
        private void txtbxNuevaCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
                e.Handled = true;
        }
        private void agregarTextoDefault()
        {
            txtbxNuevaCategoria.Text = "Ingrese su nueva categoria";
        }
        private void txtbxNuevaCategoria_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtbxNuevaCategoria.Text != "")
                txtbxNuevaCategoria.Text = "";
        }
        private void txtbxNuevaCategoria_MouseLeave(object sender, EventArgs e)
        {
            if (txtbxNuevaCategoria.Text == "")
            {
                agregarTextoDefault();
            }
        }
        // verificar textxbox, guardar categoria
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!(txtbxNuevaCategoria.Text == "" || txtbxNuevaCategoria.Text == "Ingrese su nueva categoria"))
            {
				IAtributos iatributo = null;

				if (this.atributo == "Marca")
				{
					iatributo = new Marca();
				}
				else if (this.atributo == "Categoria")
				{
					iatributo = new Categoria();
				}

				iatributo.Descripcion = txtbxNuevaCategoria.Text;

                
                if (iAtributosNegocio.agregar(iatributo))
                    MessageBox.Show("CATEGORIA AGREGADA CORRECTAMENTE");
                else
                    MessageBox.Show("ERROR AL GUARDAR CATEGORIA");
                agregarTextoDefault();
                listarCategorias();
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
            List<IAtributos> listaFiltrada;
            string filtro = txbxFiltrar.Text;
            if (!(filtro == "") && !(filtro == "Ingrese búsqueda"))
            {
                listaFiltrada = listaCategorias.FindAll(categoriaBuscada => categoriaBuscada.Descripcion.ToLower().Contains(filtro.ToLower())
                                                                         || categoriaBuscada.Id.ToString().ToLower() == filtro.ToLower());
                dgvCategorias.DataSource = null;
                dgvCategorias.DataSource = listaFiltrada;
            }
        }

        private void txbxFiltrar_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void txbxFiltrar_DoubleClick(object sender, EventArgs e)
        {
            if (!(txbxFiltrar.Text == "") || !(txbxFiltrar.Text == "Ingrese búsqueda"))
            {
                txbxFiltrar.Text = "";
                listarCategorias();
            }
        }

        private void txbxFiltrar_MouseLeave(object sender, EventArgs e)
        {
            if ((txbxFiltrar.Text == "") || !(txbxFiltrar.Text != "Ingrese búsqueda"))
            {
                txbxFiltrar.Text = "Ingrese búsqueda";
            }
            listarCategorias();
        }
    }
}
