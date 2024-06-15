using AppTRchicken.Controlador;
using AppTRchicken.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTRchicken.Vista.Inventario
{
    public partial class ConfiguracioninventarioVista : Form
    {
        public ConfiguracioninventarioVista()
        {
            InitializeComponent();
        }
        private static ConfiguracioninventarioVista fmrConfiguracioninventarioViata = null;
        internal static ConfiguracioninventarioVista Abrir1vez()
        {
            if (((fmrConfiguracioninventarioViata == null) || (fmrConfiguracioninventarioViata.IsDisposed == true)))
            {
                fmrConfiguracioninventarioViata = new ConfiguracioninventarioVista();
            }
            fmrConfiguracioninventarioViata.BringToFront();
            return fmrConfiguracioninventarioViata;
        }

        private void ConfiguracioninventarioViata_Load(object sender, EventArgs e)
        {
            cargarproductosinventario();
            cargarmenu();
            cargardg();


        }

        private void cargardg()
        {
            dgentradainventario.Rows.Clear();
            menu menu = new menu();
            menu = ControladorMenu.Instance.findidpornombre(cbmenu.Text);



            List<configinventario> configinventario = new List<configinventario>();
            configinventario = Controladorconfiginventario.Instance.findbyid(menu.Idmenu);


            foreach (configinventario d in configinventario)
            {
                /*Busca los Nombre con los ID para mostrarlo*/
                menu menu2 = new menu();
                menu2 = ControladorMenu.Instance.findnombre((int)d.Idmenu);

                inventario inventario = new inventario();
                inventario = ControladorInventario.Instance.findnombrebyid((int)d.Idinventario);


                //buscar el role por medio del idrole antes de ingresarlo
                dgentradainventario.Rows.Add(d.Idconfiginventario, menu2.Nombrecombo, inventario.Nombreproducto, d.Cantidadrestar);
            }
        }

        public void cargarproductosinventario()
        {
            cbproductoinventario.DataSource = ControladorInventario.Instance.findAll();
            cbproductoinventario.DisplayMember = "nombreproducto";
            cbproductoinventario.ValueMember = "idinventario";

        }

        public void cargarmenu()
        {
            cbmenu.DataSource = ControladorMenu.Instance.findAll();
            cbmenu.DisplayMember = "nombrecombo";
            cbmenu.ValueMember = "idmenu";

        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu = ControladorMenu.Instance.findidpornombre(cbmenu.Text);

            inventario inventario = new inventario();
            inventario = ControladorInventario.Instance.findidbynombre(cbproductoinventario.Text);

            configinventario configinventario = new configinventario();
            configinventario.Idmenu = menu.Idmenu;
            configinventario.Idinventario = inventario.Idinventario;
            configinventario.Cantidadrestar = (int)Convert.ToInt32(txtcantidad.Text);

          

            try
            {
                DialogResult result = MessageBox.Show("¿Al Vender un [**" + cbmenu.Text + "**] se restara la Cantidad("+txtcantidad.Text+") en inventario [" + cbproductoinventario.Text + "] ,Desea Continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Controladorconfiginventario.Instance.save(configinventario);
                    MessageBox.Show("Configuracion Agregada");
                    cargardg();
                    txtcantidad.Text = "";
                    // Aquí puedes poner el código que se ejecutará si el usuario presiona 'Sí'
                }
                else
                {
                    Console.WriteLine("Presionaste 'No'");
                    // Aquí puedes poner el código que se ejecutará si el usuario presiona 'No'
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cbmenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargardg();
        }

        private void dgentradainventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)  //Dónde la columna con el botón es la 6 con posición 5
            {




                try
                {
                    DialogResult result = MessageBox.Show("Esta Seguro de Eliminar esta configuracion de Inventario?", "Eliminar Configuracion", MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            configinventario configinventario = new configinventario();
                            configinventario.Idconfiginventario = Convert.ToInt32(dgentradainventario.Rows[dgentradainventario.CurrentRow.Index].Cells["idconfiginventario"].Value);
                            Controladorconfiginventario.Instance.delete(configinventario);
                            // Eliminar la fila del DataGridView
                            dgentradainventario.Rows.RemoveAt(dgentradainventario.CurrentRow.Index);
                            MessageBox.Show("Configuracion de Inventario Eliminado");

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
    }
}
