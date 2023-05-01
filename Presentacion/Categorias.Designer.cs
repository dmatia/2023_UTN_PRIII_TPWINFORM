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
            this.btnClose = new System.Windows.Forms.Button();
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
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(14, 41);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(837, 255);
            this.dgvCategorias.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(746, 639);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 58);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CERRAR";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(553, 302);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(146, 58);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "MODIFICAR SELECCIONADO";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(705, 302);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 58);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "ELIMINAR SELECCIONADO";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // gbLista
            // 
            this.gbLista.Controls.Add(this.btnEliminar);
            this.gbLista.Controls.Add(this.btnModificar);
            this.gbLista.Controls.Add(this.dgvCategorias);
            this.gbLista.Location = new System.Drawing.Point(28, 138);
            this.gbLista.Name = "gbLista";
            this.gbLista.Size = new System.Drawing.Size(864, 380);
            this.gbLista.TabIndex = 4;
            this.gbLista.TabStop = false;
            this.gbLista.Text = "LISTADO";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(553, 18);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 58);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(705, 18);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 58);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbNuevaCategoria
            // 
            this.gbNuevaCategoria.Controls.Add(this.txtbxNuevaCategoria);
            this.gbNuevaCategoria.Controls.Add(this.btnCancelar);
            this.gbNuevaCategoria.Controls.Add(this.btnGuardar);
            this.gbNuevaCategoria.Location = new System.Drawing.Point(28, 529);
            this.gbNuevaCategoria.Name = "gbNuevaCategoria";
            this.gbNuevaCategoria.Size = new System.Drawing.Size(864, 92);
            this.gbNuevaCategoria.TabIndex = 7;
            this.gbNuevaCategoria.TabStop = false;
            this.gbNuevaCategoria.Text = "NUEVA CATEGORIA";
            // 
            // txtbxNuevaCategoria
            // 
            this.txtbxNuevaCategoria.Location = new System.Drawing.Point(14, 36);
            this.txtbxNuevaCategoria.MaxLength = 50;
            this.txtbxNuevaCategoria.Name = "txtbxNuevaCategoria";
            this.txtbxNuevaCategoria.Size = new System.Drawing.Size(506, 22);
            this.txtbxNuevaCategoria.TabIndex = 7;
            this.txtbxNuevaCategoria.Text = "Ingrese su nueva categoria";
            this.txtbxNuevaCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxNuevaCategoria_KeyPress);
            this.txtbxNuevaCategoria.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtbxNuevaCategoria_MouseDoubleClick);
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltrar.Controls.Add(this.btnFiltrar);
            this.gbFiltrar.Controls.Add(this.txbxFiltrar);
            this.gbFiltrar.Controls.Add(this.btnLimpiar);
            this.gbFiltrar.Location = new System.Drawing.Point(28, 12);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Size = new System.Drawing.Size(864, 103);
            this.gbFiltrar.TabIndex = 8;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "FILTRAR";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(553, 21);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(146, 58);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // txbxFiltrar
            // 
            this.txbxFiltrar.Location = new System.Drawing.Point(24, 39);
            this.txbxFiltrar.MaxLength = 50;
            this.txbxFiltrar.Name = "txbxFiltrar";
            this.txbxFiltrar.Size = new System.Drawing.Size(506, 22);
            this.txbxFiltrar.TabIndex = 8;
            this.txbxFiltrar.Text = "Ingrese búsqueda";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(705, 21);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(146, 58);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "RESET";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 722);
            this.ControlBox = false;
            this.Controls.Add(this.gbFiltrar);
            this.Controls.Add(this.gbNuevaCategoria);
            this.Controls.Add(this.gbLista);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categorias";
            this.Text = " ";
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
        private System.Windows.Forms.Button btnClose;
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