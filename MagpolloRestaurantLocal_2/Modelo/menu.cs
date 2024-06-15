using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class menu
    {


        public menu()
        {


        }


        private int idmenu;
        private string nombrecombo;
        private string descripcion;
        private decimal precio;
        private int idcategoria;

        private int ncomplemento;
        private int grupo;
        private long idtipocomplemento;




        public int Idmenu
        {
            get
            {
                return idmenu;
            }

            set
            {
                idmenu = value;
            }

        }


        public string Nombrecombo
        {
            get
            {
                return nombrecombo;
            }

            set
            {
                nombrecombo = value;
            }

        }


        public decimal Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }

        }


        public int Idcategoria
        {
            get
            {
                return idcategoria;
            }

            set
            {
                idcategoria = value;
            }

        }



        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }

        }


        public int Ncomplemento
        {
            get
            {
                return ncomplemento;
            }

            set
            {
                ncomplemento = value;
            }

        }
        public int Grupo
        {
            get
            {
                return grupo;
            }

            set
            {
                grupo = value;
            }

        }


        public long Idtipocomplemento
        {
            get
            {
                return idtipocomplemento;
            }

            set
            {
                idtipocomplemento = value;
            }

        }
    }
}