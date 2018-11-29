﻿using System;
using System.Windows.Forms;

namespace CapaPresentacion {
	public partial class frmRegistrarse : Form {
		public frmRegistrarse()	{
			InitializeComponent();
		}

		private void btnSalir_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("De verdad, ¿Quieres salir del formulario de registro?", "Salir del Registro", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            } 
		}

		private void btnAceptar_Click(object sender, EventArgs e) {
			if(txtNombre.Text == "" || txtContraseña.Text == "") {
				MessageBox.Show("Asegurate de escribir un nombre y una contraseña", "Error");
			} else {
				//Llamar a la clase gestora de datos
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

        private void frmRegistrarse_Load(object sender, EventArgs e)
        {
            //Parametros para autocentrar los objectos según el tamaño de la pantalla
            //txtContraseña
            txtContraseña.Left = ((this.Width - txtContraseña.Width) / 2) + 25;
            txtContraseña.Top = ((this.Height - txtContraseña.Height) / 2) - 50;
            //txtNombre
            txtNombre.Left = ((this.Width - txtNombre.Width) / 2) + 25;
            txtNombre.Top = ((this.Height - txtNombre.Height) / 2) - 75;
            //lblNombre
            lblNombre.Left = ((this.Width - lblNombre.Width) / 2) - 100;
            lblNombre.Top = ((this.Height - lblNombre.Height) / 2) - 75;
            //lblContraseña
            lblContraseña.Left = ((this.Width - lblContraseña.Width) / 2) - 100;
            lblContraseña.Top = ((this.Height - lblContraseña.Height) / 2) - 50;
            //btnAcceptar
            btnAceptar.Left = ((this.Width - btnAceptar.Width) / 2) - 100;
            btnAceptar.Top = ((this.Height - btnAceptar.Height) / 2);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
