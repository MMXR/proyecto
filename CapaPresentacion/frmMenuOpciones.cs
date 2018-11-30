using System;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class frmMenuOpciones : Form	{
		public frmMenuOpciones() {
			InitializeComponent();
		}

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            frmCrearProducto CrearProducto = new frmCrearProducto();
            CrearProducto.Show();
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            frmSeleccionarProductoPorNombre SeleccionarProductoPorNombre = new frmSeleccionarProductoPorNombre();
            SeleccionarProductoPorNombre.Show();
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            frmSeleccionarProductoPorCodigo SeleccionarProductoPorCodigo = new frmSeleccionarProductoPorCodigo();
            SeleccionarProductoPorCodigo.Show();
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            frmSeleccionarTodosLosProductos SeleccionarTodosLosProductos = new frmSeleccionarTodosLosProductos();
            SeleccionarTodosLosProductos.Show();
        }

        private void btnProductoActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarUnProducto ActualizarUnProducto = new frmActualizarUnProducto();
            ActualizarUnProducto.Show();
        }

        private void btnProductoBorrar_Click(object sender, EventArgs e)
        {
            frmBorrarUnProducto BorrarUnProducto = new frmBorrarUnProducto();
            BorrarUnProducto.Show();
        }

        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir de la Aplicación?", "Salir de la Aplicación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres cerrar la Sesión?", "Cerrar la sesión", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Gracias por usarnos, vuelve pronto", "Saliendo", MessageBoxButtons.OK);
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMenuOpciones_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //grbMenu
            grbMenu.Left = ((this.Width - grbMenu.Width) / 2) - 100;
            grbMenu.Top = ((this.Height - grbMenu.Height) / 2) - 100;
        }
    }
}
