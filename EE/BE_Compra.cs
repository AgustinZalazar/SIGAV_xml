using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class BE_Compra
    {
        public int id_compra { get; set; }
        public string producto { get; set; }
        public int cantidad { get; set; }
        public string empleado { get; set; }
        public string empresa { get; set; }
        public int precio { get; set; }
        public bool autorizada { get; set; }

    }
}
