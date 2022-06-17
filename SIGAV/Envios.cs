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
    public partial class Envios : Form
    {
        public Envios()
        {
            InitializeComponent();
        }

        BLL_Envios bLL_Envios = new BLL_Envios();
        BE_Envios e_Envio_selected = new BE_Envios();
        S_Login log = S_Login.ObtenerSesion;
        EE.BE_Usuario user;
        BLL_Permisos _Permisos = new BLL_Permisos();
        public void ActualizarDGV()
        {
            DGV_Envios_compras.DataSource = null;
            DGV_Envios_compras.DataSource = bLL_Envios.ListarEnvios("Compra");
            DGV_Envios_compras.ForeColor = Color.Black;


            DGV_Envios_Ventas.DataSource = null;
            DGV_Envios_Ventas.DataSource = bLL_Envios.ListarEnvios("Venta");
            DGV_Envios_Ventas.ForeColor = Color.Black;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Envios_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
            cbEstado_Envio.Items.Add("En camino");
            cbEstado_Envio.Items.Add("Recibido");
            cbEstado_Producto.Items.Add("Buen estado");
            cbEstado_Producto.Items.Add("Mal estado");
        }

        private void DGV_Envios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            e_Envio_selected.id_envio = Convert.ToInt32(DGV_Envios_compras.Rows[e.RowIndex].Cells[0].Value);
            e_Envio_selected.producto = DGV_Envios_compras.Rows[e.RowIndex].Cells[1].Value.ToString();
            e_Envio_selected.cantidad = Convert.ToInt32(DGV_Envios_compras.Rows[e.RowIndex].Cells[2].Value);
            e_Envio_selected.Estado_Envio = DGV_Envios_compras.Rows[e.RowIndex].Cells[3].Value.ToString();
            e_Envio_selected.Estado_Producto = DGV_Envios_compras.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (e_Envio_selected.Estado_Envio == "Recibido")
            {
                cbEstado_Producto.Visible = true;
                btnGuardarEstadoProd.Visible = true;
            }
        }

        private void Btn_GuardarEstadoEnvio_Click(object sender, EventArgs e)
        {
            if (e_Envio_selected.Estado_Envio != cbEstado_Envio.Text)
            {
                e_Envio_selected.Estado_Envio = cbEstado_Envio.Text;
                bLL_Envios.CrearEnvio(e_Envio_selected);
                ActualizarDGV();
            }
            else
            {
                MessageBox.Show("El envio ya posee ese estado, por favor seleccione otro");
            }
        }

        private void btnGuardarEstadoProd_Click(object sender, EventArgs e)
        {
            e_Envio_selected.Estado_Producto = cbEstado_Producto.Text;
            bLL_Envios.CrearEnvio(e_Envio_selected);
            ActualizarDGV();
        }

        private void DGV_Envios_Ventas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            e_Envio_selected.id_envio = Convert.ToInt32(DGV_Envios_Ventas.Rows[e.RowIndex].Cells[0].Value);
            e_Envio_selected.producto = DGV_Envios_Ventas.Rows[e.RowIndex].Cells[1].Value.ToString();
            e_Envio_selected.cantidad = Convert.ToInt32(DGV_Envios_Ventas.Rows[e.RowIndex].Cells[2].Value);
            e_Envio_selected.Estado_Envio = DGV_Envios_Ventas.Rows[e.RowIndex].Cells[3].Value.ToString();
            e_Envio_selected.Estado_Producto = DGV_Envios_Ventas.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (e_Envio_selected.Estado_Envio == "Pendiente")
            {
                btnEnviar.Visible = true;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (e_Envio_selected.Estado_Envio != "Enviado")
            {
                e_Envio_selected.Estado_Envio = "Enviado";
                bLL_Envios.CrearEnvio(e_Envio_selected);
                ActualizarDGV();
            }
            else
            {
                MessageBox.Show("El envio ya posee ese estado, por favor seleccione otro");
            }
        }
    }
}
