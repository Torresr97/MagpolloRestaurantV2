using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTRchicken.Modelo;
using System.Data.SqlClient;

using AppTRchicken.Controlador;

namespace AppTRchicken.Controlador
{
    class ControladorConfig_inventario : DAOimpl<caja>
    {
        private static ControladorConfig_inventario instance = new ControladorConfig_inventario();


        internal static ControladorConfig_inventario Instance
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


        public bool delete(Config_inventario model)
        {
            throw new NotImplementedException();
        }

        public Config_inventario find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Config_inventario> findAll()
        {
            throw new NotImplementedException();
        }

        public bool save(Config_inventario model)
        {
            SqlCommand cmd = new SqlCommand("SP_NuevaConfiginventario", Conexion.getInstance().getconexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idmenu", model.);
            cmd.Parameters.AddWithValue("@idinventario", model.Motivo);
            cmd.Parameters.AddWithValue("@cantidadrestar", model.Totalefectivo);
 
            return Conexion.getInstance().ejecutarSP(cmd);
        }

        public bool save(List<Config_inventario> models)
        {
            throw new NotImplementedException();
        }

        public bool update(Config_inventario model)
        {
            throw new NotImplementedException();
        }
    }
}
