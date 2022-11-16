using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE.Composite;
using System.Xml.Serialization;

namespace EE
{
    [Serializable]
    public class BE_Usuario
    {
        List<BE_Permiso> _permisos;
        [XmlAttribute("ID")]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string empresa { get; set; }
        public string direccion_empresa { get; set; }
        public string nombre { get; set; }
        public int puntaje { get; set; }
        public BE_Usuario()
        {
            _permisos = new List<BE_Permiso>();
        }
        public List<BE_Permiso> Permisos
        {
            get
            {
                return _permisos;
            }
        }
    }
}
