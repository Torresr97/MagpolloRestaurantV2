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
using AppTRchicken.Vista.Configuraciones_Generales;


namespace AppTRchicken.Vista.Reportes
{
    public partial class ReportededuccionxempleadoVista : Form
    {
        private Dictionary<int, empleados> empleadosDict;
        public ReportededuccionxempleadoVista()
        {
            InitializeComponent();
            empleadosDict = new Dictionary<int, empleados>();
        }

        private void Cargarempleados()
        {
            empleadosDict.Clear();

            // Cargar todos los empleados
            List<empleados> empleados = ControladorEmpleados.Instance.findAll();

            // Agregar cada empleado al DataGridView y al diccionario
            foreach (empleados empleado in empleados)
            {
                empleadosDict[empleado.Idempleado] = empleado;

            }
        }

        private void CargarComboBoxConEmpleados()
        {
            cbempleado.Items.Clear(); // Limpiar el ComboBox antes de cargar nuevos empleados
                                      // Agregar el ítem "Todos" al ComboBox
            cbempleado.Items.Add("Todos");

            // Recorrer el diccionario de empleados y agregar los nombres al ComboBox
            foreach (var empleado in empleadosDict.Values)
            {
                cbempleado.Items.Add(empleado.Nombreempleado); // Puedes cambiar "NombreCompleto" por otro campo si lo prefieres
            }

            // Opcionalmente, seleccionar el primer empleado por defecto
            if (cbempleado.Items.Count > 0)
            {
                cbempleado.SelectedIndex = 0; // Selecciona el primer empleado
            }
        }
        private static ReportededuccionxempleadoVista fmrReportededuccionxempleado = null;
        internal static ReportededuccionxempleadoVista Abrir1vez()
        {
            if (((fmrReportededuccionxempleado == null) || (fmrReportededuccionxempleado.IsDisposed == true)))
            {
                fmrReportededuccionxempleado = new ReportededuccionxempleadoVista();
            }
            fmrReportededuccionxempleado.BringToFront();
            return fmrReportededuccionxempleado;
        }

        private void Reportededuccionxempleado_Load(object sender, EventArgs e)
        {
            int height = this.Height;
            int width = this.Width;



            int altura = dgreportededuccion.Location.Y;

            btnexportar.Location = new Point((width - btnexportar.Width - 20), (altura - btnexportar.Height - 5));





            dtpmesyano.Visible = false;
            dthasta.Visible = false;

            btnBuscar.Visible = false;


            Cargarempleados();
            CargarComboBoxConEmpleados();

        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscar.SelectedItem.ToString() == "Dia")
            {
                txttotal.Text = "";
                dgreportededuccion.Rows.Clear();
                btnBuscar.Visible = true;

                btnBuscar.Location = new Point(540, 57);

                dtpmesyano.Visible = true;
                dthasta.Visible = false;

            }
           
            else if (cbBuscar.SelectedItem.ToString() == "Desde - Hasta")
            {
                txttotal.Text = "";
                dgreportededuccion.Rows.Clear();
                btnBuscar.Visible = true;

                btnBuscar.Location = new Point(540, 57);

                dtpmesyano.Visible = true;
                dthasta.Visible = true;


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
            if (cargandoForm.InvokeRequired)
            {
                cargandoForm.Invoke((MethodInvoker)delegate
                {
                    // Cerrar el formulario de carga en el hilo de la interfaz de usuario
                    cargandoForm.Close();
                });
            }
            else
            {
                // Si ya estamos en el hilo de la interfaz de usuario, cerrar el formulario de carga directamente
                cargandoForm.Close();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int estado = 0;

            empleados empleados = new empleados();
            empleados = ControladorEmpleados.Instance.findidbynombre(cbempleado.Text);
            if (cbxestadodeduccion.Text == "Pendientes")
            {
                estado = 0;
            }
            else
            {
                estado = 1;
            }


            if (cbBuscar.Text.ToString() == "Dia")
            {
                int tiempoDeseado = 600000; // Por ejemplo, 5 segundos
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);

                try
                {
                    txttotal.Text = "";
                    dgreportededuccion.Rows.Clear();
                    List<Deduccionxempleados> Deduccionxempleados = new List<Deduccionxempleados>();
                    Deduccionxempleados = Controladordeduccionesxempleado.Instance.ReporteDeduccionDia(dtpmesyano.Value.ToString("yyyy-MM-dd"), empleados.Idempleado, estado);

                    foreach (Deduccionxempleados d in Deduccionxempleados)
                    {
                        string estadostring = "";
                        if (d.Estado == false)
                        {
                            estadostring = "Pendientes";
                        }
                        {
                            estadostring = "Cobradas";

                        }

                        //buscar el role por medio del idrole antes de ingresarlo
                        dgreportededuccion.Rows.Add(d.Iddeduccion, d.Numeroplanilla, d.Deduccion, d.Total, d.Fecha, estadostring);
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

                double total = 0;

                for (int x = 0; x < dgreportededuccion.Rows.Count; ++x)
                {
                    total += Convert.ToInt32(dgreportededuccion.Rows[x].Cells["Total"].Value);
                    txttotal.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                }
            }
            if (cbBuscar.Text.ToString() == "Desde - Hasta")
            {
                int tiempoDeseado = 600000; // Por ejemplo, 5 segundos
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);


                try
                {
                    txttotal.Text = "";
                    dgreportededuccion.Rows.Clear();
                    List<Deduccionxempleados> Deduccionxempleado = new List<Deduccionxempleados>();
                    Deduccionxempleado = Controladordeduccionesxempleado.Instance.ReporteDeducciondesdehasta(dtpmesyano.Value.ToString("yyyy-MM-dd"), dthasta.Value.ToString("yyyy-MM-dd"), empleados.Idempleado, estado);

                    foreach (Deduccionxempleados d in Deduccionxempleado)
                    {


                        string estadostring = "";
                        if (d.Estado == false)
                        {
                            estadostring = "Pendientes";
                        }
                        {
                            estadostring = "Cobradas";

                        }

                        //buscar el role por medio del idrole antes de ingresarlo
                        dgreportededuccion.Rows.Add(d.Iddeduccion, d.Numeroplanilla, d.Deduccion, d.Total, d.Fecha, estadostring);
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
                double total = 0;

                for (int x = 0; x < dgreportededuccion.Rows.Count; ++x)
                {
                    total += Convert.ToInt32(dgreportededuccion.Rows[x].Cells["Total"].Value);
                    txttotal.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                }
            }
           
        }
    }
}
