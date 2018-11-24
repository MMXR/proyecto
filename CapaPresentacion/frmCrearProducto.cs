using Entidades;
using System;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class frmCrearProducto : Form {
		public frmCrearProducto() {
			InitializeComponent();
		}

		private void btnSalir_Click(object sender, EventArgs e)	{
			this.Close();
		}

		private void btnAceptar_Click(object sender, EventArgs e) {
			if (txtCodigo.Text == "" || txtEAN.Text == "" || txtDescripcion.Text == "" || txtMarca.Text == "" || txtPrecio.Text == "" || txtStock.Text == "" || txtCodSubfamilia.Text == "" || txtCodFamilia.Text == "" || txtIdMarca.Text == "" || txtPesoNeto.Text == "" || txtPesoBruto.Text == "") {
				MessageBox.Show("¡Te has olvidado de escribir algún dato!", "Error");
			} else {
				int[] valoresInt = { int.Parse(txtStock.Text), int.Parse(txtCodSubfamilia.Text), int.Parse(txtCodFamilia.Text), int.Parse(txtIdMarca.Text), int.Parse(txtPesoNeto.Text), int.Parse(txtPesoBruto.Text) };
				Producto productoAux = new Producto(txtCodigo.Text, txtEAN.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, valoresInt[0], valoresInt[1], valoresInt[2], valoresInt[3], valoresInt[4], valoresInt[5]);
				//Faltar llamar a la clase gestor de datos.
			}
		}
	}
}
