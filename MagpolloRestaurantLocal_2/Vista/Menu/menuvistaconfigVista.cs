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



namespace AppTRchicken.Vista
{
    public partial class menuvistaconfigVista : Form
    {
        public menuvistaconfigVista()
        {
            InitializeComponent();
        }




      

        

        private void menuvista_Load(object sender, EventArgs e)
        {
            cargardg();
            cargarcomboboxcategoria();
            Cargarcomboboxtipocomplementos();


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
            menu.Precio = Convert.ToDecimal(txtpreciocombo.Text);
            menu.Idcategoria = (int)Convert.ToInt64(cbcategoria.SelectedValue);
            menu.Ncomplemento = (int)Convert.ToInt64(txtNcomplementos.Text);

            tipocomplemento_plato tipocomplemento_plato = new tipocomplemento_plato();
            tipocomplemento_plato = Controladortipocomplemento_plato.Instance.findIdbyname(cbtipocomplemento.Text);
            menu.Idtipocomplemento = tipocomplemento_plato.Idtipocomplemento_plato;



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
            SqlDataAdapter da = new SqlDataAdapter("SELECT idcategoriamenu,nombrecategoria FROM categoria_menu", Conexion.getInstance().getconexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbcategoria.DataSource = dt;
            cbcategoria.DisplayMember = "nombrecategoria";
            cbcategoria.ValueMember = "idcategoriamenu";


        }

        private void Cargarcomboboxtipocomplementos()
        {
            cbtipocomplemento.DataSource = Controladortipocomplemento_plato.Instance.Cargarcomboxtipocomplemento();
            cbtipocomplemento.DisplayMember = "nombrecomplemento_plato";
            cbtipocomplemento.ValueMember = "idtipocomplemento_plato";
        }


        private void cargardg()
        {
            dgmenu.Rows.Clear();
            List<menu> m = new List<menu>();
            m = ControladorMenu.Instance.findAll();

            foreach (menu men in m)
            {
                categoria_menu categoria = new categoria_menu();
                categoria = (categoria_menu)ControladorCategoriaMenu.Instance.find((int)Convert.ToInt64(men.Idcategoria));

                tipocomplemento_plato tipocomplemento_plato = new tipocomplemento_plato();
                tipocomplemento_plato = Controladortipocomplemento_plato.Instance.findnamebyID(men.Idtipocomplemento);
                //buscar el role por medio del idrole antes de ingresarlo
                dgmenu.Rows.Add(men.Idmenu, men.Nombrecombo, men.Descripcion, men.Precio, categoria.Nombrecategoria, men.Ncomplemento, tipocomplemento_plato.Nombretipocomplemento_plato);
            }




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





        }

        private void dgmenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigomenu.Text = dgmenu.CurrentRow.Cells[0].Value.ToString();
            txtnombrecombo.Text = dgmenu.CurrentRow.Cells[1].Value.ToString();
            txtdescripcioncombo.Text = dgmenu.CurrentRow.Cells[2].Value.ToString();
            txtpreciocombo.Text = dgmenu.CurrentRow.Cells[3].Value.ToString();
            cbcategoria.Text = dgmenu.CurrentRow.Cells[4].Value.ToString();
            txtNcomplementos.Text = dgmenu.CurrentRow.Cells[5].Value.ToString();
        }
    }
    }
