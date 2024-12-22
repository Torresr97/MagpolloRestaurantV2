using AppTRchicken.Controlador;
using AppTRchicken.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTRchicken.Vista.Configuraciones_Generales
{
    public partial class LoginVistaGerencia : Form
    {
        public LoginVistaGerencia()
        {
            InitializeComponent();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtusuario.Text) || string.IsNullOrWhiteSpace(txtcontra.Text) || cmbDatabases.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de iniciar sesión.");
                return; // Salir del método si algún campo está vacío
            }
            Globales.IsDynamicLogin = true;
            Globales.nombreusuario = txtusuario.Text;
            Globales.Nombrebasedatos = cmbDatabases.Text.ToString();

            var result = ControladorUsuario.Instance.Validarusuariogerencia(txtusuario.Text, ControladorUsuario.Encriptar(txtcontra.Text), Globales.IsDynamicLogin, cmbDatabases.Text.ToString());

            if (result == true)
            {

                this.Hide();


                PantallaPrincipal PantallaPrincipal = new PantallaPrincipal();
                PantallaPrincipal.Show();

            }
            else
            {
                MessageBox.Show("Su Usuario o Contrasena no son validos");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                if (string.IsNullOrWhiteSpace(txtusuario.Text) || string.IsNullOrWhiteSpace(txtcontra.Text) || cmbDatabases.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de iniciar sesión.");
                    return; // Salir del método si algún campo está vacío
                }
                Globales.IsDynamicLogin = true;
                Globales.nombreusuario = txtusuario.Text;
                Globales.Nombrebasedatos = cmbDatabases.Text.ToString();

                var result = ControladorUsuario.Instance.Validarusuariogerencia(txtusuario.Text, ControladorUsuario.Encriptar(txtcontra.Text), Globales.IsDynamicLogin, cmbDatabases.SelectedItem.ToString());

                if (result == true)
                {

                    this.Hide();


                    PantallaPrincipal PantallaPrincipal = new PantallaPrincipal();
                    PantallaPrincipal.Show();

                }
                else
                {
                    MessageBox.Show("Su Usuario o Contrasena no son validos");
                }

            }
        }
    }
}
