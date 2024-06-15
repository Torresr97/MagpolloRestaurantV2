using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTRchicken.Modelo;
using AppTRchicken.Controlador;
using System.Data.SqlClient;
using AppTRchicken.Utilidades;



namespace AppTRchicken.Vista
{
    public partial class Loginvista : Form
    {
        public Loginvista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            Globales.nombreusuario = txtusuario.Text;
            


            var result = ControladorUsuario.Instance.Validarusuario(txtusuario.Text,ControladorUsuario.Encriptar(txtcontra.Text));

            if (result == true)
            {


                try
                {

                    ////// Crear y mostrar la pantalla de cocina
                    //CocinaVista cocinaVista = new CocinaVista();
                    //cocinaVista.Show();

                    // Crear y mostrar la pantalla principal
                    PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
                    pantallaPrincipal.Show();


                    this.Hide();
                }
                catch (Exception ex)
                {
                    // Mostrar un mensaje de error en caso de que alguna ventana no se abra
                    MessageBox.Show("Error al abrir las ventanas: " + ex.Message);
                    // En caso de error, mostrar de nuevo el formulario de login
                    this.Show();
                }

            }
            else
            {
                MessageBox.Show("Su Usuario o Contrasena no son validos");
            }



        }

        private void Loginvista_Load(object sender, EventArgs e)
        {
        //    MessageBox.Show("Iniciando");
        //    StartPosition = FormStartPosition.Manual;
        //    Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;
        //    int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
        //    int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
        //    Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
        //    Size = new Size(w, h);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {


                Globales.nombreusuario = txtusuario.Text;
                var result = ControladorUsuario.Instance.Validarusuario(txtusuario.Text, ControladorUsuario.Encriptar(txtcontra.Text));

                if (result == true)
                {


                    try
                    {

                        ////// Crear y mostrar la pantalla de cocina
                        //CocinaVista cocinaVista = new CocinaVista();
                        //cocinaVista.Show();

                        // Crear y mostrar la pantalla principal
                        PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
                        pantallaPrincipal.Show();

                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        // Mostrar un mensaje de error en caso de que alguna ventana no se abra
                        MessageBox.Show("Error al abrir las ventanas: " + ex.Message);
                        // En caso de error, mostrar de nuevo el formulario de login
                        this.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Su Usuario o Contrasena no son validos");
                }

            }

        }
    }
}
