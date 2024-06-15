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
    public partial class Complementos_platoconfigVista : Form
    {
        public Complementos_platoconfigVista()
        {
            InitializeComponent();
        }

        private void Complementos_platoVista_Load(object sender, EventArgs e)
        {

            cargardg();
            Cargarcombobox();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "NUEVO")
            {
                txtidcomplementoplato.Text = "";
                txtnombrecomplemento.Text = "";

                btn1.Enabled = false;
                btn2.Text = "GUARDAR";
                btn3.Text = "CANCELAR";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tipocomplemento_plato tipocomplemento_plato = new tipocomplemento_plato();
            tipocomplemento_plato = Controladortipocomplemento_plato.Instance.findIdbyname(cbtipocomplemento.Text);

            complementos_plato complementos_plato = new complementos_plato();
            complementos_plato.Nombre_complementosplato = txtnombrecomplemento.Text;
            complementos_plato.Idtipocomplemento_plato = tipocomplemento_plato.Idtipocomplemento_plato;

             



            if (btn2.Text == "ACTUALIZAR")
            {
                complementos_plato.Idcomplementos_plato = Convert.ToInt64(txtidcomplementoplato.Text);


                try
                {
                    ControladorComplementosPlato.Instance.update(complementos_plato);
                    MessageBox.Show("Complemento Actualizado");
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
                    ControladorComplementosPlato.Instance.save(complementos_plato);
                    MessageBox.Show("Complemento Agregado");
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
                complementos_plato complementos_plato = new complementos_plato();
                complementos_plato.Idcomplementos_plato = Convert.ToInt64(txtidcomplementoplato.Text);
                try
                {
                    ControladorComplementosPlato.Instance.delete(complementos_plato);
                    MessageBox.Show("Complemento Eliminado");
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
            txtidcomplementoplato.Text = "";
            txtnombrecomplemento.Text = "";
            dgcomplementosplato.Rows.Clear();



        }

        private void Cargarcombobox()
        {
            cbtipocomplemento.DataSource = Controladortipocomplemento_plato.Instance.Cargarcomboxtipocomplemento();
            cbtipocomplemento.DisplayMember = "nombrecomplemento_plato";
            cbtipocomplemento.ValueMember = "idtipocomplemento_plato";
        }

        private void cargardg()
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            dgcomplementosplato.Rows.Clear();
            List<complementos_plato> cp = new List<complementos_plato>();
            cp = ControladorComplementosPlato.Instance.findAll();
            foreach (complementos_plato complato in cp)
            {
                tipocomplemento_plato tipocomplemento_plato = new tipocomplemento_plato();
                tipocomplemento_plato = Controladortipocomplemento_plato.Instance.findnamebyID(complato.Idtipocomplemento_plato);


                dgcomplementosplato.Rows.Add(complato.Idcomplementos_plato, complato.Nombre_complementosplato, tipocomplemento_plato.Nombretipocomplemento_plato);
            }
        }

        

        private static Complementos_platoconfigVista fmrComplementos_platoVista = null;
        internal static Complementos_platoconfigVista Abrir1vez()
        {
            if (((fmrComplementos_platoVista == null) || (fmrComplementos_platoVista.IsDisposed == true)))
            {
                fmrComplementos_platoVista = new Complementos_platoconfigVista();
            }
            fmrComplementos_platoVista.BringToFront();
            return fmrComplementos_platoVista;
        }



        private void dgcomplementosplato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidcomplementoplato.Text = dgcomplementosplato.CurrentRow.Cells[0].Value.ToString();
            txtnombrecomplemento.Text = dgcomplementosplato.CurrentRow.Cells[1].Value.ToString();
        }
    }
}