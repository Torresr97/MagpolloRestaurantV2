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
    public partial class EntradainventarioVista : Form
    {
        public EntradainventarioVista()
        {
            InitializeComponent();
        }
        private static EntradainventarioVista fmrEntradainventario = null;
        internal static EntradainventarioVista Abrir1vez()
        {
            if (((fmrEntradainventario == null) || (fmrEntradainventario.IsDisposed == true)))
            {
                fmrEntradainventario = new EntradainventarioVista();
            }
            fmrEntradainventario.BringToFront();
            return fmrEntradainventario;
        }

        private void Entradainventario_Load(object sender, EventArgs e)
        {
            cargarproductosinventario();
            cargarproovedores();
        }

        public void cargarproovedores()
        {
            cbproovedor.DataSource = ControladorProveedor.Instance.findAll();
            cbproovedor.DisplayMember = "nombre_empresa";
            cbproovedor.ValueMember = "idproovedor";

        }

        public void cargarproductosinventario()
        {
            cbproductoinventario.DataSource = ControladorInventario.Instance.findAll();
            cbproductoinventario.DisplayMember = "nombreproducto";
            cbproductoinventario.ValueMember = "idinventario";

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            inventario inventario = new inventario();
            inventario = ControladorInventario.Instance.findidbynombre(cbproductoinventario.Text);

            proovedor proovedor = new proovedor();
            proovedor = ControladorProveedor.Instance.findidbynombre(cbproovedor.Text);

            entrada_inventario entrada_inventario = new entrada_inventario();
            entrada_inventario.Idinventario = inventario.Idinventario;
            entrada_inventario.Idproovedor = proovedor.Idproovedor;
            entrada_inventario.Cantidad = Convert.ToInt32(txtcantidad.Text);
            entrada_inventario.Fecha_ingreso = DateTime.Now;



            try
            {
                DialogResult result = MessageBox.Show("¿Deseas Agregar la cantidad(+" + txtcantidad.Text + ") al producto de Inventario - " + cbproductoinventario.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ControladorEntradainventario.Instance.save(entrada_inventario);
                    MessageBox.Show("Agregado a Inventario");
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

        private void cbproductoinventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargardg();
        }


        private void cargardg()
        {
            dgconfiginventario.Rows.Clear();
            inventario inventario = new inventario();
            inventario = ControladorInventario.Instance.findidbynombre(cbproductoinventario.Text);


            List<entrada_inventario> Entradainventario = new List<entrada_inventario>();
            Entradainventario = ControladorEntradainventario.Instance.findAllbyid(inventario.Idinventario);


            foreach (entrada_inventario d in Entradainventario)
            {


                //buscar el role por medio del idrole antes de ingresarlo
                dgconfiginventario.Rows.Add(d.Identradainventario, d.Idinventario, d.Idproovedor, d.Cantidad, d.Fecha_ingreso);
            }
        }
    }
}
