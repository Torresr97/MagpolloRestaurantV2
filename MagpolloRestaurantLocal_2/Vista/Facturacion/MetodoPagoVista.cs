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

namespace AppTRchicken.Vista
{
    public partial class MetodoPagoVista : Form
    {
        public MetodoPagoVista()
        {
            InitializeComponent();
        }

        private void btnefectivo_Click(object sender, EventArgs e)
        {
            Globales.metodopago = btnefectivo.Text;
            /************Verificamos si esta abierto el formulario tarjeta y lo cerramos************/
            Tarjetavista Tarjetavista = null;
            Tarjetavista = Tarjetavista.Abrir1vez();
            Tarjetavista.Close();
            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
             que permite abrir el formulario solo 1 vez*/
            Efectivovista Efectivovista = null;
            Efectivovista = Efectivovista.Abrir1vez();
            Efectivovista.Show();
            this.Close();
           
        }

        private void btntarjeta_Click(object sender, EventArgs e)
        {
            Globales.metodopago = btntarjeta.Text;

            /************Verificamos si esta abierto el formulario tarjeta y lo cerramos************/
            Efectivovista Efectivovista = null;
            Efectivovista = Efectivovista.Abrir1vez();
            Efectivovista.Close();
            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            Tarjetavista Tarjetavista = null;
            Tarjetavista = Tarjetavista.Abrir1vez();
            Tarjetavista.Show();
            this.Close();
        }



        private static MetodoPagoVista fmrMetodoPagoVista = null;
        internal static MetodoPagoVista Abrir1vez()
        {
            if (((fmrMetodoPagoVista == null) || (fmrMetodoPagoVista.IsDisposed == true)))
            {
                fmrMetodoPagoVista = new MetodoPagoVista();
            }
            fmrMetodoPagoVista.BringToFront();
            return fmrMetodoPagoVista;
        }

       

       
    }
}
