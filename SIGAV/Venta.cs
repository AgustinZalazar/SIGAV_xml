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

namespace SIGAV
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }
        BLL_Producto bll_Producto = new BLL_Producto();
        BLL_Oferta bll_Oferta = new BLL_Oferta();
        BLL_Venta bLL_Venta = new BLL_Venta();
        BLL_Envios bll_Envios = new BLL_Envios();
        BLL_Bitacora bll_bitacora = new BLL_Bitacora();
        BE_Venta eE_Venta = new BE_Venta();
        BE_Oferta be_Oferta = new BE_Oferta();
        BE_Oferta be_OfertaPendiente = new BE_Oferta();
        BE_Producto bE_Producto = new BE_Producto();
        S_Login log = S_Login.ObtenerSesion;
        BE_Envios e_Envios = new BE_Envios();
        EE_Bitacora bitacora = new EE_Bitacora();
        public void ActualizarDGV()
        {
            DGV_Productos.DataSource = null;
            DGV_Productos.DataSource = bll_Producto.ListarProductosXML(log.Usuario.empresa);
            DGV_Productos.ForeColor = Color.Black;
            DGV_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DGV_Prod_Ofertados.DataSource = null;
            List<BE_Oferta> ListOferts = bll_Oferta.ListarOfertasXML();
            List<BE_Oferta> filteredList = ListOferts.FindAll(x => x.precio_oferta > 0 && x.estado == "Oferta realizada" && x.empresa == log.Usuario.empresa);
            List<OfertaView> ofertaViews = createOfertaView(filteredList);
            DGV_Prod_Ofertados.DataSource = ofertaViews;
            DGV_Prod_Ofertados.ForeColor = Color.Black;
            DGV_Prod_Ofertados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DGV_Venta.DataSource = null;
            DGV_Venta.DataSource = createVentaView(bLL_Venta.ListarVentasXML());
            DGV_Venta.ForeColor = Color.Black;
            DGV_Venta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public List<OfertaView> createOfertaView(List<BE_Oferta> list)
        {
            List<OfertaView> listOfertaView = new List<OfertaView>();
            foreach (var item in list)
            {
                OfertaView ofertaView = new OfertaView();
                ofertaView.id_oferta = item.id_oferta;
                ofertaView.producto = item.producto.Nombre;
                ofertaView.cantidad = item.cantidad;
                ofertaView.precio_inicial = item.precio_inicial;
                ofertaView.precio_oferta = item.precio_oferta;
                ofertaView.empresa = item.empresa;
                ofertaView.usuario_puntaje = item.usuario_puntaje;
                ofertaView.autorizada_oferta = item.autorizada_oferta;
                ofertaView.fechaFinalizacion = item.fechaFinalizacion;
                listOfertaView.Add(ofertaView);
            }
            return listOfertaView;
        }
        public List<VentaView> createVentaView(List<BE_Venta> list)
        {
            List<VentaView> listVentaView = new List<VentaView>();
            foreach (var item in list)
            {
                VentaView ventaView = new VentaView();
                ventaView.id_venta = item.id_venta;
                ventaView.producto = item.oferta.producto.Nombre;
                ventaView.cantidad = item.oferta.cantidad;
                ventaView.precio_inicial = item.oferta.precio_inicial;
                ventaView.precio_oferta = item.oferta.precio_oferta;
                ventaView.empresa = item.oferta.empresa;
                ventaView.usuario_puntaje = item.oferta.usuario_puntaje;
                ventaView.autorizada_oferta = item.oferta.autorizada_oferta;
                ventaView.fechaFinalizacion = item.oferta.fechaFinalizacion;
                ventaView.fecha = item.fecha;
                listVentaView.Add(ventaView);
            }
            return listVentaView;
        }
        public int obtenerUltimoID()
        {
            List<BE_Oferta> lista = bll_Oferta.ListarOfertasXML();
            int lastID = 1;
            if (lista.Count > 0)
            {
                lastID = lista.Last().id_oferta + 1;
            }
            return lastID;
        }
        public int obtenerUltimoIDVentas()
        {
            List<BE_Venta> lista = bLL_Venta.ListarVentasXML();
            int lastID = 1;
            if (lista.Count > 0)
            {
                lastID = lista.Last().id_venta + 1;
            }
            return lastID;
        }
        public int obtenerUltimoIDEnvio()
        {
            List<BE_Envios> lista = bll_Envios.ListarEnviosXML();
            int lastID = 1;
            if (lista.Count > 0)
            {
                lastID = lista.Last().id_envio + 1;
            }
            return lastID;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
        }

        private void DGV_Productos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (txtCantidad.Text != String.Empty)
                {

                    EE.BE_Usuario user = (EE.BE_Usuario)log.Usuario;
                    //Cargo el producto
                    bE_Producto.ID = Convert.ToInt32(DGV_Productos.Rows[e.RowIndex].Cells[0].Value);
                    bE_Producto.Nombre = DGV_Productos.Rows[e.RowIndex].Cells[1].Value.ToString();
                    bE_Producto.Descripcion = DGV_Productos.Rows[e.RowIndex].Cells[2].Value.ToString();
                    bE_Producto.Cantidad = Convert.ToInt32(DGV_Productos.Rows[e.RowIndex].Cells[3].Value) - Convert.ToInt32(txtCantidad.Text);
                    bE_Producto.Precio = Convert.ToInt32(DGV_Productos.Rows[e.RowIndex].Cells[4].Value);
                    bE_Producto.Tipo = DGV_Productos.Rows[e.RowIndex].Cells[5].Value.ToString();
                    bE_Producto.Empresa = DGV_Productos.Rows[e.RowIndex].Cells[6].Value.ToString();
                    //Cargo la oferta
                    be_Oferta.producto = bE_Producto;
                    be_Oferta.estado = "iniciada";
                    be_Oferta.autorizada_oferta = false;
                    be_Oferta.cantidad = Convert.ToInt32(txtCantidad.Text);
                    be_Oferta.precio_inicial = Convert.ToInt32(txtPrecionInicial.Text);
                    be_Oferta.precio_oferta = 0;
                    be_Oferta.usuario_puntaje = user.puntaje;
                    be_Oferta.usuario = user.nombre;
                    be_Oferta.empresa = user.empresa;
                    be_Oferta.fecha_oferta = "00/00/0000";
                    be_Oferta.empresa_compradora = "";
                    be_Oferta.direccion_de_envio = "";
                    be_Oferta.fechaFinalizacion = DTPFechaFinalizacion.Value.Date.ToString("dd-MM-yyyy");

                }
                else
                {
                    MessageBox.Show("Por favor ingrese la cantidad que desea vender antes de seleccionar el producto");
                }
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

        private void Btn_Venta_Click(object sender, EventArgs e)
        {
            try
            {
                if (be_Oferta != null)
                {
                    be_Oferta.id_oferta = obtenerUltimoID();
                    bll_Oferta.CrearOfertaXML(be_Oferta);
                    ActualizarDGV();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un producto");
                }
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
        private void DGV_Prod_Venta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DGV_Prod_Ofertados.Rows[e.RowIndex].Cells[0].Value);
            be_OfertaPendiente = bll_Oferta.ListarOfertasXML().Find(x => x.id_oferta == id);
            be_OfertaPendiente.fecha_oferta = DateTime.Now.ToString("dd/MM/yyyy");
            be_OfertaPendiente.estado = "Oferta aceptada";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bll_Oferta.ActualizarOfertaXML(be_OfertaPendiente);
            //Creo la venta
            eE_Venta.id_venta = obtenerUltimoIDVentas();
            eE_Venta.oferta = be_OfertaPendiente;
            eE_Venta.fecha = DateTime.Now.Date.ToString("dd-MM-yyyy");
            bLL_Venta.CrearVentaXML(eE_Venta);
            //Creo el envio
            e_Envios.id_envio = obtenerUltimoIDEnvio();
            e_Envios.oferta = be_OfertaPendiente;
            e_Envios.Estado_Envio = "Pendiente";
            e_Envios.Estado_Producto = " ";
            bll_Envios.CrearEnvioXML(e_Envios);
            ActualizarDGV();
        }
    }
}
