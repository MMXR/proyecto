using System;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class frmSeleccionarTodosLosProductos : Form {
		public frmSeleccionarTodosLosProductos() {
			InitializeComponent();
		}

		private void btnSalir_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
