using Entidades;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace CapaPresentacion {
    public partial class frmCrearProducto : Form {
        public frmCrearProducto() {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del formulario de creación de Producto?", "Salir de la Creación del Producto", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (txtCodigo.Text == "" || txtDescripcion.Text == "" || txtPrecio.Text == "" || txtStock.Text == "" || cboFamilia.Text == "" || cboSubFamilia.Text == "" || cboMarca.Text == "" || txtPesoNeto.Text == "" || txtPesoBruto.Text == "") {
                MessageBox.Show("¡Te has olvidado de escribir algún dato!", "Error");
            } else {
                if (!(Int32.TryParse(txtStock.Text, out int stock)))
                {
                    MessageBox.Show("El stock debe ser un número", "Error");
                } else {
                    if (!(Int32.TryParse(txtCodigo.Text, out int codigoProducto)))
                    {
                        MessageBox.Show("El codigo de producto debe ser un número", "Error");
                    }
                    else
                    {
                        Familia FElegido = (Familia)cboFamilia.SelectedItem;
                        SubFamilia SFElegido = (SubFamilia)cboSubFamilia.SelectedItem;
                        Marca marcaElegida = (Marca)cboMarca.SelectedItem;
                        String respuesta = Program.gestor.CreateProduct(new Producto(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text, stock, SFElegido.codSF, FElegido.codFamilia, marcaElegida.idmarca, txtPesoNeto.Text, txtPesoBruto.Text));
                        MessageBox.Show(respuesta);
                        frmMenuOpciones menu = new frmMenuOpciones();
                        menu.Show();

                    }
                }
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

        private void frmCrearProducto_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //grpCreacion
            grpCreacion.Left = ((this.Width - grpCreacion.Width) / 2) - 80;
            grpCreacion.Top = ((this.Height - grpCreacion.Height) / 2) - 100;
            //btnAceptar
            btnAceptar.Left = ((this.Width - btnAceptar.Width) / 2) - 100;
            btnAceptar.Top = ((this.Height - btnAceptar.Height) / 2);

            List<Marca> marcas = new List<Marca>();
            marcas = Program.gestor.BuscarMarcas();

            cboMarca.DisplayMember = "nombre";
            cboMarca.ValueMember = "idmarca";
            cboMarca.Items.Clear();
            if (marcas != null)
            {
                cboMarca.Items.AddRange(marcas.ToArray());
            }

            List<Familia> familias = new List<Familia>();
            familias = Program.gestor.BuscarFamilias();

            cboFamilia.DisplayMember = "idString";
            cboFamilia.ValueMember = "codFamilia";
            cboFamilia.Items.Clear();
            if (marcas != null)
            {
                cboFamilia.Items.AddRange(familias.ToArray());
            }

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir de la Aplicación?", "Salir de la Aplicación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void grpCreacion_Enter(object sender, EventArgs e)
        {

        }

        private void cboFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Familia FElegido = (Familia)cboFamilia.SelectedItem;
            List<SubFamilia> subfamilias = new List<SubFamilia>();
            subfamilias = Program.gestor.BuscarSubFamilias(FElegido.codFamilia);

       

            cboSubFamilia.DisplayMember = "idCaracter";
            cboSubFamilia.ValueMember = "codSF";
            cboSubFamilia.Items.Clear();
            if (subfamilias != null)
            {
                cboSubFamilia.Items.AddRange(subfamilias.ToArray());
            }
        }
    }
}
