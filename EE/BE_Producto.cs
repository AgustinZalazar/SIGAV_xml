using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EE
{
    [Serializable]
    public class BE_Producto
    {
        [XmlAttribute("ID")]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public string Tipo { get; set; }
        public string Empresa { get; set; }

    }
}
