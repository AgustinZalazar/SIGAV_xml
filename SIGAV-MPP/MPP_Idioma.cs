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
    public class MPP_Idioma
    {
        public List<BE_Traduccion> ListarTags(string idioma)
        {
            DAL dal = new DAL();
            DataSet ds = new DataSet();
            Hashtable hs = new Hashtable();
            List<BE_Traduccion> list_Tags = new List<BE_Traduccion>();
            BE_Traduccion eE_Traduccion = default(BE_Traduccion);
            hs.Add("@Idioma", idioma);

            ds = dal.Leer("S_ListarTag", hs);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                   
                    eE_Traduccion = new BE_Traduccion();
                    eE_Traduccion.Tag = item["Tag"].ToString();
                    eE_Traduccion.Descripcion = item["Traduccion"].ToString();
                    list_Tags.Add(eE_Traduccion);
                }
                return list_Tags;
            }
            else
            {
                return null;
            }
        }

        public List<BE_Idioma> ListarIdiomas()
        {
            DAL dal = new DAL();
            DataSet ds = new DataSet();
            Hashtable hs = new Hashtable();
            List<BE_Idioma> list_Idiomas = new List<BE_Idioma>(); ;
            BE_Idioma Idioma  =  default (BE_Idioma);

            ds = dal.Leer("S_ListarIdiomas", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    Idioma = new BE_Idioma();
                    Idioma.ID = Convert.ToInt32(item["ID_Idioma"]);
                    Idioma.Nombre = item["Idioma"].ToString();
                    Idioma.Traducciones = ListarTags(Idioma.Nombre);
                    list_Idiomas.Add(Idioma);
                }
                return list_Idiomas;
            }
            else
            {
                return null;
            }
        }
        public BE_Idioma ListarIdioma(string name)
        {
            DAL dal = new DAL();
            DataSet ds = new DataSet();
            Hashtable hs = new Hashtable();
            BE_Idioma Idioma = default(BE_Idioma);


            hs.Add("@Idioma", name);
            ds = dal.Leer("S_ListarIdioma", hs);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    Idioma = new BE_Idioma();
                    Idioma.ID = Convert.ToInt32(item["ID_Idioma"]);
                    Idioma.Nombre = item["Idioma"].ToString();
                    Idioma.Traducciones = ListarTags(Idioma.Nombre);
                }
                return Idioma;
            }
            else
            {
                return null;
            }
        }
        public bool AgregarIdioma(BE_Idioma eE_Idioma)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            string consulta = "S_AltaIdioma";
            hs.Add("@Idioma", eE_Idioma.Nombre);

            resultado = dal.Escribir(consulta, hs);
            return resultado;
        }
        public bool UpdateIdioma(BE_Traduccion ee_Traduccion)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            string consulta = "S_UpdateTraduccion";
            hs.Add("@Tag", ee_Traduccion.Tag);
            hs.Add("@Traduccion", ee_Traduccion.Descripcion);
            hs.Add("@ID_Idioma", ee_Traduccion.ID_Idioma);

            resultado = dal.Escribir(consulta, hs);
            return resultado;
        }
        public bool InsertIdioma_Traduccion(BE_Traduccion ee_Traduccion)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            string consulta = "S_InsertIdioma_Traduccion";
            hs.Add("@Tag", ee_Traduccion.Tag);
            hs.Add("@Traduccion", ee_Traduccion.Descripcion);
            hs.Add("@ID_Idioma", ee_Traduccion.ID_Idioma);

            resultado = dal.Escribir(consulta, hs);
            return resultado;
        }
        public bool EliminarIdioma(BE_Idioma eE_Idioma)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            hs.Add("@ID_Idioma", eE_Idioma.ID);
            resultado = dal.Escribir("S_BajaIdioma", hs);
            return resultado;
        }
        public bool EliminarTraducciones(BE_Idioma eE_Idioma)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            hs.Add("@ID_Idioma", eE_Idioma.ID);
            resultado = dal.Escribir("S_BajaTraducciones", hs);
            return resultado;
        }
    }
}
