using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class detalle_factura
    {

        public detalle_factura()
        {


        }


        private int idDetallefactura;
        private int idfactura;
        private int idmenu;
        private string complementos;
        private int cantidad;
        private decimal total;




        public int IdDetallefactura
        {
            get
            {
                return idDetallefactura;
            }

            set
            {
                idDetallefactura = value;
            }

        }


        public int Idfactura
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
        public int Idmenu
        {
            get
            {
                return idmenu;
            }

            set
            {
                idmenu = value;
            }

        }

        public string Complementos
        {
            get
            {
                return complementos;
            }

            set
            {
                complementos = value;
            }

        }
        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
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












    }
}
