using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class usuarios
    {

        public usuarios()
        {


        }


        private long idusuario;
        private string nombre;
        private string apellido;
        private string contrasena;
        private long idrole;
        private DateTime fecha_de_creacion;



        public long Idusuario
        {
            get
            {
                return idusuario;
            }

            set
            {
                idusuario = value;
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


        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }

        }



        public string Contrasena
        {
            get
            {
                return contrasena;
            }

            set
            {
                contrasena = value;
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



        public DateTime Fecha_de_creacion
        {
            get
            {
                return fecha_de_creacion;
            }

            set
            {
                fecha_de_creacion = value;
            }

        }

 
    }
}
