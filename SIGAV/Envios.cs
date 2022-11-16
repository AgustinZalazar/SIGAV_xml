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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

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
        EE_Bitacora bitacora = new EE_Bitacora();
        BLL_Bitacora bll_bitacora = new BLL_Bitacora();
        //BLL_Permisos _Permisos = new BLL_Permisos();
        public void ActualizarDGV()
        {
            DGV_Envios_compras.DataSource = null;
            List<BE_Envios> list_envios_ofertas = bLL_Envios.ListarEnviosXML();
            List<BE_Envios> filteredList = list_envios_ofertas.FindAll(x => x.oferta.empresa_compradora == log.Usuario.empresa);
            DGV_Envios_compras.DataSource = createEnvioView(filteredList);
            DGV_Envios_compras.ForeColor = Color.Black;
            DGV_Envios_compras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            DGV_Envios_Ventas.DataSource = null;
            List<BE_Envios> list_envios_ventas = bLL_Envios.ListarEnviosXML();
            List<BE_Envios> list_envios_ventas_filtered = list_envios_ventas.FindAll(x => x.oferta.empresa == log.Usuario.empresa);
            DGV_Envios_Ventas.DataSource = createEnvioView(list_envios_ventas_filtered);
            DGV_Envios_Ventas.ForeColor = Color.Black;
            DGV_Envios_Ventas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public List<EnvioView> createEnvioView(List<BE_Envios> list)
        {
            List<EnvioView> listEnvioView = new List<EnvioView>();
            foreach (var item in list)
            {
                EnvioView envioView = new EnvioView();
                envioView.id_envio = item.id_envio;
                envioView.producto = item.oferta.producto.Nombre;
                envioView.cantidad = item.oferta.cantidad;
                envioView.precio_inicial = item.oferta.precio_inicial;
                envioView.precio_oferta = item.oferta.precio_oferta;
                envioView.empresa = item.oferta.empresa;
                envioView.usuario_puntaje = item.oferta.usuario_puntaje;
                envioView.autorizada_oferta = item.oferta.autorizada_oferta;
                envioView.fechaFinalizacion = item.oferta.fechaFinalizacion;
                envioView.Estado_Envio = item.Estado_Envio;
                envioView.Estado_Producto = item.Estado_Producto;
                listEnvioView.Add(envioView);
            }
            return listEnvioView;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Envios_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
            cbPuntaje.Items.Add("1");
            cbPuntaje.Items.Add("2");
            cbPuntaje.Items.Add("3");
            cbPuntaje.Items.Add("4");
            cbPuntaje.Items.Add("5");
            cbEstado_Producto.Items.Add("Buen estado");
            cbEstado_Producto.Items.Add("Mal estado");
        }

        private void DGV_Envios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DGV_Envios_compras.Rows[e.RowIndex].Cells[0].Value);
            e_Envio_selected = bLL_Envios.ListarEnviosXML().Find(x => x.id_envio == id);
            if (e_Envio_selected.Estado_Envio == "Recibido")
            {
                cbEstado_Producto.Visible = true;
                btnGuardarEstadoProd.Visible = true;
            }
        }

        private void Btn_GuardarEstadoEnvio_Click(object sender, EventArgs e)
        {
            try
            {
                if (e_Envio_selected.Estado_Envio != "Recibido")
                {
                    e_Envio_selected.Estado_Envio = "Recibido";
                    bLL_Envios.UpdateEnvioXML(e_Envio_selected);
                    ActualizarDGV();
                }
                else
                {
                    MessageBox.Show("El envio ya posee ese estado, por favor seleccione otro");
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

        private void btnGuardarEstadoProd_Click(object sender, EventArgs e)
        {
            try
            {
                e_Envio_selected.Estado_Producto = cbEstado_Producto.Text;
                bLL_Envios.UpdateEnvioXML(e_Envio_selected);
                ActualizarDGV();
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

        private void DGV_Envios_Ventas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DGV_Envios_Ventas.Rows[e.RowIndex].Cells[0].Value);
            e_Envio_selected = bLL_Envios.ListarEnviosXML().Find(x => x.id_envio == id);
            e_Envio_selected.Estado_Producto = "";

            if (e_Envio_selected.Estado_Envio == "Pendiente")
            {
                btnEnviar.Visible = true;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (e_Envio_selected.Estado_Envio != "Enviado" && e_Envio_selected.Estado_Envio != "Recibido")
                {
                    e_Envio_selected.Estado_Envio = "Enviado";
                    bLL_Envios.UpdateEnvioXML(e_Envio_selected);
                    ActualizarDGV();
                }
                else
                {
                    MessageBox.Show("El envio ya fue enviado, por favor seleccione otro");
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Oferta oferta_temp = e_Envio_selected.oferta;
                BLL_Usuario bLL_User = new BLL_Usuario();
                List<BE_Usuario> list_usuarios = bLL_User.ListarAllUsers(log.Usuario.empresa);
                BE_Usuario user = list_usuarios.Find(x => x.nombre == oferta_temp.usuario);
                user.puntaje = Convert.ToInt32(cbPuntaje.Text);
                bLL_User.UpdateUser(user);
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                if (e_Envio_selected.Estado_Envio == "Enviado" || e_Envio_selected.Estado_Envio == "Recibido")
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.FileName = e_Envio_selected.id_envio.ToString()+ "_" + DateTime.Now.Date.ToString("ddMMyyyy") + ".pdf";

                    string html = Properties.Resources.template.ToString();
                    html = html.Replace("@FECHA", DateTime.Now.Date.ToString("dd/MM/yyyy"));
                    html = html.Replace("@ID_ENVIO", e_Envio_selected.id_envio.ToString());
                    html = html.Replace("@EMPRESA", e_Envio_selected.oferta.empresa_compradora);
                    html = html.Replace("@DIRECCION", e_Envio_selected.oferta.direccion_de_envio);
                    html = html.Replace("@CANTIDAD", e_Envio_selected.oferta.cantidad.ToString());
                    html = html.Replace("@PRODUCTO", e_Envio_selected.oferta.producto.Nombre);
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(saveFile.FileName , FileMode.Create)) { 
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                            PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, stream);
                           
                            pdfDoc.Open();
                            pdfDoc.Add(new Phrase(""));
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Logo_SIGAV, System.Drawing.Imaging.ImageFormat.Png);

                            img.ScaleToFit(80, 80);
                            img.Alignment = iTextSharp.text.Image.UNDERLYING;
                            img.SetAbsolutePosition(245, pdfDoc.Top - 60);

                            pdfDoc.Add(img);
                            using (StringReader sr = new StringReader(html))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(pdfWriter, pdfDoc, sr);
                            }

                            pdfDoc.Close();
                            stream.Close();
                        }


                    }
                    
                }
                else
                {
                    MessageBox.Show("El envio ya fue enviado, por favor seleccione otro");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
