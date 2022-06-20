namespace _1__Entregra
{
    partial class frm_Precio
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
            this.panel_Fondo = new System.Windows.Forms.Panel();
            this.cob_Producto = new System.Windows.Forms.ComboBox();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.nud_Precio = new System.Windows.Forms.NumericUpDown();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Cambiar = new System.Windows.Forms.Button();
            this.pic_ResetearPrecio = new System.Windows.Forms.PictureBox();
            this.panel_Fondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ResetearPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Fondo
            // 
            this.panel_Fondo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Fondo.Controls.Add(this.pic_ResetearPrecio);
            this.panel_Fondo.Controls.Add(this.btn_Cambiar);
            this.panel_Fondo.Controls.Add(this.cob_Producto);
            this.panel_Fondo.Controls.Add(this.lbl_Producto);
            this.panel_Fondo.Controls.Add(this.nud_Precio);
            this.panel_Fondo.Controls.Add(this.lbl_Precio);
            this.panel_Fondo.Controls.Add(this.lbl_Titulo);
            this.panel_Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Fondo.Location = new System.Drawing.Point(0, 0);
            this.panel_Fondo.Name = "panel_Fondo";
            this.panel_Fondo.Size = new System.Drawing.Size(800, 450);
            this.panel_Fondo.TabIndex = 0;
            // 
            // cob_Producto
            // 
            this.cob_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_Producto.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.cob_Producto.FormattingEnabled = true;
            this.cob_Producto.Items.AddRange(new object[] {
            "Papas rosadas",
            "Zapallo criollo",
            "Trigo",
            "Cebada",
            "Manzanas",
            "Naranjas",
            "Limones"});
            this.cob_Producto.Location = new System.Drawing.Point(310, 120);
            this.cob_Producto.Name = "cob_Producto";
            this.cob_Producto.Size = new System.Drawing.Size(257, 33);
            this.cob_Producto.TabIndex = 16;
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Producto.Location = new System.Drawing.Point(185, 123);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(119, 25);
            this.lbl_Producto.TabIndex = 15;
            this.lbl_Producto.Text = "Producto:";
            // 
            // nud_Precio
            // 
            this.nud_Precio.DecimalPlaces = 2;
            this.nud_Precio.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.nud_Precio.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Precio.Location = new System.Drawing.Point(310, 163);
            this.nud_Precio.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_Precio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_Precio.Name = "nud_Precio";
            this.nud_Precio.Size = new System.Drawing.Size(257, 31);
            this.nud_Precio.TabIndex = 14;
            this.nud_Precio.Value = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            this.nud_Precio.ValueChanged += new System.EventHandler(this.nud_Precio_ValueChanged);
            this.nud_Precio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nud_Precio_KeyUp);
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.Location = new System.Drawing.Point(185, 169);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(89, 25);
            this.lbl_Precio.TabIndex = 13;
            this.lbl_Precio.Text = "Precio:";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Titulo.Location = new System.Drawing.Point(318, 30);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(134, 41);
            this.lbl_Titulo.TabIndex = 12;
            this.lbl_Titulo.Text = "Precio";
            // 
            // btn_Cambiar
            // 
            this.btn_Cambiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cambiar.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cambiar.Location = new System.Drawing.Point(441, 200);
            this.btn_Cambiar.Name = "btn_Cambiar";
            this.btn_Cambiar.Size = new System.Drawing.Size(126, 43);
            this.btn_Cambiar.TabIndex = 19;
            this.btn_Cambiar.Text = "Cambiar";
            this.btn_Cambiar.UseVisualStyleBackColor = true;
            // 
            // pic_ResetearPrecio
            // 
            this.pic_ResetearPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_ResetearPrecio.BackColor = System.Drawing.Color.IndianRed;
            this.pic_ResetearPrecio.Image = global::_1__Entregra.Properties.Resources.Close;
            this.pic_ResetearPrecio.Location = new System.Drawing.Point(564, 163);
            this.pic_ResetearPrecio.Name = "pic_ResetearPrecio";
            this.pic_ResetearPrecio.Size = new System.Drawing.Size(31, 31);
            this.pic_ResetearPrecio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_ResetearPrecio.TabIndex = 20;
            this.pic_ResetearPrecio.TabStop = false;
            this.pic_ResetearPrecio.Click += new System.EventHandler(this.pic_ResetearPrecio_Click);
            // 
            // frm_Precio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Fondo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Precio";
            this.Text = "frm_Precio";
            this.Load += new System.EventHandler(this.frm_Precio_Load);
            this.panel_Fondo.ResumeLayout(false);
            this.panel_Fondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ResetearPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Fondo;
        private System.Windows.Forms.ComboBox cob_Producto;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.NumericUpDown nud_Precio;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Cambiar;
        private System.Windows.Forms.PictureBox pic_ResetearPrecio;
    }
}