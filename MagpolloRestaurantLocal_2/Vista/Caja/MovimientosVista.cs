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
    public partial class MovimientosVista : Form
    { int Vnumerocierre = 0;
        public MovimientosVista()
        {
            InitializeComponent();
        }

        private void Movimientos_Load(object sender, EventArgs e)
        {  /*aqui averigua cual es el numero de grupo a cerrar*/
            usuarios usuarios = new usuarios();
            usuarios = ControladorUsuario.Instance.findidbynombre(Globales.nombreusuario);
            Globales.idusuario = (int)usuarios.Idusuario;
            roles roles = new roles();
            roles = ControladorRoles.Instance.findrolebynombreusuario(Globales.nombreusuario);
            if (roles.Roles != "cajero")
            {
                // Ocultar la cuarta columna (índice 3)
                dgmovimientos.Columns[5].Visible = true;

            }else
            {
                // Ocultar la cuarta columna (índice 3)
                dgmovimientos.Columns[5].Visible = false;
            }


            facturas numerocierre = new facturas();
            numerocierre = ControladorFacturas.Instance.Findnumerocierre(Globales.fecha);
            Vnumerocierre = numerocierre.Numerocierre;
            cbtipomovimiento.Items.Add("Deposito");
            cbtipomovimiento.Items.Add("Retiro");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
            dgmovimientos.Rows.Clear();
            List<caja> caja = new List<caja>();

            char delimitador = ' ';
            caja = ControladorCaja.Instance.Registrosxtipoxfechaxcierre(cbtipomovimiento.Text, Globales.fecha, Vnumerocierre);
    
            foreach (caja cajas in caja)
            {

                string[] fechasinhora = cajas.Fecha.Split(delimitador);
                //buscar el role por medio del idrole antes de ingresarlo
                dgmovimientos.Rows.Add(cajas.Idcaja,cajas.Tipo, cajas.Motivo, cajas.Totalefectivo, fechasinhora[0]);

            }

            int total = 0;
            for (int x = 0; x < dgmovimientos.Rows.Count; ++x)
            {
                total += Convert.ToInt32(dgmovimientos.Rows[x].Cells["Total"].Value);
                txttotal.Text = String.Format("{0:n0}", total);
            }

        }

        private static MovimientosVista fmrMovimientosVista = null;
        internal static MovimientosVista Abrir1vez()
        {
            if (((fmrMovimientosVista == null) || (fmrMovimientosVista.IsDisposed == true)))
            {
                fmrMovimientosVista = new MovimientosVista();
            }
            fmrMovimientosVista.BringToFront();
            return fmrMovimientosVista;
        }

        private void dgmovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5)  //Dónde la columna con el botón es la 6 con posición 5
            {
               


               
                try
                {
                    DialogResult result = MessageBox.Show("Esta Seguro de Eliminar este Movimiento de CAJA?", "Eliminar Movimiento", MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            caja caja = new caja();
                            caja.Idcaja = Convert.ToInt32(dgmovimientos.Rows[dgmovimientos.CurrentRow.Index].Cells["idcaja"].Value);
                            ControladorCaja.Instance.delete(caja);
                            // Eliminar la fila del DataGridView
                            dgmovimientos.Rows.RemoveAt(dgmovimientos.CurrentRow.Index);
                            MessageBox.Show("Movimiento de Caja Eliminado" );
                          
                            break;
                        case DialogResult.No:
                            MessageBox.Show("Cancelado");
                            break;

                    }
                    //ControladorFacturas.Instance.delete(facturas);


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            }
    }
}
