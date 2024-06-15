using AppTRchicken.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTRchicken.Controlador;
using AppTRchicken.Modelo;
using System.Globalization;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace AppTRchicken.Vista
{
   
    public partial class PagodePlanillaVista : Form
    {
        int iddeduccion = 0;
        int idingreso = 0;

        decimal sueldobase = 0;
        decimal otrosingresos = 0;
        decimal deducciones = 0;

        decimal totalingresos = 0;
        decimal totaldeducciones = 0;
        decimal totalpagar = 0;



        public PagodePlanillaVista()
        {
            InitializeComponent();
        }

        private void Cargarcbxempleado()
        {
            //cbempleados.DataSource = ControladorEmpleados.Instance.Cargarcomboxempleado();
            List<empleados> Empleados = new List<empleados>();
            Empleados = ControladorEmpleados.Instance.findAll();
            cbempleado.DataSource = Empleados;

            cbempleado.ValueMember = "nombreempleado";
            cbempleado.DisplayMember = "nombreempleado";





        }

        //private void cbempleado_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    CargardgIngresos();
        //    CargardgDeducciones();
        //    empleados empleados = new empleados();
        //    empleados = ControladorEmpleados.Instance.findidbynombre(cbempleado.Text);

        //    salarioadmin = empleados.Sueldoquincenal;
        //    txtsalarioadmin.Text = empleados.Sueldoquincenal.ToString("N", new CultureInfo("en-US"));
        //    Calcularsaldos();
        //}
        private void PagodePlanillaVista_Load(object sender, EventArgs e)
        {

            Cargarcbxempleado();

            int height = this.Height;
            int width = this.Width;

            int mitadheight = (height / 3);


            groupBox1.Size = new Size(width, (mitadheight));
            groupBox2.Size = new Size(width, (mitadheight));
            groupBox3.Size = new Size(width, (mitadheight));


            groupBox2.Location = new System.Drawing.Point(0, (groupBox1.Location.Y + groupBox1.Size.Height));
            groupBox3.Location = new System.Drawing.Point(0, ((groupBox2.Location.Y + 10) + groupBox2.Size.Height));



            dtperiododesde.Location = new System.Drawing.Point((width - dtperiododesde.Size.Width - 25), 13);
            dtperiodohasta.Location = new System.Drawing.Point((width - dtperiododesde.Size.Width - 25), (13 + dtperiododesde.Size.Height + 5));
            lbldesde.Location = new System.Drawing.Point((dtperiododesde.Location.X - lbldesde.Size.Width - 10), 13);
            lblhasta.Location = new System.Drawing.Point((dtperiodohasta.Location.X - lblhasta.Size.Width - 10), (13 + dtperiododesde.Size.Height + 5));


            /**************Colocar controles arriba de Dg ingreso**********************/

            int altura = dgingreso.Location.Y;
            lbingreso.Location = new System.Drawing.Point(0, (altura - 35));
            txtingreso.Location = new System.Drawing.Point((lbingreso.Size.Width), (altura - 40));
            lbtotalingreso.Location = new System.Drawing.Point((lbingreso.Size.Width + txtingreso.Size.Width), (altura - 35));
            txttotalingreso.Location = new System.Drawing.Point(lbingreso.Size.Width + txtingreso.Size.Width + lbtotalingreso.Size.Width, (altura - 40));
            btningresaringresos.Location = new System.Drawing.Point(lbingreso.Size.Width + txtingreso.Size.Width + lbtotalingreso.Size.Width + txttotalingreso.Size.Width + 10, (altura - 40));




            /**************Colocar controles arriba de Dg deducciones**********************/
            int alturadeddciones = dgdeduccionxempleado.Location.Y;
            lbldeduccion.Location = new System.Drawing.Point(0, (altura - 35));
            txtdeduccion.Location = new System.Drawing.Point((lbldeduccion.Size.Width), (altura - 40));
            lbltotaldeuccion.Location = new System.Drawing.Point((lbldeduccion.Size.Width + txtdeduccion.Size.Width), (altura - 35));
            txttotaldeduccion.Location = new System.Drawing.Point(lbldeduccion.Size.Width + txtdeduccion.Size.Width + lbltotaldeuccion.Size.Width, (altura - 40));
            btningresardeccion.Location = new System.Drawing.Point(lbldeduccion.Size.Width + txtdeduccion.Size.Width + lbltotaldeuccion.Size.Width + txttotaldeduccion.Size.Width + 10, (altura - 40));

        }
        private static PagodePlanillaVista fmrPagodePlanillaVista = null;
        internal static PagodePlanillaVista Abrir1vez()
        {
            if (((fmrPagodePlanillaVista == null) || (fmrPagodePlanillaVista.IsDisposed == true)))
            {
                fmrPagodePlanillaVista = new PagodePlanillaVista();
            }
            fmrPagodePlanillaVista.BringToFront();
            return fmrPagodePlanillaVista;
        }



        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtingreso.Text != "" || txttotalingreso.Text != "")
            {
                empleados empleados = new empleados();
                empleados = ControladorEmpleados.Instance.findidbynombre(cbempleado.Text);

                ingresosxempleados ingresosxempleados = new ingresosxempleados();
                ingresosxempleados.Idempleado = empleados.Idempleado;
                ingresosxempleados.Numeroplanilla = "";
                ingresosxempleados.Ingreso = txtingreso.Text;
                ingresosxempleados.Total = Convert.ToDouble(txttotalingreso.Text);
                ingresosxempleados.Fecha = DateTime.Now;
                ingresosxempleados.Estado = false;
                try
                {

                    Controladoringresosxempleado.Instance.save(ingresosxempleados);
                    MessageBox.Show("Ingreso Extra Agregado");
                    CargarDG();
                    Calcularsaldos();
                    txtingreso.Text = "";
                    txttotalingreso.Text = "";

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btningresardeccion_Click(object sender, EventArgs e)
        {

            if (txtdeduccion.Text != "" || txttotaldeduccion.Text != "")
            {
                empleados empleados = new empleados();
                empleados = ControladorEmpleados.Instance.findidbynombre(cbempleado.Text);

                Deduccionxempleados Deduccionxempleados = new Deduccionxempleados();
                Deduccionxempleados.Idempleado = empleados.Idempleado;
                Deduccionxempleados.Numeroplanilla = "";
                Deduccionxempleados.Deduccion = txtdeduccion.Text;
                Deduccionxempleados.Total = Convert.ToDouble(txttotaldeduccion.Text);
                Deduccionxempleados.Fecha = DateTime.Now;
                Deduccionxempleados.Estado = false;

                try
                {

                    Controladordeduccionesxempleado.Instance.save(Deduccionxempleados);
                    MessageBox.Show("Deduccion Agregada");
                    CargarDG();
                    Calcularsaldos();



                    txtdeduccion.Text = "";
                    txttotaldeduccion.Text = "";
                }


                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
            else
            {

                MessageBox.Show("Campo Deduccion o Total esta vacio");



            }
        }



      

        private void dgdeduccionxempleado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                iddeduccion = Convert.ToInt32(dgdeduccionxempleado.CurrentRow.Cells[0].Value.ToString());
                dgdeduccionxempleado.CurrentCell = dgdeduccionxempleado.Rows[e.RowIndex].Cells[e.ColumnIndex];

                ContextMenu cm = new ContextMenu();
                MenuItem mi = new MenuItem();
                mi.Text = "Eliminar Deduccion";
                mi.Click += EliminarD; //metodo al dar click
                cm.MenuItems.Add(mi);


                //Obtienes las coordenadas de la celda seleccionada. 
                System.Drawing.Rectangle coordenada = dgdeduccionxempleado.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                int anchoCelda = coordenada.Location.X; //Ancho de la localizacion de la celda
                int altoCelda = coordenada.Location.Y;  //Alto de la localizacion de la celda

                //Y para mostrar el menú lo haces de esta forma:  
                int X = anchoCelda;
                int Y = altoCelda;

                cm.Show(dgdeduccionxempleado, new Point(X, Y));


            }
        }

        private void EliminarD(Object sender, EventArgs e)
        {
            usuarios usuarios = new usuarios();
            usuarios = ControladorUsuario.Instance.findidbynombre(Globales.nombreusuario);
            Globales.idusuario = (int)usuarios.Idusuario;
            roles roles = new roles();
            roles = ControladorRoles.Instance.findrolebynombreusuario(Globales.nombreusuario);
            if (roles.Roles != "Admin")
            {
                MessageBox.Show("No tienes Suficientes Privilegios, Pide ayuda a tu Superior");

            }
            else
            {
                Deduccionxempleados Deduccionxempleados = new Deduccionxempleados();
                Deduccionxempleados.Iddeduccion = iddeduccion;
                Controladordeduccionesxempleado.Instance.delete(Deduccionxempleados);
                MessageBox.Show("Deduccion Eliminada");
              

            }

        }



      

        private void dgingreso_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                idingreso = Convert.ToInt32(dgingreso.CurrentRow.Cells[0].Value.ToString());
                dgingreso.CurrentCell = dgingreso.Rows[e.RowIndex].Cells[e.ColumnIndex];

                ContextMenu cm = new ContextMenu();
                MenuItem mi = new MenuItem();
                mi.Text = "Eliminar Ingreso";
                mi.Click += EliminarI; //metodo al dar click
                cm.MenuItems.Add(mi);


                //Obtienes las coordenadas de la celda seleccionada. 
                System.Drawing.Rectangle coordenada = dgingreso.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                int anchoCelda = coordenada.Location.X; //Ancho de la localizacion de la celda
                int altoCelda = coordenada.Location.Y;  //Alto de la localizacion de la celda

                //Y para mostrar el menú lo haces de esta forma:  
                int X = anchoCelda;
                int Y = altoCelda;

                cm.Show(dgingreso, new Point(X, Y));


            }
        }


        private void EliminarI(Object sender, EventArgs e)
        {
            usuarios usuarios = new usuarios();
            usuarios = ControladorUsuario.Instance.findidbynombre(Globales.nombreusuario);
            Globales.idusuario = (int)usuarios.Idusuario;
            roles roles = new roles();
            roles = ControladorRoles.Instance.findrolebynombreusuario(Globales.nombreusuario);
            if (roles.Roles != "Admin")
            {
                MessageBox.Show("No tienes Suficientes Privilegios, Pide ayuda a tu Superior");

            }
            else
            {
                ingresosxempleados ingresosxempleados = new ingresosxempleados();
                ingresosxempleados.Idingreso = idingreso;
                Controladoringresosxempleado.Instance.delete(ingresosxempleados);
                MessageBox.Show("Ingreso Eliminado");
              

            }

        }


        private void Calcularsaldos()
        {



            totalingresos = (sueldobase + otrosingresos);
            txttotaldeingresos.Text = totalingresos.ToString("N", new CultureInfo("en-US"));

            totaldeducciones = deducciones;
            txttotaldededucciones.Text = totaldeducciones.ToString("N", new CultureInfo("en-US"));

            totalpagar = (totalingresos - totaldeducciones);
            txttotalpagar.Text = totalpagar.ToString("N", new CultureInfo("en-US"));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //decimal totaldeingresos = 0;
            //decimal totaldededucciones = 0;
            //decimal totalapagar = 0;
            //decimal salarioadmin = 0;
            //decimal otrosingresos = 0;
            //decimal totaldeducciones = 0;


            /****************************Aqui llamamos los modelos para hacer consultas************************************/
            empleados empleados = new empleados();
            empleados = ControladorEmpleados.Instance.findidbynombre(cbempleado.Text.ToString());


            
            List<ingresosxempleados> ingresosxempleados = new List<ingresosxempleados>();
            ingresosxempleados = Controladoringresosxempleado.Instance.findAllbyid(empleados.Idempleado);



            Planilla Planilla = new Planilla();
            Planilla.Idempleado = empleados.Idempleado;
            Planilla.Fechaemision = DateTime.Now;
            Planilla.Periododesde = dtperiododesde.Value;
            Planilla.Periodohasta = dtperiodohasta.Value;
            Planilla.Sueldobase = sueldobase;
            Planilla.Ingresoextra = otrosingresos;
            Planilla.Totaldeducciones = totaldeducciones;
            Planilla.Totalapagar = totalpagar;



            sucursales sucursales = new sucursales();
            sucursales = ControladorSucursal.Instance.find();
           



            try
            {

                ControladorPlanilla.Instance.save(Planilla);
                MessageBox.Show("Planilla creada");
               


                string html = Properties.Resources.plantillacomprobantepago.ToString();
                /**********************Encabezado*****************************/
                html = html.Replace("@nombreempresa", sucursales.Nombresucursal);
                html = html.Replace("@fechadesde", dtperiododesde.Value.ToShortDateString());
                html = html.Replace("@fechahasta", dtperiodohasta.Value.ToShortDateString());



                /**********************informacion de empleado*****************************/
                html = html.Replace("@nombreempleado", cbempleado.Text);
                html = html.Replace("@sueldobase", txtsalarioadmin.Text);
                html = html.Replace("@identidad", empleados.Identidad);
                html = html.Replace("@fechaingreso", empleados.Fechaingreso.ToString("dd/MM/yyyy"));



                /**********************totales*****************************/
                html = html.Replace("@totalingreso", txttotaldeingresos.Text);
                html = html.Replace("@totaldeduccion", txttotaldededucciones.Text);
                html = html.Replace("@totalpagar", txttotalpagar.Text);


                /**********************ingresos*****************************/
                string ingresofilas = "";
                foreach (DataGridViewRow row in dgingreso.Rows)
                {
                    ingresofilas += "<tr>";
                    ingresofilas += "<td style='border: 0px solid #000;padding: 8px;text-align: left;'>" + row.Cells["ingreso"].Value.ToString() + "</td>";
                    ingresofilas += "<td style='border: 0px solid #000;padding: 8px;text-align: left;'>" + row.Cells["total"].Value.ToString() + "</td>";
                    ingresofilas += "</tr>";
                }
                html = html.Replace("@ingresofilas", ingresofilas);



                /**********************deducciones*****************************/
                string deduccionfilas = "";
                foreach (DataGridViewRow row in dgdeduccionxempleado.Rows)
                {
                    deduccionfilas += "<tr>";
                    deduccionfilas += "<td style='border: 0px solid #000;padding: 8px;text-align: left;'>" + row.Cells["Deduccion"].Value.ToString() + "</td>";
                    deduccionfilas += "<td style='border: 0px solid #000;padding: 8px;text-align: left;'>" + row.Cells["total2"].Value.ToString() + "</td>";
                    deduccionfilas += "</tr>";
                }
                html = html.Replace("@deducionfilas", deduccionfilas);

                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = (cbempleado.Text.ToString()+ DateTime.Now.ToString("ddMMyyyy")+ ".pdf");

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        // Establecer el tamaño de fuente global



                        Document pdfdoc = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfdoc, stream);

                        pdfdoc.Open();

                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.magpollo, System.Drawing.Imaging.ImageFormat.Jpeg);
                        img.ScaleToFit(70, 70);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfdoc.LeftMargin, pdfdoc.Top - 70);
                        pdfdoc.Add(img);

                        //  iTextSharp.text.html.simpleparser.StyleSheet styles = new iTextSharp.text.html.simpleparser.StyleSheet();

                        // Agregar un archivo CSS a la lista de estilos

                        //Register our font and give it an alias to reference in CSS
                        var fontProv = new XMLWorkerFontProvider();
                        fontProv.Register(Properties.Resources.Roboto_Regular.ToString(), "Roboto-Regular");

                        //Create our CSS
                        var css = @"body{ font-size: 8pt;font-family: Roboto-Regular;}";

                        //Create a stream to read our HTML
                        using (var htmlMS = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(html)))
                        {
                            //Create a stream to read our CSS
                            using (var cssMS = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(css)))
                            {
                                //Get an instance of the generic XMLWorker
                                var xmlWorker = XMLWorkerHelper.GetInstance();

                                //Parse our HTML using everything setup above
                                xmlWorker.ParseXHtml(writer, pdfdoc, htmlMS, cssMS, System.Text.Encoding.UTF8, fontProv);
                            }
                        }


                        //using (StringReader sr = new StringReader(html))
                        //{
                        //    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfdoc, sr);



                        //}


                        pdfdoc.Close();
                        stream.Close();
                        this.Close();
                    }



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            CargarDG();
        }

       private void CargarDG()
        {
            int estado = 0;
            empleados empleados = new empleados();
            empleados = ControladorEmpleados.Instance.findidbynombre(cbempleado.Text);

            sueldobase = empleados.Sueldoquincenal;
            txtsalarioadmin.Text = empleados.Sueldoquincenal.ToString("N", new CultureInfo("en-US"));

            /*******************Busca todas los ingresos**********************/
            dgingreso.Rows.Clear();
            List<ingresosxempleados> ingresosxempleado = new List<ingresosxempleados>();
            ingresosxempleado = Controladoringresosxempleado.Instance.Reporteingresosdesdehasta(dtperiododesde.Value.ToString("yyyy-MM-dd"), dtperiodohasta.Value.ToString("yyyy-MM-dd"), empleados.Idempleado);

            foreach (ingresosxempleados d in ingresosxempleado)
            {


                //buscar el role por medio del idrole antes de ingresarlo
                dgingreso.Rows.Add(d.Idingreso, d.Idempleado, d.Ingreso, d.Total, d.Fecha);
            }

            otrosingresos = 0;
            for (int x = 0; x < dgingreso.Rows.Count; ++x)
            {
                otrosingresos += Convert.ToInt32(dgingreso.Rows[x].Cells["Total"].Value);
                txtotrosingresos.Text = String.Format(" L " + "{0:n}", otrosingresos.ToString("N", new CultureInfo("en-US")));
            }



            /*******************Busca todas las Deudcciones**********************/
            dgdeduccionxempleado.Rows.Clear();
            List<Deduccionxempleados> Deduccionxempleado = new List<Deduccionxempleados>();
            Deduccionxempleado = Controladordeduccionesxempleado.Instance.ReporteDeducciondesdehasta(dtperiododesde.Value.ToString("yyyy-MM-dd"), dtperiodohasta.Value.ToString("yyyy-MM-dd"), empleados.Idempleado, estado);

            foreach (Deduccionxempleados d in Deduccionxempleado)
            {


                //buscar el role por medio del idrole antes de ingresarlo
                dgdeduccionxempleado.Rows.Add(d.Iddeduccion, d.Idempleado, d.Deduccion, d.Total, d.Fecha);
            }

            deducciones = 0;
            for (int x = 0; x < dgdeduccionxempleado.Rows.Count; ++x)
            {
                deducciones += Convert.ToInt32(dgdeduccionxempleado.Rows[x].Cells["Total2"].Value);
                txttotaldeducciones.Text = String.Format(" L " + "{0:n}", deducciones.ToString("N", new CultureInfo("en-US")));
            }
            Calcularsaldos();
        }
    }
}
    

   