using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class Deduccion
    {

        public int IdDeduccion { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaDeduccion { get; set; }
        public string Sucursal { get; set; }
        public int IdUsuario { get; set; }
        public string ProductoDescripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public int IdTipoDeduccion { get; set; }
        public string Observaciones { get; set; }
        public int IdPlanilla { get; set; }
        public int IdPrestamo { get; set; }
    }
}
