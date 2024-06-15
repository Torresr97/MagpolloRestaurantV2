using AppTRchicken.Utilidades;
using AppTRchicken.Vista.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTRchicken.Vista
{
    public partial class CUreportes : UserControl
    {
        public CUreportes()
        {
            InitializeComponent();
            Globales.HabilitarBotonesSegunPermisos(this);
        }

        private void btnReporteVentasVistas_Click(object sender, EventArgs e)
        {

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            ReporteVentasVistas ReporteVentasVistas = null;
            ReporteVentasVistas = ReporteVentasVistas.Abrir1vez();
            ReporteVentasVistas.Show();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            PantallaPrincipal PantallaPrincipal = new PantallaPrincipal();
            PantallaPrincipal = (PantallaPrincipal)this.FindForm();
            PantallaPrincipal.panelContenedor1.Controls.Clear();
            PantallaPrincipal.panelmenu.Dock = DockStyle.Fill;

            PantallaPrincipal.panelContenedor1.Controls.Add(PantallaPrincipal.panelmenu);
        }

        private void btnReporteVentasxCategoriaVista_Click(object sender, EventArgs e)
        {

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
          que permite abrir el formulario solo 1 vez*/
            ReporteVentasxCategoriaVista ReporteVentasxCategoriaVista = null;
            ReporteVentasxCategoriaVista = ReporteVentasxCategoriaVista.Abrir1vez();
            ReporteVentasxCategoriaVista.Show();
        }

        private void btnreportecompras_Click(object sender, EventArgs e)
        {
           

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
           que permite abrir el formulario solo 1 vez*/
            ReporteComprasVista ReporteComprasVista = null;
            ReporteComprasVista = ReporteComprasVista.Abrir1vez();
            ReporteComprasVista.Show();

        }

        private void btnReportededuccionxempleadoVista_Click(object sender, EventArgs e)
        {
            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
           que permite abrir el formulario solo 1 vez*/
            ReportededuccionxempleadoVista Reportededuccionxempleado  = null;
            Reportededuccionxempleado = ReportededuccionxempleadoVista.Abrir1vez();
            Reportededuccionxempleado.Show();

        }

        private void btnReporteplanillaVista_Click(object sender, EventArgs e)
        {
            ReporteplanillaVista Reporteplanilla = null;
            Reporteplanilla = ReporteplanillaVista.Abrir1vez();
            Reporteplanilla.Show();
        }

        private void btnReporteMovimientoscajasVista_Click(object sender, EventArgs e)
        {
            ReporteMovimientoscajasVista ReporteMovimientoscajas = null;
            ReporteMovimientoscajas = ReporteMovimientoscajasVista.Abrir1vez();
            ReporteMovimientoscajas.Show();
        }
    }
}
