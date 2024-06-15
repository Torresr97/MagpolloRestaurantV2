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

namespace AppTRchicken.Vista
{
    public partial class InventarioVista : Form
    {
        public InventarioVista()
        {
            InitializeComponent();
        }
        private static InventarioVista fmrInventarioVista = null;
        internal static InventarioVista Abrir1vez()
        {
            if (((fmrInventarioVista == null) || (fmrInventarioVista.IsDisposed == true)))
            {
                fmrInventarioVista = new InventarioVista();
            }
            fmrInventarioVista.BringToFront();
            return fmrInventarioVista;
        }
        private void InventarioVista_Load(object sender, EventArgs e)
        {
           
            cargardg();
        }


        private void cargardg()
        {
            dginventario.Rows.Clear();
            List<inventario> inv = new List<inventario>();
            inv = ControladorInventario.Instance.findAll();

            foreach (inventario inventario in inv)
            {
             

                //se obtiene el nombre del proovedor por medio del id del proovedor
              
                dginventario.Rows.Add(inventario.Idinventario,inventario.Nombreproducto,inventario.Existencia,inventario.Costo,inventario.Precioventa);
            }


        }


      

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "NUEVO")
            {



                txtcodigoinventario.Text = "";
                txtnombreproducto.Text = "";
                txtcosto.Text = "";
                txtprecioventa.Text = "";
                txtexistencia.Text = "";
                txtnombreproducto.Focus();



                btn1.Enabled = false;
                btn2.Text = "GUARDAR";
                btn3.Text = "CANCELAR";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            inventario inventario = new inventario();
            inventario.Nombreproducto = txtnombreproducto.Text;
            
           inventario.Existencia = Convert.ToInt32(txtexistencia.Text);
            inventario.Costo = Convert.ToDecimal(txtcosto.Text);
            inventario.Precioventa = Convert.ToDecimal(txtprecioventa.Text);
           


            if (btn2.Text == "ACTUALIZAR")
            {
                inventario.Idinventario = Convert.ToInt64(txtcodigoinventario.Text);


                try
                {
                    ControladorInventario.Instance.update(inventario);
                    MessageBox.Show("Producto de Inventario Actualizado");
                    Refrescar();
                    cargardg();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }



            if (btn2.Text == "GUARDAR")
            {
                try
                {
                    ControladorInventario.Instance.save(inventario);
                    MessageBox.Show("Producto Agregado a Inventario");
                    Refrescar();
                    cargardg();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //if (btn3.Text == "ELIMINAR")
            //{
            //    inventario inventario = new inventario();
            //    inventario.Idinventario = Convert.ToInt64(txtcodigoinventario.Text);
            //    try
            //    {
            //        ControladorInventario.Instance.delete(inventario);
            //        MessageBox.Show("Producto de Inventario Eliminado");
            //        Refrescar();
            //        cargardg();
            //    }
            //    catch (Exception ex)
            //    {

            //        MessageBox.Show(ex.Message);
            //    }
            //}
            if (btn3.Text == "CANCELAR")
            {
                Refrescar();
            }
        }



        private void Refrescar()
        {
            btn1.Enabled = true;
            btn2.Text = "ACTUALIZAR";
            btn3.Text = "ELIMINAR";

            txtcodigoinventario.Text = "";
            txtnombreproducto.Text = "";
            txtcosto.Text = "";
            txtprecioventa.Text = "";
            txtexistencia.Text = "";
            txtnombreproducto.Focus();


        }

        private void dginventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigoinventario.Text = dginventario.CurrentRow.Cells[0].Value.ToString();
            txtnombreproducto.Text = dginventario.CurrentRow.Cells[1].Value.ToString();
            txtexistencia.Text = dginventario.CurrentRow.Cells[2].Value.ToString();
            txtcosto.Text = dginventario.CurrentRow.Cells[3].Value.ToString();
            txtprecioventa.Text = dginventario.CurrentRow.Cells[4].Value.ToString();
           
        }
    }
}
