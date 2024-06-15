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
    public partial class usuariovista : Form
    {
        public usuariovista()
        {
            InitializeComponent();
        }

        private void usuariovista_Load(object sender, EventArgs e)
        {

            cbroleusuario.DataSource = ControladorRoles.Instance.Cargarcomboxroles();
            cbroleusuario.DisplayMember = "role";
            cbroleusuario.ValueMember = "idrole";
         cargardg();
        }

        private void dgusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigousuario.Text = dgusuarios.CurrentRow.Cells[0].Value.ToString();
            txtnombreusuario.Text = dgusuarios.CurrentRow.Cells[1].Value.ToString();
            txtapellidousuario.Text = dgusuarios.CurrentRow.Cells[2].Value.ToString();
            txtcontrausuario.Text = dgusuarios.CurrentRow.Cells[3].Value.ToString();
            cbroleusuario.Text = dgusuarios.CurrentRow.Cells[4].Value.ToString();
            dtfechacreacionusuario.Value = DateTime.Parse(dgusuarios.CurrentRow.Cells[5].Value.ToString());
        }

        private void btn1_Click(object sender, EventArgs e)
        {


            if (btn1.Text == "NUEVO")
            {
                txtcodigousuario.Text = "";
                txtnombreusuario.Text = "";
                txtapellidousuario.Text = "";
                txtcontrausuario.Text = "";

                cbroleusuario.DataSource = ControladorRoles.Instance.Cargarcomboxroles();
                cbroleusuario.DisplayMember = "role";
                cbroleusuario.ValueMember = "idrole";
                dtfechacreacionusuario.Value = DateTime.Now;






                btn1.Enabled = false;
                btn2.Text = "GUARDAR";
                btn3.Text = "CANCELAR";
            }
        }

        private static usuariovista fmrusuariovista = null;
        internal static usuariovista Abrir1vez()
        {
            if (((fmrusuariovista == null) || (fmrusuariovista.IsDisposed == true)))
            {
                fmrusuariovista = new usuariovista();
            }
            fmrusuariovista.BringToFront();
            return fmrusuariovista;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            usuarios usuarios = new usuarios();
            usuarios.Nombre = txtnombreusuario.Text;
            usuarios.Apellido = txtapellidousuario.Text;
            usuarios.Contrasena = ControladorUsuario.Encriptar(txtcontrausuario.Text);
            usuarios.Idrole = Convert.ToInt64(cbroleusuario.SelectedValue);
            usuarios.Fecha_de_creacion = dtfechacreacionusuario.Value;




            if (btn2.Text == "ACTUALIZAR")
            {
                usuarios.Idusuario = Convert.ToInt64(txtcodigousuario.Text);


                try
                {
                    ControladorUsuario.Instance.update(usuarios);
                    MessageBox.Show("Usuarios Actualizados ");
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
                    ControladorUsuario.Instance.save(usuarios);
                    MessageBox.Show("Usuarios Agregado");
                    Refrescar();
                    cargardg();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
    
        }

        private void cargardg() {
            dgusuarios.Rows.Clear();
            List<usuarios> usr = new List<usuarios>();
            usr = ControladorUsuario.Instance.findAll();

            foreach (usuarios usuario in usr)
            {
                roles roles = new roles();

                roles = ControladorRoles.Instance.find(Convert.ToInt64(usuario.Idrole));

                //buscar el role por medio del idrole antes de ingresarlo
                dgusuarios.Rows.Add(usuario.Idusuario, usuario.Nombre, usuario.Apellido, usuario.Contrasena ,roles.Roles, usuario.Fecha_de_creacion.ToString("dd/MM/yyyy hh:mm tt"));
            }


        }
        private void Refrescar()
        {
            btn1.Enabled = true;
            btn2.Text = "ACTUALIZAR";
            btn3.Text = "ELIMINAR";
            txtcodigousuario.Text = "";
            txtnombreusuario.Text = "";
            txtapellidousuario.Text = "";
            txtcontrausuario.Text = "";
            

           


        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (btn3.Text == "ELIMINAR")
            {
                usuarios usuarios = new usuarios();
                usuarios.Idusuario= Convert.ToInt64(txtcodigousuario.Text);
                try
                {
                    ControladorUsuario.Instance.delete(usuarios);
                    MessageBox.Show("Usuario Eliminado");
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
