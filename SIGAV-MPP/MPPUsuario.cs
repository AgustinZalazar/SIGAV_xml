using EE;
using Servicios;
using SIGAV_Acceso;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace SIGAV_MPP
{
    public class MPPUsuario
    {
        string basePath = AppDomain.CurrentDomain.BaseDirectory + @"xml_files2\";
        DAL_XML dal = new DAL_XML();
        public bool CrearUserXML(BE_Usuario User)
        {
            DAL_XML dal = new DAL_XML();
            bool resultado;
            resultado = dal.SaveXMLFile<BE_Usuario>(User, "Users.xml");
            return resultado;
        }
        
        public BE_Usuario ListarUn_UserXML(BE_Usuario User)
        {
            BE_Usuario e_Usuario = new BE_Usuario();
            DAL_XML dal = new DAL_XML();
            List<BE_Usuario> users = new List<BE_Usuario>();

            users = dal.ReadXml<BE_Usuario>("Users.xml");
            e_Usuario = users.Find(x => x.Username == User.Username); 
            return e_Usuario;
        }
        public List<BE_Usuario> ListarUsersXML(string empresa)
        {
            DAL_XML dal = new DAL_XML();
            List<BE_Usuario> users =  dal.ReadXml<BE_Usuario>("Users.xml");
            return users.FindAll(x => x.empresa == empresa);
        }
        public List<BE_Usuario> ListarAllUsersXML(string empresa)
        {
            DAL_XML dal = new DAL_XML();
            List<BE_Usuario> users = dal.ReadXml<BE_Usuario>("Users.xml");
            return users.FindAll(x => x.empresa != empresa);
        }
        public bool Update_UsuarioXML(BE_Usuario User)
        {
            string path = basePath + "Users.xml";
            XDocument doc = XDocument.Load(path);
            var consulta = from user in doc.Descendants("BE_Usuario") where (Convert.ToInt32(user.Attribute("ID").Value) == User.ID && user.Element("empresa").Value == User.empresa) select user;
            foreach (XElement Node in consulta)
            {
                Node.Element("Username").Value = User.Username;
                Node.Element("Password").Value = User.Password;
                Node.Element("nombre").Value = User.nombre;
                Node.Element("empresa").Value = User.empresa;
                Node.Element("puntaje").Value = User.puntaje.ToString();
            }
            doc.Save(path);
            return true;
        }
        public bool Delete_UsuarioXML(BE_Usuario User)
        {
            string path = basePath + "Users.xml";
            XDocument doc = XDocument.Load(path);
            var consulta = from users in doc.Descendants("BE_Usuario") where (Convert.ToInt32(users.Attribute("ID").Value) == User.ID && users.Element("empresa").Value == User.empresa) select users;
            consulta.Remove();
            doc.Save(path);
            return true;
        }

        #region MPP_BD
        public bool CrearUser(BE_Usuario User)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            string consulta = "S_AltaUser";
            hs.Add("@Username", User.Username);
            hs.Add("@Password", User.Password);
            hs.Add("@Nombre", User.nombre);
            hs.Add("@Empresa", User.empresa);
            resultado = dal.Escribir(consulta, hs);
            return resultado;
        }
        public bool EliminarUser(BE_Usuario User)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            hs.Add("@ID", User.ID);
            resultado = dal.Escribir("S_BajaUsuario", hs);
            return resultado;
        }
        public BE_Usuario ListarUn_User(BE_Usuario User)
        {
            DAL dal = new DAL();
            DataSet ds = new DataSet();
            Hashtable hs = new Hashtable();
            BE_Usuario e_Usuario = default(BE_Usuario);

            hs.Add("@ID_User", User.ID);
            hs.Add("@Username", User.Username);
            hs.Add("@Password", User.Password);

            ds = dal.Leer("S_ListarUnUser", hs);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    e_Usuario = new BE_Usuario();
                    e_Usuario.ID = Convert.ToInt32(item["ID_User"]);
                    e_Usuario.Username = item["Username"].ToString();
                    e_Usuario.Password = item["Password"].ToString();
                    e_Usuario.nombre = item["Nombre"].ToString();
                    e_Usuario.empresa = item["Empresa"].ToString();
                }
                return e_Usuario;
            }
            else
            {
                return null;
            }
        }

        public List<BE_Usuario> ListarUsuarios()
        {
            DAL dal = new DAL();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            List<BE_Usuario> list_users = new List<BE_Usuario>();
            BE_Usuario User = default(BE_Usuario);

            ds = dal.Leer("S_ListarUsuarios", null);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    User = new BE_Usuario();
                    User.ID = Convert.ToInt32(item["ID_User"]);
                    User.Username = item["Username"].ToString();
                    User.Password = item["Password"].ToString();
                    User.nombre = item["Nombre"].ToString();
                    User.empresa = item["Empresa"].ToString();

                    list_users.Add(User);
                }
                return list_users;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
