using SIGAV_Acceso;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_MPP_Seguridad
{
    public class MPP_AsignarPermisos
    {
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
    }
}
