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
        public bool CrearProductoXML(BE_Producto e_Producto)
        {
            MPP_Producto mpp_Producto = new MPP_Producto();
            bool resultado = mpp_Producto.CrearProductoXML(e_Producto);
            return resultado;
        }
        public bool ActualizarProductoXML(BE_Producto e_Producto)
        {
            MPP_Producto mpp_Producto = new MPP_Producto();
            bool resultado = mpp_Producto.Update_ProductoXML(e_Producto);
            return resultado;
        }
        public bool EliminarProductoXML(BE_Producto e_Producto)
        {
            MPP_Producto mpp_Producto = new MPP_Producto();
            bool resultado = mpp_Producto.Delete_ProductoXML(e_Producto);
            return resultado;
        }

        public List<BE_Producto> ListarProductosXML(string empresa)
        {
            MPP_Producto mpp_Producto = new MPP_Producto();
            List<BE_Producto> list = mpp_Producto.ListarProductosXML(empresa);
            return list;
        }

        #region BLL Base de datos
        public bool CrearProducto(BE_Producto e_Producto)
        {
            MPP_Producto mpp_Producto = new MPP_Producto();
            bool resultado = mpp_Producto.CrearProducto(e_Producto);
            return resultado;
        }

        public bool EliminarProducto(BE_Producto e_Producto)
        {
            MPP_Producto mpp_Producto = new MPP_Producto();
            bool resultado = mpp_Producto.EliminarProducto(e_Producto);
            return resultado;
        }

        public List<BE_Producto> ListarProductos()
        {
            MPP_Producto mpp_Producto = new MPP_Producto();
            List<BE_Producto> list = new List<BE_Producto>();
            return list = mpp_Producto.ListarProductos();
        }
        #endregion

    }
}
