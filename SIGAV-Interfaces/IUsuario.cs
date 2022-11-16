using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_Interfaces
{
    public interface IUsuario
    {
        int ID { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string empresa { get; set; }
        string nombre { get; set; }
    }
}
