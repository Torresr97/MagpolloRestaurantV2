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
using System.Data.SqlClient;
using AppTRchicken.Utilidades;
using System.Globalization;

namespace AppTRchicken.Vista
{
    public partial class menuvistaconfigVista : Form
    {
        private Dictionary<int, string> categoriasDict;
        private Dictionary<int, string> complementosDict;

        public menuvistaconfigVista()
        {
            InitializeComponent();
            categoriasDict = new Dictionary<int, string>();
            complementosDict = new Dictionary<int, string>();
        }


        private void CargarDiccionario()
        {
            List<categoria_menu> listaCategorias = ControladorCategoriaMenu.Instance.findAll();
            foreach (var categoria in listaCategorias)
            {
                categoriasDict[categoria.Idcategoriamenu] = categoria.Nombrecategoria;
            }

            List<tipocomplemento_plato> tipocomplemento_plato = Controladortipocomplemento_plato.Instance.findAll();
            foreach (var complemento in tipocomplemento_plato)
            {
                // Cambia complemento.Idcomplementos_plato por complemento.Idtipocomplemento_plato
                complementosDict[(int)complemento.Idtipocomplemento_plato] = complemento.Nombretipocomplemento_plato;
            }

        }





        private void menuvista_Load(object sender, EventArgs e)
        {
            CargarDiccionario();
            cargardg();
            cargarcomboboxcategoria();
            Cargarcomboboxtipocomplementos();

        }

        private void Refrescar()
        {
           
            btn1.Enabled = true;
            btn2.Text = "ACTUALIZAR";
            btn3.Text = "ELIMINAR";
            txtcodigomenu.Text = "";
            txtnombrecombo.Text = "";
            txtdescripcioncombo.Text = "";
            txtpreciocombo.Text = "";
            cbcategoria.Text = "";
            cbtipocomplemento.Text = "";
            txtNcomplementos.Text = "";

        }


        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "NUEVO")
            {
                txtcodigomenu.Text = "";
                txtnombrecombo.Text = "";
                txtdescripcioncombo.Text = "";
                txtpreciocombo.Text = "";

                cargarcomboboxcategoria();
                Cargarcomboboxtipocomplementos();






                btn1.Enabled = false;
                btn2.Text = "GUARDAR";
                btn3.Text = "CANCELAR";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            
            menu.Nombrecombo = txtnombrecombo.Text;
            menu.Descripcion = txtdescripcioncombo.Text;
            menu.Precio = Globales.ConvertToDecimal(txtpreciocombo.Text);
            menu.Idcategoria = (int)Convert.ToInt64(cbcategoria.SelectedValue);
            string nombreCategoria = cbcategoria.Text;
            // Buscar el ID de la categoría usando el nombre en el diccionario
            int idCategoria = categoriasDict.FirstOrDefault(x => x.Value.Equals(nombreCategoria, StringComparison.OrdinalIgnoreCase)).Key;
            if (idCategoria != 0)
            {
                menu.Idcategoria = idCategoria;
            }
            else
            {
                // Manejar el caso en que el nombre de la categoría no se encuentra en el diccionario
                MessageBox.Show("Categoría no encontrada.");
                return; // Opcional: detener el proceso si no se encuentra la categoría
            }

            menu.Ncomplemento = (int)Convert.ToInt64(txtNcomplementos.Text);

            string nombreTipoComplemento = cbtipocomplemento.Text;
            // Buscar el ID del tipo de complemento usando el nombre en el diccionario
            int idTipoComplemento = complementosDict.FirstOrDefault(x => x.Value.Equals(nombreTipoComplemento, StringComparison.OrdinalIgnoreCase)).Key;
            if (idTipoComplemento != 0)
            {
                menu.Idtipocomplemento = idTipoComplemento;
            }
            else
            {
                // Manejar el caso en que el nombre del tipo de complemento no se encuentra en el diccionario
                MessageBox.Show("Tipo de complemento no encontrado.");
                return; // Opcional: detener el proceso si no se encuentra el tipo de complemento
            }



            if (btn2.Text == "ACTUALIZAR")
            {
                menu.Idmenu = (int)Convert.ToInt64(txtcodigomenu.Text);


                try
                {
                    ControladorMenu.Instance.update(menu);
                    MessageBox.Show("Menu Actualizado");
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
                    ControladorMenu.Instance.save(menu);
                    MessageBox.Show("Menu Agregado");
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
                menu menu = new menu();
                menu.Idmenu = (int)Convert.ToInt64(txtcodigomenu.Text);
                try
                {
                    ControladorMenu.Instance.delete(menu);
                    MessageBox.Show("Menu Eliminado");
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

        private static menuvistaconfigVista fmrmenuvista = null;
        internal static menuvistaconfigVista Abrir1vez()
        {
            if (((fmrmenuvista == null) || (fmrmenuvista.IsDisposed == true)))
            {
                fmrmenuvista = new menuvistaconfigVista();
            }
            fmrmenuvista.BringToFront();
            return fmrmenuvista;
        }


        private void cargarcomboboxcategoria()
        {
            // Limpia los ítems del combobox antes de llenarlo
            cbcategoria.Items.Clear();

            // Recorrer el diccionario y agregar los elementos al ComboBox
            foreach (var categoria in categoriasDict)
            {
                cbcategoria.Items.Add(new { Text = categoria.Value, Value = categoria.Key });
            }

            // Establece las propiedades DisplayMember y ValueMember para el ComboBox
            cbcategoria.DisplayMember = "Text";
            cbcategoria.ValueMember = "Value";


        }

        private void Cargarcomboboxtipocomplementos()
        {
            // Limpia los ítems del combobox antes de llenarlo
            cbtipocomplemento.Items.Clear();

            // Recorrer el diccionario de tipos de complemento y agregar los elementos al ComboBox
            foreach (var tipoComplemento in complementosDict)
            {
                cbtipocomplemento.Items.Add(new { Text = tipoComplemento.Value, Value = tipoComplemento.Key });
            }

            // Establece las propiedades DisplayMember y ValueMember para el ComboBox
            cbtipocomplemento.DisplayMember = "Text";
            cbtipocomplemento.ValueMember = "Value";
        }


        private void cargardg()
        {
            // Limpia el DataGridView antes de llenarlo
            dgmenu.Rows.Clear();

            // Obtener todos los menús
            List<menu> m = ControladorMenu.Instance.findAll();

            // Iterar sobre la lista de menús
            foreach (menu men in m)
            {
                // Obtener el nombre de la categoría desde el diccionario, utilizando el Idcategoria
                string nombreCategoria = categoriasDict.ContainsKey(men.Idcategoria) ? categoriasDict[men.Idcategoria] : "Categoría no encontrada";

                // Obtener el nombre del tipo de complemento desde el diccionario, utilizando el Idtipocomplemento
                string nombreTipoComplemento = complementosDict.ContainsKey((int)men.Idtipocomplemento) ? complementosDict[(int)men.Idtipocomplemento] : "Tipo complemento no encontrado";

                // Agregar la fila al DataGridView
                dgmenu.Rows.Add(men.Idmenu, men.Nombrecombo, men.Descripcion, men.Precio.ToString("N2", CultureInfo.InvariantCulture), nombreCategoria, men.Ncomplemento, nombreTipoComplemento);
            }
        }
      

        private void dgmenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigomenu.Text = dgmenu.CurrentRow.Cells[0].Value.ToString();
            txtnombrecombo.Text = dgmenu.CurrentRow.Cells[1].Value.ToString();
            txtdescripcioncombo.Text = dgmenu.CurrentRow.Cells[2].Value.ToString();
            txtpreciocombo.Text = dgmenu.CurrentRow.Cells[3].Value.ToString();
            cbcategoria.Text = dgmenu.CurrentRow.Cells[4].Value.ToString();
            txtNcomplementos.Text = dgmenu.CurrentRow.Cells[5].Value.ToString();
            cbtipocomplemento.Text = dgmenu.CurrentRow.Cells[6].Value.ToString();
        }
    }
    }
