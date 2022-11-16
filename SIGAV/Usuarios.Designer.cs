namespace SIGAV
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVUsers = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnModificarUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnEliminarUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAgregarUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.cbFamilia = new System.Windows.Forms.ComboBox();
            this.cbPatentes = new System.Windows.Forms.ComboBox();
            this.Btn_AgregarFamiliaUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAgregarPatenteUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TV_PermisosUser = new System.Windows.Forms.TreeView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtContraseña = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.txtEmpresa = new MetroFramework.Controls.MetroTextBox();
            this.btnLimpiar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEliminarFamilia = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEliminarPatente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtDireccion = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnModificarUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminarUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1224, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(25, 39);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1195, 19);
            this.bunifuSeparator1.TabIndex = 16;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 15;
            this.label1.Tag = "Usuarios";
            this.label1.Text = "Usuarios";
            // 
            // DGVUsers
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGVUsers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGVUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsers.DoubleBuffered = true;
            this.DGVUsers.EnableHeadersVisualStyles = false;
            this.DGVUsers.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DGVUsers.HeaderForeColor = System.Drawing.Color.White;
            this.DGVUsers.Location = new System.Drawing.Point(25, 244);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVUsers.Size = new System.Drawing.Size(501, 415);
            this.DGVUsers.TabIndex = 18;
            this.DGVUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVUsers_CellMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 32;
            this.label5.Tag = "Contraseña:";
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 31;
            this.label4.Tag = "Usuario:";
            this.label4.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 20);
            this.label3.TabIndex = 27;
            this.label3.Tag = "Agregar, eliminar y editar usuarios:";
            this.label3.Text = "Agregar, eliminar y editar usuarios:";
            // 
            // BtnModificarUser
            // 
            this.BtnModificarUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarUser.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificarUser.Image")));
            this.BtnModificarUser.ImageActive = null;
            this.BtnModificarUser.Location = new System.Drawing.Point(625, 140);
            this.BtnModificarUser.Name = "BtnModificarUser";
            this.BtnModificarUser.Size = new System.Drawing.Size(24, 24);
            this.BtnModificarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnModificarUser.TabIndex = 36;
            this.BtnModificarUser.TabStop = false;
            this.BtnModificarUser.Zoom = 10;
            this.BtnModificarUser.Click += new System.EventHandler(this.BtnModificarUser_Click);
            // 
            // BtnEliminarUser
            // 
            this.BtnEliminarUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarUser.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarUser.Image")));
            this.BtnEliminarUser.ImageActive = null;
            this.BtnEliminarUser.Location = new System.Drawing.Point(664, 140);
            this.BtnEliminarUser.Name = "BtnEliminarUser";
            this.BtnEliminarUser.Size = new System.Drawing.Size(24, 24);
            this.BtnEliminarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnEliminarUser.TabIndex = 35;
            this.BtnEliminarUser.TabStop = false;
            this.BtnEliminarUser.Zoom = 10;
            this.BtnEliminarUser.Click += new System.EventHandler(this.BtnEliminarUser_Click);
            // 
            // btnAgregarUser
            // 
            this.btnAgregarUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarUser.Image")));
            this.btnAgregarUser.ImageActive = null;
            this.btnAgregarUser.Location = new System.Drawing.Point(585, 140);
            this.btnAgregarUser.Name = "btnAgregarUser";
            this.btnAgregarUser.Size = new System.Drawing.Size(24, 24);
            this.btnAgregarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAgregarUser.TabIndex = 34;
            this.btnAgregarUser.TabStop = false;
            this.btnAgregarUser.Zoom = 10;
            this.btnAgregarUser.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(847, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 38;
            this.label2.Tag = "Asignar permisos:";
            this.label2.Text = "Asignar permisos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "ID:";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Enabled = false;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(549, 396);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 54);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 42;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // cbFamilia
            // 
            this.cbFamilia.FormattingEnabled = true;
            this.cbFamilia.Location = new System.Drawing.Point(621, 280);
            this.cbFamilia.Name = "cbFamilia";
            this.cbFamilia.Size = new System.Drawing.Size(165, 21);
            this.cbFamilia.TabIndex = 43;
            // 
            // cbPatentes
            // 
            this.cbPatentes.FormattingEnabled = true;
            this.cbPatentes.Location = new System.Drawing.Point(621, 450);
            this.cbPatentes.Name = "cbPatentes";
            this.cbPatentes.Size = new System.Drawing.Size(165, 21);
            this.cbPatentes.TabIndex = 44;
            // 
            // Btn_AgregarFamiliaUser
            // 
            this.Btn_AgregarFamiliaUser.ActiveBorderThickness = 1;
            this.Btn_AgregarFamiliaUser.ActiveCornerRadius = 5;
            this.Btn_AgregarFamiliaUser.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_AgregarFamiliaUser.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Btn_AgregarFamiliaUser.ActiveLineColor = System.Drawing.Color.Gray;
            this.Btn_AgregarFamiliaUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.Btn_AgregarFamiliaUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_AgregarFamiliaUser.BackgroundImage")));
            this.Btn_AgregarFamiliaUser.ButtonText = "Asignar familia";
            this.Btn_AgregarFamiliaUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AgregarFamiliaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AgregarFamiliaUser.ForeColor = System.Drawing.Color.White;
            this.Btn_AgregarFamiliaUser.IdleBorderThickness = 1;
            this.Btn_AgregarFamiliaUser.IdleCornerRadius = 5;
            this.Btn_AgregarFamiliaUser.IdleFillColor = System.Drawing.Color.Transparent;
            this.Btn_AgregarFamiliaUser.IdleForecolor = System.Drawing.Color.White;
            this.Btn_AgregarFamiliaUser.IdleLineColor = System.Drawing.Color.White;
            this.Btn_AgregarFamiliaUser.Location = new System.Drawing.Point(630, 325);
            this.Btn_AgregarFamiliaUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_AgregarFamiliaUser.Name = "Btn_AgregarFamiliaUser";
            this.Btn_AgregarFamiliaUser.Size = new System.Drawing.Size(147, 48);
            this.Btn_AgregarFamiliaUser.TabIndex = 64;
            this.Btn_AgregarFamiliaUser.Tag = "Asignar Familia";
            this.Btn_AgregarFamiliaUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_AgregarFamiliaUser.Click += new System.EventHandler(this.Btn_AgregarFamiliaUser_Click);
            // 
            // btnAgregarPatenteUser
            // 
            this.btnAgregarPatenteUser.ActiveBorderThickness = 1;
            this.btnAgregarPatenteUser.ActiveCornerRadius = 5;
            this.btnAgregarPatenteUser.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnAgregarPatenteUser.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnAgregarPatenteUser.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnAgregarPatenteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.btnAgregarPatenteUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarPatenteUser.BackgroundImage")));
            this.btnAgregarPatenteUser.ButtonText = "Asignar patente";
            this.btnAgregarPatenteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPatenteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPatenteUser.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPatenteUser.IdleBorderThickness = 1;
            this.btnAgregarPatenteUser.IdleCornerRadius = 5;
            this.btnAgregarPatenteUser.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAgregarPatenteUser.IdleForecolor = System.Drawing.Color.White;
            this.btnAgregarPatenteUser.IdleLineColor = System.Drawing.Color.White;
            this.btnAgregarPatenteUser.Location = new System.Drawing.Point(630, 487);
            this.btnAgregarPatenteUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarPatenteUser.Name = "btnAgregarPatenteUser";
            this.btnAgregarPatenteUser.Size = new System.Drawing.Size(147, 48);
            this.btnAgregarPatenteUser.TabIndex = 65;
            this.btnAgregarPatenteUser.Tag = "Asignar Patente";
            this.btnAgregarPatenteUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarPatenteUser.Click += new System.EventHandler(this.btnAgregarPatenteUser_Click);
            // 
            // TV_PermisosUser
            // 
            this.TV_PermisosUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TV_PermisosUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.TV_PermisosUser.ForeColor = System.Drawing.Color.White;
            this.TV_PermisosUser.LineColor = System.Drawing.Color.Gray;
            this.TV_PermisosUser.Location = new System.Drawing.Point(851, 244);
            this.TV_PermisosUser.Name = "TV_PermisosUser";
            this.TV_PermisosUser.Size = new System.Drawing.Size(330, 415);
            this.TV_PermisosUser.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(307, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 70;
            this.label8.Tag = "Empresa";
            this.label8.Text = "Empresa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(25, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 69;
            this.label9.Tag = "Nombre:";
            this.label9.Text = "Nombre:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(55, 85);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(75, 23);
            this.txtID.TabIndex = 71;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(89, 115);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(188, 23);
            this.txtUsuario.TabIndex = 72;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(111, 144);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(166, 23);
            this.txtContraseña.TabIndex = 73;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 173);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(166, 23);
            this.txtNombre.TabIndex = 74;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(379, 85);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(156, 23);
            this.txtEmpresa.TabIndex = 75;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ActiveBorderThickness = 1;
            this.btnLimpiar.ActiveCornerRadius = 5;
            this.btnLimpiar.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnLimpiar.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.ButtonText = "Limpiar datos";
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IdleBorderThickness = 1;
            this.btnLimpiar.IdleCornerRadius = 5;
            this.btnLimpiar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.IdleForecolor = System.Drawing.Color.White;
            this.btnLimpiar.IdleLineColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(565, 85);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(147, 48);
            this.btnLimpiar.TabIndex = 76;
            this.btnLimpiar.Tag = "";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminarFamilia
            // 
            this.btnEliminarFamilia.ActiveBorderThickness = 1;
            this.btnEliminarFamilia.ActiveCornerRadius = 5;
            this.btnEliminarFamilia.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnEliminarFamilia.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnEliminarFamilia.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnEliminarFamilia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.btnEliminarFamilia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarFamilia.BackgroundImage")));
            this.btnEliminarFamilia.ButtonText = "Deasignar familia";
            this.btnEliminarFamilia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFamilia.ForeColor = System.Drawing.Color.White;
            this.btnEliminarFamilia.IdleBorderThickness = 1;
            this.btnEliminarFamilia.IdleCornerRadius = 5;
            this.btnEliminarFamilia.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnEliminarFamilia.IdleForecolor = System.Drawing.Color.White;
            this.btnEliminarFamilia.IdleLineColor = System.Drawing.Color.White;
            this.btnEliminarFamilia.Location = new System.Drawing.Point(630, 381);
            this.btnEliminarFamilia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarFamilia.Name = "btnEliminarFamilia";
            this.btnEliminarFamilia.Size = new System.Drawing.Size(147, 48);
            this.btnEliminarFamilia.TabIndex = 77;
            this.btnEliminarFamilia.Tag = "Asignar Familia";
            this.btnEliminarFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarFamilia.Click += new System.EventHandler(this.btnEliminarFamilia_Click);
            // 
            // btnEliminarPatente
            // 
            this.btnEliminarPatente.ActiveBorderThickness = 1;
            this.btnEliminarPatente.ActiveCornerRadius = 5;
            this.btnEliminarPatente.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnEliminarPatente.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnEliminarPatente.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnEliminarPatente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.btnEliminarPatente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarPatente.BackgroundImage")));
            this.btnEliminarPatente.ButtonText = "Desasignar patente";
            this.btnEliminarPatente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPatente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPatente.IdleBorderThickness = 1;
            this.btnEliminarPatente.IdleCornerRadius = 5;
            this.btnEliminarPatente.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnEliminarPatente.IdleForecolor = System.Drawing.Color.White;
            this.btnEliminarPatente.IdleLineColor = System.Drawing.Color.White;
            this.btnEliminarPatente.Location = new System.Drawing.Point(630, 543);
            this.btnEliminarPatente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarPatente.Name = "btnEliminarPatente";
            this.btnEliminarPatente.Size = new System.Drawing.Size(147, 48);
            this.btnEliminarPatente.TabIndex = 78;
            this.btnEliminarPatente.Tag = "";
            this.btnEliminarPatente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarPatente.Click += new System.EventHandler(this.btnEliminarPatente_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(379, 150);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(156, 23);
            this.txtDireccion.TabIndex = 80;
            this.txtDireccion.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(307, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 16);
            this.label6.TabIndex = 79;
            this.label6.Tag = "Empresa";
            this.label6.Text = "Direccion de la empresa:";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1253, 680);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEliminarPatente);
            this.Controls.Add(this.btnEliminarFamilia);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TV_PermisosUser);
            this.Controls.Add(this.btnAgregarPatenteUser);
            this.Controls.Add(this.Btn_AgregarFamiliaUser);
            this.Controls.Add(this.cbPatentes);
            this.Controls.Add(this.cbFamilia);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnModificarUser);
            this.Controls.Add(this.BtnEliminarUser);
            this.Controls.Add(this.btnAgregarUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVUsers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnModificarUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminarUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGVUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        //private WindowsFormsControlLibrary1.BunifuCustomTextbox txtUsername;
        //private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPassword;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton BtnModificarUser;
        private Bunifu.Framework.UI.BunifuImageButton BtnEliminarUser;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregarUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        //private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtUserID;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ComboBox cbFamilia;
        private System.Windows.Forms.ComboBox cbPatentes;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_AgregarFamiliaUser;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregarPatenteUser;
        private System.Windows.Forms.TreeView TV_PermisosUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtContraseña;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox txtEmpresa;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpiar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminarFamilia;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminarPatente;
        private MetroFramework.Controls.MetroTextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        //private WindowsFormsControlLibrary1.BunifuCustomTextbox txtEmpresa;
        //private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNombre;
    }
}