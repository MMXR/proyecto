using System;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class frmSeleccionarProductoPorCodigo : Form	{
		public frmSeleccionarProductoPorCodigo() {
			InitializeComponent();
		}

		private void btnSalir_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnAceptar_Click(object sender, EventArgs e) {
			if (txtCodigo.Text == "") {
				MessageBox.Show("No has introducido un código", "Error");
			} else {
				//Llamar a la clase gestora de datos
			}
		}
	}
}
