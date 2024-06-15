using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class sucursales
    {

        public sucursales()
        {


        }


        private int idsucursal;
        private string nombresucursal;
        private string direccion;
        private string direccion_2;
        private string telefono;
        private string celular;
        private string correo;
        private string rtn;
        private string cai;
        private DateTime fecha_emision;
        private string rangodesde;
        private string rangohasta;
        private Boolean facturarconcai;


        public int Idsucursal
        {
            get
            {
                return idsucursal;
            }

            set
            {
                idsucursal = value;
            }

        }


        public string Nombresucursal
        {
            get
            {
                return nombresucursal;
            }

            set
            {
                nombresucursal = value;
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

        public string Direccion_2
        {
            get
            {
                return direccion_2;
            }

            set
            {
                direccion_2 = value;
            }

        }




        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
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



        public string Cai
        {
            get
            {
                return cai;
            }

            set
            {
                cai = value;
            }

        }


        public DateTime Fecha_emision
        {
            get
            {
                return fecha_emision;
            }

            set
            {
                fecha_emision = value;
            }

        }


        public string Rangodesde
        {
            get
            {
                return rangodesde;
            }

            set
            {
                rangodesde = value;
            }

        }



        public string Rangohasta
        {
            get
            {
                return rangohasta;
            }

            set
            {
                rangohasta = value;
            }

        }

        public Boolean Facturarconcai
        {
            get
            {
                return facturarconcai;
            }

            set
            {
                facturarconcai = value;
            }

        }




    }
}
