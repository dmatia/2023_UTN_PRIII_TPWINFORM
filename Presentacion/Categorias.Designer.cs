namespace Presentacion
{
    partial class Categorias
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
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbLista = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbNuevaCategoria = new System.Windows.Forms.GroupBox();
            this.txtbxNuevaCategoria = new System.Windows.Forms.TextBox();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txbxFiltrar = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.gbLista.SuspendLayout();
            this.gbNuevaCategoria.SuspendLayout();
            this.gbFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(13, 41);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(837, 255);
            this.dgvCategorias.TabIndex = 0;
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
            this.gbLista.Controls.Add(this.dgvCategorias);
            this.gbLista.Location = new System.Drawing.Point(28, 138);
            this.gbLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLista.Name = "gbLista";
            this.gbLista.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLista.Size = new System.Drawing.Size(864, 380);
            this.gbLista.TabIndex = 4;
            this.gbLista.TabStop = false;
            this.gbLista.Text = "LISTADO";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(553, 18);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 58);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(705, 18);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 58);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbNuevaCategoria
            // 
            this.gbNuevaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNuevaCategoria.Controls.Add(this.txtbxNuevaCategoria);
            this.gbNuevaCategoria.Controls.Add(this.btnCancelar);
            this.gbNuevaCategoria.Controls.Add(this.btnGuardar);
            this.gbNuevaCategoria.Location = new System.Drawing.Point(28, 529);
            this.gbNuevaCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbNuevaCategoria.Name = "gbNuevaCategoria";
            this.gbNuevaCategoria.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbNuevaCategoria.Size = new System.Drawing.Size(864, 92);
            this.gbNuevaCategoria.TabIndex = 7;
            this.gbNuevaCategoria.TabStop = false;
            this.gbNuevaCategoria.Text = "NUEVA CATEGORIA";
            // 
            // txtbxNuevaCategoria
            // 
            this.txtbxNuevaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxNuevaCategoria.Location = new System.Drawing.Point(13, 36);
            this.txtbxNuevaCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxNuevaCategoria.MaxLength = 50;
            this.txtbxNuevaCategoria.Name = "txtbxNuevaCategoria";
            this.txtbxNuevaCategoria.Size = new System.Drawing.Size(505, 22);
            this.txtbxNuevaCategoria.TabIndex = 7;
            this.txtbxNuevaCategoria.Text = "Ingrese su nueva categoria";
            this.txtbxNuevaCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxNuevaCategoria_KeyPress);
            this.txtbxNuevaCategoria.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtbxNuevaCategoria_MouseDoubleClick);
            this.txtbxNuevaCategoria.MouseLeave += new System.EventHandler(this.txtbxNuevaCategoria_MouseLeave);
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltrar.Controls.Add(this.btnFiltrar);
            this.gbFiltrar.Controls.Add(this.txbxFiltrar);
            this.gbFiltrar.Controls.Add(this.btnLimpiar);
            this.gbFiltrar.Location = new System.Drawing.Point(28, 12);
            this.gbFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFiltrar.Size = new System.Drawing.Size(864, 103);
            this.gbFiltrar.TabIndex = 8;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "FILTRAR";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.Location = new System.Drawing.Point(553, 21);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(147, 58);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txbxFiltrar
            // 
            this.txbxFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxFiltrar.Location = new System.Drawing.Point(24, 39);
            this.txbxFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbxFiltrar.MaxLength = 50;
            this.txbxFiltrar.Name = "txbxFiltrar";
            this.txbxFiltrar.Size = new System.Drawing.Size(505, 22);
            this.txbxFiltrar.TabIndex = 8;
            this.txbxFiltrar.Text = "Ingrese búsqueda";
            this.txbxFiltrar.TextChanged += new System.EventHandler(this.txbxFiltrar_TextChanged);
            this.txbxFiltrar.DoubleClick += new System.EventHandler(this.txbxFiltrar_DoubleClick);
            this.txbxFiltrar.MouseLeave += new System.EventHandler(this.txbxFiltrar_MouseLeave);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(705, 21);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(147, 58);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "RESET";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Categorias
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
            this.Name = "Categorias";
            this.Text = " Categorias";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.gbLista.ResumeLayout(false);
            this.gbNuevaCategoria.ResumeLayout(false);
            this.gbNuevaCategoria.PerformLayout();
            this.gbFiltrar.ResumeLayout(false);
            this.gbFiltrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbNuevaCategoria;
        private System.Windows.Forms.TextBox txtbxNuevaCategoria;
        private System.Windows.Forms.GroupBox gbFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txbxFiltrar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}