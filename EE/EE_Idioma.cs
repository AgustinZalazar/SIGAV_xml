using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EE_Idioma
    {

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private List<EE_Traduccion> traducciones = new List<EE_Traduccion>();

        public List<EE_Traduccion> Traducciones
        {
            get { return traducciones; }
            set { traducciones = value; }

        }

    }
}
