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
using AppTRchicken.Modelo;
using AppTRchicken.Vista.Menu;

namespace AppTRchicken.Vista.Configuraciones_Generales
{
    public partial class CUmenuconfig : UserControl
    {
        public CUmenuconfig()
        {
            InitializeComponent();
            panelmenuconfig.Dock = DockStyle.Fill;
            Globales.HabilitarBotonesSegunPermisos(this);
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            PantallaPrincipal PantallaPrincipal = new PantallaPrincipal();
            PantallaPrincipal = (PantallaPrincipal)this.FindForm();
            PantallaPrincipal.panelContenedor1.Controls.Clear();
            CUconfiguraciones CUconfiguraciones = new CUconfiguraciones();
            CUconfiguraciones.Dock = DockStyle.Fill;
            PantallaPrincipal.panelContenedor1.Controls.Add(CUconfiguraciones);
        }

        private void btnmenuvistaconfigVista_Click(object sender, EventArgs e)
        {

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            menuvistaconfigVista menuvista = null;
            menuvista = menuvistaconfigVista.Abrir1vez();
            menuvista.Show();
        }

        private void btncategoriamenuconfigVista_Click(object sender, EventArgs e)
        {

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            categoriamenuconfigVista categoriamenuVista = null;
            categoriamenuVista = categoriamenuconfigVista.Abrir1vez();
            categoriamenuVista.Show();
        }

        private void btnComplementos_platoconfigVista_Click(object sender, EventArgs e)
        {

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            Complementos_platoconfigVista Complementos_platoVista = null;
            Complementos_platoVista = Complementos_platoconfigVista.Abrir1vez();
            Complementos_platoVista.Show();
        }

        private void btntipocomplemento_platoVista_Click(object sender, EventArgs e)
        {
            tipocomplemento_platoVista tipocomplemento_platoVista = null;
            tipocomplemento_platoVista = tipocomplemento_platoVista.Abrir1vez();
            tipocomplemento_platoVista.Show();


                }


    }
}
