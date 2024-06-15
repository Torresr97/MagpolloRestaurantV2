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

namespace AppTRchicken.Vista
{
    public partial class ProveedoresVista : Form
    {
        public ProveedoresVista()
        {
            InitializeComponent();
        }

        private void ProveedoresVista_Load(object sender, EventArgs e)
        {
            cargardg();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "NUEVO")
            {
                txtcodigoproveedor.Text = "";
                txtnombreempresa.Text = "";
                txtrtn.Text = "";
                txtcelular.Text = "";
                txtcorreo.Text = "";
                txtdireccion.Text = "";
                txtnombreencargado.Text = "";



                btn1.Enabled = false;
                btn2.Text = "GUARDAR";
                btn3.Text = "CANCELAR";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            proovedor proovedor = new proovedor();
            proovedor.Nombre_empresa = txtnombreempresa.Text;
            proovedor.Rtn = txtrtn.Text;
            proovedor.Celular = txtcelular.Text;
            proovedor.Correo = txtcorreo.Text;
            proovedor.Direccion = txtdireccion.Text;
            proovedor.Nombre_encargado = txtnombreencargado.Text;




            if (btn2.Text == "ACTUALIZAR")
            {
                proovedor.Idproovedor = (int)Convert.ToInt64(txtcodigoproveedor.Text);


                try
                {
                    ControladorProveedor.Instance.update(proovedor);
                    MessageBox.Show("Proveedor Actualizado ");
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
                    ControladorProveedor.Instance.save(proovedor);
                    MessageBox.Show("Proveedor Agregado");
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
            if (btn3.Text == "ELIMINAR")
            {
                proovedor proovedor = new proovedor();
                proovedor.Idproovedor = (int)Convert.ToInt64(txtcodigoproveedor.Text);
                try
                {
                    ControladorProveedor.Instance.delete(proovedor);
                    MessageBox.Show("Proovedor Eliminado");
                    Refrescar();
                    cargardg();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
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
            txtcodigoproveedor.Text = "";
            txtnombreempresa.Text = "";
            txtrtn.Text = "";
            txtcelular.Text = "";
            txtcorreo.Text = "";
            txtdireccion.Text = "";
            txtnombreencargado.Text = "";

        }

        private static ProveedoresVista fmrProveedoresVista = null;
        internal static ProveedoresVista Abrir1vez()
        {

            if (((fmrProveedoresVista == null) || (fmrProveedoresVista.IsDisposed == true)))
            {
                fmrProveedoresVista = new ProveedoresVista();
            }
            fmrProveedoresVista.BringToFront();
            return fmrProveedoresVista;
        }


        private void cargardg()
        {
            dgproveedor.Rows.Clear();
            List<proovedor> pro = new List<proovedor>();
            pro = ControladorProveedor.Instance.findAll();

            foreach (proovedor proovedor in pro)
            {

                //buscar el role por medio del idrole antes de ingresarlo
                dgproveedor.Rows.Add(proovedor.Idproovedor, proovedor.Nombre_empresa, proovedor.Rtn, proovedor.Celular, proovedor.Correo, proovedor.Direccion, proovedor.Nombre_encargado);
            }





        }

        private void dgproveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigoproveedor.Text = dgproveedor.CurrentRow.Cells[0].Value.ToString();
            txtnombreempresa.Text = dgproveedor.CurrentRow.Cells[1].Value.ToString();
            txtrtn.Text = dgproveedor.CurrentRow.Cells[2].Value.ToString();
            txtcelular.Text = dgproveedor.CurrentRow.Cells[3].Value.ToString();
            txtcorreo.Text = dgproveedor.CurrentRow.Cells[4].Value.ToString();
            txtdireccion.Text = dgproveedor.CurrentRow.Cells[5].Value.ToString();
            txtnombreencargado.Text = dgproveedor.CurrentRow.Cells[6].Value.ToString();
        }
    }


}
