using Entidades;
using System;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class frmActualizarUnProducto : Form	{
		public frmActualizarUnProducto() {
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e) {
			if (txtCodigo.Text == "" || txtEAN.Text == "" || txtDescripcion.Text == "" || txtMarca.Text == "" || txtPrecio.Text == "" || txtStock.Text == "" || txtCodSubfamilia.Text == "" || txtCodFamilia.Text == "" || txtIdMarca.Text == "" || txtPesoNeto.Text == "" || txtPesoBruto.Text == "") {
				MessageBox.Show("¡Te has olvidado de escribir algún dato!", "Error");
			} else {
				
				int[] valoresInt = { int.Parse(txtStock.Text), int.Parse(txtCodSubfamilia.Text), int.Parse(txtCodFamilia.Text), int.Parse(txtIdMarca.Text), int.Parse(txtPesoNeto.Text), int.Parse(txtPesoBruto.Text) };
				//Producto productoAux = new Producto(txtCodigo.Text, txtEAN.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, valoresInt[0], valoresInt[1], valoresInt[2], valoresInt[3], valoresInt[4], valoresInt[5]);
				//Faltar llamar a la clase gestor de datos.
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
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del formulario de actualización del Producto?", "Salir de la actualización del Producto", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmActualizarUnProducto_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //grpCreacion
            grpCreacion.Left = ((this.Width - grpCreacion.Width) / 2) - 80;
            grpCreacion.Top = ((this.Height - grpCreacion.Height) / 2) - 100;
            //btnAceptar
            btnAceptar.Left = ((this.Width - btnAceptar.Width) / 2) - 100;
            btnAceptar.Top = ((this.Height - btnAceptar.Height) / 2);
        }
    }
}
