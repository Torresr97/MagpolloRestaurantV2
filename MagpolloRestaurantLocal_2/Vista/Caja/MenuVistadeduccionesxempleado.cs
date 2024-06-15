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
using AppTRchicken.Vista;
using AppTRchicken.Modelo;
using AppTRchicken.Controlador;
using AppTRchicken.Vista.Caja;

namespace AppTRchicken.Vista.Menu
{
    public partial class MenuVistadeduccionesxempleado : Form
    {
        public MenuVistadeduccionesxempleado()
        {
            InitializeComponent();
        }

        private static MenuVistadeduccionesxempleado fmrMenuVista = null;
        internal static MenuVistadeduccionesxempleado Abrir1vez()
        {
            if (((fmrMenuVista == null) || (fmrMenuVista.IsDisposed == true)))
            {
                fmrMenuVista = new MenuVistadeduccionesxempleado();
            }
            fmrMenuVista.BringToFront();
            return fmrMenuVista;
        }


        private void MenuVista_Load(object sender, EventArgs e)
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

            tpanelmenu.ColumnCount -= 1;
            tpanelmenu.RowCount -= 1;

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
                DeduccionxempleadoVista deduccionForm = (DeduccionxempleadoVista)Application.OpenForms["DeduccionxempleadoVista"];

                menu menus = new menu();
                menus = ControladorMenu.Instance.findNcomplemento(nombrecombo[0]);
                int ncomplemento = menus.Ncomplemento;

                if (ncomplemento == 0)
                       
                    {
                        // Acceder a los controles dentro de groupBox1
                        TextBox txtproducto = deduccionForm.groupBox1.Controls.Find("txtproducto", true).FirstOrDefault() as TextBox;
                        TextBox txttotal = deduccionForm.groupBox1.Controls.Find("txttotal", true).FirstOrDefault() as TextBox;


                        deduccionForm.txtproducto.Text = Division[0];
                        deduccionForm.txttotal.Text = Division[1];
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                        ComplementoVistaduccionesxempleado ComplementoVistaduccionesxempleado = new ComplementoVistaduccionesxempleado();
                    ComplementoVistaduccionesxempleado.nombrecombo = nombrecombo[0];
                    ComplementoVistaduccionesxempleado.Show();

                    }
               



            }
            /******************************************************REGRESAR AL MENU PRINCIPAL*************************************************************/





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

            Facturaciosvista.txtsubtotal.Text = subtotal.ToString();
            Facturaciosvista.txtisv.Text = isv.ToString();
            Facturaciosvista.txttotal.Text = total.ToString();
            Facturaciosvista.richTextBox1.Text = "L" + total.ToString();
            Facturaciosvista.tpanelmenu.Controls.Clear();
           cargarmenu();
            Globales.contador = 0;
            Globales.complemento = "";


        }


    }
}
