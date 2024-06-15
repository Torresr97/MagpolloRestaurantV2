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
using AppTRchicken.Utilidades;

namespace AppTRchicken.Vista
{
    public partial class ReporteVentasxCategoriaVista : Form
    {
        public ReporteVentasxCategoriaVista()
        {
            InitializeComponent();
        }

        private void ReporteVentasxCategoria_Load(object sender, EventArgs e)
        {
            int height = this.Height;
            int width = this.Width;
           


            int altura = dgreportexproducto.Location.Y;
            btntodos.Location = new Point((width - (btntodos.Width)- btnexportar.Width - 20), (altura - btntodos.Height - 5));

          
            btnexportar.Location = new Point((width - btnexportar.Width - 20), (altura - btnexportar.Height - 5));





            dtpmesyano.Visible = false;
            dthasta.Visible = false;

            btnBuscar.Visible = false;
           
            cbproducto.DataSource = ControladorMenu.Instance.Cargarcomboxmenu();
            cbproducto.DisplayMember = "nombrecombo";
            cbproducto.ValueMember = "idmenu";
        }

        private void Limpiar(){
            txtcantidad.Text = "";
            txttotal.Text = "";
        }
        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscar.SelectedItem.ToString() == "Dia")
            {
                Limpiar();
                dgreportexproducto.Rows.Clear();
                btnBuscar.Visible = true;
              
                btnBuscar.Location = new Point(540, 57);
              
                dtpmesyano.Visible = true;
                dthasta.Visible = false;

            }
            else if (cbBuscar.SelectedItem.ToString() == "Mes")
            {
                Limpiar();
                dgreportexproducto.Rows.Clear();
                btnBuscar.Visible = true;
               
                btnBuscar.Location = new Point(540, 57);
              
                dtpmesyano.Visible = true;
                dthasta.Visible = false;

            }
            else if (cbBuscar.SelectedItem.ToString() == "Año")
            {
                Limpiar();
                dgreportexproducto.Rows.Clear();
                btnBuscar.Visible = true;
               
                btnBuscar.Location = new Point(540, 57);
               
                dtpmesyano.Visible = true;
                dthasta.Visible = false;

            }
            else if (cbBuscar.SelectedItem.ToString() == "Desde - Hasta")
            {
                Limpiar();
                dgreportexproducto.Rows.Clear();
                btnBuscar.Visible = true;
               
                btnBuscar.Location = new Point(540, 57);
              
                dtpmesyano.Visible = true;
                dthasta.Visible = true;


            }

        }

        private void cbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    // Cerrar el formulario de carga
                    cargandoForm.Close();
                });
            }
            else
            {
                // Si ya estamos en el hilo de la interfaz de usuario, cerrar el formulario directamente
                cargandoForm.Close();
            }
        }


        private string GetCbxcbproductoText()
        {
            if (cbproducto.InvokeRequired)
            {
                return (string)cbproducto.Invoke((Func<string>)GetCbxcbproductoText);
            }
            else
            {
                return cbproducto.Text;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool columnaPresente = false;
            foreach (DataGridViewColumn column in dgreportexproducto.Columns)
            {
                if (column.Name == "fecha")
                {
                    columnaPresente = true;
                    break;
                }
            }

            // Si la columna "fecha" no está presente, la agregamos
            if (!columnaPresente)
            {
                dgreportexproducto.Columns.Add("fecha", "Fecha");
                dgreportexproducto.Columns["fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (cbBuscar.SelectedItem.ToString() == "Dia")
            {
                int tiempoDeseado = 600000;
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);

                try
                {
                    List<string> lmenu = new List<string>();
                    List<string> ldetalle = new List<string>();
                    List<string> ldetallel = new List<string>();
                    List<string> lfactura = new List<string>();

                    dgreportexproducto.Rows.Clear();
                    List<facturas> fac = new List<facturas>();
                    fac = ControladorFacturas.Instance.finreportexproductodia(cbproducto.Text, dtpmesyano.Value.ToString("yyyy-MM-dd"));

                    List<menu> m = new List<menu>();
                    m = ControladorMenu.Instance.finreportexproductodia(cbproducto.Text, dtpmesyano.Value.ToString("yyyy-MM-dd"));
                    List<detalle_factura> detallef = new List<detalle_factura>();
                    detallef = ControladorDetalle_Factura.Instance.finreportexproductodia(cbproducto.Text, dtpmesyano.Value.ToString("yyyy-MM-dd"));




                    foreach (menu men in m)
                    {

                        lmenu.Add(men.Nombrecombo);
                    }


                    foreach (detalle_factura df in detallef)
                    {

                        ldetalle.Add(df.Cantidad.ToString());
                    }

                    foreach (detalle_factura df in detallef)
                    {

                        ldetallel.Add(df.Total.ToString());
                    }

                    foreach (facturas f in fac)
                    {
                        char delimitador = ' ';
                        string[] fechasinhora = f.Fecha.Split(delimitador);
                        lfactura.Add(fechasinhora[0]);
                    }


                    for (int y = 0; y < lmenu.Count; y++)
                    {
                        dgreportexproducto.Rows.Add(lmenu[y], ldetalle[y], ldetallel[y], lfactura[y]);
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
                int cantidad = 0;
                for (int x = 0; x < dgreportexproducto.Rows.Count; ++x)
                {



                    total += Convert.ToInt32(dgreportexproducto.Rows[x].Cells["Total"].Value);
                    txttotal.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                    cantidad += Convert.ToInt32(dgreportexproducto.Rows[x].Cells["Cantidad"].Value);
                    txtcantidad.Text = cantidad.ToString();


                }

            }
            if (cbBuscar.SelectedItem.ToString() == "Mes")
            {
                int tiempoDeseado = 600000;
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);


                try
                {
                    List<string> lmenu = new List<string>();
                    List<string> ldetalle = new List<string>();
                    List<string> ldetallel = new List<string>();
                    List<string> lfactura = new List<string>();

                    dgreportexproducto.Rows.Clear();
                    List<facturas> fac = new List<facturas>();
                    fac = ControladorFacturas.Instance.finreportexproductomes(cbproducto.Text, dtpmesyano.Value.Month.ToString());

                    List<menu> m = new List<menu>();
                    m = ControladorMenu.Instance.finreportexproductomes(cbproducto.Text, dtpmesyano.Value.Month.ToString());
                    List<detalle_factura> detallef = new List<detalle_factura>();
                    detallef = ControladorDetalle_Factura.Instance.finreportexproductomes(cbproducto.Text, dtpmesyano.Value.Month.ToString());




                    foreach (menu men in m)
                    {

                        lmenu.Add(men.Nombrecombo);
                    }


                    foreach (detalle_factura df in detallef)
                    {

                        ldetalle.Add(df.Cantidad.ToString());
                    }

                    foreach (detalle_factura df in detallef)
                    {

                        ldetallel.Add(df.Total.ToString());
                    }

                    foreach (facturas f in fac)
                    {
                        char delimitador = ' ';
                        string[] fechasinhora = f.Fecha.Split(delimitador);
                        lfactura.Add(fechasinhora[0]);
                    }


                    for (int y = 0; y < lmenu.Count; y++)
                    {
                        dgreportexproducto.Rows.Add(lmenu[y], ldetalle[y], ldetallel[y], lfactura[y]);
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
                int cantidad = 0;
                for (int x = 0; x < dgreportexproducto.Rows.Count; ++x)
                {



                    total += Convert.ToInt32(dgreportexproducto.Rows[x].Cells["Total"].Value);
                    txttotal.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                    cantidad += Convert.ToInt32(dgreportexproducto.Rows[x].Cells["Cantidad"].Value);
                    txtcantidad.Text = cantidad.ToString();


                }

            }
            if (cbBuscar.SelectedItem.ToString() == "Año")
            {
                int tiempoDeseado = 600000;
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);


                try
                {

                    List<string> lmenu = new List<string>();
                    List<string> ldetalle = new List<string>();
                    List<string> ldetallel = new List<string>();
                    List<string> lfactura = new List<string>();

                    dgreportexproducto.Rows.Clear();
                    List<facturas> fac = new List<facturas>();
                    fac = ControladorFacturas.Instance.finreportexproductoano(cbproducto.Text, dtpmesyano.Value.Year.ToString());

                    List<menu> m = new List<menu>();
                    m = ControladorMenu.Instance.finreportexproductoano(cbproducto.Text, dtpmesyano.Value.Year.ToString());
                    List<detalle_factura> detallef = new List<detalle_factura>();
                    detallef = ControladorDetalle_Factura.Instance.finreportexproductoano(cbproducto.Text, dtpmesyano.Value.Year.ToString());




                    foreach (menu men in m)
                    {

                        lmenu.Add(men.Nombrecombo);
                    }


                    foreach (detalle_factura df in detallef)
                    {

                        ldetalle.Add(df.Cantidad.ToString());
                    }

                    foreach (detalle_factura df in detallef)
                    {

                        ldetallel.Add(df.Total.ToString());
                    }

                    foreach (facturas f in fac)
                    {
                        char delimitador = ' ';
                        string[] fechasinhora = f.Fecha.Split(delimitador);
                        lfactura.Add(fechasinhora[0]);
                    }


                    for (int y = 0; y < lmenu.Count; y++)
                    {
                        dgreportexproducto.Rows.Add(lmenu[y], ldetalle[y], ldetallel[y], lfactura[y]);
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
                int cantidad = 0;
                for (int x = 0; x < dgreportexproducto.Rows.Count; ++x)
                {



                    total += Convert.ToInt32(dgreportexproducto.Rows[x].Cells["Total"].Value);
                    txttotal.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                    cantidad += Convert.ToInt32(dgreportexproducto.Rows[x].Cells["Cantidad"].Value);
                    txtcantidad.Text = cantidad.ToString();


                }

            }
            if (cbBuscar.SelectedItem.ToString() == "Desde - Hasta")
            {
                int tiempoDeseado = 600000;
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);


                try
                {
                    List<string> lmenu = new List<string>();
                    List<string> ldetalle = new List<string>();
                    List<string> ldetallel = new List<string>();
                    List<string> lfactura = new List<string>();

                    dgreportexproducto.Rows.Clear();
                    List<facturas> fac = new List<facturas>();
                    fac = ControladorFacturas.Instance.finreportexproductodesdehasta(cbproducto.Text, dtpmesyano.Value.ToString("yyyy-MM-dd"), dthasta.Value.ToString("yyyy-MM-dd"));

                    List<menu> m = new List<menu>();
                    m = ControladorMenu.Instance.finreportexproductodesdehasta(cbproducto.Text, dtpmesyano.Value.ToString("yyyy-MM-dd"), dthasta.Value.ToString("yyyy-MM-dd"));
                    List<detalle_factura> detallef = new List<detalle_factura>();
                    detallef = ControladorDetalle_Factura.Instance.finreportexproductodesdehasta(cbproducto.Text, dtpmesyano.Value.ToString("yyyy-MM-dd"), dthasta.Value.ToString("yyyy-MM-dd"));




                    foreach (menu men in m)
                    {

                        lmenu.Add(men.Nombrecombo);
                    }


                    foreach (detalle_factura df in detallef)
                    {

                        ldetalle.Add(df.Cantidad.ToString());
                    }

                    foreach (detalle_factura df in detallef)
                    {

                        ldetallel.Add(df.Total.ToString());
                    }

                    foreach (facturas f in fac)
                    {
                        char delimitador = ' ';
                        string[] fechasinhora = f.Fecha.Split(delimitador);
                        lfactura.Add(fechasinhora[0]);
                    }


                    for (int y = 0; y < lmenu.Count; y++)
                    {
                        dgreportexproducto.Rows.Add(lmenu[y], ldetalle[y], ldetallel[y], lfactura[y]);
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
                int cantidad = 0;
                for (int x = 0; x < dgreportexproducto.Rows.Count; ++x)
                {



                    total += Convert.ToInt32(dgreportexproducto.Rows[x].Cells["Total"].Value);
                    txttotal.Text = String.Format(" L " + "{0:n}", total.ToString("N", new CultureInfo("en-US")));
                    cantidad += Convert.ToInt32(dgreportexproducto.Rows[x].Cells["Cantidad"].Value);
                    txtcantidad.Text = cantidad.ToString();


                }
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            Exportarexcel(dgreportexproducto);
        }

        private void Exportarexcel(DataGridView dg)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);



            excel.Range["A1:Z100"].Cells.Font.Name = "Bookman Old Style";
            //excel.Range[excel.Cells[X, Y], excel.Cells[X, Y]].Merge();

            excel.Range["A1:F1"].Cells.Font.Size = 24;
            excel.Range["A1:F1"].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            if (cbBuscar.SelectedItem.ToString() == "Desde - Hasta")
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
            excel.Range["A1:F1"].Value = "Reporte de Ventas x Productos - [" + cbBuscar.Text.ToString() + "]";

            excel.Cells[5, "A"].Value = "Cantidad:";
            excel.Cells[5, "B"].Value = txtcantidad.Text;
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

        private void btntodos_Click(object sender, EventArgs e)
        {

            Limpiar();

            // Verificar si la columna "fecha" está presente
            DataGridViewColumn columnaFecha = null;
            foreach (DataGridViewColumn column in dgreportexproducto.Columns)
            {
                if (column.Name == "fecha")
                {
                    columnaFecha = column;
                    break;
                }
            }

            // Si la columna "fecha" está presente, la eliminamos
            if (columnaFecha != null)
            {
                dgreportexproducto.Columns.Remove(columnaFecha);
            }

            if (cbBuscar.Text != "")
            {

                int tiempoDeseado = 600000;
                Task<CargandoVista> mostrarFormularioTask = MostrarFormularioCarga(tiempoDeseado);

                dgreportexproducto.Rows.Clear();
                try
                {
                    string query = "";
                    string strcon = Conexion.ObtenerConnectionString();
                    SqlConnection conexion = new SqlConnection(strcon);


                    if (cbBuscar.Text == "Dia")
                    {
                        query = $"SELECT nombrecombo + ' ' + complementos AS nombre_completo, SUM(cantidad) AS cantidad, SUM(total) AS total " +
                                $"FROM [{Globales.basedatos}].[dbo].[V_Reportexproducto] " +
                                $"WHERE fecha = '{dtpmesyano.Value.ToString("yyyy-MM-dd")}' " +
                                $"GROUP BY nombrecombo, complementos " +
                                $"ORDER BY nombre_completo";
                    }
                    else if (cbBuscar.Text == "Mes")
                    {
                        query = $"SELECT nombrecombo + ' ' + complementos AS nombre_completo, SUM(cantidad) AS cantidad, SUM(total) AS total " +
                                $"FROM [{Globales.basedatos}].[dbo].[V_Reportexproducto] " +
                                $"WHERE MONTH(fecha) = '{dtpmesyano.Value.Month}' " +
                                $"GROUP BY nombrecombo, complementos " +
                                $"ORDER BY nombre_completo";
                    }
                    else if (cbBuscar.Text == "Año")
                    {
                        query = $"SELECT nombrecombo + ' ' + complementos AS nombre_completo, SUM(cantidad) AS cantidad, SUM(total) AS total " +
                                $"FROM [{Globales.basedatos}].[dbo].[V_Reportexproducto] " +
                                $"WHERE YEAR(fecha) = '{dtpmesyano.Value.Year}' " +
                                $"GROUP BY nombrecombo, complementos " +
                                $"ORDER BY nombre_completo";
                    }
                    else if (cbBuscar.Text == "Desde - Hasta")
                    {
                        query = $"SELECT nombrecombo + ' ' + complementos AS nombre_completo, SUM(cantidad) AS cantidad, SUM(total) AS total " +
                                $"FROM [{Globales.basedatos}].[dbo].[V_Reportexproducto] " +
                                $"WHERE fecha BETWEEN '{dtpmesyano.Value.ToString("yyyy-MM-dd")}' AND '{dthasta.Value.ToString("yyyy-MM-dd")}' " +
                                $"GROUP BY nombrecombo, complementos " +
                                $"ORDER BY nombre_completo";
                    }




                    SqlCommand cmd = new SqlCommand(query, conexion);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable ds = new DataTable();
                    da.Fill(ds);

                    foreach (DataRow dr in ds.Rows)
                    {
                        // Crear una nueva fila para el DataGridView
                        DataGridViewRow row = new DataGridViewRow();

                        // Crear y agregar las celdas a la fila
                        DataGridViewCell cell1 = new DataGridViewTextBoxCell();
                        cell1.Value = dr["nombre_completo"]; // Obtener el valor de la columna nombre_completo
                        row.Cells.Add(cell1);

                        DataGridViewCell cell2 = new DataGridViewTextBoxCell();
                        cell2.Value = dr["cantidad"]; // Obtener el valor de la columna cantidad
                        row.Cells.Add(cell2);

                        DataGridViewCell cell3 = new DataGridViewTextBoxCell();
                        cell3.Value = dr["total"]; // Obtener el valor de la columna total
                        row.Cells.Add(cell3);

                        // Agregar la fila al DataGridView
                        dgreportexproducto.Rows.Add(row);
                    }


                    conexion.Close();


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
            else
            {

                MessageBox.Show("Para poder Ver Reporte de todos los Productos. Es Necesario Seleccionar una opcion en: Buscar Por");

            }
           
        }

        private static ReporteVentasxCategoriaVista fmrReporteVentasxCategoriaVista = null;
        internal static ReporteVentasxCategoriaVista Abrir1vez()
        {
            if (((fmrReporteVentasxCategoriaVista == null) || (fmrReporteVentasxCategoriaVista.IsDisposed == true)))
            {
                fmrReporteVentasxCategoriaVista = new ReporteVentasxCategoriaVista();
            }
            fmrReporteVentasxCategoriaVista.BringToFront();
            return fmrReporteVentasxCategoriaVista;
        }
    }
    }

