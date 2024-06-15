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
    class ControladorComplementosPlato : DAOimpl<complementos_plato>
    {


        private static ControladorComplementosPlato instance = new ControladorComplementosPlato();


        private ControladorComplementosPlato()
        {

        }

        internal static ControladorComplementosPlato Instance
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

        public bool delete(complementos_plato model)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarComplementoplato", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcomplementos_plato", model.Idcomplementos_plato);

            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public complementos_plato find(int id)
        {
            throw new NotImplementedException();
        }

        public List<complementos_plato> findAll()
        {
            List<complementos_plato> complementos_plato = new List<complementos_plato>();
            string query = "SELECT * FROM VComplemento_plato";
            SqlDataReader lector = Conexion.getInstance().ejecutarqueryleer(query);
            while (lector.Read())
            {
                complementos_plato cp = new complementos_plato();
                // Verificar si el valor no es DBNull antes de asignarlo
                cp.Idcomplementos_plato = lector.IsDBNull(0) ? 0 : lector.GetInt64(0);
                cp.Nombre_complementosplato = lector.IsDBNull(1) ? string.Empty : lector.GetString(1);
                cp.Idtipocomplemento_plato = lector.IsDBNull(2) ? 0 : lector.GetInt64(2);

                complementos_plato.Add(cp);


            }
            lector.Close();
            return complementos_plato;
        }

        public List<complementos_plato> findAllByComboName(string nombreCombo)
        {
            List<complementos_plato> complementos_plato = new List<complementos_plato>();
            string query = @"
    SELECT cp.idcomplementos_plato, cp.nombre_complementosplato, cp.idtipocomplemento_plato
    FROM [" + Globales.basedatos + @"].[dbo].[complementos_plato] cp
    INNER JOIN [" + Globales.basedatos + @"].[dbo].[menu] m ON cp.idtipocomplemento_plato = m.idtipocomplemento
    WHERE m.nombrecombo = @nombreCombo
";

            /* FROM [MagpolloLocal_2].[dbo].[complementos_plato] cp*/
            /* INNER JOIN [MagpolloLocal_2].[dbo].[menu] m ON cp.idtipocomplemento_plato = m.idtipocomplemento*/

            SqlCommand cmd = new SqlCommand(query, Conexion.getInstance().getconexion());
            cmd.Parameters.AddWithValue("@nombreCombo", nombreCombo);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                complementos_plato cp = new complementos_plato();
                cp.Idcomplementos_plato = reader.IsDBNull(0) ? 0 : reader.GetInt64(0);
                cp.Nombre_complementosplato = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                cp.Idtipocomplemento_plato = reader.IsDBNull(2) ? 0 : reader.GetInt64(2);
                complementos_plato.Add(cp);
            }
            reader.Close();
            return complementos_plato;
        }

        public bool save(complementos_plato model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevoComplementoplato", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_complementosplato", model.Nombre_complementosplato);
            cmd.Parameters.AddWithValue("@idtipocomplemento_plato", model.Idtipocomplemento_plato);


            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<complementos_plato> models)
        {
            throw new NotImplementedException();
        }

        public bool update(complementos_plato model)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarComplementoplato", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcomplementos_plato", model.Idcomplementos_plato);
            cmd.Parameters.AddWithValue("@nombre_complementosplato", model.Nombre_complementosplato);
            cmd.Parameters.AddWithValue("@idtipocomplemento_plato", model.Idtipocomplemento_plato);

            return Conexion.getInstance().ejecutarSP(cmd);
        }
    }
}
