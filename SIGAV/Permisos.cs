using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios.Composite;
using SIGAV_BLL;
using SIGAV_BLL_Seguridad;

namespace SIGAV
{
    public partial class Permisos : Form
    {
        public Permisos()
        {
            InitializeComponent();
            LlenarListaDePermisos_Familia();
            LlenarListaDePermisos();
            
        }
        IList<Permiso> lista_permisos;
        BLL_Permiso bLL_Permiso = new BLL_Permiso();
        List<Permiso> list_permisos = new List<Permiso>();
        Familia obj_familia = new Familia();
        Patente obj_patente = new Patente();
        public void LlenarListaDePermisos()
        {
            list_permisos = bLL_Permiso.ListarPatente();
            LBPatentes.DataSource = list_permisos;
            LBPatentes.DisplayMember = "Nombre";
        }

        public void LlenarListaDePermisos_Familia()
        {
            list_permisos = bLL_Permiso.ListarFamilias();
            LBFamilias.DataSource = list_permisos;
            LBFamilias.DisplayMember = "Nombre";
        }


        void AddNode(Permiso permiso, TreeNode node = null)
        {
            TreeNode newNode = new TreeNode(permiso.Nombre);
            newNode.Tag = permiso;

            if (node == null)
                treeview_Permisos.Nodes.Add(newNode);
            else
                node.Nodes.Add(newNode);

        }
        void graficar(IList<Permiso> lista, int? idPadre = null)
        {
            foreach (var l in lista)
            {
                if (idPadre == null)
                    treeview_Permisos.Nodes.Add(l.ID.ToString(), l.Nombre);
                else
                    treeview_Permisos.Nodes.Find(idPadre.ToString(), true).FirstOrDefault().Nodes.Add(l.ID.ToString(), l.Nombre);

                if (l.ObtenerHijo != null && l.ObtenerHijo.Count > 0) graficar(l.ObtenerHijo , l.ID);
            }
        }
        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            Permiso permiso_patente = (Permiso)LBPatentes.SelectedItem;

            Permiso permiso_familia = (Permiso)LBFamilias.SelectedItem;
            bLL_Permiso.InsertarPatenteEnFamilia(permiso_patente, permiso_familia);
            treeview_Permisos.Nodes.Clear();
            lista_permisos = bLL_Permiso.ListarArbol();
            graficar(lista_permisos);
        }

        private void LBFamilias_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj_patente = (Patente)LBFamilias.SelectedItem;
            TxtIDPermisos.Text = Convert.ToString(obj_patente.ID);
            txtNombrePermisos.Text = obj_patente.Nombre;
        }

        private void BtnAgregarPermisos_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Familia")
            {

                obj_familia.Nombre = txtNombrePermisos.Text;
                obj_familia.Es_Patente = false;
                bLL_Permiso.CrearPatente(obj_familia);
                LlenarListaDePermisos_Familia();
            }
            else if (comboBox1.SelectedItem.ToString() == "Patente")
            {
                obj_patente.Nombre = txtNombrePermisos.Text;
                obj_patente.Es_Patente = true;
                //obj_familia.agregarHijo(obj_patente);
                bLL_Permiso.CrearPatente(obj_patente);
                LlenarListaDePermisos();
            }
        }

        private void Permisos_Load(object sender, EventArgs e)
        {
            treeview_Permisos.Nodes.Clear();
            lista_permisos = bLL_Permiso.ListarArbol();
            graficar(lista_permisos);
        }

        private void Btn_AgregarFamilia_Click(object sender, EventArgs e)
        {
            Permiso permiso_patente = null;
            Permiso permiso_familia = (Permiso)LBFamilias.SelectedItem;
            bLL_Permiso.InsertarPatenteEnFamilia(permiso_familia, permiso_patente);
        }

        private void BtnEliminarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                bLL_Permiso.EliminarPatente(obj_patente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void LBPatentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj_patente = (Patente)LBPatentes.SelectedItem;
            TxtIDPermisos.Text = Convert.ToString(obj_patente.ID);
            txtNombrePermisos.Text = obj_patente.Nombre;
        }
    }
}
