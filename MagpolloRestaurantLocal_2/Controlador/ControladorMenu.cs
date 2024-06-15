using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTRchicken.Modelo;
using System.Data.SqlClient;
using System.Data;

namespace AppTRchicken.Controlador
{
    class ControladorMenu : DAOimpl<menu>
    {
        private static ControladorMenu instance = new ControladorMenu();

        private ControladorMenu()
        {

        }

        internal static ControladorMenu Instance
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


        public bool delete(menu model)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarMenu", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idmenu", model.Idmenu);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public menu find(string categoria)
        {
            menu menu = new menu();
            string query = "SELECT * FROM V_menu WHERE nombrecategoria = " + categoria;
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                menu.Idmenu = reader.GetInt32(0);
                menu.Nombrecombo = reader.GetString(1);
                menu.Precio = (decimal)reader.GetDouble(2);
            }
            reader.Close();
            return menu;

        }

        public menu find(int id)
        {
            return ((DAOimpl<menu>)instance).find(id);
        }

        public menu findNcomplemento(string combo)
        {

            menu menu = new menu();
            string query = $"SELECT ncomplemento FROM V_menu WHERE nombrecombo = '{combo}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {

                menu.Ncomplemento = (int)reader.GetInt32(0);

            }
            reader.Close();
            return menu;
        }
        public List<menu> findAll()
        {

            List<menu> menu = new List<menu>();
            string query = "SELECT * FROM V_menu";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                menu m = new menu();
                m.Idmenu = (int)reader.GetInt64(0);
                m.Nombrecombo = reader.GetString(1);
                m.Descripcion = reader.GetString(2);
                m.Precio = reader.GetDecimal(3);
                m.Idcategoria = (int)reader.GetInt64(4);
                m.Ncomplemento = (int)reader.GetInt32(5);
                m.Idtipocomplemento = (int)reader.GetInt64(8);

                menu.Add(m);

            }
            reader.Close();
            return menu;

        }


      

        public menu findnombre(int id)
        {
            menu menu = new menu();
            string query = "SELECT idmenu,nombrecombo,precio FROM V_menu WHERE idmenu = " + id;
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                menu.Idmenu = (int)reader.GetInt64(0);
                menu.Nombrecombo = reader.GetString(1);
                menu.Precio = reader.GetDecimal(2);
            }
            reader.Close();
            return menu;

        }

        public menu findidpornombre(string nombre)
        {
            menu menu = new menu();
            string query = $"SELECT idmenu,nombrecombo,precio FROM V_menu WHERE nombrecombo = '{nombre}'" ;
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                menu.Idmenu = (int)reader.GetInt64(0);
                menu.Nombrecombo = reader.GetString(1);
                menu.Precio = reader.GetDecimal(2);
            }
            reader.Close();
            return menu;

        }

        public List<menu> findbycategoria(string categoria)
        {

            List<menu> menu = new List<menu>();
            string query = $"SELECT * FROM Vista_menu WHERE nombrecategoria = '{categoria}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                menu m = new menu();
                m.Idmenu = (int)reader.GetInt64(0);
                m.Nombrecombo = reader.GetString(1);
                m.Descripcion = reader.GetString(2);
                m.Precio = reader.GetDecimal(3);
                m.Grupo = (int)reader.GetInt64(4);

                menu.Add(m);

            }
            reader.Close();
            return menu;




        }
        public bool save(menu model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevoMenu", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombrecombo", model.Nombrecombo);
            cmd.Parameters.AddWithValue("@descripcion", model.Descripcion);
            cmd.Parameters.AddWithValue("@precio", model.Precio);
            cmd.Parameters.AddWithValue("@idcategoria", model.Idcategoria);
            cmd.Parameters.AddWithValue("@ncomplemento", model.Ncomplemento);
            cmd.Parameters.AddWithValue("@idtipocomplemento", model.Idtipocomplemento);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<menu> models)
        {
            throw new NotImplementedException();
        }

        public bool update(menu model)
        {

            SqlCommand cmd = new SqlCommand("SP_Actualizarmenu", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idmenu", model.Idmenu);
            cmd.Parameters.AddWithValue("@nombrecombo", model.Nombrecombo);
            cmd.Parameters.AddWithValue("@descripcion", model.Descripcion);
            cmd.Parameters.AddWithValue("@precio", model.Precio);
            cmd.Parameters.AddWithValue("@idcategoria", model.Idcategoria);
            cmd.Parameters.AddWithValue("@ncomplemento", model.Ncomplemento);
            cmd.Parameters.AddWithValue("@idtipocomplemento", model.Idtipocomplemento);
            return Conexion.getInstance().ejecutarSP(cmd);
        }



        public DataTable Cargarcomboxmenu()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idmenu,nombrecombo FROM menu", Conexion.getInstance().getconexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }








        public List<menu> finreportexproductodia(string nombrecombo, string fecha)
        {
            List<menu> menus = new List<menu>();
            string query = $"SELECT * from V_Reportexproducto WHERE fecha = '{fecha}' AND nombrecombo = '{nombrecombo}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                menu menu = new menu();


                menu.Nombrecombo = reader.GetString(0);

                menus.Add(menu);


            }
            reader.Close();
            return menus;
        }















        public List<menu> finreportexproductomes(string nombrecombo, string fecha)
        {
            List<menu> menus = new List<menu>();
            string query = $"SELECT * from V_Reportexproducto WHERE MONTH(fecha) = '{ fecha}' AND nombrecombo = '{nombrecombo}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                menu menu = new menu();


                menu.Nombrecombo = reader.GetString(0);

                menus.Add(menu);


            }
            reader.Close();
            return menus;
        }



        public List<menu> finreportexproductoano(string nombrecombo, string fecha)
        {
            List<menu> menus = new List<menu>();
            string query = $"SELECT * from V_Reportexproducto WHERE YEAR(fecha) = '{ fecha}' AND nombrecombo = '{nombrecombo}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                menu menu = new menu();


                menu.Nombrecombo = reader.GetString(0);

                menus.Add(menu);


            }
            reader.Close();
            return menus;
        }


        public List<menu> finreportexproductodesdehasta(string nombrecombo, string desde, string hasta)
        {
            List<menu> menus = new List<menu>();
            string query = $"SELECT * from V_Reportexproducto WHERE fecha BETWEEN  '{desde}' AND '{hasta}' AND nombrecombo = '{nombrecombo}'";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                menu menu = new menu();


                menu.Nombrecombo = reader.GetString(0);

                menus.Add(menu);


            }
            reader.Close();
            return menus;
        }



    }
}
