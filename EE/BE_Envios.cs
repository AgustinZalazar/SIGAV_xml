using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EE
{
    [Serializable]
    public class BE_Envios
    {
        [XmlAttribute("id_envio")]
        public int id_envio { get; set; }
        public BE_Oferta oferta { get; set; }
        public string Estado_Envio { get; set; }
        public string Estado_Producto { get; set; }
    }
}
