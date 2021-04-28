using EE;
using SIGAV_MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_BLL
{
    public class BLL_Bitacora
    {
        public bool InsertarBitacora(EE_Bitacora bitacora)
        {
            MPP_Bitacora mpp_Bitacora = new MPP_Bitacora();
            bool resultado = mpp_Bitacora.InsertBitacora(bitacora);
            return resultado;
        }

    }
}
