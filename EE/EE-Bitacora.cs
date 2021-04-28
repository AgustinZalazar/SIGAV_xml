using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EE_Bitacora
    {
        public int ID_Bitacora { get; set; }
        public EE_Usuario Usuario { get; set; }
        public int Hora { get; set; }
        public DateTime Fecha { get; set; }

    }
}
