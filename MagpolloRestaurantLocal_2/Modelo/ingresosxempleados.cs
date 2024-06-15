using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class ingresosxempleados
    {

        public ingresosxempleados()
        {


        }

        private int idingreso;
        private int idempleado;
        private string numeroplanilla;
        private string ingreso;
        private double total;
        private DateTime fecha;
        private Boolean estado;




        public int Idingreso
        {
            get
            {
                return idingreso;
            }

            set
            {
                idingreso = value;
            }

        }


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

        public string Numeroplanilla
        {
            get
            {
                return numeroplanilla;
            }

            set
            {
                numeroplanilla = value;
            }

        }



        public string Ingreso
        {
            get
            {
                return ingreso;
            }

            set
            {
                ingreso = value;
            }

        }


        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }

        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }

        }
        public Boolean Estado
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
