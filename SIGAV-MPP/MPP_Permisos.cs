using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EE;
using EE.Composite;
using SIGAV_Acceso;

namespace SIGAV_MPP
{
    public class MPP_Permisos
    {
        DAL_XML dal = new DAL_XML();

        string basePath = AppDomain.CurrentDomain.BaseDirectory + @"xml_files2\";
        public bool CrearPermiso_Familia(BE_Familia _Permiso)
        {
            bool resultado = dal.SaveXMLFile<BE_Familia>(_Permiso, "Familia.xml");
            return resultado;
        }
        public bool CrearPermiso_Patente(BE_Patente _Permiso)
        {
            bool resultado = dal.SaveXMLFile<BE_Patente>(_Permiso, "Patente.xml");
            return resultado;
        }
        public bool Update_FamiliaXML(BE_Familia _Permiso)
        {
            string path = basePath + "Familia.xml";
            XDocument doc = XDocument.Load(path);
            var consulta = from familia in doc.Descendants("BE_Familia") where familia.Attribute("ID").Value == _Permiso.ID select familia;
            foreach (XElement Node in consulta)
            {
                Node.Element("Nombre").Value = _Permiso.Nombre;
            }
            doc.Save(path);
            return true;
        }
        public bool Delete_FamiliaXML(BE_Familia _Permiso)
        {
            string path = basePath + "Familia.xml";
            XDocument doc = XDocument.Load(path);
            var consulta = from familia in doc.Descendants("BE_Familia") where familia.Attribute("ID").Value == _Permiso.ID select familia;
            consulta.Remove();
            doc.Save(path);
            return true;
        }
        public bool Update_PatenteXML(BE_Patente _Permiso)
        {
            string path = basePath + "Patente.xml";
            XDocument doc = XDocument.Load(path);
            var consulta = from patente in doc.Descendants("BE_Patente") where patente.Attribute("ID").Value == _Permiso.ID select patente;
            foreach (XElement Node in consulta)
            {
                Node.Element("Nombre").Value = _Permiso.Nombre;
            }
            doc.Save(path);
            return true;
        }
        public bool Delete_PatenteXML(BE_Patente _Permiso)
        {
            string path = basePath + "Patente.xml";
            XDocument doc = XDocument.Load(path);
            var consulta = from patente in doc.Descendants("BE_Patente") where patente.Attribute("ID").Value == _Permiso.ID select patente;
            consulta.Remove();
            doc.Save(path);
            return true;
        }
        public List<BE_Familia> ListarPermisosXML_Familia()
        {
            List<BE_Familia> list = dal.ReadXml<BE_Familia>("Familia.xml");
            return list;
        }
        public List<BE_Patente> ListarPermisosXML_Patente()
        {
            List<BE_Patente> list = dal.ReadXml<BE_Patente>("Patente.xml");
            return list;
        }
        public bool InsertarPatenteEnFamiliaXML(BE_Permiso patente, BE_Permiso familia)
        {
            bool resultado;
            try
            {
                if (!File.Exists(basePath + "permiso_permiso.xml"))
                {
                    XDocument xmlFile = new XDocument( new XDeclaration("1.0", "utf-8", "yes") );
                    XElement rootElement = new XElement("Familia_Patente", new XElement("id_familia_patente", familia.ID + "-" + patente.ID));
                    xmlFile.Add(rootElement);
                    xmlFile.Save(basePath + "permiso_permiso.xml");
                }
                else
                {
                    XDocument xmlDoc = XDocument.Load(basePath + "permiso_permiso.xml");
                    xmlDoc.Root.Add(new XElement("Familia_Patente", new XElement("id_familia_patente", familia.ID + "-" + patente.ID)));
                    xmlDoc.Save(basePath + "permiso_permiso.xml");
                }
                resultado = true;
            }
            catch (Exception)
            {
                resultado = false;
            }
            
            return resultado;
        }
        public bool AsignarPermisosXML(string id_Permiso, int id_Usuario)
        {
            bool resultado;
            try
            {
                if (!File.Exists(basePath + "usuario_permiso.xml"))
                {
                    XDocument xmlFile = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
                    XElement rootElement = new XElement("user_permiso", new XElement("id_usuario_permiso", id_Usuario + "-" + id_Permiso));
                    xmlFile.Add(rootElement);
                    xmlFile.Save(basePath + "usuario_permiso.xml");
                }
                else
                {
                    XDocument xmlDoc = XDocument.Load(basePath + "usuario_permiso.xml");
                    xmlDoc.Root.Add(new XElement("user_permiso", new XElement("id_usuario_permiso", id_Usuario + "-" + id_Permiso)));
                    xmlDoc.Save(basePath + "usuario_permiso.xml");
                }
                resultado = true;
            }
            catch (Exception)
            {
                resultado = false;
            }

            return resultado;
        }
        public List<BE_Permiso> GetFamilia_Patente(string familiaID)
        {
            List<BE_Permiso> hijos = new List<BE_Permiso>();
            DAL_XML dal = new DAL_XML();
            List<string> familiaPatente = dal.ReadXMLPermiso_Permiso();
            if (familiaPatente.Count!=0)
            {
                BE_Familia flia= dal.ReadXml<BE_Familia>("Familia.xml").Find(x=> x.ID.Equals( familiaID));
                foreach (string item in familiaPatente)
                {
                    List<string> valores = item.Split('-').ToList<string>();
                    if(valores[0] == flia.ID)
                    {
                        if (valores[1].Substring(0,1)=="F")
                        {
                            BE_Familia famHijo = dal.ReadXml<BE_Familia>("Familia.xml").Find(x => x.ID.Equals(valores[1]));
                            List<BE_Permiso> permisosfamHijo = GetFamilia_Patente(famHijo.ID);
                            if (permisosfamHijo.Count!= 0)
                            {
                                foreach (BE_Permiso permiso in permisosfamHijo)
                                {
                                    famHijo.agregarHijo(permiso);
                                }
                            }
                            flia.agregarHijo(famHijo);
                        }
                        else if (valores[1].Substring(0, 1) == "P")
                        {
                            BE_Patente patHijo = dal.ReadXml<BE_Patente>("Patente.xml").Find(x => x.ID.Equals(valores[1]));
                            flia.agregarHijo(patHijo);
                        }
                    }

                }
                return flia.ObtenerHijo;


            }
            return hijos;
        }
        public bool DeleteFamilia(string familiaID)
        {
            List<BE_Permiso> hijos = new List<BE_Permiso>();
            DAL_XML dal = new DAL_XML();
            List<string> familiaPatente = dal.ReadXMLPermiso_Permiso();
            if (familiaPatente.Count != 0)
            {
                BE_Familia flia = dal.ReadXml<BE_Familia>("Familia.xml").Find(x => x.ID.Equals(familiaID));
                foreach (string item in familiaPatente)
                {
                    List<string> valores = item.Split('-').ToList<string>();
                    if (valores[0] == flia.ID)
                    {
                        string path = basePath + "permiso_permiso.xml";
                        XDocument doc = XDocument.Load(path);
                        var consulta = from permiso_permiso in doc.Descendants("Familia_Patente").Descendants("Familia_Patente") where permiso_permiso.Value == item select permiso_permiso;
                        consulta.Remove();
                        doc.Save(path);
                    }

                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteFamilia_Familia(string familiaID1 ,string familiaID2)
        {
            List<BE_Permiso> hijos = new List<BE_Permiso>();
            DAL_XML dal = new DAL_XML();
            List<string> familiaPatente = dal.ReadXMLPermiso_Permiso();
            if (familiaPatente.Count != 0)
            {
                foreach (string item in familiaPatente)
                {
                    List<string> valores = item.Split('-').ToList<string>();
                    if (valores[0] == familiaID1 && valores[1] == familiaID2)
                    {
                        string path = basePath + "permiso_permiso.xml";
                        XDocument doc = XDocument.Load(path);
                        var consulta = from permiso_permiso in doc.Descendants("Familia_Patente").Descendants("Familia_Patente") where permiso_permiso.Value == item select permiso_permiso;
                        consulta.Remove();
                        doc.Save(path);
                    }

                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeletePatenteRelacion(string patenteID)
        {
            List<BE_Permiso> hijos = new List<BE_Permiso>();
            DAL_XML dal = new DAL_XML();
            List<string> familiaPatente = dal.ReadXMLPermiso_Permiso();
            if (familiaPatente.Count != 0)
            {
                BE_Patente patente = dal.ReadXml<BE_Patente>("Patente.xml").Find(x => x.ID.Equals(patenteID));
                foreach (string item in familiaPatente)
                {
                    List<string> valores = item.Split('-').ToList<string>();
                    if (valores[1] == patente.ID)
                    {
                        string path = basePath + "permiso_permiso.xml";
                        XDocument doc = XDocument.Load(path);
                        var consulta = from permiso_permiso in doc.Descendants("Familia_Patente").Descendants("Familia_Patente") where permiso_permiso.Value == item select permiso_permiso;
                        consulta.Remove();
                        doc.Save(path);
                    }

                }
                return true;
            }
            return true;
        }
        public bool DeleteFamiliaPatente(string familiaID, string patenteID)
        {
            List<BE_Permiso> hijos = new List<BE_Permiso>();
            DAL_XML dal = new DAL_XML();
            List<string> familiaPatente = dal.ReadXMLPermiso_Permiso();
            if (familiaPatente.Count != 0)
            {
                foreach (string item in familiaPatente)
                {
                    List<string> valores = item.Split('-').ToList<string>();
                    if (valores[0] == familiaID && valores[1] == patenteID)
                    {
                        string path = basePath + "permiso_permiso.xml";
                        XDocument doc = XDocument.Load(path);
                        var consulta = from permiso_permiso in doc.Descendants("Familia_Patente").Descendants("Familia_Patente") where permiso_permiso.Value == item select permiso_permiso;
                        consulta.Remove();
                        doc.Save(path);
                    }

                }
                return true;
            }
            return true;
        }
        public List<BE_Permiso> ListUserByPermisos(BE_Usuario user)
        {
            List<BE_Permiso> hijos = new List<BE_Permiso>();
            DAL_XML dal = new DAL_XML();
            List<string> usuarioPermiso = dal.ReadXMLUsuario_Permiso();
            if (usuarioPermiso.Count != 0)
            {
                foreach (string item in usuarioPermiso)
                {
                    List<string> valores = item.Split('-').ToList<string>();
                    if (int.Parse(valores[0]) == user.ID)
                    {
                        if (valores[1].Substring(0, 1) == "F")
                        {
                            BE_Familia famHijo = dal.ReadXml<BE_Familia>("Familia.xml").Find(x => x.ID.Equals(valores[1]));
                            List<BE_Permiso> permisosfamHijo = GetFamilia_Patente(famHijo.ID);
                            if (permisosfamHijo.Count != 0)
                            {
                                foreach (BE_Permiso permiso in permisosfamHijo)
                                {
                                    famHijo.agregarHijo(permiso);
                                }
                            }
                            user.Permisos.Add(famHijo);
                        }
                        else if (valores[1].Substring(0, 1) == "P")
                        {
                            BE_Patente patHijo = dal.ReadXml<BE_Patente>("Patente.xml").Find(x => x.ID.Equals(valores[1]));
                            user.Permisos.Add(patHijo);
                        }
                    }

                }
                return user.Permisos;
            }
            return hijos;
        }

        public bool DeletePermisosUser(BE_Usuario user, string id_permiso)
        {
            List<BE_Permiso> hijos = new List<BE_Permiso>();
            DAL_XML dal = new DAL_XML();
            List<string> usuarioPermiso = dal.ReadXMLUsuario_Permiso();
            if (usuarioPermiso.Count != 0)
            {
                foreach (string item in usuarioPermiso)
                {
                    List<string> valores = item.Split('-').ToList<string>();
                    if (int.Parse(valores[0]) == user.ID)
                    {
                        if (valores[1] == id_permiso)
                        {
                            string path = basePath + "usuario_permiso.xml";
                            XDocument doc = XDocument.Load(path);
                            var consulta = from permiso_permiso in doc.Descendants("user_permiso").Descendants("user_permiso") where permiso_permiso.Value == item select permiso_permiso;
                            consulta.Remove();
                            doc.Save(path);
                        }
                    }

                }
                return true;
            }
            return true;
        }
        private BE_Permiso GetComponent(int id, IList<BE_Permiso> lista)
        {

            BE_Permiso component = lista != null ? lista.Where(i => i.ID.Equals(id)).FirstOrDefault() : null;

            if (component == null && lista != null)
            {
                foreach (var c in lista)
                {

                    var l = GetComponent(id, c.ObtenerHijo);
                    if (l != null && l.ID.Equals( id)) return l;
                    else
                    if (l != null)
                        return GetComponent(id, l.ObtenerHijo);

                }
            }
            return component;
        }
        
    }
}
