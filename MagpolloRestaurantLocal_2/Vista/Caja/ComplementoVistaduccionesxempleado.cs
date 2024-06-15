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

namespace AppTRchicken.Vista.Caja
{
    public partial class ComplementoVistaduccionesxempleado : Form
    {
        public string nombrecombo { get; set; }

        public ComplementoVistaduccionesxempleado()
        {
            InitializeComponent();
        }

        private void ComplementoVistaduccionesxempleado_Load(object sender, EventArgs e)
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

                    tpanelcomplentosplatodeducionesxempleado.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    tpanelcomplentosplatodeducionesxempleado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

                    Button botonprincipal = new Button();

                    botonprincipal.Text = list[c];
                    botonprincipal.Name = list[c];

                    botonprincipal.Click += new EventHandler(btn_Click);
                    botonprincipal.Font = new Font(" Bookman Old Style", 18);

                    botonprincipal.BackColor = Color.White;
                    botonprincipal.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;

                    if (botonprincipal.Text != "")
                    {
                        tpanelcomplentosplatodeducionesxempleado.Controls.Add(botonprincipal, columna, f);
                    }

                    if (f == 0)
                    {
                        tpanelcomplentosplatodeducionesxempleado.ColumnCount += 1;
                    }
                    columna++;
                    bandera2 = c;
                }

                bandera1 = bandera2 + 1;
            }

            tpanelcomplentosplatodeducionesxempleado.ColumnCount = 0;
            tpanelcomplentosplatodeducionesxempleado.RowCount = 0;


        }

        void btn_Click(object sender, System.EventArgs e)
        {



            Button boton = (Button)sender;
            /****separo el nombre del combo y el precio para agregarlo al datagrid*****/
            char delimitador = 'L';

            string[] Division = Globales.btn.Split(delimitador);
            /****separo el nombre del combo y el precio para agregarlo al datagrid*****/



            /****le quito \n para dejar solo el nombre del combo y poder obtener el numero de complementos correspondientes*****/
            char deli = '\n';

            string[] nombrecombo = Division[0].Split(deli);
            /****le quito \n para dejar solo el nombre del combo y poder obtener el numero de complementos correspondientes*****/
            DeduccionxempleadoVista DeduccionxempleadoVista = (DeduccionxempleadoVista)Application.OpenForms["DeduccionxempleadoVista"];

            menu menus = new menu();
            menus = ControladorMenu.Instance.findNcomplemento(nombrecombo[0]);
            int ncomplemento = menus.Ncomplemento;
            

                Globales.complemento += boton.Text + ",";

               
                    if (Globales.contador < ncomplemento)
                    {

                DeduccionxempleadoVista.txtproducto.Text = (Division[0] +Globales.complemento);
                DeduccionxempleadoVista.txttotal.Text = Division[1];
                            this.Close();


                      }

                }

            }


        }
    

