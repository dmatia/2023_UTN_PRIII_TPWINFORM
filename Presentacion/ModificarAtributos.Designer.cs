namespace Presentacion
{
    partial class ModificarAtributos
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
            this.grbxModificarCategoria = new System.Windows.Forms.GroupBox();
            this.lblDatosActuales = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txbxNuevaDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcionActual = new System.Windows.Forms.Label();
            this.lblNuevaDescripcion = new System.Windows.Forms.Label();
            this.lblIdActual = new System.Windows.Forms.Label();
            this.grbxModificarCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxModificarCategoria
            // 
            this.grbxModificarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxModificarCategoria.Controls.Add(this.lblDatosActuales);
            this.grbxModificarCategoria.Controls.Add(this.btnAceptar);
            this.grbxModificarCategoria.Controls.Add(this.lblDescripcion);
            this.grbxModificarCategoria.Controls.Add(this.btnCancelar);
            this.grbxModificarCategoria.Controls.Add(this.lblId);
            this.grbxModificarCategoria.Controls.Add(this.txbxNuevaDescripcion);
            this.grbxModificarCategoria.Controls.Add(this.lblDescripcionActual);
            this.grbxModificarCategoria.Controls.Add(this.lblNuevaDescripcion);
            this.grbxModificarCategoria.Controls.Add(this.lblIdActual);
            this.grbxModificarCategoria.Location = new System.Drawing.Point(8, 8);
            this.grbxModificarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbxModificarCategoria.Name = "grbxModificarCategoria";
            this.grbxModificarCategoria.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbxModificarCategoria.Size = new System.Drawing.Size(468, 276);
            this.grbxModificarCategoria.TabIndex = 5;
            this.grbxModificarCategoria.TabStop = false;
            this.grbxModificarCategoria.Text = "MODIFICAR REGISTRO";
            // 
            // lblDatosActuales
            // 
            this.lblDatosActuales.AutoSize = true;
            this.lblDatosActuales.Location = new System.Drawing.Point(30, 36);
            this.lblDatosActuales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosActuales.Name = "lblDatosActuales";
            this.lblDatosActuales.Size = new System.Drawing.Size(130, 13);
            this.lblDatosActuales.TabIndex = 9;
            this.lblDatosActuales.Text = "DATOS DEL REGISTRO:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(225, 198);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(116, 40);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "GUARDAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(224, 105);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.MinimumSize = new System.Drawing.Size(8, 8);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(8, 13);
            this.lblDescripcion.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(104, 198);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 40);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(224, 87);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.MinimumSize = new System.Drawing.Size(12, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(12, 13);
            this.lblId.TabIndex = 2;
            // 
            // txbxNuevaDescripcion
            // 
            this.txbxNuevaDescripcion.Location = new System.Drawing.Point(225, 162);
            this.txbxNuevaDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbxNuevaDescripcion.MaxLength = 50;
            this.txbxNuevaDescripcion.Name = "txbxNuevaDescripcion";
            this.txbxNuevaDescripcion.Size = new System.Drawing.Size(165, 20);
            this.txbxNuevaDescripcion.TabIndex = 0;
            this.txbxNuevaDescripcion.Text = "doble click aquí";
            this.txbxNuevaDescripcion.DoubleClick += new System.EventHandler(this.txbxNuevaDescripcion_DoubleClick);
            // 
            // lblDescripcionActual
            // 
            this.lblDescripcionActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcionActual.AutoSize = true;
            this.lblDescripcionActual.Location = new System.Drawing.Point(145, 105);
            this.lblDescripcionActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionActual.Name = "lblDescripcionActual";
            this.lblDescripcionActual.Size = new System.Drawing.Size(83, 13);
            this.lblDescripcionActual.TabIndex = 1;
            this.lblDescripcionActual.Text = "DESCRIPCIÓN:";
            // 
            // lblNuevaDescripcion
            // 
            this.lblNuevaDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNuevaDescripcion.AutoSize = true;
            this.lblNuevaDescripcion.Location = new System.Drawing.Point(53, 164);
            this.lblNuevaDescripcion.Margin = new System.Windows.Forms.Padding(0);
            this.lblNuevaDescripcion.Name = "lblNuevaDescripcion";
            this.lblNuevaDescripcion.Size = new System.Drawing.Size(183, 13);
            this.lblNuevaDescripcion.TabIndex = 5;
            this.lblNuevaDescripcion.Text = "INGRESE NUEVA DESCRIPCIÓN:   ";
            this.lblNuevaDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdActual
            // 
            this.lblIdActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdActual.AutoSize = true;
            this.lblIdActual.Location = new System.Drawing.Point(145, 87);
            this.lblIdActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdActual.Name = "lblIdActual";
            this.lblIdActual.Size = new System.Drawing.Size(21, 13);
            this.lblIdActual.TabIndex = 0;
            this.lblIdActual.Text = "ID:";
            // 
            // ModificarAtributos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 301);
            this.Controls.Add(this.grbxModificarCategoria);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(503, 340);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(503, 340);
            this.Name = "ModificarAtributos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡ATENCIÓN!";
            this.Load += new System.EventHandler(this.ModificarCategoria_Load);
            this.grbxModificarCategoria.ResumeLayout(false);
            this.grbxModificarCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxModificarCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txbxNuevaDescripcion;
        private System.Windows.Forms.Label lblDescripcionActual;
        private System.Windows.Forms.Label lblNuevaDescripcion;
        private System.Windows.Forms.Label lblIdActual;
        private System.Windows.Forms.Label lblDatosActuales;
    }
}