using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using SIGAV_Acceso;

namespace SIGAV_MPP
{
    public class MPP_Venta
    {
        public bool CrearVenta(BE_Venta e_Venta)
        {
            DAL _Dal = new DAL();
            Hashtable hashtable = new Hashtable();
            string consulta;
            bool resultado;
            if (e_Venta.id_venta != 0)
            {
                hashtable.Add("@id_venta", e_Venta.id_venta);
                hashtable.Add("@producto", e_Venta.producto);
                hashtable.Add("@cantidad", e_Venta.cantidad);
                hashtable.Add("@empleado", e_Venta.empleado);
                hashtable.Add("@empresa", e_Venta.empresa);
                hashtable.Add("@precio_total", e_Venta.precio_final);
                consulta = "S_UpdateVenta";
                resultado = _Dal.Escribir(consulta, hashtable);
                return resultado;
            }
            else
            {
                consulta = "S_AltaVenta";
                hashtable.Add("@producto", e_Venta.producto);
                hashtable.Add("@cantidad", e_Venta.cantidad);
                hashtable.Add("@empleado", e_Venta.empleado);
                hashtable.Add("@empresa", e_Venta.empresa);
                hashtable.Add("@precio_total", e_Venta.precio_final);
                resultado = _Dal.Escribir(consulta, hashtable);
                return resultado;
            }

        }

        public bool EliminarVenta(BE_Venta e_Venta)
        {
            DAL _Dal = new DAL();
            Hashtable hashtable = new Hashtable();
            string consulta = "S_DeleteVenta";
            bool resultado;
            hashtable.Add("@id_venta", e_Venta.id_venta);
            resultado = _Dal.Escribir(consulta, hashtable);
            return resultado;
        }

        public List<BE_Venta> ListarVentas()
        {
            DAL dal = new DAL();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            List<BE_Venta> list_ventas = new List<BE_Venta>();
            BE_Venta venta = default(BE_Venta);

            ds = dal.Leer("S_ListarVentas", null);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    venta = new BE_Venta();
                    venta.id_venta = Convert.ToInt32(item["id_venta"]);
                    venta.producto = item["producto"].ToString();
                    venta.cantidad = Convert.ToInt32(item["cantidad"]);
                    venta.empleado = item["empleado"].ToString();
                    venta.empresa = item["empresa"].ToString();
                    venta.precio_final = Convert.ToInt32(item["precio"]);
                    list_ventas.Add(venta);
                }
                return list_ventas;
            }
            else
            {
                return null;
            }
        }

        public List<BE_Venta> ListarVentasOtraEmpresa(string empresa)
        {
            DAL dal = new DAL();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            List<BE_Venta> list_ventas = new List<BE_Venta>();
            BE_Venta venta = default(BE_Venta);
            Hashtable hashtable = new Hashtable();

            hashtable.Add("@empresa", empresa);

            ds = dal.Leer("S_ListarVentasDifEmpresa", hashtable);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    venta = new BE_Venta();
                    venta.id_venta = Convert.ToInt32(item["id_venta"]);
                    venta.producto = item["producto"].ToString();
                    venta.cantidad = Convert.ToInt32(item["cantidad"]);
                    venta.empleado = item["empleado"].ToString();
                    venta.empresa = item["empresa"].ToString();
                    venta.precio_final = Convert.ToInt32(item["precio"]);
                    list_ventas.Add(venta);
                }
                return list_ventas;
            }
            else
            {
                return null;
            }
        }
    }
}
