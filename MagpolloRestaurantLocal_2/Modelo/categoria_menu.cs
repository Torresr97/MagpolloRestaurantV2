using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class categoria_menu
    {

        public categoria_menu()
        {


        }


        private int idcategoriamenu;
        private string nombrecategoria;




        public int Idcategoriamenu
        {
            get
            {
                return idcategoriamenu;
            }

            set
            {
                idcategoriamenu = value;
            }

        }


        public string Nombrecategoria
        {
            get
            {
                return nombrecategoria;
            }

            set
            {
                nombrecategoria = value;
            }

        }






    }
}
