using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;

namespace Servicios
{
    public class S_Login
    {
        private static S_Login instance;

        private BE_Usuario _usuario;
        public BE_Usuario Usuario
        {
            get
            {
                return _usuario;
            }
        }
        private static object _lock = new Object();
        public static void Login(BE_Usuario usuario)
        {
            lock (_lock)
            {
                if (instance == null)
                {
                    instance = new S_Login();
                    instance._usuario = usuario;
                }
                else
                {
                    throw new Exception("sesion ya iniciada");
                }
            }
            
        }

        public void Logout()
        {
            if (instance != null)
            {
                _usuario = null;
                instance = null;
            }           
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
