namespace SIGAV
{
    partial class Envios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Envios));
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Envios_Ventas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstado_Producto = new System.Windows.Forms.ComboBox();
            this.DGV_Envios_compras = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPuntaje = new System.Windows.Forms.ComboBox();
            this.crearRemito = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGuardarEstadoProd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEnviar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_GuardarEstadoEnvio = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Envios_Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Envios_compras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 39);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(972, 19);
            this.bunifuSeparator1.TabIndex = 70;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 69;
            this.label1.Tag = "Ventas";
            this.label1.Text = "Envios";
            // 
            // DGV_Envios_Ventas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGV_Envios_Ventas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Envios_Ventas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGV_Envios_Ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Envios_Ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Envios_Ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Envios_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Envios_Ventas.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Envios_Ventas.DoubleBuffered = true;
            this.DGV_Envios_Ventas.EnableHeadersVisualStyles = false;
            this.DGV_Envios_Ventas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DGV_Envios_Ventas.HeaderForeColor = System.Drawing.Color.White;
            this.DGV_Envios_Ventas.Location = new System.Drawing.Point(12, 421);
            this.DGV_Envios_Ventas.Name = "DGV_Envios_Ventas";
            this.DGV_Envios_Ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Envios_Ventas.Size = new System.Drawing.Size(704, 190);
            this.DGV_Envios_Ventas.TabIndex = 82;
            this.DGV_Envios_Ventas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Envios_Ventas_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 83;
            this.label2.Tag = "Listado de productos:";
            this.label2.Text = "Envios por mandar:";
            // 
            // cbEstado_Producto
            // 
            this.cbEstado_Producto.FormattingEnabled = true;
            this.cbEstado_Producto.Location = new System.Drawing.Point(258, 317);
            this.cbEstado_Producto.Name = "cbEstado_Producto";
            this.cbEstado_Producto.Size = new System.Drawing.Size(153, 21);
            this.cbEstado_Producto.TabIndex = 85;
            // 
            // DGV_Envios_compras
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGV_Envios_compras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Envios_compras.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGV_Envios_compras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Envios_compras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Envios_compras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Envios_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Envios_compras.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_Envios_compras.DoubleBuffered = true;
            this.DGV_Envios_compras.EnableHeadersVisualStyles = false;
            this.DGV_Envios_compras.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DGV_Envios_compras.HeaderForeColor = System.Drawing.Color.White;
            this.DGV_Envios_compras.Location = new System.Drawing.Point(16, 109);
            this.DGV_Envios_compras.Name = "DGV_Envios_compras";
            this.DGV_Envios_compras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Envios_compras.Size = new System.Drawing.Size(700, 190);
            this.DGV_Envios_compras.TabIndex = 86;
            this.DGV_Envios_compras.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Envios_CellMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 87;
            this.label4.Tag = "Listado de productos:";
            this.label4.Text = "Envios recibidos:";
            // 
            // cbPuntaje
            // 
            this.cbPuntaje.FormattingEnabled = true;
            this.cbPuntaje.Location = new System.Drawing.Point(518, 317);
            this.cbPuntaje.Name = "cbPuntaje";
            this.cbPuntaje.Size = new System.Drawing.Size(153, 21);
            this.cbPuntaje.TabIndex = 89;
            // 
            // crearRemito
            // 
            this.crearRemito.ActiveBorderThickness = 1;
            this.crearRemito.ActiveCornerRadius = 5;
            this.crearRemito.ActiveFillColor = System.Drawing.Color.Transparent;
            this.crearRemito.ActiveForecolor = System.Drawing.Color.Transparent;
            this.crearRemito.ActiveLineColor = System.Drawing.Color.Gray;
            this.crearRemito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.crearRemito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("crearRemito.BackgroundImage")));
            this.crearRemito.ButtonText = "Generar remito de envio";
            this.crearRemito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crearRemito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearRemito.ForeColor = System.Drawing.Color.White;
            this.crearRemito.IdleBorderThickness = 1;
            this.crearRemito.IdleCornerRadius = 5;
            this.crearRemito.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(150)))));
            this.crearRemito.IdleForecolor = System.Drawing.Color.White;
            this.crearRemito.IdleLineColor = System.Drawing.Color.Transparent;
            this.crearRemito.Location = new System.Drawing.Point(212, 637);
            this.crearRemito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crearRemito.Name = "crearRemito";
            this.crearRemito.Size = new System.Drawing.Size(218, 39);
            this.crearRemito.TabIndex = 91;
            this.crearRemito.Tag = "";
            this.crearRemito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.crearRemito.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 5;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(83)))), ((int)(((byte)(140)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(83)))), ((int)(((byte)(140)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Calificar vendedor";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 5;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(150)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.Location = new System.Drawing.Point(496, 346);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(185, 37);
            this.bunifuThinButton21.TabIndex = 90;
            this.bunifuThinButton21.Tag = "Calificar vendedor";
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnGuardarEstadoProd
            // 
            this.btnGuardarEstadoProd.ActiveBorderThickness = 1;
            this.btnGuardarEstadoProd.ActiveCornerRadius = 5;
            this.btnGuardarEstadoProd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(83)))), ((int)(((byte)(140)))));
            this.btnGuardarEstadoProd.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnGuardarEstadoProd.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(83)))), ((int)(((byte)(140)))));
            this.btnGuardarEstadoProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.btnGuardarEstadoProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarEstadoProd.BackgroundImage")));
            this.btnGuardarEstadoProd.ButtonText = "Guardar estado del producto";
            this.btnGuardarEstadoProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarEstadoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEstadoProd.ForeColor = System.Drawing.Color.White;
            this.btnGuardarEstadoProd.IdleBorderThickness = 1;
            this.btnGuardarEstadoProd.IdleCornerRadius = 5;
            this.btnGuardarEstadoProd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(150)))));
            this.btnGuardarEstadoProd.IdleForecolor = System.Drawing.Color.White;
            this.btnGuardarEstadoProd.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnGuardarEstadoProd.Location = new System.Drawing.Point(245, 346);
            this.btnGuardarEstadoProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarEstadoProd.Name = "btnGuardarEstadoProd";
            this.btnGuardarEstadoProd.Size = new System.Drawing.Size(185, 37);
            this.btnGuardarEstadoProd.TabIndex = 88;
            this.btnGuardarEstadoProd.Tag = "Guardar estado del producto";
            this.btnGuardarEstadoProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarEstadoProd.Click += new System.EventHandler(this.btnGuardarEstadoProd_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.ActiveBorderThickness = 1;
            this.btnEnviar.ActiveCornerRadius = 5;
            this.btnEnviar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(83)))), ((int)(((byte)(140)))));
            this.btnEnviar.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnEnviar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(83)))), ((int)(((byte)(140)))));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.ButtonText = "Pedido enviado";
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.IdleBorderThickness = 1;
            this.btnEnviar.IdleCornerRadius = 5;
            this.btnEnviar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(150)))));
            this.btnEnviar.IdleForecolor = System.Drawing.Color.White;
            this.btnEnviar.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnEnviar.Location = new System.Drawing.Point(12, 637);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(159, 39);
            this.btnEnviar.TabIndex = 84;
            this.btnEnviar.Tag = "Guardar estado del envio";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Btn_GuardarEstadoEnvio
            // 
            this.Btn_GuardarEstadoEnvio.ActiveBorderThickness = 1;
            this.Btn_GuardarEstadoEnvio.ActiveCornerRadius = 5;
            this.Btn_GuardarEstadoEnvio.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(83)))), ((int)(((byte)(140)))));
            this.Btn_GuardarEstadoEnvio.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Btn_GuardarEstadoEnvio.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(83)))), ((int)(((byte)(140)))));
            this.Btn_GuardarEstadoEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.Btn_GuardarEstadoEnvio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_GuardarEstadoEnvio.BackgroundImage")));
            this.Btn_GuardarEstadoEnvio.ButtonText = "Guardar estado del envio";
            this.Btn_GuardarEstadoEnvio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_GuardarEstadoEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GuardarEstadoEnvio.ForeColor = System.Drawing.Color.White;
            this.Btn_GuardarEstadoEnvio.IdleBorderThickness = 1;
            this.Btn_GuardarEstadoEnvio.IdleCornerRadius = 5;
            this.Btn_GuardarEstadoEnvio.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(150)))));
            this.Btn_GuardarEstadoEnvio.IdleForecolor = System.Drawing.Color.White;
            this.Btn_GuardarEstadoEnvio.IdleLineColor = System.Drawing.Color.Transparent;
            this.Btn_GuardarEstadoEnvio.Location = new System.Drawing.Point(16, 307);
            this.Btn_GuardarEstadoEnvio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_GuardarEstadoEnvio.Name = "Btn_GuardarEstadoEnvio";
            this.Btn_GuardarEstadoEnvio.Size = new System.Drawing.Size(185, 37);
            this.Btn_GuardarEstadoEnvio.TabIndex = 81;
            this.Btn_GuardarEstadoEnvio.Tag = "Guardar estado del envio";
            this.Btn_GuardarEstadoEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_GuardarEstadoEnvio.Click += new System.EventHandler(this.Btn_GuardarEstadoEnvio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(968, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Envios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(996, 690);
            this.Controls.Add(this.crearRemito);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.cbPuntaje);
            this.Controls.Add(this.btnGuardarEstadoProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGV_Envios_compras);
            this.Controls.Add(this.cbEstado_Producto);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_Envios_Ventas);
            this.Controls.Add(this.Btn_GuardarEstadoEnvio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Envios";
            this.Text = "Envios";
            this.Load += new System.EventHandler(this.Envios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Envios_Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Envios_compras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_GuardarEstadoEnvio;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGV_Envios_Ventas;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEnviar;
        private System.Windows.Forms.ComboBox cbEstado_Producto;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGV_Envios_compras;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardarEstadoProd;
        private System.Windows.Forms.ComboBox cbPuntaje;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 crearRemito;
    }
}