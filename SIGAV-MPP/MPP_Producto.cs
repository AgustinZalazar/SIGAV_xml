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
    public class MPP_Producto
    {
        public bool CrearProducto(BE_Producto e_Producto)
        {
            DAL _Dal = new DAL();
            Hashtable hashtable = new Hashtable();
            string consulta;
            bool resultado;
            if (e_Producto.ID != 0)
            {
                hashtable.Add("@ID_Producto", e_Producto.ID);
                hashtable.Add("@Nombre", e_Producto.Nombre);
                hashtable.Add("@Descripcion", e_Producto.Descripcion);
                hashtable.Add("@Cantidad", e_Producto.Cantidad);
                hashtable.Add("@PrecioInicial", e_Producto.Precio);
                hashtable.Add("@Tipo", e_Producto.Tipo);
                consulta = "S_UpdatePRoducto";
                resultado = _Dal.Escribir(consulta, hashtable);
                return resultado;
            }
            else
            {
               consulta = "S_AgregarProducto";
               //hashtable.Add("@ID_Producto", e_Producto.ID);
               hashtable.Add("@Nombre", e_Producto.Nombre);
               hashtable.Add("@Descripcion", e_Producto.Descripcion);
               hashtable.Add("@Cantidad", e_Producto.Cantidad);
               hashtable.Add("@PrecioInicial", e_Producto.Precio);
               hashtable.Add("@Tipo", e_Producto.Tipo);
               resultado = _Dal.Escribir(consulta, hashtable);
               return resultado;
            }
            
        }

        public bool EliminarProducto(BE_Producto e_Producto)
        {
            DAL _Dal = new DAL();
            Hashtable hashtable = new Hashtable();
            string consulta = "S_DeleteProducto";
            bool resultado;
            hashtable.Add("@ID_Producto", e_Producto.ID);
            resultado = _Dal.Escribir(consulta, hashtable);
            return resultado;
        }

        public List<BE_Producto> ListarProductos()
        {
            DAL dal = new DAL();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            List<BE_Producto> list_productos = new List<BE_Producto>();
            BE_Producto producto = default(BE_Producto);

            ds = dal.Leer("S_ListarProductos", null);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    producto = new BE_Producto();
                    producto.ID = Convert.ToInt32(item["ID_Producto"]);
                    producto.Nombre = item["Nombre"].ToString();
                    producto.Descripcion = item["Descripcion"].ToString();
                    producto.Cantidad = Convert.ToInt32(item["Cantidad"]);
                    producto.Precio = Convert.ToInt32(item["PrecioInicial"]);
                    producto.Tipo = item["Tipo"].ToString();
                    list_productos.Add(producto);
                }
                return list_productos;
            }
            else
            {
                return null;
            }
        }
    }
}
