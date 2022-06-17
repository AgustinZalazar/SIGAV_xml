using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIGAV_BLL;
using EE;
using Servicios;
using Servicios.Multi_idioma;
using SIGAV_Interfaces;

namespace SIGAV
{
    public partial class Venta : Form, IObservador
    {
        public Venta()
        {
            InitializeComponent();
        }
        BLL_Producto bll_Producto = new BLL_Producto();
        BLL_Venta bLL_Venta = new BLL_Venta();
        BLL_Envios bll_Envios = new BLL_Envios();
        BE_Venta eE_Venta = new BE_Venta();
        S_Login log = S_Login.ObtenerSesion;
        BE_Idioma eE_Idioma = new BE_Idioma();
        BE_Envios e_Envios = new BE_Envios();
        public void ActualizarDGV()
        {
            DGV_Prod_Venta.DataSource = null;
            DGV_Prod_Venta.DataSource = bLL_Venta.ListarVentas();
            DGV_Prod_Venta.ForeColor = Color.Black;

            DGV_Productos.DataSource = null;
            DGV_Productos.DataSource = bll_Producto.ListarProductos();
            DGV_Productos.ForeColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
            ChangeLenguage();
        }

        private void DGV_Productos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (txtCantidad.Text != String.Empty)
            {
                
                EE.BE_Usuario user = (EE.BE_Usuario)log.Usuario;
                eE_Venta.producto = DGV_Productos.Rows[e.RowIndex].Cells[1].Value.ToString();
                eE_Venta.cantidad = Convert.ToInt32(txtCantidad.Text);
                eE_Venta.empleado = user.nombre;
                eE_Venta.empresa = user.empresa;
                eE_Venta.precio_final = eE_Venta.cantidad * Convert.ToInt32(DGV_Productos.Rows[e.RowIndex].Cells[3].Value);
            }
            else
            {
                MessageBox.Show("Por favor ingrese la cantidad que desea vender antes de seleccionar el producto");
            }
        }

        private void Btn_Venta_Click(object sender, EventArgs e)
        {
            try
            {
                if (eE_Venta != null)
                {
                    bLL_Venta.CrearOActualizarVenta(eE_Venta);
                    e_Envios.producto = eE_Venta.producto;
                    e_Envios.cantidad = eE_Venta.cantidad;
                    e_Envios.Estado_Envio = "Pendiente";
                    e_Envios.Estado_Producto = " ";
                    e_Envios.tipo = "Venta";
                    bll_Envios.CrearEnvio(e_Envios);
                    ActualizarDGV();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un producto");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        void ChangeLenguage()
        {
            eE_Idioma = EE.BE_Idioma.SharedData.SelectedLenguage;
            Traduccion.Añadir(this);
            Traduccion.Idioma(eE_Idioma);
            update();
        }
        public void update()
        {
            Traduccion.Traducir(this);
        }
    }
}
