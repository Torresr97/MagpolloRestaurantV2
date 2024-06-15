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
    class ControladorPantallas : DAOimpl<pantallas>
    {
        private static ControladorPantallas instance = new ControladorPantallas();


        private ControladorPantallas()
        {

        }

        internal static ControladorPantallas Instance
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



        public bool delete(pantallas model)
        {
            throw new NotImplementedException();
        }

        public pantallas find(int id)
        {
            throw new NotImplementedException();
        }
        public pantallas findIdbyname(string nombrepantalla)
        {

            pantallas pantallas = new pantallas();
            string query = $"SELECT idpantalla FROM pantallas  WHERE nombrepantalla =  '{nombrepantalla}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {

                pantallas.Idpantalla = reader.GetInt64(0);

            }
            reader.Close();
            return pantallas;


        }
        public List<pantallas> findAll()
        {

            List<pantallas> pantallas = new List<pantallas>();
            string query = "SELECT * FROM pantallas";
            SqlDataReader lector = Conexion.getInstance().ejecutarqueryleer(query);
            while (lector.Read())
            {
                pantallas pantalla = new pantallas();
                pantalla.Idpantalla = lector.GetInt64(0);
                pantalla.Nombrepantalla = lector.GetString(1);




                pantallas.Add(pantalla);

                }
                lector.Close();
                return pantallas;
            }

        public List<pantallas> findAllpermisos(int idrole)
        {

            List<pantallas> pantallas = new List<pantallas>();
            string query = $"SELECT * FROM V_permisopantallas where idrole={idrole} ";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                pantallas pantalla = new pantallas();



                pantalla.Nombrepantalla = reader.GetString(3);

                pantallas.Add(pantalla);

            }
            reader.Close();
            return pantallas;
        }
        public bool save(pantallas model)
        {

            SqlCommand cmd = new SqlCommand("SP_NuevaPantalla", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombrepantalla", model.Nombrepantalla);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<pantallas> models)
        {
            throw new NotImplementedException();
        }

        public bool update(pantallas model)
        {
            throw new NotImplementedException();
        }
    }
}
