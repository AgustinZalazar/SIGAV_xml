using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SIGAV_BLL;
using EE;
using Servicios;

namespace SIGAV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        internal delegate void delCerrar(bool ok);
        internal event delCerrar Cerrar;

        #region Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();
            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

            private void Login_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        #endregion

        private void Btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            BLL_Login _Login = new BLL_Login();
            if (Txt_Username.Text != "" && Txt_Password.Text != "")
            {
                BE_Usuario _User = _Login.Logear(Txt_Username.Text, S_Encriptado.Encriptar(Txt_Password.Text));
                if (_User != null)
                {
                    S_Login.Login(_User);
                    MessageBox.Show("Inicio de sesion correcto");
                    Cerrar(true);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto");

                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese los datos");
            }          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            BE_Usuario _User = new BE_Usuario();
            BLL_Login _Login = new BLL_Login();
            _User.ID = 1;
            _User.Username = "admin";
            _User.Password = S_Encriptado.Encriptar("admin");
            _User.nombre = "agustin";
            _User.empresa = "epi";

            bool result = _Login.CrearUserXML(_User);
        }
    }
}
