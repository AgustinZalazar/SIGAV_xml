using EE;
using SIGAV_Acceso;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_MPP
{
    public class MPP_Bitacora
    {
        DAL_XML dal = new DAL_XML();
        public bool CrearLogXML(EE_Bitacora bitacora)
        {
            bool resultado;
            bitacora.ID_Bitacora = obtenerUltimoID();
            resultado = dal.SaveXMLFile<EE_Bitacora>(bitacora, "Bitacora.xml");
            return resultado;
        }
        public List<EE_Bitacora> ListarLogs()
        {
            List<EE_Bitacora> logs = dal.ReadXml<EE_Bitacora>("Bitacora.xml");
            return logs;
        }

        public int obtenerUltimoID()
        {
            List<EE_Bitacora> lista = ListarLogs();
            int lastID = 1;
            if (lista.Count > 0)
            {
                lastID = lista.Last().ID_Bitacora + 1;
            }
            return lastID;
        }
        #region Bitacora BD
        //public bool InsertBitacora(EE_Bitacora bitacora)
        //{
        //    DAL dal = new DAL();
        //    Hashtable hs = new Hashtable();
        //    bool resultado;
        //    string consulta = "S_InsertarEnBitacora";
        //    hs.Add("@Usuario", bitacora.Usuario.Username);
        //    hs.Add("@Hora", bitacora.Hora);
        //    hs.Add("@Dia", bitacora.Fecha);

        //    resultado = dal.Escribir(consulta, hs);
        //    return resultado;
        //}
        #endregion
    }
}
