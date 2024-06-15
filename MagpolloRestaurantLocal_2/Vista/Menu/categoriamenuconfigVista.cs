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
    public partial class categoriamenuconfigVista : Form
    {
        public categoriamenuconfigVista()
        {
            InitializeComponent();
        }

        private void categoriamenu_Load(object sender, EventArgs e)
        {
            cargardg();

        }



        private void Refrescar()
        {
            btn1.Enabled = true;
            btn2.Text = "ACTUALIZAR";
            btn3.Text = "ELIMINAR";
            txtcodigocategoria.Text = "";
            txtnombrecategoria.Text = "";





        }
        private void cargardg()
        {
            dgcategoriamenu.Rows.Clear();
          
            List<categoria_menu> catm = new List<categoria_menu>();
            catm = ControladorCategoriaMenu.Instance.findAll();

            foreach (categoria_menu categoriaMenu in catm)
            {
                categoria_menu categoria_menu = new categoria_menu();

               
                //buscar el role por medio del idrole antes de ingresarlo
                dgcategoriamenu.Rows.Add(categoriaMenu.Idcategoriamenu, categoriaMenu.Nombrecategoria);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "NUEVO")
            {
                txtcodigocategoria.Text = "";
                txtnombrecategoria.Text = "";

                btn1.Enabled = false;
                btn2.Text = "GUARDAR";
                btn3.Text = "CANCELAR";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            categoria_menu categoria_menu = new categoria_menu();
            categoria_menu.Nombrecategoria = txtnombrecategoria.Text;

            if (btn2.Text == "ACTUALIZAR")
            {

                categoria_menu.Idcategoriamenu = (int)Convert.ToInt64(txtcodigocategoria.Text);


                try
                {
                    ControladorCategoriaMenu.Instance.update(categoria_menu);
                    MessageBox.Show("Categoria Actualizada ");
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
                    ControladorCategoriaMenu.Instance.save(categoria_menu);
                    MessageBox.Show("Categoria Agregado");
                    Refrescar();
                    cargardg();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private static categoriamenuconfigVista fmrcategoriamenuVista = null;
        internal static categoriamenuconfigVista Abrir1vez()
        {
            if (((fmrcategoriamenuVista == null) || (fmrcategoriamenuVista.IsDisposed == true)))
            {
                fmrcategoriamenuVista = new categoriamenuconfigVista();
            }
            fmrcategoriamenuVista.BringToFront();
            return fmrcategoriamenuVista;
        }



        private void dgcategoriamenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigocategoria.Text = dgcategoriamenu.CurrentRow.Cells[0].Value.ToString();
            txtnombrecategoria.Text = dgcategoriamenu.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "ELIMINAR")
            {
                categoria_menu categoria_menu = new categoria_menu();
                categoria_menu.Idcategoriamenu = (int)Convert.ToInt64(txtcodigocategoria.Text);
                try
                {
                    ControladorCategoriaMenu.Instance.delete(categoria_menu);
                    MessageBox.Show("Categoria Eliminado");
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
    }
    }

