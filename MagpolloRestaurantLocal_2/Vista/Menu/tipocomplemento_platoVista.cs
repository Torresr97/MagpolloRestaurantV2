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

namespace AppTRchicken.Vista.Menu
{
    public partial class tipocomplemento_platoVista : Form
    {
        public tipocomplemento_platoVista()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "NUEVO")
            {
                txtidtipocomplementoplato.Text = "";
                txtnombretipocomplementoplato.Text = "";

                btn1.Enabled = false;
                btn2.Text = "GUARDAR";
                btn3.Text = "CANCELAR";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tipocomplemento_plato tipocomplemento_plato = new tipocomplemento_plato();
            tipocomplemento_plato.Nombretipocomplemento_plato = txtnombretipocomplementoplato.Text;


            if (btn2.Text == "ACTUALIZAR")
            {
                tipocomplemento_plato.Idtipocomplemento_plato = Convert.ToInt64(txtidtipocomplementoplato.Text);


                try
                {
                    Controladortipocomplemento_plato.Instance.update(tipocomplemento_plato);
                    MessageBox.Show("Tipo Complemento Actualizado");
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
                    Controladortipocomplemento_plato.Instance.save(tipocomplemento_plato);
                    MessageBox.Show("Tipo Complemento Agregado");
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
            //    complementos_plato complementos_plato = new complementos_plato();
            //    complementos_plato.Idcomplementos_plato = Convert.ToInt64(txtidcomplementoplato.Text);
            //    try
            //    {
            //        ControladorComplementosPlato.Instance.delete(complementos_plato);
            //        MessageBox.Show("Complemento Eliminado");
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
            txtidtipocomplementoplato.Text = "";
            txtnombretipocomplementoplato.Text = "";
            dgtipocomplementosplato.Rows.Clear();



        }
        private void cargardg()
        {

            List<tipocomplemento_plato> tcp = new List<tipocomplemento_plato>();
            tcp = Controladortipocomplemento_plato.Instance.findAll();
            foreach (tipocomplemento_plato complato in tcp)
            {
                dgtipocomplementosplato.Rows.Add(complato.Idtipocomplemento_plato, complato.Nombretipocomplemento_plato);
            }
        }


        private static tipocomplemento_platoVista fmrtipocomplemento_platoVista = null;
        internal static tipocomplemento_platoVista Abrir1vez()
        {
            if (((fmrtipocomplemento_platoVista == null) || (fmrtipocomplemento_platoVista.IsDisposed == true)))
            {
                fmrtipocomplemento_platoVista = new tipocomplemento_platoVista();
            }
            fmrtipocomplemento_platoVista.BringToFront();
            return fmrtipocomplemento_platoVista;
        }

        private void dgtipocomplementosplato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidtipocomplementoplato.Text = dgtipocomplementosplato.CurrentRow.Cells[0].Value.ToString();
            txtnombretipocomplementoplato.Text = dgtipocomplementosplato.CurrentRow.Cells[1].Value.ToString();
        }

        private void tipocomplemento_platoVista_Load(object sender, EventArgs e)
        {
            cargardg();
        }
    }
}
