using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class BE_Envios
    {
        public int id_envio { get; set; }
        public string producto { get; set; }
        public int cantidad { get; set; }

        public string Estado_Envio { get; set; }

        public string Estado_Producto { get; set; }
        public string tipo { get; set; }
    }
}
