using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class Deduccionxempleados
    {
        public Deduccionxempleados()
        {


        }



        private int iddeduccion;
        private int idempleado;
        private string numeroplanilla;
        private string deduccion;
        private double total;
        private DateTime fecha;
        private Boolean estado;




        public int Iddeduccion
        {
            get
            {
                return iddeduccion;
            }

            set
            {
                iddeduccion = value;
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


        public string Deduccion
        {
            get
            {
                return deduccion;
            }

            set
            {
                deduccion = value;
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
