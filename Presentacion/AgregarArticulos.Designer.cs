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
			this.pbImagenArticulo = new System.Windows.Forms.PictureBox();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnAnteriorImagen = new System.Windows.Forms.Button();
			this.btnSiguienteImagen = new System.Windows.Forms.Button();
			this.btnImagenBorrarActual = new System.Windows.Forms.Button();
			this.gbGuardarImagenes = new System.Windows.Forms.GroupBox();
			this.rbUrl = new System.Windows.Forms.RadioButton();
			this.rbArchivo = new System.Windows.Forms.RadioButton();
			this.lbImagen = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).BeginInit();
			this.gbGuardarImagenes.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbCategoria
			// 
			this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCategoria.FormattingEnabled = true;
			this.cbCategoria.Location = new System.Drawing.Point(160, 256);
			this.cbCategoria.Name = "cbCategoria";
			this.cbCategoria.Size = new System.Drawing.Size(205, 21);
			this.cbCategoria.TabIndex = 16;
			// 
			// cbMarca
			// 
			this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMarca.FormattingEnabled = true;
			this.cbMarca.Location = new System.Drawing.Point(160, 226);
			this.cbMarca.Name = "cbMarca";
			this.cbMarca.Size = new System.Drawing.Size(205, 21);
			this.cbMarca.TabIndex = 15;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(160, 197);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(205, 20);
			this.txtPrecio.TabIndex = 13;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(160, 168);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(205, 20);
			this.txtDescripcion.TabIndex = 11;
			// 
			// txtArticulo
			// 
			this.txtArticulo.Location = new System.Drawing.Point(160, 139);
			this.txtArticulo.Name = "txtArticulo";
			this.txtArticulo.Size = new System.Drawing.Size(205, 20);
			this.txtArticulo.TabIndex = 9;
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(160, 109);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(205, 20);
			this.txtCodigo.TabIndex = 7;
			// 
			// lbCategoria
			// 
			this.lbCategoria.AutoSize = true;
			this.lbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbCategoria.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCategoria.ForeColor = System.Drawing.Color.Black;
			this.lbCategoria.Location = new System.Drawing.Point(83, 257);
			this.lbCategoria.Name = "lbCategoria";
			this.lbCategoria.Size = new System.Drawing.Size(62, 16);
			this.lbCategoria.TabIndex = 18;
			this.lbCategoria.Text = "Categoria";
			// 
			// lbMarca
			// 
			this.lbMarca.AutoSize = true;
			this.lbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbMarca.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMarca.ForeColor = System.Drawing.Color.Black;
			this.lbMarca.Location = new System.Drawing.Point(106, 227);
			this.lbMarca.Name = "lbMarca";
			this.lbMarca.Size = new System.Drawing.Size(42, 16);
			this.lbMarca.TabIndex = 17;
			this.lbMarca.Text = "Marca";
			// 
			// lbPrecio
			// 
			this.lbPrecio.AutoSize = true;
			this.lbPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbPrecio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPrecio.ForeColor = System.Drawing.Color.Black;
			this.lbPrecio.Location = new System.Drawing.Point(106, 198);
			this.lbPrecio.Name = "lbPrecio";
			this.lbPrecio.Size = new System.Drawing.Size(42, 16);
			this.lbPrecio.TabIndex = 14;
			this.lbPrecio.Text = "Precio";
			// 
			// lbDescripcion
			// 
			this.lbDescripcion.AutoSize = true;
			this.lbDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbDescripcion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDescripcion.ForeColor = System.Drawing.Color.Black;
			this.lbDescripcion.Location = new System.Drawing.Point(72, 169);
			this.lbDescripcion.Name = "lbDescripcion";
			this.lbDescripcion.Size = new System.Drawing.Size(72, 16);
			this.lbDescripcion.TabIndex = 12;
			this.lbDescripcion.Text = "Descripción";
			// 
			// lbArticulo
			// 
			this.lbArticulo.AutoSize = true;
			this.lbArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbArticulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbArticulo.ForeColor = System.Drawing.Color.Black;
			this.lbArticulo.Location = new System.Drawing.Point(95, 140);
			this.lbArticulo.Name = "lbArticulo";
			this.lbArticulo.Size = new System.Drawing.Size(50, 16);
			this.lbArticulo.TabIndex = 10;
			this.lbArticulo.Text = "Articulo";
			// 
			// lbCodigo
			// 
			this.lbCodigo.AutoSize = true;
			this.lbCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbCodigo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCodigo.ForeColor = System.Drawing.Color.Black;
			this.lbCodigo.Location = new System.Drawing.Point(103, 110);
			this.lbCodigo.Name = "lbCodigo";
			this.lbCodigo.Size = new System.Drawing.Size(46, 16);
			this.lbCodigo.TabIndex = 8;
			this.lbCodigo.Text = "Código";
			// 
			// pbImagenArticulo
			// 
			this.pbImagenArticulo.Location = new System.Drawing.Point(411, 76);
			this.pbImagenArticulo.Name = "pbImagenArticulo";
			this.pbImagenArticulo.Size = new System.Drawing.Size(271, 244);
			this.pbImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImagenArticulo.TabIndex = 19;
			this.pbImagenArticulo.TabStop = false;
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(144, 359);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 23);
			this.btnModificar.TabIndex = 20;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(225, 359);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 20;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(306, 359);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 20;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnAnteriorImagen
			// 
			this.btnAnteriorImagen.Location = new System.Drawing.Point(424, 194);
			this.btnAnteriorImagen.Name = "btnAnteriorImagen";
			this.btnAnteriorImagen.Size = new System.Drawing.Size(75, 23);
			this.btnAnteriorImagen.TabIndex = 21;
			this.btnAnteriorImagen.Text = "Anterior";
			this.btnAnteriorImagen.UseVisualStyleBackColor = true;
			// 
			// btnSiguienteImagen
			// 
			this.btnSiguienteImagen.Location = new System.Drawing.Point(593, 195);
			this.btnSiguienteImagen.Name = "btnSiguienteImagen";
			this.btnSiguienteImagen.Size = new System.Drawing.Size(75, 23);
			this.btnSiguienteImagen.TabIndex = 21;
			this.btnSiguienteImagen.Text = "Siguiente";
			this.btnSiguienteImagen.UseVisualStyleBackColor = true;
			// 
			// btnImagenBorrarActual
			// 
			this.btnImagenBorrarActual.Location = new System.Drawing.Point(490, 326);
			this.btnImagenBorrarActual.Name = "btnImagenBorrarActual";
			this.btnImagenBorrarActual.Size = new System.Drawing.Size(118, 23);
			this.btnImagenBorrarActual.TabIndex = 21;
			this.btnImagenBorrarActual.Text = "Borrar Actual";
			this.btnImagenBorrarActual.UseVisualStyleBackColor = true;
			this.btnImagenBorrarActual.Click += new System.EventHandler(this.btnImagenBorrarActual_Click);
			// 
			// gbGuardarImagenes
			// 
			this.gbGuardarImagenes.Controls.Add(this.rbArchivo);
			this.gbGuardarImagenes.Controls.Add(this.rbUrl);
			this.gbGuardarImagenes.Location = new System.Drawing.Point(160, 286);
			this.gbGuardarImagenes.Name = "gbGuardarImagenes";
			this.gbGuardarImagenes.Size = new System.Drawing.Size(200, 67);
			this.gbGuardarImagenes.TabIndex = 22;
			this.gbGuardarImagenes.TabStop = false;
			this.gbGuardarImagenes.Text = "Guardar";
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
			// 
			// lbImagen
			// 
			this.lbImagen.AutoSize = true;
			this.lbImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbImagen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbImagen.ForeColor = System.Drawing.Color.Black;
			this.lbImagen.Location = new System.Drawing.Point(88, 316);
			this.lbImagen.Name = "lbImagen";
			this.lbImagen.Size = new System.Drawing.Size(57, 16);
			this.lbImagen.TabIndex = 23;
			this.lbImagen.Text = "Imaegen";
			// 
			// AgregarArticulos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lbImagen);
			this.Controls.Add(this.gbGuardarImagenes);
			this.Controls.Add(this.btnImagenBorrarActual);
			this.Controls.Add(this.btnSiguienteImagen);
			this.Controls.Add(this.btnAnteriorImagen);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.pbImagenArticulo);
			this.Controls.Add(this.cbCategoria);
			this.Controls.Add(this.cbMarca);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.txtArticulo);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.lbCategoria);
			this.Controls.Add(this.lbMarca);
			this.Controls.Add(this.lbPrecio);
			this.Controls.Add(this.lbDescripcion);
			this.Controls.Add(this.lbArticulo);
			this.Controls.Add(this.lbCodigo);
			this.Name = "AgregarArticulos";
			this.Text = "Articulos";
			this.Load += new System.EventHandler(this.Articulos_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).EndInit();
			this.gbGuardarImagenes.ResumeLayout(false);
			this.gbGuardarImagenes.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

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
		private System.Windows.Forms.PictureBox pbImagenArticulo;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnAnteriorImagen;
		private System.Windows.Forms.Button btnSiguienteImagen;
		private System.Windows.Forms.Button btnImagenBorrarActual;
		private System.Windows.Forms.GroupBox gbGuardarImagenes;
		private System.Windows.Forms.RadioButton rbArchivo;
		private System.Windows.Forms.RadioButton rbUrl;
		private System.Windows.Forms.Label lbImagen;
	}
}