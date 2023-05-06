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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(191, 332);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 43);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(103, 332);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 43);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(22, 332);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 43);
            this.btnDetalle.TabIndex = 5;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // dgvListaArticulos
            // 
            this.dgvListaArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaArticulos.Location = new System.Drawing.Point(22, 40);
            this.dgvListaArticulos.Name = "dgvListaArticulos";
            this.dgvListaArticulos.ReadOnly = true;
            this.dgvListaArticulos.RowHeadersWidth = 51;
            this.dgvListaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaArticulos.Size = new System.Drawing.Size(725, 264);
            this.dgvListaArticulos.TabIndex = 2;
            // 
            // TxtBuqueda
            // 
            this.TxtBuqueda.Location = new System.Drawing.Point(22, 46);
            this.TxtBuqueda.Name = "TxtBuqueda";
            this.TxtBuqueda.Size = new System.Drawing.Size(209, 20);
            this.TxtBuqueda.TabIndex = 11;
            this.TxtBuqueda.Text = "Ingrese busqueda...";
            this.TxtBuqueda.Click += new System.EventHandler(this.TxtBuqueda_Click);
            // 
            // CbxFiltroprimario
            // 
            this.CbxFiltroprimario.FormattingEnabled = true;
            this.CbxFiltroprimario.Location = new System.Drawing.Point(237, 45);
            this.CbxFiltroprimario.Name = "CbxFiltroprimario";
            this.CbxFiltroprimario.Size = new System.Drawing.Size(106, 21);
            this.CbxFiltroprimario.TabIndex = 12;
            this.CbxFiltroprimario.Text = "Filtros disponibles";
            this.CbxFiltroprimario.SelectedIndexChanged += new System.EventHandler(this.CbxFiltroprimario_SelectedIndexChanged);
            // 
            // CbxCategoria
            // 
            this.CbxCategoria.FormattingEnabled = true;
            this.CbxCategoria.Location = new System.Drawing.Point(349, 45);
            this.CbxCategoria.Name = "CbxCategoria";
            this.CbxCategoria.Size = new System.Drawing.Size(106, 21);
            this.CbxCategoria.TabIndex = 13;
            this.CbxCategoria.Text = "Categorias";
            this.CbxCategoria.SelectedIndexChanged += new System.EventHandler(this.CbxCategoria_SelectedIndexChanged);
            this.CbxCategoria.Click += new System.EventHandler(this.CbxCategoria_Click);
            // 
            // CbxMarca
            // 
            this.CbxMarca.FormattingEnabled = true;
            this.CbxMarca.Location = new System.Drawing.Point(461, 45);
            this.CbxMarca.Name = "CbxMarca";
            this.CbxMarca.Size = new System.Drawing.Size(106, 21);
            this.CbxMarca.TabIndex = 14;
            this.CbxMarca.Text = "Marcas";
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.Location = new System.Drawing.Point(573, 34);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(174, 43);
            this.BtnBusqueda.TabIndex = 15;
            this.BtnBusqueda.Text = "Buscar";
            this.BtnBusqueda.UseVisualStyleBackColor = true;
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReset.Location = new System.Drawing.Point(573, 332);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(174, 43);
            this.BtnReset.TabIndex = 16;
            this.BtnReset.Text = "Reestablecer busqueda";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnBusqueda);
            this.groupBox1.Controls.Add(this.CbxMarca);
            this.groupBox1.Controls.Add(this.TxtBuqueda);
            this.groupBox1.Controls.Add(this.CbxFiltroprimario);
            this.groupBox1.Controls.Add(this.CbxCategoria);
            this.groupBox1.Location = new System.Drawing.Point(33, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(776, 101);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRAR";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvListaArticulos);
            this.groupBox2.Controls.Add(this.btnDetalle);
            this.groupBox2.Controls.Add(this.BtnReset);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Location = new System.Drawing.Point(33, 140);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(776, 410);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTADO";
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 578);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Articulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}