using EE;
//using SIGAV_BLL;
using SIGAV_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Bitacora
{
    public class S_Bitacora
    {
        static List<IObservador> observers = new List<IObservador>();
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

        public static void InsertarBitacora(EE_Bitacora bitacora)
        {
            //BLL_Bitacora bll_Bitacora = new BLL_Bitacora();
            //bll_Bitacora.InsertarBitacora(bitacora);
        }

    }
}
