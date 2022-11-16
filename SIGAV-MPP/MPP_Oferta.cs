using EE;
using SIGAV_Acceso;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SIGAV_MPP
{
    public class MPP_Oferta
    {
        string basePath = AppDomain.CurrentDomain.BaseDirectory + @"xml_files2\";
        DAL_XML dal = new DAL_XML();
        public bool CrearOfertaXML(BE_Oferta _Oferta)
        {
            bool resultado;
            resultado = dal.SaveXMLFile<BE_Oferta>(_Oferta, "Ofertas.xml");
            return resultado;
        }

        public List<BE_Oferta> ListarOfertasXML()
        {
            List<BE_Oferta> list = new List<BE_Oferta>();
            list = dal.ReadXml<BE_Oferta>("Ofertas.xml");
            return list;
        }
        public bool Update_OfertaXML(BE_Oferta compra)
        {
            string path = basePath + "Ofertas.xml";
            XDocument doc = XDocument.Load(path);
            var consulta = from ofertaXE in doc.Descendants("BE_Oferta") where Convert.ToInt32(ofertaXE.Attribute("id_oferta").Value) == compra.id_oferta select ofertaXE;
            foreach (XElement Node in consulta)
            {
                Node.Element("precio_oferta").Value = compra.precio_oferta.ToString();
                Node.Element("precio_inicial").Value = compra.precio_inicial.ToString();
                Node.Element("usuario_puntaje").Value = compra.usuario_puntaje.ToString();
                Node.Element("autorizada_oferta").Value = compra.autorizada_oferta.ToString().ToLower();
                Node.Element("estado").Value = compra.estado;
                Node.Element("empresa_compradora").Value = compra.empresa_compradora;
            }
            doc.Save(path);
            return true;
        }

        #region MPP Base de datos
        //public bool CrearOActualizarCompra(BE_Oferta e_Compra)
        //{
        //    DAL _Dal = new DAL();
        //    Hashtable hashtable = new Hashtable();
        //    string consulta;
        //    bool resultado;
        //    if (e_Compra.id_compra != 0)
        //    {
        //        hashtable.Add("@id_compra", e_Compra.id_compra);
        //        hashtable.Add("@autorizada", e_Compra.autorizada);
        //        consulta = "S_UpdateCompra";
        //        resultado = _Dal.Escribir(consulta, hashtable);
        //        return resultado;
        //    }
        //    else
        //    {
        //        consulta = "S_AltaCompra";
        //        hashtable.Add("@producto", e_Compra.producto);
        //        hashtable.Add("@cantidad", e_Compra.cantidad);
        //        hashtable.Add("@precio", e_Compra.precio);
        //        hashtable.Add("@empleado", e_Compra.empleado);
        //        hashtable.Add("@empresa", e_Compra.empresa);
        //        hashtable.Add("@autorizada", e_Compra.autorizada);
        //        resultado = _Dal.Escribir(consulta, hashtable);
        //        return resultado;
        //    }

        //}
        //public List<BE_Oferta> ListarCompras()
        //{
        //    DAL dal = new DAL();
        //    DataTable dt = new DataTable();
        //    DataSet ds = new DataSet();
        //    List<BE_Oferta> list_compras = new List<BE_Oferta>();
        //    BE_Oferta compra = default(BE_Oferta);

        //    ds = dal.Leer("S_ListarCompras", null);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        foreach (DataRow item in ds.Tables[0].Rows)
        //        {
        //            compra = new BE_Oferta();
        //            compra.id_compra = Convert.ToInt32(item["id_compra"]);
        //            compra.producto = item["producto"].ToString();
        //            compra.cantidad = Convert.ToInt32(item["cantidad"]);
        //            compra.precio = Convert.ToInt32(item["precio"]);
        //            compra.empleado = item["empleado"].ToString();
        //            compra.empresa = item["empresa"].ToString();
        //            compra.autorizada = Convert.ToBoolean(item["autorizada"]);
        //            list_compras.Add(compra);
        //        }
        //        return list_compras;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        #endregion
    }
}
