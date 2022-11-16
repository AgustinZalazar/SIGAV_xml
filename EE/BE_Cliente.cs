using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EE
{
    [Serializable]
    public class BE_Cliente
    {
        [XmlAttribute("ID")]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public int Celular { get; set; }
        public string Nombre_Empresa { get; set; }
    }
}
