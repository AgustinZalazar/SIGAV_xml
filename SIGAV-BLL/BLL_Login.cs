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
        public BE_Usuario ListarUnUser(BE_Usuario _Usuario)
        {
            BE_Usuario User = new BE_Usuario();
            MPPUsuario MPP_User = new MPPUsuario();
            return User = MPP_User.ListarUn_User(_Usuario);
        }

        public BE_Usuario Logear(string Username, string Password)
        {
            BE_Usuario _Usuario = new BE_Usuario();
            BE_Usuario _Usuario2 = new BE_Usuario();
            BLL_Login _Login = new BLL_Login();

            _Usuario.Username = Username;
            _Usuario.Password = Password;
            _Usuario2 = _Login.ListarUnUser(_Usuario);

            return _Usuario2;
        }
    }
}
