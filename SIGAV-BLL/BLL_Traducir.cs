using SIGAV_MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_BLL
{
    public class BLL_Traducir
    {
        public List<string> Traducir(string idioma)
        {
            List<string> list_tags = new List<string>();
            MPP_Idioma mPP_Idioma = new MPP_Idioma();
            list_tags = mPP_Idioma.ListarTags(idioma)?.Select(a =>a.Tag).ToList() ;
            return list_tags;
        }
    }
}
