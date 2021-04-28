using EE;
using SIGAV_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class S_Login
    {
        private static S_Login instance = null;

        private IUsuario _usuario;
        public IUsuario Usuario
        {
            get
            {
                return _usuario;
            }
        }

        public void Login(IUsuario usuario)
        {
            _usuario = usuario;
        }

        public void Logout()
        {
            _usuario = null;
            instance = null;
        }

        private S_Login(){}

        public static S_Login ObtenerSesion
        {
            get
            {
                if (instance == null)
                {
                    instance = new S_Login();
                }
                return instance;
            }
        }
    }
}
