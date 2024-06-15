using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTRchicken.Modelo;
using System.Data.SqlClient;


namespace AppTRchicken.Controlador
{
    class ControladorEntradainventario : DAOimpl<entrada_inventario>
    {
        private static ControladorEntradainventario instance = new ControladorEntradainventario();
        private ControladorEntradainventario()
        {

        }

        internal static ControladorEntradainventario Instance
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

        public bool delete(entrada_inventario model)
        {
            throw new NotImplementedException();
        }

        public entrada_inventario find(int id)
        {
            throw new NotImplementedException();
        }



        public List<entrada_inventario> findAll()
        {
            throw new NotImplementedException();
        }

        public List<entrada_inventario> findAllbyid(long id)
        {
            List<entrada_inventario> entrada_inventarios = new List<entrada_inventario>();

            string query = $"SELECT * FROM V_Entradainventario WHERE idinventario = '{id}' AND CONVERT(DATE, fecha_ingreso) = CONVERT(DATE, GETDATE())";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                entrada_inventario entrada_inventario = new entrada_inventario();
                entrada_inventario.Identradainventario = reader.GetInt64(0);
                entrada_inventario.Idinventario = reader.GetInt64(1);
                entrada_inventario.Idproovedor = (int)reader.GetInt64(2);
                entrada_inventario.Cantidad = reader.GetInt32(3);
                entrada_inventario.Fecha_ingreso = reader.GetDateTime(4);


                entrada_inventarios.Add(entrada_inventario);
            }

            reader.Close();
            return entrada_inventarios;
        }

        public bool save(entrada_inventario model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevaEntradainventario", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idinventario", model.Idinventario);
            cmd.Parameters.AddWithValue("@idproovedor", model.Idproovedor);
            cmd.Parameters.AddWithValue("@cantidad", model.Cantidad);
            cmd.Parameters.AddWithValue("@fechaingreso", model.Fecha_ingreso);

            return Conexion.getInstance().ejecutarSP(cmd);
            
        }

        public bool save(List<entrada_inventario> models)
        {
            throw new NotImplementedException();
        }

        public bool update(entrada_inventario model)
        {
            throw new NotImplementedException();
        }
    }
    }
