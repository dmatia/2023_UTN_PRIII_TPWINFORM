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
	public partial class Articulos : Form
	{
		private Articulo articulo = null;

		//Banderas de vistas
		private bool esModificar;
		private bool esAgregar;
		
		//Constructor para los casos de vista y modificación de artículo
		public Articulos(Articulo articulo, bool esModificar = false)
		{
			InitializeComponent();

			if (articulo != null)
			{
				this.articulo = articulo;
			}

			this.esModificar = esModificar;

			//Sete la ventana en modo modificar
			ModoModificar(this.esModificar);

			//Carga los datos del artículo en la ventana
			CargarArticulo();
		}

		//Constructor para el caso de agregar artículo
        public Articulos(bool esAgregar = true)
		{
			InitializeComponent();

			this.esAgregar = esAgregar;

			ModoAgregar(this.esAgregar);

		}

		//Evento de carga inicial de la ventana
		private void Articulos_Load(object sender, EventArgs e)
		{
			//Carga los combo box de categorías y marcas
			CargarComboBox();
		}

		private void ModoModificar(bool esModificar)
		{
			//Habilitar o deshabilitar cada uno de los campos de texto
			txtCodigo.Enabled = esModificar;
			txtArticulo.Enabled = esModificar;
			txtDescripcion.Enabled = esModificar;
			txtPrecio.Enabled = esModificar;
			cbCategoria.Enabled = esModificar;
			cbMarca.Enabled = esModificar;
			btnCancelar.Visible = esModificar;

			//Cambiar texto al botón
			if (esModificar)
				btnModificar.Text = "Guardar";
			else
				btnModificar.Text = "Modificar";
		}

		private void ModoAgregar(bool esAgregar)
		{
			if (esAgregar)
			{
				btnCancelar.Visible = true;
				btnModificar.Text = "Guardar";
			}
		}

		private void CargarArticulo()
		{
			//Cargar los datos del arítulo en cada uno de sus campos de texto
			txtCodigo.Text = articulo.Codigo;
			txtArticulo.Text = articulo.Nombre;
			txtDescripcion.Text = articulo.Descripcion;
			txtPrecio.Text = articulo.Precio.ToString();
			cbCategoria.SelectedValue = articulo.Categoria.Id;
			cbMarca.SelectedValue = articulo.Marca.Id;

			//TODO: Cargar Imagenes

		}

		private void CargarComboBox()
		{
			//Cargar combo box de categoria y marca
			comboBoxMarca(cbMarca);
			comboBoxCategoria(cbCategoria);

			//Formatear los datos de los combo box
			cbMarca.ValueMember = "Id";
			cbMarca.DisplayMember = "Descripcion";
			cbCategoria.ValueMember = "Id";
			cbCategoria.DisplayMember = "Descripcion";

		}

		//Cargar en el combo box las marcas desde la base de datos
		public static void comboBoxMarca(ComboBox combo)
		{
			try
			{
				MarcaNegocio marcaNegocio = new MarcaNegocio();
				List<Marca> listaMarca = marcaNegocio.listar();

				combo.DataSource = listaMarca;
				combo.SelectedIndex = 0;
			}
			catch (Exception)
			{
				MessageBox.Show("Error al cargar las marcas");
			}
		}

		//Cargar en el combo box las categorias desde la base de datos
		public static void comboBoxCategoria(ComboBox combo)
		{
			try
			{
				CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
				List<Categoria> listaCategoria = categoriaNegocio.listar();

				combo.DataSource = listaCategoria;
				combo.SelectedIndex = 0;
			}
			catch (Exception)
			{
				MessageBox.Show("Error al cargar las categorias");
			}
		}

	}
}
