using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTRchicken.Modelo;
using System.Data.SqlClient;

namespace AppTRchicken.Controlador
{
    class ControladorDetallepagomixto : DAOimpl<DetallePagoMixto>
    {

        private static ControladorDetallepagomixto instance = new ControladorDetallepagomixto();

        private ControladorDetallepagomixto()
        {

        }

        internal static ControladorDetallepagomixto Instance
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
        public bool delete(DetallePagoMixto model)
        {
            throw new NotImplementedException();
        }

        public DetallePagoMixto find(int id)
        {

            DetallePagoMixto DetallePagoMixto = new DetallePagoMixto();

            string query = $"SELECT * FROM DetallePagoMixto WHERE Idfactura = '{id}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                DetallePagoMixto.IdDetallePagoMixto = reader.IsDBNull(0) ? 0 : (int)reader.GetInt64(0);
                DetallePagoMixto.IdFactura = reader.IsDBNull(1) ? 0 : (int)reader.GetInt64(1);
                DetallePagoMixto.MetodoPago = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                DetallePagoMixto.Monto = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                DetallePagoMixto.Fecha = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4);
                DetallePagoMixto.Numerocierre = reader.IsDBNull(5) ? 0 : (int)reader.GetInt64(5);


            }

            reader.Close();
            return DetallePagoMixto;
        }

        public List<DetallePagoMixto> findAll()
        {
            throw new NotImplementedException();
        }

        public bool save(DetallePagoMixto model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevoDetallePagoMixto", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFactura", model.IdFactura);
            cmd.Parameters.AddWithValue("@MetodoPago", model.MetodoPago);
            cmd.Parameters.AddWithValue("@Monto", model.Monto);
            cmd.Parameters.AddWithValue("@Fecha", model.Fecha);
            cmd.Parameters.AddWithValue("@numerocierre", model.Numerocierre);
            cmd.Parameters.AddWithValue("@estado", model.Estado);

            return Conexion.getInstance().ejecutarSP(cmd);
        }
        public DetallePagoMixto totalefectivoMixto(string fecha, string tipo, int numerocierre)
        {
            DetallePagoMixto DetallePagoMixto = new DetallePagoMixto();
            // Modificamos la consulta para comparar solo la parte de la fecha sin la hora
            string query = $"SELECT ISNULL(SUM(Monto), 0) as total FROM DetallePagoMixto " +
                           $"WHERE CONVERT(DATE, fecha) = CONVERT(DATE, '{fecha}') " +  // Convertimos el campo fecha a solo fecha
                           $"AND MetodoPago = '{tipo}' AND numerocierre = '{numerocierre}' and Estado = 1";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


            while (reader.Read())
            {

                DetallePagoMixto.Monto = reader.GetDecimal(0);

            }
            reader.Close();
            return DetallePagoMixto;

        }

        public DetallePagoMixto totaTarjetaMixto(string fecha, string tipo, int numerocierre)
        {
            DetallePagoMixto DetallePagoMixto = new DetallePagoMixto();
            // Modificamos la consulta para comparar solo la parte de la fecha sin la hora
            string query = $"SELECT ISNULL(SUM(Monto), 0) as total FROM DetallePagoMixto " +
                           $"WHERE CONVERT(DATE, fecha) = CONVERT(DATE, '{fecha}') " +  // Convertimos el campo fecha a solo fecha
                           $"AND MetodoPago = '{tipo}' AND numerocierre = '{numerocierre}' and Estado = 1";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


            while (reader.Read())
            {

                DetallePagoMixto.Monto = reader.GetDecimal(0);

            }
            reader.Close();
            return DetallePagoMixto;

        }
        public bool updateDesactivarEstado(DetallePagoMixto model)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarEstado", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFactura", model.IdFactura);
            cmd.Parameters.AddWithValue("@estado", model.Estado);

            return Conexion.getInstance().ejecutarSP(cmd);
        }
        public bool save(List<DetallePagoMixto> models)
        {
            throw new NotImplementedException();
        }

        public bool update(DetallePagoMixto model)
        {
            throw new NotImplementedException();
        }
    }
}
