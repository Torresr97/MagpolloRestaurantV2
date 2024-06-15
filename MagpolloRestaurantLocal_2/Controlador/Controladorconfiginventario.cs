using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTRchicken.Modelo;
using System.Data.SqlClient;

using AppTRchicken.Controlador;

namespace AppTRchicken.Controlador
{
    class Controladorconfiginventario : DAOimpl<configinventario>
    {
        private static Controladorconfiginventario instance = new Controladorconfiginventario();


        internal static Controladorconfiginventario Instance
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

        public bool delete(configinventario model)
        {
            SqlCommand cmd = new SqlCommand("SP_Eliminarconfiguracioninventario", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idconfiginventario", model.Idconfiginventario);

            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public configinventario find(int id)
        {
            throw new NotImplementedException();
        }

        public List<configinventario> findAll()
        {
            throw new NotImplementedException();
        }

        public List<configinventario> findbyid(long idmenu)
        {
            List<configinventario> cinv = new List<configinventario>();
            string query = $"SELECT * from  V_Configinventario WHERE idmenu = '{idmenu}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                configinventario configinventario = new configinventario();
                configinventario.Idconfiginventario = (int)reader.GetInt64(0);
                configinventario.Idmenu = (int)reader.GetInt64(1);
                configinventario.Idinventario = (int)reader.GetInt64(2);
                configinventario.Cantidadrestar = reader.GetInt32(3);

                cinv.Add(configinventario);

            }
            reader.Close();
            return cinv;
        }

        public bool updateinventario(configinventario model)
        {
            SqlCommand cmd = new SqlCommand("SP_Restarinventario", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idinventario", model.Idinventario);
            cmd.Parameters.AddWithValue("@cantidadrestar", model.Cantidadrestar);

            return Conexion.getInstance().ejecutarSP(cmd);
        }



        public bool updatesumarinventario(configinventario model)
        {
            SqlCommand cmd = new SqlCommand("SP_Sumarinventario", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idinventario", model.Idinventario);
            cmd.Parameters.AddWithValue("@cantidadsumar", model.Cantidadrestar);

            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(configinventario model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevaConfiginventario", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idmenu", model.Idmenu);
            cmd.Parameters.AddWithValue("@idinventario", model.Idinventario);
            cmd.Parameters.AddWithValue("@cantidadrestar", model.Cantidadrestar);

            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<configinventario> models)
        {
            throw new NotImplementedException();
        }

        public bool update(configinventario model)
        {
            throw new NotImplementedException();
        }
    }

   
    
}
