using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EE.Composite;
using SIGAV_BLL;

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
        IList<BE_Permiso> lista_permisos;
        BLL_Permisos bLL_Permiso = new BLL_Permisos();
        List<BE_Permiso> list_permisos = new List<BE_Permiso>();
        BE_Familia obj_familia = new BE_Familia();
        BE_Familia selected_familia;
        BE_Patente obj_patente = new BE_Patente();
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


        //void AddNode(Permiso permiso, TreeNode node = null)
        //{
        //    TreeNode newNode = new TreeNode(permiso.Nombre);
        //    newNode.Tag = permiso;

        //    if (node == null)
        //        treeview_Permisos.Nodes.Add(newNode);
        //    else
        //        node.Nodes.Add(newNode);

        //}
        void graficar(IList<BE_Permiso> lista, int? idPadre = null)
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
        void MostrarFamilia(bool init)
        {
            if (selected_familia == null) return;


            IList<BE_Permiso> flia = null;
            if (init)
            {
                //traigo los hijos de la base
                flia = bLL_Permiso.ListarArbolByFamilia("=" + selected_familia.ID);


                foreach (var i in flia)
                    selected_familia.agregarHijo(i);
            }
            else
            {
                flia = selected_familia.ObtenerHijo;
            }

            this.treeview_Permisos.Nodes.Clear();

            TreeNode root = new TreeNode(selected_familia.Nombre);
            root.Tag = selected_familia;
            this.treeview_Permisos.Nodes.Add(root);

            foreach (var item in flia)
            {
                MostrarEnTreeView(root, item);
            }

            treeview_Permisos.ExpandAll();
        }
        void MostrarEnTreeView(TreeNode tn, BE_Permiso c)
        {
            TreeNode n = new TreeNode(c.Nombre);
            tn.Tag = c;
            tn.Nodes.Add(n);
            if (c.ObtenerHijo != null)
                foreach (var item in c.ObtenerHijo)
                {
                    MostrarEnTreeView(n, item);
                }

        }
        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            BE_Permiso permiso_patente = (BE_Permiso)cbPatentes.SelectedItem;
            if (selected_familia != null)
            {
                if (permiso_patente != null)
                {
                    var existe = bLL_Permiso.Existe(selected_familia, permiso_patente.ID);
                    if (existe) MessageBox.Show("Ya existe esta patente en la familia");
                    else
                    {
                        selected_familia.agregarHijo(permiso_patente);
                        bLL_Permiso.InsertarPatenteEnFamilia(permiso_patente, selected_familia);
                        MostrarFamilia(false);
                    }

                }
                else
                {
                    MessageBox.Show("Selecciona una familia de la lista");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una familia");
            }
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
                bLL_Permiso.CrearPatente(obj_patente);
                LlenarListaDePermisos();
            }
        }

        private void Permisos_Load(object sender, EventArgs e)
        {
            treeview_Permisos.Nodes.Clear();
            lista_permisos = bLL_Permiso.ListarArbol();
        }

        private void Btn_AgregarFamilia_Click(object sender, EventArgs e)
        {
            BE_Permiso permiso_familia = (BE_Permiso)cbFamilia.SelectedItem;

            if (selected_familia != null)
            {
                if (permiso_familia != null)
                {
                    var existe = bLL_Permiso.Existe(selected_familia, permiso_familia.ID);
                    if (existe) MessageBox.Show("Ya existe esta Familia.");
                    else
                    {
                        selected_familia.agregarHijo(permiso_familia);
                        bLL_Permiso.InsertarPatenteEnFamilia(permiso_familia, selected_familia);
                        MostrarFamilia(false);
                    }

                }
                else
                {
                    MessageBox.Show("Selecciona una familia de la lista");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una familia");
            }
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

        private void btnConfigurarFamilia_Click(object sender, EventArgs e)
        {
            var tmp = (BE_Familia)this.cbFamilia.SelectedItem;
            selected_familia = new BE_Familia();
            selected_familia.ID = tmp.ID;
            selected_familia.Nombre = tmp.Nombre;
            MostrarFamilia(true);
        }

        private void BtnEliminarPatente_Click(object sender, EventArgs e)
        {

        }
    }
}
