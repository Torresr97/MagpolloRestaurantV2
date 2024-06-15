using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class tipocomplemento_plato
    {

        public tipocomplemento_plato()
        {


        }


        private long idtipocomplemento_plato;
        private string nombretipocomplemento_plato;


        public long Idtipocomplemento_plato
        {
            get
            {
                return idtipocomplemento_plato;
            }

            set
            {
                idtipocomplemento_plato = value;
            }

        }


        public string Nombretipocomplemento_plato
        {
            get
            {
                return nombretipocomplemento_plato;
            }

            set
            {
                nombretipocomplemento_plato = value;
            }

        }


    }
}
