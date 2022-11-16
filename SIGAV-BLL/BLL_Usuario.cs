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
            resultado = MPP_User.CrearUserXML(_Usuario);
            return resultado;
        }
        public bool EliminarUser(BE_Usuario _Usuario)
        {
            MPPUsuario MPP_User = new MPPUsuario();
            bool resultado;
            resultado = MPP_User.Delete_UsuarioXML(_Usuario);
            return resultado;
        }
        public bool UpdateUser(BE_Usuario _Usuario)
        {
            MPPUsuario MPP_User = new MPPUsuario();
            bool resultado;
            resultado = MPP_User.Update_UsuarioXML(_Usuario);
            return resultado;
        }
        public List<BE_Usuario> ListarUsers(string empresa)
        {
            MPPUsuario MPP_User = new MPPUsuario();
            List<BE_Usuario> List_User = MPP_User.ListarUsersXML(empresa);
            return List_User;
        }
        public List<BE_Usuario> ListarAllUsers(string empresa)
        {
            MPPUsuario MPP_User = new MPPUsuario();
            List<BE_Usuario> List_User = MPP_User.ListarAllUsersXML(empresa);
            return List_User;
        }
        public BE_Usuario ListarUnUser(BE_Usuario _Usuario)
        {
            MPPUsuario MPP_User = new MPPUsuario();
            return MPP_User.ListarUn_UserXML(_Usuario);
        }
    }
}
