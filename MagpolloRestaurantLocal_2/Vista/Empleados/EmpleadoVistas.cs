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
using AppTRchicken.Utilidades;

namespace AppTRchicken.Vista
{
    public partial class EmpleadoVistas : Form
    {
        public EmpleadoVistas()
        {
            InitializeComponent();
        }



        private void PlanillaVista_Load(object sender, EventArgs e)
        {
            List<empleados> emp = new List<empleados>();
            emp = ControladorEmpleados.Instance.findAll();
            foreach (empleados empleado in emp)
            {
                dgempleados.Rows.Add(empleado.Idempleado, empleado.Nombreempleado, empleado.Identidad, empleado.Fechaingreso.ToString("yyyy-MM-dd"), empleado.Sueldomensual, empleado.Sueldoquincenal, empleado.Estado);
            }
        }

        private void dgempleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodempleado.Text = dgempleados.CurrentRow.Cells[0].Value.ToString();
            txtnombreempleado.Text = dgempleados.CurrentRow.Cells[1].Value.ToString();
            txtidentidad.Text = dgempleados.CurrentRow.Cells[2].Value.ToString();
            txtsueldomensual.Text = dgempleados.CurrentRow.Cells[4].Value.ToString();
            txtsueldoquincenal.Text = dgempleados.CurrentRow.Cells[5].Value.ToString();
            cbestadoempleado.Text = dgempleados.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "NUEVO")
            {
                txtcodempleado.Text = "";
                txtnombreempleado.Text = "";
                txtidentidad.Text = "";
                txtsueldomensual.Text = "";
                txtsueldoquincenal.Text = "";
                cbestadoempleado.Text = "";


                btn1.Text = "GUARDAR";
                btn2.Text = "CANCELAR";

            }
            else
            if (btn1.Text == "GUARDAR")
            {

                if (txtnombreempleado.Text == "" || txtsueldomensual.Text == "" || txtsueldoquincenal.Text == "" || cbestadoempleado.Text == "" || txtidentidad.Text == "")
                {
                    MessageBox.Show("Faltan Datos por Llenar");
                }
                else
                {
                    empleados empleados = new empleados();

                    empleados.Nombreempleado = txtnombreempleado.Text;
                    empleados.Identidad = txtidentidad.Text;
                    empleados.Fechaingreso = Convert.ToDateTime(Globales.fecha);
                    empleados.Sueldomensual = Convert.ToDecimal(txtsueldomensual.Text);
                    empleados.Sueldoquincenal = Convert.ToDecimal(txtsueldoquincenal.Text);
                    empleados.Estado = cbestadoempleado.Text;


                    try
                    {
                        ControladorEmpleados.Instance.save(empleados);
                        MessageBox.Show("Empleado Ingresado");
                        Refrescar();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            if (btn1.Text == "CANCELAR")
            {

                Refrescar();
            }
        }

        public void Refrescar()
        {
            txtcodempleado.Text = "";
            txtnombreempleado.Text = "";
            txtidentidad.Text = "";
           
            txtsueldomensual.Text = "";
            txtsueldoquincenal.Text = "";
            cbestadoempleado.Text = "";

            dgempleados.Rows.Clear();
            List<empleados> emp = new List<empleados>();
            emp = ControladorEmpleados.Instance.findAll();
            foreach (empleados empleado in emp)
            {
                dgempleados.Rows.Add(empleado.Idempleado, empleado.Nombreempleado,empleado.Identidad, empleado.Fechaingreso.ToString("yyyy-MM-dd"), empleado.Sueldomensual, empleado.Sueldoquincenal, empleado.Estado);
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "ACTUALIZAR")
            {
                empleados empleados = new empleados();
                empleados.Idempleado = (int)Convert.ToInt64(txtcodempleado.Text);
                empleados.Nombreempleado = txtnombreempleado.Text;
                empleados.Identidad = txtidentidad.Text;
                empleados.Sueldomensual = Convert.ToDecimal(txtsueldomensual.Text);
                empleados.Sueldoquincenal = Convert.ToDecimal(txtsueldoquincenal.Text);
                empleados.Estado = cbestadoempleado.Text;

                try
                {
                    ControladorEmpleados.Instance.update(empleados);
                    MessageBox.Show("Empleado Actualizado");
                    Refrescar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }




            }
            else if (btn2.Text == "CANCELAR")
            {
                btn1.Text = "NUEVO";
                btn2.Text = "ACTUALIZAR";
                Refrescar();
            }


        }

        private void txtsueldomensual_TextChanged(object sender, EventArgs e)
        {
            if (txtsueldomensual.Text == "")
            {

                txtsueldomensual.Text = "0";
            }
            else
            {


                txtsueldoquincenal.Text = (Convert.ToDecimal(txtsueldomensual.Text) / 2).ToString();
            }
        }



        private static EmpleadoVistas fmrEmpleados = null;
        internal static EmpleadoVistas Abrir1vez()
        {
            if (((fmrEmpleados == null) || (fmrEmpleados.IsDisposed == true)))
            {
                fmrEmpleados = new EmpleadoVistas();
            }
            fmrEmpleados.BringToFront();
            return fmrEmpleados;
        }


    }
}



