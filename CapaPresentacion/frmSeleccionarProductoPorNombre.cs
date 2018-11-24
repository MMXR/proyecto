using System;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class frmSeleccionarProductoPorNombre : Form {
		public frmSeleccionarProductoPorNombre() {
			InitializeComponent();
		}

		private void btnSalir_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnAceptar_Click(object sender, EventArgs e) {
			if(txtNombre.Text == "") {
				MessageBox.Show("No has introducido un nombre", "Error");
			} else {
				//Llamar a la clase gestora de datos
			}
		}
	}
}
