using AppTRchicken.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTRchicken.Vista
{
    public partial class CUempleado : UserControl
    {
        public CUempleado()
        {
            InitializeComponent();
            Globales.HabilitarBotonesSegunPermisos(this);
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {


            PantallaPrincipal PantallaPrincipal = new PantallaPrincipal();
            PantallaPrincipal = (PantallaPrincipal)this.FindForm();
            PantallaPrincipal.panelContenedor1.Controls.Clear();
            PantallaPrincipal.panelmenu.Dock = DockStyle.Fill;

            PantallaPrincipal.panelContenedor1.Controls.Add(PantallaPrincipal.panelmenu);

        }

        private void btnEmpleadoVistas_Click(object sender, EventArgs e)
        {
            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
           que permite abrir el formulario solo 1 vez*/
            EmpleadoVistas Empleados = null;
            Empleados = EmpleadoVistas.Abrir1vez();
            Empleados.Show();
        }

        private void btnPagodePlanillaVista_Click(object sender, EventArgs e)
        {
            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
          que permite abrir el formulario solo 1 vez*/
            PagodePlanillaVista PagodePlanillaVista = null;
            PagodePlanillaVista = PagodePlanillaVista.Abrir1vez();
            PagodePlanillaVista.Show();
        }

        private void panelconfiguraciones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
