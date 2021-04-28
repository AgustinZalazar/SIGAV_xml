using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Composite
{
    public class Familia : Permiso
    {
        private IList<Permiso> _hijos;
        public Familia()
        {
            _hijos = new List<Permiso>();
        }
        public override IList<Permiso> ObtenerHijo
        {
            get
            {
                return _hijos.ToArray();
            }
        }

        public override void agregarHijo(Permiso permiso_)
        {
            
            _hijos.Add(permiso_);
        }
    }
}
