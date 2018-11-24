using System;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class frmRegistrarse : Form {
		public frmRegistrarse()	{
			InitializeComponent();
		}

		private void btnSalir_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnAceptar_Click(object sender, EventArgs e) {
			if(txtNombre.Text == "" || txtContraseña.Text == "") {
				MessageBox.Show("Asegurate de escribir un nombre y una contraseña", "Error");
			} else {
				//Llamar a la clase gestora de datos
			}
		}
	}
}
