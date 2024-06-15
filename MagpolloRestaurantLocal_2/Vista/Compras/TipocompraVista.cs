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
    public partial class TipocompraVista : Form
    {
        public TipocompraVista()
        {
            InitializeComponent();
        }

        private void TipocompraVista_Load(object sender, EventArgs e)
        {
            cargardg();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "NUEVO")
            {
                txtcodigotipocompra.Text = "";
                txtnombretipocompra.Text = "";
                txtnombretipocompra.Focus();


                btn1.Enabled = false;
                btn2.Text = "GUARDAR";
                btn3.Text = "CANCELAR";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tipo_compra tipo_compra = new tipo_compra();
            tipo_compra.Nombretipocompra = txtnombretipocompra.Text;
            if (btn2.Text == "ACTUALIZAR")
            {
                tipo_compra.Idtipocompra = Convert.ToInt64(txtcodigotipocompra.Text);


                try
                {
                    ControladorTipo_Compra.Instance.update(tipo_compra);
                    MessageBox.Show("Tipo de Compra Actualizada ");
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
                    ControladorTipo_Compra.Instance.save(tipo_compra);
                    MessageBox.Show("Tipo de Compra Agregada");
                    Refrescar();
                    cargardg();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private static TipocompraVista fmrTipocompraVista = null;
        internal static TipocompraVista Abrir1vez()
        {
            if (((fmrTipocompraVista == null) || (fmrTipocompraVista.IsDisposed == true)))
            {
                fmrTipocompraVista = new TipocompraVista();
            }
            fmrTipocompraVista.BringToFront();
            return fmrTipocompraVista;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "ELIMINAR")
            {
                tipo_compra tipo_compra = new tipo_compra();
                tipo_compra.Idtipocompra = Convert.ToInt64(txtcodigotipocompra.Text);
                try
                {
                    ControladorTipo_Compra.Instance.delete(tipo_compra);
                    MessageBox.Show("Tipo de Compra Eliminada");
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
            txtcodigotipocompra.Text = "";
            txtnombretipocompra.Text = "";


        }

        private void cargardg()
        {
            dgtipocompra.Rows.Clear();
            List<tipo_compra> tc = new List<tipo_compra>();
            tc = ControladorTipo_Compra.Instance.findAll();

            foreach (tipo_compra tipo_compra in tc)
            {


                //buscar el role por medio del idrole antes de ingresarlo
                dgtipocompra.Rows.Add(tipo_compra.Idtipocompra, tipo_compra.Nombretipocompra);
            }


        }

      

        private void dgtipocompra_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigotipocompra.Text = dgtipocompra.CurrentRow.Cells[0].Value.ToString();
            txtnombretipocompra.Text = dgtipocompra.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
