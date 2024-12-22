using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Modelo
{
    class Empleado
    {

        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string Identidad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string CorreoElectronico { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Estado { get; set; }
        public string NumeroCuentaBanco { get; set; }
        public decimal SalarioInicial { get; set; }
        public decimal SalarioActual { get; set; }
        public decimal SalarioQuincenal { get; set; }
        public decimal SalarioDiario { get; set; }
        public decimal SalarioHora { get; set; }
        public string Empresa { get; set; }
        public string PuestoCargo { get; set; }
        public string Departamento { get; set; }
        public DateTime FechaContrato { get; set; }
        public string NumeroSeguroSocial { get; set; }
        public string ContactoEmergencia { get; set; }
        public string NumeroContactoEmergencia { get; set; }
        public string Educacion { get; set; }
        public DateTime FechaSalida { get; set; }
        public string MotivoSalida { get; set; }
        public string NotasAdicionales { get; set; }
    }
}
