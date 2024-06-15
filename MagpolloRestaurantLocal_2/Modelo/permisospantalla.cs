using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class permisospantalla
    {
        public permisospantalla()
        {


        }


        private long idpermisospantalla;
        private long idrole;
        private long idpantalla;
        private bool acceso;


        public long Idpermisospantalla
        {
            get
            {
                return idpermisospantalla;
            }

            set
            {
                idpermisospantalla = value;
            }

        }



        public long Idrole
        {
            get
            {
                return idrole;
            }

            set
            {
                idrole = value;
            }

        }


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

        public bool Acceso
        {
            get
            {
                return acceso;
            }

            set
            {
                acceso = value;
            }

        }

    }
}
