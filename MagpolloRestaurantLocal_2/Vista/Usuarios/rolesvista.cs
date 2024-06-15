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
    public partial class rolesvista : Form
    {
        public rolesvista()
        {
            InitializeComponent();
        }

        private void rolesvista_Load(object sender, EventArgs e)
        {
            List<roles> usr = new List<roles>();
            usr = ControladorRoles.Instance.findAll();
            foreach (roles role in usr)
            {
                dgroles.Rows.Add(role.Idrole, role.Roles, role.Crear, role.Actualizar, role.Eliminar);
            }
        }

        private void dgroles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidrole.Text = dgroles.CurrentRow.Cells[0].Value.ToString();
            txtnombrerole.Text = dgroles.CurrentRow.Cells[1].Value.ToString();

            bool vcbcrear = (bool)dgroles.CurrentRow.Cells[2].Value;
            if (vcbcrear == true) {
                cbcrear.Checked = true;

            } else
            {
                cbcrear.Checked = false;
            }

            bool vcbactua = (bool)dgroles.CurrentRow.Cells[3].Value;
            if (vcbactua == true)
            {
                cbactualizar.Checked = true;

            }
            else
            {
                cbactualizar.Checked = false;
            }

            bool vcbeliminar = (bool)dgroles.CurrentRow.Cells[4].Value;
            if (vcbeliminar == true)
            {
                cbeliminar.Checked = true;

            }
            else
            {
                cbeliminar.Checked = false;
            }

        }

        private void btnbotonguardarrole_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "NUEVO")
            {
                txtidrole.Text = "";
                txtnombrerole.Text = "";
                cbcrear.Checked = false;
                cbactualizar.Checked = false;
                cbeliminar.Checked = false;

                btn1.Enabled = false;
                btn2.Text = "GUARDAR";
                btn3.Text = "CANCELAR";
            }



        }

        private static rolesvista fmrrolesvista = null;
        internal static rolesvista Abrir1vez()
        {
            if (((fmrrolesvista == null) || (fmrrolesvista.IsDisposed == true)))
            {
                fmrrolesvista = new rolesvista();
            }
            fmrrolesvista.BringToFront();
            return fmrrolesvista;
        }



        private void btn2_Click(object sender, EventArgs e)
        {
            roles roles = new roles();
           
            roles.Roles = txtnombrerole.Text;
            roles.Crear = cbcrear.Checked;
            roles.Actualizar = cbactualizar.Checked;
            roles.Eliminar = cbeliminar.Checked;


            if (btn2.Text == "ACTUALIZAR")
            {
                roles.Idrole = Convert.ToInt64(txtidrole.Text);
               

                try
                {
                    ControladorRoles.Instance.update(roles);
                    MessageBox.Show("Roles Actualizados correctamente");
                    Refrescar();
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
                    ControladorRoles.Instance.save(roles);
                    MessageBox.Show("Roles Agregado correctamente");
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
            btn1.Enabled = true;
            btn2.Text = "ACTUALIZAR";
            btn3.Text = "ELIMINAR";
            txtidrole.Text = "";
            txtnombrerole.Text = "";
            dgroles.Rows.Clear();

            List<roles> usr = new List<roles>();
            usr = ControladorRoles.Instance.findAll();
            foreach (roles role in usr)
            {
                dgroles.Rows.Add(role.Idrole, role.Roles,role.Crear,role.Actualizar,role.Eliminar);

            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (btn3.Text == "ELIMINAR")
            {
                roles roles = new roles();
                roles.Idrole = Convert.ToInt64(txtidrole.Text);
                try
                {
                    ControladorRoles.Instance.delete(roles);
                    MessageBox.Show("Roles Eliminado correctamente");
                    Refrescar();
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
