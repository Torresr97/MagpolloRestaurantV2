using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTRchicken.Modelo;
using System.Data.SqlClient;

namespace AppTRchicken.Controlador
{
    class ControladorUsuario : DAOimpl<usuarios>
    {
        private static ControladorUsuario instance = new ControladorUsuario();

        private ControladorUsuario()
        {

        }

        internal static ControladorUsuario Instance
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

        public bool delete(usuarios model)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idusuario", model.Idusuario);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public usuarios find(int id)
        {
            usuarios usuario = new usuarios();
            string query = "SELECT nombre,contra FROM usuarios WHERE idusuario = " + id;
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                usuario.Idusuario = reader.GetInt32(0);
                usuario.Nombre = reader.GetString(1);
                usuario.Apellido = reader.GetString(2);
                usuario.Contrasena = reader.GetString(3);
                usuario.Idrole = reader.GetInt32(4);
                usuario.Fecha_de_creacion = reader.GetDateTime(5);
            }
            reader.Close();
            return usuario;



        }



        public usuarios findidbynombre(string nombre)
        {
            usuarios usuario = new usuarios();
            string query = $"SELECT *  FROM V_Usuarios WHERE nombre ='{nombre}' ";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                usuario.Idusuario = reader.GetInt64(0);
                
            }
            reader.Close();
            return usuario;



        }





        public List<usuarios> findAll()
        {
            List<usuarios> usuarios = new List<usuarios>();
            string query = "SELECT * FROM V_Usuarios";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                usuarios usuario = new usuarios();
                usuario.Idusuario = reader.GetInt64(0);
                usuario.Nombre = reader.GetString(1);
                usuario.Apellido = reader.GetString(2);
                usuario.Contrasena = reader.GetString(3);
                usuario.Idrole = reader.GetInt64(4);
     
                usuario.Fecha_de_creacion = reader.GetDateTime(6);
                usuarios.Add(usuario);
               
            }
            reader.Close();
            return usuarios;
            
        }

        public bool save(usuarios model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevoUsuario", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", model.Nombre);
            cmd.Parameters.AddWithValue("@apellido", model.Apellido);
            cmd.Parameters.AddWithValue("@contrasena", model.Contrasena);
            cmd.Parameters.AddWithValue("@idrole", model.Idrole);
            cmd.Parameters.AddWithValue("@fecha", model.Fecha_de_creacion);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<usuarios> models)
        {
            throw new NotImplementedException();
        }

        public bool update(usuarios model)
        {

            SqlCommand cmd = new SqlCommand("SP_ActualizarUsuario", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idusuario", model.Idusuario);
            cmd.Parameters.AddWithValue("@nombre", model.Nombre);
            cmd.Parameters.AddWithValue("@apellido", model.Apellido);
            cmd.Parameters.AddWithValue("@contrasena", model.Contrasena);
            cmd.Parameters.AddWithValue("@idrole", model.Idrole);
            cmd.Parameters.AddWithValue("@fecha", model.Fecha_de_creacion);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        // validacion de usuario y contrasena
        public bool Validarusuario(string usuario, string contra)
        {
            

            List<usuarios> usuarios = new List<usuarios>();
            string query = "SELECT nombre,contrasena FROM usuarios WHERE nombre = '" + usuario + "'AND contrasena='" + contra + "'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    usuarios us = new usuarios();
                    us.Nombre = reader.GetString(0);
                    us.Contrasena = reader.GetString(1);
                    usuarios.Add(us);

                }
                reader.Close();
                return true;
               
            }
            else
            {
                reader.Close();
                return false;
                
            }
            


        }



        /// Encripta una cadena
        public static string Encriptar(string contra)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(contra);
            result = Convert.ToBase64String(encryted);
            return result;
        }



        /* Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptar(this string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }*/
    }
}






