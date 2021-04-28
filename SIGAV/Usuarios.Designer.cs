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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVUsers = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextbox3 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtPassword = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnModificarUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnEliminarUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAgregarUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtUserID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lbFamilias = new System.Windows.Forms.ListBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
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
            this.pictureBox1.Location = new System.Drawing.Point(1064, 11);
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(1035, 19);
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
            this.label1.Text = "Usuarios";
            // 
            // DGVUsers
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGVUsers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGVUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsers.DoubleBuffered = true;
            this.DGVUsers.EnableHeadersVisualStyles = false;
            this.DGVUsers.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DGVUsers.HeaderForeColor = System.Drawing.Color.White;
            this.DGVUsers.Location = new System.Drawing.Point(25, 244);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVUsers.Size = new System.Drawing.Size(478, 377);
            this.DGVUsers.TabIndex = 18;
            this.DGVUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVUsers_CellMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "E-mail:";
            this.label6.Visible = false;
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
            this.label4.Text = "Usuario:";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(127, 118);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 22);
            this.txtUsername.TabIndex = 30;
            // 
            // bunifuCustomTextbox3
            // 
            this.bunifuCustomTextbox3.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomTextbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox3.Location = new System.Drawing.Point(127, 177);
            this.bunifuCustomTextbox3.Multiline = true;
            this.bunifuCustomTextbox3.Name = "bunifuCustomTextbox3";
            this.bunifuCustomTextbox3.Size = new System.Drawing.Size(240, 22);
            this.bunifuCustomTextbox3.TabIndex = 29;
            this.bunifuCustomTextbox3.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(127, 148);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(240, 22);
            this.txtPassword.TabIndex = 28;
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
            this.label3.Text = "Agregar, eliminar y editar usuarios:";
            // 
            // BtnModificarUser
            // 
            this.BtnModificarUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarUser.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificarUser.Image")));
            this.BtnModificarUser.ImageActive = null;
            this.BtnModificarUser.Location = new System.Drawing.Point(343, 213);
            this.BtnModificarUser.Name = "BtnModificarUser";
            this.BtnModificarUser.Size = new System.Drawing.Size(24, 24);
            this.BtnModificarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnModificarUser.TabIndex = 36;
            this.BtnModificarUser.TabStop = false;
            this.BtnModificarUser.Visible = false;
            this.BtnModificarUser.Zoom = 10;
            // 
            // BtnEliminarUser
            // 
            this.BtnEliminarUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarUser.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarUser.Image")));
            this.BtnEliminarUser.ImageActive = null;
            this.BtnEliminarUser.Location = new System.Drawing.Point(305, 213);
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
            this.btnAgregarUser.Location = new System.Drawing.Point(261, 213);
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
            this.label2.Location = new System.Drawing.Point(594, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 38;
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
            // TxtUserID
            // 
            this.TxtUserID.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUserID.Enabled = false;
            this.TxtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserID.Location = new System.Drawing.Point(127, 90);
            this.TxtUserID.Multiline = true;
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.Size = new System.Drawing.Size(56, 22);
            this.TxtUserID.TabIndex = 39;
            // 
            // lbFamilias
            // 
            this.lbFamilias.BackColor = System.Drawing.Color.Gainsboro;
            this.lbFamilias.FormattingEnabled = true;
            this.lbFamilias.Location = new System.Drawing.Point(598, 244);
            this.lbFamilias.Name = "lbFamilias";
            this.lbFamilias.Size = new System.Drawing.Size(376, 381);
            this.lbFamilias.TabIndex = 41;
            this.lbFamilias.SelectedIndexChanged += new System.EventHandler(this.LbFamilias_SelectedIndexChanged);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(524, 409);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(50, 45);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 42;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1093, 642);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.lbFamilias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnModificarUser);
            this.Controls.Add(this.BtnEliminarUser);
            this.Controls.Add(this.btnAgregarUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.bunifuCustomTextbox3);
            this.Controls.Add(this.txtPassword);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtUsername;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPassword;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton BtnModificarUser;
        private Bunifu.Framework.UI.BunifuImageButton BtnEliminarUser;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregarUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtUserID;
        private System.Windows.Forms.ListBox lbFamilias;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}