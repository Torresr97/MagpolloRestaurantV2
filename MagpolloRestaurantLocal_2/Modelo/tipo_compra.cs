using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class tipo_compra
    {

        public tipo_compra()
        {


        }


        private long idtipocompra;
        private string nombretipocompra;


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


        public string Nombretipocompra
        {
            get
            {
                return nombretipocompra;
            }

            set
            {
                nombretipocompra = value;
            }

        }


    }
}
