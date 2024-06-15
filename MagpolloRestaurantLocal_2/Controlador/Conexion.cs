using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using AppTRchicken.Utilidades;
using System.Data;

namespace AppTRchicken.Controlador
{
    class Conexion
    {

        // private SqlConnection conexion = new SqlConnection("Data Source=mssql-59935-0.cloudclusters.net,18808;Initial Catalog=MagpolloLocal_2;Persist Security Info=True;User ID=magpollouser2;Password=MagPollo2");

        private static SqlConnection conexion;
        private static Conexion instance = new Conexion();

        private Conexion()
        {
            AbrirConexion(); // Abre la conexión al crear la instancia
        }

        public static Conexion getInstance()
        {
            return instance;
        }

        public SqlConnection getconexion()
        {
            return conexion;
        }

        private void AbrirConexion()
        {
            if (conexion == null)
            {
                try
                {
                    string connectionString = ObtenerConnectionString();
                    conexion = new SqlConnection(connectionString);
                    conexion.Open();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message+ "Revisa que las credenciales correctas");
                }
            }
        }

        // Método privado para obtener la cadena de conexión
        public static string ObtenerConnectionString()
        {
            // Aquí puedes construir dinámicamente la cadena de conexión
            string servidor = "mssql-59935-0.cloudclusters.net";
            string baseDatos = "MagpolloLocal_1";
            /*MagpolloLocal_1*/
            /*michoacanasprueba*/
            /*MagpolloLocal_2*/

            if (baseDatos == "MagpolloLocal_1") 
            {
                Globales.nombresucursallbl = "PLAZA CALPULES";
            }
            else if (baseDatos == "MagpolloLocal_2")
            {
                Globales.nombresucursallbl = "PLAZA LOS ZORZALES";
            }

                Globales.basedatos = baseDatos;
            string usuario = Globales.nombreusuario;
           // string password = "Maguser2024#";
            string password = "Maguser2024#";

            return $"Data Source={servidor},18808;Initial Catalog={baseDatos};Persist Security Info=True;User ID={usuario};Password={password}";

        }
        public bool ejecutarQuery(string query)
        {
            bool ret = false;
            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                ret = true;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                    
            }
            return ret;
            

        }
        



        public bool ejecutarSP(SqlCommand cmd)
        {
            bool ret = false;
            try
            {
                
                cmd.ExecuteNonQuery();
                ret = true;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            return ret;


        }





        public SqlDataReader ejecutarqueryleer(string query)
        {
            SqlDataReader datareader = null;

            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                datareader = cmd.ExecuteReader();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            return datareader;

        }

    }
}
