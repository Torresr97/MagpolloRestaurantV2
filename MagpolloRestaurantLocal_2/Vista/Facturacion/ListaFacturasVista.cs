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

namespace AppTRchicken.Vista
{
    public partial class ListaFacturasVista : Form
    {
        DateTime fechaCompleta;
        DateTime soloFecha;
        public ListaFacturasVista()
        {
            InitializeComponent();
            fechaCompleta = DateTime.Now;
            soloFecha = fechaCompleta.Date;

        }

        private void ListaFacturasVista_Load(object sender, EventArgs e)
        {/*aqui averigua cual es el numero de grupo a cerrar*/
            // Obtener información del usuario y asignar el ID globalmente
            usuarios usuarioActual = ControladorUsuario.Instance.findidbynombre(Globales.nombreusuario);
            Globales.idusuario = (int)usuarioActual.Idusuario;

            // Obtener el rol del usuario
            roles rolUsuario = ControladorRoles.Instance.findrolebynombreusuario(Globales.nombreusuario);

            // Obtener el número de cierre basado en la fecha global
            facturas numeroCierre = ControladorFacturas.Instance.Findnumerocierre(Globales.fecha);
            Globales.numerocierre = numeroCierre.Numerocierre;

            // Si el usuario no es cajero, cargar facturas y calcular ventas
            if (rolUsuario.Roles != "cajero")
            {
                cargardg();
                calcularventas();
            }
            else
            {
                // Si el usuario es cajero, cargar facturas y eliminar la columna de acciones (Columna 8)
                cargardg();
                if (dglistafacturas.Columns.Count > 8)  // Asegurarse de que la columna existe
                {
                    dglistafacturas.Columns.RemoveAt(8);
                }
            }
        }

        




        private void cargardg()
        {
            dglistafacturas.Rows.Clear();
            List<facturas> fac = new List<facturas>();
            fac = ControladorFacturas.Instance.FincfacturaFecha(Globales.fecha, Globales.numerocierre);

            foreach (facturas factura in fac)
            {


                //buscar el role por medio del idrole antes de ingresarlo
                dglistafacturas.Rows.Add(factura.Idfactura, factura.Facturacai, factura.Orden, factura.Descuento.ToString("N2", CultureInfo.InvariantCulture), factura.Tipopago, factura.Total.ToString("N2", CultureInfo.InvariantCulture), factura.Dinerorecibido.ToString("N2", CultureInfo.InvariantCulture), factura.Dineroentregado.ToString("N2", CultureInfo.InvariantCulture));
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
                    // Verifica si la columna 4 contiene el valor "Mixto"
                    string metodopago = dglistafacturas.Rows[dglistafacturas.CurrentRow.Index].Cells[4].Value.ToString();

                    DialogResult result = MessageBox.Show("Esta Seguro de Eliminar esta Factura?", "Eliminar Factura", MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            facturas factura = new facturas();
                            factura.Idfactura = Convert.ToInt64(dglistafacturas.Rows[e.RowIndex].Cells[0].Value);
                            factura.Estado = false;
                            ControladorFacturas.Instance.update(facturas);//Actualiza la factura a estado 0 

                            // Si la factura es de tipo "Mixto", también desactivamos los registros relacionados
                            if (metodopago == "Mixto")
                            {
                                DetallePagoMixto DetallePagoMixto = new DetallePagoMixto();
                                DetallePagoMixto.IdFactura = (int)Convert.ToInt64(dglistafacturas.Rows[e.RowIndex].Cells[0].Value);
                                DetallePagoMixto.Estado = false;

                                ControladorDetallepagomixto.Instance.updateDesactivarEstado(DetallePagoMixto);  // Desactiva los registros relacionados con la factura
                            }

                            /************************ActualizaInventario*****************************************/
                            List<detalle_factura> df = new List<detalle_factura>();
                            df = ControladorDetalle_Factura.Instance.findbyid((int)factura.Idfactura);

                            string nombreTipoComplemento = "";

                            foreach (detalle_factura detalle_factura in df)
                            {
                                menu menu = new menu();
                                menu = ControladorMenu.Instance.findnombre(detalle_factura.Idmenu);
                                List<complementos_plato> catm = ControladorComplementosPlato.Instance.findAllByComboName(menu.Nombrecombo);


                               

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
                }


                ticket.lineasGuion();

                if (Globales.nombresucursallbl == "LOS ANDES - AUTOSERVICIO")
                {
                    ticket.TextoCentro("AUTOSERVICIO");
                }
                else
                {
                    ticket.TextoCentro("TIENDA");
                }
                ticket.TextoCentro("Orden #" + facturas.Orden);
                ticket.lineasGuion();
                ticket.TextoIzquierda("");



                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("FECHA: " + facturas.Fecha2.ToString());
                ticket.TextoIzquierda("CAJERO: " + (Globales.nombreusuario));

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
                    ticket.AgregaArticulo(detalle_factura.Cantidad, menu.Nombrecombo + detalle_factura.Complementos, Globales.ConvertToDecimal(detalle_factura.Total.ToString("N2", CultureInfo.InvariantCulture)));

                }



                ticket.lineasIgual();

                //Resumen de la venta. Sólo son ejemplos
                if (Globales.sucursalfacturarconcai == true)
                {
                    //Resumen de la venta. Sólo son ejemplos
                    ticket.AgregarTotales("DESCUENTO", Globales.ConvertToDecimal(facturas.Descuento.ToString()));
                    ticket.AgregarTotales("IMPORTE GRAVADO 15%", Globales.ConvertToDecimal(facturas.Importe_gravado.ToString("N2", CultureInfo.InvariantCulture)));
                    ticket.AgregarTotales("IMPORTE GRAVADO 18%", 0);
                    ticket.AgregarTotales("IMPORTE EXCENTO", 0);
                    ticket.AgregarTotales("SUBTOTAL", Globales.ConvertToDecimal(facturas.Importe_gravado.ToString("N2", CultureInfo.InvariantCulture)));
                    ticket.AgregarTotales("I.S.V 15%", Globales.ConvertToDecimal(facturas.Isv15.ToString("N2", CultureInfo.InvariantCulture)));
                    ticket.AgregarTotales("I.S.V 18%", 0);
                    ticket.AgregarTotales("IMPORTE EXONERADO", 0);//La M indica que es un decimal en C#
                    ticket.AgregarTotales("TOTAL A PAGAR", Globales.ConvertToDecimal(facturas.Total.ToString("N2", CultureInfo.InvariantCulture)));
                }
                else
                {
                    ticket.AgregarTotales("DESCUENTO", Globales.ConvertToDecimal(facturas.Descuento.ToString("N2", CultureInfo.InvariantCulture)));
                    ticket.AgregarTotales("SUBTOTAL", Globales.ConvertToDecimal(facturas.Importe_gravado.ToString("N2", CultureInfo.InvariantCulture)));
                    ticket.AgregarTotales("ISV", Globales.ConvertToDecimal(facturas.Isv15.ToString("N2", CultureInfo.InvariantCulture)));//La M indica que es un decimal en C#
                    ticket.AgregarTotales("TOTAL A PAGAR", Globales.ConvertToDecimal(facturas.Total.ToString("N2", CultureInfo.InvariantCulture)));

                }


                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("FORMA DE PAGO");
                if (facturas.Tipopago == "Efectivo")
                {
                    ticket.AgregarTotales(facturas.Tipopago, Globales.ConvertToDecimal(facturas.Dinerorecibido.ToString("N2", CultureInfo.InvariantCulture)));
                    ticket.AgregarTotales("CAMBIO", Globales.ConvertToDecimal(facturas.Dineroentregado.ToString("N2", CultureInfo.InvariantCulture)));
                }
                else if (facturas.Tipopago == "Tarjeta")
                {
                    ticket.AgregarTotales(facturas.Tipopago, Globales.ConvertToDecimal(facturas.Dinerorecibido.ToString("N2", CultureInfo.InvariantCulture)));
                    ticket.TextoExtremos("ULTIMOS 4 DIGITOS", "****" + facturas.Ultimosdigitos);
                }
                else if (facturas.Tipopago == "Mixto")
                {
                    //trae toda la suma de ventas mixto efectivo
                    DetallePagoMixto DetallePagoMixtoEfectivo = ControladorDetallepagomixto.Instance.totalefectivoMixto(soloFecha.ToString("yyyy-MM-dd"), "Efectivo", Globales.numerocierre);
                    decimal totalEfectivoSistemaMixto = DetallePagoMixtoEfectivo.Monto;

                    //trae toda la suma de ventas mixto tarjeta
                    DetallePagoMixto DetallePagoMixtoTarjeta = ControladorDetallepagomixto.Instance.totalefectivoMixto(soloFecha.ToString("yyyy-MM-dd"), "Tarjeta", Globales.numerocierre);
                    decimal totalTarjetaSistemaMixto = DetallePagoMixtoTarjeta.Monto;

                    ticket.AgregarTotales(Globales.metodopago.ToString(), Globales.Dinerorecibido);
                    ticket.AgregarTotales("EFECTIVO", Globales.ConvertToDecimal(totalEfectivoSistemaMixto.ToString("N2", CultureInfo.InvariantCulture)));
                    ticket.AgregarTotales("TARJETA", Globales.ConvertToDecimal(totalTarjetaSistemaMixto.ToString("N2", CultureInfo.InvariantCulture)));
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
               // ticket.ImprimirTicket("Microsoft XPS Document Writer");
                ticket.ImprimirTicket(impresoras.Nombreimpresora);//Nombre de la impresora ticketera
            }
        }



        public void calcularventas()
        {


            // Sumar los valores de Efectivo usando LINQ
            decimal totalefectivo = dglistafacturas.Rows.Cast<DataGridViewRow>()
                .Where(x => x.Cells[4].Value != null && x.Cells[4].Value.ToString() == "Efectivo")
                .Sum(y => Globales.ConvertToDecimal(y.Cells[5].Value.ToString()));

            // Trae toda la suma de ventas mixtas para Efectivo
            DetallePagoMixto detallePagoMixtoEfectivo = ControladorDetallepagomixto.Instance.totalefectivoMixto(soloFecha.ToString("yyyy-MM-dd"), "Efectivo", Globales.numerocierre);
            // Verificar el monto retornado
            if (detallePagoMixtoEfectivo != null)
            {
                totalefectivo += detallePagoMixtoEfectivo.Monto;
            }
            else
            {
                MessageBox.Show("No se encontraron datos para el total de efectivo mixto.");
            }

            txttotalefectivo.Text = totalefectivo.ToString("N2", CultureInfo.InvariantCulture);

            // Sumar los valores de Tarjeta usando LINQ
            decimal totaltarjeta = dglistafacturas.Rows.Cast<DataGridViewRow>()
                .Where(x => x.Cells[4].Value != null && x.Cells[4].Value.ToString() == "Tarjeta")
                .Sum(y => Globales.ConvertToDecimal(y.Cells[5].Value.ToString()));
            // Formatear y mostrar el total de tarjeta con dos decimales
            //trae toda la suma de ventas mixto tarjeta
            DetallePagoMixto DetallePagoMixtoTarjeta = ControladorDetallepagomixto.Instance.totalefectivoMixto(soloFecha.ToString("yyyy-MM-dd"), "Tarjeta", Globales.numerocierre);
            totaltarjeta += DetallePagoMixtoTarjeta.Monto;
            txttotaltarjeta.Text = totaltarjeta.ToString("N2", CultureInfo.InvariantCulture);

            // Sumar los valores de Transferencias usando LINQ
            decimal totaltransferencias = dglistafacturas.Rows.Cast<DataGridViewRow>()
                .Where(x => x.Cells[4].Value != null && x.Cells[4].Value.ToString() == "Transferencia")
                .Sum(y => Globales.ConvertToDecimal(y.Cells[5].Value.ToString()));
            // Formatear y mostrar el total de transferencias con dos decimales
            txttotaltransferencia.Text = totaltransferencias.ToString("N2", CultureInfo.InvariantCulture);


            decimal sumatotal = 0;
            sumatotal = totalefectivo + totaltarjeta + totaltransferencias;

            // Formatear y mostrar el total de ventas con dos decimales
            txttotalventas.Text = sumatotal.ToString("N2", CultureInfo.InvariantCulture);

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

        private void dglistafacturas_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
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

        private void dglistafacturas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)  //Dónde la columna con el botón es la 6 con posición 5
            {
                facturas facturas = new facturas();
                facturas.Idfactura = Convert.ToInt32(dglistafacturas.Rows[dglistafacturas.CurrentRow.Index].Cells["codigofactura"].Value);
                try
                {
                    // Verifica si la columna 4 contiene el valor "Mixto"
                    string metodopago = dglistafacturas.Rows[dglistafacturas.CurrentRow.Index].Cells[4].Value.ToString();

                    DialogResult result = MessageBox.Show("Esta Seguro de Eliminar esta Factura?", "Eliminar Factura", MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            facturas factura = new facturas();
                            factura.Idfactura = Convert.ToInt64(dglistafacturas.Rows[e.RowIndex].Cells[0].Value);
                            factura.Estado = false;
                            ControladorFacturas.Instance.update(facturas);//Actualiza la factura a estado 0 

                            // Si la factura es de tipo "Mixto", también desactivamos los registros relacionados
                            if (metodopago == "Mixto")
                            {
                                DetallePagoMixto DetallePagoMixto = new DetallePagoMixto();
                                DetallePagoMixto.IdFactura = (int)Convert.ToInt64(dglistafacturas.Rows[e.RowIndex].Cells[0].Value);
                                DetallePagoMixto.Estado = false;

                                ControladorDetallepagomixto.Instance.updateDesactivarEstado(DetallePagoMixto);  // Desactiva los registros relacionados con la factura
                            }

                            /************************ActualizaInventario*****************************************/
                            List<detalle_factura> df = new List<detalle_factura>();
                            df = ControladorDetalle_Factura.Instance.findbyid((int)factura.Idfactura);

                            string nombreTipoComplemento = "";

                            foreach (detalle_factura detalle_factura in df)
                            {
                                menu menu = new menu();
                                menu = ControladorMenu.Instance.findnombre(detalle_factura.Idmenu);
                                List<complementos_plato> catm = ControladorComplementosPlato.Instance.findAllByComboName(menu.Nombrecombo);




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
    }
    
}
