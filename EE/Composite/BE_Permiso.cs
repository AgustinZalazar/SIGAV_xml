using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE.Composite
{
    public abstract class BE_Permiso
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public bool Es_Patente { get; set; }
        public abstract void agregarHijo(BE_Permiso permiso_);
        public abstract IList<BE_Permiso> ObtenerHijo { get; }
    }
}
