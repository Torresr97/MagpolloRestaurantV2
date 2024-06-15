using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class Compra
    {

        public Compra()
        {


        }


        private long idcompra;
        private string nombre_compra;
        private long idtipocompra;
        private long idproovedor;
        private decimal total;
        private string fecha;



        public long Idcompra
        {
            get
            {
                return idcompra;
            }

            set
            {
                idcompra = value;
            }

        }

        public string Nombre_compra
        {
            get
            {
                return nombre_compra;
            }

            set
            {
                nombre_compra = value;
            }

        }



        public long Idtipocompra
        {
            get
            {
                return idtipocompra;
            }

            set
            {
                idtipocompra = value;
            }

        }

        public long Idproovedor
        {
            get
            {
                return idproovedor;
            }

            set
            {
                idproovedor = value;
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

    }
}
