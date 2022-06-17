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
    public class MPPUsuario
    {
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
    }
}
