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
		public Main()
		{
			InitializeComponent();
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

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaArticulos();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ventanaArticulos();
        }

        private void ventanaArticulos()
        {
            // verifica si ya hay una ventana de este tipo abierta para no abrir otra
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Articulos))
                    return;
            }
            
            Articulos articulos = new Articulos();
            articulos.MdiParent = this;
            articulos.Show();
        }

        // Oculta las ventanas de fondo
        private void ocultarVentanas()
        {
            
        }
    }
}
