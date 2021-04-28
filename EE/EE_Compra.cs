using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EE_Compra
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public EE_Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }

    }
}
