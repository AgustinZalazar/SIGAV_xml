using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EE
{
    [Serializable]
    public class BE_Oferta
    {
        [XmlAttribute("id_oferta")]
        public int id_oferta { get; set; }
        public BE_Producto producto { get; set; }
        public int cantidad { get; set; }
        //Usuario y empresa que inicio la oferta
        public string usuario { get; set; }
        public string empresa { get; set; }
        public int usuario_puntaje { get; set; }
        //Direccion de envio del comprador
        public string direccion_de_envio { get; set; }
        public int precio_oferta { get; set; }
        public int precio_inicial { get; set; }
        public string estado { get; set; }
        public bool autorizada_oferta { get; set; }
        public string fechaFinalizacion { get; set; }
        public string empresa_compradora { get; set; }

    }
}
