using EE;
using SIGAV_MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SIGAV_BLL
{
    public class BLL_Venta
    {
        public bool CrearVentaXML(BE_Venta e_Venta)
        {
            MPP_Venta mpp_Venta = new MPP_Venta();
            bool resultado = mpp_Venta.CrearVentaXML(e_Venta);
            return resultado;
        }

        public bool EliminarVentaXML(BE_Venta e_Venta)
        {
            MPP_Venta mpp_Venta = new MPP_Venta();
            bool resultado = mpp_Venta.Delete_VentaXML(e_Venta);
            return resultado;
        }

        public bool UpdateVentaXML(BE_Venta e_Venta)
        {
            MPP_Venta mpp_Venta = new MPP_Venta();
            bool resultado = mpp_Venta.Update_VentasXML(e_Venta);
            return resultado;
        }
        public List<BE_Venta> ListarVentasXML()
        {
            MPP_Venta mpp_Venta = new MPP_Venta();
            List<BE_Venta> list = new List<BE_Venta>();
            return list = mpp_Venta.ListarVentasXML();
        }

        public List<BE_Venta> ListarVentasOtraEmpresaXML()
        {
            MPP_Venta mpp_Venta = new MPP_Venta();
            List<BE_Venta> list = new List<BE_Venta>();
            return list = mpp_Venta.ListarVentasOtraEmpresaXML();
        }

        #region BLL Base de datos
        //public bool CrearOActualizarVenta(BE_Venta e_Venta)
        //{
        //    MPP_Venta mpp_Venta = new MPP_Venta();
        //    bool resultado = mpp_Venta.CrearVenta(e_Venta);
        //    return resultado;
        //}

        //public bool EliminarProducto(BE_Venta e_Venta)
        //{
        //    MPP_Venta mpp_Venta = new MPP_Venta();
        //    bool resultado = mpp_Venta.EliminarVenta(e_Venta);
        //    return resultado;
        //}

        //public List<BE_Venta> ListarVentas()
        //{
        //    MPP_Venta mpp_Venta = new MPP_Venta();
        //    List<BE_Venta> list = new List<BE_Venta>();
        //    return list = mpp_Venta.ListarVentas();
        //}

        //public List<BE_Venta> ListarVentasOtraEmpresa(string empresa)
        //{
        //    MPP_Venta mpp_Venta = new MPP_Venta();
        //    List<BE_Venta> list = new List<BE_Venta>();
        //    return list = mpp_Venta.ListarVentasOtraEmpresa(empresa);
        //}
        #endregion
    }
}
