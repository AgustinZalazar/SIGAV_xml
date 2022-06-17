using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using EE.Composite;
using SIGAV_Acceso;

namespace SIGAV_MPP
{
    public class MPP_Permisos
    {
        DAL Dal_ = new DAL();

        public bool AsignarPermisos(int id_Permiso, int id_Usuario)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            string consulta = "S_AsignarPermiso";
            hs.Add("@ID_Permiso", id_Permiso);
            hs.Add("@ID_Usuario", id_Usuario);
            resultado = dal.Escribir(consulta, hs);
            return resultado;
        }
        public IList<BE_Permiso> GetAll(string familia)
        {
            var where = "is NULL";

            if (!String.IsNullOrEmpty(familia))
            {
                where = familia;
            }

            DataSet ds = new DataSet();


            var sql = $@"with recursivo as (
                        select sp2.id_permiso_padre, sp2.id_permiso_hijo  from Permisos_Permisos SP2
                        where sp2.id_permiso_padre {where}
                        UNION ALL 
                        select sp.id_permiso_padre, sp.id_permiso_hijo from Permisos_Permisos sp 
                        inner join recursivo r on r.id_permiso_hijo= sp.id_permiso_padre
                        )
                        select r.id_permiso_padre,r.id_permiso_hijo,p.id,p.nombre, p.es_patente
                        from recursivo r 
                        inner join permiso p on r.id_permiso_hijo = p.id 
						
                        ";

            ds = Dal_.Leer2(sql);

            var lista = new List<BE_Permiso>();

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    int id_padre = 0;
                    if (item["id_permiso_padre"] != DBNull.Value)
                    {
                        id_padre = Convert.ToInt32(item["id_permiso_padre"]);
                    }

                    var id = Convert.ToInt32(item["id"]);
                    var nombre = item["nombre"].ToString();
                    var patente = Convert.ToBoolean(item["es_patente"]);


                    BE_Permiso c;

                    if (!patente)
                        c = new BE_Familia();
                    else
                        c = new BE_Patente();

                    c.ID = id;
                    c.Nombre = nombre;

                    var padre = GetComponent(id_padre, lista);

                    if (padre == null)
                    {
                        lista.Add(c);
                    }
                    else
                    {
                        padre.agregarHijo(c);
                    }
                }
            }
            return lista;
        }

        public void ListUserByPermisos(BE_Usuario user)
        {

            DataSet ds = new DataSet();
            var sql = $@"select p.* from UsuarioPermiso up inner join permiso p on up.id_permiso=p.id where id_usuario='" + user.ID + "';";

            ds = Dal_.Leer2(sql);

            user.Permisos.Clear();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    var id_permiso = Convert.ToInt32(item["ID"]);
                    var nombrep = item["Nombre"].ToString();

                    var es_patente = String.Empty;
                    if (Convert.ToInt32(item["es_patente"]) != 0)
                        es_patente = item["Nombre"].ToString();


                    BE_Permiso c1;
                    if (!String.IsNullOrEmpty(es_patente))
                    {
                        c1 = new BE_Patente();
                        c1.ID = id_permiso;
                        c1.Nombre = nombrep;
                        user.Permisos.Add(c1);
                    }
                    else
                    {
                        c1 = new BE_Familia();
                        c1.ID = id_permiso;
                        c1.Nombre = nombrep;

                        var f = GetAll("=" + id_permiso);

                        foreach (var familia in f)
                        {
                            c1.agregarHijo(familia);
                        }
                        user.Permisos.Add(c1);
                    }

                }

            }
        } 
        public bool IsInRole(int id)
        {
            var lista = GetAll(string.Empty);

            var c = GetComponent(id, lista);

            return c != null;
        }


        private BE_Permiso GetComponent(int id, IList<BE_Permiso> lista)
        {

            BE_Permiso component = lista != null ? lista.Where(i => i.ID.Equals(id)).FirstOrDefault() : null;

            if (component == null && lista != null)
            {
                foreach (var c in lista)
                {

                    var l = GetComponent(id, c.ObtenerHijo);
                    if (l != null && l.ID == id) return l;
                    else
                    if (l != null)
                        return GetComponent(id, l.ObtenerHijo);

                }
            }
            return component;
        }
        public bool CrearPatente(BE_Permiso patente)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            string consulta = "S_AltaPatente";
            hs.Add("@Nombre", patente.Nombre);
            hs.Add("@Es_Patente", patente.Es_Patente);
            resultado = dal.Escribir(consulta, hs);
            return resultado;
        }
        public bool EliminarPatente(BE_Permiso patente)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            hs.Add("@ID_Patente", patente.ID);
            resultado = dal.Escribir("S_BajaPatente", hs);
            return resultado;
        }
        public bool InsertarPatenteEnFamilia(BE_Permiso patente, BE_Permiso familia)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            string consulta = "S_AgregarPatenteAFamilia";
            if (familia == null)
            {
                hs.Add("@id_permiso_padre", DBNull.Value);
            }
            else
            {
                hs.Add("@id_permiso_padre", familia.ID);
            }
            hs.Add("@id_permiso_hijo", patente.ID);
            resultado = dal.Escribir(consulta, hs);
            return resultado;
        }

        public List<BE_Permiso> ListarPatentes()
        {
            DAL dal = new DAL();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            List<BE_Permiso> list_patentes = new List<BE_Permiso>();
            BE_Patente patentes = default(BE_Patente);

            ds = dal.Leer("S_ListarPatente", null);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    patentes = new BE_Patente();
                    patentes.ID = Convert.ToInt32(item["ID"]);
                    patentes.Nombre = item["Nombre"].ToString();
                    list_patentes.Add(patentes);
                }
                return list_patentes;
            }
            else
            {
                return null;
            }
        }
        public List<BE_Permiso> ListarFamilias()
        {
            DAL dal = new DAL();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            List<BE_Permiso> list_patentes = new List<BE_Permiso>();
            BE_Familia patentes = default(BE_Familia);

            ds = dal.Leer("S_ListarFamilias", null);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    patentes = new BE_Familia();
                    patentes.ID = Convert.ToInt32(item["ID"]);
                    patentes.Nombre = item["Nombre"].ToString();
                    list_patentes.Add(patentes);
                }
                return list_patentes;
            }
            else
            {
                return null;
            }
        }
    }
}
