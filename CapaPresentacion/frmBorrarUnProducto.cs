using Entidades;
using System;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class frmBorrarUnProducto : Form {
		public frmBorrarUnProducto() {
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e) {
			if((cbxEmpresas.SelectedItem.ToString() != ""))
            {
                if((cbxProductos.SelectedItem.ToString() != ""))
                {
                    int idMarca = Program.gestor.SelectIDMarca(cbxEmpresas.SelectedItem.ToString());
                    Program.gestor.DeleteProduct(cbxProductos.SelectedItem.ToString(), idMarca);
                }
                else
                {
                    MessageBox.Show("Eliga un producto, para borrar el producto en cuestion");
                }
                
            }
            else
            {
                MessageBox.Show("Eliga una marca y un producto, para borrar el producto en cuestion");
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
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del formulario de borrado de Producto?", "Salir del borrado del Producto", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmBorrarUnProducto_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //grpCreacion
            grpCreacion.Left = ((this.Width - grpCreacion.Width) / 2) - 80;
            grpCreacion.Top = ((this.Height - grpCreacion.Height) / 2) - 100;
            //btnAceptar
            btnAceptar.Left = ((this.Width - btnAceptar.Width) / 2) - 100;
            btnAceptar.Top = ((this.Height - btnAceptar.Height) / 2);
            int cantidad = Program.gestor.SelectCountCantidadMarcas();
            if (cantidad == 0)
            {
                MessageBox.Show("No hay ninguna marca registrada, no puedes borrar ningún producto porque no existen marcas.");
                Close();
            }
            for (int i = 0; i < cantidad + 1; i++)
            {
                String nombreEmpresa = Program.gestor.SelectNombreMarca(i);
                if (nombreEmpresa != "")
                {
                    cbxEmpresas.Items.Add(nombreEmpresa);
                }
            }
        }

        private void cbxEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxProductos.Text = "";
            cbxProductos.Items.Clear();
            int idMarca = Program.gestor.SelectIDMarca(cbxEmpresas.SelectedItem.ToString());
            int cantidad = Program.gestor.SelectCountProductosMarca(idMarca);
            if (cantidad == 0)
            {
                cbxProductos.Visible = false;
                lblProducto.Visible = false;
                MessageBox.Show("No hay ningun producto registrado en esta marca, eliga otro marca.");
            }
            else
            {
                for (int i = 0; i < cantidad + 1; i++)
                {
                    String producto = Program.gestor.SelectProductoMarca(i, idMarca);
                    if (producto != "")
                    {
                        cbxProductos.Items.Add(producto);
                    }
                }
                if (cbxProductos.Items.Count > 0)
                {
                    cbxProductos.Visible = true;
                    lblProducto.Visible = true;
                }
            }
        }
    }
}
