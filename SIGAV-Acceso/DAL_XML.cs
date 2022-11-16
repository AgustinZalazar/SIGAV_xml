using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SIGAV_Acceso
{
    public class DAL_XML
    {
        string basePath = AppDomain.CurrentDomain.BaseDirectory + @"xml_files2\";
        public bool SaveXMLFile<T>(T obj, string xmlName)
        {
            try
            {

                string path = basePath + xmlName;
                if (File.Exists(path))
                {
                    List<T> listOfObj = ReadXml<T>(xmlName);
                    listOfObj.Add(obj);
                    var xs = new XmlSerializer(typeof(List<T>));

                    using (var writer = new StreamWriter(path))
                    {
                        xs.Serialize(writer, listOfObj);
                    }
                }
                else
                {
                    List<T> listOfObj = new List<T>();
                    listOfObj.Add(obj);
                    var xs = new XmlSerializer(typeof(List<T>));

                    using (var writer = new StreamWriter(path))
                    {
                        xs.Serialize(writer, listOfObj);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<T> ReadXml<T>(string xmlName)
        {
            try
            {
                List<T> list = new List<T>();
                string path = basePath + xmlName;
                if (File.Exists(path)) {
                    var xs = new XmlSerializer(typeof(List<T>));
                    using (var reader = new StreamReader(path))
                    {
                        list = (List<T>)xs.Deserialize(reader);
                    }
                    return list;
                }
                else
                {
                    List<T> listOfObj = new List<T>();
                    return listOfObj;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<string> ReadXMLPermiso_Permiso()
        {
            try
            {
                string path = basePath + "permiso_permiso.xml";
                if (File.Exists(path))
                {
                    XDocument xDoc = XDocument.Load(path);
                    List<string> listOfObj = new List<string>();
                    var consulta = from Familia_Patente in xDoc.Descendants("Familia_Patente").Descendants("Familia_Patente")
                                   select new
                                   {
                                       id_familia_patente = Familia_Patente.Element("id_familia_patente").Value
                                   };
                    foreach (var item in consulta)
                    {
                        listOfObj.Add(item.id_familia_patente);
                    }
                    return listOfObj;
                }
                else
                {
                    List<string> listOfObj = new List<string>();
                    return listOfObj;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<string> ReadXMLUsuario_Permiso()
        {
            try
            {
                string path = basePath + "usuario_permiso.xml";
                if (File.Exists(path))
                {
                    XDocument xDoc = XDocument.Load(path);
                    List<string> listOfObj = new List<string>();
                    var consulta = from Usuario_Permiso in xDoc.Descendants("user_permiso").Descendants("user_permiso")
                                   select new
                                   {
                                       id_usuario_permiso = Usuario_Permiso.Element("id_usuario_permiso").Value
                                   };
                    foreach (var item in consulta)
                    {
                        listOfObj.Add(item.id_usuario_permiso);
                    }
                    return listOfObj;
                }
                else
                {
                    List<string> listOfObj = new List<string>();
                    return listOfObj;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
