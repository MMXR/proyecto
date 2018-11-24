namespace CapaPresentacion
{
	partial class frmMenuOpciones
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.crearProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.seleccionarProductoPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.seleccionarProductoPorCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.seleccionarTodosLosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.actualizarUnProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.borrarUnProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(342, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// opcionesToolStripMenuItem
			// 
			this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearProductoToolStripMenuItem,
            this.seleccionarProductoPorNombreToolStripMenuItem,
            this.seleccionarProductoPorCodigoToolStripMenuItem,
            this.seleccionarTodosLosProductosToolStripMenuItem,
            this.actualizarUnProductoToolStripMenuItem,
            this.borrarUnProductoToolStripMenuItem});
			this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
			this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.opcionesToolStripMenuItem.Text = "Opciones";
			// 
			// crearProductoToolStripMenuItem
			// 
			this.crearProductoToolStripMenuItem.Name = "crearProductoToolStripMenuItem";
			this.crearProductoToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
			this.crearProductoToolStripMenuItem.Text = "Crear Producto";
			this.crearProductoToolStripMenuItem.Click += new System.EventHandler(this.crearProductoToolStripMenuItem_Click);
			// 
			// seleccionarProductoPorNombreToolStripMenuItem
			// 
			this.seleccionarProductoPorNombreToolStripMenuItem.Name = "seleccionarProductoPorNombreToolStripMenuItem";
			this.seleccionarProductoPorNombreToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
			this.seleccionarProductoPorNombreToolStripMenuItem.Text = "Seleccionar Producto por Nombre";
			this.seleccionarProductoPorNombreToolStripMenuItem.Click += new System.EventHandler(this.seleccionarProductoPorNombreToolStripMenuItem_Click);
			// 
			// seleccionarProductoPorCodigoToolStripMenuItem
			// 
			this.seleccionarProductoPorCodigoToolStripMenuItem.Name = "seleccionarProductoPorCodigoToolStripMenuItem";
			this.seleccionarProductoPorCodigoToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
			this.seleccionarProductoPorCodigoToolStripMenuItem.Text = "Seleccionar Producto por Codigo";
			this.seleccionarProductoPorCodigoToolStripMenuItem.Click += new System.EventHandler(this.seleccionarProductoPorCodigoToolStripMenuItem_Click);
			// 
			// seleccionarTodosLosProductosToolStripMenuItem
			// 
			this.seleccionarTodosLosProductosToolStripMenuItem.Name = "seleccionarTodosLosProductosToolStripMenuItem";
			this.seleccionarTodosLosProductosToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
			this.seleccionarTodosLosProductosToolStripMenuItem.Text = "Seleccionar todos los Productos";
			this.seleccionarTodosLosProductosToolStripMenuItem.Click += new System.EventHandler(this.seleccionarTodosLosProductosToolStripMenuItem_Click);
			// 
			// actualizarUnProductoToolStripMenuItem
			// 
			this.actualizarUnProductoToolStripMenuItem.Name = "actualizarUnProductoToolStripMenuItem";
			this.actualizarUnProductoToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
			this.actualizarUnProductoToolStripMenuItem.Text = "Actualizar un Producto";
			this.actualizarUnProductoToolStripMenuItem.Click += new System.EventHandler(this.actualizarUnProductoToolStripMenuItem_Click);
			// 
			// borrarUnProductoToolStripMenuItem
			// 
			this.borrarUnProductoToolStripMenuItem.Name = "borrarUnProductoToolStripMenuItem";
			this.borrarUnProductoToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
			this.borrarUnProductoToolStripMenuItem.Text = "Borrar un Producto";
			this.borrarUnProductoToolStripMenuItem.Click += new System.EventHandler(this.borrarUnProductoToolStripMenuItem_Click);
			// 
			// frmMenuOpciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 268);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMenuOpciones";
			this.Text = "Menú Opciones";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem crearProductoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem seleccionarProductoPorNombreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem seleccionarProductoPorCodigoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem seleccionarTodosLosProductosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem actualizarUnProductoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem borrarUnProductoToolStripMenuItem;
	}
}