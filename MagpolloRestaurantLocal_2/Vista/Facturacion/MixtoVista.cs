﻿using AppTRchicken.Controlador;
using AppTRchicken.Modelo;
using AppTRchicken.Utilidades;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTRchicken.Vista.Facturacion
{
    public partial class MixtoVista : Form
    {
        List<(int Cantidad, string Descripcion, decimal Precio)> articulos = new List<(int, string, decimal)>();
        public MixtoVista()
        {
            InitializeComponent();
        }

        private void txtefectivo_TextChanged(object sender, EventArgs e)
        {
            // Obtener el total a pagar
            decimal totalPagar = Globales.ConvertToDecimal(txtventatotal.Text);

            // Obtener el valor ingresado en efectivo
            decimal pagoEfectivo = Globales.ConvertToDecimal(txtefectivo.Text);

            // Validar que el valor en efectivo no sea negativo ni mayor al total
            if (pagoEfectivo < 0)
            {
                MessageBox.Show("El pago en efectivo no puede ser negativo.");
                txtefectivo.Text = "0";
                return;
            }

            if (pagoEfectivo > totalPagar)
            {
                MessageBox.Show("El pago en efectivo no puede ser mayor al total a pagar.");
                txtefectivo.Text = totalPagar.ToString("N2");
                return;
            }

            // Calcular el pago restante que se hará con tarjeta
            decimal pagoRestante = totalPagar - pagoEfectivo;

            // Mostrar el monto a pagar con tarjeta automáticamente
            txttarjeta.Text = pagoRestante.ToString("N2", CultureInfo.InvariantCulture);
        }

        private void MixtoVista_Load(object sender, EventArgs e)
        {
            txtventatotal.Text = Globales.ventatotal.ToString("N2", CultureInfo.InvariantCulture);
            txtefectivo.Select();

            // Validar y establecer la opción por defecto
            if (Globales.nombresucursallbl == "PLAZA CALPULES - AUTOSERVICIO")
            {
                cbxsucursal.SelectedItem = "AUTOSERVICIO";
            }
            else
            {
                cbxsucursal.SelectedItem = "TIENDA";
            }
        }


        private static MixtoVista fmrMixtoVista = null;
        internal static MixtoVista Abrir1vez()
        {
            if (((fmrMixtoVista == null) || (fmrMixtoVista.IsDisposed == true)))
            {
                fmrMixtoVista = new MixtoVista();
                // Conectar los eventos aquí para asegurarnos de que siempre estén activos
                fmrMixtoVista.Deactivate += fmrMixtoVista_Deactivate;
                fmrMixtoVista.LostFocus += fmrMixtoVista_LostFocus;
                fmrMixtoVista.Resize += fmrMixtoVista_Resize;
            }
            fmrMixtoVista.BringToFront();
            return fmrMixtoVista;
        }
        // Evento cuando el formulario pierde el foco
        private static void fmrMixtoVista_LostFocus(object sender, EventArgs e)
        {
            if (fmrMixtoVista != null && !fmrMixtoVista.Focused)
            {
                // Verificar si el formulario está minimizado o no
                if (fmrMixtoVista.WindowState != FormWindowState.Minimized)
                {
                    fmrMixtoVista.Close();
                }
            }
        }

        // Evento cuando el formulario se minimiza
        private static void fmrMixtoVista_Resize(object sender, EventArgs e)
        {
            if (fmrMixtoVista.WindowState == FormWindowState.Minimized)
            {
                fmrMixtoVista.Close();
            }
        }

        // Evento cuando el formulario se desactiva
        private static void fmrMixtoVista_Deactivate(object sender, EventArgs e)
        {
            if (fmrMixtoVista != null && !fmrMixtoVista.Focused)
            {
                // Verificar si el formulario está minimizado o no
                if (fmrMixtoVista.WindowState != FormWindowState.Minimized)
                {
                    fmrMixtoVista.Close();
                }
            }
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            // Deshabilitar el botón para prevenir múltiples clicks
            btncobrar.Enabled = false;
            Globales.nombreclienteorden = txtnombrecliente.Text;

            // Utiliza la función Globales.ConvertToDecimal para convertir los valores
            decimal totalEfectivo = Globales.ConvertToDecimal(txtefectivo.Text);
            decimal totalTarjeta = Globales.ConvertToDecimal(txttarjeta.Text);
            decimal ventaTotal = Globales.ConvertToDecimal(txtventatotal.Text);

            // Verifica si la conversión fue exitosa y los valores son válidos
            if (totalEfectivo < 0 || totalTarjeta < 0 || ventaTotal < 0)
            {
                MessageBox.Show("Uno o más valores no son válidos.");
                return;
            }

            // Asegúrate de que la suma de efectivo y tarjeta sea igual a la venta total
            if (totalEfectivo + totalTarjeta != ventaTotal)
            {
                MessageBox.Show("La cantidad total recibida no coincide con la venta total.");
                return;
            }


            try
            {
                /*Se debe crear un modelo para utlizar el controlador */
                facturas factura = new facturas();
                factura = ControladorFacturas.Instance.Findorden(Globales.fecha);
                // MessageBox.Show(factura.Orden.ToString());
                Globales.orden = Convert.ToInt32(factura.Orden + 1);
                facturas facturas = new facturas();
                facturas.Orden = Globales.orden;
                facturas.Fecha = Globales.fecha;
                facturas.Descuento = Globales.descuento;
                facturas.Importe_exonerado = Globales.exonerado;
                facturas.Importe_exento = Globales.exento;
                facturas.Importe_gravado = Globales.gravado;
                facturas.Isv15 = Globales.isv;
                facturas.Isv18 = Globales.isv;
                facturas.Tipopago = Globales.metodopago;
                facturas.Ultimosdigitos = Globales.ultimosdigitos;
                facturas.Dinerorecibido = Globales.Dinerorecibido;
                facturas.Dineroentregado = 0;
                facturas.Total = Globales.ventatotal;
                facturas.Estado = true;
                facturas.Idsucursal = Globales.idsucursal;
                facturas.Idusuario = Globales.idusuario;
                facturas.Idcliente = Globales.idcliente;
                facturas.Fecha2 = DateTime.Now;

                string facturacaiticket = "";
                facturas factura2 = new facturas();
                factura2 = ControladorFacturas.Instance.Findfacturacai(Globales.fecha, Globales.sucursalnumerofacturacai);
                if (Globales.sucursalfacturarconcai == true)
                {

                    string ultimosDigitosStr = factura2.Facturacai;
                    if (int.TryParse(ultimosDigitosStr, out int ultimosDigitos))
                    {
                        int longitudstring = Globales.sucursalnumerofacturacai.Length;
                        int diferenciadeespacios = longitudstring; // Usar la longitud total de la parte del string después del último guion
                        facturas.Facturacai = (ultimosDigitos + 1).ToString().PadLeft(diferenciadeespacios, '0');
                        facturacaiticket = facturas.Facturacai;


                        //MessageBox.Show(Globales.sucursalnumerofacturacai);
                        // MessageBox.Show(factura.Facturacai);

                    }
                    else
                    {
                        MessageBox.Show("No se puede obtener Datos para Facturacion con CAI, por favor contacta al Administrador");
                    }

                }
                else
                {
                    facturas.Facturacai = "";
                    facturacaiticket = facturas.Facturacai;
                }
                caja caja = new caja();
                caja = ControladorCaja.Instance.findgrupocierre(Globales.fecha);
                if (caja.Numerotipo == 0)
                {
                    facturas.Numerocierre = 1;

                }
                else
                {
                    facturas.Numerocierre = (caja.Numerotipo + 1);
                }
                int idfactura = ControladorFacturas.Instance.saveRidfactura(facturas);




                // Insertar registro para efectivo en DetallePagoMixto
                DetallePagoMixto detalleEfectivo = new DetallePagoMixto
                {
                    IdFactura = idfactura,
                    MetodoPago = "Efectivo",
                    Monto = totalEfectivo,
                    Fecha = DateTime.Now,
                    Numerocierre = caja.Numerotipo == 0 ? 1 : (caja.Numerotipo + 1),
                    Estado = true
                };
                ControladorDetallepagomixto.Instance.save(detalleEfectivo);

                // Insertar registro para tarjeta en DetallePagoMixto
                DetallePagoMixto detalleTarjeta = new DetallePagoMixto
                {
                    IdFactura = idfactura,
                    MetodoPago = "Tarjeta",
                    Monto = totalTarjeta,
                    Fecha = DateTime.Now,
                    Numerocierre = caja.Numerotipo == 0 ? 1 : (caja.Numerotipo + 1),
                    Estado = true
                };
                ControladorDetallepagomixto.Instance.save(detalleTarjeta);


                Facturaciosvista Facturaciosvista = (Facturaciosvista)Application.OpenForms["Facturaciosvista"];

                foreach (DataGridViewRow rw in Facturaciosvista.dgfacturacion.Rows)
                {


                    if (rw.Cells["Producto"].Value == null || rw.Cells["Producto"].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells["Producto"].Value.ToString()))
                    {
                    }
                    else
                    {
                        // busca la ultima factura insertada por fecha para utilizar en la tabla detalle factura
                        facturas f = new facturas();
                        f = ControladorFacturas.Instance.findultimafacturaregistrada(Globales.fecha);


                        // busca el id del producto para insertar en la tabla detalle factura
                        menu menu = new menu();
                        char delimitador = '\n';
                        string[] producto = rw.Cells["Producto"].Value.ToString().Split(delimitador);
                        menu = ControladorMenu.Instance.findidpornombre(producto[0]);

                        detalle_factura detalle_factura = new detalle_factura();
                        detalle_factura.Idfactura = (int)f.Idfactura;
                        detalle_factura.Idmenu = menu.Idmenu;
                        detalle_factura.Complementos = producto[1];
                        detalle_factura.Cantidad = Convert.ToInt32(rw.Cells["Cantidad"].Value);
                        detalle_factura.Total = Globales.ConvertToDecimal(rw.Cells["Total"].Value.ToString());
                        ControladorDetalle_Factura.Instance.save(detalle_factura);



                        /*Aqui buscamos en la configuracion de inventario los productos a restar de inventario por medio del IDmenu*/
                        List<configinventario> configinventario = new List<configinventario>();
                        configinventario = Controladorconfiginventario.Instance.findbyid(menu.Idmenu);

                        foreach (configinventario d in configinventario)
                        {
                            // MessageBox.Show(d.Idinventario.ToString() + "menos " + d.Cantidadrestar.ToString());
                            configinventario configinv = new configinventario();
                            configinv.Idinventario = d.Idinventario;
                            configinv.Cantidadrestar = (d.Cantidadrestar * detalle_factura.Cantidad);

                            Controladorconfiginventario.Instance.updateinventario(configinv);


                        }

                    }
                }



                // Inicializar la lista de artículos
                articulos.Clear();

                // Procesar las filas del DataGridView
                foreach (DataGridViewRow row in Facturaciosvista.dgfacturacion.Rows)
                {
                    try
                    {
                        // Validar que las celdas clave no sean nulas
                        if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[5].Value == null)
                        {
                            continue; // Omitir filas con valores nulos o vacíos
                        }

                        // Obtener valores de la fila
                        int cantidad = Convert.ToInt32(row.Cells[0].Value);
                        string productoRaw = row.Cells[1].Value.ToString();
                        decimal precio = Globales.ConvertToDecimal(row.Cells[5].Value.ToString());
                        string comentarios = string.IsNullOrWhiteSpace(row.Cells[2]?.Value?.ToString()) ? "" : row.Cells[2].Value.ToString();

                        // Procesar la descripción del producto
                        char deli = '\n';
                        string[] ticketProducto = productoRaw.Split(deli);
                        string descripcion = ticketProducto.Length > 1
                            ? ticketProducto[0].Trim() + " " + ticketProducto[1].Trim()
                            : ticketProducto[0].Trim();

                        // Agregar comentarios si existen
                        if (!string.IsNullOrWhiteSpace(comentarios))
                        {
                            descripcion += " - " + comentarios.Trim();
                        }

                        // Agregar a la lista de artículos
                        articulos.Add((cantidad, descripcion, precio));
                    }
                    catch (Exception ex)
                    {
                        // Mostrar error para depuración, si ocurre
                        MessageBox.Show($"Error procesando fila del DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                // Validar si se obtuvieron artículos
                if (articulos.Count == 0)
                {
                    MessageBox.Show("No se encontraron artículos válidos para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Salir si no hay artículos válidos
                }


                List<impresoras> listaimpresora = new List<impresoras>();

                listaimpresora = ControladorImpresora.Instance.findAll();
                foreach (var impresoras in listaimpresora)
                {

                    if (impresoras.Idimpresora == 1)
                    {
                        for (int x = 0; x < impresoras.Ticktes; x++)
                        {

                            //Creamos una instancia d ela clase CrearTicket
                            CrearTicket ticket = new CrearTicket();

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
                                ticket.TextoCentro("NO." + Globales.primerapartenumerofacturacai + "-" + facturacaiticket);
                                ticket.TextoIzquierda("Rango Autorizado:");
                                ticket.TextoIzquierda("Del: " + Globales.sucursalrangodesde);
                                ticket.TextoIzquierda("Al:  " + Globales.sucursalrangohasta);


                                ticket.TextoIzquierda("CAI:");
                                ticket.TextoIzquierda(Globales.sucursalcai);
                                ticket.TextoIzquierda("Fecha Limite de Emision: " + Globales.sucursalfechaemisionfactura);


                                ticket.TextoIzquierda("");
                                ticket.TextoIzquierda("Cliente:" + Globales.nombrecliente);
                                ticket.TextoIzquierda("RTN:" + Globales.rtncliente);
                                ticket.TextoIzquierda("");
                                ticket.TextoIzquierda("");
                                ticket.TextoIzquierda("Orden Compra Excenta: _____________");
                                ticket.TextoIzquierda("No. Constancia Registro Excento: ______");
                                ticket.TextoIzquierda("No. Registro SAG: ____________");
                                ticket.TextoIzquierda("");
                            }
                            ticket.TextoIzquierda("");
                            ticket.lineasGuion();
                            ticket.TextoCentro(cbxsucursal.Text);
                            ticket.TextoCentro(Globales.servir);
                            ticket.TextoCentro("Orden #" + Globales.orden.ToString());
                            ticket.TextoCentro(Globales.nombreclienteorden.ToString());
                            ticket.lineasGuion();
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");



                          
                            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
                            ticket.TextoIzquierda("CAJERO: " + (Globales.nombreusuario));
                            //Articulos a vender.
                            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
                            ticket.lineasIgual();
                            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
                            //foreach (DataGridViewRow fila in dgvLista.Rows)//dgvLista es el nombre del datagridview
                            //{
                            //ticket.AgregaArticulo(fila.Cells[2].Value.ToString(), int.Parse(fila.Cells[5].Value.ToString()),
                            //decimal.Parse(fila.Cells[4].Value.ToString()), decimal.Parse(fila.Cells[6].Value.ToString()));
                            //}

                            foreach (var (cantidad, descripcion, precio) in articulos)
                            {
                                ticket.AgregaArticulo(cantidad, descripcion, precio);
                            }


                            ticket.lineasIgual();
                            if (Globales.sucursalfacturarconcai == true)
                            {
                                //Resumen de la venta. Sólo son ejemplos
                                ticket.AgregarTotales("DESCUENTO", Globales.descuento);
                                ticket.AgregarTotales("IMPORTE GRAVADO 15%", Globales.gravado);
                                ticket.AgregarTotales("IMPORTE GRAVADO 18%", 0);
                                ticket.AgregarTotales("IMPORTE EXCENTO", 0);
                                ticket.AgregarTotales("SUBTOTAL", Globales.gravado);
                                ticket.AgregarTotales("I.S.V 15%", Globales.isv);
                                ticket.AgregarTotales("I.S.V 18%", 0);
                                ticket.AgregarTotales("IMPORTE EXONERADO", 0);//La M indica que es un decimal en C#
                                ticket.AgregarTotales("TOTAL A PAGAR", Globales.ventatotal);
                            }
                            else
                            {
                                ticket.AgregarTotales("DESCUENTO", Globales.descuento);
                                ticket.AgregarTotales("SUBTOTAL", Globales.gravado);
                                ticket.AgregarTotales("ISV", Globales.isv);//La M indica que es un decimal en C#
                                ticket.AgregarTotales("TOTAL A PAGAR", Globales.ventatotal);

                            }


                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("FORMA DE PAGO");
                            ticket.AgregarTotales(Globales.metodopago.ToString(), Globales.Dinerorecibido);


                            ticket.AgregarTotales("EFECTIVO", totalEfectivo);
                            ticket.AgregarTotales("TARJETA", totalTarjeta);

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
                            ticket.AbreCajon();
                            //ticket.ImprimirTicket("Microsoft XPS Document Writer");
                            try
                            {
                                ticket.ImprimirTicket(impresoras.Nombreimpresora); // Enviar la orden de impresión
                                                                                   // ticket.ImprimirTicket("Microsoft XPS Document Writer");
                                Thread.Sleep(2000); // Retraso después de imprimir
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error imprimiendo en {impresoras.Nombreimpresora}: {ex.Message}");
                            }


                        }

                    }
                    if (impresoras.Idimpresora == 2)
                    {
                        for (int x = 0; x < impresoras.Ticktes; x++)
                        {
                            //Creamos una instancia d ela clase CrearTicket
                            CrearTicket ticket = new CrearTicket();

                            ticket.AbreCajon();//Para abrir el cajon de dinero.//Datos de la cabecera del Ticket.
                            ticket.TextoCentro(Globales.sucursalnombre);
                            ticket.TextoIzquierda(Globales.sucursaldireccion);
                            ticket.TextoIzquierda("RTN:" + Globales.sucursalrtn);
                            ticket.TextoIzquierda("CEL:" + Globales.sucursalcelular);//Es el mio por si me quieren contactar ...
                            ticket.TextoIzquierda("Correo:" + Globales.sucursalcorreo);

                            ticket.TextoIzquierda("");
                            ticket.lineasGuion();
                            ticket.TextoCentro(cbxsucursal.Text);
                            ticket.TextoCentro(Globales.servir);
                            ticket.TextoCentro("Orden #" + Globales.orden.ToString());
                            ticket.TextoCentro(Globales.nombreclienteorden.ToString());
                            ticket.lineasGuion();
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());

                            //Articulos a vender.
                            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
                            ticket.lineasIgual();
                            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
                            //foreach (DataGridViewRow fila in dgvLista.Rows)//dgvLista es el nombre del datagridview
                            //{
                            //ticket.AgregaArticulo(fila.Cells[2].Value.ToString(), int.Parse(fila.Cells[5].Value.ToString()),
                            //decimal.Parse(fila.Cells[4].Value.ToString()), decimal.Parse(fila.Cells[6].Value.ToString()));
                            //}


                            foreach (var (cantidad, descripcion, precio) in articulos)
                            {
                                ticket.AgregaArticulo(cantidad, descripcion, precio);
                            }


                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.TextoCentro("¡Gracias por su Compra!");
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.CortaTicket();
                            ticket.AbreCajon();
                            //ticket.ImprimirTicket("Microsoft XPS Document Writer");
                            try
                            {
                                ticket.ImprimirTicket(impresoras.Nombreimpresora); // Enviar la orden de impresión
                                                                                   // ticket.ImprimirTicket("Microsoft XPS Document Writer");
                                Thread.Sleep(2000); // Retraso después de imprimir
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error imprimiendo en {impresoras.Nombreimpresora}: {ex.Message}");
                            }


                        }
                    }
                    if (impresoras.Idimpresora == 3)
                    {
                        for (int x = 0; x < impresoras.Ticktes; x++)
                        {
                            //Creamos una instancia d ela clase CrearTicket
                            CrearTicket ticket = new CrearTicket();

                            ticket.AbreCajon();//Para abrir el cajon de dinero.//Datos de la cabecera del Ticket.
                            ticket.TextoCentro(Globales.sucursalnombre);
                            ticket.TextoIzquierda(Globales.sucursaldireccion);
                            ticket.TextoIzquierda("RTN:" + Globales.sucursalrtn);
                            ticket.TextoIzquierda("CEL:" + Globales.sucursalcelular);//Es el mio por si me quieren contactar ...
                            ticket.TextoIzquierda("Correo:" + Globales.sucursalcorreo);

                            ticket.TextoIzquierda("");
                            ticket.lineasGuion();
                            ticket.TextoCentro(cbxsucursal.Text);
                            ticket.TextoCentro(Globales.servir);
                            ticket.TextoCentro("Orden #" + Globales.orden.ToString());
                            ticket.TextoCentro(Globales.nombreclienteorden.ToString());
                            ticket.lineasGuion();
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                           
                            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());

                            //Articulos a vender.
                            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
                            ticket.lineasIgual();
                            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
                            //foreach (DataGridViewRow fila in dgvLista.Rows)//dgvLista es el nombre del datagridview
                            //{
                            //ticket.AgregaArticulo(fila.Cells[2].Value.ToString(), int.Parse(fila.Cells[5].Value.ToString()),
                            //decimal.Parse(fila.Cells[4].Value.ToString()), decimal.Parse(fila.Cells[6].Value.ToString()));
                            //}

                            foreach (var (cantidad, descripcion, precio) in articulos)
                            {
                                ticket.AgregaArticulo(cantidad, descripcion, precio);
                            }


                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.TextoCentro("¡Gracias por su Compra!");
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.CortaTicket();
                            ticket.AbreCajon();

                            //ticket.ImprimirTicket("Microsoft XPS Document Writer");
                            try
                            {
                                ticket.ImprimirTicket(impresoras.Nombreimpresora); // Enviar la orden de impresión
                                                                                   // ticket.ImprimirTicket("Microsoft XPS Document Writer");
                                Thread.Sleep(2000); // Retraso después de imprimir
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error imprimiendo en {impresoras.Nombreimpresora}: {ex.Message}");
                            }


                        }
                    }
                }

                // Limpia la lista de artículos para la nueva factura
                articulos.Clear();
                Facturaciosvista.dgfacturacion.Rows.Clear();
                Facturaciosvista.tpanelmenu.Controls.Clear();
                Facturaciosvista.cargarmenu();
                Facturaciosvista.limpiartxt();
                Facturaciosvista.LimpiarVariablesGlobales();
                Globales.nombreclienteorden = "";
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Rehabilitar el botón después de que el proceso termine
                btncobrar.Enabled = true;
            }
        }
    }
}
