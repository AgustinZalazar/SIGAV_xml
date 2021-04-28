using EE;
using SIGAV_MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_BLL
{
    public class BLL_Idioma
    {
        public List<EE.EE_Idioma> ListarIdiomas()
        {
            List<EE.EE_Idioma> list_idiomas = new List<EE.EE_Idioma>();
            SIGAV_MPP.MPP_Idioma mPP_Idioma = new SIGAV_MPP.MPP_Idioma();
            return list_idiomas = mPP_Idioma.ListarIdiomas();
        }

        public List<EE.EE_Traduccion> ListarTags(string idioma)
        {
            List<EE.EE_Traduccion> list_idiomas = new List<EE.EE_Traduccion>();
            SIGAV_MPP.MPP_Idioma mPP_Idioma = new SIGAV_MPP.MPP_Idioma();
            return list_idiomas = mPP_Idioma.ListarTags(idioma);
        }
        public bool CrearIdioma(EE_Idioma eE_Idioma )
        {
            MPP_Idioma mPP_Idioma = new MPP_Idioma();
            bool resultado;
            return resultado = mPP_Idioma.AgregarIdioma(eE_Idioma);
        }
        public bool UpdateIdioma(EE_Traduccion ee_Traduccion)
        {
            MPP_Idioma mPP_Idioma = new MPP_Idioma();
            bool resultado;
            return resultado = mPP_Idioma.UpdateIdioma(ee_Traduccion);
        }
        public bool EliminarIdioma(EE_Idioma eE_Idioma)
        {
            MPP_Idioma mPP_Idioma = new MPP_Idioma();
            bool resultado;
            return resultado = mPP_Idioma.EliminarIdioma(eE_Idioma);
        }
    }
}
