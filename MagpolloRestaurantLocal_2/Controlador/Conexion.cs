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
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message + "Revisa que las credenciales correctas");
                }
            }
        }

        // Método privado para obtener la cadena de conexión
        public static string ObtenerConnectionString()
        {
            // Aquí puedes construir dinámicamente la cadena de conexión
            string servidor = "mssql-59935-0.cloudclusters.net";
            string baseDatos;

            // Aquí puedes construir dinámicamente la cadena de conexión

            if (Globales.IsDynamicLogin)
            {
                baseDatos = ObtenerBaseDatos(Globales.Nombrebasedatos);

            }
            else
            {
                baseDatos = "MagpolloLocal_2";
            }
            /*MagpolloLocal_Prisma*/
            /*MagpolloLocal_1*/
            /*michoacanasprueba*/
            /*MagpolloLocal_2*/
            /*MagpollopruebaARIELTORRES*/
            /*MagpolloLocal_1_Autoservicio*/


            Globales.nombresucursallbl = ObtenerNombreSucursal(baseDatos);


            Globales.basedatos = baseDatos;
            string usuario = Globales.nombreusuario;
            // string password = "Maguser2024#";
            string password = " Maguser2024#";
            // MessageBox.Show("Base de datos es" + baseDatos);
            return $"Data Source={servidor},18808;Initial Catalog={baseDatos};Persist Security Info=True;User ID={usuario};Password={password}";
        }


        public static string ObtenerBaseDatos(string nombreSucursal)
        {
            switch (nombreSucursal)
            {
                case "PLAZA CALPULES":
                    return "MagpolloLocal_1";
                case "PLAZA LOS ZORZALES":
                    return "MagpolloLocal_2";
                case "PLAZA CALPULES - AUTOSERVICIO":
                    return "MagpolloLocal_1_Autoservicio";
                case "PLAZA PRISMA":
                    return "MagpolloLocal_Prisma";


                default:
                    return "base_datos_desconocida";
            }
        }
        public static string ObtenerNombreSucursal(string baseDatos)
        {
            switch (baseDatos)
            {
                case "MagpolloLocal_1":
                    return "PLAZA CALPULES";
                case "MagpolloLocal_2":
                    return "PLAZA LOS ZORZALES";
                case "MagpolloLocal_1_Autoservicio":
                    return "PLAZA CALPULES - AUTOSERVICIO";
                case "MagpolloLocal_Prisma":
                    return "PLAZA PRISMA";

                default:
                    return "NOMBRE DESCONOCIDO";
            }
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
        /***************FUNCION PARA CONEXION A OTRA BASES DE DATOS**********************/
        
        public static SqlConnection ObtenerConexionEnOtraBD(string baseDatos)
        {
            
         
            string servidor = "mssql-59935-0.cloudclusters.net";
            //string usuario = Globales.nombreusuario;
            // string usuario = "aftorres";
            string password = "Torres07740";
            string connectionString = $"Data Source={servidor},18808;Initial Catalog={baseDatos};Persist Security Info=True;User ID=usr;Password={password}";
            SqlConnection nuevaConexion = new SqlConnection(connectionString);
            try
            {
                nuevaConexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }
            return nuevaConexion;
        }
        public SqlDataReader ejecutarQueryLeerEnOtraBD(string query, string baseDatos)
        {
            SqlDataReader datareader = null;
            SqlConnection nuevaConexion = ObtenerConexionEnOtraBD(baseDatos);
            if (nuevaConexion != null)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, nuevaConexion);
                    datareader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return datareader;
        }
        public bool ejecutarSPEnOtraBD(SqlCommand cmd, string baseDatos)
        {
            bool ret = false;
            SqlConnection conexionUtilizada = ObtenerConexionEnOtraBD(baseDatos);

            if (conexionUtilizada == null)
            {
                return false; // No se pudo obtener la conexión
            }

            try
            {
                cmd.Connection = conexionUtilizada; // Usar la conexión a la otra base de datos
                cmd.ExecuteNonQuery();
                ret = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el SP en otra BD: " + ex.Message);
            }
            finally
            {
                conexionUtilizada.Close(); // Cerrar la conexión
            }
            return ret;
        }

    }
}
