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
using AppTRchicken.Vista.Prueba_Vistas;

namespace AppTRchicken.Vista
{
    public partial class CUcaja : UserControl
    {
        public CUcaja()
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

        private void btnDepositoVista_Click(object sender, EventArgs e)
        {
            
            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            DepositoVista DepositoVista = null;
            DepositoVista = DepositoVista.Abrir1vez();
            DepositoVista.Show();
        }

        private void btnRetiroVista_Click(object sender, EventArgs e)
        {

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            RetiroVista RetiroVista = null;
            RetiroVista = RetiroVista.Abrir1vez();
            RetiroVista.Show();

        }

        private void btnCierreVista_Click(object sender, EventArgs e)
        {
 

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            CierreVista CierreVista = null;
            CierreVista = CierreVista.Abrir1vez();
            CierreVista.Show();
        }

       

        private void btnMovimientosVista_Click(object sender, EventArgs e)
        {
            
            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
           que permite abrir el formulario solo 1 vez*/
            MovimientosVista MovimientosVista = null;
            MovimientosVista = MovimientosVista.Abrir1vez();
            MovimientosVista.Show();
        }

        private void btnplanilla_Click(object sender, EventArgs e)
        {

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
         que permite abrir el formulario solo 1 vez*/
            EmpleadoVistas Empleados = null;
            Empleados = EmpleadoVistas.Abrir1vez();
            Empleados.Show();

        }

        private void btnDeduccionxempleadoVista_Click(object sender, EventArgs e)
        {
            DeduccionxempleadoVista DeduccionxempleadoVista = null;
            DeduccionxempleadoVista = DeduccionxempleadoVista.Abrir1vez();
            DeduccionxempleadoVista.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
           que permite abrir el formulario solo 1 vez*/
            CierreVistaApp CierreVistaApp = null;
            CierreVistaApp = CierreVistaApp.Abrir1vez();
            CierreVistaApp.Show();
        }
    }
    }

