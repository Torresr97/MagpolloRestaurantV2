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
using AppTRchicken.Utilidades;
using System.Globalization;
using System.Threading;
using AppTRchicken.Vista.Configuraciones_Generales;

namespace AppTRchicken.Vista.Prueba_Vistas
{
    public partial class CierreVistaApp : Form
    {  // Crear una instancia de la cultura específica que utiliza la coma como separador de miles
        CultureInfo culture = new CultureInfo("en-US");

        int totalefectivosistema;
        int totaltarjetasistema;
        int totaldeposito;
        int totalretiro;
        int totalefectivocajero = 0;
        int totalTarjetacajero = 0;
        int valor500 = 0, valor200 = 0, valor100 = 0, valor50 = 0, valor20 = 0, valor10 = 0, valor5 = 0, valor2 = 0, valor1 = 0;

        int totalEfectivoSistema;
        int totalTarjetaSistema;
        int totalCompletoSistema;

     

        private void CierreVistaApp_Load(object sender, EventArgs e)
        { /*aqui averigua cual es el numero de grupo a cerrar*/

            facturas numerocierre = new facturas();
            numerocierre = ControladorFacturas.Instance.Findnumerocierre(Globales.fecha);
            Globales.numerocierre = numerocierre.Numerocierre;

            //trae toda la suma de ventas en efectivo
            facturas facturaefectivo = ControladorFacturas.Instance.totalefectivofacturado(Globales.fecha, "Efectivo", Globales.numerocierre);
            totalefectivosistema = (int)facturaefectivo.Total;


            //trae toda la suma de ventas en tarjeta
            facturas facturatarjeta = ControladorFacturas.Instance.totalefectivofacturado(Globales.fecha, "Tarjeta", Globales.numerocierre);
            totaltarjetasistema = (int)facturatarjeta.Total;


            //trae toda la suma de depositos por fecha 
            caja deposito = ControladorCaja.Instance.totaldepositoycierre(Globales.fecha, "Deposito", Globales.numerocierre);
            totaldeposito = (int)deposito.Totalefectivo;


            //trae toda la suma de retiros por fecha
            caja retiro = ControladorCaja.Instance.totaldepositoycierre(Globales.fecha, "Retiro", Globales.numerocierre);
            totalretiro = (int)retiro.Totalefectivo;



            usuarios usuarios = new usuarios();
            usuarios = ControladorUsuario.Instance.findidbynombre(Globales.nombreusuario);
            Globales.idusuario = (int)usuarios.Idusuario;
            roles roles = new roles();
            roles = ControladorRoles.Instance.findrolebynombreusuario(Globales.nombreusuario);
            /*Si el usuario tiene rol de admin podra hacer el cierre viendo los totales*/



            // Calcular los totales según el sistema
            totalEfectivoSistema = ((totalefectivosistema + totaldeposito) - totalretiro);
            totalTarjetaSistema = totaltarjetasistema;
            totalCompletoSistema = totalEfectivoSistema + totalTarjetaSistema;




            if (roles.Roles != "cajero")
            {
                txttotalrealefectivo.Text = totalefectivosistema.ToString("N0", culture);
                txttarjetasistema.Text = totaltarjetasistema.ToString("N0", culture);
                txtdeposito.Text = totaldeposito.ToString("N0", culture);
                txtretiro.Text = totalretiro.ToString("N0", culture);


                // Mostrar los totales según el sistema en los TextBox correspondientes
                txtefectivosistema.Text = totalEfectivoSistema.ToString("N0", culture);
                txttarjetasistema.Text = totalTarjetaSistema.ToString("N0", culture);
                txttotalventasegunsistema.Text = totalCompletoSistema.ToString("N0", culture);

            }

        }

        public CierreVistaApp()
        {
           
            InitializeComponent();

         
            // Agregar controladores de eventos para el evento TextChanged de cada TextBox
            txt500.TextChanged += TextBox_TextChanged;
            txt200.TextChanged += TextBox_TextChanged;
            txt100.TextChanged += TextBox_TextChanged;
            txt50.TextChanged += TextBox_TextChanged;
            txt20.TextChanged += TextBox_TextChanged;
            txt10.TextChanged += TextBox_TextChanged;
            txt5.TextChanged += TextBox_TextChanged;
            txt2.TextChanged += TextBox_TextChanged;
            txt1.TextChanged += TextBox_TextChanged;
        }

       

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Obtener el valor de cada denominación desde los TextBox
            valor500 = string.IsNullOrEmpty(txt500.Text) ? 0 : Convert.ToInt32(txt500.Text);
            valor200 = string.IsNullOrEmpty(txt200.Text) ? 0 : Convert.ToInt32(txt200.Text);
            valor100 = string.IsNullOrEmpty(txt100.Text) ? 0 : Convert.ToInt32(txt100.Text);
            valor50 = string.IsNullOrEmpty(txt50.Text) ? 0 : Convert.ToInt32(txt50.Text);
            valor20 = string.IsNullOrEmpty(txt20.Text) ? 0 : Convert.ToInt32(txt20.Text);
            valor10 = string.IsNullOrEmpty(txt10.Text) ? 0 : Convert.ToInt32(txt10.Text);
            valor5 = string.IsNullOrEmpty(txt5.Text) ? 0 : Convert.ToInt32(txt5.Text);
            valor2 = string.IsNullOrEmpty(txt2.Text) ? 0 : Convert.ToInt32(txt2.Text);
            valor1 = string.IsNullOrEmpty(txt1.Text) ? 0 : Convert.ToInt32(txt1.Text);

            // Calcular el total del efectivo
            totalefectivocajero = (valor500 * 500) + (valor200 * 200) + (valor100 * 100) + (valor50 * 50) + (valor20 * 20) + (valor10 * 10) + (valor5 * 5) + (valor2 * 2) + (valor1 * 1);

            // Actualizar los labels con los totales por denominación
            lbl500.Text = (valor500 * 500).ToString("N0", culture);
            lbl200.Text = (valor200 * 200).ToString("N0", culture);
            lbl100.Text = (valor100 * 100).ToString("N0", culture);
            lbl50.Text = (valor50 * 50).ToString("N0", culture);
            lbl20.Text = (valor20 * 20).ToString("N0", culture);
            lbl10.Text = (valor10 * 10).ToString("N0", culture);
            lbl5.Text = (valor5 * 5).ToString("N0", culture);
            lbl2.Text = (valor2 * 2).ToString("N0", culture);
            lbl1.Text = (valor1 * 1).ToString("N0", culture);

            //mostrar el total efectico en el txtefectivocajero 
            txtefectivocajero.Text = totalefectivocajero.ToString("N0", culture);

            // Calcular el total de tarjeta
            if (!int.TryParse(txttarjetacajero.Text, out totalTarjetacajero))
            {
                // Si la conversión falla, asignar cero
                totalTarjetacajero = 0;
            }

            // Calcular el total completo (efectivo + tarjeta)
            int totalCompleto = totalefectivocajero + totalTarjetacajero;

            // Mostrar el total en el TextBox correspondiente
            txttotalventaseguncajero.Text = totalCompleto.ToString("N0", culture);
        }
       


        private  void CargarDatosDelSistema()
        {
            
                  
          
        }

        private void txttarjetacajero_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e); // Llama al método existente para recalcular el total
        }

        private void btncierre_Click(object sender, EventArgs e)
        {

            //Aqui saco las conversiones y calculos para el cierre

            int Efectivocierrecaja = (totalefectivosistema - totalretiro);
            int Efectivocierrecajamasdeposito = (Efectivocierrecaja + totaldeposito);
            int tarjetacierrecaja = totaltarjetasistema;
            int totalcierrecaja = (Efectivocierrecaja + tarjetacierrecaja);
            int totalcierrecajamasdeposito = ((Efectivocierrecaja + tarjetacierrecaja) + totaldeposito);

            /*aqui averigua cual es el numero de grupo a cerrar*/
            facturas facturas = new facturas();
            facturas = ControladorFacturas.Instance.Findnumerocierre(Globales.fecha);

            caja caja = new caja();
            caja.Tipo = "Cierre de Caja";
            caja.Motivo = "Cierre de Caja";
            caja.Totalefectivo = Efectivocierrecaja;
            caja.Totaltarjeta = tarjetacierrecaja;
            caja.Ventatotal = totalcierrecaja;
            caja.Fecha = Globales.fecha;
            caja.Numerotipo = facturas.Numerocierre;




            try
            {
                usuarios usuarios = new usuarios();
                usuarios = ControladorUsuario.Instance.findidbynombre(Globales.nombreusuario);
                Globales.idusuario = (int)usuarios.Idusuario;
                roles roles = new roles();
                roles = ControladorRoles.Instance.findrolebynombreusuario(Globales.nombreusuario);
               

                    ControladorCaja.Instance.save(caja);
                    

                    MessageBox.Show("Realizando Cierre");


                    impresoras impresoras = new impresoras();
                    impresoras = ControladorImpresora.Instance.findconfig();




                    CrearTicket ticket = new CrearTicket();
                    ticket.AbreCajon();//Para abrir el cajon de dinero.//Datos de la cabecera del Ticket.
                    ticket.TextoCentro(Globales.sucursalnombre);
                    ticket.TextoCentro(Globales.sucursaldireccion);
                    ticket.TextoCentro("CIERRE DE CAJA #" + facturas.Numerocierre);
                    ticket.TextoIzquierda("Cajero:" + Globales.nombreusuario);
                    ticket.TextoIzquierda(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString());
                    ticket.lineasIgual();
                    ticket.TextoCentro("MOVIMIENTOS DE CAJA");
                    ticket.TextoIzquierda("DEPOSITOS:");
                    List<caja> depositos = new List<caja>();
                    depositos = ControladorCaja.Instance.Registrosxtipoxfechaxcierre("Deposito", Globales.fecha, Globales.numerocierre);
                    foreach (caja deposito in depositos)
                    {
                        ticket.Agregarinventario(deposito.Motivo, (int)deposito.Totalefectivo);
                    }
                    ticket.TextoIzquierda("TOTAL DEPOSITOS L." + totaldeposito);
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("RETIROS:");
                    List<caja> retiros = new List<caja>();
                    retiros = ControladorCaja.Instance.Registrosxtipoxfechaxcierre("Retiro", Globales.fecha, Globales.numerocierre);
                    foreach (caja retiro in retiros)
                    {
                        ticket.Agregarinventario(retiro.Motivo, (int)retiro.Totalefectivo);
                    }
                    ticket.TextoIzquierda("TOTAL RETIROS   L." + totalretiro);
                    ticket.lineasIgual();
                    ticket.TextoCentro("METODO EFECTIVO");
                    ticket.TextoIzquierda("");
                    ticket.Encabezadocierre();///encabezados desgloce de  billetes cant y total
                    ticket.TextoIzquierda("");
                    ticket.AgregaArticuloscierre(string.IsNullOrEmpty(txt500.Text) ? 0 : Convert.ToInt32(txt500.Text), "Billetes de 500", (string.IsNullOrEmpty(txt500.Text) ? 0 : Convert.ToInt32(txt500.Text)) * 500);
                    ticket.AgregaArticuloscierre(string.IsNullOrEmpty(txt200.Text) ? 0 : Convert.ToInt32(txt200.Text), "Billetes de 200", (string.IsNullOrEmpty(txt200.Text) ? 0 : Convert.ToInt32(txt200.Text)) * 200);
                    ticket.AgregaArticuloscierre(string.IsNullOrEmpty(txt100.Text) ? 0 : Convert.ToInt32(txt100.Text), "Billetes de 100", (string.IsNullOrEmpty(txt100.Text) ? 0 : Convert.ToInt32(txt100.Text)) * 100);
                    ticket.AgregaArticuloscierre(string.IsNullOrEmpty(txt50.Text) ? 0 : Convert.ToInt32(txt50.Text), "Billetes de 50", (string.IsNullOrEmpty(txt50.Text) ? 0 : Convert.ToInt32(txt50.Text)) * 50);
                    ticket.AgregaArticuloscierre(string.IsNullOrEmpty(txt20.Text) ? 0 : Convert.ToInt32(txt20.Text), "Billetes de 20", (string.IsNullOrEmpty(txt20.Text) ? 0 : Convert.ToInt32(txt20.Text)) * 20);
                    ticket.AgregaArticuloscierre(string.IsNullOrEmpty(txt10.Text) ? 0 : Convert.ToInt32(txt10.Text), "Billetes de 10", (string.IsNullOrEmpty(txt10.Text) ? 0 : Convert.ToInt32(txt10.Text)) * 10);
                    ticket.AgregaArticuloscierre(string.IsNullOrEmpty(txt5.Text) ? 0 : Convert.ToInt32(txt5.Text), "Billetes de 5", (string.IsNullOrEmpty(txt5.Text) ? 0 : Convert.ToInt32(txt5.Text)) * 5);
                    ticket.AgregaArticuloscierre(string.IsNullOrEmpty(txt2.Text) ? 0 : Convert.ToInt32(txt2.Text), "Billetes de 2", (string.IsNullOrEmpty(txt2.Text) ? 0 : Convert.ToInt32(txt2.Text)) * 2);
                    ticket.AgregaArticuloscierre(string.IsNullOrEmpty(txt1.Text) ? 0 : Convert.ToInt32(txt1.Text), "Billetes de 1", (string.IsNullOrEmpty(txt1.Text) ? 0 : Convert.ToInt32(txt1.Text)) * 1);
                    ticket.TextoIzquierda("TOTAL VENTA EFECTIVO             L." + Efectivocierrecaja);
                    ticket.TextoIzquierda("TOTAL VENTA EFECTIVO + DEPOSITO  L." + Efectivocierrecajamasdeposito);
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("CALCULOS()");
                    
                    ticket.TextoIzquierda("TOTAL EFECTIVO SEGUN SISTEMA L." + Efectivocierrecajamasdeposito);
                    ticket.TextoIzquierda("TOTAL EFECTIVO SEGUN CAJERO  L." + totalefectivocajero);
                    if (Efectivocierrecajamasdeposito > totalefectivocajero)
                    {
                        ticket.TextoIzquierda("DIFERENCIA                (-)L." + Math.Abs((Efectivocierrecajamasdeposito - totalefectivocajero)));
                    }
                    else
                    {
                        ticket.TextoIzquierda("DIFERENCIA                (+)L." + Math.Abs((Efectivocierrecajamasdeposito - totalefectivocajero)));
                    }

                    ticket.TextoIzquierda("");

                    ticket.lineasIgual();
                    ticket.TextoCentro("METODO TARJETA");
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("TOTAL VENTA TARJETA  L." + totaltarjetasistema);


                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("CALCULOS()");
                    ticket.TextoIzquierda("TOTAL TARJETA SEGUN SISTEMA L." + (totaltarjetasistema));
                    ticket.TextoIzquierda("TOTAL TARJETA SEGUN CAJERO  L." + (totalTarjetacajero));
                    if (totaltarjetasistema > totalTarjetacajero)
                    {
                        ticket.TextoIzquierda("DIFERENCIA               (-)L." + Math.Abs((totaltarjetasistema - totalTarjetacajero)));
                    }
                    else
                    {
                        ticket.TextoIzquierda("DIFERENCIA               (+)L." + Math.Abs((totaltarjetasistema - totalTarjetacajero)));
                    }
                    ticket.lineasIgual();

                    ticket.TextoIzquierda("TOTAL VENTA DEL DIA           L." + totalcierrecaja);
                    ticket.TextoIzquierda("TOTAL VENTA + DEPOSITO:       L." + totalcierrecajamasdeposito);
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("");
                    ticket.CortaTicket();
                   // ticket.ImprimirTicket("Microsoft XPS Document Writer");
                   ticket.ImprimirTicket(impresoras.Nombreimpresora);//Nombre de la impresora ticketera



                    this.Close();





                
               


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private static CierreVistaApp fmrCierreVistaApp = null;
        internal static CierreVistaApp Abrir1vez()
        {
            if (((fmrCierreVistaApp == null) || (fmrCierreVistaApp.IsDisposed == true)))
            {
                fmrCierreVistaApp = new CierreVistaApp();
            }
            fmrCierreVistaApp.BringToFront();
            return fmrCierreVistaApp;
        }
    }
}
