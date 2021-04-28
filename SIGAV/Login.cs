using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SIGAV_BLL;
using EE;
using Servicios;
using Servicios.Bitacora;
using SIGAV_Interfaces;

namespace SIGAV
{
    public partial class Login : Form, IObservador
    {
        public Login()
        {
            InitializeComponent();
        }
        internal delegate void delCerrar(bool ok);
        internal event delCerrar Cerrar;
        EE_Bitacora bitacora = new EE_Bitacora();

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
                EE_Usuario _User = _Login.Logear(Txt_Username.Text, S_Encriptado.Encriptar(Txt_Password.Text));
                if (_User != null)
                {
                    Login login_f = new Login();
                    S_Login.ObtenerSesion.Login(_User);
                    MessageBox.Show("Inicio de sesion correcto");
                    bitacora.Usuario = _User;
                    bitacora.Hora = DateTime.Now.Hour;
                    bitacora.Fecha = DateTime.Now.Date;
                    AgregarBitacora();
                    update();
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
            Cerrar(false);
            this.Close();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void AgregarBitacora()
        {
            S_Bitacora.Añadir(this);
        }

        public void update()
        {
            S_Bitacora.InsertarBitacora(bitacora);
        }
    }
}
