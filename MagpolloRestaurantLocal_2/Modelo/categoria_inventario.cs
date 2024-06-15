using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class categoria_inventario
    {


        public categoria_inventario()
        {


        }


        private int idcategoria_inventario;
        private string categoria;
        private string descripcion;


        public int Idcategoria_inventario
        {
            get
            {
                return idcategoria_inventario;
            }

            set
            {
                idcategoria_inventario = value;
            }

        }


        public string Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
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

























    }
}
