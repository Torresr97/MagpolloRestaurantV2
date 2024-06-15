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
    public partial class CierreVista : Form
    {

      
        public CierreVista()
        {
            InitializeComponent();
           
        }
        int totaldeposito = 0;
        int totalretiro = 0;
        int totalefectivocajero = 0;
        int totalefectivosistema = 0;
        int totaltarjetacajero = 0;
        int totaltarjetasistema = 0;
       
        int n500,n200,n100,n50,n20,n10,n5,n2,n1;
       

        private void txt20_TextChanged(object sender, EventArgs e)
        {
            if (txt20.Text == "")
            {

                lbl20.Text = "0";
                totalefectivocajero -= n20;

                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();
                txt20.Text = "0";

            }
            else
            {


                lbl20.Text = (Convert.ToInt64(txt20.Text) * 20).ToString();

                totalefectivocajero += int.Parse(lbl20.Text);
                n20 = (int)totalefectivocajero;
                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();

            }
        }

        private void txt10_TextChanged(object sender, EventArgs e)
        {
            if (txt10.Text == "")
            {

                lbl10.Text = "0";
                totalefectivocajero -= n10;

                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();
                txt10.Text = "0";

            }
            else
            {


                lbl10.Text = (Convert.ToInt64(txt10.Text) * 10).ToString();

                totalefectivocajero += int.Parse(lbl10.Text);
                n10 = (int)totalefectivocajero;
                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();

            }
        }

        

        private void txt5_TextChanged(object sender, EventArgs e)
        {
            if (txt5.Text == "")
            {

                lbl5.Text = "0";
                totalefectivocajero -= n5;

                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();
                txt5.Text = "0";

            }
            else
            {


                lbl5.Text = (Convert.ToInt64(txt5.Text) * 5).ToString();

                totalefectivocajero += int.Parse(lbl5.Text);
                n5 = (int)totalefectivocajero;
                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();

            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (txt2.Text == "")
            {

                lbl2.Text = "0";
                totalefectivocajero -= n2;

                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();
                txt2.Text = "0";

            }
            else
            {


                lbl2.Text = (Convert.ToInt64(txt2.Text) * 2).ToString();

                totalefectivocajero += int.Parse(lbl2.Text);
                n2 = (int)totalefectivocajero;
                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();

            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {

                lbl1.Text = "0";
                totalefectivocajero -= n1;

                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();
                txt1.Text = "0";

            }
            else
            {


                lbl1.Text = (Convert.ToInt64(txt1.Text) * 1).ToString();

                totalefectivocajero += int.Parse(lbl1.Text);
                n1 = (int)totalefectivocajero;
                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();

            }
        }

        private void txt50_TextChanged(object sender, EventArgs e)
        {
            if (txt50.Text == "")
            {

                lbl50.Text = "0";
                totalefectivocajero -= n50;

                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();
                txt50.Text = "0";

            }
            else
            {


                lbl50.Text = (Convert.ToInt64(txt50.Text) * 50).ToString();

                totalefectivocajero += int.Parse(lbl50.Text);
                n50 = (int)totalefectivocajero;
                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();

            }
        }

        private void txttarjetacajero_TextChanged(object sender, EventArgs e)
        {
            if (txttarjetacajero.Text == "")
            {
                txttarjetacajero.Text = "0";
                txttotalventaseguncajero.Text = (int.Parse(txtefectivocajero.Text) + int.Parse(txttarjetacajero.Text)).ToString();
            }
            else
            {
                txttotalventaseguncajero.Text = (int.Parse(txtefectivocajero.Text) + int.Parse(txttarjetacajero.Text)).ToString();
            }
           
            //if (txttarjetasistema.Text == txttarjetacajero.Text)
            //{
            //    txttarjetacajero.BackColor = Color.Green;
            //}
            //else
            //{
            //    txttarjetacajero.BackColor = Color.Red;
            //}
        }

        private void txttotalventasegunsistema_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txttotalventaseguncajero_TextChanged(object sender, EventArgs e)
        {
            //if(txttotalventaseguncajero.Text == txttotalventasegunsistema.Text)
            //{
            //    btncierre.BackColor = Color.Green;
            //}
            //else
            //{
            //    btncierre.BackColor = Color.Red;
            //}
        }

        private void CierreVista_Load(object sender, EventArgs e)
        {
            /*Aqui se cumple la condicion si usuario no tiene el rol de admin no podra ver el total de ventas, tendra que hacer cierre a ciegas*/


            usuarios usuarios = new usuarios();
            usuarios = ControladorUsuario.Instance.findidbynombre(Globales.nombreusuario);
            Globales.idusuario = (int)usuarios.Idusuario;
            roles roles = new roles();
            roles = ControladorRoles.Instance.findrolebynombreusuario(Globales.nombreusuario);
            /*Si el usuario tiene rol de admin podra hacer el cierre viendo los totales*/
            if (roles.Roles != "cajero")
            {
                /*aqui averigua cual es el numero de grupo a cerrar*/
                facturas numerocierre = new facturas();
                numerocierre = ControladorFacturas.Instance.Findnumerocierre(Globales.fecha);
                Globales.numerocierre = numerocierre.Numerocierre;



                string Efectivo = "Efectivo";
                string Tarjeta = "Tarjeta";
                string Deposito = "Deposito";
                string Retiro = "Retiro";
                //trae toda las suma de ventas en efectivo

                facturas facturaefectivo = new facturas();
                facturaefectivo = ControladorFacturas.Instance.totalefectivofacturado(Globales.fecha, Efectivo, Globales.numerocierre);
                totalefectivosistema = (int)facturaefectivo.Total;
                txtefectivosistema.Text = totalefectivosistema.ToString() ;


                //trae toda las suma de ventas en tarjeta
                facturas facturatarjeta = new facturas();
                facturatarjeta = ControladorFacturas.Instance.totalefectivofacturado(Globales.fecha, Tarjeta, Globales.numerocierre);
                totaltarjetasistema = (int)facturatarjeta.Total;
                txttarjetasistema.Text = totaltarjetasistema.ToString();

               

                //trae toda la suma de depositos por fecha 
                caja deposito = new caja();
                deposito = ControladorCaja.Instance.totaldepositoycierre(Globales.fecha, Deposito, Globales.numerocierre);
                totaldeposito = (int)deposito.Totalefectivo;
                txtdeposito.Text = totaldeposito.ToString();
                //trae toda la suma de retiros por fecha
                caja retiro = new caja();
                retiro = ControladorCaja.Instance.totaldepositoycierre(Globales.fecha, Retiro, Globales.numerocierre);
                totalretiro = (int)retiro.Totalefectivo;
                txtretiro.Text = totalretiro.ToString();


                //hace los calculos correctos para tener el total efectivo despues de depositos y retiros
                txtefectivosistema.Text = ((totalefectivosistema + totaldeposito) - totalretiro).ToString();
                
                txttotalventasegunsistema.Text = (int.Parse(txtefectivosistema.Text) + int.Parse(txttarjetasistema.Text)).ToString();

            }
            else
            {
                /*aqui averigua cual es el numero de grupo a cerrar*/
                facturas numerocierre = new facturas();
                numerocierre = ControladorFacturas.Instance.Findnumerocierre(Globales.fecha);
                Globales.numerocierre = numerocierre.Numerocierre;



                string Efectivo = "Efectivo";
                string Tarjeta = "Tarjeta";
                string Deposito = "Deposito";
                string Retiro = "Retiro";
                //trae toda las suma de ventas en efectivo

                facturas facturaefectivo = new facturas();
                facturaefectivo = ControladorFacturas.Instance.totalefectivofacturado(Globales.fecha, Efectivo, Globales.numerocierre);
                totalefectivosistema = (int)facturaefectivo.Total;
               


                //trae toda las suma de ventas en tarjeta
                facturas facturatarjeta = new facturas();
                facturatarjeta = ControladorFacturas.Instance.totalefectivofacturado(Globales.fecha, Tarjeta, Globales.numerocierre);
                totaltarjetasistema = (int)facturatarjeta.Total;
               



                //trae toda la suma de depositos por fecha 
                caja deposito = new caja();
                deposito = ControladorCaja.Instance.totaldepositoycierre(Globales.fecha, Deposito, Globales.numerocierre);
                totaldeposito = (int)deposito.Totalefectivo;
               
                //trae toda la suma de retiros por fecha
                caja retiro = new caja();
                retiro = ControladorCaja.Instance.totaldepositoycierre(Globales.fecha, Retiro, Globales.numerocierre);
                totalretiro = (int)retiro.Totalefectivo;
               

               

            }
        }



            public void verificarefectivo()
        {
            //if (txtefectivocajero.Text == txtefectivosistema.Text)
            //{
            //    txtefectivocajero.BackColor = Color.Green;
            //}
            //else
            //{
            //    txtefectivocajero.BackColor = Color.Red;
            //}
        }

        public void verificartotales()
        {
            txttotalventaseguncajero.Text = (int.Parse(txtefectivocajero.Text) + int.Parse(txttarjetacajero.Text)).ToString();
        }

        public void verificartarjeta()
        {
            //if (txtefectivocajero.Text == txtefectivosistema.Text)
            //{
            //    txtefectivocajero.BackColor = Color.Green;
            //}
            //else
            //{
            //    txtefectivocajero.BackColor = Color.Red;
            //}
        }

      

        private void txtefectivocajero_TextChanged(object sender, EventArgs e)
        {
            txtefectivocajero.Text = (int.Parse(lbl500.Text) + int.Parse(lbl200.Text) + int.Parse(lbl100.Text)+ int.Parse(lbl50.Text)+ int.Parse(lbl20.Text)+ int.Parse(lbl10.Text)+ int.Parse(lbl5.Text)+ int.Parse(lbl2.Text)+ int.Parse(lbl1.Text)).ToString();
           
            if (totalefectivocajero < 0)
            {
                totalefectivocajero = 0;
                txtefectivocajero.Text = "0";
                verificarefectivo();
            }
        }
        private void txt500_TextChanged(object sender, EventArgs e)
        {
            if (txt500.Text == "")
            {
                
                lbl500.Text = "0";
                totalefectivocajero -= n500;

                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();
                txt500.Text = "0";

            }
            else
            {


                lbl500.Text = (Convert.ToInt64(txt500.Text) * 500).ToString();

                totalefectivocajero += int.Parse(lbl500.Text);
                n500 += int.Parse(lbl500.Text);
                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();

            }
        }
        private void txt200_TextChanged(object sender, EventArgs e)
        {

            if (txt200.Text == "")
            {

                lbl200.Text = "0";
                totalefectivocajero -= n200;

                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();
                txt200.Text = "0";

            }
            else
            {


                lbl200.Text = (Convert.ToInt64(txt200.Text) * 200).ToString();

                totalefectivocajero += int.Parse(lbl200.Text);
                n200 = (int)totalefectivocajero;
                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();

            }
        }

        private void txt100_TextChanged(object sender, EventArgs e)
        {
            if (txt100.Text == "")
            {

                lbl100.Text = "0";
                totalefectivocajero -= n100;

                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();
                txt100.Text = "0";

            }
            else
            {


                lbl100.Text = (Convert.ToInt64(txt100.Text) * 100).ToString();

                totalefectivocajero += int.Parse(lbl100.Text);
                n100 = (int)totalefectivocajero;
                txtefectivocajero.Text = String.Format("{0:n0}", totalefectivocajero);
                verificarefectivo();

            }
        }


        public void validarbilletes()
        {
            if (txt500.Text == "")
            {
                txt500.Text = "0";
            }
            if (txt200.Text == "")
            {
                txt200.Text = "0";
            }
            if (txt100.Text == "")
            {
                txt100.Text = "0";
            }
            if (txt50.Text == "")
            {
                txt50.Text = "0";
            }
            if (txt20.Text == "")
            {
                txt20.Text = "0";
            }
            if (txt10.Text == "")
            {
                txt10.Text = "0";
            }
            if (txt5.Text == "")
            {
                txt5.Text = "0";
            }
            if (txt2.Text == "")
            {
                txt2.Text = "0";
            }
            if (txt1.Text == "")
            {
                txt1.Text = "0";
            }

        }


        private void btncierre_Click(object sender, EventArgs e)
        {

            /*aqui averigua cual es el numero de grupo a cerrar*/
            facturas facturas = new facturas();
            facturas = ControladorFacturas.Instance.Findnumerocierre(Globales.fecha);

            caja caja = new caja();
            caja.Tipo = "Cierre de Caja";
            caja.Motivo = "Cierre de Caja";
            caja.Totalefectivo = (totalefectivosistema - totalretiro);
            caja.Totaltarjeta = totaltarjetasistema;
            caja.Ventatotal = ((totalefectivosistema - totalretiro) + totaltarjetasistema );
            caja.Fecha = Globales.fecha;
            caja.Numerotipo = facturas.Numerocierre;




            try
            {
                usuarios usuarios = new usuarios();
                usuarios = ControladorUsuario.Instance.findidbynombre(Globales.nombreusuario);
                Globales.idusuario = (int)usuarios.Idusuario;
                roles roles = new roles();
                roles = ControladorRoles.Instance.findrolebynombreusuario(Globales.nombreusuario);
                if (roles.Roles == "Admin")/*Aqui se vaida si el usuario tiene rol adminsi lo tiene podra ver los totales de venta*/
                {

                     ControladorCaja.Instance.save(caja);
                    validarbilletes();
                   
                                        MessageBox.Show("Realizando Cierre");

                
                                        impresoras impresoras = new impresoras();
                                        impresoras = ControladorImpresora.Instance.findconfig();

                   


                    CrearTicket ticket = new CrearTicket();
                                        ticket.AbreCajon();//Para abrir el cajon de dinero.//Datos de la cabecera del Ticket.
                                        ticket.TextoCentro(Globales.sucursalnombre);
                                        ticket.TextoCentro(Globales.sucursaldireccion);
                                        ticket.TextoCentro("CIERRE DE CAJA #" + facturas.Numerocierre);
                                        ticket.TextoIzquierda("Cajero:" + Globales.nombreusuario);
                                        ticket.TextoIzquierda(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString());
                                        ticket.lineasIgual();
                                        ticket.TextoCentro("MOVIMIENTOS DE CAJA");
                                        ticket.TextoIzquierda("DEPOSITOS:");
                                        List<caja> depositos = new List<caja>();
                                        depositos = ControladorCaja.Instance.Registrosxtipoxfechaxcierre("Deposito", Globales.fecha,Globales.numerocierre);
                                        foreach (caja deposito in depositos)
                                        {
                                            ticket.Agregarinventario(deposito.Motivo, (int)deposito.Totalefectivo);
                                        }
                                        ticket.TextoIzquierda("TOTAL DEPOSITOS L." + totaldeposito);
                                        ticket.TextoIzquierda("");
                                        ticket.TextoIzquierda("RETIROS:");
                                        List<caja> retiros = new List<caja>();
                                         retiros = ControladorCaja.Instance.Registrosxtipoxfechaxcierre("Retiro", Globales.fecha, Globales.numerocierre);
                                        foreach (caja retiro in retiros)
                                        {
                                            ticket.Agregarinventario(retiro.Motivo, (int)retiro.Totalefectivo);
                                        }
                                        ticket.TextoIzquierda("TOTAL RETIROS   L." + totalretiro);
                                        ticket.lineasIgual();
                                        ticket.TextoCentro("METODO EFECTIVO");
                                        ticket.TextoIzquierda("");
                                        ticket.Encabezadocierre();///encabezados desgloce de  billetes cant y total
                                        ticket.TextoIzquierda("");
                                        ticket.AgregaArticuloscierre(Convert.ToInt32(txt500.Text), "Billetes de 500", (Convert.ToInt32(txt500.Text) * 500));
                                        ticket.AgregaArticuloscierre(Convert.ToInt32(txt200.Text), "Billetes de 200", (Convert.ToInt32(txt200.Text) * 200));
                                        ticket.AgregaArticuloscierre(Convert.ToInt32(txt100.Text), "Billetes de 100", (Convert.ToInt32(txt100.Text) * 100));
                                        ticket.AgregaArticuloscierre(Convert.ToInt32(txt50.Text), "Billetes de 50", (Convert.ToInt32(txt50.Text) * 50));
                                        ticket.AgregaArticuloscierre(Convert.ToInt32(txt20.Text), "Billetes de 20", (Convert.ToInt32(txt20.Text) * 20));
                                        ticket.AgregaArticuloscierre(Convert.ToInt32(txt10.Text), "Billetes de 10", (Convert.ToInt32(txt10.Text) * 10));
                                        ticket.AgregaArticuloscierre(Convert.ToInt32(txt5.Text), "Billetes de 5", (Convert.ToInt32(txt5.Text) * 5));
                                        ticket.AgregaArticuloscierre(Convert.ToInt32(txt2.Text), "Billetes de 2", (Convert.ToInt32(txt2.Text) * 2));
                                        ticket.AgregaArticuloscierre(Convert.ToInt32(txt1.Text), "Billetes de 1", (Convert.ToInt32(txt1.Text) * 1));
                                        ticket.lineasGuion();
                                         ticket.TextoIzquierda("TOTAL VENTA EFECTIVO             L." + (totalefectivosistema - totalretiro));
                                         ticket.TextoIzquierda("TOTAL VENTA EFECTIVO + DEPOSITO  L." + ((totaldeposito + totalefectivosistema - totalretiro)));
                                        ticket.TextoIzquierda("");
                                        ticket.TextoIzquierda("CALCULOS()");
                                        int totalsistema = (totaldeposito + totalefectivosistema - totalretiro);
                                        ticket.TextoIzquierda("TOTAL EFECTIVO SEGUN SISTEMA L." + totalsistema);
                                        ticket.TextoIzquierda("TOTAL EFECTIVO SEGUN CAJERO  L." + Convert.ToInt32(txtefectivocajero.Text));
                                        if (totalsistema > Convert.ToInt32(txtefectivocajero.Text))
                                        {
                                        ticket.TextoIzquierda("DIFERENCIA                (-)L." + Math.Abs((totalsistema - Convert.ToInt32(txtefectivocajero.Text))));
                                        }
                                        else
                                        {
                                        ticket.TextoIzquierda("DIFERENCIA                (+)L." + Math.Abs((totalsistema - Convert.ToInt32(txtefectivocajero.Text))));
                                        }
                                        
                                        ticket.TextoIzquierda("");

                                        ticket.lineasIgual();
                                                            ticket.TextoCentro("METODO TARJETA");
                                        ticket.TextoIzquierda("");
                                                            ticket.TextoIzquierda("TOTAL TARJETA  L." + txttarjetacajero.Text);


                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("CALCULOS()");
                    ticket.TextoIzquierda("TOTAL TARJETA SEGUN SISTEMA L." + (totaltarjetasistema));
                    ticket.TextoIzquierda("TOTAL TARJETA SEGUN CAJERO  L." + (txttarjetacajero.Text));
                    if (totaltarjetasistema > Convert.ToInt32(txttarjetacajero.Text))
                    {
                    ticket.TextoIzquierda("DIFERENCIA               (-)L." + Math.Abs((totaltarjetasistema - Convert.ToInt32(txttarjetacajero.Text))));
                    }
                    else
                    {
                    ticket.TextoIzquierda("DIFERENCIA               (+)L." + Math.Abs((totaltarjetasistema - Convert.ToInt32(txttarjetacajero.Text))));
                    }
                    ticket.lineasIgual();

                    ticket.TextoIzquierda("TOTAL VENTA DEL DIA           L." + (totalefectivosistema + totaltarjetasistema - totalretiro));
                    ticket.TextoIzquierda("TOTAL VENTA + DEPOSITO:       L." + (totalefectivosistema + totaltarjetasistema + totaldeposito - totalretiro));
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda(""); 
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("");
                        ticket.CortaTicket();
                       //ticket.ImprimirTicket("Microsoft XPS Document Writer");
                        ticket.ImprimirTicket(impresoras.Nombreimpresora);//Nombre de la impresora ticketera



                                        this.Close();



                                   

                }
                else /*condicion para ver si no tiene rol admin va ver los totales a ciegas*/
                {
                     ControladorCaja.Instance.save(caja);
                    validarbilletes();

                    MessageBox.Show("Realizando Cierre");

                    sucursales sucursal = new sucursales();
                    sucursal = ControladorSucursal.Instance.find();



                    impresoras impresoras = new impresoras();
                    impresoras = ControladorImpresora.Instance.findconfig();


                    CrearTicket ticket = new CrearTicket();
                    ticket.AbreCajon();//Para abrir el cajon de dinero.//Datos de la cabecera del Ticket.
                    ticket.TextoCentro(sucursal.Nombresucursal);
                    ticket.TextoCentro(sucursal.Direccion);
                    ticket.TextoCentro("CIERRE DE CAJA #" + facturas.Numerocierre);
                    ticket.TextoIzquierda("Cajero:" + Globales.nombreusuario);
                    ticket.TextoIzquierda(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString());
                    ticket.lineasIgual();
                    ticket.TextoCentro("MOVIMIENTOS DE CAJA");
                    ticket.TextoIzquierda("DEPOSITOS:");
                    List<caja> depositos = new List<caja>();
                    depositos = ControladorCaja.Instance.Registrosxtipoxfechaxcierre("Deposito", Globales.fecha, Globales.numerocierre);
                    foreach (caja deposito in depositos)
                    {
                        ticket.Agregarinventario(deposito.Motivo, (int)deposito.Totalefectivo);
                    }
                    ticket.TextoIzquierda("TOTAL DEPOSITOS L." + totaldeposito);
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("RETIROS:");
                    List<caja> retiros = new List<caja>();
                    retiros = ControladorCaja.Instance.Registrosxtipoxfechaxcierre("Retiro", Globales.fecha, Globales.numerocierre);
                    foreach (caja retiro in retiros)
                    {
                        ticket.Agregarinventario(retiro.Motivo, (int)retiro.Totalefectivo);
                    }
                    ticket.TextoIzquierda("TOTAL RETIROS   L." + totalretiro);
                    ticket.lineasIgual(); ticket.TextoCentro("METODO EFECTIVO");
                    ticket.TextoIzquierda("");
                    ticket.Encabezadocierre();///encabezados desgloce de  billetes cant y total
                    ticket.TextoIzquierda("");
                    ticket.AgregaArticuloscierre(Convert.ToInt32(txt500.Text), "Billetes de 500", (Convert.ToInt32(txt500.Text) * 500));
                    ticket.AgregaArticuloscierre(Convert.ToInt32(txt200.Text), "Billetes de 200", (Convert.ToInt32(txt200.Text) * 200));
                    ticket.AgregaArticuloscierre(Convert.ToInt32(txt100.Text), "Billetes de 100", (Convert.ToInt32(txt100.Text) * 100));
                    ticket.AgregaArticuloscierre(Convert.ToInt32(txt50.Text), "Billetes de 50", (Convert.ToInt32(txt50.Text) * 50));
                    ticket.AgregaArticuloscierre(Convert.ToInt32(txt20.Text), "Billetes de 20", (Convert.ToInt32(txt20.Text) * 20));
                    ticket.AgregaArticuloscierre(Convert.ToInt32(txt10.Text), "Billetes de 10", (Convert.ToInt32(txt10.Text) * 10));
                    ticket.AgregaArticuloscierre(Convert.ToInt32(txt5.Text), "Billetes de 5", (Convert.ToInt32(txt5.Text) * 5));
                    ticket.AgregaArticuloscierre(Convert.ToInt32(txt2.Text), "Billetes de 2", (Convert.ToInt32(txt2.Text) * 2));
                    ticket.AgregaArticuloscierre(Convert.ToInt32(txt1.Text), "Billetes de 1", (Convert.ToInt32(txt1.Text) * 1));
                    ticket.lineasGuion();
                    ticket.TextoIzquierda("TOTAL VENTA EFECTIVO             L." + (totalefectivosistema - totalretiro));
                    ticket.TextoIzquierda("TOTAL VENTA EFECTIVO + DEPOSITO  L." + ((totaldeposito + totalefectivosistema - totalretiro)));
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("CALCULOS()");
                    int totalsistema = (totaldeposito + totalefectivosistema - totalretiro);
                    ticket.TextoIzquierda("TOTAL EFECTIVO SEGUN SISTEMA L." + totalsistema);
                    ticket.TextoIzquierda("TOTAL EFECTIVO SEGUN CAJERO  L." + Convert.ToInt32(txtefectivocajero.Text));
                    if (totalsistema > Convert.ToInt32(txtefectivocajero.Text))
                    {
                        ticket.TextoIzquierda("DIFERENCIA                (-)L." + Math.Abs((totalsistema - Convert.ToInt32(txtefectivocajero.Text))));
                    }
                    else
                    {
                        ticket.TextoIzquierda("DIFERENCIA                (+)L." + Math.Abs((totalsistema - Convert.ToInt32(txtefectivocajero.Text))));
                    }

                    ticket.TextoIzquierda("");

                    ticket.lineasIgual();
                    ticket.TextoCentro("METODO TARJETA");
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("TOTAL TARJETA  L." + txttarjetacajero.Text);


                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("CALCULOS()");
                    ticket.TextoIzquierda("TOTAL TARJETA SEGUN SISTEMA L." + (totaltarjetasistema));
                    ticket.TextoIzquierda("TOTAL TARJETA SEGUN CAJERO  L." + (txttarjetacajero.Text));
                    if (totaltarjetasistema > Convert.ToInt32(txttarjetacajero.Text))
                    {
                        ticket.TextoIzquierda("DIFERENCIA               (-)L." + Math.Abs((totaltarjetasistema - Convert.ToInt32(txttarjetacajero.Text))));
                    }
                    else
                    {
                        ticket.TextoIzquierda("DIFERENCIA               (+)L." + Math.Abs((totaltarjetasistema - Convert.ToInt32(txttarjetacajero.Text))));
                    }
                    ticket.lineasIgual();

                    ticket.TextoIzquierda("TOTAL VENTA DEL DIA           L." + (totalefectivosistema + totaltarjetasistema - totalretiro));
                    ticket.TextoIzquierda("TOTAL VENTA + DEPOSITO:       L." + (totalefectivosistema + totaltarjetasistema + totaldeposito - totalretiro));
                    ticket.TextoIzquierda("");



                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("");
                    ticket.CortaTicket();
                   //ticket.ImprimirTicket("Microsoft XPS Document Writer");
                    ticket.ImprimirTicket(impresoras.Nombreimpresora);//Nombre de la impresora ticketera



                    this.Close();



                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private static CierreVista fmrCierreVista = null;
        internal static CierreVista Abrir1vez()
        {
            if (((fmrCierreVista == null) || (fmrCierreVista.IsDisposed == true)))
            {
                fmrCierreVista = new CierreVista();
            }
            fmrCierreVista.BringToFront();
            return fmrCierreVista;
        }



       


            

        }



    }


