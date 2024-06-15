using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class impresoras
    {
        public impresoras()
        {


        }


        private long idimpresora;
        private string nombreimpresora;
        private int ticktes;


        public long Idimpresora
        {
            get
            {
                return idimpresora;
            }

            set
            {
                idimpresora = value;
            }

        }


        public string Nombreimpresora
        {
            get
            {
                return nombreimpresora;
            }

            set
            {
                nombreimpresora = value;
            }

        }

        public int Ticktes
        {
            get
            {
                return ticktes;
            }

            set
            {
                ticktes = value;
            }

        }



    }

}
