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
    public partial class PantallaPrincipal : Form
    {
       
        public PantallaPrincipal()
        {
            InitializeComponent();
           
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            lblnombredesucural.Text=Globales.nombresucursallbl;
            //Aqui obtenemos todos los datos de la sucursal 
            sucursales sucursal = new sucursales();
            sucursal = ControladorSucursal.Instance.find();

            Globales.sucursalnombre = sucursal.Nombresucursal;
            Globales.sucursaldireccion = sucursal.Direccion;
            Globales.sucursalcelular = sucursal.Celular;
            Globales.sucursalcorreo = sucursal.Correo;
            Globales.sucursalrtn = sucursal.Rtn;
            Globales.sucursalcai = sucursal.Cai;
            Globales.sucursalfechaemisionfactura = sucursal.Fecha_emision.ToString("dd-MM-yyyy");
            Globales.sucursalrangodesde = sucursal.Rangodesde;
            Globales.sucursalrangohasta = sucursal.Rangohasta;
            Globales.sucursalfacturarconcai = sucursal.Facturarconcai;

            if (Globales.sucursalfacturarconcai == true)
            {
                int lastIndex = Globales.sucursalrangodesde.LastIndexOf('-');
                if (lastIndex != -1 && lastIndex < Globales.sucursalrangodesde.Length - 1)
                {
                    string primeraParte = Globales.sucursalrangodesde.Substring(0, lastIndex);
                    Globales.primerapartenumerofacturacai = primeraParte;
                    string ultimosDigitosStr = Globales.sucursalrangodesde.Substring(lastIndex + 1);
                    if (int.TryParse(ultimosDigitosStr, out int ultimosDigitos))
                    {
                        int longitudstring = ultimosDigitosStr.Length;
                        int diferenciadeespacios = longitudstring; // Usar la longitud total de la parte del string después del último guion
                        Globales.sucursalnumerofacturacai = ultimosDigitos.ToString().PadLeft(diferenciadeespacios, '0');

                        //for (int x = 0; x < 5; x++)
                        //{
                        //    Globales.sucursalnumerofacturacai = (ultimosDigitos + x).ToString().PadLeft(diferenciadeespacios, '0');
                        //    MessageBox.Show(Globales.sucursalnumerofacturacai);
                        //}
                    }
                    else
                    {
                        MessageBox.Show("No se puede obtener Datos para Facturacion con CAI, por favor contacta al Administrador");
                    }
                }
            }
           


            Globales.fecha = dtfecha.Value.ToString("yyyy-MM-dd");
            //aqui obtenemos los datos necesario para continuar con la autentificacion
            usuarios usuarios = new usuarios();
            usuarios = ControladorUsuario.Instance.findidbynombre(Globales.nombreusuario);
            Globales.idusuario = (int)usuarios.Idusuario;

            roles roles = new roles();
            roles = ControladorRoles.Instance.findrolebynombreusuario(Globales.nombreusuario);
            Globales.idroleusuario = (int)roles.Idrole;


            // Después de iniciar sesión, obtén los permisos de pantalla del usuario
            List<pantallas> pantallasUsuario = new List<pantallas>();
            pantallasUsuario = ControladorPantallas.Instance.findAllpermisos((int)roles.Idrole);
            // Almacena los nombres de las pantallas en la clase Globales
            // Asegúrate de que se hayan obtenido datos
            if (pantallasUsuario != null && pantallasUsuario.Any())
            {
                // Almacena los nombres de las pantallas en la clase Globales
                Globales.PermisosPantalla = pantallasUsuario.Select(p => p.Nombrepantalla).ToList();
                // Utiliza la función global para habilitar o deshabilitar los botones según los permisos de pantalla del usuario
                Globales.HabilitarBotonesSegunPermisos(this);
            }
            else
            {
                // Si no se obtuvieron datos, muestra un mensaje de error o toma alguna otra acción apropiada
                MessageBox.Show("No se han encontrado permisos de pantalla para este usuario.");
            }





            //if (roles.Roles != "Admin")
            //{
            //    btnCUreportes.Enabled = false;
            //    btnCUempleado.Enabled = false;
            //    btnCUcompras.Enabled = false;
            //    btnProveedoresVista.Enabled = false;


            //}



        }
      
        private void btnconfiguraaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnCUconfiguraciones_Click_1(object sender, EventArgs e)
        {
            panelContenedor1.Controls.Clear();
            CUconfiguraciones CUconfiguraciones = new CUconfiguraciones();
            CUconfiguraciones.Dock = DockStyle.Fill;
            panelContenedor1.Controls.Add(CUconfiguraciones);

        }

        private void btnClienteVista_Click(object sender, EventArgs e)
        {/*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            ClienteVista ClienteVista = null;
            ClienteVista = ClienteVista.Abrir1vez();
            ClienteVista.Show();
        }

        private void btnCUcaja_Click(object sender, EventArgs e)
        {
            panelContenedor1.Controls.Clear();
            CUcaja CUcaja = new CUcaja();
            CUcaja.Dock = DockStyle.Fill;
            panelContenedor1.Controls.Add(CUcaja);
        }

        private void Facturaciosvista_Click(object sender, EventArgs e)
        {
            panelContenedor1.Controls.Clear();
            Facturaciosvista FacturaciosVista = new Facturaciosvista();
            FacturaciosVista.TopLevel = false;
            panelContenedor1.Controls.Add(FacturaciosVista);
            FacturaciosVista.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FacturaciosVista.Dock = DockStyle.Fill;
            FacturaciosVista.Show();




        }

        

        private void btnCUreportes_Click(object sender, EventArgs e)
        {
            panelContenedor1.Controls.Clear();
            CUreportes CUreportes = new CUreportes();
            CUreportes.Dock = DockStyle.Fill;
            panelContenedor1.Controls.Add(CUreportes);
             
        }

        private void btnProveedoresVista_Click(object sender, EventArgs e)
        {


            /*Abrimos el formulario metodo pero en la vistametodo creamos una funcion Abrir1vez()
            que permite abrir el formulario solo 1 vez*/
            ProveedoresVista ProveedoresVista = null;
            ProveedoresVista = ProveedoresVista.Abrir1vez();
            ProveedoresVista.Show();


        }

        private void btnCUcompras_Click(object sender, EventArgs e)
        {
            panelContenedor1.Controls.Clear();
            CUcompras CUcompras = new CUcompras();
            CUcompras.Dock = DockStyle.Fill;
            panelContenedor1.Controls.Add(CUcompras);
        }

        private void btnCUInventario_Click(object sender, EventArgs e)
        {
            panelContenedor1.Controls.Clear();
            CUInventario CUInventario = new CUInventario();
            CUInventario.Dock = DockStyle.Fill;
            panelContenedor1.Controls.Add(CUInventario);
        }

        private void btnCUempleado_Click(object sender, EventArgs e)
        {
            PantallaPrincipal PantallaPrincipal = (PantallaPrincipal)Application.OpenForms["PantallaPrincipal"];
            PantallaPrincipal.panelContenedor1.Controls.Clear();
            CUempleado CUempleado = new CUempleado();
            CUempleado.Dock = DockStyle.Fill;
            PantallaPrincipal.panelContenedor1.Controls.Add(CUempleado);
        }
    }
    
}
