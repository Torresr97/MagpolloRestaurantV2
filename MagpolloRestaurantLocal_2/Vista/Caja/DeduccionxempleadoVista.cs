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

namespace AppTRchicken.Vista
{
    public partial class DeduccionxempleadoVista : Form
    {
        int iddeduccion = 0;

        public DeduccionxempleadoVista()
        {
            InitializeComponent();
        }

        private void Deduccionxempleado_Load(object sender, EventArgs e)
        {
            

            Cargarcbxempleado();
            


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
        private void Cargarcbxempleado()
        {
            //cbempleados.DataSource = ControladorEmpleados.Instance.Cargarcomboxempleado();
            List<empleados> Empleados = new List<empleados>();
            Empleados = ControladorEmpleados.Instance.findAll();
            cbempleado.DataSource = Empleados;

            cbempleado.ValueMember = "nombreempleado";
            cbempleado.DisplayMember = "nombreempleado";

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
                empleados empleados = new empleados();
                empleados = ControladorEmpleados.Instance.findidbynombre(cbempleado.Text);

                Deduccionxempleados Deduccionxempleados = new Deduccionxempleados();
                Deduccionxempleados.Idempleado = empleados.Idempleado;
                Deduccionxempleados.Numeroplanilla = "";
                Deduccionxempleados.Deduccion = txtproducto.Text;
                Deduccionxempleados.Total = Convert.ToDouble(txttotal.Text);
                Deduccionxempleados.Fecha = DateTime.Now; 
                try
                {

                    Controladordeduccionesxempleado.Instance.save(Deduccionxempleados);
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
                    impresoras impresoras = new impresoras();
                    impresoras = ControladorImpresora.Instance.findconfig();
                    for (int x = 0; x < impresoras.Ticktes; x++)
                     //for (int x = 0; x < 1; x++)
                    {
                        //Creamos una instancia d ela clase CrearTicket
                        CrearTicket ticket = new CrearTicket();
                        //Ya podemos usar todos sus metodos
                        sucursales sucursal = new sucursales();
                        sucursal = ControladorSucursal.Instance.find();
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


                        ticket.AgregaArticulo(1, txtproducto.Text, Convert.ToDecimal(txttotal.Text));




                        ticket.lineasIgual();


                        ticket.AgregarTotales("TOTAL        ", Convert.ToDecimal(txttotal.Text));
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

                        /* CON ESTO ES PARA PROBAR SI IMPRIME LAS IMAGENES
                        Image image = Properties.Resources.close;

                        // Convertir la imagen en un formato adecuado, como PNG
                        using (MemoryStream stream = new MemoryStream())
                        {
                            image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                            byte[] imageBytes = stream.ToArray();

                            // Luego puedes enviar estos bytes a la impresora
                            string impresora = "Microsoft Print to PDF"; // Reemplaza con el nombre de tu impresora
                            IntPtr pBytes = Marshal.AllocCoTaskMem(imageBytes.Length);
                            Marshal.Copy(imageBytes, 0, pBytes, imageBytes.Length);

                            ticket.ImprimirTicketimagen(impresora, pBytes, imageBytes.Length);

                            Marshal.FreeCoTaskMem(pBytes);
                        }
                        */
                     


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
            empleados empleados = new empleados();
            empleados = ControladorEmpleados.Instance.findidbynombre(cbempleado.Text);


            dgdeduccionxempleado.Rows.Clear();
            List<Deduccionxempleados> creditoxempleados = new List<Deduccionxempleados>();
            creditoxempleados = Controladordeduccionesxempleado.Instance.findAllbyid(empleados.Idempleado);

            foreach (Deduccionxempleados Deduccionxempleado in creditoxempleados)
            {


                dgdeduccionxempleado.Rows.Add(Deduccionxempleado.Iddeduccion, Deduccionxempleado.Idempleado, Deduccionxempleado.Deduccion, Deduccionxempleado.Total, Deduccionxempleado.Fecha.ToString("dd/MM/yyyy hh:mm tt")); 
            }
            int Saldox = 0;
            for (int x = 0; x < dgdeduccionxempleado.Rows.Count; ++x)
            {

                Saldox += Convert.ToInt32(dgdeduccionxempleado.Rows[x].Cells["Total"].Value);

            }

            txtsaldo.Text = String.Format(" L " + "{0:n}", Saldox.ToString());
        }

      

        internal void dgdeduccionxempleado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
               
                iddeduccion = Convert.ToInt32(dgdeduccionxempleado.CurrentRow.Cells[0].Value.ToString());
                dgdeduccionxempleado.CurrentCell = dgdeduccionxempleado.Rows[e.RowIndex].Cells[e.ColumnIndex];

                ContextMenu cm = new ContextMenu();
                MenuItem mi = new MenuItem();
                mi.Text = "Eliminar";
                mi.Click += Eliminar; //metodo al dar click
                cm.MenuItems.Add(mi);


                //Obtienes las coordenadas de la celda seleccionada. 
                Rectangle coordenada = dgdeduccionxempleado.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                int anchoCelda = coordenada.Location.X; //Ancho de la localizacion de la celda
                int altoCelda = coordenada.Location.Y;  //Alto de la localizacion de la celda

                //Y para mostrar el menú lo haces de esta forma:  
                int X = anchoCelda;
                int Y = altoCelda;

                cm.Show(dgdeduccionxempleado, new Point(X, Y));


            }
        }


        private void Eliminar(Object sender, EventArgs e)
        {
            usuarios usuarios = new usuarios();
            usuarios = ControladorUsuario.Instance.findidbynombre(Globales.nombreusuario);
            Globales.idusuario = (int)usuarios.Idusuario;
            roles roles = new roles();
            roles = ControladorRoles.Instance.findrolebynombreusuario(Globales.nombreusuario);
            if (roles.Roles != "Admin")
            {
                MessageBox.Show("No tienes Suficientes Privilegios, Pide ayuda a tu Superior");

            }
            else
            {
                Deduccionxempleados Deduccionxempleados = new Deduccionxempleados();
                Deduccionxempleados.Iddeduccion = iddeduccion;
                Controladordeduccionesxempleado.Instance.delete(Deduccionxempleados);
                MessageBox.Show("Deduccion Eliminada");
                Cargardg();

            }

        }
        }
}
