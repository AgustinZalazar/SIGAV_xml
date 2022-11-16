using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Composite
{
    public abstract class Permiso
    {
       public int ID { get; set; }
       public string Nombre { get; set; }
       public abstract  void agregarHijo(Permiso permiso_);
       public abstract IList<Permiso> ObtenerHijo { get; }

    }
}
