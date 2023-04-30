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

		//Bandera de cambios en la ventana para cargar lista en el form principal
		private bool hayCambios;

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

		//Evento de modificación y creacion de artículo
		private void btnModificar_Click(object sender, EventArgs e)
		{
			//Inicia negocio de artiuclos
			ArticuloNegocio articuloNegocio = new ArticuloNegocio();
			
			//Si el modo es agregar, instancia producto vacío
			if (this.esAgregar)
			{
				articulo = new Articulo();
			}

			//cargamos los datos del formulario al objeto
			cargarDatosDeFormulario(articulo);

			if(this.esAgregar) //Agregar Articulo a la base de datos
			{
				if(btnModificar.Text == "Guardar")
				{
					// Guardar articulo
					if (articuloNegocio.agregar(articulo))
					{
						MessageBox.Show("Se Guardó correctamente");

						// Validar si guardó y pasar a modo vista
						this.hayCambios = true;
						this.esAgregar = false;
						//this.esModificar = false;
						//ModoModificar(this.esAgregar);
					}
				}
			}
			else //Modificar Articulo en la base de datos
			{
				if (btnModificar.Text == "Guardar")
				{
					// Validaciones

					//Verificar si se quiere cancelar
					DialogResult result = MessageBox.Show("¿Está seguro que quiere modificar el detalle", "Cancelar", MessageBoxButtons.OKCancel);

					if (result == DialogResult.OK)
					{
						//Modificar producto
						if (articuloNegocio.modificar(articulo))
						{
							MessageBox.Show("Se modificó correctamente");

							// Si se guardan correctamente se cierra la ventana
							this.hayCambios = true;
							
							// Validar si guardó y pasar a modo vista
							this.hayCambios = true;
							this.esAgregar = false;
							//this.esModificar = false;
							//ModoModificar(this.esAgregar);
						}
						else
						{
							MessageBox.Show("Error al modificar");
						}
					}
				}
			}

			this.esModificar = !this.esModificar;
			ModoModificar(this.esModificar);
		}

		private void cargarDatosDeFormulario(Articulo articulo)
		{
			//TODO: Validaciones de los campos
			
			//Ariticulo
			string precio = txtPrecio.Text.Trim();
			string codigo = txtCodigo.Text.Trim();
			string nombre = txtArticulo.Text.Trim();
			string descripcion = txtDescripcion.Text.Trim();

			// Marca
			Marca marca = new Marca();
			marca.Descripcion = cbMarca.Text;
			marca.Id = (int)cbMarca.SelectedValue;

			//Categoria
			Categoria categoria = new Categoria();
			categoria.Descripcion = cbCategoria.Text;
			categoria.Id = (int)cbCategoria.SelectedValue;

			//Guardar datos de la ventana en el articulo
			articulo.Codigo = codigo;
			articulo.Precio = Convert.ToDouble(precio.Replace(".", ","));
			articulo.Nombre = nombre;
			articulo.Descripcion = descripcion;
			articulo.Marca = marca;
			articulo.Categoria = categoria;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			if (this.esModificar)
			{
				//En Modo Modificar verificamos que se quiera cancelar
				DialogResult result = MessageBox.Show("¿Está seguro que quiere cancelar", "Cancelar", MessageBoxButtons.OKCancel);

				//Si se cancela, vuelve a Modo Vista
				if (result == DialogResult.OK)
				{
					this.esModificar = false;
					ModoModificar(this.esModificar);
				}
			}
			else
			{
				// En Modo Agregar, cerrar la ventana si se cancela
				this.Close();
			}
		}
	}
}
