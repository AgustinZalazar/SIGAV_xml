using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_Acceso
{
    public class DAL_XML
    {
        public bool SaveXMLFile(string xml, string xmlName)
        {
            try
            {

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
