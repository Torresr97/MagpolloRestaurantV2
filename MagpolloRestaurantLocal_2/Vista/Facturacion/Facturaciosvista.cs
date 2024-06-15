using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTRchicken.Modelo;
using AppTRchicken.Controlador;

using AppTRchicken.Utilidades;

namespace AppTRchicken.Vista
{
    public partial class Facturaciosvista : Form
    {
        public Facturaciosvista()
        {
            InitializeComponent();
            // Obtén el índice de la última fila actual.
        
        }


        public void Cargarcmbcliente()
        {
            cmbcliente.DataSource = ControladorCliente.Instance.Cargarcomboxcliente();
            cmbcliente.DisplayMember = "nombre";
            cmbcliente.ValueMember = "idcliente";

            string nombrePorDefecto = "CONSUMIDOR FINAL"; // Reemplaza "NombreDeLaOpcion" con el nombre que deseas establecer por defecto
            foreach (var item in cmbcliente.Items)
            {
                DataRowView row = item as DataRowView;
                if (row["nombre"].ToString() == nombrePorDefecto)
                {
                    cmbcliente.SelectedItem = item;
                    break;
                }
            }

        }

        private void Facturaciosvista_Load(object sender, EventArgs e)
        {
            lblusuario.Text = (lblusuario.Text + " " + Globales.nombreusuario);
            Cargarcmbcliente();

            /****************Aqui agregamos la columna de descuento**********************/
            DataGridViewTextBoxColumn discountColumn = new DataGridViewTextBoxColumn
            {
                Name = "DiscountAmount",
                HeaderText = "DiscountAmount",
                Visible = false
            };

            dgfacturacion.Columns.Add(discountColumn);



            decimal filan = 0;

            int bandera1 = 0;
            int bandera2 = 0;

            List<categoria_menu> catm = new List<categoria_menu>();
            catm = ControladorCategoriaMenu.Instance.findAll();

            List<String> list = new List<String>();


            foreach (categoria_menu categoriaMenu in catm)
            {
                list.Add(categoriaMenu.Nombrecategoria);

            }


            if (list.Count() <= 5)
            {
                filan = 1;
            }
            else
            {
                if ((list.Count() % 5) == 0)
                {
                    filan = int.Parse(Math.Ceiling(double.Parse((list.Count() / 5).ToString())).ToString());
                }
                else
                {
                    filan = int.Parse(Math.Ceiling(double.Parse((list.Count() / 5).ToString())).ToString());
                    filan++;

                    int registros = ((int)(filan * 5));
                    if (list.Count() != registros)
                    {
                        int diferencia = registros - list.Count;

                        int i = 0;
                        while (i < diferencia)
                        {
                            list.Add("");
                            i++;
                        }
                    }
                }
            }



            for (int f = 0; f < filan; f++)
            {
                int columna = 0;
                for (int c = bandera1; c < (f + 1) * 5; c++)
                {

                    tpanelmenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    tpanelmenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

                    Button boton = new Button();

                    boton.Text = list[c];
                    boton.Name = list[c];
                    boton.Click += new EventHandler(boton_Click);
                    boton.Font = new Font(" Bookman Old Style", 18);

                    boton.BackColor = Color.White;
                    boton.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;

                    if (boton.Text != "")
                    {
                        tpanelmenu.Controls.Add(boton, columna, f);
                    }

                    if (f == 0)
                    {
                        tpanelmenu.ColumnCount += 1;
                    }
                    columna++;
                    bandera2 = c;
                }

                bandera1 = bandera2 + 1;
            }

            tpanelmenu.ColumnCount -= 1;
            tpanelmenu.RowCount -= 1;

            limpiartxt();

        }

        void boton_Click(object sender, System.EventArgs e)
        {
            Button boton = (Button)sender;

            tpanelmenu.Controls.Clear();

            decimal filan = 0;

            int bandera1 = 0;
            int bandera2 = 0;


            List<menu> men = new List<menu>();
            men = ControladorMenu.Instance.findbycategoria(boton.Name.ToString());
            List<String> list = new List<String>();


            foreach (menu menu in men)
            {
                list.Add(menu.Nombrecombo + " \n L" + menu.Precio);

            }
            list.Add("REGRESAR");

            if (list.Count() <= 5)
            {
                filan = 1;

                int registros = ((int)(filan * 5));
                if (list.Count() != registros)
                {
                    int diferencia = registros - list.Count;

                    int i = 0;
                    while (i < diferencia)
                    {
                        list.Add("");
                        i++;
                    }
                }
            }
            else
            {
                if ((list.Count() % 5) == 0)
                {
                    filan = int.Parse(Math.Ceiling(double.Parse((list.Count() / 5).ToString())).ToString());
                }
                else
                {
                    filan = int.Parse(Math.Ceiling(double.Parse((list.Count() / 5).ToString())).ToString());
                    filan++;

                    int registros = ((int)(filan * 5));
                    if (list.Count() != registros)
                    {
                        int diferencia = registros - list.Count;

                        int i = 0;
                        while (i < diferencia)
                        {
                            list.Add("");
                            i++;
                        }
                    }
                }
            }



            for (int f = 0; f < filan; f++)
            {
                int columna = 0;
                for (int c = bandera1; c < (f + 1) * 5; c++)
                {

                    tpanelmenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    tpanelmenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

                    Button btn = new Button();

                    btn.Text = list[c];
                    btn.Name = list[c];
                    btn.Font = new Font(" Bookman Old Style", 18);
                    btn.BackColor = Color.White;
                    btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
                    btn.Click += new EventHandler(btn_Click);
                    if (btn.Text != "")
                    {
                        tpanelmenu.Controls.Add(btn, columna, f);
                    }

                    if (f == 0)
                    {
                        tpanelmenu.ColumnCount += 1;
                    }
                    columna++;
                    bandera2 = c;
                }

                bandera1 = bandera2 + 1;
            }
            tpanelmenu.ColumnCount -= 5;
        }



        /*****************************************************verificamos que opcion se presiono *********************************************************************/

        void btn_Click(object sender, System.EventArgs e)
        {
            Button boton = (Button)sender;
            char delimitador = 'L';
            Globales.btn = boton.Text;
            string[] precio = Globales.btn.Split(delimitador);

            /*****************************************************REGRESAR AL MENU PRINCIPAL*********************************************************************/
            if (Globales.btn == "REGRESAR")
            {
                tpanelmenu.Controls.Clear();
                cargarmenu();
            }
            else
            {


                string[] Division = Globales.btn.Split(delimitador);
                /****separo el nombre del combo y el precio para agregarlo al datagrid*****/

                /****le quito \n para dejar solo el nombre del combo y poder obtener el numero de complementos correspondientes*****/
                char deli = '\n';

                string[] nombrecombo = Division[0].Split(deli);
                /****le quito \n para dejar solo el nombre del combo y poder obtener el numero de complementos correspondientes*****/
                Facturaciosvista Facturaciosvista = (Facturaciosvista)Application.OpenForms["Facturaciosvista"];


                menu menus = new menu();
                menus = ControladorMenu.Instance.findNcomplemento(nombrecombo[0]);
                int ncomplemento = menus.Ncomplemento;

                if (ncomplemento == 0)
                {

                    /**********************************Aqui no se extiende los complementos**************************************/
                    bool existe = false;
                    for (int i = 0; i < Facturaciosvista.dgfacturacion.RowCount; i++)
                    {
                        //MessageBox.Show((Convert.ToString(Facturaciosvista.dgfacturacion.Rows[i].Cells["Producto"].Value)));
                        //MessageBox.Show(Convert.ToString(Division[0]));

                        if ((Convert.ToString(Facturaciosvista.dgfacturacion.Rows[i].Cells["Producto"].Value) == Convert.ToString(Division[0])))
                        {
                            int cantidad;
                            cantidad = 1 + Convert.ToInt32(Facturaciosvista.dgfacturacion.Rows[i].Cells["Cantidad"].Value);

                            Facturaciosvista.dgfacturacion.Rows[i].Cells["Cantidad"].Value = cantidad;
                            Facturaciosvista.dgfacturacion.Rows[i].Cells["Total"].Value = (cantidad * Convert.ToInt32(Division[1]));
                            existe = true;
                            Sumartotales();
                        }
                    }
                    if (existe == false)
                    {




                        /**********************************Aqui no se extiende los complementos**************************************/
                        Facturaciosvista.dgfacturacion.Rows.Add(1, Division[0] + "" + Globales.complemento,"" ,0, Division[1]);
                        Sumartotales();




                    }






                }
                else
                {


                    complementoVista complementoVista = null;
                    complementoVista = complementoVista.Abrir1vez();
                    complementoVista.nombrecombo = nombrecombo[0];
                    complementoVista.Show();
                }


            }
            /******************************************************REGRESAR AL MENU PRINCIPAL*************************************************************/





        }




        public void limpiartxt()
        {
            txtdescuento.Text = "L";
            txtexcento.Text = "L";
            txtexonerado.Text = "L";
            txtsubtotal.Text = "L";
            txtisv.Text = "L";
            txttotal.Text = "L";
            richTextBox1.Text = "L";
        }

        public void cargarmenu()
        {

            decimal filan = 0;

            int bandera1 = 0;
            int bandera2 = 0;

            List<categoria_menu> catm = new List<categoria_menu>();
            catm = ControladorCategoriaMenu.Instance.findAll();

            List<String> list = new List<String>();


            foreach (categoria_menu categoriaMenu in catm)
            {
                list.Add(categoriaMenu.Nombrecategoria);

            }


            if (list.Count() <= 5)
            {
                filan = 1;
            }
            else
            {
                if ((list.Count() % 5) == 0)
                {
                    filan = int.Parse(Math.Ceiling(double.Parse((list.Count() / 5).ToString())).ToString());
                }
                else
                {
                    filan = int.Parse(Math.Ceiling(double.Parse((list.Count() / 5).ToString())).ToString());
                    filan++;

                    int registros = ((int)(filan * 5));
                    if (list.Count() != registros)
                    {
                        int diferencia = registros - list.Count;

                        int i = 0;
                        while (i < diferencia)
                        {
                            list.Add("");
                            i++;
                        }
                    }
                }
            }



            for (int f = 0; f < filan; f++)
            {
                int columna = 0;
                for (int c = bandera1; c < (f + 1) * 5; c++)
                {

                    tpanelmenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    tpanelmenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

                    Button boton = new Button();

                    boton.Text = list[c];
                    boton.Name = list[c];
                    boton.Click += new EventHandler(boton_Click);
                    boton.Font = new Font(" Bookman Old Style", 18);

                    boton.BackColor = Color.White;
                    boton.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;

                    if (boton.Text != "")
                    {
                        tpanelmenu.Controls.Add(boton, columna, f);
                    }

                    if (f == 0)
                    {
                        tpanelmenu.ColumnCount += 1;
                    }
                    columna++;
                    bandera2 = c;
                }

                bandera1 = bandera2 + 1;
            }

            tpanelmenu.ColumnCount = 0;
            tpanelmenu.RowCount = 0;







        }






        private void button1_Click_1(object sender, EventArgs e)
        {

            dgfacturacion.Rows.Clear();
            tpanelmenu.Controls.Clear();
            cargarmenu();
            limpiartxt();
            LimpiarVariablesGlobales();
            Cargarcmbcliente();
        }

        public void LimpiarVariablesGlobales()
        {
          
         
            Globales.complemento = "";
            Globales.orden = 0;
            Globales.descuento = 0;
            Globales.exonerado = 0;
            Globales.exento = 0;
            Globales.gravado = 0;
            Globales.isv = 0;
            Globales.metodopago = "";
            Globales.ultimosdigitos = "";
            Globales.Dinerorecibido = 0;
            Globales.ventatotal = 0;
            Globales.servir = "";
           




        }


        private void btnregresarconfiguraciones_Click(object sender, EventArgs e)
        {
            this.Close();

            PantallaPrincipal PantallaPrincipal = (PantallaPrincipal)Application.OpenForms["PantallaPrincipal"];
            PantallaPrincipal.panelContenedor1.Controls.Clear();
            PantallaPrincipal.panelmenu.Dock = DockStyle.Fill;

            PantallaPrincipal.panelContenedor1.Controls.Add(PantallaPrincipal.panelmenu);
        }


        /******************************Aqui definimos que solo se abra 1 vez el formulario*************************************/



        private void button2_Click_2(object sender, EventArgs e)
        {


            char delimitador = 'L';
            string[] ventat = richTextBox1.Text.Split(delimitador);
            string[] exento = txtexcento.Text.Split(delimitador);
            string[] exonerado = txtexonerado.Text.Split(delimitador);
            string[] gravado = txtsubtotal.Text.Split(delimitador);

            Globales.ventatotal = Convert.ToDecimal(ventat[1]);
            Globales.isv = Convert.ToDecimal(txtisv.Text);
            Globales.exento = Convert.ToDecimal(exento[1]);
            Globales.exonerado = Convert.ToDecimal(exonerado[1]);
            Globales.gravado = Convert.ToDecimal(gravado[0]);

            Cliente Cliente = new Cliente();
            Cliente = ControladorCliente.Instance.findbynombre(cmbcliente.Text);

            Globales.idcliente = (int)Cliente.Idcliente;
            Globales.nombrecliente = Cliente.Nombre;
            Globales.rtncliente = Cliente.Rtn;


            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            metodos metodos = null;
            metodos = metodos.Abrir1vez();
            metodos.Show();
        }


        private void btnListaFacturasVista_Click(object sender, EventArgs e)
        {
            ListaFacturasVista ListaFacturasVista = null;
            ListaFacturasVista = ListaFacturasVista.Abrir1vez();
            ListaFacturasVista.Show();
        }


        private void dgfacturacion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)  //Dónde la columna con el botón es la 6 con posición 5
            {



                for (int i = 0; i < dgfacturacion.RowCount; i++)
                {
                    if (dgfacturacion.Rows[i].Cells["Producto"].Value != null)
                    {
                        char delimitador = '\n';
                        string nombre = dgfacturacion.Rows[i].Cells["Producto"].Value.ToString();
                        string[] nombrecombo = nombre.Split(delimitador);
                        menu menu = new menu();
                        menu = ControladorMenu.Instance.findidpornombre(nombrecombo[0]);


                        int cantidad = Convert.ToInt32(dgfacturacion.Rows[i].Cells["Cantidad"].Value);


                        (dgfacturacion.Rows[i].Cells["Total"].Value) = (cantidad * menu.Precio);
                        Sumartotales();
                    }
                }


            }

            if (e.ColumnIndex == 3)  // Aquí es para sacar el descuento
            {
                // Obtenemos la fila actual
                DataGridViewRow currentRow = dgfacturacion.Rows[e.RowIndex];

                // Obtenemos el valor del descuento y del total actual
                if (decimal.TryParse(currentRow.Cells["Descuento"].Value?.ToString(), out decimal descuento) &&
                    decimal.TryParse(currentRow.Cells["Total"].Value?.ToString(), out decimal total))
                {
                    if (descuento == 0)
                    {
                        // Si el descuento es 0, revertimos al total original
                        if (decimal.TryParse(currentRow.Cells["DiscountAmount"].Value?.ToString(), out decimal originalTotal))
                        {
                            // Restauramos el total al valor original
                            currentRow.Cells["Total"].Value = originalTotal;

                            // Ajustamos el descuento global
                            Globales.descuento -= (originalTotal - total);
                            currentRow.Cells["DiscountAmount"].Value = 0; // Resetear el monto del descuento almacenado

                            // Actualizamos los totales generales
                            Sumartotales();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el total original para revertir el descuento.");
                        }
                    }
                    else
                    {
                        // Si el descuento es diferente de 0, aplicamos el descuento normalmente

                        // Calculamos el importe del descuento
                        decimal imp = (descuento / 100) * total;

                        // Ajustamos el descuento global
                        Globales.descuento += imp;

                       // MessageBox.Show(Globales.descuento.ToString());

                        // Guardamos el total original en la columna DiscountAmount si no está ya guardado
                        if (currentRow.Cells["DiscountAmount"].Value == null ||
                            currentRow.Cells["DiscountAmount"].Value == DBNull.Value ||
                            (decimal.TryParse(currentRow.Cells["DiscountAmount"].Value?.ToString(), out decimal originalTotal) && originalTotal <= 0))
                        {
                            currentRow.Cells["DiscountAmount"].Value = total;
                        }

                        // Actualizamos el total restando el descuento
                        currentRow.Cells["Total"].Value = total - imp;

                        // Actualizamos los totales generales
                        Sumartotales();
                    }
                }
                else
                {
                    // Manejo de errores si los valores de descuento o total no son válidos
                    MessageBox.Show("Por favor, introduce un valor válido para el descuento y el total.");
                }
            }
        }




        public void Sumartotales()
        {
            Facturaciosvista Facturaciosvista = (Facturaciosvista)Application.OpenForms["Facturaciosvista"];
            int sumatotal = 0;
            for (int x = 0; x < Facturaciosvista.dgfacturacion.Rows.Count; ++x)
            {
                sumatotal += Convert.ToInt32(Facturaciosvista.dgfacturacion.Rows[x].Cells["Total"].Value);
            }
            decimal excento = 0;
            decimal importe = 0;

            decimal total = sumatotal;
            decimal subtotal = ((decimal)(sumatotal / 1.15));
            decimal isv = ((decimal)(subtotal * Convert.ToDecimal(0.15)));


            Facturaciosvista.txtexcento.Text = "L" + excento;
            Facturaciosvista.txtexonerado.Text = "L" + importe;
            Facturaciosvista.txtdescuento.Text = "L" + Globales.descuento;
            Facturaciosvista.txtsubtotal.Text = subtotal.ToString();
            Facturaciosvista.txtisv.Text = isv.ToString();
            Facturaciosvista.txttotal.Text = total.ToString();
            Facturaciosvista.richTextBox1.Text = "L" + total.ToString();
            Facturaciosvista.tpanelmenu.Controls.Clear();
            Facturaciosvista.cargarmenu();
            Globales.contador = 0;
            Globales.complemento = "";


        }

        private void dgfacturacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)  //Dónde la columna con el botón es la 6 con posición 5
            {
                // Obtenemos el importe del descuento de la columna oculta
                if (decimal.TryParse(dgfacturacion.CurrentRow.Cells["DiscountAmount"].Value?.ToString(), out decimal descuento) && 
                    decimal.TryParse(dgfacturacion.CurrentRow.Cells["Total"].Value?.ToString(), out decimal total))
                {
                   
                    // Restamos el importe del descuento del total acumulado
                    Globales.descuento -= (  descuento - total);
                    //MessageBox.Show($"Descuento acumulado actualizado: {Globales.descuento:C}");
                }
                dgfacturacion.Rows.RemoveAt(dgfacturacion.CurrentRow.Index);
                Sumartotales();

            }
        }

       
    }
}
