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
    public class MPP_Envios
    {
        string basePath = AppDomain.CurrentDomain.BaseDirectory + @"xml_files2\";
        public bool CrearEnvioXML(BE_Envios _Envio)
        {
            DAL_XML dal = new DAL_XML();
            bool resultado;
            resultado = dal.SaveXMLFile<BE_Envios>(_Envio, "Envios.xml");
            return resultado;
        }

        public List<BE_Envios> ListarEnviosXML()
        {
            DAL_XML dal = new DAL_XML();
            List<BE_Envios> list = dal.ReadXml<BE_Envios>("Envios.xml");
            return list;
        }

        public bool Update_EnviosXML(BE_Envios Envio)
        {
            DAL_XML dal = new DAL_XML();
            string path = basePath + "Envios.xml";
            XDocument doc = XDocument.Load(path);
            var consulta = from envio in doc.Descendants("BE_Envios") where Convert.ToInt32(envio.Attribute("id_envio").Value) == Envio.id_envio select envio;
            foreach (XElement Node in consulta)
            {
                Node.Element("Estado_Producto").Value = Envio.Estado_Producto;
                Node.Element("Estado_Envio").Value = Envio.Estado_Envio;
            }
            doc.Save(path);
            return true;
        }

        #region MPP Base de datos
        //public bool CrearOActualizarEnvio(BE_Envios e_Envios)
        //{
        //    DAL _Dal = new DAL();
        //    Hashtable hashtable = new Hashtable();
        //    string consulta;
        //    bool resultado;
        //    if (e_Envios.id_envio != 0)
        //    {
        //        consulta = "S_UpdateEnvio";
        //        hashtable.Add("@id_envio", e_Envios.id_envio);
        //        hashtable.Add("@estado_envio", e_Envios.Estado_Envio);
        //        hashtable.Add("@estado_producto", e_Envios.Estado_Producto);
        //        resultado = _Dal.Escribir(consulta, hashtable);
        //        return resultado;
        //    }
        //    else
        //    {
        //        consulta = "S_AltaEnvio";
        //        hashtable.Add("@producto", e_Envios.producto);
        //        hashtable.Add("@cantidad", e_Envios.cantidad);
        //        hashtable.Add("@estado_envio", e_Envios.Estado_Envio);
        //        hashtable.Add("@estado_producto", e_Envios.Estado_Producto);
        //        hashtable.Add("@tipo", e_Envios.tipo);
        //        resultado = _Dal.Escribir(consulta, hashtable);
        //        return resultado;
        //    }
            
            

        //}
        //public List<BE_Envios> ListarEnvios(string tipo)
        //{
        //    DAL dal = new DAL();
        //    DataTable dt = new DataTable();
        //    DataSet ds = new DataSet();
        //    List<BE_Envios> list_envios = new List<BE_Envios>();
        //    BE_Envios envio = default(BE_Envios);
        //    Hashtable hashtable = new Hashtable();
        //    hashtable.Add("@tipo", tipo);

        //    ds = dal.Leer("S_ListarEnvios", hashtable);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        foreach (DataRow item in ds.Tables[0].Rows)
        //        {
        //            envio = new BE_Envios();
        //            envio.id_envio = Convert.ToInt32(item["id_envio"]);
        //            envio.producto = item["producto"].ToString();
        //            envio.cantidad = Convert.ToInt32(item["cantidad"]);
        //            envio.Estado_Envio = item["estado_envio"].ToString();
        //            envio.Estado_Producto = item["estado_producto"].ToString();
        //            envio.tipo = item["tipo"].ToString();
        //            list_envios.Add(envio);
        //        }
        //        return list_envios;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        #endregion

    }
}
