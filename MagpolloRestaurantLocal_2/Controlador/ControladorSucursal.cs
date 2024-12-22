using AppTRchicken.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Controlador
{
    class ControladorSucursal : DAOimpl<sucursales>
    {
        private static ControladorSucursal instance = new ControladorSucursal();

        private ControladorSucursal()
        {

        }

        internal static ControladorSucursal Instance
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
        public bool delete(sucursales model)
        {
            throw new NotImplementedException();
        }

        public sucursales find()
        {
            sucursales sucursal = new sucursales();
            string query = "SELECT TOP 1 * FROM V_Sucursales ORDER BY idsucursal DESC";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            try
            {
                while (reader.Read())
                {
                    sucursal.Idsucursal = (int)reader.GetInt64(0);
                    sucursal.Nombresucursal = reader.GetString(1);
                    sucursal.Direccion = reader.GetString(2);
                    sucursal.Celular = reader.GetString(5);
                    sucursal.Correo = reader.GetString(6);
                    sucursal.Rtn = reader.GetString(7);
                    sucursal.Cai = reader.GetString(8);
                    sucursal.Fecha_emision = reader.GetDateTime(9);
                    sucursal.Rangodesde = reader.GetString(10);
                    sucursal.Rangohasta = reader.GetString(11);
                    sucursal.Facturarconcai = reader.GetBoolean(12);
                }
            }
            finally
            {
                reader.Close();
            }
            return sucursal;
        }


        public sucursales find(int id)
        {
            throw new NotImplementedException();
        }

        public List<sucursales> findAll()
        {
            List<sucursales> sucursales = new List<sucursales>();
            string query = "SELECT * FROM V_Sucursales";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                sucursales sucursal = new sucursales();
                sucursal.Idsucursal = (int)reader.GetInt64(0);
                sucursal.Nombresucursal = reader.GetString(1);
                sucursal.Direccion =  reader.GetString(2);
                sucursal.Celular = reader.GetString(5);
                sucursal.Correo = reader.GetString(6);
                sucursal.Rtn = reader.GetString(7);
                sucursal.Cai = reader.GetString(8);
                sucursal.Fecha_emision = reader.GetDateTime(9);
                sucursal.Rangodesde = reader.GetString(10);
                sucursal.Rangohasta = reader.GetString(11);
                sucursal.Facturarconcai = reader.GetBoolean(12);
                sucursales.Add(sucursal);
            }
            reader.Close();
            return sucursales;
        }


        public List<sucursales> findbyid()
        {
            List<sucursales> sucursales = new List<sucursales>();
            string query = "SELECT * FROM V_Sucursales WHERE idsucursal = 1";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                sucursales sucursal = new sucursales();
                sucursal.Idsucursal = (int)reader.GetInt64(0);
                sucursal.Nombresucursal = reader.GetString(1);
                sucursal.Direccion = reader.GetString(2);
                sucursal.Celular = reader.GetString(5);
                sucursal.Correo = reader.GetString(6);
                sucursal.Rtn = reader.GetString(7);
                sucursal.Cai = reader.GetString(8);
                sucursal.Fecha_emision = reader.GetDateTime(9);
                sucursal.Rangodesde = reader.GetString(10);
                sucursal.Rangohasta = reader.GetString(11);
                sucursal.Facturarconcai = reader.GetBoolean(12);
                sucursales.Add(sucursal);
            }
            reader.Close();
            return sucursales;
        }
        public bool save(sucursales model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevoSucursal", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombresucursal", model.Nombresucursal);
            cmd.Parameters.AddWithValue("@direccion", model.Direccion);
            cmd.Parameters.AddWithValue("@celular", model.Celular);
            cmd.Parameters.AddWithValue("@correo", model.Correo);
            cmd.Parameters.AddWithValue("@rtn", model.Rtn);
            cmd.Parameters.AddWithValue("@cai", model.Cai);
            cmd.Parameters.AddWithValue("@fechaemision", model.Fecha_emision);
            cmd.Parameters.AddWithValue("@rangodesde", model.Rangodesde);
            cmd.Parameters.AddWithValue("@rangohasta", model.Rangohasta);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<sucursales> models)
        {
            throw new NotImplementedException();
        }

        public bool update(sucursales model)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarSucursal", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idsucursal", model.Idsucursal);
            cmd.Parameters.AddWithValue("@nombresucursal", model.Nombresucursal);
            cmd.Parameters.AddWithValue("@direccion", model.Direccion);
            cmd.Parameters.AddWithValue("@celular", model.Celular);
            cmd.Parameters.AddWithValue("@correo", model.Correo);
            cmd.Parameters.AddWithValue("@rtn", model.Rtn);
            cmd.Parameters.AddWithValue("@cai", model.Cai);
            cmd.Parameters.AddWithValue("@fechaemision", model.Fecha_emision);
            cmd.Parameters.AddWithValue("@rangodesde", model.Rangodesde);
            cmd.Parameters.AddWithValue("@rangohasta", model.Rangohasta);
            return Conexion.getInstance().ejecutarSP(cmd);
        }
    }
}
