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
using AppTRchicken.Controlador;
using AppTRchicken.Modelo;
using AppTRchicken.Vista.Menu;
using System.Drawing.Printing;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Globalization;

namespace AppTRchicken.Vista
{
    public partial class DeduccionxempleadoVista : Form
    {
        private Dictionary<int, Empleado> empleadosDict;
        int iddeduccion = 0;
        private decimal precioOriginal;

        public DeduccionxempleadoVista()
        {
            InitializeComponent();
            empleadosDict = new Dictionary<int, Empleado>();
        }
        private void Cargarempleados()
        {
            empleadosDict.Clear();

            // Cargar todos los empleados
            List<Empleado> empleados = ControladorEmpleado.Instance.findAllcentral(Globales.basedatoscentral);

            // Agregar cada empleado al DataGridView y al diccionario
            foreach (Empleado empleado in empleados)
            {
                empleadosDict[empleado.IdEmpleado] = empleado;

            }
        }

        private void CargarComboBoxConEmpleados()
        {
            cbempleado.Items.Clear(); // Limpiar el ComboBox antes de cargar nuevos empleados
                                      // Agregar el ítem "Todos" al ComboBox
            

            // Recorrer el diccionario de empleados y agregar los nombres al ComboBox
            foreach (var empleado in empleadosDict.Values)
            {
                cbempleado.Items.Add(empleado.NombreCompleto); // Puedes cambiar "NombreCompleto" por otro campo si lo prefieres
            }

            // Opcionalmente, seleccionar el primer empleado por defecto
            if (cbempleado.Items.Count > 0)
            {
                cbempleado.SelectedIndex = 0; // Selecciona el primer empleado
            }
        }
        private void Deduccionxempleado_Load(object sender, EventArgs e)
        {


            Cargarempleados();
            CargarComboBoxConEmpleados();



        }
        private static DeduccionxempleadoVista instancia = null;

        public static DeduccionxempleadoVista ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new DeduccionxempleadoVista();
            }
            return instancia;
        }
       

        private void cbempleado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Cargardg();

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            MenuVistadeduccionesxempleado menuvista = null;
            menuvista = MenuVistadeduccionesxempleado.Abrir1vez();
            menuvista.Show();
        }


        private static DeduccionxempleadoVista fmrDeduccionxempleado = null;
        internal static DeduccionxempleadoVista Abrir1vez()
        {
            if (((fmrDeduccionxempleado == null) || (fmrDeduccionxempleado.IsDisposed == true)))
            {
                fmrDeduccionxempleado = new DeduccionxempleadoVista();
            }
            fmrDeduccionxempleado.BringToFront();
            return fmrDeduccionxempleado;
        }



        private void btnagregar_Click(object sender, EventArgs e)
        {




            if (txtproducto.Text != "" || txttotal.Text != "")
            {
                // Obtener el nombre del empleado seleccionado en el ComboBox
                string nombreEmpleadoSeleccionado = cbempleado.SelectedItem?.ToString();

                // Buscar el IdEmpleado usando el nombre
                int? idempleado = empleadosDict.Values
                    .FirstOrDefault(emp => emp.NombreCompleto == nombreEmpleadoSeleccionado)?.IdEmpleado;

                if (idempleado == null)
                {
                    MessageBox.Show("Empleado no encontrado.");
                    return;
                }



                Deduccion Deduccion = new Deduccion();
                              
                Deduccion.IdEmpleado = idempleado.Value;
                // Buscar el ID del tipo deduccion por su nombre
 
                Deduccion.IdTipoDeduccion = 1;
                Deduccion.FechaDeduccion = DateTime.Now;
                Deduccion.ProductoDescripcion = txtproducto.Text;
                Deduccion.Cantidad = 1;
                Deduccion.Total = Globales.ConvertToDecimal(txttotal.Text);
                Deduccion.Sucursal ="MAGPOLLO "+ Globales.nombresucursallbl;
                Deduccion.IdUsuario = 5;
                Deduccion.Observaciones = "";
               
                try
                {

                    ControladorDeduccioneses.Instance.save(Deduccion);
                    MessageBox.Show("Deduccion Agregada");

                    /*Aqui buscamos el id del producto por el nombre */
                    menu menu = new menu();
                    char delimitador = '\n';
                    string[] producto = txtproducto.Text.ToString().Split(delimitador);
                    menu = ControladorMenu.Instance.findidpornombre(producto[0]);

                    /*Aqui buscamos en la configuracion de inventario los productos a restar de inventario por medio del IDmenu*/
                    List<configinventario> configinventario = new List<configinventario>();
                    configinventario = Controladorconfiginventario.Instance.findbyid(menu.Idmenu);

                    foreach (configinventario d in configinventario)
                    {
                        // MessageBox.Show(d.Idinventario.ToString() + "menos " + d.Cantidadrestar.ToString());
                        configinventario configinv = new configinventario();
                        configinv.Idinventario = d.Idinventario;
                        configinv.Cantidadrestar = (d.Cantidadrestar * 1);
                        Controladorconfiginventario.Instance.updateinventario(configinv);
                    }


                    Cargardg();




                    /**********************************************************************************************/
                    List<impresoras> listaimpresora = new List<impresoras>();
                    sucursales sucursal = new sucursales();
                    sucursal = ControladorSucursal.Instance.find();

                    listaimpresora = ControladorImpresora.Instance.findAll();
                    foreach (var impresoras in listaimpresora)
                    {
                        
                            for (int x = 0; x < impresoras.Ticktes; x++)
                            //for (int x = 0; x < 1; x++)
                            {
                                //Creamos una instancia d ela clase CrearTicket
                                CrearTicket ticket = new CrearTicket();
                                //Ya podemos usar todos sus metodos
                               
                                //obtenemos el nombre por cada id que reciba







                                ticket.AbreCajon();//Para abrir el cajon de dinero.//Datos de la cabecera del Ticket.
                                ticket.TextoCentro(sucursal.Nombresucursal);
                                //ticket.TextoCentro(sucursal.Direccion);
                                ticket.TextoIzquierda("CEL:" + sucursal.Celular);//Es el mio por si me quieren contactar ...
                                ticket.TextoIzquierda("Correo:" + sucursal.Correo);
                                ticket.lineasGuion();


                                ticket.TextoIzquierda("");
                                ticket.TextoCentro("Comprobante....");
                                ticket.TextoIzquierda("Empleado:" + cbempleado.Text);


                                ticket.TextoIzquierda("");
                                ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());

                                //Articulos a vender.
                                ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
                                ticket.lineasIgual();



                                //AgregaArticulo(int cant, string articulo, decimal total)


                                ticket.AgregaArticulo(1, txtproducto.Text, Globales.ConvertToDecimal(txttotal.Text));




                                ticket.lineasIgual();


                                ticket.AgregarTotales("TOTAL        ", Globales.ConvertToDecimal(txttotal.Text));
                                ticket.TextoIzquierda("");

                                //Texto final del Ticket.
                                ticket.TextoIzquierda("");
                                ticket.TextoIzquierda("");
                                ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
                                ticket.TextoIzquierda("");
                                ticket.TextoIzquierda("");
                                ticket.TextoIzquierda("");
                                ticket.TextoIzquierda("");
                                ticket.CortaTicket();

                                ticket.ImprimirTicket(impresoras.Nombreimpresora);//Nombre de la impresora ticketera Microsoft XPS Document Writer
                                                                                  // ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera Microsoft XPS Document Writer

                             


                            }
                        }

                    txtproducto.Text = "";
                    txttotal.Text = "";
                    Globales.complemento = "";

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

                MessageBox.Show("Para Agregar una Deduccion necesita agregar un Producto");



            }

        }







        private void Cargardg()
        {
            dgdeduccion.Rows.Clear();
            


            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;
            // Determinar las fechas de inicio y fin de la quincena
            DateTime fechaInicio, fechaFin;
            if (fechaActual.Day <= 15)
            {
                // Primera quincena: del 1 al 15
                fechaInicio = new DateTime(fechaActual.Year, fechaActual.Month, 1);
                fechaFin = new DateTime(fechaActual.Year, fechaActual.Month, 15);
            }
            else
            {
                // Segunda quincena: del 16 al último día del mes
                fechaInicio = new DateTime(fechaActual.Year, fechaActual.Month, 16);
                fechaFin = new DateTime(fechaActual.Year, fechaActual.Month, DateTime.DaysInMonth(fechaActual.Year, fechaActual.Month));
            }
            // Obtener el nombre del empleado seleccionado en el ComboBox
            string nombreEmpleadoSeleccionado = cbempleado.SelectedItem?.ToString();

            // Buscar el IdEmpleado usando el nombre
            int? idempleado = empleadosDict.Values
                .FirstOrDefault(emp => emp.NombreCompleto == nombreEmpleadoSeleccionado)?.IdEmpleado;

            if (idempleado == null)
            {
                MessageBox.Show("Empleado no encontrado.");
                return;
            }
            // Cargar todas las deducciones
            List<Deduccion> deducciones = ControladorDeduccioneses.Instance.finddeduccionesxfechas(fechaInicio, fechaFin, idempleado.Value, Globales.basedatoscentral);
            decimal sumaTotal = 0;
            // Agregar cada deducción al DataGridView, buscando el nombre del empleado y del tipo de deducción en los diccionarios
            foreach (Deduccion deduccion in deducciones)
            {
                // Intenta obtener el empleado del diccionario
                string nombreEmpleado = empleadosDict.TryGetValue((int)deduccion.IdEmpleado, out Empleado empleado)
                    ? empleado.NombreCompleto // Asegúrate de que el objeto Empleado tiene esta propiedad
                    : "Empleado desconocido";

                dgdeduccion.Rows.Add(
                    deduccion.IdDeduccion,
                    nombreEmpleado,
                    deduccion.ProductoDescripcion,
                    deduccion.Cantidad,
                    deduccion.Total.ToString("N2", CultureInfo.InvariantCulture),
                    deduccion.Sucursal,
                     deduccion.FechaDeduccion.ToString("dd/MM/yyyy hh:mm tt")
                );

                // Acumula el total
                sumaTotal += deduccion.Total; // Asegúrate de que 'Total' es de tipo decimal
            }
            txtsaldo.Text = sumaTotal.ToString("N2", CultureInfo.InvariantCulture);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   // Si es la primera vez que se interactúa, almacenamos el valor original
            if (precioOriginal == 0)
            {
                precioOriginal = Globales.ConvertToDecimal(txttotal.Text);
            }

            // Si el CheckBox está marcado, aplicar el 15% de descuento
            if (checkBox1.Checked)
            {
                decimal precioConDescuento = precioOriginal * 0.85m; // Aplicar 15% de descuento
                txttotal.Text = precioConDescuento.ToString("N2", CultureInfo.InvariantCulture);
            }
            else
            {
                // Si el CheckBox está desmarcado, volver al precio original
                txttotal.Text = precioOriginal.ToString("N2", CultureInfo.InvariantCulture);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtproducto.Text = "";
            txttotal.Text = "";
            precioOriginal = 0;
            checkBox1.Checked = false;
        }
    }
}
