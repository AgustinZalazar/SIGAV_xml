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
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }
        //BLL
        BLL_Oferta bll_Oferta = new BLL_Oferta();
        BLL_Bitacora bll_bitacora = new BLL_Bitacora();
        BLL_Permisos _Permisos = new BLL_Permisos();
        //BE
        BE_Oferta eE_Oferta = new BE_Oferta();
        BE_Oferta ee_OfertaAutorizada = new BE_Oferta();
        EE_Bitacora bitacora = new EE_Bitacora();
        S_Login log = S_Login.ObtenerSesion;
        EE.BE_Usuario user;
        
        public void ActualizarDGV()
        {
            DGV_Ofertas.DataSource = null;
            List<BE_Oferta> List = bll_Oferta.ListarOfertasXML();
            List<BE_Oferta> filteredList = List.FindAll(x => x.empresa != user.empresa && x.precio_oferta == 0 && Convert.ToDateTime(x.fechaFinalizacion) > DateTime.Now);
            List<BE_Oferta> orderedList = (from o in filteredList orderby o.usuario_puntaje descending select o).ToList();
            List<OfertaView> ofertaViews = createOfertaView(orderedList);
            DGV_Ofertas.DataSource = ofertaViews;
            DGV_Ofertas.ForeColor = Color.Black;
            DGV_Ofertas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            DGV_Autorizacion.DataSource = null;
            List<BE_Oferta> listOfertas = List.FindAll(x => x.empresa != user.empresa && x.precio_oferta != 0);
            List<OfertaView> ofertaViews1 = createOfertaView(listOfertas);
            DGV_Autorizacion.DataSource = ofertaViews1;
            DGV_Autorizacion.ForeColor = Color.Black;
            DGV_Autorizacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Compra_Load(object sender, EventArgs e)
        {
            user = (EE.BE_Usuario)log.Usuario;
            ActualizarDGV();
            
            this.btnAutorizarProd.Visible = false;
            HideForms();
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
        private void DGV_Ventas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (txtOferta.Text != String.Empty)
            {
                //Cargo la compra
                int id = Convert.ToInt32(DGV_Ofertas.Rows[e.RowIndex].Cells[0].Value);
                eE_Oferta = bll_Oferta.ListarOfertasXML().Find(x => x.id_oferta == id);
                eE_Oferta.direccion_de_envio = user.direccion_empresa;
                eE_Oferta.precio_oferta = Convert.ToInt32(txtOferta.Text);
                eE_Oferta.autorizada_oferta = false;
                eE_Oferta.empresa_compradora = log.Usuario.empresa;
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
                if (eE_Oferta != null)
                {
                    bll_Oferta.ActualizarOfertaXML(eE_Oferta);
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

        private void DGV_Compras_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DGV_Autorizacion.Rows[e.RowIndex].Cells[0].Value);
            ee_OfertaAutorizada = bll_Oferta.ListarOfertasXML().Find(x => x.id_oferta == id);
            ee_OfertaAutorizada.estado = "Oferta realizada";
            ee_OfertaAutorizada.autorizada_oferta = true;
        }

        private void btnAutorizarProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ee_OfertaAutorizada != null)
                {
                    //Actualizo la compra a autorizada
                    bll_Oferta.ActualizarOfertaXML(ee_OfertaAutorizada);                 
                    ActualizarDGV();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un compra");
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
        void HideForms()
        {
            S_Login log = S_Login.ObtenerSesion;
            _Permisos.ListUserByPermisos(user);
            foreach (var item in user.Permisos)
            {

                foreach (var subitem in item.ObtenerHijo)
                {
                    if (item.Nombre == "Gerente de compras" || subitem.Nombre == "Autorizar compra" || item.Nombre == "Autorizar compra" || item.Nombre == "admin general")
                    {
                        this.btnAutorizarProd.Visible = true;
                    }
                    if (subitem.Nombre == "Ver compras")
                    {
                        this.btnAutorizarProd.Visible = false;
                        this.btnRechazarCompra.Visible = false;
                        this.Btn_ComprarProd.Visible = false;
                    }
                }
                if (item.Nombre == "Gerente de compras" || item.Nombre == "Autorizar compra" || item.Nombre == "admin general")
                {
                    this.btnAutorizarProd.Visible = true;
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRechazarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (ee_OfertaAutorizada != null)
                {
                    //Actualizo la compra a rechazada
                    ee_OfertaAutorizada.estado = "iniciada";
                    ee_OfertaAutorizada.autorizada_oferta = false;
                    ee_OfertaAutorizada.precio_oferta = 0;
                    bll_Oferta.ActualizarOfertaXML(ee_OfertaAutorizada);
                    ActualizarDGV();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un compra");
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
    }
}
