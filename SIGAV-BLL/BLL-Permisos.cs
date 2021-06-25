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
        public bool CrearPatente(BE_Permiso _Patente)
        {
            MPP_Permisos MPP_Patente = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Patente.CrearPatente(_Patente);
            return resultado;
        }

        public bool InsertarPatenteEnFamilia(BE_Permiso _Patente, BE_Permiso _Familia)
        {
            MPP_Permisos MPP_Patente = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Patente.InsertarPatenteEnFamilia(_Patente, _Familia);
            return resultado;
        }

        public bool EliminarPatente(BE_Permiso _Patente)
        {
            MPP_Permisos MPP_Patente = new MPP_Permisos();
            bool resultado;
            resultado = MPP_Patente.EliminarPatente(_Patente);
            return resultado;
        }

        public List<BE_Permiso> ListarPatente()
        {
            List<BE_Permiso> List_Patente = new List<BE_Permiso>();
            MPP_Permisos MPP_Patentes = new MPP_Permisos();
            return List_Patente = MPP_Patentes.ListarPatentes();
        }
        public List<BE_Permiso> ListarFamilias()
        {
            List<BE_Permiso> List_Familias = new List<BE_Permiso>();
            MPP_Permisos MPP_Patentes = new MPP_Permisos();
            return List_Familias = MPP_Patentes.ListarFamilias();
        }
        public IList<BE_Permiso> ListarArbol()
        {
            string variable = "";
            IList<BE_Permiso> List_;
            MPP_Permisos MPP_Permisos = new MPP_Permisos();
            return List_ = MPP_Permisos.GetAll(variable);
        }
        public IList<BE_Permiso> ListarArbolByFamilia(string familia)
        {
            IList<BE_Permiso> List_;
            MPP_Permisos MPP_Permisos = new MPP_Permisos();
            return List_ = MPP_Permisos.GetAll(familia);
        }

        public bool AsignarPermisos(int id_permiso, int id_usuario)
        {
            MPP_Permisos mPP_AsignarPermisos = new MPP_Permisos();  
            bool resultado = mPP_AsignarPermisos.AsignarPermisos(id_permiso, id_usuario);
            return resultado;
        }
        public void ListUserByPermisos(EE_Usuario user)
        {
            MPP_Permisos mPP_ListUserByPermisos = new MPP_Permisos();
            mPP_ListUserByPermisos.ListUserByPermisos(user);
        }
        public bool Existe(BE_Permiso permiso, int id)
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
