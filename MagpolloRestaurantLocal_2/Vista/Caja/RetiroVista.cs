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
    public partial class RetiroVista : Form
    {
        public RetiroVista()
        {
            InitializeComponent();
        }

        private void RetiroVista_Load(object sender, EventArgs e)
        {
            actualizarsaldos();
        }


        private void btnretirar_Click(object sender, EventArgs e)
        {
           

                         caja caja = new caja();
            caja.Tipo = "Retiro";
            caja.Motivo = txtmotivoretiro.Text;
            caja.Totalefectivo = Convert.ToDecimal(txtmontoretiro.Text);
            caja.Totaltarjeta = 0;
            caja.Ventatotal = 0;
            caja.Fecha = Globales.fecha;
            caja.Numerotipo = Globales.numerocierre;

            caja cajas = new caja();
            cajas = ControladorCaja.Instance.totaldepositoycierre(Globales.fecha, "Retiro", Globales.numerocierre);
            

            try
            {
                if (caja.Totalefectivo < Globales.disponible) { 
                    ControladorCaja.Instance.save(caja);
                    MessageBox.Show("Retiro Realizado");
                    Globales.retiro += (long)caja.Totalefectivo;
                   

                    sucursales sucursal = new sucursales();
                    sucursal = ControladorSucursal.Instance.find();

                    impresoras impresoras = new impresoras();
                    impresoras = ControladorImpresora.Instance.findconfig();


                    CrearTicket ticket = new CrearTicket();
                    ticket.AbreCajon();//Para abrir el cajon de dinero.//Datos de la cabecera del Ticket.
                    ticket.TextoCentro("RETIRO DE CAJA");
                    ticket.TextoCentro(sucursal.Nombresucursal);
                    ticket.TextoCentro(sucursal.Direccion);
                    ticket.TextoIzquierda("Cajero:" + Globales.nombreusuario);
                    ticket.TextoIzquierda(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString());
                    ticket.lineasGuion();
                    ticket.TextoIzquierda("Motivo: " + caja.Motivo);
                    ticket.TextoIzquierda(" ");
                    ticket.TextoIzquierda("Total: L." + caja.Totalefectivo);
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
                else
                {
                    MessageBox.Show("Fondos Insuficientes");
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private static RetiroVista fmrRetiroVista = null;
        internal static RetiroVista Abrir1vez()
        {
            if (((fmrRetiroVista == null) || (fmrRetiroVista.IsDisposed == true)))
            {
                fmrRetiroVista = new RetiroVista();
            }
            fmrRetiroVista.BringToFront();
            return fmrRetiroVista;
        }


        private void btndepositar_KeyPress(object sender, KeyPressEventArgs e)
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



        private void actualizarsaldos()
        {


            /*aqui averigua cual es el numero de grupo a cerrar*/
            facturas numerocierre = new facturas();
            numerocierre = ControladorFacturas.Instance.Findnumerocierre(Globales.fecha);
            Globales.numerocierre = numerocierre.Numerocierre;

            caja cajas = new caja();
            cajas = ControladorCaja.Instance.totaldepositoycierre(Globales.fecha, "Retiro", Globales.numerocierre);
            Globales.retiro = (long)cajas.Totalefectivo;

            caja cajas2 = new caja();
            cajas2 = ControladorCaja.Instance.totaldepositoycierre(Globales.fecha, "Deposito", Globales.numerocierre);
            Globales.deposito = (long)cajas2.Totalefectivo;

            //verifica si hay suciciente efectivo en caja para hacer el retiro
            int totalefectivosegunsistema;
            facturas facturaefectivo = new facturas();
            facturaefectivo = ControladorFacturas.Instance.totalefectivofacturado(Globales.fecha, "Efectivo", Globales.numerocierre);
            totalefectivosegunsistema = (int)facturaefectivo.Total;

            Globales.disponible = (totalefectivosegunsistema  - Globales.retiro);


            usuarios usuarios = new usuarios();
            usuarios = ControladorUsuario.Instance.findidbynombre(Globales.nombreusuario);
            Globales.idusuario = (int)usuarios.Idusuario;
            roles roles = new roles();
            roles = ControladorRoles.Instance.findrolebynombreusuario(Globales.nombreusuario);



            if (roles.Roles != "cajero")
            {
                if (Globales.disponible > 0)
                {
                    lbldisponible.ForeColor = Color.Green;

                    lbldisponible.Text = Globales.disponible.ToString();
                }
                else
                {
                    lbldisponible.ForeColor = Color.Red;
                    lbldisponible.Text = Globales.disponible.ToString();

                }
            }


        }

        private void btnactualizarsaldo_Click(object sender, EventArgs e)
        {
            actualizarsaldos();
        }
    }
    }
