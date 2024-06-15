using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class roles
    {

        public roles()
        {


        }


        private long idrole;
        private string role;
        private Boolean crear;
        private Boolean actualizar;
        private Boolean eliminar;


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


        public string Roles
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }

        }

        public Boolean Crear
        {
            get
            {
                return crear;
            }

            set
            {
                crear = value;
            }

        }




        public Boolean Actualizar
        {
            get
            {
                return actualizar;
            }

            set
            {
                actualizar = value;
            }

        }




        public Boolean Eliminar
        {
            get
            {
                return eliminar;
            }

            set
            {
                eliminar = value;
            }

        }

    }
}
