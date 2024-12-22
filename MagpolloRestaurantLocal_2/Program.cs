
using AppTRchicken.Vista;
using AppTRchicken.Vista.Configuraciones_Generales;
using AppTRchicken.Vista.Inventario;
using AppTRchicken.Vista.Menu;
using AppTRchicken.Vista.Prueba_Vistas;
using AppTRchicken.Vista.Pruebas;
using AppTRchicken.Vista.Reportes;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace AppTRchicken
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new InventarioVista());
            // Application.Run(new ReporteMovimientoscajas());
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new Loginvista());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            //Application.Run(new Prueba_de_Tickets());
            //Application.Run(new PagodePlanillaVista());
            //Application.Run(new ReporteVentasVistas());

        }
    }
}
