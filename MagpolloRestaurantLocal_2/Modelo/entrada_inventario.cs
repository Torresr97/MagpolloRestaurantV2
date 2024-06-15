using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class entrada_inventario
    {

        public entrada_inventario()
        {


        }


        private long identradainventario;
        private long idinventario;
        private long idproovedor;
        private int cantidad;
        private DateTime fecha_ingreso;

         public long Identradainventario
        {
            get
            {
                return identradainventario;
            }

            set
            {
                identradainventario = value;
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

        public long Idproovedor
        {
            get
            {
                return idproovedor;
            }

            set
            {
                idproovedor = value;
            }

        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }

        }

        public DateTime Fecha_ingreso
        {
            get
            {
                return fecha_ingreso;
            }

            set
            {
                fecha_ingreso = value;
            } 

        }
    }


   
}
