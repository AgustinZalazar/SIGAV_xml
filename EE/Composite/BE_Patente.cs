using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EE.Composite
{
    [Serializable]
    public class BE_Patente : BE_Permiso
    {
        public override List<BE_Permiso> ObtenerHijo
        {
            get
            {
                return new List<BE_Permiso>();
            }
        }

        public override void agregarHijo(BE_Permiso permiso_) { }
    }
}
