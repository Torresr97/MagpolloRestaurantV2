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
using AppTRchicken.Controlador;
using AppTRchicken.Modelo;
using AppTRchicken.Vista.Configuraciones_Generales;

namespace AppTRchicken.Vista
{
    public partial class CUconfiguraciones : UserControl
    {
        public CUconfiguraciones()
        {
            InitializeComponent();
            panelconfiguraciones.Dock = DockStyle.Fill;
            Globales.HabilitarBotonesSegunPermisos(this);

        }



        private void btnregresar_Click_1(object sender, EventArgs e)
        {
            PantallaPrincipal PantallaPrincipal = new PantallaPrincipal();
            PantallaPrincipal = (PantallaPrincipal)this.FindForm();
            PantallaPrincipal.panelContenedor1.Controls.Clear();
            PantallaPrincipal.panelmenu.Dock = DockStyle.Fill;

            PantallaPrincipal.panelContenedor1.Controls.Add(PantallaPrincipal.panelmenu);
        }

        private void btnusuariovista_Click(object sender, EventArgs e)
        {

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            usuariovista usuariovista = null;
            usuariovista = usuariovista.Abrir1vez();
            usuariovista.Show();
        }

        private void btnrolesvista_Click(object sender, EventArgs e)
        {


            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            rolesvista rolesvista = null;
            rolesvista = rolesvista.Abrir1vez();
            rolesvista.Show();

        }

        private void btncategoria_Click(object sender, EventArgs e)
        {



            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            categoriamenuconfigVista categoriamenuVista = null;
            categoriamenuVista = categoriamenuconfigVista.Abrir1vez();
            categoriamenuVista.Show();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            menuvistaconfigVista menuvista = null;
            menuvista = menuvistaconfigVista.Abrir1vez();
            menuvista.Show();
        }

        private void btnDatosGeneralesVista_Click(object sender, EventArgs e)
        {


            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            DatosGeneralesVista DatosGeneralesVista = null;
            DatosGeneralesVista = DatosGeneralesVista.Abrir1vez();
            DatosGeneralesVista.Show();
        }

        private void btncomplementoplato_Click(object sender, EventArgs e)
        {


            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            Complementos_platoconfigVista Complementos_platoVista = null;
            Complementos_platoVista = Complementos_platoconfigVista.Abrir1vez();
            Complementos_platoVista.Show();
        }

        private void btnpanelcontrolVista_Click(object sender, EventArgs e)
        {

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            panelcontrolVista panelcontrolVista = null;
            panelcontrolVista = panelcontrolVista.Abrir1vez();
            panelcontrolVista.Show();
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {

            PantallaPrincipal PantallaPrincipal = (PantallaPrincipal)Application.OpenForms["PantallaPrincipal"];
            PantallaPrincipal.panelContenedor1.Controls.Clear();
            CUempleado CUempleado = new CUempleado();
            CUempleado.Dock = DockStyle.Fill;
            PantallaPrincipal.panelContenedor1.Controls.Add(CUempleado);

        }



        private void btnmenuconfig_Click(object sender, EventArgs e)
        {
            PantallaPrincipal PantallaPrincipal = (PantallaPrincipal)Application.OpenForms["PantallaPrincipal"];
            PantallaPrincipal.panelContenedor1.Controls.Clear();
            CUmenuconfig CUmenuconfig = new CUmenuconfig();
            CUmenuconfig.Dock = DockStyle.Fill;
            PantallaPrincipal.panelContenedor1.Controls.Add(CUmenuconfig);

        }

        private void btnpermisospantallaVista_Click(object sender, EventArgs e)
        {

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            permisospantallaVista permisospantallaVista = null;
            permisospantallaVista = permisospantallaVista.Abrir1vez();
            permisospantallaVista.Show();
        }
    }
}
