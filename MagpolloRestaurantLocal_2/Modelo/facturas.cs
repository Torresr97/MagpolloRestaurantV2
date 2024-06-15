using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class facturas
    {

        public facturas()
        {


        }


        private long idfactura;
        private int orden;
        private string fecha;
        private string nombrecliente;
        private string rtncliente;
        private decimal descuento;
        private decimal importe_exonerado;
        private decimal importe_exento;
        private decimal importe_gravado;
        private decimal isv15;
        private decimal isv18;
        private decimal dinerorecibido;
        private decimal dineroentregado;
        private decimal total;
        private Boolean estado;
        private int idsucursal;
        private int idusuario;
        private int idcliente;
        private string tipopago;
        private string ultimosdigitos;
        private int numerocierre;
        private DateTime fecha2;
        private string facturacai;


        public long Idfactura
        {
            get
            {
                return idfactura;
            }

            set
            {
                idfactura = value;
            }

        }


        public int Orden
        {
            get
            {
                return orden;
            }

            set
            {
                orden = value;
            }

        }


        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }

        }

        public string Nombrecliente
        {
            get
            {
                return nombrecliente;
            }

            set
            {
                nombrecliente = value;
            }

        }

        public string Rtncliente
        {
            get
            {
                return rtncliente;
            }

            set
            {
                rtncliente = value;
            }

        }

        public decimal Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
            }

        }

        public decimal Importe_exonerado
        {
            get
            {
                return importe_exonerado;
            }

            set
            {
                importe_exonerado = value;
            }

        }

        public decimal Importe_exento
        {
            get
            {
                return importe_exento;
            }

            set
            {
                importe_exento = value;
            }

        }
        public decimal Importe_gravado
        {
            get
            {
                return importe_gravado;
            }

            set
            {
                importe_gravado = value;
            }

        }
        public decimal Isv15
        {
            get
            {
                return isv15;
            }

            set
            {
                isv15 = value;
            }

        }
        public decimal Isv18
        {
            get
            {
                return isv18;
            }

            set
            {
                isv18 = value;
            }

        }
        public decimal Dinerorecibido
        {
            get
            {
                return dinerorecibido;
            }

            set
            {
                dinerorecibido = value;
            }

        }
        public decimal Dineroentregado
        {
            get
            {
                return dineroentregado;
            }

            set
            {
                dineroentregado = value;
            }

        }
        public decimal Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }

        }
        public Boolean Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }

        }


        public int Idsucursal
        {
            get
            {
                return idsucursal;
            }

            set
            {
                idsucursal = value;
            }

        }



        public int Idusuario
        {
            get
            {
                return idusuario;
            }

            set
            {
                idusuario = value;
            }

        }
        public int Idcliente
        {
            get
            {
                return idcliente;
            }

            set
            {
                idcliente = value;
            }

        }


        public string Tipopago
        {
            get
            {
                return tipopago;
            }

            set
            {
                tipopago = value;
            }

        }

        public string Ultimosdigitos
        {
            get
            {
                return ultimosdigitos;
            }

            set
            {
                ultimosdigitos = value;
            }

        }

        public int Numerocierre
        {
            get
            {
                return numerocierre;
            }

            set
            {
                numerocierre = value;
            }

        }

        public DateTime Fecha2
        {
            get
            {
                return fecha2;
            }

            set
            {
                fecha2 = value;
            }

        }
        public string Facturacai
        {
            get
            {
                return facturacai;
            }

            set
            {
                facturacai = value;
            }

        }














    }
}
