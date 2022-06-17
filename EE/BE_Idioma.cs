using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class BE_Idioma
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

        private List<BE_Traduccion> traducciones = new List<BE_Traduccion>();

        public List<BE_Traduccion> Traducciones
        {
            get { return traducciones; }
            set { traducciones = value; }

        }

        public static class SharedData
        {
            public static BE_Idioma SelectedLenguage { get; set; }
        }
        
    }
}
