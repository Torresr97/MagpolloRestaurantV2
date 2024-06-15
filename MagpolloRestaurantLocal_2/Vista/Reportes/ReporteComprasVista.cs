using AppTRchicken.Controlador;
using AppTRchicken.Modelo;
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
using AppTRchicken.Vista.Configuraciones_Generales;

namespace AppTRchicken.Vista
{
    public partial class ReporteComprasVista : Form
    {
        public ReporteComprasVista()
        {
            InitializeComponent();
        }
       
        private void ReporteComprasVista_Load(object sender, EventArgs e)
        {
            dtpmesyano.Visible = false;
            dthasta.Visible = false;

            btnBuscar.Visible = false;


            int height = this.Height;
            int width = this.Width;
            int altura = dgreportecompras.Location.Y;
            btnexportar.Location = new Point((width - btnexportar.Width - 20), (altura - btnexportar.Height - 5));


        }

        private void cbBcompras_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbBcompras.SelectedItem.ToString() == "Dia")
            {
                dgreportecompras.Rows.Clear();
                btnBuscar.Visible = true;
                btnBuscar.Location = new Point(455, 15);
                dtpmesyano.Visible = true;
                dthasta.Visible = false;

            }
            else if (cbBcompras.SelectedItem.ToString() == "Mes")
            {
                dgreportecompras.Rows.Clear();
                btnBuscar.Visible = true;
                btnBuscar.Location = new Point(455, 15);
                dtpmesyano.Visible = true;
                dthasta.Visible = false;

            }
            else if (cbBcompras.SelectedItem.ToString() == "Año")
            {
                dgreportecompras.Rows.Clear();
                btnBuscar.Visible = true;
                btnBuscar.Location = new Point(455, 15);
                dtpmesyano.Visible = true;
                dthasta.Visible = false;

            }
            else if (cbBcompras.SelectedItem.ToString() == "Desde - Hasta")
            {
                dgreportecompras.Rows.Clear();
                btnBuscar.Visible = true;
                btnBuscar.Location = new Point(655, 15);
                dtpmesyano.Visible = true;
                dthasta.Visible = true;


            }

        }


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



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBcompras.SelectedItem.ToString() == "Dia")
            {
                int tiempoDeseado = 600000;
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);


                try
                {
                    dgreportecompras.Rows.Clear();
                    List<Compra> comp = new List<Compra>();
                    comp = ControladorCompra.Instance.FincompraFecha(dtpmesyano.Value.ToString("yyyy-MM-dd"));

                    char delimitador = ' ';
                    foreach (Compra compra in comp)
                    {
                        string[] fechasinhora = compra.Fecha.Split(delimitador);
                        tipo_compra tipo_compra = new tipo_compra();
                        tipo_compra = ControladorTipo_Compra.Instance.findnombrenyid((int)compra.Idtipocompra);

                        proovedor proovedor = new proovedor();
                        proovedor = ControladorProveedor.Instance.findnombrenyid((int)compra.Idproovedor);
                        //buscar el role por medio del idrole antes de ingresarlo
                        dgreportecompras.Rows.Add(compra.Nombre_compra, tipo_compra.Nombretipocompra, proovedor.Nombre_empresa, compra.Total, fechasinhora[0]);
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
                double isv = 0;
                double subtotal = 0;
                for (int x = 0; x < dgreportecompras.Rows.Count; ++x)
                {
                    total += Convert.ToInt32(dgreportecompras.Rows[x].Cells["Total"].Value);
                    txttotal.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                    subtotal = (total / 1.15);
                    isv = (subtotal * 0.15);
                    txtsubtotal.Text = String.Format(" L " + "{0:n}", subtotal.ToString("N", new CultureInfo("en-US")));
                    txtisv.Text = String.Format(" L " + "{0:n}", isv.ToString("N", new CultureInfo("en-US")));
                }

            }
            if (cbBcompras.SelectedItem.ToString() == "Mes")
            {
                int tiempoDeseado = 600000;
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);

                try
                {
                    dgreportecompras.Rows.Clear();
                    List<Compra> comp = new List<Compra>();
                    comp = ControladorCompra.Instance.Fincomprames(dtpmesyano.Value.Month.ToString(), dtpmesyano.Value.Year.ToString());

                    char delimitador = ' ';
                    foreach (Compra compra in comp)
                    {
                        string[] fechasinhora = compra.Fecha.Split(delimitador);
                        tipo_compra tipo_compra = new tipo_compra();
                        tipo_compra = ControladorTipo_Compra.Instance.findnombrenyid((int)compra.Idtipocompra);

                        proovedor proovedor = new proovedor();
                        proovedor = ControladorProveedor.Instance.findnombrenyid((int)compra.Idproovedor);
                        //buscar el role por medio del idrole antes de ingresarlo
                        dgreportecompras.Rows.Add(compra.Nombre_compra, tipo_compra.Nombretipocompra, proovedor.Nombre_empresa, compra.Total, fechasinhora[0]);
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
                double isv = 0;
                double subtotal = 0;
                for (int x = 0; x < dgreportecompras.Rows.Count; ++x)
                {
                    total += Convert.ToInt32(dgreportecompras.Rows[x].Cells["Total"].Value);
                    txttotal.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                    subtotal = (total / 1.15);
                    isv = (subtotal * 0.15);
                    txtsubtotal.Text = String.Format(" L " + "{0:n}", subtotal.ToString("N", new CultureInfo("en-US")));
                    txtisv.Text = String.Format(" L " + "{0:n}", isv.ToString("N", new CultureInfo("en-US")));
                }

            }
            if (cbBcompras.SelectedItem.ToString() == "Año")
            {
                int tiempoDeseado = 600000;
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);

                try
                {
                    dgreportecompras.Rows.Clear();
                    List<Compra> comp = new List<Compra>();
                    comp = ControladorCompra.Instance.Fincompraano(dtpmesyano.Value.Year.ToString());

                    char delimitador = ' ';
                    foreach (Compra compra in comp)
                    {
                        string[] fechasinhora = compra.Fecha.Split(delimitador);
                        tipo_compra tipo_compra = new tipo_compra();
                        tipo_compra = ControladorTipo_Compra.Instance.findnombrenyid((int)compra.Idtipocompra);

                        proovedor proovedor = new proovedor();
                        proovedor = ControladorProveedor.Instance.findnombrenyid((int)compra.Idproovedor);
                        //buscar el role por medio del idrole antes de ingresarlo
                        dgreportecompras.Rows.Add(compra.Nombre_compra, tipo_compra.Nombretipocompra, proovedor.Nombre_empresa, compra.Total, fechasinhora[0]);
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
                double isv = 0;
                double subtotal = 0;
                for (int x = 0; x < dgreportecompras.Rows.Count; ++x)
                {
                    total += Convert.ToInt32(dgreportecompras.Rows[x].Cells["Total"].Value);
                    txttotal.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                    subtotal = (total / 1.15);
                    isv = (subtotal * 0.15);
                    txtsubtotal.Text = String.Format(" L " + "{0:n}", subtotal.ToString("N", new CultureInfo("en-US")));
                    txtisv.Text = String.Format(" L " + "{0:n}", isv.ToString("N", new CultureInfo("en-US")));
                }

            }
            if (cbBcompras.SelectedItem.ToString() == "Desde - Hasta")
            {
                int tiempoDeseado = 600000;
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);

                try
                {
                    dgreportecompras.Rows.Clear();
                    List<Compra> comp = new List<Compra>();
                    comp = ControladorCompra.Instance.Fincompradesdehasta(dtpmesyano.Value.ToString("yyyy-MM-dd"), dthasta.Value.ToString("yyyy-MM-dd"));

                    char delimitador = ' ';
                    foreach (Compra compra in comp)
                    {
                        string[] fechasinhora = compra.Fecha.Split(delimitador);
                        tipo_compra tipo_compra = new tipo_compra();
                        tipo_compra = ControladorTipo_Compra.Instance.findnombrenyid((int)compra.Idtipocompra);

                        proovedor proovedor = new proovedor();
                        proovedor = ControladorProveedor.Instance.findnombrenyid((int)compra.Idproovedor);
                        //buscar el role por medio del idrole antes de ingresarlo
                        dgreportecompras.Rows.Add(compra.Nombre_compra, tipo_compra.Nombretipocompra, proovedor.Nombre_empresa, compra.Total, fechasinhora[0]);
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
                double isv = 0;
                double subtotal = 0;
                for (int x = 0; x < dgreportecompras.Rows.Count; ++x)
                {
                    total += Convert.ToInt32(dgreportecompras.Rows[x].Cells["Total"].Value);
                    txttotal.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                    subtotal = (total / 1.15);
                    isv = (subtotal * 0.15);
                    txtsubtotal.Text = String.Format(" L " + "{0:n}", subtotal.ToString("N", new CultureInfo("en-US")));
                    txtisv.Text = String.Format(" L " + "{0:n}", isv.ToString("N", new CultureInfo("en-US")));
                }
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            Exportarexcel(dgreportecompras);
        }

        private void Exportarexcel(DataGridView dg)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);



            excel.Range["A1:Z100"].Cells.Font.Name = "Bookman Old Style";
            //excel.Range[excel.Cells[X, Y], excel.Cells[X, Y]].Merge();

            excel.Range["A1:F1"].Cells.Font.Size = 24;
            excel.Range["A1:F1"].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            if (cbBcompras.SelectedItem.ToString() == "Desde - Hasta")
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
            excel.Range["A1:F1"].Value = "Reporte de Compras - [" + cbBcompras.Text.ToString() + "]";

            
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
                    excel.Cells[IndiceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }
            }
            excel.Columns.AutoFit();
            excel.Visible = true;
        }


        private static ReporteComprasVista fmrReporteComprasVista = null;
        internal static ReporteComprasVista Abrir1vez()
        {
            if (((fmrReporteComprasVista == null) || (fmrReporteComprasVista.IsDisposed == true)))
            {
                fmrReporteComprasVista = new ReporteComprasVista();
            }
            fmrReporteComprasVista.BringToFront();
            return fmrReporteComprasVista;
        }
    }



    }

