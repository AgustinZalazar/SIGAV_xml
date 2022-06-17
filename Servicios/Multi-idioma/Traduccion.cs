using SIGAV_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EE;

namespace Servicios.Multi_idioma
{
    public static class Traduccion
    {
        static List<IObservador> observers = new List<IObservador>();
        static BE_Idioma idiomaSeleccionado;

        public static void Idioma(BE_Idioma idioma)
        {
            idiomaSeleccionado = idioma;                   
            Notificar();
        }
        public static void Añadir(IObservador obj)
        {
            if (obj != null)
            {
                observers.Add(obj);
            }           
        }

        public static void Eliminar(IObservador obj)
        {
            if (obj != null)
            {
                observers.Remove(obj);
            }
        }

        public static void Notificar()
        {
            foreach (IObservador item in observers)
            {
                item.update();
            }
        }
        public static string traducir(string key)
        {
           
            return (from BE_Traduccion traduccion in idiomaSeleccionado.Traducciones
                    where traduccion.Tag.CompareTo(key) == 0 
                    select traduccion).FirstOrDefault()?.Descripcion;
        }

        public static void Traducir(Control control)
        {
            if (control.Tag!=null)
            {
                control.Text = traducir(control.Tag.ToString());
            }
            if(control.HasChildren)
            {
                foreach (Control controlhijo in control.Controls)
                {
                    Traducir(controlhijo);
                }
            }
        }
    }
}
