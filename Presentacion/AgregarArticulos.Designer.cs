namespace Presentacion
{
	partial class AgregarArticulos
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbGuardarImagenes = new System.Windows.Forms.GroupBox();
            this.rbArchivo = new System.Windows.Forms.RadioButton();
            this.rbUrl = new System.Windows.Forms.RadioButton();
            this.lbImagen = new System.Windows.Forms.Label();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.btnGuardarImagen = new System.Windows.Forms.Button();
            this.gbArticulo = new System.Windows.Forms.GroupBox();
            this.pbFlechaDerecha = new System.Windows.Forms.PictureBox();
            this.pbFlechaIzquierda = new System.Windows.Forms.PictureBox();
            this.btnImagenBorrarActual = new System.Windows.Forms.Button();
            this.pbImagenArticulo = new System.Windows.Forms.PictureBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbArticulo = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.gbImagen = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbGuardarImagenes.SuspendLayout();
            this.gbArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlechaDerecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlechaIzquierda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).BeginInit();
            this.gbImagen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(65, 227);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 43);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(146, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 43);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(227, 227);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 43);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbGuardarImagenes
            // 
            this.gbGuardarImagenes.Controls.Add(this.rbArchivo);
            this.gbGuardarImagenes.Controls.Add(this.rbUrl);
            this.gbGuardarImagenes.Location = new System.Drawing.Point(126, 19);
            this.gbGuardarImagenes.Name = "gbGuardarImagenes";
            this.gbGuardarImagenes.Size = new System.Drawing.Size(200, 67);
            this.gbGuardarImagenes.TabIndex = 0;
            this.gbGuardarImagenes.TabStop = false;
            this.gbGuardarImagenes.Text = "Guardar";
            // 
            // rbArchivo
            // 
            this.rbArchivo.AutoSize = true;
            this.rbArchivo.Location = new System.Drawing.Point(101, 29);
            this.rbArchivo.Name = "rbArchivo";
            this.rbArchivo.Size = new System.Drawing.Size(61, 17);
            this.rbArchivo.TabIndex = 1;
            this.rbArchivo.TabStop = true;
            this.rbArchivo.Text = "Archivo";
            this.rbArchivo.UseVisualStyleBackColor = true;
            this.rbArchivo.CheckedChanged += new System.EventHandler(this.rbArchivo_CheckedChanged);
            // 
            // rbUrl
            // 
            this.rbUrl.AutoSize = true;
            this.rbUrl.Location = new System.Drawing.Point(29, 29);
            this.rbUrl.Name = "rbUrl";
            this.rbUrl.Size = new System.Drawing.Size(45, 17);
            this.rbUrl.TabIndex = 0;
            this.rbUrl.TabStop = true;
            this.rbUrl.Text = "Link";
            this.rbUrl.UseVisualStyleBackColor = true;
            this.rbUrl.CheckedChanged += new System.EventHandler(this.rbUrl_CheckedChanged);
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbImagen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImagen.ForeColor = System.Drawing.Color.Black;
            this.lbImagen.Location = new System.Drawing.Point(53, 48);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(50, 16);
            this.lbImagen.TabIndex = 3;
            this.lbImagen.Text = "Imagen";
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Location = new System.Drawing.Point(347, 48);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(254, 20);
            this.txtImagenUrl.TabIndex = 1;
            this.txtImagenUrl.TextChanged += new System.EventHandler(this.txtImagenUrl_TextChanged);
            // 
            // btnGuardarImagen
            // 
            this.btnGuardarImagen.Location = new System.Drawing.Point(621, 36);
            this.btnGuardarImagen.Name = "btnGuardarImagen";
            this.btnGuardarImagen.Size = new System.Drawing.Size(75, 43);
            this.btnGuardarImagen.TabIndex = 2;
            this.btnGuardarImagen.Text = "Guardar";
            this.btnGuardarImagen.UseVisualStyleBackColor = true;
            this.btnGuardarImagen.Click += new System.EventHandler(this.btnGuardarImagen_Click);
            // 
            // gbArticulo
            // 
            this.gbArticulo.Controls.Add(this.label3);
            this.gbArticulo.Controls.Add(this.label2);
            this.gbArticulo.Controls.Add(this.label1);
            this.gbArticulo.Controls.Add(this.pbFlechaDerecha);
            this.gbArticulo.Controls.Add(this.pbFlechaIzquierda);
            this.gbArticulo.Controls.Add(this.btnImagenBorrarActual);
            this.gbArticulo.Controls.Add(this.pbImagenArticulo);
            this.gbArticulo.Controls.Add(this.cbCategoria);
            this.gbArticulo.Controls.Add(this.btnEliminar);
            this.gbArticulo.Controls.Add(this.cbMarca);
            this.gbArticulo.Controls.Add(this.btnCancelar);
            this.gbArticulo.Controls.Add(this.txtPrecio);
            this.gbArticulo.Controls.Add(this.btnModificar);
            this.gbArticulo.Controls.Add(this.txtDescripcion);
            this.gbArticulo.Controls.Add(this.txtArticulo);
            this.gbArticulo.Controls.Add(this.txtCodigo);
            this.gbArticulo.Controls.Add(this.lbCategoria);
            this.gbArticulo.Controls.Add(this.lbMarca);
            this.gbArticulo.Controls.Add(this.lbPrecio);
            this.gbArticulo.Controls.Add(this.lbDescripcion);
            this.gbArticulo.Controls.Add(this.lbArticulo);
            this.gbArticulo.Controls.Add(this.lbCodigo);
            this.gbArticulo.Location = new System.Drawing.Point(37, 12);
            this.gbArticulo.Name = "gbArticulo";
            this.gbArticulo.Size = new System.Drawing.Size(735, 307);
            this.gbArticulo.TabIndex = 0;
            this.gbArticulo.TabStop = false;
            this.gbArticulo.Text = "ARTICULO";
            // 
            // pbFlechaDerecha
            // 
            this.pbFlechaDerecha.BackColor = System.Drawing.Color.Transparent;
            this.pbFlechaDerecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFlechaDerecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFlechaDerecha.Location = new System.Drawing.Point(681, 123);
            this.pbFlechaDerecha.Name = "pbFlechaDerecha";
            this.pbFlechaDerecha.Size = new System.Drawing.Size(25, 25);
            this.pbFlechaDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlechaDerecha.TabIndex = 35;
            this.pbFlechaDerecha.TabStop = false;
            this.pbFlechaDerecha.Click += new System.EventHandler(this.btnSiguienteImagen_Click);
            // 
            // pbFlechaIzquierda
            // 
            this.pbFlechaIzquierda.BackColor = System.Drawing.Color.Transparent;
            this.pbFlechaIzquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFlechaIzquierda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFlechaIzquierda.Location = new System.Drawing.Point(419, 123);
            this.pbFlechaIzquierda.Name = "pbFlechaIzquierda";
            this.pbFlechaIzquierda.Size = new System.Drawing.Size(25, 25);
            this.pbFlechaIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlechaIzquierda.TabIndex = 35;
            this.pbFlechaIzquierda.TabStop = false;
            this.pbFlechaIzquierda.Click += new System.EventHandler(this.btnAnteriorImagen_Click);
            // 
            // btnImagenBorrarActual
            // 
            this.btnImagenBorrarActual.Location = new System.Drawing.Point(508, 245);
            this.btnImagenBorrarActual.Name = "btnImagenBorrarActual";
            this.btnImagenBorrarActual.Size = new System.Drawing.Size(118, 43);
            this.btnImagenBorrarActual.TabIndex = 10;
            this.btnImagenBorrarActual.Text = "Borrar Actual";
            this.btnImagenBorrarActual.UseVisualStyleBackColor = true;
            this.btnImagenBorrarActual.Click += new System.EventHandler(this.btnImagenBorrarActual_Click);
            // 
            // pbImagenArticulo
            // 
            this.pbImagenArticulo.Location = new System.Drawing.Point(445, 28);
            this.pbImagenArticulo.Name = "pbImagenArticulo";
            this.pbImagenArticulo.Size = new System.Drawing.Size(235, 211);
            this.pbImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenArticulo.TabIndex = 31;
            this.pbImagenArticulo.TabStop = false;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(84, 186);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(205, 21);
            this.cbCategoria.TabIndex = 6;
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(84, 156);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(205, 21);
            this.cbMarca.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(84, 127);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(205, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(84, 98);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(205, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(84, 69);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(205, 20);
            this.txtArticulo.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(84, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(205, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCategoria.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.ForeColor = System.Drawing.Color.Black;
            this.lbCategoria.Location = new System.Drawing.Point(16, 191);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(62, 16);
            this.lbCategoria.TabIndex = 1;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMarca.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.ForeColor = System.Drawing.Color.Black;
            this.lbMarca.Location = new System.Drawing.Point(36, 161);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(42, 16);
            this.lbMarca.TabIndex = 0;
            this.lbMarca.Text = "Marca";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPrecio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.ForeColor = System.Drawing.Color.Black;
            this.lbPrecio.Location = new System.Drawing.Point(36, 131);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(42, 16);
            this.lbPrecio.TabIndex = 15;
            this.lbPrecio.Text = "Precio";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDescripcion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lbDescripcion.Location = new System.Drawing.Point(6, 102);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(72, 16);
            this.lbDescripcion.TabIndex = 14;
            this.lbDescripcion.Text = "Descripción";
            // 
            // lbArticulo
            // 
            this.lbArticulo.AutoSize = true;
            this.lbArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbArticulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArticulo.ForeColor = System.Drawing.Color.Black;
            this.lbArticulo.Location = new System.Drawing.Point(28, 73);
            this.lbArticulo.Name = "lbArticulo";
            this.lbArticulo.Size = new System.Drawing.Size(50, 16);
            this.lbArticulo.TabIndex = 13;
            this.lbArticulo.Text = "Articulo";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCodigo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.Black;
            this.lbCodigo.Location = new System.Drawing.Point(32, 43);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(46, 16);
            this.lbCodigo.TabIndex = 12;
            this.lbCodigo.Text = "Código";
            // 
            // gbImagen
            // 
            this.gbImagen.Controls.Add(this.lbImagen);
            this.gbImagen.Controls.Add(this.gbGuardarImagenes);
            this.gbImagen.Controls.Add(this.txtImagenUrl);
            this.gbImagen.Controls.Add(this.btnGuardarImagen);
            this.gbImagen.Location = new System.Drawing.Point(37, 325);
            this.gbImagen.Name = "gbImagen";
            this.gbImagen.Size = new System.Drawing.Size(735, 103);
            this.gbImagen.TabIndex = 1;
            this.gbImagen.TabStop = false;
            this.gbImagen.Text = "IMAGEN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "AvisoPrecio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "label3";
            // 
            // AgregarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbImagen);
            this.Controls.Add(this.gbArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarArticulos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            this.gbGuardarImagenes.ResumeLayout(false);
            this.gbGuardarImagenes.PerformLayout();
            this.gbArticulo.ResumeLayout(false);
            this.gbArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlechaDerecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlechaIzquierda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).EndInit();
            this.gbImagen.ResumeLayout(false);
            this.gbImagen.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.GroupBox gbGuardarImagenes;
		private System.Windows.Forms.RadioButton rbArchivo;
		private System.Windows.Forms.RadioButton rbUrl;
		private System.Windows.Forms.Label lbImagen;
		private System.Windows.Forms.TextBox txtImagenUrl;
		private System.Windows.Forms.Button btnGuardarImagen;
		private System.Windows.Forms.GroupBox gbArticulo;
		private System.Windows.Forms.ComboBox cbCategoria;
		private System.Windows.Forms.ComboBox cbMarca;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtArticulo;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lbCategoria;
		private System.Windows.Forms.Label lbMarca;
		private System.Windows.Forms.Label lbPrecio;
		private System.Windows.Forms.Label lbDescripcion;
		private System.Windows.Forms.Label lbArticulo;
		private System.Windows.Forms.Label lbCodigo;
		private System.Windows.Forms.Button btnImagenBorrarActual;
		private System.Windows.Forms.PictureBox pbImagenArticulo;
		private System.Windows.Forms.GroupBox gbImagen;
		private System.Windows.Forms.PictureBox pbFlechaDerecha;
		private System.Windows.Forms.PictureBox pbFlechaIzquierda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}