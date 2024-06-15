using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTRchicken.Controlador;
using AppTRchicken.Modelo;
using AppTRchicken.Utilidades;

namespace AppTRchicken.Vista
{
    public partial class DepositoVista : Form
    {
        public DepositoVista()
        {
            InitializeComponent();
        }

        private void txtdinerorecibido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btndepositar_Click(object sender, EventArgs e)
        {
            caja caja = new caja();
            caja.Tipo = "Deposito";
            caja.Motivo = txtmotivodeposito.Text;
            caja.Totalefectivo = Convert.ToDecimal(txtmontodeposito.Text);
            caja.Totaltarjeta = 0;
            caja.Ventatotal = 0;
            caja.Fecha = Globales.fecha;


            caja cajagrupocierre = new caja();
            cajagrupocierre = ControladorCaja.Instance.findgrupocierre(Globales.fecha);
            if (cajagrupocierre.Numerotipo == 0)
            {
                caja.Numerotipo = 1;


            }
            else
            {
                 caja.Numerotipo = (cajagrupocierre.Numerotipo + 1);

            }

            caja cajas = new caja();
            cajas = ControladorCaja.Instance.totaldepositoycierre(Globales.fecha , "Deposito", Globales.numerocierre);
            MessageBox.Show(cajas.Totalefectivo.ToString());

            try
            {
                ControladorCaja.Instance.save(caja);
                MessageBox.Show("Deposito Realizado");
                Globales.deposito = ((long)caja.Totalefectivo+ (long)cajas.Totalefectivo);
               

                sucursales sucursal = new sucursales();
                sucursal = ControladorSucursal.Instance.find();

                impresoras impresoras = new impresoras();
                impresoras = ControladorImpresora.Instance.findconfig();


                CrearTicket ticket = new CrearTicket();
                ticket.AbreCajon();//Para abrir el cajon de dinero.//Datos de la cabecera del Ticket.
                ticket.TextoCentro("DEPOSITO CAJA");
                ticket.TextoCentro(sucursal.Nombresucursal);
                ticket.TextoCentro(sucursal.Direccion);
                ticket.TextoIzquierda("Cajero:" + Globales.nombreusuario);
                ticket.TextoIzquierda(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString());
                ticket.lineasGuion();
                ticket.TextoIzquierda("Motivo: "+ caja.Motivo);
                ticket.TextoIzquierda(" ");
                ticket.TextoIzquierda("Total: L" + caja.Totalefectivo);
                ticket.TextoIzquierda(" ");
                ticket.TextoIzquierda(" ");
                ticket.TextoIzquierda(" ");
                ticket.TextoIzquierda(" ");
                ticket.TextoIzquierda(" ");
                ticket.TextoIzquierda(" ");
                ticket.TextoIzquierda(" ");
                ticket.TextoIzquierda(" ");
                ticket.CortaTicket();
                ticket.ImprimirTicket(impresoras.Nombreimpresora);//Nombre de la impresora ticketera




                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private static DepositoVista fmrDepositoVista = null;
        internal static DepositoVista Abrir1vez()
        {
            if (((fmrDepositoVista == null) || (fmrDepositoVista.IsDisposed == true)))
            {
                fmrDepositoVista = new DepositoVista();
            }
            fmrDepositoVista.BringToFront();
            return fmrDepositoVista;
        }


        private void DepositoVista_Load(object sender, EventArgs e)
        {

        }
    }
}
