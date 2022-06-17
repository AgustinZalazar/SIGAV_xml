using SIGAV_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE.Composite;

namespace EE
{
    public class BE_Usuario : IUsuario
    {
        List<BE_Permiso> _permisos;
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string empresa { get; set; }
        public string nombre { get; set; }
        public BE_Usuario()
        {
            _permisos = new List<BE_Permiso>();
        }
        public List<BE_Permiso> Permisos
        {
            get
            {
                return _permisos;
            }
        }
    }
}
