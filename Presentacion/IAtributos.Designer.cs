namespace Presentacion
{
    partial class IAtributos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAtributos = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbLista = new System.Windows.Forms.GroupBox();
            this.btnGuardarNuevoAtributo = new System.Windows.Forms.Button();
            this.btnCancelarNuevoAtributo = new System.Windows.Forms.Button();
            this.gbNuevaCategoria = new System.Windows.Forms.GroupBox();
            this.txtbxNuevoAtributo = new System.Windows.Forms.TextBox();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.btnFiltrarAtributos = new System.Windows.Forms.Button();
            this.txbxFiltrarAtributos = new System.Windows.Forms.TextBox();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtributos)).BeginInit();
            this.gbLista.SuspendLayout();
            this.gbNuevaCategoria.SuspendLayout();
            this.gbFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAtributos
            // 
            this.dgvAtributos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtributos.Location = new System.Drawing.Point(13, 41);
            this.dgvAtributos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAtributos.Name = "dgvAtributos";
            this.dgvAtributos.RowHeadersWidth = 51;
            this.dgvAtributos.RowTemplate.Height = 24;
            this.dgvAtributos.Size = new System.Drawing.Size(837, 255);
            this.dgvAtributos.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(553, 302);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(147, 58);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "MODIFICAR SELECCIONADO";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(705, 302);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(147, 58);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "ELIMINAR SELECCIONADO";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbLista
            // 
            this.gbLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLista.Controls.Add(this.btnEliminar);
            this.gbLista.Controls.Add(this.btnModificar);
            this.gbLista.Controls.Add(this.dgvAtributos);
            this.gbLista.Location = new System.Drawing.Point(28, 138);
            this.gbLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLista.Name = "gbLista";
            this.gbLista.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLista.Size = new System.Drawing.Size(864, 380);
            this.gbLista.TabIndex = 4;
            this.gbLista.TabStop = false;
            this.gbLista.Text = "LISTADO";
            // 
            // btnGuardarNuevoAtributo
            // 
            this.btnGuardarNuevoAtributo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarNuevoAtributo.Location = new System.Drawing.Point(553, 18);
            this.btnGuardarNuevoAtributo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarNuevoAtributo.Name = "btnGuardarNuevoAtributo";
            this.btnGuardarNuevoAtributo.Size = new System.Drawing.Size(147, 58);
            this.btnGuardarNuevoAtributo.TabIndex = 5;
            this.btnGuardarNuevoAtributo.Text = "GUARDAR";
            this.btnGuardarNuevoAtributo.UseVisualStyleBackColor = true;
            this.btnGuardarNuevoAtributo.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelarNuevoAtributo
            // 
            this.btnCancelarNuevoAtributo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarNuevoAtributo.Location = new System.Drawing.Point(705, 18);
            this.btnCancelarNuevoAtributo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarNuevoAtributo.Name = "btnCancelarNuevoAtributo";
            this.btnCancelarNuevoAtributo.Size = new System.Drawing.Size(147, 58);
            this.btnCancelarNuevoAtributo.TabIndex = 6;
            this.btnCancelarNuevoAtributo.Text = "CANCELAR";
            this.btnCancelarNuevoAtributo.UseVisualStyleBackColor = true;
            this.btnCancelarNuevoAtributo.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbNuevaCategoria
            // 
            this.gbNuevaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNuevaCategoria.Controls.Add(this.txtbxNuevoAtributo);
            this.gbNuevaCategoria.Controls.Add(this.btnCancelarNuevoAtributo);
            this.gbNuevaCategoria.Controls.Add(this.btnGuardarNuevoAtributo);
            this.gbNuevaCategoria.Location = new System.Drawing.Point(28, 522);
            this.gbNuevaCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbNuevaCategoria.Name = "gbNuevaCategoria";
            this.gbNuevaCategoria.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbNuevaCategoria.Size = new System.Drawing.Size(864, 92);
            this.gbNuevaCategoria.TabIndex = 7;
            this.gbNuevaCategoria.TabStop = false;
            this.gbNuevaCategoria.Text = "AGREGAR NUEVO";
            // 
            // txtbxNuevoAtributo
            // 
            this.txtbxNuevoAtributo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxNuevoAtributo.Location = new System.Drawing.Point(13, 36);
            this.txtbxNuevoAtributo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxNuevoAtributo.MaxLength = 50;
            this.txtbxNuevoAtributo.Name = "txtbxNuevoAtributo";
            this.txtbxNuevoAtributo.Size = new System.Drawing.Size(505, 22);
            this.txtbxNuevoAtributo.TabIndex = 7;
            this.txtbxNuevoAtributo.Text = " ";
            this.txtbxNuevoAtributo.TextChanged += new System.EventHandler(this.txtbxNuevaCategoria_TextChanged);
            this.txtbxNuevoAtributo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtbxNuevoAtributo_MouseDoubleClick);
            this.txtbxNuevoAtributo.MouseLeave += new System.EventHandler(this.txtbxNuevoAtributo_MouseLeave);
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltrar.Controls.Add(this.btnFiltrarAtributos);
            this.gbFiltrar.Controls.Add(this.txbxFiltrarAtributos);
            this.gbFiltrar.Controls.Add(this.btnLimpiarBusqueda);
            this.gbFiltrar.Location = new System.Drawing.Point(28, 12);
            this.gbFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFiltrar.Size = new System.Drawing.Size(864, 103);
            this.gbFiltrar.TabIndex = 8;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "FILTRAR";
            // 
            // btnFiltrarAtributos
            // 
            this.btnFiltrarAtributos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrarAtributos.Location = new System.Drawing.Point(217, 21);
            this.btnFiltrarAtributos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrarAtributos.Name = "btnFiltrarAtributos";
            this.btnFiltrarAtributos.Size = new System.Drawing.Size(147, 58);
            this.btnFiltrarAtributos.TabIndex = 9;
            this.btnFiltrarAtributos.Text = "FILTRAR";
            this.btnFiltrarAtributos.UseVisualStyleBackColor = true;
            this.btnFiltrarAtributos.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txbxFiltrarAtributos
            // 
            this.txbxFiltrarAtributos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxFiltrarAtributos.Location = new System.Drawing.Point(24, 39);
            this.txbxFiltrarAtributos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbxFiltrarAtributos.MaxLength = 50;
            this.txbxFiltrarAtributos.Name = "txbxFiltrarAtributos";
            this.txbxFiltrarAtributos.Size = new System.Drawing.Size(169, 22);
            this.txbxFiltrarAtributos.TabIndex = 8;
            this.txbxFiltrarAtributos.Text = "Ingrese búsqueda";
            this.txbxFiltrarAtributos.TextChanged += new System.EventHandler(this.txbxFiltrar_TextChanged);
            this.txbxFiltrarAtributos.DoubleClick += new System.EventHandler(this.txbxFiltrar_DoubleClick);
            this.txbxFiltrarAtributos.MouseLeave += new System.EventHandler(this.txbxFiltrar_MouseLeave);
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(369, 21);
            this.btnLimpiarBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(147, 58);
            this.btnLimpiarBusqueda.TabIndex = 7;
            this.btnLimpiarBusqueda.Text = "RESET";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = true;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // IAtributos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 650);
            this.ControlBox = false;
            this.Controls.Add(this.gbFiltrar);
            this.Controls.Add(this.gbNuevaCategoria);
            this.Controls.Add(this.gbLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IAtributos";
            this.Text = " Categorias";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtributos)).EndInit();
            this.gbLista.ResumeLayout(false);
            this.gbNuevaCategoria.ResumeLayout(false);
            this.gbNuevaCategoria.PerformLayout();
            this.gbFiltrar.ResumeLayout(false);
            this.gbFiltrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAtributos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.Button btnGuardarNuevoAtributo;
        private System.Windows.Forms.Button btnCancelarNuevoAtributo;
        private System.Windows.Forms.GroupBox gbNuevaCategoria;
        private System.Windows.Forms.TextBox txtbxNuevoAtributo;
        private System.Windows.Forms.GroupBox gbFiltrar;
        private System.Windows.Forms.Button btnFiltrarAtributos;
        private System.Windows.Forms.TextBox txbxFiltrarAtributos;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
    }
}