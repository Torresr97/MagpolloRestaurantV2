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


namespace AppTRchicken.Vista
{
    public partial class ListaFacturasVista : Form
    {
        public ListaFacturasVista()
        {
            InitializeComponent();
        }

        private void ListaFacturasVista_Load(object sender, EventArgs e)
        {/*aqui averigua cual es el numero de grupo a cerrar*/

            usuarios usuarios = new usuarios();
            usuarios = ControladorUsuario.Instance.findidbynombre(Globales.nombreusuario);
            Globales.idusuario = (int)usuarios.Idusuario;
            roles roles = new roles();
            roles = ControladorRoles.Instance.findrolebynombreusuario(Globales.nombreusuario);
            if (roles.Roles != "cajero")
            {
                facturas numerocierre = new facturas();
                numerocierre = ControladorFacturas.Instance.Findnumerocierre(Globales.fecha);
                Globales.numerocierre = numerocierre.Numerocierre;

                cargardg();
                calcularventas();

            }
            else
            {
                facturas numerocierre = new facturas();
                numerocierre = ControladorFacturas.Instance.Findnumerocierre(Globales.fecha);
                Globales.numerocierre = numerocierre.Numerocierre;
                cargardg();
                dglistafacturas.Columns.RemoveAt(8);
            }

            
        }

        




        private void cargardg()
        {
            dglistafacturas.Rows.Clear();
            List<facturas> fac = new List<facturas>();
            fac = ControladorFacturas.Instance.FincfacturaFecha(Globales.fecha,Globales.numerocierre);

            foreach (facturas factura in fac)
            {


                //buscar el role por medio del idrole antes de ingresarlo
                dglistafacturas.Rows.Add(factura.Idfactura, factura.Facturacai,factura.Orden, factura.Descuento, factura.Tipopago, factura.Total, factura.Dinerorecibido, factura.Dineroentregado);
            }


          


        }

        private void dglistafacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == 8)  //Dónde la columna con el botón es la 6 con posición 5
            {
                facturas facturas = new facturas();
                facturas.Idfactura = Convert.ToInt32(dglistafacturas.Rows[dglistafacturas.CurrentRow.Index].Cells["codigofactura"].Value);
                try
                {
                    DialogResult result = MessageBox.Show("Esta Seguro de Eliminar esta Factura?", "Eliminar Factura", MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            facturas factura = new facturas();
                            factura.Idfactura = Convert.ToInt64(dglistafacturas.Rows[e.RowIndex].Cells[0].Value);
                            factura.Estado = false;
                            ControladorFacturas.Instance.update(facturas);//Actualiza la factura a estado 0 
                            /************************ActualizaInventario*****************************************/
                            List<detalle_factura> df = new List<detalle_factura>();
                            df = ControladorDetalle_Factura.Instance.findbyid((int)factura.Idfactura);

                            foreach (detalle_factura detalle_factura in df)
                            {

                          


                                /*Aqui buscamos en la configuracion de inventario los productos a restar de inventario por medio del IDmenu*/
                                List<configinventario> configinventario = new List<configinventario>();
                                configinventario = Controladorconfiginventario.Instance.findbyid(detalle_factura.Idmenu);

                                foreach (configinventario d in configinventario)
                                {
                                    // MessageBox.Show(d.Idinventario.ToString() + "menos " + d.Cantidadrestar.ToString());
                                    configinventario configinv = new configinventario();
                                    configinv.Idinventario = d.Idinventario;
                                    configinv.Cantidadrestar = (d.Cantidadrestar * detalle_factura.Cantidad);
                                    Controladorconfiginventario.Instance.updatesumarinventario(configinv);
                                }

                                /*Aqui buscamos en la configuracion de inventario los productos a restar de inventario por medio del IDmenu*/
                            }
                            /************************ActualizaInventario*****************************************/
                            MessageBox.Show("Factura Eliminada");
                            cargardg();
                            calcularventas();
                            break;
                        case DialogResult.No:
                            MessageBox.Show("Cancelado");
                            break;

                    }
                    //ControladorFacturas.Instance.delete(facturas);


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void txttotalventas_TextChanged(object sender, EventArgs e)
        {
            txttotalventas.Text = String.Format("{0:n0}", int.Parse(txttotalefectivo.Text) + int.Parse(txttotaltarjeta.Text));
        }

        private void dglistafacturas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                dglistafacturas.CurrentCell = dglistafacturas.Rows[e.RowIndex].Cells[e.ColumnIndex];

                ContextMenu cm = new ContextMenu();
                MenuItem mi = new MenuItem();
                mi.Text = "REIMPRIMIR";
                mi.Click += REIMPRIMIR; //metodo al dar click
                cm.MenuItems.Add(mi);


                //Obtienes las coordenadas de la celda seleccionada. 
                Rectangle coordenada = dglistafacturas.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                int anchoCelda = coordenada.Location.X; //Ancho de la localizacion de la celda
                int altoCelda = coordenada.Location.Y;  //Alto de la localizacion de la celda

                //Y para mostrar el menú lo haces de esta forma:  
                int X = anchoCelda;
                int Y = altoCelda;

                cm.Show(dglistafacturas, new Point(X, Y));


            }
        }

        private void REIMPRIMIR(Object sender, EventArgs e)
        {
            impresoras impresoras = new impresoras();
            impresoras = ControladorImpresora.Instance.findconfig();
            for (int x = 0; x < impresoras.Ticktes; x++)
            {



                int idfactura;

                idfactura = Convert.ToInt32(dglistafacturas.SelectedCells[0].Value);
                facturas facturas = new facturas();
                facturas = ControladorFacturas.Instance.find(idfactura);
                // aqui generamos la copia del ticket
                CrearTicket ticket = new CrearTicket();
                //Ya podemos usar todos sus metodos
                

                ticket.AbreCajon();//Para abrir el cajon de dinero.//Datos de la cabecera del Ticket.
                ticket.TextoCentro(Globales.sucursalnombre);
                ticket.TextoIzquierda(Globales.sucursaldireccion);
                ticket.TextoIzquierda("RTN:" + Globales.sucursalrtn);
                ticket.TextoIzquierda("CEL:" + Globales.sucursalcelular);//Es el mio por si me quieren contactar ...
                ticket.TextoIzquierda("Correo:" + Globales.sucursalcorreo);

                if (Globales.sucursalfacturarconcai == true)
                {
                    ticket.TextoIzquierda("");
                    ticket.TextoCentro("FACTURA");
                    ticket.TextoCentro("NO." + Globales.primerapartenumerofacturacai + "-" + facturas.Facturacai);
                    ticket.TextoIzquierda("Rango Autorizado:");
                    ticket.TextoIzquierda("Del: " + Globales.sucursalrangodesde);
                    ticket.TextoIzquierda("Al : " + Globales.sucursalrangohasta);


                    ticket.TextoIzquierda("CAI:");
                    ticket.TextoIzquierda(Globales.sucursalcai);
                    ticket.TextoIzquierda("Fecha Limite de Emision: " + Globales.sucursalfechaemisionfactura);



                    ticket.TextoIzquierda("");
                    Cliente Cliente = new Cliente();
                    Cliente = ControladorCliente.Instance.findbyid(facturas.Idcliente);
                    ticket.TextoIzquierda("Cliente:" + Cliente.Nombre);
                    ticket.TextoIzquierda("RTN:" + Cliente.Rtn);
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("Orden Compra Excenta: _____________");
                    ticket.TextoIzquierda("No. Constancia Registro Excento: ______");
                    ticket.TextoIzquierda("No. Registro SAG: ____________");
                    ticket.TextoIzquierda("");
                    ticket.lineasGuion();
                }
               
                ticket.TextoCentro("Orden #" +facturas.Orden);
                ticket.lineasGuion();
                ticket.TextoIzquierda("");



                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("FECHA: " + facturas.Fecha2.ToString());


                //Articulos a vender.
                ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
                ticket.lineasIgual();

                List<detalle_factura> df = new List<detalle_factura>();
                df = ControladorDetalle_Factura.Instance.findbyid(idfactura);

                foreach (detalle_factura detalle_factura in df)
                {

                    menu menu = new menu();
                    menu = ControladorMenu.Instance.findnombre(detalle_factura.Idmenu);
                    //buscar el role por medio del idrole antes de ingresarlo
                    ticket.AgregaArticulo(detalle_factura.Cantidad, menu.Nombrecombo+detalle_factura.Complementos, detalle_factura.Total);

                }



                ticket.lineasIgual();

                //Resumen de la venta. Sólo son ejemplos
                if (Globales.sucursalfacturarconcai == true)
                {
                    //Resumen de la venta. Sólo son ejemplos
                    ticket.AgregarTotales("IMPORTE GRAVADO 15%", facturas.Importe_gravado);
                    ticket.AgregarTotales("IMPORTE GRAVADO 18%", 0);
                    ticket.AgregarTotales("IMPORTE EXCENTO", 0);
                    ticket.AgregarTotales("SUBTOTAL", facturas.Importe_gravado);
                    ticket.AgregarTotales("I.S.V 15%", facturas.Isv15);
                    ticket.AgregarTotales("I.S.V 18%", 0);
                    ticket.AgregarTotales("IMPORTE EXONERADO", 0);//La M indica que es un decimal en C#
                    ticket.AgregarTotales("TOTAL A PAGAR", facturas.Total);
                }
                else
                {
                    ticket.AgregarTotales("SUBTOTAL", facturas.Importe_gravado);
                    ticket.AgregarTotales("ISV", facturas.Isv15);//La M indica que es un decimal en C#
                    ticket.AgregarTotales("TOTAL A PAGAR", facturas.Total);

                }


                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("FORMA DE PAGO");
                if (facturas.Tipopago == "Efectivo")
                {
                    ticket.AgregarTotales(facturas.Tipopago, facturas.Dinerorecibido);
                    ticket.AgregarTotales("VUELTO", facturas.Dineroentregado);
                }
                else if (facturas.Tipopago == "Tarjeta")
                {
                    ticket.AgregarTotales(facturas.Tipopago, facturas.Dinerorecibido);
                    ticket.TextoExtremos("ULTIMOS 4 DIGITOS", "****" + facturas.Ultimosdigitos);
                }

              

                //Texto final del Ticket.
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                if (x == 0)
                {
                    ticket.TextoCentro("ORIGINAL-CLIENTE");
                }
                else
                {
                    ticket.TextoCentro("COPIA DE COMERCIO");
                }
                ticket.TextoIzquierda("");
                ticket.TextoCentro("La Factura es beneficio de todos exijela!");
                ticket.TextoCentro("¡Gracias por su Compra!");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.CortaTicket();
                //ticket.ImprimirTicket("Microsoft XPS Document Writer");
               ticket.ImprimirTicket(impresoras.Nombreimpresora);//Nombre de la impresora ticketera
            }
        }



        public void calcularventas()
        {
            int sumatotal = 0;
            for (int x = 0; x < dglistafacturas.Rows.Count; ++x)
            {
                sumatotal += Convert.ToInt32(dglistafacturas.Rows[x].Cells["Total"].Value);
                txttotalventas.Text = String.Format("{0:n0}", sumatotal);
            }
            //suma los valores dependiendo el metodo de pago usando metodo linq
            decimal totalefectivo = dglistafacturas.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[4].Value != null && x.Cells[4].Value.ToString() == "Efectivo").ToList().Sum(y => Convert.ToDecimal(y.Cells[5].Value));
            txttotalefectivo.Text = String.Format("{0:n0}", totalefectivo);


            decimal totaltarjeta = dglistafacturas.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[4].Value != null && x.Cells[4].Value.ToString() == "Tarjeta").ToList().Sum(y => Convert.ToDecimal(y.Cells[5].Value));
            txttotaltarjeta.Text = String.Format("{0:n0}", totaltarjeta);
        }


        /*Esta funcion permite solo abrir 1 vez el formulario*/
        private static ListaFacturasVista fmrlistafacturas = null;
        internal static ListaFacturasVista Abrir1vez()
        {

            if (((fmrlistafacturas == null) || (fmrlistafacturas.IsDisposed == true)))
            {
                fmrlistafacturas = new ListaFacturasVista();
            }
            fmrlistafacturas.BringToFront();
            return fmrlistafacturas;
        }
    }
    
}
