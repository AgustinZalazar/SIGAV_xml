using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EE.Composite
{
    [Serializable] 

    public class BE_Familia : BE_Permiso
    {
        private List<BE_Permiso> _hijos;
        public BE_Familia()
        {
            _hijos = new List<BE_Permiso>();
        }
        public override List<BE_Permiso> ObtenerHijo
        {
            get
            {
                return _hijos;
            }
        }

        public override void agregarHijo(BE_Permiso permiso_)
        {

            _hijos.Add(permiso_);
        }
    }
}
