using System;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class frmLogin : Form {
		public frmLogin() {
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e) {
			if (txtNombre.Text == "" || txtContraseña.Text == "") {
				MessageBox.Show("Asegurate de escribir un nombre y una contraseña", "Error");
			}
		}

		private void btnRegistrarse_Click(object sender, EventArgs e) {
			frmRegistrarse registrarse = new frmRegistrarse();
			registrarse.Show();
		}
	}
}
