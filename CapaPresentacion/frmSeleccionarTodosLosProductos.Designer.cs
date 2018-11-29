namespace CapaPresentacion
{
	partial class frmSeleccionarTodosLosProductos
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
            this.rtbProductos = new System.Windows.Forms.RichTextBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnSalirApp = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblVer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbProductos
            // 
            this.rtbProductos.Location = new System.Drawing.Point(137, 40);
            this.rtbProductos.Name = "rtbProductos";
            this.rtbProductos.Size = new System.Drawing.Size(436, 411);
            this.rtbProductos.TabIndex = 10;
            this.rtbProductos.Text = "";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Image = global::CapaPresentacion.Properties.Resources.cerrarSesion;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(28, 0);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(28, 28);
            this.btnCerrarSesion.TabIndex = 87;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnSalirApp
            // 
            this.btnSalirApp.Image = global::CapaPresentacion.Properties.Resources.salir;
            this.btnSalirApp.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalirApp.Location = new System.Drawing.Point(0, 0);
            this.btnSalirApp.Name = "btnSalirApp";
            this.btnSalirApp.Size = new System.Drawing.Size(28, 28);
            this.btnSalirApp.TabIndex = 86;
            this.btnSalirApp.UseVisualStyleBackColor = true;
            this.btnSalirApp.Click += new System.EventHandler(this.btnSalirApp_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.minimizar;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMinimizar.Location = new System.Drawing.Point(56, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btnMinimizar.TabIndex = 85;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.atras;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalir.Location = new System.Drawing.Point(84, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(28, 28);
            this.btnSalir.TabIndex = 84;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(12, 43);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(119, 13);
            this.lblVer.TabIndex = 83;
            this.lblVer.Text = "Ver todos los Productos";
            // 
            // frmSeleccionarTodosLosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 459);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnSalirApp);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.rtbProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSeleccionarTodosLosProductos";
            this.Text = "Seleccionar Todos Los Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSeleccionarTodosLosProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbProductos;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnSalirApp;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblVer;
    }
}