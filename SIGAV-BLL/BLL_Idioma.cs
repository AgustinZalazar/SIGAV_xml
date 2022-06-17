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
        public List<EE.BE_Idioma> ListarIdiomas()
        {
            List<EE.BE_Idioma> list_idiomas = new List<EE.BE_Idioma>();
            SIGAV_MPP.MPP_Idioma mPP_Idioma = new SIGAV_MPP.MPP_Idioma();
            return list_idiomas = mPP_Idioma.ListarIdiomas();
        }

        public List<EE.BE_Traduccion> ListarTags(string idioma)
        {
            List<EE.BE_Traduccion> list_idiomas = new List<EE.BE_Traduccion>();
            SIGAV_MPP.MPP_Idioma mPP_Idioma = new SIGAV_MPP.MPP_Idioma();
            return list_idiomas = mPP_Idioma.ListarTags(idioma);
        }
        public bool CrearIdioma(BE_Idioma eE_Idioma )
        {
            MPP_Idioma mPP_Idioma = new MPP_Idioma();
            bool resultado;
            return resultado = mPP_Idioma.AgregarIdioma(eE_Idioma);
        }
        public EE.BE_Idioma ListarIdioma(string idioma)
        {
            MPP_Idioma mPP_Idioma = new MPP_Idioma();
            return  mPP_Idioma.ListarIdioma(idioma);
        }
        public bool UpdateIdioma(BE_Traduccion ee_Traduccion)
        {
            MPP_Idioma mPP_Idioma = new MPP_Idioma();
            bool resultado;
            return resultado = mPP_Idioma.UpdateIdioma(ee_Traduccion);
        }
        public bool InsertIdioma_Traduccion(BE_Traduccion ee_Traduccion)
        {
            MPP_Idioma mPP_Idioma = new MPP_Idioma();
            bool resultado;
            return resultado = mPP_Idioma.InsertIdioma_Traduccion(ee_Traduccion);
        }
        public bool EliminarIdioma(BE_Idioma eE_Idioma)
        {
            MPP_Idioma mPP_Idioma = new MPP_Idioma();
            bool resultado;
            return resultado = mPP_Idioma.EliminarIdioma(eE_Idioma);
        }

        public bool EliminarTraducciones(BE_Idioma eE_Idioma)
        {
            MPP_Idioma mPP_Idioma = new MPP_Idioma();
            bool resultado;
            return resultado = mPP_Idioma.EliminarTraducciones(eE_Idioma);
        }
    }
}
