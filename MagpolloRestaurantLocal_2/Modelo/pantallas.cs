using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class pantallas
    {
        public pantallas()
        {


        }


        private long idpantalla;
        private string nombrepantalla;


        public long Idpantalla
        {
            get
            {
                return idpantalla;
            }

            set
            {
                idpantalla = value;
            }

        }


        public string Nombrepantalla
        {
            get
            {
                return nombrepantalla;
            }

            set
            {
                nombrepantalla = value;
            }

        }
    }
}
