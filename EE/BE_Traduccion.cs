using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
  public  class BE_Traduccion
  {
        private string tag;

        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int ID_Idioma { get; set; }

  }
}
