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
    public partial class Idiomas : Form
    {
        public Idiomas()
        {
            InitializeComponent();
            ActualizarDGV();
        }
        BLL_Idioma bLL_Idioma = new BLL_Idioma();
        EE_Idioma eE_Idioma = new EE_Idioma();
        EE.EE_Traduccion ee_Traduccion = new EE_Traduccion();
        private void BtnAgregarUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdioma.Text))
            {
                eE_Idioma.Nombre = txtIdioma.Text;
                bLL_Idioma.CrearIdioma(eE_Idioma);
                MessageBox.Show("Idioma agregado con exito.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarDGV();
                //LimpiartTxts();
            }
            else
            {
                MessageBox.Show("Por favor llene los campos requeridos para agregar un idioma.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //LimpiartTxts();
                ActualizarDGV();
            }
            else
            {
                MessageBox.Show("Error,seleccione un usuario");
            }
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
    }
}
