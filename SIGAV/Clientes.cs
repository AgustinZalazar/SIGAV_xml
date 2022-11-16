using EE;
using SIGAV_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace SIGAV
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            ActualizarDGV();
        }
        BLL_Cliente bll_cliente = new BLL_Cliente();
        BE_Cliente ee_Cliente = new BE_Cliente();
        S_Login log = S_Login.ObtenerSesion;
        EE_Bitacora bitacora = new EE_Bitacora();
        BLL_Bitacora bll_bitacora = new BLL_Bitacora();

        public void ActualizarDGV()
        {
            DGVCliente.DataSource = null;
            DGVCliente.DataSource = bll_cliente.ListarClientesXML();
            DGVCliente.ForeColor = Color.Black;
            DGVCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void limpiarTxts()
        {
            txtIDCliente.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtDireccion.Text = "";
            txtTelefonoCliente.Text = "";
            txtCelular.Text = "";
            txtEmpresa.Text = "";
        }
        public int obtenerUltimoID()
        {
            List<BE_Cliente> lista = bll_cliente.ListarClientesXML();
            int lastID = 1;
            if (lista.Count > 0)
            {
                lastID = lista.Last().ID + 1;
            }
            return lastID;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ee_Cliente.ID = obtenerUltimoID();
                ee_Cliente.Nombre = txtNombreCliente.Text;
                ee_Cliente.Apellido = txtApellidoCliente.Text;
                ee_Cliente.Direccion = txtDireccion.Text;
                ee_Cliente.Telefono = Convert.ToInt32(txtTelefonoCliente.Text);
                ee_Cliente.Celular = Convert.ToInt32(txtCelular.Text);
                ee_Cliente.Nombre_Empresa = txtEmpresa.Text;
                bll_cliente.CrearClienteXML(ee_Cliente);
                ActualizarDGV();
                limpiarTxts();
            }
            catch (Exception ex)
            {
                bitacora.Fecha = DateTime.Now;
                bitacora.Usuario = log.Usuario.nombre;
                bitacora.Log = ex.ToString();
                bll_bitacora.InsertarBitacora(bitacora);
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
            //ChangeLenguage();
        }

        private void BtnUpdateCliente_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Cliente newCliente = new BE_Cliente();
                newCliente.ID = Convert.ToInt32(txtIDCliente.Text);
                newCliente.Nombre = txtNombreCliente.Text;
                newCliente.Apellido = txtApellidoCliente.Text;
                newCliente.Celular = Convert.ToInt32(txtCelular.Text);
                newCliente.Telefono = Convert.ToInt32(txtTelefonoCliente.Text);
                newCliente.Direccion = txtDireccion.Text;
                newCliente.Nombre_Empresa = txtEmpresa.Text;

                bll_cliente.UpdateClienteXML(newCliente);
                ActualizarDGV();
                limpiarTxts();
            }
            catch (Exception ex)
            {
                bitacora.Fecha = DateTime.Now;
                bitacora.Usuario = log.Usuario.nombre;
                bitacora.Log = ex.ToString();
                bll_bitacora.InsertarBitacora(bitacora);
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteCliente_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Cliente newCliente = new BE_Cliente();
                newCliente.ID = Convert.ToInt32(txtIDCliente.Text);
                newCliente.Nombre = txtNombreCliente.Text;
                newCliente.Apellido = txtApellidoCliente.Text;
                newCliente.Celular = Convert.ToInt32(txtCelular.Text);
                newCliente.Telefono = Convert.ToInt32(txtTelefonoCliente.Text);
                newCliente.Direccion = txtDireccion.Text;
                newCliente.Nombre_Empresa = txtEmpresa.Text;

                bll_cliente.DeleteClienteXML(newCliente);
                ActualizarDGV();
                limpiarTxts();
            }
            catch (Exception ex)
            {
                bitacora.Fecha = DateTime.Now;
                bitacora.Usuario = log.Usuario.nombre;
                bitacora.Log = ex.Message;
                bll_bitacora.InsertarBitacora(bitacora);
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                ee_Cliente = (BE_Cliente)DGVCliente.Rows[e.RowIndex].DataBoundItem;
                txtIDCliente.Text = Convert.ToString(ee_Cliente.ID);
                txtNombreCliente.Text = ee_Cliente.Nombre;
                txtApellidoCliente.Text = ee_Cliente.Apellido;
                txtDireccion.Text = ee_Cliente.Direccion;
                txtTelefonoCliente.Text = Convert.ToString(ee_Cliente.Telefono);
                txtCelular.Text = Convert.ToString(ee_Cliente.Celular);
                txtEmpresa.Text = ee_Cliente.Nombre_Empresa;
            }
            
        }

    }
}
