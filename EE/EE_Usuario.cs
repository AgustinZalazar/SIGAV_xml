using SIGAV_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EE_Usuario : IUsuario
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        //public string Permisos { get; set; }
    }
}
