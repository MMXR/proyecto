using System;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class frmSeleccionarTodosLosProductos : Form {
		public frmSeleccionarTodosLosProductos() {
			InitializeComponent();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del formulario de vista de Productos?", "Salir del formulario de vista de Productos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmSeleccionarTodosLosProductos_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //lblVer
            lblVer.Left = ((this.Width - lblVer.Width) / 2) - 240;
            lblVer.Top = ((this.Height - lblVer.Height) / 2) - 100;
            //rtbProductos
            rtbProductos.Left = ((this.Width - rtbProductos.Width) / 2) + 100;
            rtbProductos.Top = ((this.Height - rtbProductos.Height) / 2) - 100;
        }
    }
}
