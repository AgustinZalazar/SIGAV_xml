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
        public void ActualizarDGV()
        {
            DGVProducto.DataSource = null;
            DGVProducto.DataSource = bll_Producto.ListarProductos();
            DGVProducto.ForeColor = Color.Black;
        }
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ee_producto.Nombre = txtNombreProd.Text;
                ee_producto.Descripcion = txtDescripcion.Text;
                ee_producto.Precio = Convert.ToInt32(txtPrecio.Text);
                ee_producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
                ee_producto.Tipo = txtTipo.Text;
                bll_Producto.CrearProducto(ee_producto);
                ActualizarDGV();
            }
            catch (Exception ex)
            {
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
                ee_producto.Nombre = txtNombreProd.Text;
                ee_producto.Descripcion = txtDescripcion.Text;
                ee_producto.Precio = Convert.ToInt32(txtPrecio.Text);
                ee_producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
                ee_producto.Tipo = txtTipo.Text;
                bll_Producto.CrearProducto(ee_producto);
                ActualizarDGV();
            }
            catch (Exception ex)
            {
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
                bll_Producto.EliminarProducto(ee_producto);
                ActualizarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
