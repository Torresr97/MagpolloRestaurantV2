using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTRchicken.Modelo;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppTRchicken.Controlador
{
	class ControladorFacturas : DAOimpl<facturas>
	{
		private static ControladorFacturas instance = new ControladorFacturas();

		private ControladorFacturas()
		{

		}

		internal static ControladorFacturas Instance
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

		public bool delete(facturas model)
		{

			SqlCommand cmd = new SqlCommand("SP_EliminarFactura", Conexion.getInstance().getconexion());
			cmd.CommandType = System.Data.CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@idfactura", model.Idfactura);
			return Conexion.getInstance().ejecutarSP(cmd);



		}

		public facturas find(int id)
		{

			facturas factura = new facturas();

			string query = $"SELECT * FROM V_Facturas WHERE idfactura = '{id}'";
			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
			while (reader.Read())
			{
				factura.Idfactura = reader.IsDBNull(0) ? 0 : (int)reader.GetInt64(0);
				factura.Orden = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
				factura.Fecha = reader.IsDBNull(2) ? string.Empty : reader.GetDateTime(2).ToString();
				factura.Descuento = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
				factura.Importe_exonerado = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
				factura.Importe_exento = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
				factura.Importe_gravado = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
				factura.Isv15 = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
				factura.Isv18 = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8);
				factura.Tipopago = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
				factura.Dinerorecibido = reader.IsDBNull(10) ? 0 : reader.GetDecimal(10);
				factura.Dineroentregado = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11);
				factura.Total = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12);
				factura.Fecha2 = reader.IsDBNull(13) ? DateTime.MinValue : reader.GetDateTime(13);
				factura.Facturacai = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
				factura.Idcliente = reader.IsDBNull(17) ? 0 : (int)reader.GetInt64(17);

			}

			reader.Close();
			return factura;
		}




		public List<facturas> FindAll()
		{
			List<facturas> facturas = new List<facturas>();
			string query = "SELECT * from V_Facturas";
			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
			while (reader.Read())
			{
				facturas factura = new facturas();
				factura.Idfactura = reader.IsDBNull(0) ? 0 : (int)reader.GetInt64(0);
				factura.Orden = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
				factura.Fecha = reader.IsDBNull(2) ? string.Empty : reader.GetDateTime(2).ToString();
				factura.Descuento = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
				factura.Importe_exonerado = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
				factura.Importe_exento = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
				factura.Importe_gravado = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
				factura.Isv15 = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
				factura.Isv18 = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8);
				factura.Tipopago = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
				factura.Dinerorecibido = reader.IsDBNull(10) ? 0 : reader.GetDecimal(10);
				factura.Dineroentregado = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11);
				factura.Total = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12);
				factura.Fecha2 = reader.IsDBNull(13) ? DateTime.MinValue : reader.GetDateTime(13);
				factura.Facturacai = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
				factura.Idcliente = reader.IsDBNull(17) ? 0 : (int)reader.GetInt64(17);



				facturas.Add(factura);

			}
			reader.Close();
			return facturas;
		}



		public List<facturas> FincfacturaFecha(string fecha, int numerocierre)
		{
			List<facturas> facturas = new List<facturas>();
			string query = $"SELECT * from V_Facturas WHERE fecha = '{fecha}' AND estado = 1 AND numerocierre = '{numerocierre}'";
			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
			while (reader.Read())
			{
				facturas factura = new facturas();
				factura.Idfactura = reader.IsDBNull(0) ? 0 : (int)reader.GetInt64(0);
				factura.Orden = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
				factura.Fecha = reader.IsDBNull(2) ? string.Empty : reader.GetDateTime(2).ToString();
				factura.Descuento = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
				factura.Importe_exonerado = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
				factura.Importe_exento = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
				factura.Importe_gravado = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
				factura.Isv15 = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
				factura.Isv18 = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8);
				factura.Tipopago = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
				factura.Dinerorecibido = reader.IsDBNull(10) ? 0 : reader.GetDecimal(10);
				factura.Dineroentregado = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11);
				factura.Total = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12);
				factura.Fecha2 = reader.IsDBNull(13) ? DateTime.MinValue : reader.GetDateTime(13);
				factura.Facturacai = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
				factura.Idcliente = reader.IsDBNull(17) ? 0 : (int)reader.GetInt64(17);



				facturas.Add(factura);

			}
			reader.Close();
			return facturas;
		}
		/****************Aqui inicia las consultas para los Reportes de facturas*****************************/

		public List<facturas> ReporteFincfacturaDia(string fecha, string estado)
		{
			string query = "";
			if (estado == "Activas")
			{
				estado = "1";
				query = $"SELECT * from V_Facturas WHERE fecha = '{fecha}' AND estado = '{estado}' ";
			}
			else if (estado == "Inactivas")
			{
				estado = "0";
				query = $"SELECT * from V_Facturas WHERE fecha = '{fecha}' AND estado = '{estado}' ";
			}
			else if (estado == "Todas")
			{
				query = $"SELECT * from V_Facturas WHERE fecha = '{fecha}'";
			}
			List<facturas> facturas = new List<facturas>();

			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
			while (reader.Read())
			{
				facturas factura = new facturas();
				factura.Idfactura = reader.IsDBNull(0) ? 0 : (int)reader.GetInt64(0);
				factura.Orden = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
				factura.Fecha = reader.IsDBNull(2) ? string.Empty : reader.GetDateTime(2).ToString();
				factura.Descuento = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
				factura.Importe_exonerado = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
				factura.Importe_exento = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
				factura.Importe_gravado = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
				factura.Isv15 = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
				factura.Isv18 = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8);
				factura.Tipopago = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
				factura.Dinerorecibido = reader.IsDBNull(10) ? 0 : reader.GetDecimal(10);
				factura.Dineroentregado = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11);
				factura.Total = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12);
				factura.Fecha2 = reader.IsDBNull(13) ? DateTime.MinValue : reader.GetDateTime(13);
				factura.Facturacai = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
				factura.Estado = reader.IsDBNull(14) ? false : reader.GetBoolean(16);
				factura.Idcliente = reader.IsDBNull(17) ? 0 : (int)reader.GetInt64(17);


				facturas.Add(factura);

			}
			reader.Close();
			return facturas;
		}
		public List<facturas> ReporteFinfacturames(string mes, string estado, string ano)
		{
			string query = "";
			if (estado == "Activas")
			{
				estado = "1";
				query = $"SELECT * from V_Facturas WHERE MONTH(fecha) = '{ mes}'AND YEAR(fecha)={ano} AND estado = '{estado}'";
			}
			else if (estado == "Inactivas")
			{
				estado = "0";
				query = $"SELECT * from V_Facturas WHERE MONTH(fecha) = '{ mes}'AND YEAR(fecha)={ano} AND estado = '{estado}'";
			}
			else if (estado == "Todas")
			{
				query = $"SELECT * from V_Facturas WHERE MONTH(fecha) = '{ mes}'AND YEAR(fecha)={ano}";
			}
			List<facturas> facturas = new List<facturas>();

			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
			while (reader.Read())
			{
				facturas factura = new facturas();
				factura.Idfactura = reader.IsDBNull(0) ? 0 : (int)reader.GetInt64(0);
				factura.Orden = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
				factura.Fecha = reader.IsDBNull(2) ? string.Empty : reader.GetDateTime(2).ToString();
				factura.Descuento = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
				factura.Importe_exonerado = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
				factura.Importe_exento = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
				factura.Importe_gravado = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
				factura.Isv15 = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
				factura.Isv18 = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8);
				factura.Tipopago = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
				factura.Dinerorecibido = reader.IsDBNull(10) ? 0 : reader.GetDecimal(10);
				factura.Dineroentregado = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11);
				factura.Total = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12);
				factura.Fecha2 = reader.IsDBNull(13) ? DateTime.MinValue : reader.GetDateTime(13);
				factura.Facturacai = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
				factura.Estado = reader.IsDBNull(14) ? false : reader.GetBoolean(16);
				factura.Idcliente = reader.IsDBNull(17) ? 0 : (int)reader.GetInt64(17);

				facturas.Add(factura);

			}
			reader.Close();
			return facturas;
		}


		public List<facturas> ReporteFinfacturaano(string ano, string estado)
		{
			string query = "";
			if (estado == "Activas")
			{
				estado = "1";
				query = $"SELECT * from V_Facturas WHERE YEAR(fecha)='{ ano}' AND estado = '{estado}' ";
			}
			else if (estado == "Inactivas")
			{
				estado = "0";
				query = $"SELECT * from V_Facturas WHERE YEAR(fecha)='{ ano}' AND estado = '{estado}' ";
			}
			else if (estado == "Todas")
			{
				query = $"SELECT * from V_Facturas WHERE YEAR(fecha)='{ ano}'";
			}
			List<facturas> facturas = new List<facturas>();

			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
			while (reader.Read())
			{
				facturas factura = new facturas();
				factura.Idfactura = reader.IsDBNull(0) ? 0 : (int)reader.GetInt64(0);
				factura.Orden = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
				factura.Fecha = reader.IsDBNull(2) ? string.Empty : reader.GetDateTime(2).ToString();
				factura.Descuento = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
				factura.Importe_exonerado = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
				factura.Importe_exento = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
				factura.Importe_gravado = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
				factura.Isv15 = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
				factura.Isv18 = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8);
				factura.Tipopago = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
				factura.Dinerorecibido = reader.IsDBNull(10) ? 0 : reader.GetDecimal(10);
				factura.Dineroentregado = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11);
				factura.Total = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12);
				factura.Fecha2 = reader.IsDBNull(13) ? DateTime.MinValue : reader.GetDateTime(13);
				factura.Facturacai = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
				factura.Estado = reader.IsDBNull(14) ? false : reader.GetBoolean(16);
				factura.Idcliente = reader.IsDBNull(17) ? 0 : (int)reader.GetInt64(17);


				facturas.Add(factura);

			}
			reader.Close();
			return facturas;
		}



		public List<facturas> ReporteFinfacturadesdehasta(string desde, string hasta, string estado)

		{
			string query = "";
			if (estado == "Activas")
			{
				estado = "1";
				query = $"SELECT * from V_Facturas WHERE fecha BETWEEN  '{desde}' AND '{hasta}' AND estado = '{estado}' ";
			}
			else if (estado == "Inactivas")
			{
				estado = "0";
				query = $"SELECT * from V_Facturas WHERE fecha BETWEEN  '{desde}' AND '{hasta}' AND estado = '{estado}' ";
			}
			else if (estado == "Todas")
			{
				query = $"SELECT * from V_Facturas WHERE fecha BETWEEN  '{desde}' AND '{hasta}'";
			}
			List<facturas> facturas = new List<facturas>();

			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
			while (reader.Read())
			{
				facturas factura = new facturas();

				factura.Idfactura = reader.IsDBNull(0) ? 0 : (int)reader.GetInt64(0);
				factura.Orden = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
				factura.Fecha = reader.IsDBNull(2) ? string.Empty : reader.GetDateTime(2).ToString();
				factura.Descuento = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
				factura.Importe_exonerado = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
				factura.Importe_exento = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
				factura.Importe_gravado = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
				factura.Isv15 = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
				factura.Isv18 = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8);
				factura.Tipopago = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
				factura.Dinerorecibido = reader.IsDBNull(10) ? 0 : reader.GetDecimal(10);
				factura.Dineroentregado = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11);
				factura.Total = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12);
				factura.Fecha2 = reader.IsDBNull(13) ? DateTime.MinValue : reader.GetDateTime(13);
				factura.Facturacai = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
				factura.Estado = reader.IsDBNull(14) ? false : reader.GetBoolean(16);
				factura.Idcliente = reader.IsDBNull(17) ? 0 : (int)reader.GetInt64(17);

				facturas.Add(factura);



			}
			reader.Close();
			return facturas;
		}
		/***************************************aqui finaliza las consultas de reportes*****************************************/






		public List<facturas> findAll()
		{
			List<facturas> facturas = new List<facturas>();
			string query = "SELECT * from facturas";

			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
			while (reader.Read())
			{
				facturas factura = new facturas();

				factura.Idfactura = reader.IsDBNull(0) ? 0 : (int)reader.GetInt64(0);
				factura.Orden = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
				factura.Fecha = reader.IsDBNull(2) ? string.Empty : reader.GetDateTime(2).ToString();
				factura.Descuento = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
				factura.Importe_exonerado = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
				factura.Importe_exento = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
				factura.Importe_gravado = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
				factura.Isv15 = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
				factura.Isv18 = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8);
				factura.Tipopago = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
				factura.Dinerorecibido = reader.IsDBNull(10) ? 0 : reader.GetDecimal(10);
				factura.Dineroentregado = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11);
				factura.Total = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12);
				factura.Fecha2 = reader.IsDBNull(13) ? DateTime.MinValue : reader.GetDateTime(13);
				factura.Facturacai = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
				factura.Idcliente = reader.IsDBNull(17) ? 0 : (int)reader.GetInt64(17);


				facturas.Add(factura);

			}
			reader.Close();
			return facturas;
		}



		public facturas Findorden(string fecha)
		{
			facturas facturas = new facturas();
			string query = $"SELECT ISNULL(MAX(Orden), 0) FROM facturas WHERE fecha = '{ fecha}'";
			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


			while (reader.Read())
			{

				facturas.Orden = reader.GetInt32(0);


			}



			reader.Close();
			return facturas;


		}


		public facturas Findfacturacai(string fecha, string iniciofacsturacai)
		{
			facturas facturas = new facturas();
			string query = $"SELECT CASE WHEN EXISTS (SELECT 1 FROM facturas WHERE fecha = '{fecha}') THEN ISNULL((SELECT MAX(TRY_CONVERT(INT, facturacai)) FROM facturas WHERE fecha = '{fecha}'), 100) ELSE ISNULL((SELECT MAX(TRY_CONVERT(INT, facturacai)) FROM facturas WHERE fecha = DATEADD(DAY, -1, '{fecha}')), 100)END AS facturacai";


			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


			while (reader.Read())
			{
				int valorEntero = reader.GetInt32(0);
				facturas.Facturacai = valorEntero.ToString();



			}



			reader.Close();
			return facturas;


		}

		/*esta funcion es para verificar cual es el numero de grupo de facturas para hacer el cierre se obtiene de la tabla facturas 
		 y luego se ingresa en los datos de la tabla caja para proceder hacer el cierre*/
		public facturas Findnumerocierre(string fecha)
		{
			facturas facturas = new facturas();
			string query = $"SELECT ISNULL(MAX(numerocierre), 1) FROM facturas WHERE fecha = '{ fecha}'";
			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


			while (reader.Read())
			{

				facturas.Numerocierre = reader.GetInt32(0);


			}



			reader.Close();
			return facturas;


		}





		public facturas findultimafacturaregistrada(string fecha)
		{
			facturas facturas = new facturas();
			string query = $"SELECT TOP (1) idfactura FROM facturas WHERE fecha = '{fecha}' ORDER BY idfactura DESC";
			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


			while (reader.Read())
			{

				facturas.Idfactura = (int)reader.GetInt64(0);


			}



			reader.Close();
			return facturas;


		}


		public facturas totalefectivofacturado(string fecha, string tipo, int numerocierre)
		{
			facturas facturas = new facturas();
			string query = $"SELECT ISNULL(SUM(total), 0) as total from V_Facturas WHERE fecha = '{fecha}'  AND tipopago = '{tipo}' AND estado = 1 AND numerocierre = '{numerocierre}'";
			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


			while (reader.Read())
			{

				facturas.Total = reader.GetDecimal(0);

			}
			reader.Close();
			return facturas;


		}


		public bool save(facturas model)
		{
			SqlCommand cmd = new SqlCommand("SP_NuevaFactura", Conexion.getInstance().getconexion());
			cmd.CommandType = System.Data.CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@orden", model.Orden);
			cmd.Parameters.AddWithValue("@fecha", model.Fecha);
			cmd.Parameters.AddWithValue("@descuento", model.Descuento);
			cmd.Parameters.AddWithValue("@exonerado", model.Importe_exonerado);
			cmd.Parameters.AddWithValue("@exento", model.Importe_exento);
			cmd.Parameters.AddWithValue("@gravado", model.Importe_gravado);
			cmd.Parameters.AddWithValue("@isv15", model.Isv15);
			cmd.Parameters.AddWithValue("@isv18", model.Isv18);
			cmd.Parameters.AddWithValue("@tipopago", model.Tipopago);
			cmd.Parameters.AddWithValue("@ultimosdigitos", model.Ultimosdigitos);
			cmd.Parameters.AddWithValue("@dinerorecibido", model.Dinerorecibido);
			cmd.Parameters.AddWithValue("@dineroentregado", model.Dineroentregado);
			cmd.Parameters.AddWithValue("@total", model.Total);
			cmd.Parameters.AddWithValue("@estado", model.Estado);
			cmd.Parameters.AddWithValue("@idsucursal", model.Idsucursal);
			cmd.Parameters.AddWithValue("@idusuario", model.Idusuario);
			cmd.Parameters.AddWithValue("@idcliente", model.Idcliente);
			cmd.Parameters.AddWithValue("@numerocierre", model.Numerocierre);
			cmd.Parameters.AddWithValue("@fecha2", model.Fecha2);
			cmd.Parameters.AddWithValue("@facturacai", model.Facturacai);

			return Conexion.getInstance().ejecutarSP(cmd);

		}

		public int saveRidfactura(facturas model)
		{
			int idfactura = 0;
			SqlCommand cmd = new SqlCommand("SP_NuevaFactura", Conexion.getInstance().getconexion());
			cmd.CommandType = System.Data.CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@orden", model.Orden);
			cmd.Parameters.AddWithValue("@fecha", model.Fecha);
			cmd.Parameters.AddWithValue("@descuento", model.Descuento);
			cmd.Parameters.AddWithValue("@exonerado", model.Importe_exonerado);
			cmd.Parameters.AddWithValue("@exento", model.Importe_exento);
			cmd.Parameters.AddWithValue("@gravado", model.Importe_gravado);
			cmd.Parameters.AddWithValue("@isv15", model.Isv15);
			cmd.Parameters.AddWithValue("@isv18", model.Isv18);
			cmd.Parameters.AddWithValue("@tipopago", model.Tipopago);
			cmd.Parameters.AddWithValue("@ultimosdigitos", model.Ultimosdigitos);
			cmd.Parameters.AddWithValue("@dinerorecibido", model.Dinerorecibido);
			cmd.Parameters.AddWithValue("@dineroentregado", model.Dineroentregado);
			cmd.Parameters.AddWithValue("@total", model.Total);
			cmd.Parameters.AddWithValue("@estado", model.Estado);
			cmd.Parameters.AddWithValue("@idsucursal", model.Idsucursal);
			cmd.Parameters.AddWithValue("@idusuario", model.Idusuario);
			cmd.Parameters.AddWithValue("@idcliente", model.Idcliente);
			cmd.Parameters.AddWithValue("@numerocierre", model.Numerocierre);
			cmd.Parameters.AddWithValue("@fecha2", model.Fecha2);
			cmd.Parameters.AddWithValue("@facturacai", model.Facturacai);

			try
			{
				// Ejecutar el comando y obtener el nuevo IdPlanilla
				idfactura = Convert.ToInt32(cmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al guardar la planilla: " + ex.Message);
			}

			return idfactura;

		}


		public bool save(List<facturas> models)
		{
			throw new NotImplementedException();
		}

		public bool update(facturas model)
		{

			SqlCommand cmd = new SqlCommand("SP_ActualizarFactura", Conexion.getInstance().getconexion());
			cmd.CommandType = System.Data.CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@idfactura", model.Idfactura);
			cmd.Parameters.AddWithValue("@estado", model.Estado);
			return Conexion.getInstance().ejecutarSP(cmd);
		}















		/*funciones para reportes por producto*/
		public List<facturas> finreportexproductodia(string nombrecombo, string fecha)
		{
			List<facturas> facturas = new List<facturas>();
			string query = $"SELECT * from V_Reportexproducto WHERE fecha = '{fecha}' AND nombrecombo = '{nombrecombo}'";
			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
			while (reader.Read())
			{
				facturas factura = new facturas();
				menu menu = new menu();
				detalle_factura detalle_factura = new detalle_factura();
				menu.Nombrecombo = reader.GetString(0);
				detalle_factura.Cantidad = (int)reader.GetInt64(1);
				detalle_factura.Total = reader.GetDecimal(2);
				factura.Fecha = (reader.GetDateTime(3)).ToString();




				facturas.Add(factura);


			}
			reader.Close();
			return facturas;
		}











		public List<facturas> finreportexproductomes(string nombrecombo, string fecha)
		{
			List<facturas> facturas = new List<facturas>();
			string query = $"SELECT * from V_Reportexproducto WHERE MONTH(fecha) = '{ fecha}' AND nombrecombo = '{nombrecombo}'";
			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
			while (reader.Read())
			{
				facturas factura = new facturas();
				menu menu = new menu();
				detalle_factura detalle_factura = new detalle_factura();
				menu.Nombrecombo = reader.GetString(0);
				detalle_factura.Cantidad = (int)reader.GetInt64(1);
				detalle_factura.Total = reader.GetDecimal(2);
				factura.Fecha = (reader.GetDateTime(3)).ToString();




				facturas.Add(factura);


			}
			reader.Close();
			return facturas;
		}



		public List<facturas> finreportexproductoano(string nombrecombo, string fecha)
		{
			List<facturas> facturas = new List<facturas>();
			string query = $"SELECT * from V_Reportexproducto WHERE YEAR(fecha) = '{ fecha}' AND nombrecombo = '{nombrecombo}'";
			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
			while (reader.Read())
			{
				facturas factura = new facturas();
				menu menu = new menu();
				detalle_factura detalle_factura = new detalle_factura();
				menu.Nombrecombo = reader.GetString(0);
				detalle_factura.Cantidad = (int)reader.GetInt64(1);
				detalle_factura.Total = reader.GetDecimal(2);
				factura.Fecha = (reader.GetDateTime(3)).ToString();




				facturas.Add(factura);


			}
			reader.Close();
			return facturas;
		}









		public List<facturas> finreportexproductodesdehasta(string nombrecombo, string desde, string hasta)
		{
			List<facturas> facturas = new List<facturas>();
			string query = $"SELECT * from V_Reportexproducto WHERE fecha BETWEEN  '{desde}' AND '{hasta}' AND nombrecombo = '{nombrecombo}'";
			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
			while (reader.Read())
			{
				facturas factura = new facturas();
				menu menu = new menu();
				detalle_factura detalle_factura = new detalle_factura();
				menu.Nombrecombo = reader.GetString(0);
				detalle_factura.Cantidad = (int)reader.GetInt64(1);
				detalle_factura.Total = reader.GetDecimal(2);
				factura.Fecha = (reader.GetDateTime(3)).ToString();




				facturas.Add(factura);


			}
			reader.Close();
			return facturas;
		}




		/********encontrar total de ventas********/
		public facturas Findsumtotalventasdia(string fecha)
		{
			facturas facturas = new facturas();
			string query = $"SELECT ISNULL(SUM(total), 0) from facturas WHERE fecha = '{ fecha}'";
			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


			while (reader.Read())
			{

				facturas.Total = reader.GetDecimal(0);


			}



			reader.Close();
			return facturas;


		}


		public facturas Findsumtotalventasmes(string fecha)
		{
			facturas facturas = new facturas();
			string query = $"SELECT ISNULL(SUM(total), 0) from facturas WHERE MONTH(fecha) = '{ fecha}'";
			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


			while (reader.Read())
			{

				facturas.Total = reader.GetDecimal(0);


			}



			reader.Close();
			return facturas;


		}




		public facturas Findsumtotalventasano(string fecha)
		{
			facturas facturas = new facturas();
			string query = $"SELECT ISNULL(SUM(total), 0) from facturas WHERE YEAR(fecha) = '{ fecha}'";
			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


			while (reader.Read())
			{

				facturas.Total = reader.GetDecimal(0);


			}



			reader.Close();
			return facturas;


		}





		public facturas Findsumtotalventasdesdehasta(string desde, string hasta)
		{
			facturas facturas = new facturas();
			string query = $"SELECT ISNULL(SUM(total), 0) from facturas WHERE fecha BETWEEN  '{desde}' AND '{hasta}'";
			SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);


			while (reader.Read())
			{

				facturas.Total = reader.GetDecimal(0);


			}



			reader.Close();
			return facturas;


		}


		/*COCINA*/
		public List<facturas> FincfacturaFechacocina(string fecha)
		{
			List<facturas> facturas = new List<facturas>();
			string query = $"SELECT * from V_Facturas WHERE fecha = '{fecha}' AND estado = 1";

			// Usar un bloque using para garantizar el cierre del SqlDataReader
			using (SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query))
			{
				while (reader.Read())
				{
					facturas factura = new facturas();
					factura.Idfactura = reader.IsDBNull(0) ? 0 : (int)reader.GetInt64(0);
					factura.Orden = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
					factura.Fecha = reader.IsDBNull(2) ? string.Empty : reader.GetDateTime(2).ToString();
					factura.Descuento = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
					factura.Importe_exonerado = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
					factura.Importe_exento = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
					factura.Importe_gravado = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
					factura.Isv15 = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
					factura.Isv18 = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8);
					factura.Tipopago = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
					factura.Dinerorecibido = reader.IsDBNull(10) ? 0 : reader.GetDecimal(10);
					factura.Dineroentregado = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11);
					factura.Total = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12);
					factura.Fecha2 = reader.IsDBNull(13) ? DateTime.MinValue : reader.GetDateTime(13);
					factura.Facturacai = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
					factura.Idcliente = reader.IsDBNull(17) ? 0 : (int)reader.GetInt64(17);

					facturas.Add(factura);
				}
			} // El reader se cerrará automáticamente al salir de este bloque
			return facturas;
		}


		public List<facturas> ObtenernuevasFacturas(int ultimaFacturaID, string fechaActual)
		{
			List<facturas> nuevasFacturas = new List<facturas>();

			// Consultar las nuevas facturas desde la última factura procesada
			string query = $"SELECT * FROM V_Facturas WHERE Idfactura > {ultimaFacturaID} AND fecha = '{fechaActual}' AND estado = 1";

			// Usar un bloque using para garantizar el cierre del SqlDataReader
			using (SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query))
			{
				while (reader.Read())
				{
					facturas factura = new facturas();
					factura.Idfactura = reader.IsDBNull(0) ? 0 : (int)reader.GetInt64(0);
					factura.Orden = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
					factura.Fecha = reader.IsDBNull(2) ? string.Empty : reader.GetDateTime(2).ToString();
					factura.Descuento = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
					factura.Importe_exonerado = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
					factura.Importe_exento = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
					factura.Importe_gravado = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
					factura.Isv15 = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
					factura.Isv18 = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8);
					factura.Tipopago = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
					factura.Dinerorecibido = reader.IsDBNull(10) ? 0 : reader.GetDecimal(10);
					factura.Dineroentregado = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11);
					factura.Total = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12);
					factura.Fecha2 = reader.IsDBNull(13) ? DateTime.MinValue : reader.GetDateTime(13);
					factura.Facturacai = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
					factura.Idcliente = reader.IsDBNull(17) ? 0 : (int)reader.GetInt64(17);

					nuevasFacturas.Add(factura);
				}
			} // El reader se cerrará automáticamente al salir de este bloque

			return nuevasFacturas;
		}


		public facturas ObtenerUltimaFacturaPorFecha(string fecha)
		{
			facturas factura = new facturas();

			// Consultar la última factura de la fecha especificada
			string query = $"SELECT TOP 1 * FROM V_Facturas WHERE fecha = '{fecha}' ORDER BY idfactura DESC";

			// Usar un bloque using para garantizar el cierre del SqlDataReader
			using (SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query))
			{
				while (reader.Read())
				{
					factura.Idfactura = reader.IsDBNull(0) ? 0 : (int)reader.GetInt64(0);
					factura.Orden = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
					factura.Fecha = reader.IsDBNull(2) ? string.Empty : reader.GetDateTime(2).ToString();
					factura.Descuento = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
					factura.Importe_exonerado = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
					factura.Importe_exento = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
					factura.Importe_gravado = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
					factura.Isv15 = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
					factura.Isv18 = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8);
					factura.Tipopago = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
					factura.Dinerorecibido = reader.IsDBNull(10) ? 0 : reader.GetDecimal(10);
					factura.Dineroentregado = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11);
					factura.Total = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12);
					factura.Fecha2 = reader.IsDBNull(13) ? DateTime.MinValue : reader.GetDateTime(13);
					factura.Facturacai = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
					factura.Idcliente = reader.IsDBNull(17) ? 0 : (int)reader.GetInt64(17);
				}
			} // El reader se cerrará automáticamente al salir de este bloque

			return factura;
		}


	}
}
