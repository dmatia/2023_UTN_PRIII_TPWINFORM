using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
	public partial class Main : Form
	{
		private List<Articulo> listaArticulos = null;
		
		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, System.EventArgs e)
		{
			//Evita duplicar datos
			if (listaArticulos == null)
				cargarVentana();

		}

		//Metodos necesarios al momento de cargar la ventana
		private void cargarVentana()
		{
			ListarArticulos();
			CargarGridView();
		}

		// Método para cargar el data grid view con los datos de los artículos
		public void CargarGridView()
		{
			//Cargar el data grid view
			dgvListaArticulos.DataSource = listaArticulos;
			
			//Estilos del data grid view
			dgvListaArticulos.EnableHeadersVisualStyles = false;
			dgvListaArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			//No mostrar columnas
			dgvListaArticulos.Columns["Id"].Visible = false;
		}

		private void ListarArticulos()
		{
			try
			{
				ArticuloNegocio articulosNegocio = new ArticuloNegocio();
				listaArticulos = articulosNegocio.listar();
			}
			catch (Exception)
			{
				MessageBox.Show("Error al cargar listado de articulos");
			}
		}

		// Evento para agregar un articulo nuevo
		private void btnAgregar_Click(object sender, EventArgs e)
		{
			Articulos Screen = new Articulos();
			Screen.ShowDialog();
			
			//Si se realizaron cambios, cargar la lista de vuelta
			if(Screen.hayCambios)
			{
				cargarVentana();
			}
		}
		
		// Evento para ver detalle o modificar un articulo nuevo
		private void btnDetalle_Click(object sender, EventArgs e)
		{
			Articulos Screen = new Articulos((Articulo)dgvListaArticulos.CurrentRow.DataBoundItem);
			Screen.ShowDialog();
			
			//Si se realizaron cambios, cargar la lista de vuelta
			if (Screen.hayCambios)
			{
				cargarVentana();
			}
		}

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
			// verifica si ya hay una ventana de este tipo abierta para no abrir otra
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Categorias))
                    return;
            }
            Categorias categorias = new Categorias();
			categorias.MdiParent = this;
			categorias.Show();
        }
    }
}
