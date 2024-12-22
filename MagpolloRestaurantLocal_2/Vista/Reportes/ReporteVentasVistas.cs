using AppTRchicken.Controlador;
using AppTRchicken.Modelo;
using AppTRchicken.Reportes;
using AppTRchicken.Utilidades;
using AppTRchicken.Vista.Configuraciones_Generales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppTRchicken.Vista
{
    public partial class ReporteVentasVistas : Form
    {
        private Dictionary<int, Cliente> ClienteDict;
        public ReporteVentasVistas()
        {
            InitializeComponent();
            ClienteDict = new Dictionary<int, Cliente>();
        }

        private void ReporteVentasVistas_Load(object sender, EventArgs e)
        {
            CargarDiccionario();
            dtpmesyano.Visible = false;
            dthasta.Visible = false;

            btnBuscar.Visible = false;


            int height = this.Height;
            int width = this.Width;
            int altura = dgreporteventas.Location.Y;
            btnexportar.Location = new Point((width - btnexportar.Width - 20), (altura - btnexportar.Height - 5));


        }
        private void CargarDiccionario()
        {
            List<Cliente> listacliente = ControladorCliente.Instance.findAll();

            // Recorre la lista de clientes y agrégala al diccionario
            foreach (Cliente cliente in listacliente)
            {
                if (!ClienteDict.ContainsKey((int)cliente.Idcliente))
                {
                    // Agrega cada cliente al diccionario utilizando su ID como clave
                    ClienteDict.Add((int)cliente.Idcliente, cliente);
                }
            }
        }
      
        private string GetCbxfacturasText()
        {
            if (cbxfacturas.InvokeRequired)
            {
                return (string)cbxfacturas.Invoke((Func<string>)GetCbxfacturasText);
            }
            else
            {
                return cbxfacturas.Text;
            }
        }
        // Método para mostrar el formulario de carga de forma asíncrona

        private CargandoVista cargandoForm;
        private async Task<CargandoVista> MostrarFormularioCarga(int tiempoDeseado)
        {

            await Task.Run(() =>
            {
                cargandoForm = new CargandoVista();
                cargandoForm.SetTiempoDeEspera(tiempoDeseado); // Establecer el dato deseado
                cargandoForm.ShowDialog();
            });
            return cargandoForm;
        }


        private void CerrarFormularioCarga()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    // Cerrar el formulario en el hilo de la interfaz de usuario
                    this.Close();
                });
            }
            else
            {
                // Si ya estamos en el hilo de la interfaz de usuario, cerrar el formulario directamente
                this.Close();
            }
        }
    


        private static ReporteVentasVistas fmrReporteVentasVistas = null;
        internal static ReporteVentasVistas Abrir1vez()
        {
            if (((fmrReporteVentasVistas == null) || (fmrReporteVentasVistas.IsDisposed == true)))
            {
                fmrReporteVentasVistas = new ReporteVentasVistas();
            }
            fmrReporteVentasVistas.BringToFront();
            return fmrReporteVentasVistas;
        }


        private void Exportarexcel(DataGridView dg)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);



            excel.Range["A1:Z100"].Cells.Font.Name = "Bookman Old Style";
            //excel.Range[excel.Cells[X, Y], excel.Cells[X, Y]].Merge();

            excel.Range["A1:F1"].Cells.Font.Size = 24;
            excel.Range["A1:F1"].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            if (cbBventas.SelectedItem.ToString() == "Desde - Hasta")
            {
                excel.Range["A1:H1"].Merge();
                excel.Cells[3, "A"].Value = "Fecha:";
                excel.Cells[3, "B"].Value = (dtpmesyano.Value.ToString("yyyy-MM-dd") + " - " + dthasta.Value.ToString("yyyy-MM-dd"));

            }
            else
            {
                excel.Range["A1:F1"].Merge();
                excel.Cells[3, "A"].Value = "Fecha:";
                excel.Cells[3, "B"].Value = dtpmesyano.Value.ToString("yyyy-MM-dd");

            }
            excel.Range["A1:F1"].Value = "Reporte de Ventas - [" + cbBventas.Text.ToString() + "]";

            excel.Cells[4, "A"].Value = "Facturas:";
            excel.Cells[4, "B"].Value = cbxfacturas.Text.ToString();
            excel.Cells[5, "A"].Value = "Subtotal:";
            excel.Cells[5, "B"].Value = txtsubtotal.Text;
            excel.Cells[6, "A"].Value = "Isv:";
            excel.Cells[6, "B"].Value = txtisv.Text;
            excel.Cells[7, "A"].Value = "Total:";
            excel.Cells[7, "B"].Value = txttotal.Text;





            //excel.Rows["4"].Cells["B"].Value = "Cell in row 4 and column B [B4].";
            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in dg.Columns)
            {
                IndiceColumna++;
                excel.Cells[10, IndiceColumna] = col.HeaderText;

            }
            int IndiceFila = 9;

            foreach (DataGridViewRow row in dg.Rows)
            {
                IndiceFila++;
                IndiceColumna = 0;

                foreach (DataGridViewColumn col in dg.Columns)
                {
                    IndiceColumna++;
                    if (col.Name == "facturacai") // Comprobar si es la columna "FacturaCai"
                    {
                        excel.Cells[IndiceFila + 1, IndiceColumna].NumberFormat = "@"; // Establecer formato de texto
                        excel.Cells[IndiceFila + 1, IndiceColumna] = "'" + Globales.primerapartenumerofacturacai + "-" + row.Cells[col.Name].Value.ToString(); // Agregar apóstrofe antes del valor
                    }
                    else if (col.Name == "rtn") // Comprobar si es la columna "FacturaCai"
                    {
                        excel.Cells[IndiceFila + 1, IndiceColumna].NumberFormat = "@"; // Establecer formato de texto
                        excel.Cells[IndiceFila + 1, IndiceColumna] = "'" + row.Cells[col.Name].Value.ToString(); // Agregar apóstrofe antes del valor
                    }
                    else
                    {
                        excel.Cells[IndiceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                    }



                }
            }
            excel.Columns.AutoFit();
            excel.Visible = true;
        }

      

        private void dgreporteventas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                dgreporteventas.CurrentCell = dgreporteventas.Rows[e.RowIndex].Cells[e.ColumnIndex];

                ContextMenu cm = new ContextMenu();
                MenuItem mi = new MenuItem();
                mi.Text = "REIMPRIMIR";
                mi.Click += REIMPRIMIR; //metodo al dar click
                cm.MenuItems.Add(mi);


                //Obtienes las coordenadas de la celda seleccionada. 
                Rectangle coordenada = dgreporteventas.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                int anchoCelda = coordenada.Location.X; //Ancho de la localizacion de la celda
                int altoCelda = coordenada.Location.Y;  //Alto de la localizacion de la celda

                //Y para mostrar el menú lo haces de esta forma:  
                int X = anchoCelda;
                int Y = altoCelda;

                cm.Show(dgreporteventas, new Point(X, Y));


            }
        }

        private void REIMPRIMIR(Object sender, EventArgs e)
        {
            impresoras impresoras = new impresoras();
            impresoras = ControladorImpresora.Instance.findconfig();
            for (int x = 0; x < impresoras.Ticktes; x++)
            {



                int idfactura;

                idfactura = Convert.ToInt32(dgreporteventas.SelectedCells[0].Value);
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

                ticket.TextoCentro("Orden #" + facturas.Orden);
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
                    ticket.AgregaArticulo(detalle_factura.Cantidad, menu.Nombrecombo + detalle_factura.Complementos, detalle_factura.Total);

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

        private void cbBventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBventas.SelectedItem.ToString() == "Dia")
            {
                dgreporteventas.Rows.Clear();
                btnBuscar.Visible = true;
                btnBuscar.Location = new Point(455, 18);
                dtpmesyano.Visible = true;
                dthasta.Visible = false;

            }

            else if (cbBventas.SelectedItem.ToString() == "Desde - Hasta")
            {
                dgreporteventas.Rows.Clear();
                btnBuscar.Visible = true;
                btnBuscar.Location = new Point(655, 18);
                dtpmesyano.Visible = true;
                dthasta.Visible = true;


            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {

            if (cbBventas.SelectedItem.ToString() == "Dia")
            {
                //15 segundos: 15 * 1000 = 15000 
                //25 segundos: 25 * 1000 = 25000 
                //1 minuto: 60 * 1000 = 60000 
                //2 minutos: 2 * 60 * 1000 = 120000 
                //3 minutos: 3 * 60 * 1000 = 180000 
                //5 minutos: 5 * 60 * 1000 = 300000 
                //6 minutos: 6 * 60 * 1000 = 360000 
                //8 minutos: 8 * 60 * 1000 = 480000 
                //10 minutos: 10 * 60 * 1000 = 600000 

                int tiempoDeseado = 0; // Por ejemplo, 5 segundos
                if (cbxfacturas.Text == "Todas" || cbxfacturas.Text == "Activas" || cbxfacturas.Text == "Inactivas")
                {
                    tiempoDeseado = 600000;
                }
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);

                try
                {
                    // Limpiar el DataGridView
                    dgreporteventas.Rows.Clear();

                    // Consultar los datos de la base de datos en segundo plano
                    List<facturas> fac = await Task.Run(() => ControladorFacturas.Instance.ReporteFincfacturaDia(dtpmesyano.Value.ToString("yyyy-MM-dd"), GetCbxfacturasText()));

                    // Rellenar el DataGridView con los datos consultados
                    char delimitador = ' ';
                    foreach (facturas factura in fac)
                    {
                        string estado = factura.Estado ? "Activa" : "Inactiva";
                        // Buscar cliente en el diccionario
                        if (ClienteDict.TryGetValue(factura.Idcliente, out Cliente cliente))
                        {
                            // Agregar fila al DataGridView
                            dgreporteventas.Rows.Add(factura.Idfactura, factura.Facturacai, cliente.Nombre, cliente.Rtn, factura.Orden, factura.Tipopago, factura.Isv15.ToString("N2", CultureInfo.InvariantCulture), factura.Total.ToString("N2", CultureInfo.InvariantCulture), factura.Fecha2, estado);
                        }
                        else
                        {
                            // Manejar el caso en que el cliente no esté en el diccionario (opcional)
                            dgreporteventas.Rows.Add(factura.Idfactura, factura.Facturacai, "Cliente no encontrado", "N/A", factura.Orden, factura.Tipopago, factura.Isv15.ToString("N2", CultureInfo.InvariantCulture), factura.Total.ToString("N2", CultureInfo.InvariantCulture), factura.Fecha2, estado);
                        }
                    }

                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción que pueda ocurrir durante la consulta de datos
                    MessageBox.Show("Error al consultar datos: " + ex.Message);
                }
                finally
                {
                    cargandoForm.CerrarFormularioSeguro();
                }



                decimal total = 0;
                decimal isv = 0;
                decimal subtotal = 0;
                decimal efectivo = 0;
                decimal tarjeta = 0;
                decimal transferencia = 0;

                // Recorre todas las filas del DataGridView
                for (int x = 0; x < dgreporteventas.Rows.Count; ++x)
                {
                    // Verifica si el valor en la celda 'tipopago' es "Efectivo" o "Tarjeta"
                    string tipoPago = dgreporteventas.Rows[x].Cells["tipopago"].Value.ToString();
                    decimal valor = Globales.ConvertToDecimal(dgreporteventas.Rows[x].Cells["Total"].Value.ToString());

                    // Acumulamos los valores según el tipo de pago
                    if (tipoPago == "Efectivo")
                    {
                        efectivo += valor;
                    }
                    else if (tipoPago == "Tarjeta")
                    {
                        tarjeta += valor;
                    }
                    else if (tipoPago == "Transferencia")
                    {
                        transferencia += valor;
                    }

                    // Acumulamos el total general
                    total += valor;
                }

                // Calculamos el subtotal y el ISV
                subtotal = total / 1.15m; // Usar 'm' para asegurar que es decimal
                isv = subtotal * 0.15m;   // Usar 'm' para asegurar que es decimal

                // Actualizamos los valores en los controles de texto
                txtefectivo.Text = efectivo.ToString("N2", CultureInfo.InvariantCulture);
                txttarjeta.Text = tarjeta.ToString("N2", CultureInfo.InvariantCulture);
                txttransferencia.Text = transferencia.ToString("N2", CultureInfo.InvariantCulture);
                txttotal.Text = total.ToString("N2", CultureInfo.InvariantCulture);
                txtsubtotal.Text = subtotal.ToString("N2", CultureInfo.InvariantCulture);
                txtisv.Text = isv.ToString("N2", CultureInfo.InvariantCulture);

            }

            if (cbBventas.SelectedItem.ToString() == "Desde - Hasta")
            {

                // Llamada a MostrarFormularioCarga con el tiempo deseado
                int tiempoDeseado = 600000; // Por ejemplo, 5 segundos
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);

                try
                {
                    // Limpiar el DataGridView
                    dgreporteventas.Rows.Clear();

                    // Consultar los datos de la base de datos en segundo plano
                    List<facturas> fac = await Task.Run(() => ControladorFacturas.Instance.ReporteFinfacturadesdehasta(dtpmesyano.Value.ToString("yyyy-MM-dd"), dthasta.Value.ToString("yyyy-MM-dd"), GetCbxfacturasText()));
                    // Rellenar el DataGridView con los datos consultados

                    foreach (facturas factura in fac)
                    {
                        string estado = factura.Estado ? "Activa" : "Inactiva";
                        // Buscar cliente en el diccionario
                        if (ClienteDict.TryGetValue(factura.Idcliente, out Cliente cliente))
                        {
                            // Agregar fila al DataGridView
                            dgreporteventas.Rows.Add(factura.Idfactura, factura.Facturacai, cliente.Nombre, cliente.Rtn, factura.Orden, factura.Tipopago, factura.Isv15.ToString("N2", CultureInfo.InvariantCulture), factura.Total.ToString("N2", CultureInfo.InvariantCulture), factura.Fecha2, estado);
                        }
                        else
                        {
                            // Manejar el caso en que el cliente no esté en el diccionario (opcional)
                            dgreporteventas.Rows.Add(factura.Idfactura, factura.Facturacai, "Cliente no encontrado", "N/A", factura.Orden, factura.Tipopago, factura.Isv15.ToString("N2", CultureInfo.InvariantCulture), factura.Total.ToString("N2", CultureInfo.InvariantCulture), factura.Fecha2, estado);
                        }
                    }


                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción que pueda ocurrir durante la consulta de datos
                    MessageBox.Show("Error al consultar datos: " + ex.Message);
                }
                finally
                {
                    cargandoForm.CerrarFormularioSeguro();
                }

                decimal total = 0;
                decimal isv = 0;
                decimal subtotal = 0;
                decimal efectivo = 0;
                decimal tarjeta = 0;
                decimal transferencia = 0;

                // Recorre todas las filas del DataGridView
                for (int x = 0; x < dgreporteventas.Rows.Count; ++x)
                {
                    // Verifica si el valor en la celda 'tipopago' es "Efectivo" o "Tarjeta"
                    string tipoPago = dgreporteventas.Rows[x].Cells["tipopago"].Value.ToString();
                    decimal valor = Globales.ConvertToDecimal(dgreporteventas.Rows[x].Cells["Total"].Value.ToString());

                    // Acumulamos los valores según el tipo de pago
                    if (tipoPago == "Efectivo")
                    {
                        efectivo += valor;
                    }
                    else if (tipoPago == "Tarjeta")
                    {
                        tarjeta += valor;
                    }
                    else if (tipoPago == "Transferencia")
                    {
                        transferencia += valor;
                    }

                    // Acumulamos el total general
                    total += valor;
                }

                // Calculamos el subtotal y el ISV
                subtotal = total / 1.15m; // Usar 'm' para asegurar que es decimal
                isv = subtotal * 0.15m;   // Usar 'm' para asegurar que es decimal

                // Actualizamos los valores en los controles de texto
                txtefectivo.Text = efectivo.ToString("N2", CultureInfo.InvariantCulture);
                txttarjeta.Text = tarjeta.ToString("N2", CultureInfo.InvariantCulture);
                txttransferencia.Text = transferencia.ToString("N2", CultureInfo.InvariantCulture);
                txttotal.Text = total.ToString("N2", CultureInfo.InvariantCulture);
                txtsubtotal.Text = subtotal.ToString("N2", CultureInfo.InvariantCulture);
                txtisv.Text = isv.ToString("N2", CultureInfo.InvariantCulture);

            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            Exportarexcel(dgreporteventas);
        }

        private void dgreporteventas_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                dgreporteventas.CurrentCell = dgreporteventas.Rows[e.RowIndex].Cells[e.ColumnIndex];

                ContextMenu cm = new ContextMenu();
                MenuItem mi = new MenuItem();
                mi.Text = "REIMPRIMIR";
                mi.Click += REIMPRIMIR; //metodo al dar click
                cm.MenuItems.Add(mi);


                //Obtienes las coordenadas de la celda seleccionada. 
                Rectangle coordenada = dgreporteventas.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                int anchoCelda = coordenada.Location.X; //Ancho de la localizacion de la celda
                int altoCelda = coordenada.Location.Y;  //Alto de la localizacion de la celda

                //Y para mostrar el menú lo haces de esta forma:  
                int X = anchoCelda;
                int Y = altoCelda;

                cm.Show(dgreporteventas, new Point(X, Y));


            }

        }
    }
}
