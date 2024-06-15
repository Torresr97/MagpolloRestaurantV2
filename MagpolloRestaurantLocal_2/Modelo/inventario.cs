using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class inventario
    {
        public inventario()
        {


        }


        private long idinventario;
        private string nombreproducto;
        private int existencia;
        private decimal costo;
        private decimal precioventa;
       


        public long Idinventario
        {
            get
            {
                return idinventario;
            }

            set
            {
                idinventario = value;
            }

        }

        public string Nombreproducto
        {
            get
            {
                return nombreproducto;
            }

            set
            {
                nombreproducto = value;
            }

        }




        public int Existencia
        {
            get
            {
                return existencia;
            }

            set
            {
                existencia = value;
            }

        }








        public decimal Costo
        {
            get
            {
                return costo;
            }

            set
            {
                costo = value;
            }

        }

        public decimal Precioventa
        {
            get
            {
                return precioventa;
            }

            set
            {
                precioventa = value;
            }

        }







    }
}
