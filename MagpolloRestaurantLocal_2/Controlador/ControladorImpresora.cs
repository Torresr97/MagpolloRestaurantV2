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
    class ControladorImpresora : DAOimpl<impresoras>
    {
        private static ControladorImpresora instance = new ControladorImpresora();


        private ControladorImpresora()
        {

        }

        internal static ControladorImpresora Instance
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



        public bool delete(impresoras model)
        {
            throw new NotImplementedException();
        }

        public impresoras find(int id)
        {
            throw new NotImplementedException();
        }

        public List<impresoras> findAll()
        {
            List<impresoras> impresoras = new List<impresoras>();
            string query = "SELECT * FROM V_Impresoras";
            SqlDataReader lector = Conexion.getInstance().ejecutarqueryleer(query);
            while (lector.Read())
            {
                impresoras impresora = new impresoras();
                impresora.Idimpresora = lector.GetInt64(0);
                impresora.Nombreimpresora = lector.GetString(1);
                impresora.Ticktes = lector.GetInt32(2);



                impresoras.Add(impresora);

            }
            lector.Close();
            return impresoras;
        }
        public impresoras findconfig()
        {
            impresoras impresora = new impresoras();
            string query = $"SELECT * FROM V_Impresoras WHERE idimpresora = {1}";
            SqlDataReader lector = Conexion.getInstance().ejecutarqueryleer(query);
            while (lector.Read())
            {

                impresora.Idimpresora = lector.GetInt64(0);
                impresora.Nombreimpresora = lector.GetString(1);
                impresora.Ticktes = lector.GetInt32(2);


            }
            lector.Close();
            return impresora;


        }

        public bool save(impresoras model)
        {
            throw new NotImplementedException();
        }

        public bool save(List<impresoras> models)
        {
            throw new NotImplementedException();
        }

        public bool update(impresoras model)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarImpresora", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idimpresora", model.Idimpresora);
            cmd.Parameters.AddWithValue("@nombreimpresora", model.Nombreimpresora);
            cmd.Parameters.AddWithValue("@cantidadtickets", model.Ticktes);
            return Conexion.getInstance().ejecutarSP(cmd);
        }
    }
}
