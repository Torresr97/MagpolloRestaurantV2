using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTRchicken.Modelo;
using System.Data.SqlClient;
using System.Data;

namespace AppTRchicken.Controlador
{
    class ControladorEmpleados : DAOimpl<empleados>
    {
        private static ControladorEmpleados instance = new ControladorEmpleados();

        private ControladorEmpleados()
        {

        }

        internal static ControladorEmpleados Instance
        {

            get
            {
                return instance;
            }
            set
            {
                instance = value;

            }

        }

    
public bool delete(empleados model)
        {
            throw new NotImplementedException();
        }

        public empleados find(int id)
        {
            throw new NotImplementedException();
        }

        public List<empleados> findAll()
        {
            List<empleados> empleados = new List<empleados>();
            string query = "SELECT * FROM V_Empleados";
            SqlDataReader lector = Conexion.getInstance().ejecutarqueryleer(query);
            while (lector.Read())
            {
                empleados empleado = new empleados();
                empleado.Idempleado = (int)lector.GetInt64(0);
                empleado.Nombreempleado = lector.GetString(1);
                empleado.Identidad = lector.GetString(2);
                empleado.Fechaingreso = lector.GetDateTime(3);
                empleado.Sueldomensual = lector.GetDecimal(4);
                empleado.Sueldoquincenal = lector.GetDecimal(5);
                empleado.Estado = lector.GetString(6);



                empleados.Add(empleado);

            }
            lector.Close();
            return empleados;

        }

        public bool save(empleados model)
        {
               SqlCommand cmd = new SqlCommand("SP_NuevoEmpleado", Conexion.getInstance().getconexion());
           cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreempleado", model.Nombreempleado);
            cmd.Parameters.AddWithValue("@identidad", model.Identidad);
            cmd.Parameters.AddWithValue("@fechaingreso", model.Fechaingreso);
            cmd.Parameters.AddWithValue("@sueldomensual", model.Sueldomensual);
               cmd.Parameters.AddWithValue("@sueldoquincenal", model.Sueldoquincenal);
               cmd.Parameters.AddWithValue("@estado", model.Estado);
               return Conexion.getInstance().ejecutarSP(cmd);
           
        }

        public bool save(List<empleados> models)
        {
            throw new NotImplementedException();
        }

        public bool update(empleados model)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarEmpleado", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idempleado", model.Idempleado);
            cmd.Parameters.AddWithValue("@nombreempleado", model.Nombreempleado);
            cmd.Parameters.AddWithValue("@identidad", model.Identidad);
            
            cmd.Parameters.AddWithValue("@sueldomensual", model.Sueldomensual);
            cmd.Parameters.AddWithValue("@sueldoquincenal", model.Sueldoquincenal);
            cmd.Parameters.AddWithValue("@estado", model.Estado);
            return Conexion.getInstance().ejecutarSP(cmd);

        }

        public empleados findidbynombre(string nombre)
        {
            empleados empleados = new empleados();
            string query = $"SELECT * FROM V_Empleados WHERE nombreempleado ='{nombre}' ";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                empleados.Idempleado = (int)reader.GetInt64(0);
                empleados.Nombreempleado = reader.GetString(1);
                empleados.Identidad = reader.GetString(2);
                empleados.Fechaingreso = reader.GetDateTime(3);
                empleados.Sueldomensual = reader.GetDecimal(4);
                empleados.Sueldoquincenal = reader.GetDecimal(5);
                empleados.Estado = reader.GetString(6);


            }
            reader.Close();
            return empleados;



        }


        public DataTable Cargarcomboxempleado()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idempleado,nombreempleado FROM empleados", Conexion.getInstance().getconexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }                                                                    
    }
}
