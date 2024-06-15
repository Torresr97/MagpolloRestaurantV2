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
    class ControladorPermisosPantalla : DAOimpl<permisospantalla>
    {
        private static ControladorPermisosPantalla instance = new ControladorPermisosPantalla();


        private ControladorPermisosPantalla()
        {

        }

        internal static ControladorPermisosPantalla Instance
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

        public bool delete(permisospantalla model)
        {
            throw new NotImplementedException();
        }

        public permisospantalla find(int id)
        {
            throw new NotImplementedException();
        }

        public List<permisospantalla> findAll()
        {
            throw new NotImplementedException();
        }

        public List<permisospantalla> findAllpermisos(int idrole)
        {

            List<permisospantalla> permisospantallas = new List<permisospantalla>();
            string query = $"SELECT * FROM V_permisopantallas where idrole={idrole} ";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                permisospantalla permisospantalla = new permisospantalla();
                permisospantalla.Idpermisospantalla = reader.GetInt64(0);
                permisospantalla.Idrole = reader.GetInt64(1);
                permisospantalla.Idpantalla = reader.GetInt64(2);
                permisospantalla.Acceso = reader.GetBoolean(4);



                permisospantallas.Add(permisospantalla);

            }
            reader.Close();
            return permisospantallas;
        }

        public bool save(permisospantalla model)
        {

            SqlCommand cmd = new SqlCommand("SP_Nuevopermisospantalla", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idrole", model.Idrole);
            cmd.Parameters.AddWithValue("@idpantalla", model.Idpantalla);
            cmd.Parameters.AddWithValue("@acceso", model.Acceso);
            return Conexion.getInstance().ejecutarSP(cmd);
        }


     

        public bool existsPantallaParaRol(int idRole, int idpantalla)
        {

            bool existe = false;
            string query = $"SELECT 1 FROM permisospantalla WHERE idrole = {idRole} AND idpantalla = {idpantalla}";

            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);

            if (reader.Read()) // Verificar si hay al menos un registro
            {
                existe = true;
            }

            reader.Close();

            return existe;
        }




        public bool save(List<permisospantalla> models)
        {
            throw new NotImplementedException();
        }

        public bool update(permisospantalla model)
        {
            SqlCommand cmd = new SqlCommand("SP_Actualizarpermisospantalla", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idrole", model.Idrole);
            cmd.Parameters.AddWithValue("@idpantalla", model.Idpantalla);
            cmd.Parameters.AddWithValue("@acceso", model.Acceso);
           

            return Conexion.getInstance().ejecutarSP(cmd);
        }
    }
}
