using EE;
using SIGAV_MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_BLL
{
    public class BLL_Oferta
    {
        MPP_Oferta mpp_Oferta = new MPP_Oferta();
        public bool CrearOfertaXML(BE_Oferta e_Oferta)
        {    
            bool resultado = mpp_Oferta.CrearOfertaXML(e_Oferta);
            return resultado;
        }
        public bool ActualizarOfertaXML(BE_Oferta e_Oferta)
        {
            bool resultado = mpp_Oferta.Update_OfertaXML(e_Oferta);
            return resultado;
        }
        public List<BE_Oferta> ListarOfertasXML()
        {
            List<BE_Oferta> list = new List<BE_Oferta>();
            return list = mpp_Oferta.ListarOfertasXML();
        }

        #region BLL Base de datos
        //public bool CrearOActualizarCompra(BE_Oferta e_Compra)
        //{
        //    MPP_Oferta mpp_Compra = new MPP_Oferta();
        //    bool resultado = mpp_Compra.CrearOActualizarCompra(e_Compra);
        //    return resultado;
        //}

        //public List<BE_Oferta> ListarCompras()
        //{
        //    MPP_Oferta mpp_Compra = new MPP_Oferta();
        //    List<BE_Oferta> list = new List<BE_Oferta>();
        //    return list = mpp_Compra.ListarCompras();
        //}
        #endregion
    }
}
