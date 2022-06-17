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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Envios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstado_Envio = new System.Windows.Forms.ComboBox();
            this.Btn_GuardarEstadoEnvio = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DGV_Envios_Ventas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbEstado_Producto = new System.Windows.Forms.ComboBox();
            this.DGV_Envios_compras = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarEstadoProd = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Envios_Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Envios_compras)).BeginInit();
            this.SuspendLayout();
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
            // cbEstado_Envio
            // 
            this.cbEstado_Envio.FormattingEnabled = true;
            this.cbEstado_Envio.Location = new System.Drawing.Point(18, 317);
            this.cbEstado_Envio.Name = "cbEstado_Envio";
            this.cbEstado_Envio.Size = new System.Drawing.Size(153, 21);
            this.cbEstado_Envio.TabIndex = 80;
            // 
            // Btn_GuardarEstadoEnvio
            // 
            this.Btn_GuardarEstadoEnvio.ActiveBorderThickness = 1;
            this.Btn_GuardarEstadoEnvio.ActiveCornerRadius = 5;
            this.Btn_GuardarEstadoEnvio.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_GuardarEstadoEnvio.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Btn_GuardarEstadoEnvio.ActiveLineColor = System.Drawing.Color.Gray;
            this.Btn_GuardarEstadoEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.Btn_GuardarEstadoEnvio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_GuardarEstadoEnvio.BackgroundImage")));
            this.Btn_GuardarEstadoEnvio.ButtonText = "Guardar estado del envio";
            this.Btn_GuardarEstadoEnvio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_GuardarEstadoEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GuardarEstadoEnvio.ForeColor = System.Drawing.Color.White;
            this.Btn_GuardarEstadoEnvio.IdleBorderThickness = 1;
            this.Btn_GuardarEstadoEnvio.IdleCornerRadius = 5;
            this.Btn_GuardarEstadoEnvio.IdleFillColor = System.Drawing.Color.Transparent;
            this.Btn_GuardarEstadoEnvio.IdleForecolor = System.Drawing.Color.White;
            this.Btn_GuardarEstadoEnvio.IdleLineColor = System.Drawing.Color.White;
            this.Btn_GuardarEstadoEnvio.Location = new System.Drawing.Point(16, 346);
            this.Btn_GuardarEstadoEnvio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_GuardarEstadoEnvio.Name = "Btn_GuardarEstadoEnvio";
            this.Btn_GuardarEstadoEnvio.Size = new System.Drawing.Size(185, 37);
            this.Btn_GuardarEstadoEnvio.TabIndex = 81;
            this.Btn_GuardarEstadoEnvio.Tag = "Guardar estado del envio";
            this.Btn_GuardarEstadoEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_GuardarEstadoEnvio.Click += new System.EventHandler(this.Btn_GuardarEstadoEnvio_Click);
            // 
            // DGV_Envios_Ventas
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGV_Envios_Ventas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_Envios_Ventas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGV_Envios_Ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Envios_Ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Envios_Ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_Envios_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Envios_Ventas.DefaultCellStyle = dataGridViewCellStyle9;
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
            // btnEnviar
            // 
            this.btnEnviar.ActiveBorderThickness = 1;
            this.btnEnviar.ActiveCornerRadius = 5;
            this.btnEnviar.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnEnviar.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnEnviar.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.ButtonText = "Pedido enviado";
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.IdleBorderThickness = 1;
            this.btnEnviar.IdleCornerRadius = 5;
            this.btnEnviar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnEnviar.IdleForecolor = System.Drawing.Color.White;
            this.btnEnviar.IdleLineColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(12, 637);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(159, 39);
            this.btnEnviar.TabIndex = 84;
            this.btnEnviar.Tag = "Guardar estado del envio";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cbEstado_Producto
            // 
            this.cbEstado_Producto.FormattingEnabled = true;
            this.cbEstado_Producto.Location = new System.Drawing.Point(258, 317);
            this.cbEstado_Producto.Name = "cbEstado_Producto";
            this.cbEstado_Producto.Size = new System.Drawing.Size(153, 21);
            this.cbEstado_Producto.TabIndex = 85;
            this.cbEstado_Producto.Visible = false;
            // 
            // DGV_Envios_compras
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGV_Envios_compras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_Envios_compras.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGV_Envios_compras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Envios_compras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Envios_compras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DGV_Envios_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Envios_compras.DefaultCellStyle = dataGridViewCellStyle12;
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
            // btnGuardarEstadoProd
            // 
            this.btnGuardarEstadoProd.ActiveBorderThickness = 1;
            this.btnGuardarEstadoProd.ActiveCornerRadius = 5;
            this.btnGuardarEstadoProd.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnGuardarEstadoProd.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnGuardarEstadoProd.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnGuardarEstadoProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.btnGuardarEstadoProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarEstadoProd.BackgroundImage")));
            this.btnGuardarEstadoProd.ButtonText = "Guardar estado del producto";
            this.btnGuardarEstadoProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarEstadoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEstadoProd.ForeColor = System.Drawing.Color.White;
            this.btnGuardarEstadoProd.IdleBorderThickness = 1;
            this.btnGuardarEstadoProd.IdleCornerRadius = 5;
            this.btnGuardarEstadoProd.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnGuardarEstadoProd.IdleForecolor = System.Drawing.Color.White;
            this.btnGuardarEstadoProd.IdleLineColor = System.Drawing.Color.White;
            this.btnGuardarEstadoProd.Location = new System.Drawing.Point(258, 346);
            this.btnGuardarEstadoProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarEstadoProd.Name = "btnGuardarEstadoProd";
            this.btnGuardarEstadoProd.Size = new System.Drawing.Size(185, 37);
            this.btnGuardarEstadoProd.TabIndex = 88;
            this.btnGuardarEstadoProd.Tag = "Guardar estado del producto";
            this.btnGuardarEstadoProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarEstadoProd.Visible = false;
            this.btnGuardarEstadoProd.Click += new System.EventHandler(this.btnGuardarEstadoProd_Click);
            // 
            // Envios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(996, 690);
            this.Controls.Add(this.btnGuardarEstadoProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGV_Envios_compras);
            this.Controls.Add(this.cbEstado_Producto);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_Envios_Ventas);
            this.Controls.Add(this.Btn_GuardarEstadoEnvio);
            this.Controls.Add(this.cbEstado_Envio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Envios";
            this.Text = "Envios";
            this.Load += new System.EventHandler(this.Envios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Envios_Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Envios_compras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstado_Envio;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_GuardarEstadoEnvio;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGV_Envios_Ventas;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEnviar;
        private System.Windows.Forms.ComboBox cbEstado_Producto;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGV_Envios_compras;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardarEstadoProd;
    }
}