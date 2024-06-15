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
    class Controladortipocomplemento_plato : DAOimpl<tipocomplemento_plato>
    {
        private static Controladortipocomplemento_plato instance = new Controladortipocomplemento_plato();


        private Controladortipocomplemento_plato()
        {

        }

        internal static Controladortipocomplemento_plato Instance
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


        public tipocomplemento_plato findIdbyname(string nombretipocomplemento)
        {

            tipocomplemento_plato tipocomplemento_plato = new tipocomplemento_plato();
            string query = $"SELECT [idtipocomplemento_plato] FROM tipocomplemento_plato WHERE [nombrecomplemento_plato] = '{nombretipocomplemento}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {

                tipocomplemento_plato.Idtipocomplemento_plato = reader.GetInt64(0);

            }
            reader.Close();
            return tipocomplemento_plato;


        }


        public tipocomplemento_plato findnamebyID(long idtipocomplemento)
        {

            tipocomplemento_plato tipocomplemento_plato = new tipocomplemento_plato();
            string query = $"SELECT [nombrecomplemento_plato] FROM tipocomplemento_plato WHERE [idtipocomplemento_plato] = {idtipocomplemento}";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                
                tipocomplemento_plato.Nombretipocomplemento_plato = reader.GetString(0);

            }
            reader.Close();
            return tipocomplemento_plato;


        }


        public bool delete(tipocomplemento_plato model)
        {
            throw new NotImplementedException();
        }

        public tipocomplemento_plato find(int id)
        {
            throw new NotImplementedException();
        }

        public List<tipocomplemento_plato> findAll()
        {
            List<tipocomplemento_plato> tipocomplemento_platos = new List<tipocomplemento_plato>();
            string query = "SELECT * FROM tipocomplemento_plato";
            SqlDataReader lector = Conexion.getInstance().ejecutarqueryleer(query);
            while (lector.Read())
            {
                tipocomplemento_plato tipocomplemento_plato = new tipocomplemento_plato();
                tipocomplemento_plato.Idtipocomplemento_plato = lector.GetInt64(0);
                tipocomplemento_plato.Nombretipocomplemento_plato = lector.GetString(1);
                tipocomplemento_platos.Add(tipocomplemento_plato);

            }
            lector.Close();
            return tipocomplemento_platos;
        }

        public bool save(tipocomplemento_plato model)
        {
            SqlCommand cmd = new SqlCommand("SP_Nuevotipocomplementoplato", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombrecomplemento_plato", model.Nombretipocomplemento_plato);

            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<tipocomplemento_plato> models)
        {
            throw new NotImplementedException();
        }

        public bool update(tipocomplemento_plato model)
        {
            SqlCommand cmd = new SqlCommand("SP_Actualizartipocomplementoplato", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idtipocomplemento_plato", model.Idtipocomplemento_plato);
            cmd.Parameters.AddWithValue("@nombrecomplemento_plato", model.Nombretipocomplemento_plato);

            return Conexion.getInstance().ejecutarSP(cmd);
        }


        public DataTable Cargarcomboxtipocomplemento()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idtipocomplemento_plato, nombrecomplemento_plato FROM tipocomplemento_plato", Conexion.getInstance().getconexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }


    }
}
