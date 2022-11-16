using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EE.Composite
{
    [Serializable]
    public abstract class BE_Permiso
    {
        [XmlAttribute("ID")]
        public string ID { get; set; }
        public string Nombre { get; set; }
        public abstract void agregarHijo(BE_Permiso permiso_);
        public abstract List<BE_Permiso> ObtenerHijo { get; }
    }
}
