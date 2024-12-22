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
    public partial class EntradainventariomasivoVista : Form
    {
        public EntradainventariomasivoVista()
        {
            InitializeComponent();
            this.Load += EntradainventariomasivoVista_Load;
            
        }

       
        private static EntradainventariomasivoVista fmrEntradainventariomasivoVista = null;
        internal static EntradainventariomasivoVista Abrir1vez()
        {
            if (((fmrEntradainventariomasivoVista == null) || (fmrEntradainventariomasivoVista.IsDisposed == true)))
            {
                fmrEntradainventariomasivoVista = new EntradainventariomasivoVista();
            }
            fmrEntradainventariomasivoVista.BringToFront();
            return fmrEntradainventariomasivoVista;
        }
        private void EntradainventariomasivoVista_Load(object sender, EventArgs e)
        {
            cargardg();

            dginventario.KeyDown += dginventario_KeyDown;
        }
        private void dginventario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de error
                DataGridView dgv = sender as DataGridView;
                int currentRowIndex = dgv.CurrentCell.RowIndex;
                int currentColumnIndex = dgv.CurrentCell.ColumnIndex;

                if (dgv.Columns[currentColumnIndex].Name == "cantidadingresar")
                {
                    int nextRowIndex = currentRowIndex + 1;
                    if (nextRowIndex < dgv.Rows.Count)
                    {
                        dgv.CurrentCell = dgv.Rows[nextRowIndex].Cells["cantidadingresar"];
                    }
                }
            }
        }
            private void cargardg()
            {
                dginventario.Rows.Clear();
                List<inventario> inv = new List<inventario>();
                inv = ControladorInventario.Instance.findAll();

                foreach (inventario inventario in inv)
                {


                    //se obtiene el nombre del proovedor por medio del id del proovedor

                    dginventario.Rows.Add(inventario.Idinventario, inventario.Nombreproducto, inventario.Existencia);
                }


            }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dginventario.Rows)
            {
                // Validar que la columna "cantidadingresar" no esté vacía ni sea 0
                if (row.Cells["cantidadingresar"].Value != null &&
                    int.TryParse(row.Cells["cantidadingresar"].Value.ToString(), out int cantidad) &&
                    cantidad > 0)
                {
                    entrada_inventario entrada_inventario = new entrada_inventario
                    {
                        Idinventario = Convert.ToInt32(row.Cells["codigoinv"].Value),
                        Idproovedor = 1,
                        Cantidad = cantidad,
                        Fecha_ingreso = DateTime.Now
                    };

                    try
                    {
                        ControladorEntradainventario.Instance.save(entrada_inventario);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            MessageBox.Show("Cantidades Agregadas al Inventario");
            cargardg(); // Recargar el DataGridView después de agregar los elementos al inventario
        }
    }
    }
    
