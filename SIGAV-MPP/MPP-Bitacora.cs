using EE;
using SIGAV_Acceso;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_MPP
{
    public class MPP_Bitacora
    {
        public bool InsertBitacora(EE_Bitacora bitacora)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;
            string consulta = "S_InsertarEnBitacora";
            hs.Add("@Usuario", bitacora.Usuario.Username);
            hs.Add("@Hora", bitacora.Hora);
            hs.Add("@Dia", bitacora.Fecha);

            resultado = dal.Escribir(consulta, hs);
            return resultado;
        }
    }
}
