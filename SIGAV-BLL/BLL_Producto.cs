using EE;
using SIGAV_MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_BLL
{
    public class BLL_Producto
    {
        public bool CrearProducto(EE_Producto e_Producto)
        {
            MPP_Producto mpp_Producto = new MPP_Producto();
            bool resultado = mpp_Producto.CrearProducto(e_Producto);
            return resultado;
        }

        public bool EliminarProducto(EE_Producto e_Producto)
        {
            MPP_Producto mpp_Producto = new MPP_Producto();
            bool resultado = mpp_Producto.EliminarProducto(e_Producto);
            return resultado;
        }

        public List<EE_Producto> ListarProductos()
        {
            MPP_Producto mpp_Producto = new MPP_Producto();
            List<EE_Producto> list = new List<EE_Producto>();
            return list = mpp_Producto.ListarProductos();
        }
    }
}
