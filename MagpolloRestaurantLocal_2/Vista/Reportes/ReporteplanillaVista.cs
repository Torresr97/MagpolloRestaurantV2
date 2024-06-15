using AppTRchicken.Controlador;
using AppTRchicken.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTRchicken.Vista.Reportes
{
    public partial class ReporteplanillaVista : Form
    {
        public ReporteplanillaVista()
        {
            InitializeComponent();
        }
        private static ReporteplanillaVista fmrReporteplanilla = null;
        internal static ReporteplanillaVista Abrir1vez()
        {
            if (((fmrReporteplanilla == null) || (fmrReporteplanilla.IsDisposed == true)))
            {
                fmrReporteplanilla = new ReporteplanillaVista();
            }
            fmrReporteplanilla.BringToFront();
            return fmrReporteplanilla;
        }
        private void Reporteplanilla_Load(object sender, EventArgs e)
        {
            int height = this.Height;
            int width = this.Width;



            int altura = dgreporteplanilla.Location.Y;

            btnexportar.Location = new Point((width - btnexportar.Width - 20), (altura - btnexportar.Height - 5));





            dtpmesyano.Visible = false;
            dthasta.Visible = false;

            btnBuscar.Visible = false;

            //cbempleados.DataSource = ControladorEmpleados.Instance.Cargarcomboxempleado();
            List<empleados> Empleados = new List<empleados>();
            Empleados = ControladorEmpleados.Instance.findAll();
            cbempleado.DataSource = Empleados;

            cbempleado.ValueMember = "nombreempleado";
            cbempleado.DisplayMember = "nombreempleado";
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscar.SelectedItem.ToString() == "Mes")
            {
                
                dgreporteplanilla.Rows.Clear();
                btnBuscar.Visible = true;

                btnBuscar.Location = new Point(540, 57);

                dtpmesyano.Visible = true;
                dthasta.Visible = false;

            }
            else if (cbBuscar.SelectedItem.ToString() == "Año")
            {
               
                dgreporteplanilla.Rows.Clear();
                btnBuscar.Visible = true;

                btnBuscar.Location = new Point(540, 57);

                dtpmesyano.Visible = true;
                dthasta.Visible = false;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            empleados empleados = new empleados();
            empleados = ControladorEmpleados.Instance.findidbynombre(cbempleado.Text);

            if (cbBuscar.Text.ToString() == "Mes")
            {
                dgreporteplanilla.Rows.Clear();
                List<Planilla> planilla = new List<Planilla>();
                planilla = ControladorPlanilla.Instance.ReportePlanillames(dtpmesyano.Value.Month.ToString(), empleados.Idempleado);

                foreach(Planilla p in planilla)
                {
                    dgreporteplanilla.Rows.Add(p.Idplanilla,p.Fechaemision,p.Periododesde,p.Periodohasta,p.Sueldobase,p.Ingresoextra,p.Totaldeducciones,p.Totalapagar);
                }

            }

        }
    }
}
