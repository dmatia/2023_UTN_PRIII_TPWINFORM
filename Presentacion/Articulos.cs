using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Articulos : Form
    {
        private List<Articulo> listaArticulos = null;
		List<Articulo> listaFiltrada = null;
		
		public Articulos()
        {
            InitializeComponent();
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            //Evita duplicar datos
            if (listaArticulos == null)
                cargarVentana();

        }

        //Metodos necesarios al momento de cargar la ventana
        private void cargarVentana()
        {
            //listar Categorias y marcas
            Cargarcombobox();
            ListarArticulos();
            CargarGridView();
            CargarOrdenarPor();

		}

        public void Cargarcombobox()
        {

            CategoriaNegocio CategoriaNegocio = new CategoriaNegocio();
            List<IAtributo> Listacategorias = new List<IAtributo>();
            Listacategorias = CategoriaNegocio.listar();
            foreach (Categoria aux in Listacategorias)
            {

                CbxCategoria.Items.Add(aux.Descripcion);

            }
            CbxCategoria.Text = "Categorias"; // Ver como hacer para que esto lo haga el framework

            MarcaNegocio MarcaNegocio = new MarcaNegocio();
            List<IAtributo> Listamarcas = new List<IAtributo>();
            Listamarcas = MarcaNegocio.listar();
			
            foreach (Marca aux in Listamarcas)
            {
                CbxMarca.Items.Add(aux.Descripcion);
            }
            CbxMarca.Text = "Marcas"; // Ver como hacer para que esto lo haga el framework

            CbxFiltroprimario.Items.Add("Codigo");
            CbxFiltroprimario.Items.Add("Nombre");
            CbxFiltroprimario.Items.Add("Descripcion");
            CbxFiltroprimario.Items.Add("Precio mayor a");
            CbxFiltroprimario.Items.Add("Precio menor a");
            CbxFiltroprimario.Text = "Filtros disponibles";
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
            dgvListaArticulos.Columns["Descripcion"].Visible = false;
		}

        private void ListarArticulos()
        {
            try
            {
                ArticuloNegocio articulosNegocio = new ArticuloNegocio();
                listaArticulos = articulosNegocio.listar();
                listaFiltrada = listaArticulos;
			}
            catch (Exception)
            {
                MessageBox.Show("Error al cargar listado de articulos");
            }
        }


        // Evento para ver detalle o modificar un articulo nuevo
        private void btnDetalle_Click(object sender, EventArgs e)
        {
                if (!(verificarGrid()))
                {
                    MessageBox.Show("SIN REGISTROS");
                }
            
                else {
                        AgregarArticulos Screen = new AgregarArticulos((Articulo)dgvListaArticulos.CurrentRow.DataBoundItem);
                          Screen.ShowDialog();

                        //Si se realizaron cambios, cargar la lista de vuelta
                        if (Screen.hayCambios)
                        {
                            cargarVentana();
                        }
                }
        }


        // Evento para agregar un articulo nuevo
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarArticulos Screen = new AgregarArticulos();
            Screen.ShowDialog();

            //Si se realizaron cambios, cargar la lista de vuelta
            if (Screen.hayCambios)
            {
                cargarVentana();
            }
        }

        private void TxtBuqueda_Click(object sender, EventArgs e)
        {
            if (TxtBuqueda.Text == "Ingrese busqueda...")
            {
                TxtBuqueda.Clear();
            }
        }

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
				ArticuloNegocio articulosNegocio = new ArticuloNegocio();
                listaFiltrada = articulosNegocio.Filtrar(TxtBuqueda.Text, CbxFiltroprimario.Text, CbxCategoria.Text, CbxMarca.Text);
                dgvListaArticulos.DataSource = listaFiltrada;
				
                //Ordenar lista según opción elegida
				OrdenarListaArticulo();


			}
            catch (Exception)
            {

                MessageBox.Show("Error al cargar listado de articulos");
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtBuqueda.Clear();
            CbxFiltroprimario.Text = "Filtros disponibles";
            CbxCategoria.Text = "Categorias";
            CbxMarca.Text = "Marcas";
            dgvListaArticulos.DataSource = listaArticulos;
        }

        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbxCategoria_Click(object sender, EventArgs e)
        {

        }

        // ELIMINAR ARTICULOS
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio eliminarRegistro = new ArticuloNegocio();
            Articulo seleccionado = new Articulo();

            MessageBoxDefaultButton DefaultButton = MessageBoxDefaultButton.Button1;

            if (!(verificarGrid()))
            {
                MessageBox.Show("SIN REGISTROS");
            }
            else
            {
                try
                {
                    DialogResult respuesta = MessageBox.Show("¿ELIMINAR REGISTRO?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DefaultButton);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
                        eliminarRegistro.eliminar(seleccionado.Id);
                        cargarVentana();
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }


        }

        bool verificarGrid()
        {
            if (!(dgvListaArticulos == null) && !(dgvListaArticulos.Rows.Count == 0))
                return true;
            else return false;
        }

            private void CbxFiltroprimario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Cargar el combox de "ordenar por" con el listado de opciones
		private void CargarOrdenarPor()
        {
            cbxOrdenarListaArticulos.DataSource = ListaOrdenarPor();
        }

        // Cambiar opcion de orden
		private void cbxOrdenarListaArticulos_SelectedIndexChanged(object sender, EventArgs e)
		{
            OrdenarListaArticulo();
		}

		// Lsitado de combobox "ordenar por"
		private List<string> ListaOrdenarPor()
        {
			List<string> columnaArticulo = new List<string>()
			{
				"Nombre",
				"Código",
                "Precio Ascendente",
                "Precio Descendiente",
                "Marca",
				"Categoria"
			};

            return columnaArticulo;
		}

        // Ordenar lista de articulo según la opción elegida
		private void OrdenarListaArticulo()
		{
			try
			{
				if (cbxOrdenarListaArticulos.SelectedItem.ToString() == "Nombre")
				{
					listaFiltrada = listaFiltrada.OrderBy(x => x.Nombre).ToList();
				}
				else if (cbxOrdenarListaArticulos.SelectedItem.ToString() == "Marca")
				{
					listaFiltrada = listaFiltrada.OrderBy(x => x.Marca.Descripcion).ToList();
				}
				else if (cbxOrdenarListaArticulos.SelectedItem.ToString() == "Categoria")
				{
					listaFiltrada = listaFiltrada.OrderBy(x => x.Categoria.Descripcion).ToList();
				}
				else if (cbxOrdenarListaArticulos.SelectedItem.ToString() == "Precio Ascendente")
				{
					listaFiltrada = listaFiltrada.OrderBy(x => x.Precio).ToList();
				}
                else if (cbxOrdenarListaArticulos.SelectedItem.ToString() == "Precio Descendente")
                {
                    listaFiltrada = listaFiltrada.OrderByDescending(x => x.Precio).ToList();
                }
                else if (cbxOrdenarListaArticulos.SelectedItem.ToString() == "Código")
				{
					listaFiltrada = listaFiltrada.OrderBy(x => x.Codigo).ToList();
				}

                dgvListaArticulos.DataSource = listaFiltrada;
			}
			catch (Exception)
			{
				MessageBox.Show("Error al ordenar lista de articulos");
			}
		}
	}
}