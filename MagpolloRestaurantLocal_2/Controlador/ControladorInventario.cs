using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTRchicken.Modelo;
using System.Data.SqlClient;

namespace AppTRchicken.Controlador
{
    class ControladorInventario : DAOimpl<inventario>
    {

        private static ControladorInventario instance = new ControladorInventario();

        private ControladorInventario()
        {

        }

        internal static ControladorInventario Instance
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




        public bool delete(inventario model)
        {
           
            SqlCommand cmd = new SqlCommand("SP_EliminarInventario", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idinventario", model.Idinventario);
            return Conexion.getInstance().ejecutarSP(cmd);

        }

        public inventario find(int id)
        {
            throw new NotImplementedException();
        }

        public List<inventario> findAll()
        {
            List<inventario> inventarios = new List<inventario>();
            string query = "SELECT * FROM V_inventario";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                inventario inventario = new inventario();
                inventario.Idinventario = reader.GetInt64(0);
                inventario.Nombreproducto = reader.GetString(1);
                inventario.Existencia = (int)reader.GetInt32(2);
                inventario.Costo = reader.GetDecimal(3);
                inventario.Precioventa = reader.GetDecimal(4);
                



                inventarios.Add(inventario);

            }
            reader.Close();
            return inventarios;
        }
        public inventario findidbynombre(string nombre)
        {

            inventario inventario = new inventario();

            string query = $"SELECT * FROM V_inventario WHERE nombreproducto = '{nombre}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                inventario.Idinventario = reader.GetInt64(0);
                inventario.Nombreproducto = reader.GetString(1);
                inventario.Existencia = (int)reader.GetInt32(2);
                inventario.Costo = reader.GetDecimal(3);
                inventario.Precioventa = reader.GetDecimal(4);



            }

            reader.Close();
            return inventario;
        }

        public inventario findnombrebyid(int id)
        {

            inventario inventario = new inventario();

            string query = $"SELECT * FROM V_inventario WHERE idinventario = '{id}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                inventario.Idinventario = reader.GetInt64(0);
                inventario.Nombreproducto = reader.GetString(1);
                inventario.Existencia = (int)reader.GetInt32(2);
                inventario.Costo = reader.GetDecimal(3);
                inventario.Precioventa = reader.GetDecimal(4);



            }

            reader.Close();
            return inventario;
        }

        public bool save(inventario model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevoInventario", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombreproducto", model.Nombreproducto);
            cmd.Parameters.AddWithValue("@existencia", model.Existencia);
            cmd.Parameters.AddWithValue("@costo", model.Costo);
            cmd.Parameters.AddWithValue("@precioventa", model.Precioventa);
            
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<inventario> models)
        {
            throw new NotImplementedException();
        }

        public bool update(inventario model)
        {
           

            SqlCommand cmd = new SqlCommand("SP_ActualizarInventario", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idinventario", model.Idinventario);
            cmd.Parameters.AddWithValue("@nombreproducto", model.Nombreproducto);
            cmd.Parameters.AddWithValue("@existencia", model.Existencia);
            cmd.Parameters.AddWithValue("@costo", model.Costo);
            cmd.Parameters.AddWithValue("@precioventa", model.Precioventa);
            return Conexion.getInstance().ejecutarSP(cmd);
        }
    }
}
