using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class Cliente
    {
        public Cliente()
        {


        }




        private long idcliente;
        private string nombre;
        private string rtn;
        private string celular;
        private string correo;


        public long Idcliente
        {
            get
            {
                return idcliente;
            }

            set
            {
                idcliente = value;
            }

        }


        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }

        }

        public string Rtn
        {
            get
            {
                return rtn;
            }

            set
            {
                rtn = value;
            }

        }

        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }

        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }

        }
    }




}
