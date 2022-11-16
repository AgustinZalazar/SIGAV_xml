using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EE
{
    [Serializable]
    public class BE_Venta
    {
        [XmlAttribute("id_venta")]
        public int id_venta { get; set; }
        public BE_Oferta oferta { get; set; }
        public string fecha { get; set; }

    }
}
