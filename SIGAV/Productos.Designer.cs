namespace SIGAV
{
    partial class Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.DGVProducto = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtIDProducto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_buscador = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrecio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombreProd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdateProducto = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDeleteProducto = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAgregarProducto = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtTipo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVProducto
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGVProducto.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGVProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVProducto.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVProducto.DoubleBuffered = true;
            this.DGVProducto.EnableHeadersVisualStyles = false;
            this.DGVProducto.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DGVProducto.HeaderForeColor = System.Drawing.Color.White;
            this.DGVProducto.Location = new System.Drawing.Point(24, 301);
            this.DGVProducto.Name = "DGVProducto";
            this.DGVProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVProducto.Size = new System.Drawing.Size(885, 329);
            this.DGVProducto.TabIndex = 76;
            this.DGVProducto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVProducto_CellMouseClick);
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDProducto.Enabled = false;
            this.txtIDProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIDProducto.ForeColor = System.Drawing.Color.White;
            this.txtIDProducto.HintForeColor = System.Drawing.Color.White;
            this.txtIDProducto.HintText = "";
            this.txtIDProducto.isPassword = false;
            this.txtIDProducto.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtIDProducto.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIDProducto.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtIDProducto.LineThickness = 3;
            this.txtIDProducto.Location = new System.Drawing.Point(120, 98);
            this.txtIDProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(240, 24);
            this.txtIDProducto.TabIndex = 75;
            this.txtIDProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(44, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 74;
            this.label11.Text = "ID:";
            // 
            // txt_buscador
            // 
            this.txt_buscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_buscador.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_buscador.ForeColor = System.Drawing.Color.White;
            this.txt_buscador.HintForeColor = System.Drawing.Color.White;
            this.txt_buscador.HintText = "";
            this.txt_buscador.isPassword = false;
            this.txt_buscador.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txt_buscador.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_buscador.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txt_buscador.LineThickness = 3;
            this.txt_buscador.Location = new System.Drawing.Point(659, 256);
            this.txt_buscador.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscador.Name = "txt_buscador";
            this.txt_buscador.Size = new System.Drawing.Size(219, 31);
            this.txt_buscador.TabIndex = 72;
            this.txt_buscador.Text = "Nombre";
            this.txt_buscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_buscador.Visible = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecio.ForeColor = System.Drawing.Color.White;
            this.txtPrecio.HintForeColor = System.Drawing.Color.White;
            this.txtPrecio.HintText = "";
            this.txtPrecio.isPassword = false;
            this.txtPrecio.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtPrecio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrecio.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtPrecio.LineThickness = 3;
            this.txtPrecio.Location = new System.Drawing.Point(120, 195);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(240, 24);
            this.txtPrecio.TabIndex = 68;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.HintForeColor = System.Drawing.Color.White;
            this.txtDescripcion.HintText = "";
            this.txtDescripcion.isPassword = false;
            this.txtDescripcion.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtDescripcion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDescripcion.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtDescripcion.LineThickness = 3;
            this.txtDescripcion.Location = new System.Drawing.Point(120, 163);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(240, 24);
            this.txtDescripcion.TabIndex = 67;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProd.ForeColor = System.Drawing.Color.White;
            this.txtNombreProd.HintForeColor = System.Drawing.Color.White;
            this.txtNombreProd.HintText = "";
            this.txtNombreProd.isPassword = false;
            this.txtNombreProd.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtNombreProd.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombreProd.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtNombreProd.LineThickness = 3;
            this.txtNombreProd.Location = new System.Drawing.Point(120, 127);
            this.txtNombreProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(240, 23);
            this.txtNombreProd.TabIndex = 66;
            this.txtNombreProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Agregar, eliminar y editar clientes:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(550, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Buscar producto:";
            this.label2.Visible = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(19, 40);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(890, 19);
            this.bunifuSeparator1.TabIndex = 54;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(913, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnUpdateProducto
            // 
            this.btnUpdateProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateProducto.Image")));
            this.btnUpdateProducto.ImageActive = null;
            this.btnUpdateProducto.Location = new System.Drawing.Point(286, 243);
            this.btnUpdateProducto.Name = "btnUpdateProducto";
            this.btnUpdateProducto.Size = new System.Drawing.Size(24, 24);
            this.btnUpdateProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnUpdateProducto.TabIndex = 56;
            this.btnUpdateProducto.TabStop = false;
            this.btnUpdateProducto.Zoom = 10;
            this.btnUpdateProducto.Click += new System.EventHandler(this.btnUpdateProducto_Click);
            // 
            // btnDeleteProducto
            // 
            this.btnDeleteProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProducto.Image")));
            this.btnDeleteProducto.ImageActive = null;
            this.btnDeleteProducto.Location = new System.Drawing.Point(326, 243);
            this.btnDeleteProducto.Name = "btnDeleteProducto";
            this.btnDeleteProducto.Size = new System.Drawing.Size(24, 24);
            this.btnDeleteProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDeleteProducto.TabIndex = 52;
            this.btnDeleteProducto.TabStop = false;
            this.btnDeleteProducto.Zoom = 10;
            this.btnDeleteProducto.Click += new System.EventHandler(this.btnDeleteProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.ImageActive = null;
            this.btnAgregarProducto.Location = new System.Drawing.Point(244, 243);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(24, 24);
            this.btnAgregarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAgregarProducto.TabIndex = 51;
            this.btnAgregarProducto.TabStop = false;
            this.btnAgregarProducto.Zoom = 10;
            this.btnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(885, 263);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bunifuImageButton1.TabIndex = 50;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Visible = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // txtTipo
            // 
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTipo.ForeColor = System.Drawing.Color.White;
            this.txtTipo.HintForeColor = System.Drawing.Color.White;
            this.txtTipo.HintText = "";
            this.txtTipo.isPassword = false;
            this.txtTipo.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtTipo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTipo.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtTipo.LineThickness = 3;
            this.txtTipo.Location = new System.Drawing.Point(492, 129);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(240, 24);
            this.txtTipo.TabIndex = 80;
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.HintForeColor = System.Drawing.Color.White;
            this.txtCantidad.HintText = "";
            this.txtCantidad.isPassword = false;
            this.txtCantidad.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtCantidad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCantidad.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtCantidad.LineThickness = 3;
            this.txtCantidad.Location = new System.Drawing.Point(492, 97);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(240, 24);
            this.txtCantidad.TabIndex = 79;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(403, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "Tipo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(395, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 77;
            this.label8.Text = "Cantidad:";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(948, 642);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DGVProducto);
            this.Controls.Add(this.txtIDProducto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_buscador);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdateProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.bunifuImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DGVProducto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIDProducto;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_buscador;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrecio;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDescripcion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnUpdateProducto;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnDeleteProducto;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregarProducto;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTipo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}