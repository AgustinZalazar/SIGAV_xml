using EE;
using EE.Composite;
using Servicios;
using Servicios.Composite;
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
    public partial class Usuarios : Form, IObservador
    {
        public Usuarios()
        {
            InitializeComponent();
            ActualizarDGvUsers();
            LlenarListaDePermisos_Familia();
            LlenarListaDePermisos();
        }
        BLL_Usuario BLL_User = new BLL_Usuario();
        BE_Usuario EE_User = new BE_Usuario();
        BLL_Permisos bLL_Permiso = new BLL_Permisos();
        List<BE_Permiso> list_permisos = new List<BE_Permiso>();
        BE_Idioma eE_Idioma = new BE_Idioma();
        EE.BE_Traduccion ee_Traduccion = new BE_Traduccion();

        Patente familia = new Patente();
        public void LlenarListaDePermisos()
        {
            list_permisos = bLL_Permiso.ListarPatente();
            cbPatentes.DataSource = list_permisos;
            cbPatentes.DisplayMember = "Nombre";
        }

        public void LlenarListaDePermisos_Familia()
        {
            list_permisos = bLL_Permiso.ListarFamilias();
            cbFamilia.DataSource = list_permisos;
            cbFamilia.DisplayMember = "Nombre";

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiartTxts()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            TxtUserID.Text = "";
            txtNombre.Text = "";
            txtEmpresa.Text = "";
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
                EE_User.nombre = txtNombre.Text;
                EE_User.empresa = txtEmpresa.Text;
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
                ActualizarDGvUsers();
                LimpiartTxts();
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
                EE_User = (BE_Usuario)DGVUsers.Rows[e.RowIndex].DataBoundItem;
                TxtUserID.Text = Convert.ToString(EE_User.ID);
                txtUsername.Text = EE_User.Username;
                txtPassword.Text = EE_User.Password;
                txtNombre.Text = EE_User.nombre;
                txtEmpresa.Text = EE_User.empresa;
                bLL_Permiso.ListUserByPermisos(EE_User);
                MostrarPermisos(EE_User);
            }
        }
        void LlenarTreeView(TreeNode padre, BE_Permiso c)
        {
            TreeNode hijo = new TreeNode(c.Nombre);
            hijo.Tag = c;
            padre.Nodes.Add(hijo);

            foreach (var item in c.ObtenerHijo)
            {
                LlenarTreeView(hijo, item);
            }

        }
        void MostrarPermisos(BE_Usuario user)
        {
            this.TV_PermisosUser.Nodes.Clear();
            TreeNode root = new TreeNode(user.Username);

            foreach (var item in user.Permisos)
            {
                LlenarTreeView(root, item);
            }

            this.TV_PermisosUser.Nodes.Add(root);
            this.TV_PermisosUser.ExpandAll();
        }
        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_AgregarFamiliaUser_Click(object sender, EventArgs e)
        {
            if (EE_User != null)
            {
                var familia = (BE_Familia)cbFamilia.SelectedItem;
                if (familia != null)
                {
                    var esta = false;
                    foreach (var item in EE_User.Permisos)
                    {
                        if (bLL_Permiso.Existe(item, familia.ID))
                        {
                            esta = true;
                        }
                    }

                    if (esta)
                        MessageBox.Show("El usuario ya tiene la familia seleccionada");
                    else
                    {                   
                        bLL_Permiso.AsignarPermisos(familia.ID, EE_User.ID);
                        EE_User.Permisos.Add(familia);
                        MostrarPermisos(EE_User);                    
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario");
            }
     
        }

        private void btnAgregarPatenteUser_Click(object sender, EventArgs e)
        {
            if (EE_User != null)
            {
                var patente = (BE_Patente)cbPatentes.SelectedItem;
                if (patente != null)
                {
                    var esta = false;
                    foreach (var item in EE_User.Permisos)
                    {
                        if (bLL_Permiso.Existe(item, patente.ID))
                        {
                            esta = true;
                        }
                    }

                    if (esta)
                        MessageBox.Show("El usuario ya tiene la patente seleccionada");
                    else
                    {
                        bLL_Permiso.AsignarPermisos(patente.ID, EE_User.ID);
                        EE_User.Permisos.Add(patente);
                        MostrarPermisos(EE_User);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario");
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

        private void Usuarios_Load(object sender, EventArgs e)
        {
            ChangeLenguage();
        }
    }
}
