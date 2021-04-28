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

        EE.EE_Idioma eE_Idioma = new EE.EE_Idioma();
        private Form activeForm = null;
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
        }

        void EnlazarIdiomas()
        {
            BLL_Idioma bLL_Idioma = new BLL_Idioma();
            List<EE.EE_Idioma> list_idiomas = new List<EE.EE_Idioma>();
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
            eE_Idioma = (EE.EE_Idioma)CB_Idioma2.SelectedItem;
            Traduccion.Añadir(this);
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
    }
}
