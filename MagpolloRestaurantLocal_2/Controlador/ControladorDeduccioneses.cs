using AppTRchicken.Modelo;
using AppTRchicken.Utilidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTRchicken.Controlador
{
    class ControladorDeduccioneses : DAOimpl<Deduccion>
    {
        private static ControladorDeduccioneses instance = new ControladorDeduccioneses();
        private ControladorDeduccioneses() { }

        public static ControladorDeduccioneses Instance
        {
            get { return instance; }
            set { instance = value; }
        }

        public bool delete(Deduccion model)
        {
            throw new NotImplementedException();
        }

        public Deduccion find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Deduccion> findAll()
        {
            throw new NotImplementedException();
        }
        public List<Deduccion> finddeduccionesxfechas(DateTime desde, DateTime hasta, int idempleado,string basedatos)
        {
            List<Deduccion> deducciones = new List<Deduccion>();
            string query = "SELECT * FROM Deducciones WHERE CONVERT(DATE, FechaDeduccion) BETWEEN @desde AND @hasta AND IdEmpleado = @idempleado AND idplanilla = 0";

            // Obtener conexión a la otra base de datos
            using (SqlConnection conexion = Conexion.ObtenerConexionEnOtraBD(basedatos))
            {
                if (conexion == null)
                {
                    //MessageBox.Show("No se pudo conectar a la base de datos especificada.");
                    return deducciones; // Retornar una lista vacía si no se pudo conectar
                }

                // Crear el comando usando la conexión obtenida
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    // Añadir los parámetros de la consulta
                    command.Parameters.AddWithValue("@desde", desde.Date);
                    command.Parameters.AddWithValue("@hasta", hasta.Date);
                    command.Parameters.AddWithValue("@idempleado", idempleado);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Deduccion deduccion = new Deduccion
                            {
                                IdDeduccion = reader.GetInt32(0),
                                IdEmpleado = reader.GetInt32(1),
                                FechaDeduccion = reader.GetDateTime(2),
                                Sucursal = reader.GetString(3),
                                IdUsuario = reader.GetInt32(4),
                                ProductoDescripcion = reader.GetString(5),
                                Cantidad = reader.GetInt32(6),
                                Total = reader.GetDecimal(7),
                                IdTipoDeduccion = reader.GetInt32(8),
                                Observaciones = reader.GetString(9),
                                IdPlanilla = reader.GetInt32(10),
                                IdPrestamo = reader.GetInt32(11)
                            };
                            deducciones.Add(deduccion);
                        }
                    }
                }
            }

            return deducciones;
        }
        public bool save(Deduccion model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevaDeduccion", Conexion.ObtenerConexionEnOtraBD(Globales.basedatoscentral));
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", model.IdEmpleado);
            cmd.Parameters.AddWithValue("@FechaDeduccion", model.FechaDeduccion);
            cmd.Parameters.AddWithValue("@Sucursal", model.Sucursal);
            cmd.Parameters.AddWithValue("@IdUsuario", model.IdUsuario);
            cmd.Parameters.AddWithValue("@ProductoDescripcion", model.ProductoDescripcion);
            cmd.Parameters.AddWithValue("@Cantidad", model.Cantidad);
            cmd.Parameters.AddWithValue("@Total", model.Total);
            cmd.Parameters.AddWithValue("@IdTipoDeduccion", model.IdTipoDeduccion);
            cmd.Parameters.AddWithValue("@Observaciones", model.Observaciones);
            cmd.Parameters.AddWithValue("@IdPlanilla", model.IdPlanilla);
            cmd.Parameters.AddWithValue("@IdPrestamo", model.IdPrestamo);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<Deduccion> models)
        {
            throw new NotImplementedException();
        }

        public bool update(Deduccion model)
        {
            throw new NotImplementedException();
        }
    }
}
