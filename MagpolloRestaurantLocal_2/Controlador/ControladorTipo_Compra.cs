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
    class ControladorTipo_Compra : DAOimpl<tipo_compra>
    {



        private static ControladorTipo_Compra instance = new ControladorTipo_Compra();


        private ControladorTipo_Compra()
        {

        }

        internal static ControladorTipo_Compra Instance
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
        public bool delete(tipo_compra model)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarTipoCompra", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idtipocompra", model.Idtipocompra);


            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public tipo_compra find(int id)
        {
            throw new NotImplementedException();
        }


        public tipo_compra findnombrenyid(int id)
        {
            tipo_compra tipo_compra = new tipo_compra();
            string query = $"SELECT nombretipocompra FROM tipo_compra where idtipocompra ='{ id}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


            while (reader.Read())
            {

                tipo_compra.Nombretipocompra = reader.GetString(0);


            }



            reader.Close();
            return tipo_compra;

        }

        public List<tipo_compra> findAll()
        {
            List<tipo_compra> tipo_compra = new List<tipo_compra>();
            string query = "SELECT * FROM V_TipoCompra";
            SqlDataReader lector = Conexion.getInstance().ejecutarqueryleer(query);
            while (lector.Read())
            {
                tipo_compra tipo_compras = new tipo_compra();
                tipo_compras.Idtipocompra = lector.GetInt64(0);
                tipo_compras.Nombretipocompra = lector.GetString(1);



                tipo_compra.Add(tipo_compras);

            }
            lector.Close();
            return tipo_compra;

        }

        public bool save(tipo_compra model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevoTipoCompra", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombretipocompra", model.Nombretipocompra);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<tipo_compra> models)
        {
            throw new NotImplementedException();
        }

        public bool update(tipo_compra model)
        {


            SqlCommand cmd = new SqlCommand("SP_ActualizarTipoCompra", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idtipocompra", model.Idtipocompra);
            cmd.Parameters.AddWithValue("@nombretipocompra", model.Nombretipocompra);

            return Conexion.getInstance().ejecutarSP(cmd);

        }
    }
}
