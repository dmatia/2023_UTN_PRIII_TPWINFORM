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

        // Cierre
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
