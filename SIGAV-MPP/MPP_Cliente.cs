using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using SIGAV_Acceso;

namespace SIGAV_MPP
{
    public class MPP_Cliente
    {

        public bool CrearCliente(BE_Cliente _Cliente)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            string consulta = "S_AltaCliente";
            hs.Add("@Nombre", _Cliente.Nombre);
            hs.Add("@Apellido", _Cliente.Apellido);
            hs.Add("@Telefono", _Cliente.Telefono);
            hs.Add("@Direccion", _Cliente.Direccion);
            hs.Add("@Fecha_Nac", _Cliente.Fecha_Nac);
            hs.Add("@Celular", _Cliente.Celular);
            hs.Add("@Nombre_Empresa", _Cliente.Nombre_Empresa);

            resultado = dal.Escribir(consulta, hs);
            return resultado;
        }

        public bool UpdateCliente(BE_Cliente _Cliente)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            string consulta = "S_UpdateCliente";
            hs.Add("@Nombre", _Cliente.Nombre);
            hs.Add("@Apellido", _Cliente.Apellido);
            hs.Add("@Telefono", _Cliente.Telefono);
            hs.Add("@Direccion", _Cliente.Direccion);
            hs.Add("@Fecha_Nac", _Cliente.Fecha_Nac);
            hs.Add("@Celular", _Cliente.Celular);
            hs.Add("@Nombre_Empresa", _Cliente.Nombre_Empresa);

            resultado = dal.Escribir(consulta, hs);
            return resultado;
        }
        public bool EliminarUser(BE_Cliente _Cliente)
        {
            DAL dal = new DAL();
            Hashtable hs = new Hashtable();
            bool resultado;

            hs.Add("@ID", _Cliente.ID);
            resultado = dal.Escribir("S_BajaCliente", hs);
            return resultado;
        }
        public List<BE_Cliente> ListarClientes()
        {
            DAL dal = new DAL();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            List<BE_Cliente> list_clientes = new List<BE_Cliente>();
            BE_Cliente cliente = default(BE_Cliente);

            ds = dal.Leer("S_ListarClientes", null);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    cliente = new BE_Cliente();
                    cliente.ID = Convert.ToInt32(item["ID_Cliente"]);
                    cliente.Nombre = item["Nombre"].ToString();
                    cliente.Apellido = item["Apellido"].ToString();
                    cliente.Telefono =Convert.ToInt32(item["Telefono"]);
                    cliente.Direccion = item["Direccion"].ToString();
                    cliente.Fecha_Nac = Convert.ToDateTime(item["Fecha_Nac"]);
                    cliente.Celular = Convert.ToInt32(item["Celular"]);
                    cliente.Nombre_Empresa = item["Nombre_Empresa"].ToString();
                    list_clientes.Add(cliente);
                }
                return list_clientes;
            }
            else
            {
                return null;
            }
        }

        public List<BE_Cliente> ListarCliente(string nombre_cliente)
        {
            DAL dal = new DAL();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            List<BE_Cliente> list_clientes = new List<BE_Cliente>();
            BE_Cliente cliente = default(BE_Cliente);
            Hashtable hs = new Hashtable();
            hs.Add("@Nombre", nombre_cliente);

            ds = dal.Leer("S_ListarUnCliente", hs);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    cliente = new BE_Cliente();
                    cliente.ID = Convert.ToInt32(item["ID_Cliente"]);
                    cliente.Nombre = item["Nombre"].ToString();
                    cliente.Apellido = item["Apellido"].ToString();
                    cliente.Telefono = Convert.ToInt32(item["Telefono"]);
                    cliente.Direccion = item["Direccion"].ToString();
                    cliente.Fecha_Nac = Convert.ToDateTime(item["Fecha_Nac"]);
                    cliente.Celular = Convert.ToInt32(item["Celular"]);
                    cliente.Nombre_Empresa = item["Nombre_Empresa"].ToString();
                    list_clientes.Add(cliente);
                }
                return list_clientes;
            }
            else
            {
                return null;
            }
        }
    }

}
