using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGAV_MPP;
using EE;

namespace SIGAV_BLL
{
    public class BLL_Usuario
    {
        public bool CrearUser(BE_Usuario _Usuario)
        {
            MPPUsuario MPP_User = new MPPUsuario();
            bool resultado;
            resultado = MPP_User.CrearUser(_Usuario);
            return resultado;
        }
        public bool ModificarUser(BE_Usuario _Usuario)
        {
            MPPUsuario MPP_User = new MPPUsuario();
            bool resultado;
            resultado = MPP_User.CrearUser(_Usuario);
            return resultado;
        }
        public bool EliminarUser(BE_Usuario _Usuario)
        {
            MPPUsuario MPP_User = new MPPUsuario();
            bool resultado;
            resultado = MPP_User.EliminarUser(_Usuario);
            return resultado;
        }

        public List<BE_Usuario> ListarUsers()
        {
            List<BE_Usuario> List_User = new List<BE_Usuario>();
            MPPUsuario MPP_User = new MPPUsuario();
            return List_User = MPP_User.ListarUsuarios();
        }

    }
}
