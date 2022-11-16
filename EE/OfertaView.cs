using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class OfertaView
    {
        public int id_oferta { get; set; }
        public string producto { get; set; }
        public int cantidad { get; set; }
        public int precio_inicial { get; set; }
        public int precio_oferta { get; set; }
        public string empresa { get; set; }
        public int usuario_puntaje { get; set; }
        public bool autorizada_oferta { get; set; }
        public string fechaFinalizacion { get; set; }
    }
}
