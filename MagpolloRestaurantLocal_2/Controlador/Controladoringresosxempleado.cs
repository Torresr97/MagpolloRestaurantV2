
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTRchicken.Modelo;
using AppTRchicken.Controlador;
using System.Data.SqlClient;
namespace AppTRchicken.Controlador
{
    class Controladoringresosxempleado : DAOimpl<ingresosxempleados>
    {
        private static Controladoringresosxempleado instance = new Controladoringresosxempleado();

        private Controladoringresosxempleado()
        {

        }

        internal static Controladoringresosxempleado Instance
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


        public bool delete(ingresosxempleados model)
        {
            SqlCommand cmd = new SqlCommand("SP_Eliminaringresoxempleado", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idingreso", model.Idingreso);
            return Conexion.getInstance().ejecutarSP(cmd);

        }

        public ingresosxempleados find(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ingresosxempleados> findAll()
        {
            throw new System.NotImplementedException();
        }

        public bool save(ingresosxempleados model)
        {
            SqlCommand cmd = new SqlCommand("SP_Nuevoingresosxempleado", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idempleado", model.Idempleado);
            cmd.Parameters.AddWithValue("@numeroplanilla", model.Numeroplanilla);
            cmd.Parameters.AddWithValue("@ingreso", model.Ingreso);
            cmd.Parameters.AddWithValue("@total", model.Total);
            cmd.Parameters.AddWithValue("@fecha", model.Fecha);
            cmd.Parameters.AddWithValue("@estado", model.Estado);
            return Conexion.getInstance().ejecutarSP(cmd);

        }

        public bool save(List<ingresosxempleados> models)
        {
            throw new System.NotImplementedException();
        }

        public bool update(ingresosxempleados model)
        {
            throw new System.NotImplementedException();
        }


        public List<ingresosxempleados> findAllbyid(int id)
        {

            List<ingresosxempleados> ingresosxempleados = new List<ingresosxempleados>();
            string query = "SELECT * FROM  V_ingresosxempleado Where estado = 0 and idempleado =" + id;
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                ingresosxempleados ingresosxempleado = new ingresosxempleados();
                ingresosxempleado.Idingreso = (int)reader.GetInt64(0);
                ingresosxempleado.Idempleado = (int)reader.GetInt64(1);
                ingresosxempleado.Numeroplanilla = reader.GetString(2);
                ingresosxempleado.Ingreso = reader.GetString(3);
                ingresosxempleado.Total = (double)reader.GetDecimal(4);
                ingresosxempleado.Fecha = reader.GetDateTime(5);
                ingresosxempleado.Estado = reader.GetBoolean(6);

                ingresosxempleados.Add(ingresosxempleado);

            }
            reader.Close();
            return ingresosxempleados;
        }

        public List<ingresosxempleados> Reporteingresosdesdehasta(string desde, string hasta, int idempleado)
        {

            List<ingresosxempleados> ingresosxempleados = new List<ingresosxempleados>();
            string query = $"SELECT * FROM  V_ingresosxempleado WHERE CAST(fecha AS DATE) BETWEEN  '{desde}' AND '{hasta}' AND idempleado = '{idempleado}' AND estado = 0 ";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                ingresosxempleados ingresosxempleado = new ingresosxempleados();
                ingresosxempleado.Idingreso = (int)reader.GetInt64(0);
                ingresosxempleado.Idempleado = (int)reader.GetInt64(1);
                ingresosxempleado.Numeroplanilla = reader.GetString(2);
                ingresosxempleado.Ingreso = reader.GetString(3);
                ingresosxempleado.Total = (double)reader.GetDecimal(4);
                ingresosxempleado.Fecha = reader.GetDateTime(5);
                ingresosxempleado.Estado = reader.GetBoolean(6);

                ingresosxempleados.Add(ingresosxempleado);

            }
            reader.Close();
            return ingresosxempleados;
        }
    }
}
