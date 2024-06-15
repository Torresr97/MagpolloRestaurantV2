using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTRchicken.Modelo;
using System.Data.SqlClient;
using AppTRchicken.Utilidades;
namespace AppTRchicken.Controlador
{
    class ControladorDetalle_Factura : DAOimpl<detalle_factura>
    {
        private static ControladorDetalle_Factura instance = new ControladorDetalle_Factura();


        private ControladorDetalle_Factura()
        {

        }

        internal static ControladorDetalle_Factura Instance
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
        public bool delete(detalle_factura model)
        {
            throw new NotImplementedException();
        }

        public detalle_factura find(int id)
        {
            detalle_factura detalle_factura = new detalle_factura();
            string query = "SELECT * FROM detalle_factura WHERE idfactura = " + id;
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                detalle_factura.IdDetallefactura = (int)reader.GetInt64(0);
                detalle_factura.Idfactura =(int)reader.GetInt64(1);
                detalle_factura.Idmenu = (int)reader.GetInt64(2);
                detalle_factura.Complementos = reader.GetString(4);
                detalle_factura.Cantidad = ((int)reader.GetInt64(5));
                detalle_factura.Total = reader.GetDecimal(6);

            }
            reader.Close();
            return detalle_factura;
        }

        public List<detalle_factura> findbyid(int id)
        {
            List<detalle_factura> detalle_factura = new List<detalle_factura>();
            string query = "SELECT * FROM detalle_factura WHERE idfactura = " + id;
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                detalle_factura detallefactura = new detalle_factura();
                detallefactura.Idmenu = (int)reader.GetInt64(2);
                detallefactura.Complementos = reader.GetString(3);

                detallefactura.Cantidad = (int)reader.GetInt64(4);
                detallefactura.Total = reader.GetDecimal(5);

                detalle_factura.Add(detallefactura);

            }
            reader.Close();
            return detalle_factura;

        }
        public List<detalle_factura> findAll()
        {
            throw new NotImplementedException();
        }

        public bool save(detalle_factura model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevoDetalleFactura", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idfactura", model.Idfactura);
            cmd.Parameters.AddWithValue("@idmenu", model.Idmenu);
            cmd.Parameters.AddWithValue("@complementos", model.Complementos);
            cmd.Parameters.AddWithValue("@cantidad", model.Cantidad);
            cmd.Parameters.AddWithValue("@total", model.Total);

            return Conexion.getInstance().ejecutarSP(cmd);
           
        }

        public bool save(List<detalle_factura> models)
        {
            throw new NotImplementedException();
        }

        public bool update(detalle_factura model)
        {
            throw new NotImplementedException();
        }



        public List<detalle_factura> finreportexproductodia(string nombrecombo, string fecha)
        {
            List<detalle_factura> detalle_facturas = new List<detalle_factura>();
            string query = $"SELECT * from V_Reportexproducto WHERE fecha = '{fecha}' AND nombrecombo = '{nombrecombo}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                detalle_factura detalle_factura = new detalle_factura();


                detalle_factura.Cantidad = (int)reader.GetInt64(1);
                detalle_factura.Total = reader.GetDecimal(2);





                detalle_facturas.Add(detalle_factura);


            }
            reader.Close();
            return detalle_facturas;
        }












        public List<detalle_factura> finreportexproductomes(string nombrecombo, string fecha)
        {
            List<detalle_factura> detalle_facturas = new List<detalle_factura>();
            string query = $"SELECT * from V_Reportexproducto WHERE MONTH(fecha) = '{ fecha}' AND nombrecombo = '{nombrecombo}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);

            while (reader.Read())
            {
                detalle_factura detalle_factura = new detalle_factura();


                detalle_factura.Cantidad = (int)reader.GetInt64(1);
                detalle_factura.Total = reader.GetDecimal(2);





                detalle_facturas.Add(detalle_factura);


            }
            reader.Close();
            return detalle_facturas;
        }




        public List<detalle_factura> finreportexproductoano(string nombrecombo, string fecha)
        {
            List<detalle_factura> detalle_facturas = new List<detalle_factura>();
            string query = $"SELECT * from V_Reportexproducto WHERE YEAR(fecha) = '{ fecha}' AND nombrecombo = '{nombrecombo}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);

            while (reader.Read())
            {
                detalle_factura detalle_factura = new detalle_factura();


                detalle_factura.Cantidad = (int)reader.GetInt64(1);
                detalle_factura.Total = reader.GetDecimal(2);





                detalle_facturas.Add(detalle_factura);


            }
            reader.Close();
            return detalle_facturas;
        }





        public List<detalle_factura> finreportexproductodesdehasta(string nombrecombo, string desde, string hasta)
        {
            List<detalle_factura> detalle_facturas = new List<detalle_factura>();
            string query = $"SELECT * from V_Reportexproducto WHERE fecha BETWEEN  '{desde}' AND '{hasta}' AND nombrecombo = '{nombrecombo}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);

            while (reader.Read())
            {
                detalle_factura detalle_factura = new detalle_factura();


                detalle_factura.Cantidad = (int)reader.GetInt64(1);
                detalle_factura.Total = reader.GetDecimal(2);





                detalle_facturas.Add(detalle_factura);


            }
            reader.Close();
            return detalle_facturas;
        }









    }
}
