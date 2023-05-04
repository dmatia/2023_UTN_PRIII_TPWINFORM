namespace Presentacion
{
    partial class Articulos
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.dgvListaArticulos = new System.Windows.Forms.DataGridView();
            this.TxtBuqueda = new System.Windows.Forms.TextBox();
            this.CbxFiltroprimario = new System.Windows.Forms.ComboBox();
            this.CbxCategoria = new System.Windows.Forms.ComboBox();
            this.CbxMarca = new System.Windows.Forms.ComboBox();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(244, 454);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(136, 454);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(28, 455);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(100, 28);
            this.btnDetalle.TabIndex = 5;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // dgvListaArticulos
            // 
            this.dgvListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaArticulos.Location = new System.Drawing.Point(27, 158);
            this.dgvListaArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListaArticulos.Name = "dgvListaArticulos";
            this.dgvListaArticulos.ReadOnly = true;
            this.dgvListaArticulos.RowHeadersWidth = 51;
            this.dgvListaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaArticulos.Size = new System.Drawing.Size(1035, 288);
            this.dgvListaArticulos.TabIndex = 2;
            // 
            // TxtBuqueda
            // 
            this.TxtBuqueda.Location = new System.Drawing.Point(31, 108);
            this.TxtBuqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBuqueda.Name = "TxtBuqueda";
            this.TxtBuqueda.Size = new System.Drawing.Size(363, 22);
            this.TxtBuqueda.TabIndex = 11;
            this.TxtBuqueda.Text = "Ingrese busqueda...";
            this.TxtBuqueda.Click += new System.EventHandler(this.TxtBuqueda_Click);
            // 
            // CbxFiltroprimario
            // 
            this.CbxFiltroprimario.FormattingEnabled = true;
            this.CbxFiltroprimario.Location = new System.Drawing.Point(403, 107);
            this.CbxFiltroprimario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxFiltroprimario.Name = "CbxFiltroprimario";
            this.CbxFiltroprimario.Size = new System.Drawing.Size(176, 24);
            this.CbxFiltroprimario.TabIndex = 12;
            this.CbxFiltroprimario.Text = "Filtros disponibles";
            // 
            // CbxCategoria
            // 
            this.CbxCategoria.FormattingEnabled = true;
            this.CbxCategoria.Location = new System.Drawing.Point(588, 107);
            this.CbxCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxCategoria.Name = "CbxCategoria";
            this.CbxCategoria.Size = new System.Drawing.Size(176, 24);
            this.CbxCategoria.TabIndex = 13;
            this.CbxCategoria.Text = "Categorias";
            this.CbxCategoria.SelectedIndexChanged += new System.EventHandler(this.CbxCategoria_SelectedIndexChanged);
            this.CbxCategoria.Click += new System.EventHandler(this.CbxCategoria_Click);
            // 
            // CbxMarca
            // 
            this.CbxMarca.FormattingEnabled = true;
            this.CbxMarca.Location = new System.Drawing.Point(773, 107);
            this.CbxMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxMarca.Name = "CbxMarca";
            this.CbxMarca.Size = new System.Drawing.Size(176, 24);
            this.CbxMarca.TabIndex = 14;
            this.CbxMarca.Text = "Marcas";
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.Location = new System.Drawing.Point(959, 107);
            this.BtnBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(100, 28);
            this.BtnBusqueda.TabIndex = 15;
            this.BtnBusqueda.Text = "Buscar";
            this.BtnBusqueda.UseVisualStyleBackColor = true;
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(829, 453);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(232, 31);
            this.BtnReset.TabIndex = 16;
            this.BtnReset.Text = "Reestablecer busqueda";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 711);
            this.ControlBox = false;
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnBusqueda);
            this.Controls.Add(this.CbxMarca);
            this.Controls.Add(this.CbxCategoria);
            this.Controls.Add(this.CbxFiltroprimario);
            this.Controls.Add(this.TxtBuqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.dgvListaArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Articulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.DataGridView dgvListaArticulos;
        private System.Windows.Forms.TextBox TxtBuqueda;
        private System.Windows.Forms.ComboBox CbxFiltroprimario;
        private System.Windows.Forms.ComboBox CbxCategoria;
        private System.Windows.Forms.ComboBox CbxMarca;
        private System.Windows.Forms.Button BtnBusqueda;
        private System.Windows.Forms.Button BtnReset;
    }
}