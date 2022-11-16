using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGAV_MPP;
using EE.Composite;
using EE;


namespace SIGAV_BLL
{
    public class BLL_Permisos
    {
        public List<BE_Familia> ListarPermisos_Familia()
        {
            MPP_Permisos MPP_Patente = new MPP_Permisos();
            List<BE_Familia> list = MPP_Patente.ListarPermisosXML_Familia();
            return list;
        }
        public List<BE_Patente> ListarPermisos_Patente()
        {
            MPP_Permisos MPP_Patente = new MPP_Permisos();
            List<BE_Patente> list = MPP_Patente.ListarPermisosXML_Patente();
            return list;
        }
        public bool CrearPermiso_Familia(BE_Familia _Familia)
        {
            MPP_Permisos MPP_Familia = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Familia.CrearPermiso_Familia(_Familia);
            return resultado;
        }
        public bool CrearPermiso_Patente(BE_Patente _Permiso)
        {
            MPP_Permisos MPP_Patente = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Patente.CrearPermiso_Patente(_Permiso);
            return resultado;
        }

        public bool UpdatePermiso_Familia(BE_Familia _Familia)
        {
            MPP_Permisos MPP_Familia = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Familia.Update_FamiliaXML(_Familia);
            return resultado;
        }
        public bool UpdatePermiso_Patente(BE_Patente _Permiso)
        {
            MPP_Permisos MPP_Patente = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Patente.Update_PatenteXML(_Permiso);
            return resultado;
        }

        public bool DeletePermiso_Familia(BE_Familia _Familia)
        {
            MPP_Permisos MPP_Familia = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Familia.Delete_FamiliaXML(_Familia);
            return resultado;
        }
        public bool DeleteFamilia_Relacion(string id_Familia)
        {
            MPP_Permisos MPP_Familia = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Familia.DeleteFamilia(id_Familia);
            return resultado;
        }
        public bool DeletePermiso_Patente(BE_Patente _Permiso)
        {
            MPP_Permisos MPP_Patente = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Patente.Delete_PatenteXML(_Permiso);
            return resultado;
        }
        public bool DeletePatente_Relacion(string id_Patente)
        {
            MPP_Permisos MPP_Familia = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Familia.DeletePatenteRelacion(id_Patente);
            return resultado;
        }
        public bool DeleteFamiliaPatente(string id_familia,string id_Patente)
        {
            MPP_Permisos MPP_Familia = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Familia.DeleteFamiliaPatente(id_familia ,id_Patente);
            return resultado;
        }
        public bool DeleteFamilia_Familia(string id_familia1, string id_familia2)
        {
            MPP_Permisos MPP_Familia = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Familia.DeleteFamilia_Familia(id_familia1, id_familia2);
            return resultado;
        }
        public bool InsertarPatenteEnFamilia(BE_Permiso _Patente, BE_Permiso _Familia)
        {
            MPP_Permisos MPP_Patente = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Patente.InsertarPatenteEnFamiliaXML(_Patente, _Familia);
            return resultado;
        }

        public bool DeleteUsuario_Permiso(BE_Usuario user, string id_permiso)
        {
            MPP_Permisos MPP_Familia = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Familia.DeletePermisosUser(user, id_permiso);
            return resultado;
        }
        public List<BE_Permiso> ListarArbolByFamilia(string familia)
        {
            MPP_Permisos MPP_Permisos = new MPP_Permisos();
            return MPP_Permisos.GetFamilia_Patente(familia);
        }

        public bool AsignarPermisos(string id_permiso, int id_usuario)
        {
            MPP_Permisos mPP_AsignarPermisos = new MPP_Permisos();  
            bool resultado = mPP_AsignarPermisos.AsignarPermisosXML(id_permiso, id_usuario);
            return resultado;
        }
        public List<BE_Permiso> ListUserByPermisos(BE_Usuario user)
        {
            MPP_Permisos mPP_ListUserByPermisos = new MPP_Permisos();
            return mPP_ListUserByPermisos.ListUserByPermisos(user);
        }
        public bool Existe(BE_Permiso permiso, string id)
        {
            bool existe = false;

            if (permiso.ID.Equals(id))
                existe = true;
            else

                foreach (var item in permiso.ObtenerHijo)
                {
                    existe = Existe(item, id);
                    if (existe) return true;
                }

            return existe;

        }
    }
}
