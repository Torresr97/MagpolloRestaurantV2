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


namespace AppTRchicken.Vista
{
    public partial class complementoVista : Form
    {

        // Propiedad para almacenar el ID del combo
        public string nombrecombo { get; set; }


        public complementoVista()
        {
            InitializeComponent();
            this.FormClosing += complementoVista_FormClosing; // Suscribir al evento FormClosing
            this.Deactivate += complementoVista_Deactivate; // Suscribir al evento Deactivate
            this.Activated += complementoVista_Activated; // Suscribir al evento Activated
        
    }

        private static complementoVista fmrcomplementoVista = null;
        internal static complementoVista Abrir1vez()
        {
            if (((fmrcomplementoVista == null) || (fmrcomplementoVista.IsDisposed == true)))
            {
                fmrcomplementoVista = new complementoVista();
            }
            fmrcomplementoVista.BringToFront();
            return fmrcomplementoVista;
        }


        private void complementoVista_Load(object sender, EventArgs e)
        {
            decimal filan = 0;

            int bandera1 = 0;
            int bandera2 = 0;
            string nombreCombo = this.nombrecombo;
            List<complementos_plato> catm = ControladorComplementosPlato.Instance.findAllByComboName(nombreCombo);

            List<String> list = new List<String>();

            foreach (complementos_plato complementos_plato in catm)
            {
                list.Add(complementos_plato.Nombre_complementosplato);
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

                    tpanelcomplentosplato.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    tpanelcomplentosplato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

                    Button botonprincipal = new Button();

                    botonprincipal.Text = list[c];
                    botonprincipal.Name = list[c];

                    botonprincipal.Click += new EventHandler(btn_Click);
                    botonprincipal.Font = new Font(" Bookman Old Style", 18);

                    botonprincipal.BackColor = Color.White;
                    botonprincipal.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;

                    if (botonprincipal.Text != "")
                    {
                        tpanelcomplentosplato.Controls.Add(botonprincipal, columna, f);
                    }

                    if (f == 0)
                    {
                        tpanelcomplentosplato.ColumnCount += 1;
                    }
                    columna++;
                    bandera2 = c;
                }

                bandera1 = bandera2 + 1;
            }

            tpanelcomplentosplato.ColumnCount = 0;
            tpanelcomplentosplato.RowCount = 0;


        }



        void btn_Click(object sender, System.EventArgs e)
        {



            Button boton = (Button)sender;


            // Cambia el color del botón seleccionado al color de selección
            boton.BackColor = Color.Yellow;
            /****separo el nombre del combo y el precio para agregarlo al datagrid*****/
            char delimitador = 'L';

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
            if (Facturaciosvista.dgfacturacion.RowCount > 0)
            {






                Globales.complemento += boton.Text + ",";

                // Primero averigua si el registro existe:
                // Primero averigua si el registro existe:
                bool existe = false;
                for (int i = 0; i < Facturaciosvista.dgfacturacion.RowCount; i++)
                {

                    //MessageBox.Show((Convert.ToString(Facturaciosvista.dgfacturacion.Rows[i].Cells["Producto"].Value)));
                    //MessageBox.Show(Convert.ToString(Division[0] + "" + Globales.complemento));

                    if (Convert.ToString(Facturaciosvista.dgfacturacion.Rows[i].Cells["Producto"].Value) == Convert.ToString(Division[0] + "" + Globales.complemento))
                    {
                        int cantidad;
                        cantidad = 1 + Convert.ToInt32(Facturaciosvista.dgfacturacion.Rows[i].Cells["Cantidad"].Value);
                        // MessageBox.Show("Si encontro el producto");
                        Facturaciosvista.dgfacturacion.Rows[i].Cells["Cantidad"].Value = cantidad;
                        Facturaciosvista.dgfacturacion.Rows[i].Cells["Total"].Value = (cantidad * Convert.ToInt32(Division[1]));
                        existe = true;
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
                        Facturaciosvista.cargarmenu();
                        Globales.contador = 0;
                        Globales.complemento = "";

                        this.Close();

                    }
                }

                // Luego, ya fuera del ciclo, solo si no existe, realizas la insercion:
                if (existe == false)
                {



                    if (Globales.contador < ncomplemento)
                    {



                        Globales.contador += 1;

                        if (Globales.contador == ncomplemento)
                        {
                            Facturaciosvista.dgfacturacion.Rows.Add(1, Division[0] + "" + Globales.complemento, "", 0, Division[1]);


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
                            Facturaciosvista.cargarmenu();
                            Globales.contador = 0;
                            Globales.complemento = "";

                            this.Close();
                        }



                    }

                }

            }


        }
        private void complementoVista_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Establece la variable nombrecombo a null o a una cadena vacía al cerrar el formulario
            nombrecombo = null; // o nombrecombo = "";

        }

        private void complementoVista_Deactivate(object sender, EventArgs e)
        {
            // Verifica si el formulario no está minimizado
            if (this.WindowState != FormWindowState.Minimized)
            {
                // Cierra el formulario
                this.Close();
            }
        }

        private void complementoVista_Activated(object sender, EventArgs e)
        {
            // No es necesario hacer nada cuando el formulario se activa nuevamente
        }
    }
}

