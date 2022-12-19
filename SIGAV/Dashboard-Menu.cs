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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        BLL_Permisos _Permisos = new BLL_Permisos();
        //S_Login log = S_Login.ObtenerSesion;
        private void openChildForm(Form childForm)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void HideSubMenus()
        {
            if (panel_Submenu_Ajustes.Visible == true)
            {
                panel_Submenu_Ajustes.Visible = false;
            }
        }
        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            if (Panel_Menu.Width == 250)
            {
                Panel_Menu.Width = 70;
                bunifuFlatButton2.Textcolor = Color.FromArgb(34, 36, 49);
                bunifuFlatButton3.Textcolor = Color.FromArgb(34, 36, 49);
                bunifuFlatButton4.Textcolor = Color.FromArgb(34, 36, 49);
                bunifuFlatButton5.Textcolor = Color.FromArgb(34, 36, 49);
                bunifuFlatButton7.Textcolor = Color.FromArgb(34, 36, 49);
                bunifuFlatButton8.Textcolor = Color.FromArgb(34, 36, 49);
                bunifuFlatButton10.Textcolor = Color.FromArgb(34, 36, 49);
                bunifuFlatButton11.Textcolor = Color.FromArgb(34, 36, 49);
                bunifuFlatButton12.Textcolor = Color.FromArgb(34, 36, 49);
                btnLogout.Textcolor = Color.FromArgb(34, 36, 49);
                btnEnvios.Textcolor = Color.FromArgb(34, 36, 49);
                label1.Hide();
                label3.Hide();
                label4.Hide();
                lblUsuario.Hide();
                lblEmpresa.Hide();
                lblRol.Hide();

                HideSubMenus();
            }
            else if(Panel_Menu.Width == 70)
            {
                bunifuFlatButton2.Textcolor = Color.White;
                bunifuFlatButton3.Textcolor = Color.White;
                bunifuFlatButton4.Textcolor = Color.White;
                bunifuFlatButton5.Textcolor = Color.White;
                bunifuFlatButton7.Textcolor = Color.White;
                bunifuFlatButton8.Textcolor = Color.White;
                bunifuFlatButton10.Textcolor = Color.White;
                bunifuFlatButton11.Textcolor = Color.White;
                bunifuFlatButton12.Textcolor = Color.White;
                btnEnvios.Textcolor = Color.White;
                btnLogout.Textcolor = Color.White;
                label1.Show();
                label3.Show();
                label4.Show();
                lblUsuario.Show();
                lblEmpresa.Show();
                lblRol.Show();
                Panel_Menu.Width = 250;
                HideSubMenus();
            }
        }


        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new Clientes());
            //openChildForm(new _404_NotFound());

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            if (panel_Submenu_Ajustes.Visible == false)
            {
                panel_Submenu_Ajustes.Visible = true;
            }
            else
            {
                panel_Submenu_Ajustes.Visible = false;
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            openChildForm(new Usuarios());
            //openChildForm(new _404_NotFound());
        }

        void ShowLogin()
        {
            this.Hide();
            Login frm = new Login();
            frm.Cerrar += Frm_Cerrar;
            frm.ShowDialog();
            if (!Ok)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
                HideForms();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {             
            ShowLogin();
            if (Ok)
            {
                HideForms();
            }
        }

        private bool Ok;
        private void Frm_Cerrar(bool ok)
        {
            Ok = ok;
        }

        private void BunifuFlatButton10_Click(object sender, EventArgs e)
        {
            openChildForm(new Productos());
        }

        private void BunifuFlatButton6_Click(object sender, EventArgs e)
        {
            openChildForm(new _404_NotFound());
        }

        private void BunifuFlatButton11_Click(object sender, EventArgs e)
        {
            openChildForm(new Permisos());
            //openChildForm(new _404_NotFound());
        }

        private void BunifuFlatButton12_Click(object sender, EventArgs e)
        {
            openChildForm(new BACK_UP());
        }

        void HideForms()
        {
            S_Login log = S_Login.ObtenerSesion;
            EE.BE_Usuario user = (EE.BE_Usuario)log.Usuario;
            _Permisos.ListUserByPermisos(user);
            lblUsuario.Text = log.Usuario.Username;
            lblRol.Text = log.Usuario.Permisos[0].Nombre;
            lblEmpresa.Text = log.Usuario.empresa;
            foreach (var item in user.Permisos)
            {
                if (item.Nombre.ToLower() == "gerente de ventas"  || item.Nombre.ToLower() == "administrador de ventas")
                {
                    this.bunifuFlatButton7.Visible = false;
                    this.bunifuFlatButton5.Visible = false;
                    this.bunifuFlatButton2.Visible = false;
                    this.btnEnvios.Visible = false;
                }
                if (item.Nombre.ToLower() == "gerente de compras" || item.Nombre.ToLower() == "administrador de compras")
                {
                    this.bunifuFlatButton3.Visible = false;
                    this.bunifuFlatButton11.Visible = false;
                    this.bunifuFlatButton5.Visible = false;
                    this.bunifuFlatButton3.Visible = false;
                    this.bunifuFlatButton7.Visible = false;
                    this.btnEnvios.Visible = false;
                }
                if (item.Nombre.ToLower() == "administrador de envios")
                {
                    this.bunifuFlatButton2.Visible = false;
                    this.bunifuFlatButton3.Visible = false;
                    this.bunifuFlatButton11.Visible = false;
                    this.bunifuFlatButton5.Visible = false;
                    this.bunifuFlatButton3.Visible = false;
                    this.bunifuFlatButton4.Visible = false;
                    this.bunifuFlatButton7.Visible = false;
                }
                foreach (var subitem in item.ObtenerHijo)
                {
                    if (subitem.Nombre.ToLower() == "administrar ventas")
                    {
                        this.bunifuFlatButton3.Visible = true;
                    }
                    if (subitem.Nombre.ToLower() == "ver compras" || subitem.Nombre == "administrar de compras")
                    {
                        this.bunifuFlatButton2.Visible = true;
                    }
                    if (subitem.Nombre.ToLower() == "ver envios")
                    {
                        this.btnEnvios.Visible = true;
                    }
                }
                
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new Venta());
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new Compra());
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            openChildForm(new Envios());
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            openChildForm(new Reportes());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            S_Login log = S_Login.ObtenerSesion;
            log.Logout();
            ShowLogin();
        }
    }
}
