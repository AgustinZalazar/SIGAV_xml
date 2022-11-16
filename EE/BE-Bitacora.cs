using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EE
{
    [Serializable]
    public class EE_Bitacora
    {
        [XmlAttribute("ID_Bitacora")]
        public int ID_Bitacora { get; set; }
        public string Usuario { get; set; }
        public string Log { get; set; }
        public DateTime Fecha { get; set; }

    }
}
