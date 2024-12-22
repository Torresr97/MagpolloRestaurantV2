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
            txttransferencia.Text = "";
            txttotal.Text = "";
        }

        private void ReporteMovimientoscajas_Load(object sender, EventArgs e)
        {// Obtener el rol del usuario
            roles rolUsuario = ControladorRoles.Instance.findrolebynombreusuario(Globales.nombreusuario);

            // Si el usuario no es cajero, cargar facturas y calcular ventas
            if (rolUsuario.Roles == "cajero")
            {
                if (dgreportemovimientoscaja.Columns.Count > 8)  // Asegurarse de que la columna existe
                {
                    dgreportemovimientoscaja.Columns.RemoveAt(8);
                }
            }

            dtpmesyano.Visible = false;
            dthasta.Visible = false;

            btnBuscar.Visible = false;


            int height = this.Height;
            int width = this.Width;
            int altura = dgreportemovimientoscaja.Location.Y;
            btnexportar.Location = new Point((width - btnexportar.Width - 20), (altura - btnexportar.Height - 5));
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

        private void btnBuscar_Click_1(object sender, EventArgs e)
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
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo.ToString("N2", CultureInfo.InvariantCulture), caja.Totaltarjeta.ToString("N2", CultureInfo.InvariantCulture), caja.Totaltransferencia.ToString("N2", CultureInfo.InvariantCulture), caja.Ventatotal.ToString("N2", CultureInfo.InvariantCulture), caja.Fecha.ToString());
                            decimal total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Deposito")
                                {
                                    total += Globales.ConvertToDecimal(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value.ToString());
                                }

                                txtefectivo.Text = total.ToString("N2", CultureInfo.InvariantCulture);
                            }
                        }
                        if (cbxmovimientos.Text == "Retiro")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo.ToString("N2", CultureInfo.InvariantCulture), caja.Totaltarjeta.ToString("N2", CultureInfo.InvariantCulture), caja.Totaltransferencia.ToString("N2", CultureInfo.InvariantCulture), caja.Ventatotal.ToString("N2", CultureInfo.InvariantCulture), caja.Fecha.ToString());
                            decimal total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Retiro")
                                {
                                    total += Globales.ConvertToDecimal(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value.ToString());
                                }

                                txtefectivo.Text = total.ToString("N2", CultureInfo.InvariantCulture);
                            }
                        }
                        if (cbxmovimientos.Text == "Cierre de Caja")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo.ToString("N2", CultureInfo.InvariantCulture), caja.Totaltarjeta.ToString("N2", CultureInfo.InvariantCulture), caja.Totaltransferencia.ToString("N2", CultureInfo.InvariantCulture), caja.Ventatotal.ToString("N2", CultureInfo.InvariantCulture), caja.Fecha.ToString());
                            decimal totalefectivo = 0;
                            decimal totaltarejta = 0;
                            decimal totaltransferencia = 0;
                            decimal total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Cierre de Caja")
                                {
                                    totalefectivo += Globales.ConvertToDecimal(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value.ToString());
                                    totaltarejta += Globales.ConvertToDecimal(dgreportemovimientoscaja.Rows[x].Cells["Tarjeta"].Value.ToString());
                                    totaltransferencia += Globales.ConvertToDecimal(dgreportemovimientoscaja.Rows[x].Cells["Transferencia"].Value.ToString());
                                    total += Globales.ConvertToDecimal(dgreportemovimientoscaja.Rows[x].Cells["Total"].Value.ToString());
                                }

                                txtefectivo.Text = totalefectivo.ToString("N2", CultureInfo.InvariantCulture);
                                txttarjeta.Text = totaltarejta.ToString("N2", CultureInfo.InvariantCulture);
                                txttransferencia.Text = totaltransferencia.ToString("N2", CultureInfo.InvariantCulture);
                                txttotal.Text = total.ToString("N2", CultureInfo.InvariantCulture);
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
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo.ToString("N2", CultureInfo.InvariantCulture), caja.Totaltarjeta.ToString("N2", CultureInfo.InvariantCulture), caja.Totaltransferencia.ToString("N2", CultureInfo.InvariantCulture), caja.Ventatotal.ToString("N2", CultureInfo.InvariantCulture), caja.Fecha.ToString());
                            decimal total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Deposito")
                                {
                                    total += Globales.ConvertToDecimal(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value.ToString());
                                }

                                txtefectivo.Text = total.ToString("N2", CultureInfo.InvariantCulture);
                            }
                        }
                        if (cbxmovimientos.Text == "Retiro")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo.ToString("N2", CultureInfo.InvariantCulture), caja.Totaltarjeta.ToString("N2", CultureInfo.InvariantCulture), caja.Totaltransferencia.ToString("N2", CultureInfo.InvariantCulture), caja.Ventatotal.ToString("N2", CultureInfo.InvariantCulture), caja.Fecha.ToString());
                            decimal total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Retiro")
                                {
                                    total += Globales.ConvertToDecimal(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value.ToString());
                                }

                                txtefectivo.Text = total.ToString("N2", CultureInfo.InvariantCulture);
                            }
                        }
                        if (cbxmovimientos.Text == "Cierre de Caja")
                        {
                            limpiartxt();
                            dgreportemovimientoscaja.Rows.Add(caja.Idcaja, caja.Tipo, caja.Motivo, caja.Totalefectivo.ToString("N2", CultureInfo.InvariantCulture), caja.Totaltarjeta.ToString("N2", CultureInfo.InvariantCulture), caja.Totaltransferencia.ToString("N2", CultureInfo.InvariantCulture), caja.Ventatotal.ToString("N2", CultureInfo.InvariantCulture), caja.Fecha.ToString());
                            decimal totalefectivo = 0;
                            decimal totaltarejta = 0;
                            decimal totaltransferencia = 0;
                            decimal total = 0;

                            for (int x = 0; x < dgreportemovimientoscaja.Rows.Count; ++x)
                            {
                                if (dgreportemovimientoscaja.Rows[x].Cells["Tipo"].Value.ToString() == "Cierre de Caja")
                                {
                                    totalefectivo += Globales.ConvertToDecimal(dgreportemovimientoscaja.Rows[x].Cells["Efectivo"].Value.ToString());
                                    totaltarejta += Globales.ConvertToDecimal(dgreportemovimientoscaja.Rows[x].Cells["Tarjeta"].Value.ToString());
                                    totaltransferencia += Globales.ConvertToDecimal(dgreportemovimientoscaja.Rows[x].Cells["Transferencia"].Value.ToString());
                                    total += Globales.ConvertToDecimal(dgreportemovimientoscaja.Rows[x].Cells["Total"].Value.ToString());
                                }

                                txtefectivo.Text = totalefectivo.ToString("N2", CultureInfo.InvariantCulture);
                                txttarjeta.Text = totaltarejta.ToString("N2", CultureInfo.InvariantCulture);
                                txttransferencia.Text = totaltransferencia.ToString("N2", CultureInfo.InvariantCulture);
                                txttotal.Text = total.ToString("N2", CultureInfo.InvariantCulture);
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

        private void btnexportar_Click_1(object sender, EventArgs e)
        {
            Exportarexcel(dgreportemovimientoscaja);
        }

        private void dgreportemovimientoscaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)  //Dónde la columna con el botón es la 6 con posición 5
            {
                caja caja = new caja();
                caja.Idcaja = Convert.ToInt32(dgreportemovimientoscaja.Rows[dgreportemovimientoscaja.CurrentRow.Index].Cells[0].Value);
                try
                {


                    DialogResult result = MessageBox.Show("Esta Seguro de Eliminar este Movimiento de Caja?", "Eliminar Registro", MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            caja cajas = new caja();
                            cajas.Idcaja = Convert.ToInt32(dgreportemovimientoscaja.Rows[dgreportemovimientoscaja.CurrentRow.Index].Cells[0].Value);

                            ControladorCaja.Instance.delete(cajas);//Actualiza la factura a estado 0 


                            MessageBox.Show("Registro Eliminado");
                            // Elimina la fila del DataGridView
                            dgreportemovimientoscaja.Rows.RemoveAt(e.RowIndex);
                            break;
                        case DialogResult.No:
                            MessageBox.Show("Cancelado");
                            break;

                    }
                    //ControladorFacturas.Instance.delete(facturas);


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void cbBventas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbBventas.SelectedItem.ToString() == "Dia")
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
    }
}
