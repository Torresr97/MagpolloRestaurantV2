using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class empleados
    {
        public empleados()
        {


        }



        private int idempleado;
        private string nombreempleado;
        private string identidad;
        private DateTime fechaingreso;
        private decimal sueldomensual;
        private decimal sueldoquincenal;
        private string estado;



        public int Idempleado
        {
            get
            {
                return idempleado;
            }

            set
            {
                idempleado = value;
            }

        }

        public string Nombreempleado
        {
            get
            {
                return nombreempleado;
            }

            set
            {
                nombreempleado = value;
            }

        }

        public string Identidad
        {
            get
            {
                return identidad;
            }

            set
            {
                identidad = value;
            }

        }

        public DateTime Fechaingreso
        {
            get
            {
                return fechaingreso;
            }

            set
            {
                fechaingreso = value;
            }

        }



        public decimal Sueldomensual
        {
            get
            {
                return sueldomensual;
            }

            set
            {
                sueldomensual = value;
            }

        }



        public decimal Sueldoquincenal
        {
            get
            {
                return sueldoquincenal;
            }

            set
            {
                sueldoquincenal = value;
            }

        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }

        }











    }
}
