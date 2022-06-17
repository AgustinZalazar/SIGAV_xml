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
using Servicios.Multi_idioma;
using SIGAV_Interfaces;

namespace SIGAV
{
    public partial class Compra : Form, IObservador
    {
        public Compra()
        {
            InitializeComponent();
        }
        BLL_Venta bLL_Venta = new BLL_Venta();
        BLL_Compra bLL_Compra = new BLL_Compra();
        BLL_Envios bll_Envios = new BLL_Envios();
        BE_Envios e_Envios = new BE_Envios();
        BE_Compra eE_Compra = new BE_Compra();
        BE_Compra eE_Compra_autorizada = new BE_Compra();
        S_Login log = S_Login.ObtenerSesion;
        EE.BE_Usuario user;
        BE_Idioma eE_Idioma = new BE_Idioma();
        BLL_Permisos _Permisos = new BLL_Permisos();
        public void ActualizarDGV()
        {
            DGV_Ventas.DataSource = null;
            DGV_Ventas.DataSource = bLL_Venta.ListarVentasOtraEmpresa(user.empresa);
            DGV_Ventas.ForeColor = Color.Black;

            DGV_Compras.DataSource = null;
            DGV_Compras.DataSource = bLL_Compra.ListarCompras();
            DGV_Compras.ForeColor = Color.Black;
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            user = (EE.BE_Usuario)log.Usuario;
            ActualizarDGV();
            ChangeLenguage();
            
            this.btnAutorizarProd.Visible = false;
            HideForms();
        }

        private void DGV_Ventas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (txtCantidad.Text != String.Empty)
            {   
                eE_Compra.producto = DGV_Ventas.Rows[e.RowIndex].Cells[1].Value.ToString();
                eE_Compra.cantidad = Convert.ToInt32(txtCantidad.Text);
                eE_Compra.empleado = user.nombre;
                eE_Compra.empresa = user.empresa;
                eE_Compra.precio = eE_Compra.cantidad * Convert.ToInt32(DGV_Ventas.Rows[e.RowIndex].Cells[5].Value);
                eE_Compra.autorizada = false;
            }
            else
            {
                MessageBox.Show("Por favor ingrese la cantidad que desea comprar antes de seleccionar el producto");
            }
        }

        private void Btn_ComprarProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (eE_Compra != null)
                {
                    bLL_Compra.CrearOActualizarCompra(eE_Compra);
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

        private void DGV_Compras_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            eE_Compra_autorizada.id_compra = Convert.ToInt32(DGV_Compras.Rows[e.RowIndex].Cells[0].Value);
            eE_Compra_autorizada.producto = DGV_Compras.Rows[e.RowIndex].Cells[1].Value.ToString();
            eE_Compra_autorizada.cantidad = Convert.ToInt32(DGV_Compras.Rows[e.RowIndex].Cells[2].Value);
            eE_Compra_autorizada.empleado = DGV_Compras.Rows[e.RowIndex].Cells[3].Value.ToString();
            eE_Compra_autorizada.empresa = DGV_Compras.Rows[e.RowIndex].Cells[4].Value.ToString();
            eE_Compra_autorizada.precio = Convert.ToInt32(DGV_Compras.Rows[e.RowIndex].Cells[5].Value);
            eE_Compra_autorizada.autorizada = true;
        }

        private void btnAutorizarProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (eE_Compra_autorizada != null)
                {
                    bLL_Compra.CrearOActualizarCompra(eE_Compra_autorizada);
                    e_Envios.producto = eE_Compra_autorizada.producto;
                    e_Envios.cantidad = eE_Compra_autorizada.cantidad;
                    e_Envios.Estado_Envio = "Pendiente";
                    e_Envios.Estado_Producto = " ";
                    e_Envios.tipo = "Compra";
                    bll_Envios.CrearEnvio(e_Envios);
                    ActualizarDGV();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un compra");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        void HideForms()
        {
            S_Login log = S_Login.ObtenerSesion;
            _Permisos.ListUserByPermisos(user);
            foreach (var item in user.Permisos)
            {

                foreach (var subitem in item.ObtenerHijo)
                {
                    if (item.Nombre == "Gerente de compras" || subitem.Nombre == "Autorizar compra" || item.Nombre == "Autorizar compra")
                    {
                        this.btnAutorizarProd.Visible = true;
                    }
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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
