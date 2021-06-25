using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE.Composite
{
    public class BE_Familia : BE_Permiso
    {
        private IList<BE_Permiso> _hijos;
        public BE_Familia()
        {
            _hijos = new List<BE_Permiso>();
        }
        public override IList<BE_Permiso> ObtenerHijo
        {
            get
            {
                return _hijos.ToArray();
            }
        }

        public override void agregarHijo(BE_Permiso permiso_)
        {

            _hijos.Add(permiso_);
        }
    }
}
