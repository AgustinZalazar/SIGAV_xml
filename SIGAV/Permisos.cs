using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EE;
using EE.Composite;
using Servicios;
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
        List<BE_Familia> list_permisos_familia = new List<BE_Familia>();
        List<BE_Permiso> list_permisos = new List<BE_Permiso>();
        List<BE_Patente> list_permisos_patente = new List<BE_Patente>();
        BE_Familia obj_familia = new BE_Familia();
        BE_Familia selected_familia;
        BE_Patente obj_patente = new BE_Patente();
        BE_Patente selected_pat;
        BE_Familia selected_fam;
        EE_Bitacora bitacora = new EE_Bitacora();
        BLL_Bitacora bll_bitacora = new BLL_Bitacora();
        S_Login log = S_Login.ObtenerSesion;

        public string obtenerUltimoID_Familia()
        {
            List<BE_Familia> lista = bLL_Permiso.ListarPermisos_Familia();
            string lastID;
            if (lista.Count > 0)
            {
                lastID = "F"+ (lista.Count + 1);
            }
            else
            {
                lastID = "F1";
            }
            return lastID;
        }
        public string obtenerUltimoID_Patente()
        {
            List<BE_Patente> lista = bLL_Permiso.ListarPermisos_Patente();
            string lastID;
            if (lista.Count > 0)
            {
                lastID = "P"+ (lista.Count + 1);
            }
            else
            {
                lastID = "P1";
            }
            return lastID;
        }
        public void LlenarListaDePermisos()
        {
            DGVPatentes.DataSource = bLL_Permiso.ListarPermisos_Patente();
            DGVPatentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            list_permisos_patente = bLL_Permiso.ListarPermisos_Patente();
            cbPatentes.DataSource = list_permisos_patente;
            cbPatentes.DisplayMember = "Nombre";
        }

        public void LlenarListaDePermisos_Familia()
        {
            DGVFamilias.DataSource = bLL_Permiso.ListarPermisos_Familia();
            DGVFamilias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            list_permisos_familia = bLL_Permiso.ListarPermisos_Familia();
            cbFamilia.DataSource = list_permisos_familia;
            cbFamilia.DisplayMember = "Nombre";

        }

        void limpiarDatos()
        {
            txtID.Text = "";
            txtNombrePermisos.Text = " ";
            comboBox1.Enabled = true;
        }
        void MostrarFamilia(bool init)
        {
            if (selected_familia == null) return;


            List<BE_Permiso> hijosFlia = new List<BE_Permiso>();
            if (init)
            {
                //traigo los hijos de la base
                hijosFlia = bLL_Permiso.ListarArbolByFamilia(selected_familia.ID);
                foreach (var item in hijosFlia)
                {
                    selected_familia.agregarHijo(item);
                }
            }
           

            this.treeview_Permisos.Nodes.Clear();

            TreeNode root = new TreeNode(selected_familia.Nombre);
            root.Tag = selected_familia;
            this.treeview_Permisos.Nodes.Add(root);

            foreach (var item in hijosFlia)
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
            //Agregar patente a familia
            BE_Permiso permiso_patente = (BE_Permiso)cbPatentes.SelectedItem;
            if (selected_familia != null)
            {
                if (permiso_patente != null)
                {
                    var existe = bLL_Permiso.Existe(selected_familia, permiso_patente.ID);
                    if (existe) MessageBox.Show("Ya existe esta patente en la familia");
                    else
                    {
                        //selected_familia.agregarHijo(permiso_patente);
                        bLL_Permiso.InsertarPatenteEnFamilia(permiso_patente, selected_familia);
                        MostrarFamilia(false);
                    }

                }
                else
                {
                    MessageBox.Show("Selecciona una Patente de la lista");
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
                obj_familia.ID = obtenerUltimoID_Familia();
                obj_familia.Nombre = txtNombrePermisos.Text;
                bLL_Permiso.CrearPermiso_Familia(obj_familia);
                LlenarListaDePermisos_Familia();
                limpiarDatos();
            }
            else if (comboBox1.SelectedItem.ToString() == "Patente")
            {
                obj_patente.ID = obtenerUltimoID_Patente();
                obj_patente.Nombre = txtNombrePermisos.Text;
                bLL_Permiso.CrearPermiso_Patente(obj_patente);
                LlenarListaDePermisos();
                limpiarDatos();
            }
        }

        private void Permisos_Load(object sender, EventArgs e)
        {
            treeview_Permisos.Nodes.Clear();
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
                if (selected_fam != null)
                {
                    bLL_Permiso.DeleteFamilia_Relacion(selected_fam.ID);
                    bLL_Permiso.DeletePermiso_Familia(selected_fam);
                    LlenarListaDePermisos_Familia();
                    limpiarDatos();

                }
                else if (selected_pat !=null)
                {
                    bLL_Permiso.DeletePatente_Relacion(selected_pat.ID);
                    bLL_Permiso.DeletePermiso_Patente(selected_pat);
                    LlenarListaDePermisos();
                    limpiarDatos();
                }
                
            }
            catch (Exception ex)
            {
                bitacora.Fecha = DateTime.Now;
                bitacora.Usuario = log.Usuario.nombre;
                bitacora.Log = ex.Message;
                bll_bitacora.InsertarBitacora(bitacora);
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
            //Eliminar Patente del arbol 
            if (selected_familia != null)
            {
                var tmp = (BE_Patente)this.cbPatentes.SelectedItem;
                var existe = bLL_Permiso.Existe(selected_familia, tmp.ID);
                if (existe)
                {
                    bLL_Permiso.DeleteFamiliaPatente(selected_familia.ID, tmp.ID);
                    LlenarListaDePermisos_Familia();
                }
                else MessageBox.Show("No existe esta Patente en el arbol.");
            }
            else
            {
                MessageBox.Show("Selecciona una familia de la lista");
            }
        }

        private void BtnModificarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "Familia")
                {
                    BE_Familia update_fam = new BE_Familia();
                    update_fam.ID = txtID.Text;
                    update_fam.Nombre = txtNombrePermisos.Text;
                    bLL_Permiso.UpdatePermiso_Familia(update_fam);  
                    LlenarListaDePermisos_Familia();
                    limpiarDatos();
                }
                else
                {
                    BE_Patente update_pat = new BE_Patente();
                    update_pat.ID = txtID.Text;
                    update_pat.Nombre = txtNombrePermisos.Text;
                    bLL_Permiso.UpdatePermiso_Patente(update_pat);
                    LlenarListaDePermisos();
                    limpiarDatos();
                }
            }
            catch (Exception ex)
            {
                bitacora.Fecha = DateTime.Now;
                bitacora.Usuario = log.Usuario.nombre;
                bitacora.Log = ex.Message;
                bll_bitacora.InsertarBitacora(bitacora);
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVFamilias_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = DGVFamilias.Rows[e.RowIndex].Cells[0].Value.ToString();
            selected_fam = bLL_Permiso.ListarPermisos_Familia().Find(x => x.ID == id);
            txtID.Text = selected_fam.ID;
            txtNombrePermisos.Text = selected_fam.Nombre;
            comboBox1.SelectedIndex = 0;
            comboBox1.Enabled = false;
            selected_pat = null;
        }

        private void DGVPatentes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = DGVPatentes.Rows[e.RowIndex].Cells[0].Value.ToString();
            selected_pat = bLL_Permiso.ListarPermisos_Patente().Find(x => x.ID == id);
            txtID.Text = selected_pat.ID;
            txtNombrePermisos.Text = selected_pat.Nombre;
            comboBox1.SelectedIndex = 1;
            comboBox1.Enabled = false;
            selected_fam = null;
        }

        private void BtnEliminarFamilia_Click(object sender, EventArgs e)
        {
            if (selected_familia != null)
            {
                var tmp = (BE_Familia)this.cbFamilia.SelectedItem;
                var existe = bLL_Permiso.Existe(selected_familia, tmp.ID);
                if (existe)
                {
                    bLL_Permiso.DeleteFamilia_Familia(selected_familia.ID, tmp.ID);
                    LlenarListaDePermisos_Familia();
                }
                else MessageBox.Show("No existe esta Familia en el arbol.");
            }
            else
            {
                MessageBox.Show("Selecciona una familia de la lista");
            }


        }
    }
}
