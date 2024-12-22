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
using System.Data.SqlClient;

namespace AppTRchicken.Vista
{
    public partial class CierreVista : Form
    {
        //PARA EFECTIVO
        decimal totalefectivosistema;
        decimal totalEfectivoSistemaMixto;
        decimal totalEfectivoSistemacompleto;
        decimal totalEfectivoSistemacompletoconretiro;
        decimal totalEfectivoSistemacompletocondesposito;

        //PARA TARJETA
        decimal totaltarjetasistema;
        decimal totalTarjetaSistemaMixto;
        decimal totalTarjetaSistemacompleto;

        //PARA TRANSFERENCIA
        decimal totaltransferenciasistema;

        //PARA DEPOSITO
        decimal totaldeposito;

        //PARA RETIRO
        decimal totalretiro;

      
       

        decimal totalefectivocajero = 0;
        decimal totalTarjetacajero = 0;
        decimal totalTransferenciacajero = 0;
        decimal totalCompletoCAJERO = 0;

        decimal valor500 = 0, valor200 = 0, valor100 = 0, valor50 = 0, valor20 = 0, valor10 = 0, valor5 = 0, valor2 = 0, valor1 = 0;

       
       
       
        decimal totalventaDia;
        decimal totalventaDiaconretiro;
        decimal totalventaDiacondeposito;


        //ESTA VARIABLE ES PARA SUMAR YA CUADRADO TODO EFECTIVO , TARJETA, TRANSFERENCIA
        decimal VENTAREALCERRARSISTEMA;


        DateTime fechaCompleta;
        DateTime soloFecha;

        private void txttarjetacajero_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e); // Llama al método existente para recalcular el total
        }

        private void btncierre_Click_1(object sender, EventArgs e)
        {

            btncierre.Enabled = false;
            //Aqui saco las conversiones y calculos para el cierre


            /*aqui averigua cual es el numero de grupo a cerrar*/
            facturas facturas = new facturas();
            facturas = ControladorFacturas.Instance.Findnumerocierre(fechaCompleta.Date.ToString("yyyy-MM-dd"));

            caja caja = new caja();
            caja.Tipo = "Cierre de Caja";
            caja.Motivo = "Cierre de Caja";
            caja.Totalefectivo = totalEfectivoSistemacompletoconretiro;
            caja.Totaltarjeta = totalTarjetaSistemacompleto;
            caja.Totaltransferencia = totaltransferenciasistema;
            caja.Ventatotal = VENTAREALCERRARSISTEMA;
            caja.Fecha = fechaCompleta.Date.ToString("yyyy-MM-dd");
            caja.Numerotipo = facturas.Numerocierre;


            try
            {
                bool cierreExistente = ControladorCaja.Instance.ValidarCierreDeCaja(caja.Fecha, caja.Numerotipo);

                if (cierreExistente)
                {
                    // Si ya existe un cierre de caja, mostramos un mensaje de advertencia y deshabilitamos el botón
                    MessageBox.Show("Ya existe un cierre de caja para esta fecha con el mismo número de tipo. No se puede crear otro cierre a menos que se elimine el existente.", "Cierre de Caja Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btncierre.Enabled = false;

                    // Cerramos la ventana actual para evitar que siga el proceso
                    this.Close();
                    return; // Es opcional pero buena práctica para asegurarte de que no continúa
                }

                usuarios usuarios = new usuarios();
                usuarios = ControladorUsuario.Instance.findidbynombre(Globales.nombreusuario);
                Globales.idusuario = (int)usuarios.Idusuario;
                roles roles = new roles();
                roles = ControladorRoles.Instance.findrolebynombreusuario(Globales.nombreusuario);


                ControladorCaja.Instance.save(caja);


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
                depositos = ControladorCaja.Instance.Registrosxtipoxfechaxcierre("Deposito", fechaCompleta.Date.ToString("yyyy-MM-dd"), Globales.numerocierre);
                foreach (caja deposito in depositos)
                {
                    ticket.Agregarinventario(deposito.Motivo, (int)deposito.Totalefectivo);
                }
                ticket.TextoIzquierda("TOTAL DEPOSITOS L." + totaldeposito.ToString("N2", CultureInfo.InvariantCulture));
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("RETIROS:");
                List<caja> retiros = new List<caja>();
                retiros = ControladorCaja.Instance.Registrosxtipoxfechaxcierre("Retiro", fechaCompleta.Date.ToString("yyyy-MM-dd"), Globales.numerocierre);
                foreach (caja retiro in retiros)
                {
                    ticket.Agregarinventario(retiro.Motivo, (int)retiro.Totalefectivo);
                }
                ticket.TextoIzquierda("TOTAL RETIROS   L." + totalretiro.ToString("N2", CultureInfo.InvariantCulture));
                ticket.lineasIgual();
                ticket.TextoCentro("METODO EFECTIVO");
                ticket.TextoIzquierda("");
                ticket.Encabezadocierre();///encabezados desgloce de  billetes cant y total
                ticket.TextoIzquierda("");
                ticket.AgregaArticuloscierreDecimales(string.IsNullOrEmpty(txt500.Text) ? 0 : Globales.ConvertToDecimal(txt500.Text), "Billetes de 500", (string.IsNullOrEmpty(txt500.Text) ? 0 : Globales.ConvertToDecimal(txt500.Text)) * 500);
                ticket.AgregaArticuloscierreDecimales(string.IsNullOrEmpty(txt200.Text) ? 0 : Globales.ConvertToDecimal(txt200.Text), "Billetes de 200", (string.IsNullOrEmpty(txt200.Text) ? 0 : Globales.ConvertToDecimal(txt200.Text)) * 200);
                ticket.AgregaArticuloscierreDecimales(string.IsNullOrEmpty(txt100.Text) ? 0 : Globales.ConvertToDecimal(txt100.Text), "Billetes de 100", (string.IsNullOrEmpty(txt100.Text) ? 0 : Globales.ConvertToDecimal(txt100.Text)) * 100);
                ticket.AgregaArticuloscierreDecimales(string.IsNullOrEmpty(txt50.Text) ? 0 : Globales.ConvertToDecimal(txt50.Text), "Billetes de 50", (string.IsNullOrEmpty(txt50.Text) ? 0 : Globales.ConvertToDecimal(txt50.Text)) * 50);
                ticket.AgregaArticuloscierreDecimales(string.IsNullOrEmpty(txt20.Text) ? 0 : Globales.ConvertToDecimal(txt20.Text), "Billetes de 20", (string.IsNullOrEmpty(txt20.Text) ? 0 : Globales.ConvertToDecimal(txt20.Text)) * 20);
                ticket.AgregaArticuloscierreDecimales(string.IsNullOrEmpty(txt10.Text) ? 0 : Globales.ConvertToDecimal(txt10.Text), "Billetes de 10", (string.IsNullOrEmpty(txt10.Text) ? 0 : Globales.ConvertToDecimal(txt10.Text)) * 10);
                ticket.AgregaArticuloscierreDecimales(string.IsNullOrEmpty(txt5.Text) ? 0 : Globales.ConvertToDecimal(txt5.Text), "Billetes de 5", (string.IsNullOrEmpty(txt5.Text) ? 0 : Globales.ConvertToDecimal(txt5.Text)) * 5);
                ticket.AgregaArticuloscierreDecimales(string.IsNullOrEmpty(txt2.Text) ? 0 : Globales.ConvertToDecimal(txt2.Text), "Billetes de 2", (string.IsNullOrEmpty(txt2.Text) ? 0 : Globales.ConvertToDecimal(txt2.Text)) * 2);
                ticket.AgregaArticuloscierreDecimales(string.IsNullOrEmpty(txt1.Text) ? 0 : Globales.ConvertToDecimal(txt1.Text), "Billetes de 1", (string.IsNullOrEmpty(txt1.Text) ? 0 : Globales.ConvertToDecimal(txt1.Text)) * 1);
                ticket.TextoIzquierda("");
                ticket.lineasIgual(); // Línea divisoria
                // Encabezado para la sección de Efectivo
                ticket.TextoCentro("DETALLE VENTA EFECTIVO");
                ticket.TextoIzquierda("VENTA EFECTIVO NETA           L." + totalEfectivoSistemacompleto.ToString("N2", CultureInfo.InvariantCulture));
                ticket.TextoIzquierda("VENTA EFECTIVO - RETIRO       L." + totalEfectivoSistemacompletoconretiro.ToString("N2", CultureInfo.InvariantCulture));
                ticket.TextoIzquierda("VENTA EFECTIVO + DEPOSITO     L." + totalEfectivoSistemacompletocondesposito.ToString("N2", CultureInfo.InvariantCulture));
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("TOTAL EFECTIVO SEGÚN SISTEMA  L." + totalEfectivoSistemacompletocondesposito.ToString("N2", CultureInfo.InvariantCulture));
                ticket.TextoIzquierda("TOTAL EFECTIVO SEGÚN CAJERO   L." + totalefectivocajero.ToString("N2", CultureInfo.InvariantCulture));

                // Diferencia en efectivo
                if (totalEfectivoSistemacompletocondesposito > totalefectivocajero)
                {
                    ticket.TextoIzquierda("DIFERENCIA (-)                L." + Math.Abs(totalEfectivoSistemacompletocondesposito - totalefectivocajero).ToString("N2", CultureInfo.InvariantCulture));
                }
                else
                {
                    ticket.TextoIzquierda("DIFERENCIA (+)                L." + Math.Abs(totalEfectivoSistemacompletocondesposito - totalefectivocajero).ToString("N2", CultureInfo.InvariantCulture));
                }
                ticket.TextoIzquierda(""); // Espacio en blanco

                // Encabezado para la sección de Tarjetas
                ticket.lineasIgual(); // Línea divisoria
                ticket.TextoCentro(" DETALLE VENTA TARJETA");
                ticket.TextoIzquierda("TOTAL VENTA TARJETA          L." + totalTarjetaSistemacompleto.ToString("N2", CultureInfo.InvariantCulture));
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("TOTAL TARJETA SEGÚN SISTEMA  L." + totalTarjetaSistemacompleto.ToString("N2", CultureInfo.InvariantCulture));
                ticket.TextoIzquierda("TOTAL TARJETA SEGÚN CAJERO   L." + totalTarjetacajero.ToString("N2", CultureInfo.InvariantCulture));

                // Diferencia en tarjeta
                if (totalTarjetaSistemacompleto > totalTarjetacajero)
                {
                    ticket.TextoIzquierda("DIFERENCIA (-)               L." + Math.Abs(totalTarjetaSistemacompleto - totalTarjetacajero).ToString("N2", CultureInfo.InvariantCulture));
                }
                else
                {
                    ticket.TextoIzquierda("DIFERENCIA (+)               L." + Math.Abs(totalTarjetaSistemacompleto - totalTarjetacajero).ToString("N2", CultureInfo.InvariantCulture));
                }
                ticket.TextoIzquierda(""); // Espacio en blanco

                ticket.TextoIzquierda(""); // Espacio en blanco

                // Encabezado para la sección de Tarjetas
                ticket.lineasIgual(); // Línea divisoria
                ticket.TextoCentro(" DETALLE VENTA TRANSFERENCIA");
                ticket.TextoIzquierda("TOTAL VENTA TRANSFERENCIA     L." + totaltransferenciasistema.ToString("N2", CultureInfo.InvariantCulture));
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("TRANSFERENCIA SEGÚN SISTEMA   L." + totaltransferenciasistema.ToString("N2", CultureInfo.InvariantCulture));
                ticket.TextoIzquierda("TRANSFERENCIA SEGÚN CAJERO    L." + totalTransferenciacajero.ToString("N2", CultureInfo.InvariantCulture));

                // Diferencia en tarjeta
                if (totaltransferenciasistema > totalTransferenciacajero)
                {
                    ticket.TextoIzquierda("DIFERENCIA (-)               L." + Math.Abs(totaltransferenciasistema - totalTransferenciacajero).ToString("N2", CultureInfo.InvariantCulture));
                }
                else
                {
                    ticket.TextoIzquierda("DIFERENCIA (+)               L." + Math.Abs(totaltransferenciasistema - totalTransferenciacajero).ToString("N2", CultureInfo.InvariantCulture));
                }
                ticket.TextoIzquierda(""); // Espacio en blanco

                // Resumen final del día
                ticket.lineasIgual(); // Línea divisoria
                ticket.TextoCentro("CIERRE FINAL");
                ticket.TextoIzquierda("TOTAL VENTA NETA              L." + totalventaDia.ToString("N2", CultureInfo.InvariantCulture));
                ticket.TextoIzquierda("TOTAL VENTA DÍA - RETIRO      L." + totalventaDiaconretiro.ToString("N2", CultureInfo.InvariantCulture));
                ticket.TextoIzquierda("TOTAL VENTA + DEPOSITO        L." + totalventaDiacondeposito.ToString("N2", CultureInfo.InvariantCulture));
                ticket.lineasIgual(); // Línea divisoria

                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.CortaTicket();
                //ticket.ImprimirTicket("Microsoft XPS Document Writer");
                ticket.ImprimirTicket(impresoras.Nombreimpresora);//Nombre de la impresora ticketera



                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Rehabilitar el botón después de que el proceso termine
                btncierre.Enabled = true;
                VentaProductoDia(Globales.fecha);

            }

        }

        public void VentaProductoDia(string fecha)
        {
            try
            {
                // Obtener información de la sucursal e impresora
                sucursales sucursal = ControladorSucursal.Instance.find();
                impresoras impresoras = ControladorImpresora.Instance.findconfig();

                // Crear instancia de CrearTicket para generar el ticket
                CrearTicket ticket = new CrearTicket();
                ticket.AbreCajon(); // Para abrir el cajón de dinero

                // Encabezado del ticket
                ticket.TextoCentro(sucursal.Nombresucursal);
                ticket.TextoCentro(sucursal.Direccion);
                ticket.TextoIzquierda("Cajero: " + Globales.nombreusuario);
                ticket.TextoIzquierda(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString());
                ticket.lineasGuion();
                ticket.TextoCentro("REPORTE DE PRODUCTOS VENDIDOS");
                ticket.TextoIzquierda(" ");

                // Encabezados de la tabla
                ticket.EncabezadoReporteinventario(); // Adaptar el método para los encabezados necesarios
                ticket.TextoIzquierda(" ");

                // Consulta para obtener los productos vendidos
                string query = $"SELECT nombrecombo + ' ' + complementos AS nombre_completo, SUM(cantidad) AS cantidad, SUM(total) AS total " +
                       $"FROM [{Globales.basedatos}].[dbo].[V_Reportexproducto] " +
                       $"WHERE CONVERT(DATE, fecha) = '{fecha}' " +
                       $"GROUP BY nombrecombo, complementos " +
                       $"ORDER BY nombre_completo";

                using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConnectionString()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Agregar cada producto al ticket
                    while (reader.Read())
                    {
                        string nombreProducto = reader["nombre_completo"].ToString();
                        int cantidad = Convert.ToInt32(reader["cantidad"]);
                        decimal total = Convert.ToDecimal(reader["total"]);

                        // Agregar información del producto al ticket
                        ticket.Agregarinventario(nombreProducto, cantidad);
                    }

                    reader.Close();
                }

                // Pie de ticket
                ticket.TextoIzquierda(" ");
                ticket.TextoIzquierda(" ");
                ticket.TextoIzquierda(" ");
                ticket.CortaTicket();
                ticket.ImprimirTicket(impresoras.Nombreimpresora); // Nombre de la impresora ticketera
                //ticket.ImprimirTicket("Microsoft XPS Document Writer");
                MessageBox.Show("Reporte de productos vendidos generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txttransferenciacajero_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e); // Llama al método existente para recalcular el total
        }

      
        public CierreVista()
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
            txttarjetacajero.TextChanged += TextBox_TextChanged;
            txttransferenciacajero.TextChanged += TextBox_TextChanged;


            fechaCompleta = DateTime.Now;
            soloFecha = fechaCompleta.Date;
        }
        private static CierreVista fmrCierreVista = null;
        internal static CierreVista Abrir1vez()
        {
            if (((fmrCierreVista == null) || (fmrCierreVista.IsDisposed == true)))
            {
                fmrCierreVista = new CierreVista();
                // Conectar los eventos aquí para asegurarnos de que siempre estén activos
                //fmrCierreVista.Deactivate += fmrCierreVista_Deactivate;
                //fmrCierreVista.LostFocus += fmrCierreVista_LostFocus;
                //fmrCierreVista.Resize += fmrCierreVista_Resize;
            }
            fmrCierreVista.BringToFront();
            return fmrCierreVista;
        }
        private void panelPrincipal_Resize(object sender, EventArgs e)
        {
            // Obtener el ancho y alto del panel principal
            int anchoTotal = panelprincipal.ClientSize.Width;
            int altoTotal = panelprincipal.ClientSize.Height;

            // Calcular el ancho para cada panel hijo (30% y 70% del ancho total)
            int anchoPanelIzquierdo = (int)(anchoTotal * 0.4);
            int anchoPanelDerecho = anchoTotal - anchoPanelIzquierdo;

            // Establecer el tamaño y posición del panel izquierdo
            panelIzquierdo.Width = anchoPanelIzquierdo;
            panelIzquierdo.Height = altoTotal;
            panelIzquierdo.Location = new Point(0, 0);

            // Establecer el tamaño y posición del panel derecho
            panelDerecho.Width = anchoPanelDerecho;
            panelDerecho.Height = altoTotal;
            panelDerecho.Location = new Point(anchoPanelIzquierdo, 0);
        }

        //private static void fmrCierreVista_Deactivate(object sender, EventArgs e)
        //{
        //    // Cuando el formulario pierde el foco, cerrarlo
        //    if (((CierreVista)sender).WindowState != FormWindowState.Minimized)
        //    {
        //        ((CierreVista)sender).Close();
        //    }
        //}

        //private static void fmrCierreVista_LostFocus(object sender, EventArgs e)
        //{
        //    // Cerrar el formulario cuando pierde el foco
        //    ((CierreVista)sender).Close();
        //}

        //private static void fmrCierreVista_Resize(object sender, EventArgs e)
        //{
        //    // Si el formulario se minimiza, lo cerramos automáticamente
        //    if (((CierreVista)sender).WindowState == FormWindowState.Minimized)
        //    {
        //        ((CierreVista)sender).Close();
        //    }
        //}
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Obtener el valor de cada denominación desde los TextBox
            valor500 = string.IsNullOrEmpty(txt500.Text) ? 0m : Globales.ConvertToDecimal(txt500.Text);
            valor200 = string.IsNullOrEmpty(txt200.Text) ? 0m : Globales.ConvertToDecimal(txt200.Text);
            valor100 = string.IsNullOrEmpty(txt100.Text) ? 0m : Globales.ConvertToDecimal(txt100.Text);
            valor50 = string.IsNullOrEmpty(txt50.Text) ? 0m : Globales.ConvertToDecimal(txt50.Text);
            valor20 = string.IsNullOrEmpty(txt20.Text) ? 0m : Globales.ConvertToDecimal(txt20.Text);
            valor10 = string.IsNullOrEmpty(txt10.Text) ? 0m : Globales.ConvertToDecimal(txt10.Text);
            valor5 = string.IsNullOrEmpty(txt5.Text) ? 0m : Globales.ConvertToDecimal(txt5.Text);
            valor2 = string.IsNullOrEmpty(txt2.Text) ? 0m : Globales.ConvertToDecimal(txt2.Text);
            valor1 = string.IsNullOrEmpty(txt1.Text) ? 0m : Globales.ConvertToDecimal(txt1.Text);


            // Calcular el total del efectivo
            totalefectivocajero = (valor500 * 500) + (valor200 * 200) + (valor100 * 100) + (valor50 * 50) + (valor20 * 20) + (valor10 * 10) + (valor5 * 5) + (valor2 * 2) + (valor1 * 1);

            // Actualizar los labels con los totales por denominación
            lbl500.Text = (valor500 * 500).ToString("N2", CultureInfo.InvariantCulture);
            lbl200.Text = (valor200 * 200).ToString("N2", CultureInfo.InvariantCulture);
            lbl100.Text = (valor100 * 100).ToString("N2", CultureInfo.InvariantCulture);
            lbl50.Text = (valor50 * 50).ToString("N2", CultureInfo.InvariantCulture);
            lbl20.Text = (valor20 * 20).ToString("N2", CultureInfo.InvariantCulture);
            lbl10.Text = (valor10 * 10).ToString("N2", CultureInfo.InvariantCulture);
            lbl5.Text = (valor5 * 5).ToString("N2", CultureInfo.InvariantCulture);
            lbl2.Text = (valor2 * 2).ToString("N2", CultureInfo.InvariantCulture);
            lbl1.Text = (valor1 * 1).ToString("N2", CultureInfo.InvariantCulture);

            //mostrar el total efectico en el txtefectivocajero 
            txtefectivocajero.Text = totalefectivocajero.ToString("N2", CultureInfo.InvariantCulture);



            totalTarjetacajero = string.IsNullOrEmpty(txttarjetacajero.Text) ? 0m : Globales.ConvertToDecimal(txttarjetacajero.Text);

            totalTransferenciacajero = string.IsNullOrEmpty(txttransferenciacajero.Text) ? 0m : Globales.ConvertToDecimal(txttransferenciacajero.Text);
            // Calcular el total completo (efectivo + tarjeta)
            totalCompletoCAJERO = totalefectivocajero + totalTarjetacajero + totalTransferenciacajero;

            // Mostrar el total en el TextBox correspondiente
            txttotalventaseguncajero.Text = totalCompletoCAJERO.ToString("N2", CultureInfo.InvariantCulture);
        }

        private void CierreVista_Load(object sender, EventArgs e)
        {
            panelprincipal.Resize += panelPrincipal_Resize;
            panelPrincipal_Resize(panelprincipal, EventArgs.Empty); // Inicializar el tamaño correcto al inicio

            facturas numerocierre = new facturas();
            numerocierre = ControladorFacturas.Instance.Findnumerocierre(soloFecha.ToString("yyyy-MM-dd"));
            Globales.numerocierre = numerocierre.Numerocierre;


            //trae toda la suma de ventas en efectivo
            facturas facturaefectivo = ControladorFacturas.Instance.totalefectivofacturado(soloFecha.ToString("yyyy-MM-dd"), "Efectivo", Globales.numerocierre);
            totalefectivosistema = facturaefectivo.Total;


            //trae toda la suma de ventas en tarjeta
            facturas facturatarjeta = ControladorFacturas.Instance.totalefectivofacturado(soloFecha.ToString("yyyy-MM-dd"), "Tarjeta", Globales.numerocierre);
            totaltarjetasistema = facturatarjeta.Total;

            //trae toda la suma de ventas en Trransferencia
            facturas facturatransferencia = ControladorFacturas.Instance.totalefectivofacturado(soloFecha.ToString("yyyy-MM-dd"), "Transferencia", Globales.numerocierre);
            totaltransferenciasistema = facturatransferencia.Total;

            //trae toda la suma de ventas mixto efectivo
            DetallePagoMixto DetallePagoMixtoEfectivo = ControladorDetallepagomixto.Instance.totalefectivoMixto(soloFecha.ToString("yyyy-MM-dd"), "Efectivo", Globales.numerocierre);
            totalEfectivoSistemaMixto = DetallePagoMixtoEfectivo.Monto;

            //trae toda la suma de ventas mixto tarjeta
            DetallePagoMixto DetallePagoMixtoTarjeta = ControladorDetallepagomixto.Instance.totalefectivoMixto(soloFecha.ToString("yyyy-MM-dd"), "Tarjeta", Globales.numerocierre);
            totalTarjetaSistemaMixto = DetallePagoMixtoTarjeta.Monto;


            //trae toda la suma de depositos por fecha 
            caja deposito = ControladorCaja.Instance.totaldepositoycierre(soloFecha.ToString("yyyy-MM-dd"), "Deposito", Globales.numerocierre);
            totaldeposito = deposito.Totalefectivo;


            //trae toda la suma de retiros por fecha
            caja retiro = ControladorCaja.Instance.totaldepositoycierre(soloFecha.ToString("yyyy-MM-dd"), "Retiro", Globales.numerocierre);
            totalretiro = (int)retiro.Totalefectivo;

            // EL TOTAL DE EFECTIVO SEGUN EL SISTEMA SUMA EFECTIVO MAS LO MIXTO
            totalEfectivoSistemacompleto = (totalefectivosistema + totalEfectivoSistemaMixto);
            totalEfectivoSistemacompletoconretiro = (totalEfectivoSistemacompleto - totalretiro);
            totalEfectivoSistemacompletocondesposito = (totalEfectivoSistemacompletoconretiro + totaldeposito);
            // EL TOTAL DE EFECTIVO SEGUN EL SISTEMA SUMA EFECTIVO MAS LO MIXTO
            totalTarjetaSistemacompleto = (totaltarjetasistema + totalTarjetaSistemaMixto);



            // para cerrar el cierre 
            totalventaDia = (totalEfectivoSistemacompleto + totalTarjetaSistemacompleto + totaltransferenciasistema);
            totalventaDiaconretiro = (totalventaDia - totalretiro);
            totalventaDiacondeposito = (totalventaDiaconretiro + totaldeposito);
            VENTAREALCERRARSISTEMA = (totalEfectivoSistemacompletoconretiro + totalTarjetaSistemacompleto + totaltransferenciasistema);

            usuarios usuarios = new usuarios();
            usuarios = ControladorUsuario.Instance.findidbynombre(Globales.nombreusuario);
            Globales.idusuario = (int)usuarios.Idusuario;
            roles roles = new roles();
            roles = ControladorRoles.Instance.findrolebynombreusuario(Globales.nombreusuario);
            /*Si el usuario tiene rol de admin podra hacer el cierre viendo los totales*/



            if (roles.Roles != "cajero")
            {
               
                txtdeposito.Text = totaldeposito.ToString("N2", CultureInfo.InvariantCulture);
                txtretiro.Text = totalretiro.ToString("N2", CultureInfo.InvariantCulture);

                txttotalrealefectivo.Text = totalEfectivoSistemacompleto.ToString("N2", CultureInfo.InvariantCulture);
                txtefectivosistema.Text = totalEfectivoSistemacompletocondesposito.ToString("N2", CultureInfo.InvariantCulture);
                txttarjetasistema.Text = totalTarjetaSistemacompleto.ToString("N2", CultureInfo.InvariantCulture);
                txttransferenciasistema.Text = totaltransferenciasistema.ToString("N2", CultureInfo.InvariantCulture);
                txttotalventasegunsistema.Text = totalventaDiacondeposito.ToString("N2", CultureInfo.InvariantCulture);

            }
        }
    }

}


