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
        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
          listarCategorias();
        }

        // Lista completa de categorias 
        private void listarCategorias()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            dgvCategorias.DataSource = categoriaNegocio.listar();
            //Estilos del data grid view
            dgvCategorias.EnableHeadersVisualStyles = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

 

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbxFiltrar.Text = "Ingrese búsqueda";
            listarCategorias();
        }



        // ELIMINAR SELECCIONADO DEL GRID

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBoxDefaultButton DefaultButton = MessageBoxDefaultButton.Button1;
            if (MessageBox.Show("¿SEGURO QUE DESEA ELIMINAR EL REGISTRO?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DefaultButton) == DialogResult.Yes)
            {
                CategoriaNegocio RegistroEliminar = new CategoriaNegocio();
                RegistroEliminar.eliminar(dgvCategorias.CurrentRow.Cells[0].Value.ToString());
                listarCategorias();
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
            if(txtbxNuevaCategoria.Text == "")
            {
               agregarTextoDefault();
            }
        }

            // verificar textxbox, guardar categoria
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!(txtbxNuevaCategoria.Text == "" || txtbxNuevaCategoria.Text == "Ingrese su nueva categoria"))
            {
                Categoria categoria = new Categoria();
                categoria.Descripcion = txtbxNuevaCategoria.Text;

                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                if (categoriaNegocio.agregar(categoria))
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
    }
}
