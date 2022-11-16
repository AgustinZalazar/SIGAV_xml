using EE;
using Servicios;
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

namespace SIGAV
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            ActualizarDGV();
        }
        BLL_Producto bll_Producto = new BLL_Producto();
        BE_Producto ee_producto = new BE_Producto();
        S_Login log = S_Login.ObtenerSesion;
        EE_Bitacora bitacora = new EE_Bitacora();
        BLL_Bitacora bll_bitacora = new BLL_Bitacora();
        public void ActualizarDGV()
        {
            DGVProducto.DataSource = null;
            DGVProducto.DataSource = bll_Producto.ListarProductosXML(log.Usuario.empresa);
            DGVProducto.ForeColor = Color.Black;
            DGVProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public int obtenerUltimoID()
        {
            List<BE_Producto> lista = bll_Producto.ListarProductosXML(log.Usuario.empresa);
            int lastID = 1;
            if (lista.Count > 0)
            {
                lastID = lista.Last().ID + 1;
            }
            return lastID;
        }
        public void limpiarTxts()
        {
            txtIDProducto.Text = "";
            txtNombreProd.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtTipo.Text = "";
        }
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ee_producto.ID = obtenerUltimoID();
                ee_producto.Nombre = txtNombreProd.Text;
                ee_producto.Descripcion = txtDescripcion.Text;
                ee_producto.Precio = Convert.ToInt32(txtPrecio.Text);
                ee_producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
                ee_producto.Tipo = txtTipo.Text;
                ee_producto.Empresa = log.Usuario.empresa;
                bll_Producto.CrearProductoXML(ee_producto);
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

        private void Productos_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
        }

        private void btnUpdateProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ee_producto.ID = Convert.ToInt32(txtIDProducto.Text);
                ee_producto.Nombre = txtNombreProd.Text;
                ee_producto.Descripcion = txtDescripcion.Text;
                ee_producto.Precio = Convert.ToInt32(txtPrecio.Text);
                ee_producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
                ee_producto.Tipo = txtTipo.Text;
                ee_producto.Empresa = log.Usuario.empresa;
                bll_Producto.ActualizarProductoXML(ee_producto);
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

        private void DGVProducto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                ee_producto = (BE_Producto)DGVProducto.Rows[e.RowIndex].DataBoundItem;
                txtIDProducto.Text = ee_producto.ID.ToString();
                txtNombreProd.Text = ee_producto.Nombre;
                txtDescripcion.Text = ee_producto.Descripcion;
                txtPrecio.Text = ee_producto.Precio.ToString(); ;
                txtCantidad.Text = ee_producto.Cantidad.ToString();
                txtTipo.Text= ee_producto.Tipo;
            }
        }

        private void btnDeleteProducto_Click(object sender, EventArgs e)
        {
            try
            {
                bll_Producto.EliminarProductoXML(ee_producto);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
