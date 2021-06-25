using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Composite
{
    public class Patente : Permiso
    {
        public override IList<Permiso> ObtenerHijo
        {
            get
            {
                return new List<Permiso>();
            }
        }

        public override void agregarHijo(Permiso permiso_){}

    }
}
