using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class DetallePagoMixto
    {

        public DetallePagoMixto()
        {


        }

        public int IdDetallePagoMixto { get; set; }
        public int IdFactura { get; set; }
        public string MetodoPago { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public int Numerocierre { get; set; }
        public Boolean Estado { get; set; }
    }
}
