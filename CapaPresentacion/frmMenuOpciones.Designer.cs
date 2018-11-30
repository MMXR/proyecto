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
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnSalirApp = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.grbAdmin = new System.Windows.Forms.GroupBox();
            this.btnAdminModificarEmpresa = new System.Windows.Forms.Button();
            this.btnAdminCrearEmpresa = new System.Windows.Forms.Button();
            this.btnAdminCrearAdmin = new System.Windows.Forms.Button();
            this.grbPerfil = new System.Windows.Forms.GroupBox();
            this.btnPerfilModificarContraseña = new System.Windows.Forms.Button();
            this.grbProducto = new System.Windows.Forms.GroupBox();
            this.btnProductoCrear = new System.Windows.Forms.Button();
            this.btnProductoActualizar = new System.Windows.Forms.Button();
            this.btnProductoBorrar = new System.Windows.Forms.Button();
            this.grbBusquedas = new System.Windows.Forms.GroupBox();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.grbMenu.SuspendLayout();
            this.grbAdmin.SuspendLayout();
            this.grbPerfil.SuspendLayout();
            this.grbProducto.SuspendLayout();
            this.grbBusquedas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Image = global::CapaPresentacion.Properties.Resources.cerrarSesion;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(28, 0);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(28, 28);
            this.btnCerrarSesion.TabIndex = 91;
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
            this.btnSalirApp.TabIndex = 90;
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
            this.btnMinimizar.TabIndex = 89;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // grbMenu
            // 
            this.grbMenu.Controls.Add(this.grbAdmin);
            this.grbMenu.Controls.Add(this.grbPerfil);
            this.grbMenu.Controls.Add(this.grbProducto);
            this.grbMenu.Controls.Add(this.grbBusquedas);
            this.grbMenu.Location = new System.Drawing.Point(12, 34);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(473, 296);
            this.grbMenu.TabIndex = 92;
            this.grbMenu.TabStop = false;
            this.grbMenu.Text = "Menu del Usuario";
            // 
            // grbAdmin
            // 
            this.grbAdmin.Controls.Add(this.btnAdminModificarEmpresa);
            this.grbAdmin.Controls.Add(this.btnAdminCrearEmpresa);
            this.grbAdmin.Controls.Add(this.btnAdminCrearAdmin);
            this.grbAdmin.Location = new System.Drawing.Point(248, 163);
            this.grbAdmin.Name = "grbAdmin";
            this.grbAdmin.Size = new System.Drawing.Size(212, 116);
            this.grbAdmin.TabIndex = 102;
            this.grbAdmin.TabStop = false;
            this.grbAdmin.Text = "Administración";
            // 
            // btnAdminModificarEmpresa
            // 
            this.btnAdminModificarEmpresa.Location = new System.Drawing.Point(22, 78);
            this.btnAdminModificarEmpresa.Name = "btnAdminModificarEmpresa";
            this.btnAdminModificarEmpresa.Size = new System.Drawing.Size(177, 23);
            this.btnAdminModificarEmpresa.TabIndex = 95;
            this.btnAdminModificarEmpresa.Text = "Modificar una Empresa";
            this.btnAdminModificarEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnAdminCrearEmpresa
            // 
            this.btnAdminCrearEmpresa.Location = new System.Drawing.Point(22, 49);
            this.btnAdminCrearEmpresa.Name = "btnAdminCrearEmpresa";
            this.btnAdminCrearEmpresa.Size = new System.Drawing.Size(177, 23);
            this.btnAdminCrearEmpresa.TabIndex = 94;
            this.btnAdminCrearEmpresa.Text = "Crear nueva Empresa";
            this.btnAdminCrearEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnAdminCrearAdmin
            // 
            this.btnAdminCrearAdmin.Location = new System.Drawing.Point(22, 20);
            this.btnAdminCrearAdmin.Name = "btnAdminCrearAdmin";
            this.btnAdminCrearAdmin.Size = new System.Drawing.Size(177, 23);
            this.btnAdminCrearAdmin.TabIndex = 93;
            this.btnAdminCrearAdmin.Text = "Crear nuevo Admin";
            this.btnAdminCrearAdmin.UseVisualStyleBackColor = true;
            // 
            // grbPerfil
            // 
            this.grbPerfil.Controls.Add(this.btnPerfilModificarContraseña);
            this.grbPerfil.Location = new System.Drawing.Point(16, 163);
            this.grbPerfil.Name = "grbPerfil";
            this.grbPerfil.Size = new System.Drawing.Size(212, 116);
            this.grbPerfil.TabIndex = 101;
            this.grbPerfil.TabStop = false;
            this.grbPerfil.Text = "Perfil";
            // 
            // btnPerfilModificarContraseña
            // 
            this.btnPerfilModificarContraseña.Location = new System.Drawing.Point(22, 20);
            this.btnPerfilModificarContraseña.Name = "btnPerfilModificarContraseña";
            this.btnPerfilModificarContraseña.Size = new System.Drawing.Size(177, 23);
            this.btnPerfilModificarContraseña.TabIndex = 93;
            this.btnPerfilModificarContraseña.Text = "Cambiar la contraseña";
            this.btnPerfilModificarContraseña.UseVisualStyleBackColor = true;
            // 
            // grbProducto
            // 
            this.grbProducto.Controls.Add(this.btnProductoCrear);
            this.grbProducto.Controls.Add(this.btnProductoActualizar);
            this.grbProducto.Controls.Add(this.btnProductoBorrar);
            this.grbProducto.Location = new System.Drawing.Point(248, 20);
            this.grbProducto.Name = "grbProducto";
            this.grbProducto.Size = new System.Drawing.Size(212, 123);
            this.grbProducto.TabIndex = 100;
            this.grbProducto.TabStop = false;
            this.grbProducto.Text = "Producto";
            // 
            // btnProductoCrear
            // 
            this.btnProductoCrear.Location = new System.Drawing.Point(22, 20);
            this.btnProductoCrear.Name = "btnProductoCrear";
            this.btnProductoCrear.Size = new System.Drawing.Size(177, 23);
            this.btnProductoCrear.TabIndex = 93;
            this.btnProductoCrear.Text = "Crear Producto";
            this.btnProductoCrear.UseVisualStyleBackColor = true;
            this.btnProductoCrear.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // btnProductoActualizar
            // 
            this.btnProductoActualizar.Location = new System.Drawing.Point(22, 50);
            this.btnProductoActualizar.Name = "btnProductoActualizar";
            this.btnProductoActualizar.Size = new System.Drawing.Size(177, 23);
            this.btnProductoActualizar.TabIndex = 97;
            this.btnProductoActualizar.Text = "Actualizar un Producto";
            this.btnProductoActualizar.UseVisualStyleBackColor = true;
            this.btnProductoActualizar.Click += new System.EventHandler(this.btnProductoActualizar_Click);
            // 
            // btnProductoBorrar
            // 
            this.btnProductoBorrar.Location = new System.Drawing.Point(22, 80);
            this.btnProductoBorrar.Name = "btnProductoBorrar";
            this.btnProductoBorrar.Size = new System.Drawing.Size(177, 23);
            this.btnProductoBorrar.TabIndex = 98;
            this.btnProductoBorrar.Text = "Borrar un Producto";
            this.btnProductoBorrar.UseVisualStyleBackColor = true;
            this.btnProductoBorrar.Click += new System.EventHandler(this.btnProductoBorrar_Click);
            // 
            // grbBusquedas
            // 
            this.grbBusquedas.Controls.Add(this.btnBuscarNombre);
            this.grbBusquedas.Controls.Add(this.btnBuscarCodigo);
            this.grbBusquedas.Controls.Add(this.btnBuscarTodos);
            this.grbBusquedas.Location = new System.Drawing.Point(16, 20);
            this.grbBusquedas.Name = "grbBusquedas";
            this.grbBusquedas.Size = new System.Drawing.Size(212, 123);
            this.grbBusquedas.TabIndex = 99;
            this.grbBusquedas.TabStop = false;
            this.grbBusquedas.Text = "Busquedas";
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Location = new System.Drawing.Point(22, 20);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(177, 23);
            this.btnBuscarNombre.TabIndex = 94;
            this.btnBuscarNombre.Text = "Buscar Producto por Nombre";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.Location = new System.Drawing.Point(22, 50);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(177, 23);
            this.btnBuscarCodigo.TabIndex = 95;
            this.btnBuscarCodigo.Text = "Buscar Producto por Código";
            this.btnBuscarCodigo.UseVisualStyleBackColor = true;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnBuscarCodigo_Click);
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Location = new System.Drawing.Point(22, 80);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(177, 23);
            this.btnBuscarTodos.TabIndex = 96;
            this.btnBuscarTodos.Text = "Ver todos los Productos";
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // frmMenuOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 339);
            this.Controls.Add(this.grbMenu);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnSalirApp);
            this.Controls.Add(this.btnMinimizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuOpciones";
            this.Text = "Menú Opciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuOpciones_Load);
            this.grbMenu.ResumeLayout(false);
            this.grbAdmin.ResumeLayout(false);
            this.grbPerfil.ResumeLayout(false);
            this.grbProducto.ResumeLayout(false);
            this.grbBusquedas.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnSalirApp;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.Button btnProductoBorrar;
        private System.Windows.Forms.Button btnProductoActualizar;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Button btnProductoCrear;
        private System.Windows.Forms.GroupBox grbProducto;
        private System.Windows.Forms.GroupBox grbBusquedas;
        private System.Windows.Forms.GroupBox grbPerfil;
        private System.Windows.Forms.Button btnPerfilModificarContraseña;
        private System.Windows.Forms.GroupBox grbAdmin;
        private System.Windows.Forms.Button btnAdminModificarEmpresa;
        private System.Windows.Forms.Button btnAdminCrearEmpresa;
        private System.Windows.Forms.Button btnAdminCrearAdmin;
    }
}