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
    public partial class CUcompras : UserControl
    {
        public CUcompras()
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

        private void btnCompraVista_Click(object sender, EventArgs e)
        {

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
           que permite abrir el formulario solo 1 vez*/
            CompraVista Compravista = null;
            Compravista = CompraVista.Abrir1vez();
            Compravista.Show();

        }

        private void btnTipocompraVista_Click(object sender, EventArgs e)
        {
            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
           que permite abrir el formulario solo 1 vez*/
            TipocompraVista TipocompraVista = null;
            TipocompraVista = TipocompraVista.Abrir1vez();
            TipocompraVista.Show();



        }
    }
}
