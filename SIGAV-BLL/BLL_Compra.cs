using EE;
using SIGAV_MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_BLL
{
    public class BLL_Compra
    {
        public bool CrearOActualizarCompra(BE_Compra e_Compra)
        {
            MPP_Compra mpp_Compra = new MPP_Compra();
            bool resultado = mpp_Compra.CrearOActualizarCompra(e_Compra);
            return resultado;
        }

        //public bool EliminarProducto(EE_Compra e_Venta)
        //{
        //    MPP_Compra mpp_Venta = new MPP_Compra();
        //    bool resultado = mpp_Venta.EliminarVenta(e_Venta);
        //    return resultado;
        //}

        public List<BE_Compra> ListarCompras()
        {
            MPP_Compra mpp_Compra = new MPP_Compra();
            List<BE_Compra> list = new List<BE_Compra>();
            return list = mpp_Compra.ListarCompras();
        }
    }
}
