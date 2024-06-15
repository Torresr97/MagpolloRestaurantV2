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
using AppTRchicken.Vista;


namespace AppTRchicken.Vista
{
    public partial class metodos : Form
    {

       
        public metodos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncomersqui_Click(object sender, EventArgs e)
        {
            Globales.servir = btncomersqui.Text;
            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
             que permite abrir el formulario solo 1 vez*/
            MetodoPagoVista MetodoPagoVista = null;
            MetodoPagoVista = MetodoPagoVista.Abrir1vez();
            MetodoPagoVista.Show();
            this.Close();
        }

        private void btnparallevar_Click(object sender, EventArgs e)
        {
            Globales.servir = btnparallevar.Text;
            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
             que permite abrir el formulario solo 1 vez*/
            MetodoPagoVista MetodoPagoVista = null;
            MetodoPagoVista = MetodoPagoVista.Abrir1vez();
            MetodoPagoVista.Show();
            this.Close();
        }

        private void btnadomicilio_Click(object sender, EventArgs e)
        {
            Globales.servir = btnadomicilio.Text;
            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
             que permite abrir el formulario solo 1 vez*/
            MetodoPagoVista MetodoPagoVista = null;
            MetodoPagoVista = MetodoPagoVista.Abrir1vez();
            MetodoPagoVista.Show();
            this.Close();
        }





        /*Esta funcion permite solo abrir 1 vez el formulario*/
        private static metodos fmrmetodo = null;
        internal static metodos Abrir1vez()
        {

           
                if (((fmrmetodo == null) || (fmrmetodo.IsDisposed == true)))
                {
                fmrmetodo = new metodos();
                }
            fmrmetodo.BringToFront();
                return fmrmetodo;
            }
        
    }
}
