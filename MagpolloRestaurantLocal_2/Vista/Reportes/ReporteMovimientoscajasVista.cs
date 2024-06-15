using AppTRchicken.Controlador;
using AppTRchicken.Modelo;
using AppTRchicken.Reportes;
using AppTRchicken.Utilidades;
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

namespace AppTRchicken.Vista.Reportes
{
    public partial class ReporteMovimientoscajasVista : Form
    {
        public ReporteMovimientoscajasVista()
        {
            InitializeComponent();
        }

        private static ReporteMovimientoscajasVista fmrReporteMovimientoscajas = null;
        internal static ReporteMovimientoscajasVista Abrir1vez()
        {
            if (((fmrReporteMovimientoscajas == null) || (fmrReporteMovimientoscajas.IsDisposed == true)))
            {
                fmrReporteMovimientoscajas = new ReporteMovimientoscajasVista();
            }
            fmrReporteMovimientoscajas.BringToFront();
            return fmrReporteMovimientoscajas;
        }

        public void limpiartxt()
        {
            txtefectivo.Text = "";
            txttarjeta.Text = "";
            txttotal.Text = "";
        }

        private void ReporteMovimientoscajas_Load(object sender, EventArgs e)
        {
            dtpmesyano.Visible = false;
            dthasta.Visible = false;

            btnBuscar.Visible = false;


            int height = this.Height;
            int width = this.Width;
            int altura = dgreportemovimientoscaja.Location.Y;
            btnexportar.Location = new Point((width - btnexportar.Width - 20), (altura - btnexportar.Height - 5));
        }

        private void cbBventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBventas.SelectedItem.ToString() == "Dia")
            {
                dgreportemovimientoscaja.Rows.Clear();
                btnBuscar.Visible = true;
                btnBuscar.Location = new Point(455, 18);
                dtpmesyano.Visible = true;
                dthasta.Visible = false;

            }
            else if (cbBventas.SelectedItem.ToString() == "Mes")
            {
                dgreportemovimientoscaja.Rows.Clear();
                btnBuscar.Visible = true;
                btnBuscar.Location = new Point(455, 18);
                dtpmesyano.Visible = true;
                dthasta.Visible = false;

            }
            else if (cbBventas.SelectedItem.ToString() == "Año")
            {
                dgreportemovimientoscaja.Rows.Clear();
                btnBuscar.Visible = true;
                btnBuscar.Location = new Point(455, 18);
                dtpmesyano.Visible = true;
                dthasta.Visible = false;

            }
            else if (cbBventas.SelectedItem.ToString() == "Desde - Hasta")
            {
                dgreportemovimientoscaja.Rows.Clear();
                btnBuscar.Visible = true;
                btnBuscar.Location = new Point(655, 18);
                dtpmesyano.Visible = true;
                dthasta.Visible = true;


            }


        }
        private string GetcbxmovimientosText()
        {
            if (cbxmovimientos.InvokeRequired)
            {
                return (string)cbxmovimientos.Invoke((Func<string>)GetcbxmovimientosText);
            }
            else
            {
                return cbxmovimientos.Text;
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


        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (cbBventas.SelectedItem.ToString() == "Dia")
            {
                int tiempoDeseado = 600000; // Por ejemplo, 5 segundos
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);


                try
                {
                    dgreportemovimientoscaja.Rows.Clear();
                    List<caja> cj = new List<caja>();
                    cj = ControladorCaja.Instance.ReportemovimientosDia(cbxmovimientos.Text, dtpmesyano.Value.ToString("yyyy-MM-dd"));


                    foreach (caja caja in cj)
                    {


                        if (cbxmovimientos.Text == "Deposito")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo,caja.Motivo, caja.Totalefectivo, caja.Totaltarjeta, caja.Ventatotal, caja.Fecha);
                            double total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Deposito")
                                {
                                    total += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value);
                                }

                                txtefectivo.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                            }
                        }
                        if (cbxmovimientos.Text == "Retiro")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo, caja.Totaltarjeta, caja.Ventatotal, caja.Fecha);
                            double total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Retiro")
                                {
                                    total += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value);
                                }

                                txtefectivo.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                            }
                        }
                        if (cbxmovimientos.Text == "Cierre de Caja")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo, caja.Totaltarjeta, caja.Ventatotal, caja.Fecha);
                            double totalefectivo = 0;
                            double totaltarejta = 0;
                            double total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Cierre de Caja")
                                {
                                    totalefectivo += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value);
                                    totaltarejta += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Tarjeta"].Value);
                                    total += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Total"].Value);
                                }

                                txtefectivo.Text = String.Format(" L " + "{0:n}", totalefectivo.ToString("N", new CultureInfo("en-US")));
                                txttarjeta.Text = String.Format(" L " + "{0:n}", totaltarejta.ToString("N", new CultureInfo("en-US")));
                                txttotal.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                            }
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



            }
            if (cbBventas.SelectedItem.ToString() == "Mes")
            {
                int tiempoDeseado = 600000; // Por ejemplo, 5 segundos
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);


                try
                {
                    dgreportemovimientoscaja.Rows.Clear();
                    List<caja> cj = new List<caja>();
                    cj = ControladorCaja.Instance.ReportemovimientosMes(cbxmovimientos.Text, dtpmesyano.Value.Month.ToString(), dthasta.Value.Year.ToString());


                    foreach (caja caja in cj)
                    {


                        if (cbxmovimientos.Text == "Deposito")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo, caja.Totaltarjeta, caja.Ventatotal, caja.Fecha);
                            double total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Deposito")
                                {
                                    total += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value);
                                }

                                txtefectivo.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                            }
                        }
                        if (cbxmovimientos.Text == "Retiro")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo, caja.Totaltarjeta, caja.Ventatotal, caja.Fecha);
                            double total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Retiro")
                                {
                                    total += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value);
                                }

                                txtefectivo.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                            }
                        }
                        if (cbxmovimientos.Text == "Cierre de Caja")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo, caja.Totaltarjeta, caja.Ventatotal, caja.Fecha);
                            double totalefectivo = 0;
                            double totaltarejta = 0;
                            double total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Cierre de Caja")
                                {
                                    totalefectivo += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value);
                                    totaltarejta += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Tarjeta"].Value);
                                    total += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Total"].Value);
                                }

                                txtefectivo.Text = String.Format(" L " + "{0:n}", totalefectivo.ToString("N", new CultureInfo("en-US")));
                                txttarjeta.Text = String.Format(" L " + "{0:n}", totaltarejta.ToString("N", new CultureInfo("en-US")));
                                txttotal.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                            }
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

            }
            if (cbBventas.SelectedItem.ToString() == "Año")
            {
                int tiempoDeseado = 600000; // Por ejemplo, 5 segundos
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);


                try
                {
                    dgreportemovimientoscaja.Rows.Clear();
                    List<caja> cj = new List<caja>();
                    cj = ControladorCaja.Instance.ReportemovimientosAno(cbxmovimientos.Text, dtpmesyano.Value.Year.ToString());


                    foreach (caja caja in cj)
                    {


                        if (cbxmovimientos.Text == "Deposito")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo, caja.Totaltarjeta, caja.Ventatotal, caja.Fecha);
                            double total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Deposito")
                                {
                                    total += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value);
                                }

                                txtefectivo.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                            }
                        }
                        if (cbxmovimientos.Text == "Retiro")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo, caja.Totaltarjeta, caja.Ventatotal, caja.Fecha);
                            double total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Retiro")
                                {
                                    total += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value);
                                }

                                txtefectivo.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                            }
                        }
                        if (cbxmovimientos.Text == "Cierre de Caja")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo, caja.Totaltarjeta, caja.Ventatotal, caja.Fecha);
                            double totalefectivo = 0;
                            double totaltarejta = 0;
                            double total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Cierre de Caja")
                                {
                                    totalefectivo += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value);
                                    totaltarejta += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Tarjeta"].Value);
                                    total += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Total"].Value);
                                }

                                txtefectivo.Text = String.Format(" L " + "{0:n}", totalefectivo.ToString("N", new CultureInfo("en-US")));
                                txttarjeta.Text = String.Format(" L " + "{0:n}", totaltarejta.ToString("N", new CultureInfo("en-US")));
                                txttotal.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                            }
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
            }
            if (cbBventas.SelectedItem.ToString() == "Desde - Hasta")
            {
                int tiempoDeseado = 600000; // Por ejemplo, 5 segundos
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);


                try
                {
                    dgreportemovimientoscaja.Rows.Clear();
                    List<caja> cj = new List<caja>();
                    cj = ControladorCaja.Instance.ReportemovimientosDesdeHasta(cbxmovimientos.Text, dtpmesyano.Value.ToString("yyyy-MM-dd"), dthasta.Value.ToString("yyyy-MM-dd"));


                    foreach (caja caja in cj)
                    {


                        if (cbxmovimientos.Text == "Deposito")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo, caja.Totaltarjeta, caja.Ventatotal, caja.Fecha);
                            double total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Deposito")
                                {
                                    total += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value);
                                }

                                txtefectivo.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                            }
                        }
                        if (cbxmovimientos.Text == "Retiro")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo, caja.Totaltarjeta, caja.Ventatotal, caja.Fecha);
                            double total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Retiro")
                                {
                                    total += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value);
                                }

                                txtefectivo.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                            }
                        }
                        if (cbxmovimientos.Text == "Cierre de Caja")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo, caja.Totaltarjeta, caja.Ventatotal, caja.Fecha);
                            double totalefectivo = 0;
                            double totaltarejta = 0;
                            double total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Cierre de Caja")
                                {
                                    totalefectivo += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value);
                                    totaltarejta += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Tarjeta"].Value);
                                    total += Convert.ToDouble(dgreportemovimientoscaja.Rows[x].Cells["Total"].Value);
                                }

                                txtefectivo.Text = String.Format(" L " + "{0:n}", totalefectivo.ToString("N", new CultureInfo("en-US")));
                                txttarjeta.Text = String.Format(" L " + "{0:n}", totaltarejta.ToString("N", new CultureInfo("en-US")));
                                txttotal.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                            }
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

            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            Exportarexcel(dgreportemovimientoscaja);
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
            excel.Range["A1:F1"].Value = "Reporte Movimientos de Caja - [" + cbBventas.Text.ToString() + "]";

            excel.Cells[4, "A"].Value = "Efectivo:";
            excel.Cells[4, "B"].Value = txtefectivo.Text;
            excel.Cells[5, "A"].Value = "Tarjeta:";
            excel.Cells[5, "B"].Value = txttarjeta.Text;
            excel.Cells[6, "A"].Value = "Total:";
            excel.Cells[6, "B"].Value = txttotal.Text;
           





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

    }
}
