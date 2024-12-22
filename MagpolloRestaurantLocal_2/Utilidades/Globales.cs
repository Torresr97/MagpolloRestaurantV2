using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTRchicken.Utilidades
{
    public class Globales
    {
        public static bool IsDynamicLogin = false;
        public static string nombresucursallbl = "";
        public static string basedatos = "";
        public static string Nombrebasedatos = "";
        public static string nombreclienteorden = "";
        public static string basedatoscentral = "Corporacion_alimentaos_RRHH";
        /*michoacanasprueba*/
        /*MagpolloLocal_2*/


        //***************************************Variables para permisos de usuarios segun su role*************************************************

        public static string nombreusuario;
        public static string pswusuario;


        public static string roleusuario;
        public static int idroleusuario;





        //***************************************Variables para deposito y retiros*************************************************

        public static decimal deposito;
        public static decimal retiro;
        public static decimal disponible;



        //***************************************Variables para Ticket de Cocina*************************************************
        public static List<string> complementosSeleccionados = new List<string>();

        public static string complemento = "";
        public static int contador;
        public static string btn = "";
        public static int papas = 0;
        public static int tajadas = 0;
        public static int tostones = 0;
        public static int yuca = 0;
        //***************************************Variables para Ticket de Cocina*************************************************




        //***************************************Variables para Facturar Una Venta*************************************************


        public static int orden;

        public static string fecha;
        public static decimal descuento = 0;
        public static decimal ventatotal = 0;
        public static decimal isv = 0;
        public static decimal exonerado = 0;
        public static decimal exento = 0;
        public static decimal gravado = 0;
        public static string servir = "";
        public static string metodopago = "";
        public static string ultimosdigitos = "";

        public static decimal Dinerorecibido = 0;
        public static decimal vuelto = 0;
        public static int idsucursal;

        public static int idusuario;
        public static string producto = "";
        public static int numerocierre;

        //***************************************Variables para obtener datos de clientes *************************************************
        public static int idcliente;
        public static string nombrecliente = "";
        public static string rtncliente = "";


        //***************************************Variables pago de planilla*************************************************

        public static decimal totalapagar = 0;
        public static long idempleado;



        //***************************************Variables para tomar datos de la sucursal *************************************************
        public static string sucursalnombre = "";
        public static string sucursaldireccion = "";
        public static string sucursalcelular = "";
        public static string sucursalcorreo = "";
        public static string sucursalrtn = "";
        public static string sucursalcai = "";
        public static string sucursalfechaemisionfactura = "";
        public static string sucursalrangodesde = "";
        public static string sucursalrangohasta = "";
        public static Boolean sucursalfacturarconcai = false;
        public static string sucursalnumerofacturacai;
        public static string primerapartenumerofacturacai;







        //****************************Funciones ********************************************//

        //***************************************Propiedad para almacenar permisos de pantalla*************************************************

        public static List<string> PermisosPantalla { get; set; } = new List<string>();


        public static void HabilitarBotonesSegunPermisos(Control control)
        {
            // Obtén los nombres de todos los botones en el formulario actual
            List<string> nombresBotones = ObtenerNombresBotones(control);

            // Itera sobre todos los botones en el formulario
            foreach (string nombreBoton in nombresBotones)
            {
                // Construye el nombre de la pantalla correspondiente al botón
                string nombrePantalla = nombreBoton.Substring(3); // Quita los primeros 3 caracteres "btn"

                // Verifica si el nombre de la pantalla está en la lista de permisos
                if (PermisosPantalla.Contains(nombrePantalla))
                {
                    // Si el botón corresponde a una pantalla con permiso, habilítalo
                    Button boton = control.Controls.Find(nombreBoton, true).FirstOrDefault() as Button;
                    if (boton != null)
                    {
                        boton.Enabled = true;
                        boton.Visible = true;
                    }
                }
                else
                {
                    // Si el botón no corresponde a una pantalla con permiso, deshabilítalo
                    Button boton = control.Controls.Find(nombreBoton, true).FirstOrDefault() as Button;
                    if (boton != null)
                    {
                        boton.Enabled = false;
                        boton.Visible = false;

                    }
                }
            }
        }

        // Función para obtener los nombres de todos los botones en un formulario
        private static List<string> ObtenerNombresBotones(Control control)
        {
            List<string> nombresBotones = new List<string>();
            foreach (Control ctrl in GetAllControls(control))
            {
                if (ctrl is Button boton)
                {
                    nombresBotones.Add(boton.Name);
                }
            }
            return nombresBotones;
        }

        // Función para obtener todos los controles de un formulario y sus controles secundarios recursivamente
        private static IEnumerable<Control> GetAllControls(Control control)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAllControls(ctrl)).Concat(controls);
        }


        //funcion para convertir todo a decimal pero en db tiene que estar decimal(18,2)

        // Función para convertir un texto a decimal
        public static decimal ConvertToDecimal(string text, decimal defaultValue = 0)
        {
            if (decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal result))
            {
                return result;
            }
            else
            {
                // Puedes registrar un error o manejar el fallo de otra manera
                return defaultValue;
            }
        }

    }

}
