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
using System.Globalization;

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

            // Separar el nombre del combo y el precio
            char delimitador = 'L';
            string[] Division = Globales.btn.Split(delimitador);


            // Separar el nombre del combo para obtener el número de complementos
            char deli = '\n';
            string[] nombrecombo = Division[0].Split(deli);

            // Eliminar saltos de línea del nombre del combo para una comparación precisa
            string nombreComboLimpio = Division[0].Replace("\n", "").Trim();

            Facturaciosvista Facturaciosvista = (Facturaciosvista)Application.OpenForms["Facturaciosvista"];

            menu menus = ControladorMenu.Instance.findNcomplemento(nombrecombo[0]);
            int ncomplemento = menus.Ncomplemento;

            if (Facturaciosvista.dgfacturacion.RowCount > 0)
            {
                Globales.complemento += boton.Text + ",";
                bool existe = false;

                // Iterar sobre el DataGridView para buscar si ya existe el producto con complemento
                for (int i = 0; i < Facturaciosvista.dgfacturacion.RowCount; i++)
                {
                    // Comparar el producto y complementos existentes
                    // Eliminar saltos de línea del producto existente para comparación
                    // Eliminar saltos de línea y retornos de carro del producto existente para comparación
                    string productoExistente = Convert.ToString(Facturaciosvista.dgfacturacion.Rows[i].Cells["Producto"].Value)
                                                .Replace("\n", "").Replace("\r", "").Trim();
                    // Eliminar saltos de línea y retornos de carro del producto con complemento para comparación
                    string productoConComplemento = Division[0].Replace("\n", "").Replace("\r", "").Trim() + "  " + Globales.complemento.Trim();

                    if (productoExistente == productoConComplemento)
                    {
                        // Incrementar la cantidad y actualizar el total
                        int cantidad = 1 + Convert.ToInt32(Facturaciosvista.dgfacturacion.Rows[i].Cells["Cantidad"].Value);
                        Facturaciosvista.dgfacturacion.Rows[i].Cells["Cantidad"].Value = cantidad;
                        Facturaciosvista.dgfacturacion.Rows[i].Cells["Total"].Value = (cantidad * Globales.ConvertToDecimal(Division[1]));

                        existe = true;
                        ActualizarTotales(Facturaciosvista);
                        Globales.complemento = "";
                        Globales.contador = 0;
                        this.Close();
                        return;
                    }
                }

                // Si el producto con complemento no existe, agregar nueva línea
                if (!existe && Globales.contador < ncomplemento)
                {
                    Globales.contador += 1;

                    if (Globales.contador == ncomplemento)
                    {
                        Facturaciosvista.dgfacturacion.Rows.Add(1, Division[0] + "" + Globales.complemento, "", "", 0, Division[1]);
                        ActualizarTotales(Facturaciosvista);

                        // Reiniciar los valores globales
                        Globales.complemento = "";
                        Globales.contador = 0;
                        this.Close();
                    }
                }
            }
        }

        // Método para actualizar los totales en la interfaz
        void ActualizarTotales(Facturaciosvista vista)
        {
            decimal sumatotal = 0;

            // Sumar los totales de cada fila del DataGridView
            for (int x = 0; x < vista.dgfacturacion.Rows.Count; ++x)
            {
                if (!vista.dgfacturacion.Rows[x].IsNewRow)
                {
                    var valorCelda = vista.dgfacturacion.Rows[x].Cells["Total"].Value;
                    if (valorCelda != null && !string.IsNullOrWhiteSpace(valorCelda.ToString()))
                    {
                        sumatotal += Globales.ConvertToDecimal(valorCelda.ToString());
                    }
                }
            }

            // Cálculo de subtotal, ISV y total
            decimal subtotal = sumatotal / 1.15m;
            decimal isv = subtotal * 0.15m;
            decimal excento = 0;
            decimal importe = 0;

            // Actualizar los controles de totales en la vista
            vista.txtexcento.Text = "L" + excento.ToString("N2", CultureInfo.InvariantCulture);
            vista.txtexonerado.Text = "L" + importe.ToString("N2", CultureInfo.InvariantCulture);
            vista.txtsubtotal.Text = subtotal.ToString("N2", CultureInfo.InvariantCulture);
            vista.txtisv.Text = isv.ToString("N2", CultureInfo.InvariantCulture);
            vista.txttotal.Text = sumatotal.ToString("N2", CultureInfo.InvariantCulture);
            vista.richTextBox1.Text = "L" + sumatotal.ToString("N2", CultureInfo.InvariantCulture);
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

