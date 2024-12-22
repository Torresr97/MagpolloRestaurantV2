using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class caja
    {


        public caja()
        {


        }


        private long idcaja;
        private string tipo;
        private string motivo;
        private decimal totalefectivo;
        private decimal totaltarjeta;
        private decimal totaltransferencia;
        private decimal ventatotal;
        private string fecha;
        private int numerotipo;

        public long Idcaja
        {
            get
            {
                return idcaja;
            }

            set
            {
                idcaja = value;
            }

        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }

        }


        public string Motivo
        {
            get
            {
                return motivo;
            }

            set
            {
                motivo = value;
            }

        }
        public decimal Totalefectivo
        {
            get
            {
                return totalefectivo;
            }

            set
            {
                totalefectivo = value;
            }

        }
        public decimal Totaltarjeta
        {
            get
            {
                return totaltarjeta;
            }

            set
            {
                totaltarjeta = value;
            }

        }

        public decimal Totaltransferencia
        {
            get
            {
                return totaltransferencia;
            }

            set
            {
                totaltransferencia = value;
            }

        }


        public decimal Ventatotal
        {
            get
            {
                return ventatotal;
            }

            set
            {
                ventatotal = value;
            }

        }


        public string Fecha
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

        public int Numerotipo
        {
            get
            {
                return numerotipo;
            }

            set
            {
                numerotipo = value;
            }

        }
    }
}
