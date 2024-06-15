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
    public partial class CompraVista : Form
    {
        public CompraVista()
        {
            InitializeComponent();
            
        }

      





        public void cargarcbtipocarnes()
        {
            cbtipocompra.DataSource = ControladorTipo_Compra.Instance.findAll();
            cbtipocompra.DisplayMember = "nombretipocompra";
            cbtipocompra.ValueMember = "idtipocompra";

        }
        public void cargarproovedores()
        {
            cbproveedor.DataSource = ControladorProveedor.Instance.findAll();
            cbproveedor.DisplayMember = "nombre_empresa";
            cbproveedor.ValueMember = "idproovedor";

        }

       










        private void Refrescar()
        {
            btn1.Enabled = true;
            btn2.Text = "ACTUALIZAR";
            btn3.Text = "ELIMINAR";
            txtcodigocompra.Text = "";
            txtnombrecompra.Text = "";
            cbproveedor.Text = "";
            cbtipocompra.Text = "";
            dtfechacompra.Text = "";

        }

       
        private void cargardg()
        {
            dgnuevacompra.Rows.Clear();
            List<Compra> com = new List<Compra>();
            com = ControladorCompra.Instance.findAll();

            foreach (Compra compra in com)
            {
                //se obtiene el nombre del tipo de compra por medio de id 
                tipo_compra tipo_compra = new tipo_compra();
                tipo_compra = ControladorTipo_Compra.Instance.findnombrenyid((int)compra.Idtipocompra);

                //se obtiene el nombre del proovedor por medio del id del proovedor
                proovedor proovedor = new proovedor();
                proovedor = ControladorProveedor.Instance.findnombrenyid((int)compra.Idproovedor);
                dgnuevacompra.Rows.Add(compra.Idcompra, compra.Nombre_compra, tipo_compra.Nombretipocompra, proovedor.Nombre_empresa, compra.Total, compra.Fecha);
            }


        }


       
   

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "NUEVO")
            {



                txtcodigocompra.Text = "";
                txtnombrecompra.Text = "";
                cargarcbtipocarnes();
                cargarproovedores();
                txttotal.Text = "";


                btn1.Enabled = false;
                btn2.Text = "GUARDAR";
                btn3.Text = "CANCELAR";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            compra.Nombre_compra = txtnombrecompra.Text;
            compra.Idtipocompra = Convert.ToInt64(cbtipocompra.SelectedValue);
            compra.Idproovedor = Convert.ToInt64(cbproveedor.SelectedValue);
            compra.Total = Convert.ToDecimal(txttotal.Text);
            compra.Fecha = dtfechacompra.Value.ToString("yyyy-MM-dd");




            if (btn2.Text == "ACTUALIZAR")
            {
                compra.Idcompra = Convert.ToInt64(txtcodigocompra.Text);


                try
                {
                    ControladorCompra.Instance.update(compra);
                    MessageBox.Show("Compra Actualizada ");
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
                    ControladorCompra.Instance.save(compra);
                    MessageBox.Show("Compra Agregada");
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
                Compra compra = new Compra();
                compra.Idcompra = Convert.ToInt64(txtcodigocompra.Text);
                try
                {
                    ControladorCompra.Instance.delete(compra);
                    MessageBox.Show("Compra Eliminada");
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

        private void Compravista_Load(object sender, EventArgs e)
        {
            

            cargardg();
            cargarcbtipocarnes();
            cargarproovedores();
        }

        private void dgnuevacompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigocompra.Text = dgnuevacompra.CurrentRow.Cells[0].Value.ToString();
            txtnombrecompra.Text = dgnuevacompra.CurrentRow.Cells[1].Value.ToString();
            cbtipocompra.Text = dgnuevacompra.CurrentRow.Cells[2].Value.ToString();
            cbproveedor.Text = dgnuevacompra.CurrentRow.Cells[3].Value.ToString();
            txttotal.Text = dgnuevacompra.CurrentRow.Cells[4].Value.ToString();
            dtfechacompra.Text = dgnuevacompra.CurrentRow.Cells[5].Value.ToString();
        }


        private static CompraVista fmrCompravista = null;
        internal static CompraVista Abrir1vez()
        {
            if (((fmrCompravista == null) || (fmrCompravista.IsDisposed == true)))
            {
                fmrCompravista = new CompraVista();
            }
            fmrCompravista.BringToFront();
            return fmrCompravista;
        }



    }
}
