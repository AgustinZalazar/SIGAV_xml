using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EE;
using SIGAV_Acceso;


namespace SIGAV_MPP
{
    public class MPP_Producto
    {
        string basePath = AppDomain.CurrentDomain.BaseDirectory + @"xml_files2\";
        public bool CrearProductoXML(BE_Producto _Producto)
        {
            DAL_XML dal = new DAL_XML();
            bool resultado;
            resultado = dal.SaveXMLFile<BE_Producto>(_Producto, "Productos.xml");
            return resultado;
        }

        public List<BE_Producto> ListarProductosXML(string empresa)
        {
            DAL_XML dal = new DAL_XML();
            List<BE_Producto> list = dal.ReadXml<BE_Producto>("Productos.xml");
            List<BE_Producto> listFiltrada = list.FindAll(item => item.Empresa == empresa);
            return listFiltrada;
        }
        public bool Update_ProductoXML(BE_Producto producto)
        {
            DAL_XML dal = new DAL_XML();
            string path = basePath + "Productos.xml";
            XDocument doc = XDocument.Load(path);
            var consulta = from prod in doc.Descendants("BE_Producto") where (Convert.ToInt32(prod.Attribute("ID").Value) == producto.ID) && (prod.Element("Empresa").Value == producto.Empresa) select prod;
            foreach (XElement Node in consulta)
            {
                Node.Element("Nombre").Value = producto.Nombre;
                Node.Element("Descripcion").Value = producto.Descripcion;
                Node.Element("Cantidad").Value = producto.Cantidad.ToString();
                Node.Element("Precio").Value = producto.Precio.ToString();
                Node.Element("Tipo").Value = producto.Tipo;
                Node.Element("Empresa").Value = producto.Empresa;
            }
            doc.Save(path);
            return true;
        }
        public bool Delete_ProductoXML(BE_Producto producto)
        {
            DAL_XML dal = new DAL_XML();
            string path = basePath + "Productos.xml";
            XDocument doc = XDocument.Load(path);
            var consulta = from prod in doc.Descendants("BE_Producto") where Convert.ToInt32(prod.Attribute("ID").Value) == producto.ID select prod;
            consulta.Remove();
            doc.Save(path);
            return true;
        }


        #region MPP Base de datos 
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

        #endregion
    }
}
