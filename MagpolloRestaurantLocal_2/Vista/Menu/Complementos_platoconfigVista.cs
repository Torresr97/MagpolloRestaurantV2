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
        private Dictionary<long, tipocomplemento_plato> tipocomplementoPlatoDict;
        public Complementos_platoconfigVista()
        {
            InitializeComponent();
            tipocomplementoPlatoDict = new Dictionary<long, tipocomplemento_plato>();
        }

        private void Complementos_platoVista_Load(object sender, EventArgs e)
        {
            CargarComplementoPlatoDiccionario();
            cargardg();
            Cargarcombobox();
        }
        private void CargarComplementoPlatoDiccionario()
        {
            List<tipocomplemento_plato> tipocomplemento_platos = Controladortipocomplemento_plato.Instance.findAll();
            tipocomplementoPlatoDict.Clear(); // Asegúrate de limpiar el diccionario antes de cargar los nuevos valores.

            foreach (var complemento in tipocomplemento_platos)
            {
                tipocomplementoPlatoDict[complemento.Idtipocomplemento_plato] = complemento;
            }
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
            long idTipoComplementoPlatoSeleccionado = (long)cbtipocomplemento.SelectedValue;
          

            complementos_plato complementos_plato = new complementos_plato();
            complementos_plato.Nombre_complementosplato = txtnombrecomplemento.Text;
            complementos_plato.Idtipocomplemento_plato = idTipoComplementoPlatoSeleccionado;

             



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

            // Cargar el ComboBox directamente desde el diccionario
            cbtipocomplemento.DataSource = tipocomplementoPlatoDict.Values.ToList();  // Convertimos los valores del diccionario a lista
            cbtipocomplemento.DisplayMember = "nombretipocomplemento_plato"; // Nombre que se mostrará en el ComboBox
            cbtipocomplemento.ValueMember = "Idtipocomplemento_plato"; // ID que se usará como valor
        }

        private void cargardg()
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            dgcomplementosplato.Rows.Clear();

            // Primero, asegúrate de haber cargado el diccionario
            CargarComplementoPlatoDiccionario();

            // Obtener los complementos del plato
            List<complementos_plato> cp = ControladorComplementosPlato.Instance.findAll();

            // Rellenar el DataGridView
            foreach (complementos_plato complato in cp)
            {
                // Verificar si el Idtipocomplemento_plato existe en el diccionario
                if (tipocomplementoPlatoDict.TryGetValue(complato.Idtipocomplemento_plato, out var complementoPlato))
                {
                    dgcomplementosplato.Rows.Add(complato.Idcomplementos_plato, complato.Nombre_complementosplato, complementoPlato.Nombretipocomplemento_plato);
                }
                else
                {
                    // Si no se encuentra el complemento, puedes agregar un valor por defecto
                    dgcomplementosplato.Rows.Add(complato.Idcomplementos_plato, complato.Nombre_complementosplato, "Complemento desconocido");
                }
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




        private void dgcomplementosplato_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtidcomplementoplato.Text = dgcomplementosplato.CurrentRow.Cells[0].Value.ToString();
            txtnombrecomplemento.Text = dgcomplementosplato.CurrentRow.Cells[1].Value.ToString();
            cbtipocomplemento.Text = dgcomplementosplato.CurrentRow.Cells[2].Value.ToString();
        }
    }
}