using EE;
using Servicios;
using Servicios.Composite;
using SIGAV_BLL;
using SIGAV_BLL_Seguridad;
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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            ActualizarDGvUsers();
            LlenarListaDePermisos_Familia();
        }
        BLL_Usuario BLL_User = new BLL_Usuario();
        EE_Usuario EE_User = new EE_Usuario();

        BLL_Permiso bLL_Permiso = new BLL_Permiso();
        List<Permiso> list_permisos = new List<Permiso>();

        Patente familia = new Patente();
        public void LlenarListaDePermisos_Familia()
        {
            list_permisos = bLL_Permiso.ListarFamilias();
            lbFamilias.DataSource = list_permisos;
            lbFamilias.DisplayMember = "Nombre";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiartTxts()
        {
            EE_User.Username = "";
            EE_User.Password = "";
            TxtUserID.Text = "";
        }
        public void ActualizarDGvUsers()
        {
            DGVUsers.DataSource = null;
            DGVUsers.DataSource = BLL_User.ListarUsers();
        }
        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                EE_User.Username = txtUsername.Text;
                EE_User.Password = S_Encriptado.Encriptar(txtPassword.Text);
                BLL_User.CrearUser(EE_User);
                MessageBox.Show("Usuario agregado con exito.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarDGvUsers();
                LimpiartTxts();
            }
            else
            {
                MessageBox.Show("Por favor llene los campos requeridos para agregar un usuario.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminarUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUserID.Text))
            {
                EE_User.ID = Convert.ToInt32(TxtUserID.Text);
                EE_User.Username = txtUsername.Text;
                MessageBox.Show("Desea eliminar  " + EE_User.Username + "?", "Alerta", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                BLL_User.EliminarUser(EE_User);
                LimpiartTxts();
                ActualizarDGvUsers();
            }
            else
            {
                MessageBox.Show("Error,seleccione un usuario");
            }
        }

        private void DGVUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                EE_User = (EE_Usuario)DGVUsers.Rows[e.RowIndex].DataBoundItem;
                TxtUserID.Text = Convert.ToString(EE_User.ID);
                txtUsername.Text = EE_User.Username;
                txtPassword.Text = EE_User.Password;
            }
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                bLL_Permiso.AsignarPermisos(familia.ID, EE_User.ID);
                MessageBox.Show("Por favor reloguea para aplicar los permisos", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LbFamilias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            familia = (Patente)lbFamilias.SelectedItem; 
        }
    }
}
