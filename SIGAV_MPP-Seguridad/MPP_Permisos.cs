using Servicios.Composite;
using SIGAV_Acceso;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_MPP_Seguridad
{
    public class MPP_Permisos
    {
        public bool CrearPatente(Permiso patente)
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
        public bool EliminarPatente(Permiso patente)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            hs.Add("@ID_Patente", patente.ID);
            resultado = dal.Escribir("S_BajaPatente", hs);
            return resultado;
        }
        public bool InsertarPatenteEnFamilia(Permiso patente, Permiso familia)
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

        public List<Permiso> ListarPatentes()
        {
            DAL dal = new DAL();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            List<Permiso> list_patentes = new List<Permiso>();
            Patente patentes = default(Patente);

            ds = dal.Leer("S_ListarPatente", null);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    patentes = new Patente();
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
        public List<Permiso> ListarFamilias()
        {
            DAL dal = new DAL();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            List<Permiso> list_patentes = new List<Permiso>();
            Patente patentes = default(Patente);

            ds = dal.Leer("S_ListarFamilias", null);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    patentes = new Patente();
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
