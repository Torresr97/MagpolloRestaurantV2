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
    public partial class impresoraVista : Form
    {
        public impresoraVista()
        {
            InitializeComponent();
        }

        private void impresoraVista_Load(object sender, EventArgs e)
        {
            List<impresoras> imp = new List<impresoras>();
            imp = ControladorImpresora.Instance.findAll();
            foreach (impresoras impresora in imp)
            {
                dgimpresora.Rows.Add(impresora.Idimpresora, impresora.Nombreimpresora, impresora.Ticktes);
            }
        }

        private void dgimpresora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigoimpresora.Text = dgimpresora.CurrentRow.Cells[0].Value.ToString();
            txtnombreimpresora.Text = dgimpresora.CurrentRow.Cells[1].Value.ToString();
            txtcantidadtickets.Text = dgimpresora.CurrentRow.Cells[2].Value.ToString();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "ACTUALIZAR")
            {
                impresoras impresoras = new impresoras();
                impresoras.Idimpresora = Convert.ToInt64(txtcodigoimpresora.Text);
                impresoras.Nombreimpresora = txtnombreimpresora.Text;
                impresoras.Ticktes = Convert.ToInt32(txtcantidadtickets.Text);


                try
                {
                    ControladorImpresora.Instance.update(impresoras);
                    MessageBox.Show("Impresora Actualizada");
                    Refrescar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void Refrescar()
        {

            txtcodigoimpresora.Text = "";
            txtnombreimpresora.Text = "";
            txtcantidadtickets.Text = "";
            dgimpresora.Rows.Clear();

            List<impresoras> imp = new List<impresoras>();
            imp = ControladorImpresora.Instance.findAll();
            foreach (impresoras impresora in imp)
            {
                dgimpresora.Rows.Add(impresora.Idimpresora, impresora.Nombreimpresora, impresora.Ticktes);
            }

        }
    }
}
