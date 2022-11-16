﻿using EE;
using SIGAV_MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_BLL
{
    public class BLL_Envios
    {
        public bool CrearEnvioXML(BE_Envios e_Envio)
        {
            MPP_Envios mpp_Envios = new MPP_Envios();
            bool resultado = mpp_Envios.CrearEnvioXML(e_Envio);
            return resultado;
        }
        public bool UpdateEnvioXML(BE_Envios e_Envio)
        {
            MPP_Envios mpp_Envios = new MPP_Envios();
            bool resultado = mpp_Envios.Update_EnviosXML(e_Envio);
            return resultado;
        }
        public List<BE_Envios> ListarEnviosXML()
        {
            MPP_Envios mpp_Envios = new MPP_Envios();
            List<BE_Envios> list = new List<BE_Envios>();
            return list = mpp_Envios.ListarEnviosXML();
        }

        #region BLL Base de datos
        //public bool CrearEnvio(BE_Envios e_Envio)
        //{
        //    MPP_Envios mpp_Envios = new MPP_Envios();
        //    bool resultado = mpp_Envios.CrearOActualizarEnvio(e_Envio);
        //    return resultado;
        //}

        //public List<BE_Envios> ListarEnvios(string tipo)
        //{
        //    MPP_Envios mpp_Envios = new MPP_Envios();
        //    List<BE_Envios> list = new List<BE_Envios>();
        //    return list = mpp_Envios.ListarEnvios(tipo);
        //}

        #endregion
    }
}
