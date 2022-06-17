using EE;
using SIGAV_MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAV_BLL
{
    public class BLL_Cliente
    {
        public bool CrearCliente(BE_Cliente ee_Cliente)
        {
            MPP_Cliente mpp_Cliente = new MPP_Cliente();
            bool resultado ;
            return resultado = mpp_Cliente.CrearCliente(ee_Cliente);
        }
        public bool UpdateCliente(BE_Cliente ee_Cliente)
        {
            MPP_Cliente mpp_Cliente = new MPP_Cliente();
            bool resultado;
            return resultado = mpp_Cliente.UpdateCliente(ee_Cliente);
        }
        public bool EliminarCliente(BE_Cliente ee_Cliente)
        {
            MPP_Cliente mpp_Cliente = new MPP_Cliente();
            bool resultado;
            return resultado = mpp_Cliente.EliminarUser(ee_Cliente);
        }

        public List<BE_Cliente> ListarClientes()
        {
            List<BE_Cliente> list_clientes = new List<BE_Cliente>();
            MPP_Cliente mpp_Cliente = new MPP_Cliente();
            return list_clientes = mpp_Cliente.ListarClientes();
        }

        public List<BE_Cliente> ListarCliente(string nombre_cliente)
        {
            List<BE_Cliente> list_clientes = new List<BE_Cliente>();
            MPP_Cliente mpp_Cliente = new MPP_Cliente();
            return list_clientes = mpp_Cliente.ListarCliente(nombre_cliente);
        }
    }
}
