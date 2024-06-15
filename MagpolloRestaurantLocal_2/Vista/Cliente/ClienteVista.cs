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
    public partial class ClienteVista : Form
    {
        public ClienteVista()
        {
            InitializeComponent();
        }

        private void ClienteVista_Load(object sender, EventArgs e)
        {
            List<Cliente> usr = new List<Cliente>();
            usr = ControladorCliente.Instance.findAll();
            foreach (Cliente cliente in usr)
            {
                dgclientes.Rows.Add(cliente.Idcliente, cliente.Nombre, cliente.Rtn, cliente.Celular, cliente.Correo);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "NUEVO")
            {
                txtidcliente.Text = "";
                txtnombrecliente.Text = "";
                txtrtncliente.Text = "";
                txtcelularcliente.Text = "";
                txtcorreocliente.Text = "";

                btn1.Enabled = false;
                btn2.Text = "GUARDAR";
                btn3.Text = "CANCELAR";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = txtnombrecliente.Text;
            cliente.Rtn = txtrtncliente.Text;
            cliente.Celular = txtcelularcliente.Text;
            cliente.Correo = txtcorreocliente.Text;


            if (btn2.Text == "ACTUALIZAR")
            {
                cliente.Idcliente = Convert.ToInt64(txtidcliente.Text);


                try
                {
                    ControladorCliente.Instance.update(cliente);
                    MessageBox.Show("Cliente Actualizado");
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
                    ControladorCliente.Instance.save(cliente);
                    MessageBox.Show("Cliente Agregado");
                    Refrescar();
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
                Cliente cliente = new Cliente();
                cliente.Idcliente = Convert.ToInt64(txtidcliente.Text);
                try
                {
                    ControladorCliente.Instance.delete(cliente);
                    MessageBox.Show("Cliente Eliminado");
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

        private static ClienteVista fmrClienteVista = null;
        internal static ClienteVista Abrir1vez()
        {

            if (((fmrClienteVista == null) || (fmrClienteVista.IsDisposed == true)))
            {
                fmrClienteVista = new ClienteVista();
            }
            fmrClienteVista.BringToFront();
            return fmrClienteVista;
        }


        private void Refrescar()
        {
            btn1.Enabled = true;
            btn2.Text = "ACTUALIZAR";
            btn3.Text = "ELIMINAR";
            txtidcliente.Text = "";
            txtnombrecliente.Text = "";
            txtrtncliente.Text = "";
            txtcelularcliente.Text = "";
            txtcorreocliente.Text = "";
            dgclientes.Rows.Clear();

            List<Cliente> usr = new List<Cliente>();
            usr = ControladorCliente.Instance.findAll();
            foreach (Cliente cliente in usr)
            {
                dgclientes.Rows.Add(cliente.Idcliente, cliente.Nombre, cliente.Rtn, cliente.Celular, cliente.Correo);
            }

        }

        private void dgclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidcliente.Text = dgclientes.CurrentRow.Cells[0].Value.ToString();
            txtnombrecliente.Text = dgclientes.CurrentRow.Cells[1].Value.ToString();
            txtrtncliente.Text = dgclientes.CurrentRow.Cells[2].Value.ToString();
            txtcelularcliente.Text = dgclientes.CurrentRow.Cells[3].Value.ToString();
            txtcorreocliente.Text = dgclientes.CurrentRow.Cells[4].Value.ToString();

        }
    }
}
