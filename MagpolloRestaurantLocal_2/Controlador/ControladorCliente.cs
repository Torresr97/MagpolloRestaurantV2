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
    class ControladorCliente : DAOimpl<Cliente>
    {
        private static ControladorCliente instance = new ControladorCliente();

        private ControladorCliente()
        {

        }

        internal static ControladorCliente Instance
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
        public bool delete(Cliente model)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarCliente", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcliente", model.Idcliente);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public Cliente findbyid(int id)
        {

            Cliente Cliente = new Cliente();
            string query = "SELECT idcliente,nombre,rtn  FROM clientes  WHERE idcliente = " + id;
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {

                Cliente.Idcliente = reader.GetInt64(0);
                Cliente.Nombre = reader.GetString(1);
                Cliente.Rtn = reader.GetString(2);

            }
            reader.Close();
            return Cliente;
        }

        public Cliente findbynombre(string nombre)
        {

            Cliente Cliente = new Cliente();
            string query = $"SELECT idcliente,nombre,rtn FROM clientes  WHERE nombre = '{nombre}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                Cliente.Idcliente = reader.GetInt64(0);
                Cliente.Nombre = reader.GetString(1);
                Cliente.Rtn = reader.GetString(2);

            }
            reader.Close();
            return Cliente;
        }

        public List<Cliente> findAll()
        {
            List<Cliente> Clientes = new List<Cliente>();
            string query = "SELECT * FROM V_Clientes";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                Cliente Cliente = new Cliente();
                Cliente.Idcliente = (int)reader.GetInt64(0);
                Cliente.Nombre = reader.GetString(1);
                Cliente.Rtn = reader.GetString(2);
                Cliente.Celular = reader.GetString(3);
                Cliente.Correo = reader.GetString(4);
                Clientes.Add(Cliente);
            }
            reader.Close();
            return Clientes;
        }

        public bool save(Cliente model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevoCliente", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", model.Nombre);
            cmd.Parameters.AddWithValue("@rtn", model.Rtn);
            cmd.Parameters.AddWithValue("@celular", model.Celular);
            cmd.Parameters.AddWithValue("@correo", model.Correo);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<Cliente> models)
        {
            throw new NotImplementedException();
        }

        public bool update(Cliente model)
        {

            SqlCommand cmd = new SqlCommand("SP_ActualizarCliente", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcliente", model.Idcliente);
            cmd.Parameters.AddWithValue("@nombre", model.Nombre);
            cmd.Parameters.AddWithValue("@rtn", model.Rtn);
            cmd.Parameters.AddWithValue("@celular", model.Celular);
            cmd.Parameters.AddWithValue("@correo", model.Correo);
            return Conexion.getInstance().ejecutarSP(cmd);
        }


        //funcion que me devuelve todos los roles disponibles con su id 
        public DataTable Cargarcomboxcliente()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idcliente,nombre FROM clientes ORDER BY nombre ASC", Conexion.getInstance().getconexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public Cliente find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
