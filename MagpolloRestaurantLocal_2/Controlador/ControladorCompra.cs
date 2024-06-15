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
using AppTRchicken.Utilidades;

namespace AppTRchicken.Controlador
{
    class ControladorCompra : DAOimpl<Compra>
    {
        private static ControladorCompra instance = new ControladorCompra();


        private ControladorCompra()
        {

        }

        internal static ControladorCompra Instance
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


        public bool delete(Compra model)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarCompra", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcompra", model.Idcompra);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public Compra find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Compra> findAll()
        {
            List<Compra> compras = new List<Compra>();
            string query = $"SELECT * FROM V_Compras WHERE fecha ='{Globales.fecha}'";
            SqlDataReader lector = Conexion.getInstance().ejecutarqueryleer(query);
            while (lector.Read())
            {
                Compra compra = new Compra();
                compra.Idcompra = lector.GetInt64(0);
                compra.Nombre_compra = lector.GetString(1);
                compra.Idtipocompra = lector.GetInt64(2);
                compra.Idproovedor = lector.GetInt64(3);
                compra.Total = lector.GetDecimal(4);
                compra.Fecha = (lector.GetDateTime(5)).ToString();



                compras.Add(compra);

            }
            lector.Close();
            return compras;
        }

        public bool save(Compra model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevoCompra", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre_compra", model.Nombre_compra);
            cmd.Parameters.AddWithValue("@idtipocompra", model.Idtipocompra);
            cmd.Parameters.AddWithValue("@idproovedor", model.Idproovedor);
            cmd.Parameters.AddWithValue("@total", model.Total);
            cmd.Parameters.AddWithValue("@fecha", model.Fecha);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<Compra> models)
        {
            throw new NotImplementedException();
        }

        public bool update(Compra model)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarCompra", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcompra", model.Idcompra);
            cmd.Parameters.AddWithValue("@nombre_compra", model.Nombre_compra);
            cmd.Parameters.AddWithValue("@idtipocompra", model.Idtipocompra);
            cmd.Parameters.AddWithValue("@idproovedor", model.Idproovedor);
            cmd.Parameters.AddWithValue("@total", model.Total);
            cmd.Parameters.AddWithValue("@fecha", model.Fecha);
            return Conexion.getInstance().ejecutarSP(cmd);
        }







        public List<Compra> FincompraFecha(string fecha)
        {
            List<Compra> compras = new List<Compra>();
            string query = $"SELECT * from V_Compras WHERE fecha = '{fecha}'";
            SqlDataReader lector = Conexion.getInstance().ejecutarqueryleer(query);
            while (lector.Read())
            {
                Compra compra = new Compra();
                compra.Idcompra = lector.GetInt64(0);
                compra.Nombre_compra = lector.GetString(1);
                compra.Idtipocompra = lector.GetInt64(2);
                compra.Idproovedor = lector.GetInt64(3);
                compra.Total = lector.GetDecimal(4);
                compra.Fecha = (lector.GetDateTime(5)).ToString();



                compras.Add(compra);

            }
            lector.Close();
            return compras;

        }
        public List<Compra> Fincomprames(string mes, string ano)
        {
            List<Compra> compras = new List<Compra>();
            string query = $"SELECT * from V_Compras WHERE MONTH(fecha) = '{mes}' AND YEAR(fecha) = '{ano}'";
            SqlDataReader lector = Conexion.getInstance().ejecutarqueryleer(query);
            while (lector.Read())
            {
                Compra compra = new Compra();
                compra.Idcompra = lector.GetInt64(0);
                compra.Nombre_compra = lector.GetString(1);
                compra.Idtipocompra = lector.GetInt64(2);
                compra.Idproovedor = lector.GetInt64(3);
                compra.Total = lector.GetDecimal(4);
                compra.Fecha = (lector.GetDateTime(5)).ToString();



                compras.Add(compra);

            }
            lector.Close();
            return compras;

        }


        public List<Compra> Fincompraano(string ano)
        {
            List<Compra> compras = new List<Compra>();
            string query = $"SELECT * from V_Compras WHERE YEAR(fecha) = '{ano}'";
            SqlDataReader lector = Conexion.getInstance().ejecutarqueryleer(query);
            while (lector.Read())
            {
                Compra compra = new Compra();
                compra.Idcompra = lector.GetInt64(0);
                compra.Nombre_compra = lector.GetString(1);
                compra.Idtipocompra = lector.GetInt64(2);
                compra.Idproovedor = lector.GetInt64(3);
                compra.Total = lector.GetDecimal(4);
                compra.Fecha = (lector.GetDateTime(5)).ToString();



                compras.Add(compra);

            }
            lector.Close();
            return compras;

        }



        public List<Compra> Fincompradesdehasta(string desde, string hasta)
        {
            List<Compra> compras = new List<Compra>();
            string query = $"SELECT * from V_Compras WHERE fecha BETWEEN  '{desde}' AND '{hasta}'";
            SqlDataReader lector = Conexion.getInstance().ejecutarqueryleer(query);
            while (lector.Read())
            {
                Compra compra = new Compra();
                compra.Idcompra = lector.GetInt64(0);
                compra.Nombre_compra = lector.GetString(1);
                compra.Idtipocompra = lector.GetInt64(2);
                compra.Idproovedor = lector.GetInt64(3);
                compra.Total = lector.GetDecimal(4);
                compra.Fecha = (lector.GetDateTime(5)).ToString();



                compras.Add(compra);

            }
            lector.Close();
            return compras;

        }

        /*buscar el total de compras*/
        public Compra Findsumtotalcomprasdia(string fecha)
        {
            Compra Compra = new Compra();
            string query = $"SELECT ISNULL(SUM(total), 0) from compras WHERE fecha = '{ fecha}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


            while (reader.Read())
            {

                Compra.Total = reader.GetDecimal(0);


            }



            reader.Close();
            return Compra;


        }


        public Compra Findsumtotalcomprasmes(string fecha)
        {
            Compra Compra = new Compra();
            string query = $"SELECT ISNULL(SUM(total), 0) FROM compras WHERE MONTH(fecha) = '{fecha}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


            while (reader.Read())
            {

                Compra.Total = reader.GetDecimal(0);


            }



            reader.Close();
            return Compra;


        }




        public Compra Findsumtotalcomprasano(string fecha)
        {
            Compra Compra = new Compra();
            string query = $"SELECT ISNULL(SUM(total), 0) from compras WHERE YEAR(fecha) = '{ fecha}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


            while (reader.Read())
            {

                Compra.Total = reader.GetDecimal(0);


            }



            reader.Close();
            return Compra;


        }





        public Compra Findsumtotalcompradesdehasta(string desde, string hasta)
        {
            Compra Compra = new Compra();
            string query = $"SELECT ISNULL(SUM(total), 0) from compras WHERE fecha BETWEEN  '{desde}' AND '{hasta}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


            while (reader.Read())
            {

                Compra.Total = reader.GetDecimal(0);


            }



            reader.Close();
            return Compra;


        }
    }
}
