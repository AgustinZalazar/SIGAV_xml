using EE;
using SIGAV_BLL;
using Servicios.Multi_idioma;
using SIGAV_Interfaces;
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
    public partial class Idiomas : Form, IObservador
    {
        public Idiomas()
        {
            InitializeComponent();
            ActualizarDGV();
        }
        Form1 dashboard = new Form1();
        Venta venta = new Venta();
        Compra compra = new Compra();
        Usuarios Usuarios = new Usuarios();
        Clientes clientes = new Clientes();
        Productos productos = new Productos();
        BLL_Idioma bLL_Idioma = new BLL_Idioma();
        BE_Idioma eE_Idioma = new BE_Idioma();
        EE.BE_Traduccion ee_Traduccion = new BE_Traduccion();
        private void BtnAgregarUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdioma.Text))
            {
                eE_Idioma.Nombre = txtIdioma.Text;
                bLL_Idioma.CrearIdioma(eE_Idioma);
                eE_Idioma =  bLL_Idioma.ListarIdioma(eE_Idioma.Nombre);
                ListTags(dashboard , eE_Idioma.ID);
                ListTags(venta, eE_Idioma.ID);
                ListTags(compra, eE_Idioma.ID);
                ListTags(this, eE_Idioma.ID);
                ListTags(Usuarios, eE_Idioma.ID);
                ListTags(clientes, eE_Idioma.ID);
                ListTags(productos, eE_Idioma.ID);
                MessageBox.Show("Idioma agregado con exito.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarDGV();
                LimpiarTxts();
            }
            else
            {
                MessageBox.Show("Por favor llene los campos requeridos para agregar un idioma.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public  void ListTags(Control control , int id_idioma)
        {
            EE.BE_Traduccion ee_Traduccion = new BE_Traduccion();
            ee_Traduccion.ID_Idioma = id_idioma;
            if (control.Tag != null)
            {
                ee_Traduccion.Tag = control.Tag.ToString();
                ee_Traduccion.Descripcion = " ";
                bLL_Idioma.InsertIdioma_Traduccion(ee_Traduccion);
            }
            if (control.HasChildren)
            {
                foreach (Control controlhijo in control.Controls)
                {
                    ListTags(controlhijo, ee_Traduccion.ID_Idioma);
                }
            }
        }
        public void ActualizarDGV()
        {
            DGVIdiomas.DataSource = null;
            DGVIdiomas.DataSource = bLL_Idioma.ListarIdiomas();
        }

        private void BtnEliminarUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtIdiomaID.Text))
            {
                eE_Idioma.ID = Convert.ToInt32(TxtIdiomaID.Text);
                eE_Idioma.Nombre = txtIdioma.Text;
                MessageBox.Show("Desea eliminar  " + eE_Idioma.Nombre + "?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                bLL_Idioma.EliminarIdioma(eE_Idioma);
                bLL_Idioma.EliminarTraducciones(eE_Idioma);
                ActualizarDGV();
                LimpiarTxts();
            }
            else
            {
                MessageBox.Show("Error,seleccione un usuario");
            }
        }

        void LimpiarTxts()
        {
            txtIdioma.Text = " ";
            TxtIdiomaID.Text = " ";
        }
        private void DGVIdiomas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {

                TxtIdiomaID.Text = Convert.ToString(DGVIdiomas.Rows[e.RowIndex].Cells[0].Value);
                txtIdioma.Text = Convert.ToString(DGVIdiomas.Rows[e.RowIndex].Cells[1].Value);
                ee_Traduccion.ID_Idioma = Convert.ToInt32(DGVIdiomas.Rows[e.RowIndex].Cells[0].Value);
                LlenarDGVTraducciones();
            }
        }
        public void LlenarDGVTraducciones()
        {
            DGVTraducciones.DataSource = null;
            DGVTraducciones.DataSource = bLL_Idioma.ListarTags(txtIdioma.Text);
            //DGVTraducciones.Columns[2].Visible = false;
        }
        private void DGVTraducciones_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                
                ee_Traduccion.Tag = Convert.ToString(DGVTraducciones.Rows[e.RowIndex].Cells[0].Value);
                ee_Traduccion.Descripcion = Convert.ToString(DGVTraducciones.Rows[e.RowIndex].Cells[1].Value);
                
                bLL_Idioma.UpdateIdioma(ee_Traduccion);
                LlenarDGVTraducciones();
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

        private void Idiomas_Load(object sender, EventArgs e)
        {
            ChangeLenguage();
        }
    }
}
