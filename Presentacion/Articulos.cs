using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Articulos : Form
    {
        private List<Articulo> listaArticulos = null;
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
        }

        public void Cargarcombobox()
        {
                        
            CategoriaNegocio CategoriaNegocio = new CategoriaNegocio();
            List<Categoria> Listacategorias = new List<Categoria>();
            Listacategorias = CategoriaNegocio.listar();
            foreach (Categoria aux in Listacategorias){

                CbxCategoria.Items.Add(aux.Descripcion);
            
                }
            CbxCategoria.Text = "Categorias"; // Ver como hacer para que esto lo haga el framework
    
            MarcaNegocio MarcaNegocio = new MarcaNegocio();
            List<Marca> Listamarcas = new List<Marca>();
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
            ///dgvListaArticulos.Columns["Id"].Visible = false;
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


        // Evento para ver detalle o modificar un articulo nuevo
        private void btnDetalle_Click(object sender, EventArgs e)
        {
            AgregarArticulos Screen = new AgregarArticulos((Articulo)dgvListaArticulos.CurrentRow.DataBoundItem);
            Screen.ShowDialog();

            //Si se realizaron cambios, cargar la lista de vuelta
            if (Screen.hayCambios)
            {
                cargarVentana();
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
            TxtBuqueda.Clear();
        }

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
               
               List<Articulo> listaFiltrada = new List<Articulo>();
               ArticuloNegocio articulosNegocio = new ArticuloNegocio();
               listaFiltrada = articulosNegocio.Filtrar(TxtBuqueda.Text, CbxFiltroprimario.Text, CbxCategoria.Text, CbxMarca.Text);
               dgvListaArticulos.DataSource = listaFiltrada;
                
                
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

        private void TxtBuqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
