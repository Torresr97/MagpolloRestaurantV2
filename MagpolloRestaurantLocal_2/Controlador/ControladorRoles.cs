using System;
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

    
    class ControladorRoles : DAOimpl<roles>
    {
        private static ControladorRoles instance = new ControladorRoles();


        private ControladorRoles()
        {

        }

        internal static ControladorRoles Instance
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

        public bool delete(roles model)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarRole", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idrole",model.Idrole);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public roles find(Int64 id)
        {
           
            roles role = new roles();
            string query = "SELECT role FROM roles  WHERE idrole = " + id;
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {

                role.Roles = reader.GetString(0);
               
            }
            reader.Close();
            return role;


        }

        public roles findIdbyname(string nombrerole)
        {

            roles role = new roles();
            string query = $"SELECT idrole FROM roles WHERE role = '{nombrerole}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {

                role.Idrole = reader.GetInt64(0);

            }
            reader.Close();
            return role;


        }


        public roles findrolebynombreusuario(string nombre)
        {

            roles role = new roles();
            string query = $"SELECT * FROM V_Usuarios WHERE nombre = '{nombre}' ";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                role.Idrole = reader.GetInt64(4);
                role.Roles = reader.GetString(5);

            }
            reader.Close();
            return role;


        }



        public List<roles> findAll()
        {
            List<roles> roles = new List<roles>();
            string query = "SELECT * FROM V_Roles";
            SqlDataReader lector = Conexion.getInstance().ejecutarqueryleer(query);
            while (lector.Read())
            {
                roles role = new roles();
                role.Idrole = lector.GetInt64(0);
               role.Roles= lector.GetString(1);
                role.Crear = lector.GetBoolean(2);
                role.Actualizar = lector.GetBoolean(3);
                role.Eliminar = lector.GetBoolean(4);



                roles.Add(role);

            }
            lector.Close();
            return roles;

        }



        public bool save(roles model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevoRole", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@role", model.Roles);
            cmd.Parameters.AddWithValue("@crear", model.Crear);
            cmd.Parameters.AddWithValue("@actualizar", model.Actualizar);
            cmd.Parameters.AddWithValue("@eliminar", model.Eliminar);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<roles> models)
        {
            throw new NotImplementedException();
        }

        public bool update(roles model)
        {

            SqlCommand cmd = new SqlCommand("SP_ActualizarRole", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idrole", model.Idrole);
            cmd.Parameters.AddWithValue("@role", model.Roles);
            cmd.Parameters.AddWithValue("@crear", model.Crear);
            cmd.Parameters.AddWithValue("@actualizar", model.Actualizar);
            cmd.Parameters.AddWithValue("@eliminar", model.Eliminar);
            return Conexion.getInstance().ejecutarSP(cmd);
        }



        //funcion que me devuelve todos los roles disponibles con su id 
        public DataTable Cargarcomboxroles()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idrole,role FROM roles", Conexion.getInstance().getconexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public roles find(int id)
        {
            return ((DAOimpl<roles>)instance).find(id);
        }
    }
}
