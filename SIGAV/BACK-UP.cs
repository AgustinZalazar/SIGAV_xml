using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace SIGAV
{
    public partial class BACK_UP : Form
    {
        public BACK_UP()
        {
            InitializeComponent();
        }

        private void Btn_IniciarBackUP_Click(object sender, EventArgs e)
        {
            ProgressBarBackUP.Value = 0;
            try
            {
                if (TxtRutaBD.Text == string.Empty)
                {
                    MessageBox.Show("Por favor ingresa una ruta en la que vas a guardar tu back-up");
                }
                else
                {
                    S_BackUp _BackUp = new S_BackUp();
                    _BackUp.RealizarBackup(TxtRutaBD.Text);
                    ProgressBarBackUP.Value = 100;
                    lblEstadoBackup.Text = "Completado";
                    LblPorcentajeBack.Text = "100%";
                    MessageBox.Show("Back-up realizado correctamente", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ProgressBarBackUP.Value = 0;
            lblEstadoBackup.Text = "";
            LblPorcentajeBack.Text = "0%";
            TxtRutaBD.Text = "";
        }


        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TxtRutaBD.Text = dlg.SelectedPath;
                Btn_IniciarBackUP.Enabled = true;
            }
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "SQL SERVER database backup files |*.bak";
            openFile.Title = "Base de datos Restaurada";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtRutaRestaurarBD.Text = openFile.FileName;
                BtnRestaurar_Backup.Enabled = true;
            }
        }

        private void BtnRestaurar_Backup_Click(object sender, EventArgs e)
        {
            ProgressBarRestaurar.Value = 0;
            try
            {
                if (txtRutaRestaurarBD.Text == string.Empty)
                {
                    MessageBox.Show("Por favor ingresa la ruta de de base de datos");
                }
                else
                {
                    S_BackUp _BackUp = new S_BackUp();
                    _BackUp.RestaurarBackup(txtRutaRestaurarBD.Text);
                    ProgressBarRestaurar.Value = 100;
                    lblEstadoRestaurar.Text = "Completado";
                    LblPorcentajeRestaurar.Text = "100%";
                    MessageBox.Show("Base de datos restaurada correctamente", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ProgressBarRestaurar.Value = 0;
            lblEstadoRestaurar.Text = "";
            LblPorcentajeRestaurar.Text = "0%";
            txtRutaRestaurarBD.Text = "";
        }
    }
}
