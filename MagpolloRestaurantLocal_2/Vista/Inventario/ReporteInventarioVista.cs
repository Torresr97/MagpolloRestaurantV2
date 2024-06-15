using AppTRchicken.Controlador;
using AppTRchicken.Modelo;
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

namespace AppTRchicken.Vista.Inventario
{
    public partial class ReporteInventarioVista : Form
    {
        public ReporteInventarioVista()
        {
            InitializeComponent();
        }


        private void ReporteInventarioVista_Load(object sender, EventArgs e)
        {
           
            cargardg();
        }


        private static ReporteInventarioVista fmrReporteInventarioVista = null;
        internal static ReporteInventarioVista Abrir1vez()
        {
            if (((fmrReporteInventarioVista == null) || (fmrReporteInventarioVista.IsDisposed == true)))
            {
                fmrReporteInventarioVista = new ReporteInventarioVista();
            }
            fmrReporteInventarioVista.BringToFront();
            return fmrReporteInventarioVista;
        }

        private void cargardg()
        {
            dgreporteinventario.Rows.Clear();
            List<inventario> inv = new List<inventario>();
            inv = ControladorInventario.Instance.findAll();

            foreach (inventario inventario in inv)
            {


                //se obtiene el nombre del proovedor por medio del id del proovedor

                dgreporteinventario.Rows.Add(inventario.Idinventario, inventario.Nombreproducto, inventario.Existencia);
            }


        }

        private void btntodos_Click(object sender, EventArgs e)
        {
            try
            {
  
                    sucursales sucursal = new sucursales();
                    sucursal = ControladorSucursal.Instance.find();

                    impresoras impresoras = new impresoras();
                    impresoras = ControladorImpresora.Instance.findconfig();


                    CrearTicket ticket = new CrearTicket();
                    ticket.AbreCajon();//Para abrir el cajon de dinero.//Datos de la cabecera del Ticket.
                    
                    ticket.TextoCentro(sucursal.Nombresucursal);
                    ticket.TextoCentro(sucursal.Direccion);
                    ticket.TextoIzquierda("Cajero:" + Globales.nombreusuario);
                    ticket.TextoIzquierda(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString());
                ticket.lineasGuion();
                ticket.TextoCentro("REPORTE INVENTARIO");
                ticket.TextoIzquierda(" ");

                ticket.EncabezadoReporteinventario();
                ticket.TextoIzquierda(" ");
                foreach (DataGridViewRow row in dgreporteinventario.Rows)
                    {

                        if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                        {
                            

                        //AgregaArticulo(int cant, string articulo, decimal total)


                        ticket.Agregarinventario(row.Cells[1].Value.ToString(), Convert.ToInt32(row.Cells[2].Value));
                    }
                    }


                ticket.TextoIzquierda(" ");
                ticket.TextoIzquierda(" ");
                ticket.TextoIzquierda(" ");
                ticket.TextoIzquierda(" ");
                ticket.TextoIzquierda(" ");
                ticket.CortaTicket(); 
                ticket.ImprimirTicket(impresoras.Nombreimpresora);//Nombre de la impresora ticketera
                //ticket.ImprimirTicket(impresoras.Nombreimpresora);//Nombre de la impresora ticketera
                    this.Close();
                
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
