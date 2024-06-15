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
    class ControladorCaja : DAOimpl<caja>
    {
        private static ControladorCaja instance = new ControladorCaja();


        internal static ControladorCaja Instance
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

        public caja totaldepositoycierre(string fecha, string tipo, int numerocierre)
        {
            caja caja = new caja();
            string query = $"SELECT ISNULL(SUM(totalefectivo), 0) as total from caja WHERE fecha = '{fecha}'  AND tipo = '{tipo}' AND numerotipo = '{numerocierre}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


            while (reader.Read())
            {

                caja.Totalefectivo = reader.GetDecimal(0);


            }
            reader.Close();
            return caja;

        }



        public bool delete(caja model)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarCaja", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcaja", model.Idcaja);
          
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public caja find(int id)
        {
            throw new NotImplementedException();
        }

        public List<caja> findAll()
        {
            throw new NotImplementedException();
        }


        public List<caja> Registrosxtipoxfecha(string tipo, string fecha)
        {
            List<caja> cajas = new List<caja>();
            string query = $"SELECT * from caja WHERE TIPO = '{tipo}' AND fecha = '{ fecha}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                caja caja = new caja();
                caja.Tipo = reader.GetString(1);
                caja.Motivo = reader.GetString(2);
                caja.Totalefectivo = reader.GetDecimal(3);
                caja.Fecha = (reader.GetDateTime(6)).ToString();

                cajas.Add(caja);

            }
            reader.Close();
            return cajas;
        }

        public List<caja> Registrosxtipoxfechaxcierre(string tipo, string fecha, int numerocierre)
        {
            List<caja> cajas = new List<caja>();
            string query = $"SELECT * from caja WHERE TIPO = '{tipo}' AND fecha = '{ fecha}' AND numerotipo = '{numerocierre}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                caja caja = new caja();
                caja.Idcaja = reader.GetInt64(0);
                caja.Tipo = reader.GetString(1);
                caja.Motivo = reader.GetString(2);
                caja.Totalefectivo = reader.GetDecimal(3);
                caja.Fecha = (reader.GetDateTime(6)).ToString();

                cajas.Add(caja);

            }
            reader.Close();
            return cajas;
        }

        public bool save(caja model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevaCaja", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tipo", model.Tipo);
            cmd.Parameters.AddWithValue("@motivo", model.Motivo);
            cmd.Parameters.AddWithValue("@totalefectivo", model.Totalefectivo);
            cmd.Parameters.AddWithValue("@totaltarjeta", model.Totaltarjeta);
            cmd.Parameters.AddWithValue("@ventatotal", model.Ventatotal);
            cmd.Parameters.AddWithValue("@fecha", model.Fecha);
            cmd.Parameters.AddWithValue("@numerotipo", model.Numerotipo);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<caja> models)
        {
            throw new NotImplementedException();
        }

        public bool update(caja model)
        {
            throw new NotImplementedException();
        }


        public caja findgrupocierre(string fecha)
        {
            caja caja = new caja();
            string query = $"SELECT ISNULL(MAX(numerotipo), 0) FROM caja WHERE tipo = '{"Cierre de Caja"}' AND fecha = '{ fecha}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


            while (reader.Read())
            {

                caja.Numerotipo = reader.GetInt32(0);


            }



            reader.Close();
            return caja;


        }



        /******************************Aqui se hacen la consulta para obtener todos los movimientos para el reporte de movimientos**********************/
        public List<caja> ReportemovimientosDia(string tipo, string fecha)
        {
            List<caja> cajas = new List<caja>();
            string query = $"SELECT * from caja WHERE TIPO = '{tipo}' AND fecha = '{ fecha}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                caja caja = new caja();
                caja.Idcaja = reader.GetInt64(0);
                caja.Tipo = reader.GetString(1);
                caja.Motivo = reader.GetString(2);
                caja.Totalefectivo = reader.GetDecimal(3);
                caja.Totaltarjeta = reader.GetDecimal(4);
                caja.Ventatotal = reader.GetDecimal(5);
                caja.Fecha = (reader.GetDateTime(6)).ToString();

                cajas.Add(caja);

            }
            reader.Close();
            return cajas;
        }


        public List<caja> ReportemovimientosMes(string tipo, string mes, string ano)
        {
            List<caja> cajas = new List<caja>();
            string query = $"SELECT * from caja WHERE TIPO = '{tipo}' AND MONTH(fecha) = '{mes}' AND YEAR(fecha)='{ano}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                caja caja = new caja();
                caja.Idcaja = reader.GetInt64(0);
                caja.Tipo = reader.GetString(1);
                caja.Motivo = reader.GetString(2);
                caja.Totalefectivo = reader.GetDecimal(3);
                caja.Totaltarjeta = reader.GetDecimal(4);
                caja.Ventatotal = reader.GetDecimal(5);
                caja.Fecha = (reader.GetDateTime(6)).ToString();

                cajas.Add(caja);

            }
            reader.Close();
            return cajas;
        }


        public List<caja> ReportemovimientosAno(string tipo, string ano)
        {
            List<caja> cajas = new List<caja>();
            string query = $"SELECT * from caja WHERE TIPO = '{tipo}' AND YEAR(fecha)='{ano}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                caja caja = new caja();
                caja.Idcaja = reader.GetInt64(0);
                caja.Tipo = reader.GetString(1);
                caja.Motivo = reader.GetString(2);
                caja.Totalefectivo = reader.GetDecimal(3);
                caja.Totaltarjeta = reader.GetDecimal(4);
                caja.Ventatotal = reader.GetDecimal(5);
                caja.Fecha = (reader.GetDateTime(6)).ToString();

                cajas.Add(caja);

            }
            reader.Close();
            return cajas;
        }


        public List<caja> ReportemovimientosDesdeHasta(string tipo, string desde, string hasta)
        {
            List<caja> cajas = new List<caja>();
            string query = $"SELECT * from caja WHERE TIPO = '{tipo}' AND fecha BETWEEN  '{desde}' AND '{hasta}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                caja caja = new caja();
                caja.Idcaja = reader.GetInt64(0);
                caja.Tipo = reader.GetString(1);
                caja.Motivo = reader.GetString(2);
                caja.Totalefectivo = reader.GetDecimal(3);
                caja.Totaltarjeta = reader.GetDecimal(4);
                caja.Ventatotal = reader.GetDecimal(5);
                caja.Fecha = (reader.GetDateTime(6)).ToString();

                cajas.Add(caja);

            }
            reader.Close();
            return cajas;
        }


        /******************************Aqui se hacen la consulta para obtener todos los movimientos para el reporte de movimientos**********************/
    }
}
