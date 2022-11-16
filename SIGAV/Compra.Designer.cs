namespace SIGAV
{
    partial class Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_ComprarProd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAutorizarProd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DGV_Ofertas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.DGV_Autorizacion = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtOferta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRechazarCompra = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ofertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Autorizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1043, 9);
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 36);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1047, 19);
            this.bunifuSeparator1.TabIndex = 16;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 15;
            this.label1.Tag = "Compras";
            this.label1.Text = "Compras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 19;
            this.label3.Tag = "Listado de productos a la venta:";
            this.label3.Text = "Listado de productos a la venta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 20);
            this.label2.TabIndex = 21;
            this.label2.Tag = "Compras pendientes de autorización:";
            this.label2.Text = "Compras pendientes de autorización:";
            // 
            // Btn_ComprarProd
            // 
            this.Btn_ComprarProd.ActiveBorderThickness = 1;
            this.Btn_ComprarProd.ActiveCornerRadius = 5;
            this.Btn_ComprarProd.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_ComprarProd.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Btn_ComprarProd.ActiveLineColor = System.Drawing.Color.Gray;
            this.Btn_ComprarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.Btn_ComprarProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ComprarProd.BackgroundImage")));
            this.Btn_ComprarProd.ButtonText = "Ofertar producto";
            this.Btn_ComprarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ComprarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ComprarProd.ForeColor = System.Drawing.Color.White;
            this.Btn_ComprarProd.IdleBorderThickness = 1;
            this.Btn_ComprarProd.IdleCornerRadius = 5;
            this.Btn_ComprarProd.IdleFillColor = System.Drawing.Color.Transparent;
            this.Btn_ComprarProd.IdleForecolor = System.Drawing.Color.White;
            this.Btn_ComprarProd.IdleLineColor = System.Drawing.Color.White;
            this.Btn_ComprarProd.Location = new System.Drawing.Point(12, 360);
            this.Btn_ComprarProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_ComprarProd.Name = "Btn_ComprarProd";
            this.Btn_ComprarProd.Size = new System.Drawing.Size(152, 43);
            this.Btn_ComprarProd.TabIndex = 64;
            this.Btn_ComprarProd.Tag = "ofertar producto";
            this.Btn_ComprarProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_ComprarProd.Click += new System.EventHandler(this.Btn_ComprarProd_Click);
            // 
            // btnAutorizarProd
            // 
            this.btnAutorizarProd.ActiveBorderThickness = 1;
            this.btnAutorizarProd.ActiveCornerRadius = 5;
            this.btnAutorizarProd.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnAutorizarProd.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnAutorizarProd.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnAutorizarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.btnAutorizarProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutorizarProd.BackgroundImage")));
            this.btnAutorizarProd.ButtonText = "Autorizar compra";
            this.btnAutorizarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutorizarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutorizarProd.ForeColor = System.Drawing.Color.White;
            this.btnAutorizarProd.IdleBorderThickness = 1;
            this.btnAutorizarProd.IdleCornerRadius = 5;
            this.btnAutorizarProd.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAutorizarProd.IdleForecolor = System.Drawing.Color.White;
            this.btnAutorizarProd.IdleLineColor = System.Drawing.Color.White;
            this.btnAutorizarProd.Location = new System.Drawing.Point(17, 700);
            this.btnAutorizarProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAutorizarProd.Name = "btnAutorizarProd";
            this.btnAutorizarProd.Size = new System.Drawing.Size(152, 43);
            this.btnAutorizarProd.TabIndex = 65;
            this.btnAutorizarProd.Tag = "autorizar compra";
            this.btnAutorizarProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAutorizarProd.Click += new System.EventHandler(this.btnAutorizarProd_Click);
            // 
            // DGV_Ofertas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGV_Ofertas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Ofertas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGV_Ofertas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Ofertas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Ofertas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Ofertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Ofertas.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Ofertas.DoubleBuffered = true;
            this.DGV_Ofertas.EnableHeadersVisualStyles = false;
            this.DGV_Ofertas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DGV_Ofertas.HeaderForeColor = System.Drawing.Color.White;
            this.DGV_Ofertas.Location = new System.Drawing.Point(12, 117);
            this.DGV_Ofertas.Name = "DGV_Ofertas";
            this.DGV_Ofertas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Ofertas.Size = new System.Drawing.Size(885, 235);
            this.DGV_Ofertas.TabIndex = 78;
            this.DGV_Ofertas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Ventas_CellMouseClick);
            // 
            // DGV_Autorizacion
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGV_Autorizacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Autorizacion.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGV_Autorizacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Autorizacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Autorizacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Autorizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Autorizacion.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_Autorizacion.DoubleBuffered = true;
            this.DGV_Autorizacion.EnableHeadersVisualStyles = false;
            this.DGV_Autorizacion.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DGV_Autorizacion.HeaderForeColor = System.Drawing.Color.White;
            this.DGV_Autorizacion.Location = new System.Drawing.Point(12, 457);
            this.DGV_Autorizacion.Name = "DGV_Autorizacion";
            this.DGV_Autorizacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Autorizacion.Size = new System.Drawing.Size(885, 235);
            this.DGV_Autorizacion.TabIndex = 79;
            this.DGV_Autorizacion.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Compras_CellMouseClick);
            // 
            // txtOferta
            // 
            this.txtOferta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtOferta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtOferta.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtOferta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOferta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOferta.ForeColor = System.Drawing.Color.White;
            this.txtOferta.HintForeColor = System.Drawing.Color.White;
            this.txtOferta.HintText = "";
            this.txtOferta.isPassword = false;
            this.txtOferta.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtOferta.LineIdleColor = System.Drawing.Color.Gray;
            this.txtOferta.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtOferta.LineThickness = 3;
            this.txtOferta.Location = new System.Drawing.Point(67, 86);
            this.txtOferta.Margin = new System.Windows.Forms.Padding(4);
            this.txtOferta.MaxLength = 32767;
            this.txtOferta.Name = "txtOferta";
            this.txtOferta.Size = new System.Drawing.Size(136, 24);
            this.txtOferta.TabIndex = 83;
            this.txtOferta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 82;
            this.label8.Tag = "Cantidad:";
            this.label8.Text = "Oferta:";
            // 
            // btnRechazarCompra
            // 
            this.btnRechazarCompra.ActiveBorderThickness = 1;
            this.btnRechazarCompra.ActiveCornerRadius = 5;
            this.btnRechazarCompra.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnRechazarCompra.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnRechazarCompra.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnRechazarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.btnRechazarCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRechazarCompra.BackgroundImage")));
            this.btnRechazarCompra.ButtonText = "Rechazar compra";
            this.btnRechazarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechazarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazarCompra.ForeColor = System.Drawing.Color.White;
            this.btnRechazarCompra.IdleBorderThickness = 1;
            this.btnRechazarCompra.IdleCornerRadius = 5;
            this.btnRechazarCompra.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnRechazarCompra.IdleForecolor = System.Drawing.Color.White;
            this.btnRechazarCompra.IdleLineColor = System.Drawing.Color.White;
            this.btnRechazarCompra.Location = new System.Drawing.Point(189, 700);
            this.btnRechazarCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRechazarCompra.Name = "btnRechazarCompra";
            this.btnRechazarCompra.Size = new System.Drawing.Size(152, 43);
            this.btnRechazarCompra.TabIndex = 84;
            this.btnRechazarCompra.Tag = "";
            this.btnRechazarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRechazarCompra.Click += new System.EventHandler(this.btnRechazarCompra_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1071, 749);
            this.Controls.Add(this.btnRechazarCompra);
            this.Controls.Add(this.txtOferta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DGV_Autorizacion);
            this.Controls.Add(this.DGV_Ofertas);
            this.Controls.Add(this.btnAutorizarProd);
            this.Controls.Add(this.Btn_ComprarProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ofertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Autorizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_ComprarProd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAutorizarProd;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGV_Ofertas;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGV_Autorizacion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtOferta;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRechazarCompra;
    }
}