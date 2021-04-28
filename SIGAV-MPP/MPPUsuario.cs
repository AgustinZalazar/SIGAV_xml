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
        public bool CrearUser(EE_Usuario User)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            string consulta = "S_AltaUser";
            hs.Add("@Username", User.Username);
            hs.Add("@Password", User.Password);

            resultado = dal.Escribir(consulta, hs);
            return resultado;
        }
        public bool EliminarUser(EE_Usuario User)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            hs.Add("@ID", User.ID);
            resultado = dal.Escribir("S_BajaUsuario", hs);
            return resultado;
        }

        public EE_Usuario ListarUn_User(EE_Usuario User)
        {
            DAL dal = new DAL();
            DataSet ds = new DataSet();
            Hashtable hs = new Hashtable();
            EE_Usuario e_Usuario = default(EE_Usuario);

            hs.Add("@Username", User.Username);
            hs.Add("@Password", User.Password);

            ds = dal.Leer("S_ListarUnUser", hs);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    e_Usuario = new EE_Usuario();
                    e_Usuario.Username = item["Username"].ToString();
                    e_Usuario.Password = item["Password"].ToString();
                }
                return User;
            }
            else
            {
                return null;
            }
        }

        public List<EE_Usuario> ListarUsuarios()
        {
            DAL dal = new DAL();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            List<EE_Usuario> list_users = new List<EE_Usuario>();
            EE_Usuario User = default(EE_Usuario);

            ds = dal.Leer("S_ListarUsuarios", null);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    User = new EE_Usuario();
                    User.ID = Convert.ToInt32(item["ID_User"]);
                    User.Username = item["Username"].ToString();
                    User.Password = item["Password"].ToString();

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
