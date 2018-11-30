using System;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class frmSeleccionarProductoPorCodigo : Form	{
		public frmSeleccionarProductoPorCodigo() {
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e) {
			if (txtCodigo.Text == "") {
				MessageBox.Show("No has introducido un código", "Error");
			} else {
				//Llamar a la clase gestora de datos
			}
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
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del formulario de busqueda por Código?", "Salir del formulario de Busqueda por Código", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmSeleccionarProductoPorCodigo_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //lblCodigo
            lblCodigo.Left = ((this.Width - lblCodigo.Width) / 2) - 330;
            lblCodigo.Top = ((this.Height - lblCodigo.Height) / 2) - 100;
            //txtCodigo
            txtCodigo.Left = ((this.Width - txtCodigo.Width) / 2) - 240;
            txtCodigo.Top = ((this.Height - txtCodigo.Height) / 2) - 100;
            //rtbProductos
            rtbProductos.Left = ((this.Width - rtbProductos.Width) / 2) + 100;
            rtbProductos.Top = ((this.Height - rtbProductos.Height) / 2) - 100;
            //btnAceptar
            btnAceptar.Left = ((this.Width - btnAceptar.Width) / 2) - 250;
            btnAceptar.Top = ((this.Height - btnAceptar.Height) / 2);
        }
    }
}
