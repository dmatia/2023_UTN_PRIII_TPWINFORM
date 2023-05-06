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
            //foreach (var item in Application.OpenForms)
            //{
            //    if (item.GetType() == typeof(Categorias))
            //        return;
            //}
            ocultarVentanas();
            IAtributos categorias = new IAtributos("Categoria");
			categorias.MdiParent = this;
			categorias.Show();
            categorias.WindowState = FormWindowState.Maximized;
        }
		
		private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// verifica si ya hay una ventana de este tipo abierta para no abrir otra
			//foreach (var item in Application.OpenForms)
			//{
			//	if (item.GetType() == typeof(Categorias))
			//		return;
			//}
			ocultarVentanas();
			IAtributos categorias = new IAtributos("Marca");
			categorias.MdiParent = this;
			categorias.Show();
			categorias.WindowState = FormWindowState.Maximized;
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
            ocultarVentanas();
            Articulos articulos = new Articulos();
            articulos.MdiParent = this;
            articulos.Show();
            articulos.WindowState = FormWindowState.Maximized;
        }

        // Oculta las ventanas de fondo
        private void ocultarVentanas()
        {
            foreach(Form frm in this.MdiChildren)
            {
                if(!frm.Focused)
                {
                    frm.Close();
                }
            }
            
        }

        private void lblAboutUs_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("PROGRAMACIÓN III - GRUPO 25" + Environment.NewLine +
                            "Alumnos: " + Environment.NewLine +
                            "Merayo, Federico" + Environment.NewLine +
                            "Nieto, Alejandro" + Environment.NewLine +
                            "Villalba, Diego" + Environment.NewLine);
           } 
    }
}
