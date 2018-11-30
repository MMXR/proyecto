using System;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class frmSeleccionarProductoPorNombre : Form {
		public frmSeleccionarProductoPorNombre() {
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e) {
			if(txtNombre.Text == "") {
				MessageBox.Show("No has introducido un nombre", "Error");
			} else {
				//Llamar a la clase gestora de datos
			}
		}

        private void frmSeleccionarProductoPorNombre_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //lblNombre
            lblNombre.Left = ((this.Width - lblNombre.Width) / 2) - 330;
            lblNombre.Top = ((this.Height - lblNombre.Height) / 2) - 100;
            //txtNombre
            txtNombre.Left = ((this.Width - txtNombre.Width) / 2) - 240;
            txtNombre.Top = ((this.Height - txtNombre.Height) / 2) - 100;
            //rtbProductos
            rtbProductos.Left = ((this.Width - rtbProductos.Width) / 2) + 100;
            rtbProductos.Top = ((this.Height - rtbProductos.Height) / 2) - 100;
            //btnAceptar
            btnAceptar.Left = ((this.Width - btnAceptar.Width) / 2) - 250;
            btnAceptar.Top = ((this.Height - btnAceptar.Height) / 2);
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
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del formulario de busqueda por Nombre?", "Salir del formulario de Busqueda por Nombre", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
