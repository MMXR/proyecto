using System;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class frmMenuOpciones : Form	{
		public frmMenuOpciones() {
			InitializeComponent();
		}

		private void crearProductoToolStripMenuItem_Click(object sender, EventArgs e){
			frmCrearProducto CrearProducto = new frmCrearProducto();
			CrearProducto.Show();
		}

		private void seleccionarProductoPorNombreToolStripMenuItem_Click(object sender, EventArgs e) {
			frmSeleccionarProductoPorNombre SeleccionarProductoPorNombre = new frmSeleccionarProductoPorNombre();
			SeleccionarProductoPorNombre.Show();
		}

		private void seleccionarProductoPorCodigoToolStripMenuItem_Click(object sender, EventArgs e) {
			frmSeleccionarProductoPorCodigo SeleccionarProductoPorCodigo = new frmSeleccionarProductoPorCodigo();
			SeleccionarProductoPorCodigo.Show();
		}

		private void seleccionarTodosLosProductosToolStripMenuItem_Click(object sender, EventArgs e) {
			frmSeleccionarTodosLosProductos SeleccionarTodosLosProductos = new frmSeleccionarTodosLosProductos();
			SeleccionarTodosLosProductos.Show();
		}

		private void actualizarUnProductoToolStripMenuItem_Click(object sender, EventArgs e) {
			frmActualizarUnProducto ActualizarUnProducto = new frmActualizarUnProducto();
			ActualizarUnProducto.Show();
		}

		private void borrarUnProductoToolStripMenuItem_Click(object sender, EventArgs e) {
			frmBorrarUnProducto BorrarUnProducto = new frmBorrarUnProducto();
			BorrarUnProducto.Show();
		}
	}
}
