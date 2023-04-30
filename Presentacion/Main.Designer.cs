namespace Presentacion
{
	partial class Main
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
			this.dgvListaArticulos = new System.Windows.Forms.DataGridView();
			this.btnDetalle = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnArticulos = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnMarca = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.btnCategoria = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvListaArticulos
			// 
			this.dgvListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListaArticulos.Location = new System.Drawing.Point(12, 136);
			this.dgvListaArticulos.Name = "dgvListaArticulos";
			this.dgvListaArticulos.Size = new System.Drawing.Size(776, 234);
			this.dgvListaArticulos.TabIndex = 0;
			// 
			// btnDetalle
			// 
			this.btnDetalle.Location = new System.Drawing.Point(13, 377);
			this.btnDetalle.Name = "btnDetalle";
			this.btnDetalle.Size = new System.Drawing.Size(75, 23);
			this.btnDetalle.TabIndex = 1;
			this.btnDetalle.Text = "Detalle";
			this.btnDetalle.UseVisualStyleBackColor = true;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(94, 376);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 1;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(175, 376);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 1;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnArticulos
			// 
			this.btnArticulos.Location = new System.Drawing.Point(13, 3);
			this.btnArticulos.Name = "btnArticulos";
			this.btnArticulos.Size = new System.Drawing.Size(75, 23);
			this.btnArticulos.TabIndex = 1;
			this.btnArticulos.Text = "Articulos";
			this.btnArticulos.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(13, -369);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Detalle";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnMarca
			// 
			this.btnMarca.Location = new System.Drawing.Point(94, 5);
			this.btnMarca.Name = "btnMarca";
			this.btnMarca.Size = new System.Drawing.Size(75, 23);
			this.btnMarca.TabIndex = 1;
			this.btnMarca.Text = "Marcas";
			this.btnMarca.UseVisualStyleBackColor = true;
			this.btnMarca.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(13, -740);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 1;
			this.button4.Text = "Detalle";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(94, -367);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 1;
			this.button5.Text = "Agregar";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnCategoria
			// 
			this.btnCategoria.Location = new System.Drawing.Point(175, 5);
			this.btnCategoria.Name = "btnCategoria";
			this.btnCategoria.Size = new System.Drawing.Size(75, 23);
			this.btnCategoria.TabIndex = 1;
			this.btnCategoria.Text = "Categorias";
			this.btnCategoria.UseVisualStyleBackColor = true;
			this.btnCategoria.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCategoria);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.btnMarca);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnArticulos);
			this.Controls.Add(this.btnDetalle);
			this.Controls.Add(this.dgvListaArticulos);
			this.Name = "Main";
			this.Text = "Main";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvListaArticulos;
		private System.Windows.Forms.Button btnDetalle;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnArticulos;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnMarca;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button btnCategoria;
	}
}

