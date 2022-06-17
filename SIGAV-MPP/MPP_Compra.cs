using EE;
using SIGAV_Acceso;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_MPP
{
    public class MPP_Compra
    {
        public bool CrearOActualizarCompra(BE_Compra e_Compra)
        {
            DAL _Dal = new DAL();
            Hashtable hashtable = new Hashtable();
            string consulta;
            bool resultado;
            if (e_Compra.id_compra != 0)
            {
                hashtable.Add("@id_compra", e_Compra.id_compra);
                hashtable.Add("@autorizada", e_Compra.autorizada);
                consulta = "S_UpdateCompra";
                resultado = _Dal.Escribir(consulta, hashtable);
                return resultado;
            }
            else
            {
                consulta = "S_AltaCompra";
                hashtable.Add("@producto", e_Compra.producto);
                hashtable.Add("@cantidad", e_Compra.cantidad);
                hashtable.Add("@precio", e_Compra.precio);
                hashtable.Add("@empleado", e_Compra.empleado);
                hashtable.Add("@empresa", e_Compra.empresa);
                hashtable.Add("@autorizada", e_Compra.autorizada);
                resultado = _Dal.Escribir(consulta, hashtable);
                return resultado;
            }

        }
        public List<BE_Compra> ListarCompras()
        {
            DAL dal = new DAL();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            List<BE_Compra> list_compras = new List<BE_Compra>();
            BE_Compra compra = default(BE_Compra);

            ds = dal.Leer("S_ListarCompras", null);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    compra = new BE_Compra();
                    compra.id_compra = Convert.ToInt32(item["id_compra"]);
                    compra.producto = item["producto"].ToString();
                    compra.cantidad = Convert.ToInt32(item["cantidad"]);
                    compra.precio = Convert.ToInt32(item["precio"]);
                    compra.empleado = item["empleado"].ToString();
                    compra.empresa = item["empresa"].ToString();
                    compra.autorizada = Convert.ToBoolean(item["autorizada"]);
                    list_compras.Add(compra);
                }
                return list_compras;
            }
            else
            {
                return null;
            }
        }
    }
}
