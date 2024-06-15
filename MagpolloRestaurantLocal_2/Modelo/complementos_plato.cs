using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class complementos_plato
    {


        public complementos_plato()
        {


        }


        private long idcomplementos_plato;
        private string nombre_complementosplato;
        private long idtipocomplemento_plato;

        public long Idcomplementos_plato
        {
            get
            {
                return idcomplementos_plato;
            }

            set
            {
                idcomplementos_plato = value;
            }

        }


        public string Nombre_complementosplato
        {
            get
            {
                return nombre_complementosplato;
            }

            set
            {
                nombre_complementosplato = value;
            }

        }
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


    }
}
