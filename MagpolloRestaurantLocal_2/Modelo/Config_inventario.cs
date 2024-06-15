using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class Config_inventario
    {

        public Config_inventario()
        {
        }

        private long idconfiginventario;
        private long idmenu;
        private long idinventario;
        private int cantidadrestar;

        public long Idconfiginventario
        {
            get
            {
                return idconfiginventario;
            }

            set
            {
                idconfiginventario = value;
            }

        }

        public long Idmenu
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

        public long Idinventario
        {
            get
            {
                return idinventario;
            }

            set
            {
                idinventario = value;
            }

        }

        public int Cantidadrestar
        {
            get
            {
                return cantidadrestar;
            }

            set
            {
                cantidadrestar = value;
            }

        }


    }
}
