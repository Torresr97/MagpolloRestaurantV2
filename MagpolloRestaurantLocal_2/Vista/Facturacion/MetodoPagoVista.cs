using AppTRchicken.Utilidades;
using AppTRchicken.Vista.Facturacion;
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
        private void CerrarFormulariosDePago()
        {
            // Verificar y cerrar si los formularios de métodos de pago están abiertos

            // Verificar si la vista de pago en efectivo está abierta
            Efectivovista efectivovista = Efectivovista.Abrir1vez();
            if (efectivovista != null && !efectivovista.IsDisposed)
            {
                efectivovista.Close();
            }

            // Verificar si la vista de pago con tarjeta está abierta
            Tarjetavista tarjetavista = Tarjetavista.Abrir1vez();
            if (tarjetavista != null && !tarjetavista.IsDisposed)
            {
                tarjetavista.Close();
            }

            // Verificar si la vista de pago mixto está abierta
            MixtoVista mixtovista = MixtoVista.Abrir1vez();
            if (mixtovista != null && !mixtovista.IsDisposed)
            {
                mixtovista.Close();
            }

            //// Verificar si la vista de pago por transferencia está abierta
            //Transferenciavista transferenciavista = Transferenciavista.Abrir1vez();
            //if (transferenciavista != null && !transferenciavista.IsDisposed)
            //{
            //    transferenciavista.Close();
            //}
        }


        private void Form_Resize(object sender, EventArgs e)
        {
            // Verificar si el formulario ha sido minimizado
            if (this.WindowState == FormWindowState.Minimized)
            {
                // Cerrar el formulario si ha sido minimizado
                this.Close();
            }
        }
        private void btnefectivo_Click(object sender, EventArgs e)
        {
            // Establecer método de pago global
            Globales.metodopago = btnefectivo.Text;

            // Cerrar cualquier otro formulario de pago que esté abierto
            CerrarFormulariosDePago();

            // Abrir la vista de pago en efectivo
            Efectivovista efectivovista = Efectivovista.Abrir1vez();
            efectivovista.Show();
            this.Close(); // Opcional, cierra el formulario actua

        }

        private void btntarjeta_Click(object sender, EventArgs e)
        {
            Globales.metodopago = btntarjeta.Text;

            // Cerrar cualquier otro formulario de pago que esté abierto
            CerrarFormulariosDePago();
            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
           
            Tarjetavista Tarjetavista = Tarjetavista.Abrir1vez();
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

        private void btnmixto_Click(object sender, EventArgs e)
        {
            Globales.metodopago = btnmixto.Text;
            // Cerrar cualquier otro formulario de pago que esté abierto
            CerrarFormulariosDePago();
            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/

            MixtoVista MixtoVista = MixtoVista.Abrir1vez();
            MixtoVista.Show();
            this.Close();
        }

        private void MetodoPagoVista_Load(object sender, EventArgs e)
        {

        }

        private void btntranferencia_Click(object sender, EventArgs e)
        {
            Globales.metodopago = btntranferencia.Text;
            // Cerrar cualquier otro formulario de pago que esté abierto
            CerrarFormulariosDePago();
            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/

            TransferenciaVista TransferenciaVista = TransferenciaVista.Abrir1vez();
            TransferenciaVista.Show();
            this.Close();
        }
    }
}
