using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class proovedor
    {
        public proovedor()
        {


        }


        private int idproovedor;
        private string nombre_empresa;
        private string rtn;
        private string celular;
        private string correo;
        private string direccion;
        private string nombre_encargado;







        public int Idproovedor
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

        public string Nombre_empresa
        {
            get
            {
                return nombre_empresa;
            }

            set
            {
                nombre_empresa = value;
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







        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }

        }



        public string Nombre_encargado
        {
            get
            {
                return nombre_encargado;
            }

            set
            {
                nombre_encargado = value;
            }

        }



    }
}
