namespace CapaPresentacion
{
	partial class frmCrearProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPesoNeto = new System.Windows.Forms.TextBox();
            this.txtPesoBruto = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnSalirApp = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpCreacion = new System.Windows.Forms.GroupBox();
            this.cboSubFamilia = new System.Windows.Forms.ComboBox();
            this.cboFamilia = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.grpCreacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(657, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Subfamilia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Familia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Marca";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(660, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Peso Neto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(656, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Peso Bruto";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(464, 62);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(132, 22);
            this.txtStock.TabIndex = 14;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(142, 101);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(132, 22);
            this.txtPrecio.TabIndex = 15;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(142, 62);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(132, 22);
            this.txtDescripcion.TabIndex = 17;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(142, 25);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 19;
            // 
            // txtPesoNeto
            // 
            this.txtPesoNeto.Location = new System.Drawing.Point(773, 62);
            this.txtPesoNeto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesoNeto.Name = "txtPesoNeto";
            this.txtPesoNeto.Size = new System.Drawing.Size(132, 22);
            this.txtPesoNeto.TabIndex = 20;
            // 
            // txtPesoBruto
            // 
            this.txtPesoBruto.Location = new System.Drawing.Point(773, 98);
            this.txtPesoBruto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesoBruto.Name = "txtPesoBruto";
            this.txtPesoBruto.Size = new System.Drawing.Size(132, 22);
            this.txtPesoBruto.TabIndex = 21;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(31, 265);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 28);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Crear Producto";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Image = global::CapaPresentacion.Properties.Resources.cerrarSesion;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(37, 0);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(37, 34);
            this.btnCerrarSesion.TabIndex = 27;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnSalirApp
            // 
            this.btnSalirApp.Image = global::CapaPresentacion.Properties.Resources.salir;
            this.btnSalirApp.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalirApp.Location = new System.Drawing.Point(0, 0);
            this.btnSalirApp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalirApp.Name = "btnSalirApp";
            this.btnSalirApp.Size = new System.Drawing.Size(37, 34);
            this.btnSalirApp.TabIndex = 26;
            this.btnSalirApp.UseVisualStyleBackColor = true;
            this.btnSalirApp.Click += new System.EventHandler(this.btnSalirApp_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.minimizar;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMinimizar.Location = new System.Drawing.Point(75, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(37, 34);
            this.btnMinimizar.TabIndex = 25;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.atras;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalir.Location = new System.Drawing.Point(112, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(37, 34);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpCreacion
            // 
            this.grpCreacion.Controls.Add(this.cboSubFamilia);
            this.grpCreacion.Controls.Add(this.cboFamilia);
            this.grpCreacion.Controls.Add(this.cboMarca);
            this.grpCreacion.Controls.Add(this.label1);
            this.grpCreacion.Controls.Add(this.txtCodigo);
            this.grpCreacion.Controls.Add(this.txtDescripcion);
            this.grpCreacion.Controls.Add(this.label3);
            this.grpCreacion.Controls.Add(this.txtPesoBruto);
            this.grpCreacion.Controls.Add(this.txtPesoNeto);
            this.grpCreacion.Controls.Add(this.label11);
            this.grpCreacion.Controls.Add(this.label10);
            this.grpCreacion.Controls.Add(this.txtStock);
            this.grpCreacion.Controls.Add(this.label9);
            this.grpCreacion.Controls.Add(this.txtPrecio);
            this.grpCreacion.Controls.Add(this.label5);
            this.grpCreacion.Controls.Add(this.label6);
            this.grpCreacion.Controls.Add(this.label8);
            this.grpCreacion.Controls.Add(this.label7);
            this.grpCreacion.Location = new System.Drawing.Point(16, 62);
            this.grpCreacion.Margin = new System.Windows.Forms.Padding(4);
            this.grpCreacion.Name = "grpCreacion";
            this.grpCreacion.Padding = new System.Windows.Forms.Padding(4);
            this.grpCreacion.Size = new System.Drawing.Size(923, 177);
            this.grpCreacion.TabIndex = 28;
            this.grpCreacion.TabStop = false;
            this.grpCreacion.Text = "Crear un Producto Nuevo";
            this.grpCreacion.Enter += new System.EventHandler(this.grpCreacion_Enter);
            // 
            // cboSubFamilia
            // 
            this.cboSubFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubFamilia.FormattingEnabled = true;
            this.cboSubFamilia.Location = new System.Drawing.Point(773, 21);
            this.cboSubFamilia.Name = "cboSubFamilia";
            this.cboSubFamilia.Size = new System.Drawing.Size(132, 24);
            this.cboSubFamilia.TabIndex = 24;
            // 
            // cboFamilia
            // 
            this.cboFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFamilia.FormattingEnabled = true;
            this.cboFamilia.Location = new System.Drawing.Point(464, 23);
            this.cboFamilia.Name = "cboFamilia";
            this.cboFamilia.Size = new System.Drawing.Size(132, 24);
            this.cboFamilia.TabIndex = 23;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(464, 98);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(132, 24);
            this.cboMarca.TabIndex = 22;
            // 
            // frmCrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 316);
            this.Controls.Add(this.grpCreacion);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnSalirApp);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCrearProducto";
            this.Text = "Crear Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCrearProducto_Load);
            this.grpCreacion.ResumeLayout(false);
            this.grpCreacion.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.TextBox txtPesoNeto;
		private System.Windows.Forms.TextBox txtPesoBruto;
		private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalirApp;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.GroupBox grpCreacion;
        private System.Windows.Forms.ComboBox cboSubFamilia;
        private System.Windows.Forms.ComboBox cboFamilia;
        private System.Windows.Forms.ComboBox cboMarca;
    }
}