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

namespace SIGAV
{
    public partial class Usuarios : Form
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
        List<BE_Familia> list_permisos_familia = new List<BE_Familia>();
        List<BE_Patente> list_permisos_patente = new List<BE_Patente>();
        EE.BE_Traduccion ee_Traduccion = new BE_Traduccion();
        EE_Bitacora bitacora = new EE_Bitacora();
        BLL_Bitacora bll_bitacora = new BLL_Bitacora();
        S_Login log = S_Login.ObtenerSesion;

        Patente familia = new Patente();
        public void LlenarListaDePermisos()
        {
            list_permisos_patente = bLL_Permiso.ListarPermisos_Patente();
            cbPatentes.DataSource = list_permisos_patente;
            cbPatentes.DisplayMember = "Nombre";
        }

        public void LlenarListaDePermisos_Familia()
        {
            list_permisos_familia = bLL_Permiso.ListarPermisos_Familia();
            cbFamilia.DataSource = list_permisos_familia;
            cbFamilia.DisplayMember = "Nombre";

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiartTxts()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtID.Text = "";
            txtNombre.Text = "";
            txtEmpresa.Text = "";
            txtDireccion.Text = "";
        }
        public void ActualizarDGvUsers()
        {
            DGVUsers.DataSource = null;
            DGVUsers.DataSource = BLL_User.ListarUsers(log.Usuario.empresa);
            DGVUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public int obtenerUltimoID()
        {
            List<BE_Usuario> lista = BLL_User.ListarUsers(log.Usuario.empresa);
            int lastID = 1;
            if (lista.Count > 0)
            {
                lastID = lista.Last().ID + 1;
            }
            return lastID;
        }
        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContraseña.Text))
            {
                BE_Usuario new_user = new BE_Usuario();
                new_user.ID = obtenerUltimoID();
                new_user.Username = txtUsuario.Text;
                new_user.Password = S_Encriptado.Encriptar(txtContraseña.Text);
                new_user.nombre = txtNombre.Text;
                new_user.empresa = txtEmpresa.Text;
                new_user.direccion_empresa = txtDireccion.Text;
                BLL_User.CrearUser(new_user);
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
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Desea eliminar  " + EE_User.Username + "?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    BLL_User.EliminarUser(EE_User);
                    ActualizarDGvUsers();
                    LimpiartTxts();
                }
                else
                {
                    MessageBox.Show("Error,seleccione un usuario");
                }
            }
            catch (Exception ex)
            {
                bitacora.Fecha = DateTime.Now;
                bitacora.Usuario = log.Usuario.nombre;
                bitacora.Log = ex.ToString();
                bll_bitacora.InsertarBitacora(bitacora);
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DGVUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                EE_User = (BE_Usuario)DGVUsers.Rows[e.RowIndex].DataBoundItem;
                txtID.Text = Convert.ToString(EE_User.ID);
                txtUsuario.Text = EE_User.Username;
                txtContraseña.Text = EE_User.Password;
                txtNombre.Text = EE_User.nombre;
                txtEmpresa.Text = EE_User.empresa;
                txtDireccion.Text = EE_User.direccion_empresa;
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

            if (user.Permisos.Count == 0)  bLL_Permiso.ListUserByPermisos(EE_User);
            TreeNode root = new TreeNode(user.Username);

            foreach (var item in user.Permisos)
            {
                LlenarTreeView(root, item);
            }

            this.TV_PermisosUser.Nodes.Add(root);
            this.TV_PermisosUser.ExpandAll();
        }

        private void Btn_AgregarFamiliaUser_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                bitacora.Fecha = DateTime.Now;
                bitacora.Usuario = log.Usuario.nombre;
                bitacora.Log = ex.ToString();
                bll_bitacora.InsertarBitacora(bitacora);
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAgregarPatenteUser_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                bitacora.Fecha = DateTime.Now;
                bitacora.Usuario = log.Usuario.nombre;
                bitacora.Log = ex.ToString();
                bll_bitacora.InsertarBitacora(bitacora);
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiartTxts();
        }

        private void BtnModificarUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (EE_User != null)
                {
                    BE_Usuario updated_user = new BE_Usuario();
                    updated_user.ID = Convert.ToInt32(txtID.Text);
                    updated_user.Username = txtUsuario.Text;
                    if (EE_User.Password == txtContraseña.Text)
                    {
                        updated_user.Password = txtContraseña.Text;
                    }
                    else
                    {
                        updated_user.Password = S_Encriptado.Encriptar(txtContraseña.Text);
                    }
                    updated_user.nombre = txtNombre.Text;
                    updated_user.empresa = txtEmpresa.Text;
                    updated_user.direccion_empresa = txtDireccion.Text;
                    BLL_User.UpdateUser(updated_user);
                    ActualizarDGvUsers();
                    LimpiartTxts();
                }
                else
                {
                    MessageBox.Show("Seleccione un usuario");
                }                 
            }
            catch (Exception ex)
            {
                bitacora.Fecha = DateTime.Now;
                bitacora.Usuario = log.Usuario.nombre;
                bitacora.Log = ex.ToString();
                bll_bitacora.InsertarBitacora(bitacora);
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarFamilia_Click(object sender, EventArgs e)
        {
            try
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

                        if (!esta)
                            MessageBox.Show("El usuario no tiene la familia seleccionada");
                        else
                        {
                            bLL_Permiso.DeleteUsuario_Permiso(EE_User, familia.ID);
                            MostrarPermisos(EE_User);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un usuario");
                }
            }
            catch (Exception ex)
            {
                bitacora.Fecha = DateTime.Now;
                bitacora.Usuario = log.Usuario.nombre;
                bitacora.Log = ex.ToString();
                bll_bitacora.InsertarBitacora(bitacora);
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarPatente_Click(object sender, EventArgs e)
        {
            try
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

                        if (!esta)
                            MessageBox.Show("El usuario no tiene la patente seleccionada");
                        else
                        {
                            bLL_Permiso.DeleteUsuario_Permiso(EE_User, patente.ID);
                            MostrarPermisos(EE_User);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un usuario");
                }
            }
            catch (Exception ex)
            {
                bitacora.Fecha = DateTime.Now;
                bitacora.Usuario = log.Usuario.nombre;
                bitacora.Log = ex.ToString();
                bll_bitacora.InsertarBitacora(bitacora);
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
