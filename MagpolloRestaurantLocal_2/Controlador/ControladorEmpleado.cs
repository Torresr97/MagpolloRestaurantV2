using AppTRchicken.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Controlador
{
    class ControladorEmpleado : DAOimpl<Empleado>
    {
        private static ControladorEmpleado instance = new ControladorEmpleado();
        private ControladorEmpleado() { }

        public static ControladorEmpleado Instance
        {
            get { return instance; }
            set { instance = value; }
        }

        public bool delete(Empleado model)
        {
            throw new NotImplementedException();
        }

        public Empleado find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Empleado> findAll()
        {
            throw new NotImplementedException();
        }

        public List<Empleado> findAllcentral(string basedatos)
        {
            List<Empleado> empleados = new List<Empleado>();
            string query = "SELECT * FROM Empleados Where Estado = 'Activo'";
            SqlDataReader reader = Conexion.getInstance().ejecutarQueryLeerEnOtraBD(query, basedatos);
            while (reader.Read())
            {
                Empleado empleado = new Empleado
                {
                    IdEmpleado = reader.GetInt32(0),
                    NombreCompleto = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    Identidad = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    FechaNacimiento = reader.GetDateTime(3),
                    Direccion = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    Celular = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                    CorreoElectronico = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                    EstadoCivil = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                    FechaIngreso = reader.GetDateTime(8),
                    Estado = reader.IsDBNull(9) ? string.Empty : reader.GetString(9),
                    NumeroCuentaBanco = reader.IsDBNull(10) ? string.Empty : reader.GetString(10),
                    SalarioInicial = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11),
                    SalarioActual = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12),
                    SalarioQuincenal = reader.IsDBNull(13) ? 0 : reader.GetDecimal(13),
                    SalarioDiario = reader.IsDBNull(14) ? 0 : reader.GetDecimal(14),
                    SalarioHora = reader.IsDBNull(15) ? 0 : reader.GetDecimal(15),
                    Empresa = reader.IsDBNull(16) ? string.Empty : reader.GetString(16),
                    PuestoCargo = reader.IsDBNull(17) ? string.Empty : reader.GetString(17),
                    Departamento = reader.IsDBNull(18) ? string.Empty : reader.GetString(18),
                    FechaContrato = reader.GetDateTime(19),
                    NumeroSeguroSocial = reader.IsDBNull(20) ? string.Empty : reader.GetString(20),
                    ContactoEmergencia = reader.IsDBNull(21) ? string.Empty : reader.GetString(21),
                    NumeroContactoEmergencia = reader.IsDBNull(22) ? string.Empty : reader.GetString(22),
                    Educacion = reader.IsDBNull(23) ? string.Empty : reader.GetString(23),
                    FechaSalida = reader.GetDateTime(24),
                    MotivoSalida = reader.IsDBNull(25) ? string.Empty : reader.GetString(25),
                    NotasAdicionales = reader.IsDBNull(26) ? string.Empty : reader.GetString(26)
                };
                empleados.Add(empleado);
            }
            reader.Close();
            return empleados;
        }

        public bool save(Empleado model)
        {
            throw new NotImplementedException();
        }

        public bool save(List<Empleado> models)
        {
            throw new NotImplementedException();
        }

        public bool update(Empleado model)
        {
            throw new NotImplementedException();
        }
    }
}
