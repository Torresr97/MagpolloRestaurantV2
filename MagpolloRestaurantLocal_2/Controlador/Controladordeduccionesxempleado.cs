
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
    class Controladordeduccionesxempleado : DAOimpl<Deduccionxempleados>
    {
        private static Controladordeduccionesxempleado instance = new Controladordeduccionesxempleado();

        private Controladordeduccionesxempleado()
        {

        }

        internal static Controladordeduccionesxempleado Instance
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
        public bool delete(Deduccionxempleados model)
        {
            SqlCommand cmd = new SqlCommand("SP_Eliminardeduccionxempleado ", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iddeduccion", model.Iddeduccion);

            return Conexion.getInstance().ejecutarSP(cmd);
        }




        public Deduccionxempleados find(int id)
        {
            Deduccionxempleados Deduccionxempleado = new Deduccionxempleados();
            string query = "SELECT * FROM  V_deduccionesxempleado WHERE idempleado = " + id;
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                Deduccionxempleado.Iddeduccion = reader.GetInt32(0);
                Deduccionxempleado.Idempleado = reader.GetInt32(1);
                Deduccionxempleado.Numeroplanilla = reader.GetString(2);
                Deduccionxempleado.Deduccion = reader.GetString(3);
                Deduccionxempleado.Total = (double)reader.GetDecimal(4);
                Deduccionxempleado.Fecha = reader.GetDateTime(5);
                Deduccionxempleado.Estado = reader.GetBoolean(6);
            }
            reader.Close();
            return Deduccionxempleado;
        }

        public List<Deduccionxempleados> findAll()
        {

            List<Deduccionxempleados> creditoxempleados = new List<Deduccionxempleados>();
            string query = "SELECT * FROM  V_deduccionesxempleado";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                Deduccionxempleados creditoxempleado = new Deduccionxempleados();
                creditoxempleado.Iddeduccion = reader.GetInt32(0);
                creditoxempleado.Idempleado = reader.GetInt32(1);
                creditoxempleado.Numeroplanilla = reader.GetString(2);
                creditoxempleado.Deduccion = reader.GetString(3);
                creditoxempleado.Total = (double)reader.GetDecimal(4);
                creditoxempleado.Fecha = reader.GetDateTime(5);
                creditoxempleado.Estado = reader.GetBoolean(6);

                creditoxempleados.Add(creditoxempleado);

            }
            reader.Close();
            return creditoxempleados;
        }


        public List<Deduccionxempleados> findAllbyid(int id)
        {

            List<Deduccionxempleados> creditoxempleados = new List<Deduccionxempleados>();
            string query = "SELECT * FROM  V_deduccionesxempleado Where estado = 0 and idempleado =" + id;
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                Deduccionxempleados creditoxempleado = new Deduccionxempleados();
                creditoxempleado.Iddeduccion = (int)reader.GetInt64(0);
                creditoxempleado.Idempleado = (int)reader.GetInt64(1);
                creditoxempleado.Numeroplanilla = reader.GetString(2);
                creditoxempleado.Deduccion = reader.GetString(3);
                creditoxempleado.Total = (double)reader.GetDecimal(4);
                creditoxempleado.Fecha = reader.GetDateTime(5);
                creditoxempleado.Estado = reader.GetBoolean(6);

                creditoxempleados.Add(creditoxempleado);

            }
            reader.Close();
            return creditoxempleados;
        }
        public bool save(Deduccionxempleados model)
        {
            SqlCommand cmd = new SqlCommand("SP_Nuevodeduccionesxempleado", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idempleado", model.Idempleado);
            cmd.Parameters.AddWithValue("@numeroplanilla", model.Numeroplanilla);
            cmd.Parameters.AddWithValue("@deduccion", model.Deduccion);
            cmd.Parameters.AddWithValue("@total", model.Total);
            cmd.Parameters.AddWithValue("@fecha", model.Fecha);
            cmd.Parameters.AddWithValue("@estado", model.Estado);
            return Conexion.getInstance().ejecutarSP(cmd);

        }



        public bool save(List<Deduccionxempleados> models)
        {
            throw new System.NotImplementedException();
        }

        public bool update(Deduccionxempleados model)
        {

            SqlCommand cmd = new SqlCommand("SP_Actualizardeduccionesxempleado", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idcredito", model.Iddeduccion);
            cmd.Parameters.AddWithValue("@idempleado", model.Idempleado);
            cmd.Parameters.AddWithValue("@estado", model.Estado);
            return Conexion.getInstance().ejecutarSP(cmd);
        }


        /*****************************Aqui creamos funciones para reportes de deducciones*****************************************/
        public List<Deduccionxempleados> ReporteDeduccionDia(string f, int idempleado,int estado)
        {

            List<Deduccionxempleados> creditoxempleados = new List<Deduccionxempleados>();
            string query = $"SELECT * FROM  V_deduccionesxempleado WHERE idempleado = '{idempleado}' AND CAST(fecha AS DATE) = '{f}' AND estado = '{estado}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                Deduccionxempleados creditoxempleado = new Deduccionxempleados();
                creditoxempleado.Iddeduccion = (int)reader.GetInt64(0);
                creditoxempleado.Idempleado = (int)reader.GetInt64(1);
                creditoxempleado.Numeroplanilla = reader.GetString(2);
                creditoxempleado.Deduccion = reader.GetString(3);
                creditoxempleado.Total = (double)reader.GetDecimal(4);
                creditoxempleado.Fecha = reader.GetDateTime(5);
                creditoxempleado.Estado = reader.GetBoolean(6);

                creditoxempleados.Add(creditoxempleado);

            }
            reader.Close();
            return creditoxempleados;
        }


        public List<Deduccionxempleados> ReporteDeduccionmes(string mes, int idempleado, int estado)
        {

            List<Deduccionxempleados> creditoxempleados = new List<Deduccionxempleados>();
            string query = $"SELECT * FROM  V_deduccionesxempleado WHERE MONTH(fecha) = '{mes}' AND idempleado = '{idempleado}' AND estado = '{estado}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                Deduccionxempleados creditoxempleado = new Deduccionxempleados();
                creditoxempleado.Iddeduccion = (int)reader.GetInt64(0);
                creditoxempleado.Idempleado = (int)reader.GetInt64(1);
                creditoxempleado.Numeroplanilla = reader.GetString(2);
                creditoxempleado.Deduccion = reader.GetString(3);
                creditoxempleado.Total = (double)reader.GetDecimal(4);
                creditoxempleado.Fecha = reader.GetDateTime(5);
                creditoxempleado.Estado = reader.GetBoolean(6);

                creditoxempleados.Add(creditoxempleado);

            }
            reader.Close();
            return creditoxempleados;
        }

        public List<Deduccionxempleados> ReporteDeduccionano(string ano, int idempleado, int estado)
        {

            List<Deduccionxempleados> creditoxempleados = new List<Deduccionxempleados>();
            string query = $"SELECT * FROM  V_deduccionesxempleado WHERE YEAR(fecha)= '{ano}' AND idempleado = '{idempleado}' AND estado = '{estado}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                Deduccionxempleados creditoxempleado = new Deduccionxempleados();
                creditoxempleado.Iddeduccion = (int)reader.GetInt64(0);
                creditoxempleado.Idempleado = (int)reader.GetInt64(1);
                creditoxempleado.Numeroplanilla = reader.GetString(2);
                creditoxempleado.Deduccion = reader.GetString(3);
                creditoxempleado.Total = (double)reader.GetDecimal(4);
                creditoxempleado.Fecha = reader.GetDateTime(5);
                creditoxempleado.Estado = reader.GetBoolean(6);

                creditoxempleados.Add(creditoxempleado);

            }
            reader.Close();
            return creditoxempleados;
        }

        public List<Deduccionxempleados> ReporteDeducciondesdehasta(string desde, string hasta, int idempleado , int estado)
        {

            List<Deduccionxempleados> creditoxempleados = new List<Deduccionxempleados>();
            string query = $"SELECT * FROM  V_deduccionesxempleado WHERE CAST(fecha AS DATE) BETWEEN  '{desde}' AND '{hasta}' AND idempleado = '{idempleado}' AND estado = '{estado}' ";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                Deduccionxempleados creditoxempleado = new Deduccionxempleados();
                creditoxempleado.Iddeduccion = (int)reader.GetInt64(0);
                creditoxempleado.Idempleado = (int)reader.GetInt64(1);
                creditoxempleado.Numeroplanilla = reader.GetString(2);
                creditoxempleado.Deduccion = reader.GetString(3);
                creditoxempleado.Total = (double)reader.GetDecimal(4);
                creditoxempleado.Fecha = reader.GetDateTime(5);
                creditoxempleado.Estado = reader.GetBoolean(6);

                creditoxempleados.Add(creditoxempleado);

            }
            reader.Close();
            return creditoxempleados;
        }
    }
}
