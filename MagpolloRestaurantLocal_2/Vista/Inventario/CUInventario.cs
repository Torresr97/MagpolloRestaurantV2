using AppTRchicken.Vista.Inventario;
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

namespace AppTRchicken.Vista
{
    public partial class CUInventario : UserControl
    {
        public CUInventario()
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

        private void btnInventarioVista_Click(object sender, EventArgs e)
        {
            

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            InventarioVista InventarioVista = null;
            InventarioVista = InventarioVista.Abrir1vez();
            InventarioVista.Show();
        }

        private void btnEntradainventarioVista_Click(object sender, EventArgs e)
        {

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            EntradainventarioVista Entradainventario = null;
            Entradainventario = EntradainventarioVista.Abrir1vez();
            Entradainventario.Show();

        }

        private void btnConfiguracioninventarioVista_Click(object sender, EventArgs e)
        {
            ConfiguracioninventarioVista ConfiguracioninventarioViata = new ConfiguracioninventarioVista();
            ConfiguracioninventarioViata = ConfiguracioninventarioVista.Abrir1vez();
            ConfiguracioninventarioViata.Show();
        }

        private void btnReporteInventarioVista_Click(object sender, EventArgs e)
        {
            ReporteInventarioVista ReporteInventarioVista = new ReporteInventarioVista();
            ReporteInventarioVista = ReporteInventarioVista.Abrir1vez();
            ReporteInventarioVista.Show();
        }

        private void panelconfiguraciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntradainventariomasivoVista_Click(object sender, EventArgs e)
        {
            EntradainventariomasivoVista EntradainventariomasivoVista = new EntradainventariomasivoVista();
            EntradainventariomasivoVista = EntradainventariomasivoVista.Abrir1vez();
            EntradainventariomasivoVista.Show();
        }
    }
}
