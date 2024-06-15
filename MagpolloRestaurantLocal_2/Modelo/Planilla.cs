using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class Planilla
    {
        public Planilla()
        {


        }


        private int idplanilla;
        private int idempleado;
        private DateTime fechaemision;
        private DateTime periododesde;
        private DateTime periodohasta;
        private decimal sueldobase;
        private decimal ingresoextra;
        private decimal totaldeducciones;
        private decimal totalapagar;


        public int Idplanilla
        {
            get
            {
                return idplanilla;
            }

            set
            {
                idplanilla = value;
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
        public DateTime Fechaemision
        {
            get
            {
                return fechaemision;
            }

            set
            {
                fechaemision = value;
            }

        }
        public DateTime Periododesde
        {
            get
            {
                return periododesde;
            }

            set
            {
                periododesde = value;
            }

        }
        public DateTime Periodohasta
        {
            get
            {
                return periodohasta;
            }

            set
            {
                periodohasta = value;
            }

        }
        public decimal Totaldeducciones
        {
            get
            {
                return totaldeducciones;
            }

            set
            {
                totaldeducciones = value;
            }

        }
        public decimal Sueldobase
        {
            get
            {
                return sueldobase;
            }

            set
            {
                sueldobase = value;
            }

        }
        public decimal Ingresoextra
        {
            get
            {
                return ingresoextra;
            }

            set
            {
                ingresoextra = value;
            }

        }
        public decimal Totalapagar
        {
            get
            {
                return totalapagar;
            }

            set
            {
                totalapagar = value;
            }

        }

    }
}
