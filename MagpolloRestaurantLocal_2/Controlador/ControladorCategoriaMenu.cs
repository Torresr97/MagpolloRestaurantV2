using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTRchicken.Modelo;
using System.Data.SqlClient;

namespace AppTRchicken.Controlador
{
    class ControladorCategoriaMenu : DAOimpl<categoria_menu>
    {

        private static ControladorCategoriaMenu instance = new ControladorCategoriaMenu();

        private ControladorCategoriaMenu()
        {

        }

        internal static ControladorCategoriaMenu Instance
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



        public bool delete(categoria_menu model)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarCategoriamenu", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcategoriamenu", model.Idcategoriamenu);
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public categoria_menu find(int id)
        {
            categoria_menu categoria_menu = new categoria_menu();
            string query = "SELECT nombrecategoria FROM categoria_menu WHERE idcategoriamenu = " + id;
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {

                categoria_menu.Nombrecategoria = reader.GetString(0);

            }
            reader.Close();
            return categoria_menu;

        }

       

        public List<categoria_menu> findAll()
        {
            List<categoria_menu> categoria_menu = new List<categoria_menu>();
            string query = "SELECT * FROM V_Categoria_Menu";
            SqlDataReader reader = Conexion.getInstance().ejecutarqueryleer(query);
            while (reader.Read())
            {
                categoria_menu cm = new categoria_menu();
                cm.Idcategoriamenu = (int)reader.GetInt64(0);
                cm.Nombrecategoria = reader.GetString(1);

                categoria_menu.Add(cm);

            }
            reader.Close();
            return categoria_menu;
        }



            public bool save(categoria_menu model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevoCategoriamenu", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombrecategoriamenu", model.Nombrecategoria);
            
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<categoria_menu> models)
        {
            throw new NotImplementedException();
        }

        public bool update(categoria_menu model)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarCategoriamenu", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcategoria", model.Idcategoriamenu);
            cmd.Parameters.AddWithValue("@nombrecategoria", model.Nombrecategoria);

            return Conexion.getInstance().ejecutarSP(cmd);
        }
    }
}
