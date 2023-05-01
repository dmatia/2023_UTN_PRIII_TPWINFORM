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

        
    }
}
