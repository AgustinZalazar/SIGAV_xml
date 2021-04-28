using Servicios.Composite;
using SIGAV_MPP_Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_BLL_Seguridad
{
    public class BLL_Permiso
    {
        public bool CrearPatente(Permiso _Patente)
        {
            MPP_Permisos MPP_Patente = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Patente.CrearPatente(_Patente);
            return resultado;
        }

        public bool InsertarPatenteEnFamilia(Permiso _Patente , Permiso _Familia)
        {
            MPP_Permisos MPP_Patente = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Patente.InsertarPatenteEnFamilia(_Patente ,_Familia);
            return resultado;
        }

        public bool EliminarPatente(Permiso _Patente)
        {
            MPP_Permisos MPP_Patente = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Patente.EliminarPatente(_Patente);
            return resultado;
        }

        public List<Permiso> ListarPatente()
        {
            List<Permiso> List_Patente = new List<Permiso>();
            MPP_Permisos MPP_Patentes = new MPP_Permisos();
            return List_Patente = MPP_Patentes.ListarPatentes();
        }
        public List<Permiso> ListarFamilias()
        {
            List<Permiso> List_Familias = new List<Permiso>();
            MPP_Permisos MPP_Patentes = new MPP_Permisos();
            return List_Familias = MPP_Patentes.ListarFamilias();
        }
        public IList<Permiso> ListarArbol()
        {
            string variable = "";
            IList<Permiso> List_;
            MPP_Permiso_List MPP_Permisos = new MPP_Permiso_List();
            return List_ = MPP_Permisos.GetAll(variable);
        }
        public IList<Permiso> ListarArbolByFamilia(string familia)
        {
            IList<Permiso> List_;
            MPP_Permiso_List MPP_Permisos = new MPP_Permiso_List();
            return List_ = MPP_Permisos.GetAll(familia);
        }

        public bool AsignarPermisos(int id_permiso,int id_usuario)
        {
            MPP_AsignarPermisos mPP_AsignarPermisos = new MPP_AsignarPermisos();
            bool resultado = mPP_AsignarPermisos.AsignarPermisos(id_permiso, id_usuario);
            return resultado;
        }
    }
}
