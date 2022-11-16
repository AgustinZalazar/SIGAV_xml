using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using SIGAV_MPP;
using SIGAV_Acceso;
using System.Xml.Linq;
using System.Xml;

namespace SIGAV_MPP
{
    public class MPP_Cliente
    {
        string basePath = AppDomain.CurrentDomain.BaseDirectory + @"xml_files2\";
        

        DAL_XML dal = new DAL_XML();
        public bool CrearClienteXML(BE_Cliente _Cliente)
        {
            bool resultado;
            resultado = dal.SaveXMLFile<BE_Cliente>(_Cliente, "Clientes.xml");
            return resultado;
        }

        public List<BE_Cliente> ListarClientesXML()
        {
            List<BE_Cliente> list = new List<BE_Cliente>();
            list = dal.ReadXml<BE_Cliente>("Clientes.xml");
            return list;
        }
        public bool Update_ClienteXML(BE_Cliente Cliente)
        {
            string path = basePath + "Clientes.xml";
            XDocument doc = XDocument.Load(path);
            var consulta = from cliente in doc.Descendants("BE_Cliente") where Convert.ToInt32(cliente.Attribute("ID").Value) == Cliente.ID select cliente;
            foreach (XElement Node in consulta)
            {
                Node.Element("Nombre").Value = Cliente.Nombre;
                Node.Element("Apellido").Value = Cliente.Apellido;
                Node.Element("Celular").Value = Cliente.Celular.ToString();
                Node.Element("Telefono").Value = Cliente.Telefono.ToString();
                Node.Element("Direccion").Value = Cliente.Direccion;
                Node.Element("Nombre_Empresa").Value = Cliente.Nombre_Empresa;
            }
            doc.Save(path);
            return true;       
        }
        public bool Delete_ClienteXML(BE_Cliente Cliente)
        {
            string path = basePath + "Clientes.xml";
            XDocument doc = XDocument.Load(path);
            var consulta = from cliente in doc.Descendants("BE_Cliente") where Convert.ToInt32(cliente.Attribute("ID").Value) == Cliente.ID select cliente;
            consulta.Remove();
            doc.Save(path);
            return true; 
        }
        public BE_Cliente ListarUn_ClienteXML(BE_Cliente Cliente)
        {
            BE_Cliente e_Cliente = new BE_Cliente();
            List<BE_Cliente> clientes = new List<BE_Cliente>();

            clientes = dal.ReadXml<BE_Cliente>("Clientes.xml");
            e_Cliente = clientes.Find(x => x.ID == Cliente.ID);
            return e_Cliente;
        }

        #region MPP Base de datos
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
        #endregion
    }

}
