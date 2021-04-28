using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGAV_MPP;
using EE;

namespace SIGAV_BLL
{
    public class BLL_Login
    {
        public EE_Usuario ListarUnUser(EE_Usuario _Usuario)
        {
            EE_Usuario User = new EE_Usuario();
            MPPUsuario MPP_User = new MPPUsuario();
            return User = MPP_User.ListarUn_User(_Usuario);
        }

        public EE_Usuario Logear(string Username, string Password)
        {
            EE_Usuario _Usuario = new EE_Usuario();
            EE_Usuario _Usuario2 = new EE_Usuario();
            BLL_Login _Login = new BLL_Login();

            _Usuario.Username = Username;
            _Usuario.Password = Password;
            _Usuario2 = _Login.ListarUnUser(_Usuario);

            return _Usuario2;
        }
    }
}
