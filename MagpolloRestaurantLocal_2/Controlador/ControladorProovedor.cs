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
    class ControladorProveedor : DAOimpl<proovedor>
    {

        private static ControladorProveedor instance = new ControladorProveedor();


        private ControladorProveedor()
        {

        }

        internal static ControladorProveedor Instance
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







        public bool delete(proovedor model)
        {

            SqlCommand cmd = new SqlCommand("SP_EliminarProovedor", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idproovedor", model.Idproovedor);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public proovedor find(int id)
        {
            throw new NotImplementedException();
        }

      

        
        public bool save(proovedor model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevoProveedor", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_empresa", model.Nombre_empresa);
            cmd.Parameters.AddWithValue("@rtn", model.Rtn);
            cmd.Parameters.AddWithValue("@celular", model.Celular);
            cmd.Parameters.AddWithValue("@correo", model.Correo);
            cmd.Parameters.AddWithValue("@direccion", model.Direccion);
            cmd.Parameters.AddWithValue("@nombre_encargado", model.Nombre_encargado);
            return Conexion.getInstance().ejecutarSP(cmd);
        }
        public proovedor findnombrenyid(int id)
        {
            proovedor proovedor = new proovedor();
            string query = $"SELECT nombre_empresa FROM proovedor where idproovedor = '{ id}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


            while (reader.Read())
            {

                proovedor.Nombre_empresa = reader.GetString(0);


            }



            reader.Close();
            return proovedor;

        }

        public proovedor findidbynombre(string  nombre)
        {
            proovedor proovedor = new proovedor();
            string query = $"SELECT idproovedor FROM proovedor where nombre_empresa = '{nombre}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


            while (reader.Read())
            {

                proovedor.Idproovedor = (int)reader.GetInt64(0);


            }



            reader.Close();
            return proovedor;

        }
        public bool save(List<proovedor> models)
        {
            throw new NotImplementedException();
        }

        public bool update(proovedor model)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarProovedor", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idproovedor", model.Idproovedor);
            cmd.Parameters.AddWithValue("@nombre_empresa", model.Nombre_empresa);
            cmd.Parameters.AddWithValue("@rtn", model.Rtn);
            cmd.Parameters.AddWithValue("@celular", model.Celular);
            cmd.Parameters.AddWithValue("@correo", model.Correo);
            cmd.Parameters.AddWithValue("@direccion", model.Direccion);
            cmd.Parameters.AddWithValue("@nombre_encargado", model.Nombre_encargado);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public List<proovedor> findAll()
        {
            List<proovedor> proovedores = new List<proovedor>();
            string query = "SELECT * FROM V_Proovedor";
            SqlDataReader lector = Conexion.getInstance().ejecutarqueryleer(query);
            while (lector.Read())
            {
                proovedor proovedor = new proovedor();
                proovedor.Idproovedor = (int)lector.GetInt64(0);
                proovedor.Nombre_empresa = lector.GetString(1);
                proovedor.Rtn = lector.GetString(2);
                proovedor.Celular = lector.GetString(3);
                proovedor.Correo = lector.GetString(4);
                proovedor.Direccion = lector.GetString(5);
                proovedor.Nombre_encargado = lector.GetString(6);



                proovedores.Add(proovedor);

            }
            lector.Close();
            return proovedores;

        }
    }
}
