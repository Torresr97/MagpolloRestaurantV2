using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTRchicken.Modelo;
using System.Data.SqlClient;

namespace AppTRchicken.Controlador
{
    class ControladorPlanilla : DAOimpl<Planilla>
    {
        private static ControladorPlanilla instance = new ControladorPlanilla();

        private ControladorPlanilla()
        {

        }

        internal static ControladorPlanilla Instance
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
    
public bool delete(Planilla model)
        {
            throw new NotImplementedException();
        }

        public Planilla find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Planilla> findAll()
        {
            throw new NotImplementedException();
        }

        public List<Planilla> ReportePlanillames(string mes, int idempleado)
        {
            List<Planilla> planillas = new List<Planilla>();
            string query = $"SELECT * FROM  V_Planillas WHERE MONTH(fechaemision) = '{mes}' AND idempleado = '{idempleado}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                Planilla Planilla = new Planilla();
                Planilla.Idplanilla = (int)reader.GetInt64(0);
                Planilla.Idempleado = (int)reader.GetInt64(1);
                Planilla.Fechaemision = reader.GetDateTime(2);
                Planilla.Periododesde = reader.GetDateTime(3);
                Planilla.Periodohasta = reader.GetDateTime(4);
                Planilla.Sueldobase = reader.GetDecimal(5);
                Planilla.Ingresoextra = reader.GetDecimal(6);
                Planilla.Totaldeducciones = reader.GetDecimal(7);
                Planilla.Totalapagar = reader.GetDecimal(8);

                planillas.Add(Planilla);

            }
            reader.Close();
            return planillas;
        }
        public bool save(Planilla model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevaPlanilla", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idempleado", model.Idempleado);
            cmd.Parameters.AddWithValue("@fechaemision", model.Fechaemision);
            cmd.Parameters.AddWithValue("@periododesde", model.Periododesde);
            cmd.Parameters.AddWithValue("@periodohasta", model.Periodohasta);
            cmd.Parameters.AddWithValue("@sueldobase", model.Sueldobase);
            cmd.Parameters.AddWithValue("@ingresoextra", model.Ingresoextra);
            cmd.Parameters.AddWithValue("@totaldeducciones", model.Totaldeducciones);
            cmd.Parameters.AddWithValue("@totalapagar", model.Totalapagar);

            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<Planilla> models)
        {
            throw new NotImplementedException();
        }

        public bool update(Planilla model)
        {
            throw new NotImplementedException();
        }
    }
}
