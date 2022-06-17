using Servicios;
using Servicios.Multi_idioma;
using SIGAV_BLL;
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
    public partial class Form1 : Form,IObservador
    {
        public Form1()
        {
            InitializeComponent();
        }

        EE.BE_Idioma eE_Idioma = new EE.BE_Idioma();
        private Form activeForm = null;
        BLL_Permisos _Permisos = new BLL_Permisos();

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
                Panel_Menu.Width = 60;
                HideSubMenus();
            }
            else if(Panel_Menu.Width == 60)
            {
                Panel_Menu.Width = 250;
                HideSubMenus();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //openChildForm(new Dashboard());
            openChildForm(new _404_NotFound());
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
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {             
            EnlazarIdiomas();       
            update();
            ShowLogin();
            HideForms();
        }

        void EnlazarIdiomas()
        {
            BLL_Idioma bLL_Idioma = new BLL_Idioma();
            List<EE.BE_Idioma> list_idiomas = new List<EE.BE_Idioma>();
            CB_Idioma2.DataSource = bLL_Idioma.ListarIdiomas();
            CB_Idioma2.DisplayMember = "Nombre";
            if (CB_Idioma2.Items.Count>0)
            {
                CB_Idioma2.SelectedIndex = 0;
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

        private void BunifuFlatButton8_Click(object sender, EventArgs e)
        {
            S_Login log = S_Login.ObtenerSesion;
            log.Logout();
            ShowLogin();
        }

        private void BunifuFlatButton11_Click(object sender, EventArgs e)
        {
            openChildForm(new Permisos());
        }

        private void BunifuFlatButton9_Click(object sender, EventArgs e)
        {
            if (panel_idioma.Visible == false)
            {
                panel_idioma.Visible = true;
            }
            else
            {
                panel_idioma.Visible = false;
            }
        }


        public void update()
        {
            Traduccion.Traducir(this);
        }

        private void CB_Idioma2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            eE_Idioma = (EE.BE_Idioma)CB_Idioma2.SelectedItem;
            Traduccion.Añadir(this);
            EE.BE_Idioma.SharedData.SelectedLenguage = eE_Idioma;
            Traduccion.Idioma(eE_Idioma);
        }

        private void BunifuFlatButton6_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Idiomas());
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
            foreach (var item in user.Permisos)
            {
                
                foreach (var subitem in item.ObtenerHijo)
                {
                    if (item.Nombre == "Gerente de ventas" || item.Nombre == "Administrar ventas" || item.Nombre == "Administrador de Ventas" || subitem.Nombre == "Administrar ventas")
                    {
                        this.bunifuFlatButton7.Visible = false;
                        this.bunifuFlatButton5.Visible = false;
                        this.bunifuFlatButton2.Visible = false;
                        this.bunifuFlatButton6.Visible = false;
                        this.btnEnvios.Visible = false;
                    }
                    if (item.Nombre == "Gerente de compras" || item.Nombre == "Administrador de Compras")
                    {
                        this.bunifuFlatButton3.Visible = false;
                        this.bunifuFlatButton11.Visible = false;
                        this.bunifuFlatButton5.Visible = false;
                        this.bunifuFlatButton3.Visible = false;
                        this.bunifuFlatButton6.Visible = false;
                        this.btnEnvios.Visible = false;
                    }
                    if (item.Nombre == "Administrador de Envios" || item.Nombre == "Ver envios")
                    {
                        this.bunifuFlatButton2.Visible = false;
                        this.bunifuFlatButton3.Visible = false;
                        this.bunifuFlatButton11.Visible = false;
                        this.bunifuFlatButton5.Visible = false;
                        this.bunifuFlatButton3.Visible = false;
                        this.bunifuFlatButton6.Visible = false;
                        this.bunifuFlatButton4.Visible = false;
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
    }
}
