using AppTRchicken.Controlador;
using AppTRchicken.Modelo;
using AppTRchicken.Utilidades;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTRchicken.Vista.Pruebas
{
    public partial class Prueba_de_Tickets : Form
    {
        public Prueba_de_Tickets()
        {
            InitializeComponent();
        }
        // Función para obtener datos de un recurso de imagen
      

        private void btncobrar_Click(object sender, EventArgs e)
        {
            //Creamos una instancia d ela clase CrearTicket
            CrearTicket ticket = new CrearTicket();
            //Ya podemos usar todos sus metodos
            sucursales sucursal = new sucursales();
            sucursal = ControladorSucursal.Instance.find();
            //obtenemos el nombre por cada id que reciba
            Cliente Cliente = new Cliente();
            Cliente = ControladorCliente.Instance.findbyid(Globales.idcliente);




            ticket.AbreCajon();//Para abrir el cajon de dinero.//Datos de la cabecera del Ticket.
            ticket.TextoCentro(sucursal.Nombresucursal);
            ticket.TextoCentro(sucursal.Direccion);
            ticket.TextoIzquierda("CEL:" + sucursal.Celular);//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("Correo:" + sucursal.Correo);
            ticket.TextoIzquierda("RTN: xxxx-xxxx-xxxxx");
            ticket.TextoIzquierda("CAI: xxxx-xxxx-xxxxx-xxxx-xxxxx");
            ticket.TextoIzquierda("Fecha Emision: xx/xx/xxxx");
            ticket.TextoIzquierda("Rango Aprobado:");
            ticket.TextoIzquierda("DESDE: xxxxxxxxxxxxx");
            ticket.TextoIzquierda("HASTA: xxxxxxxxxxxxx");
            ticket.lineasGuion();
            ticket.TextoCentro("FACTURA");
            ticket.TextoCentro("XXX-XXXXXXX-XXXXXX");
            ticket.TextoIzquierda("Cliente: N/A");
            ticket.TextoIzquierda("RTN: XXXX-XXXX-XXXXX");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.TextoCentro("Orden #" + Globales.orden.ToString());
            ticket.TextoCentro(Globales.servir);
            
            ticket.lineasGuion();
            ticket.TextoIzquierda("");
            


            ticket.TextoIzquierda("");
       

            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasIgual();
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            //foreach (DataGridViewRow fila in dgvLista.Rows)//dgvLista es el nombre del datagridview
            //{
            //ticket.AgregaArticulo(fila.Cells[2].Value.ToString(), int.Parse(fila.Cells[5].Value.ToString()),
            //decimal.Parse(fila.Cells[4].Value.ToString()), decimal.Parse(fila.Cells[6].Value.ToString()));
            //}



                    ticket.AgregaArticulo(10,"Hamburguesa con pollo",1500);
            ticket.AgregaArticulo(10, "Hamburguesa con tajada", 1700);
            ticket.AgregaArticulo(10, "Pollo con tajadas", 1200);



            ticket.lineasIgual();

            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("SUBTOTAL", Globales.gravado);
            ticket.AgregarTotales("ISV", Globales.isv);//La M indica que es un decimal en C#
            ticket.AgregarTotales("TOTAL A PAGAR", Globales.ventatotal);
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("FORMA DE PAGO");
            ticket.AgregarTotales(Globales.metodopago.ToString(), Globales.Dinerorecibido);

            ticket.AgregarTotales("VUELTO", Globales.vuelto);

            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.CortaTicket();


            ticket.ImprimirTicket("Microsoft XPS Document Writer");
           


           // ticket.ImprimirTicket("Microsoft XPS Document Writer");
        }


        private static byte[] ObtenerDatosDesdeRecurso(string nombreRecurso)
        {
            try
            {
                // Cargar la imagen desde los recursos
                using (Stream stream = typeof(CrearTicket).Assembly.GetManifestResourceStream(nombreRecurso))
                {
                    if (stream == null)
                    {
                        Console.WriteLine("Recurso no encontrado.");
                        return new byte[0];
                    }

                    using (MemoryStream ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        return ms.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar la imagen desde el recurso: " + ex.Message);
                return new byte[0];
            }

        }

        // Función para convertir un array de bytes a IntPtr (igual que en el ejemplo anterior)
        private static IntPtr DatosIntPtr(byte[] datos)
        {
            // Convertir el array de bytes a IntPtr
            IntPtr punteroDatos = Marshal.AllocCoTaskMem(datos.Length);
            Marshal.Copy(datos, 0, punteroDatos, datos.Length);
            return punteroDatos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ticket2 ticket2 = new Ticket2();
           // ticket2.HeaderImage = Properties.Resources.magpollo;
            ticket2.AddHeaderLine("Hola esto es una prueba AddHeaderLine");
            ticket2.AddSubHeaderLine("Hola esto es una prueba 2 AddSubHeaderLine");
            ticket2.AddItem("2","Hamburguesa","1,500");
            ticket2.AddTotal("Total a pagar","2500");
            ticket2.AddFooterLine("Gracias por su pago AddFooterLine");
            ticket2.PrintTicket("Microsoft XPS Document Writer");


        }
    }
}
