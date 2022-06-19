namespace _1__Entregra.Resources
{
    partial class frm_Compra
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
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            this.btn_Comprar = new System.Windows.Forms.Button();
            this.txt_PrecioTotal = new System.Windows.Forms.TextBox();
            this.txt_PrecioKG = new System.Windows.Forms.TextBox();
            this.lbl_PrecioTotal = new System.Windows.Forms.Label();
            this.lbl_PrecioKG = new System.Windows.Forms.Label();
            this.cob_Producto = new System.Windows.Forms.ComboBox();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Fondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Fondo.Controls.Add(this.btn_Comprar);
            this.pnl_Fondo.Controls.Add(this.txt_PrecioTotal);
            this.pnl_Fondo.Controls.Add(this.txt_PrecioKG);
            this.pnl_Fondo.Controls.Add(this.lbl_PrecioTotal);
            this.pnl_Fondo.Controls.Add(this.lbl_PrecioKG);
            this.pnl_Fondo.Controls.Add(this.cob_Producto);
            this.pnl_Fondo.Controls.Add(this.lbl_Producto);
            this.pnl_Fondo.Controls.Add(this.nud_Cantidad);
            this.pnl_Fondo.Controls.Add(this.lbl_Cantidad);
            this.pnl_Fondo.Controls.Add(this.label1);
            this.pnl_Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Fondo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(800, 450);
            this.pnl_Fondo.TabIndex = 0;
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Comprar.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Comprar.Location = new System.Drawing.Point(441, 278);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(126, 43);
            this.btn_Comprar.TabIndex = 18;
            this.btn_Comprar.Text = "Comprar";
            this.btn_Comprar.UseVisualStyleBackColor = true;
            this.btn_Comprar.Click += new System.EventHandler(this.btn_Comprar_Click);
            // 
            // txt_PrecioTotal
            // 
            this.txt_PrecioTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_PrecioTotal.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.txt_PrecioTotal.Location = new System.Drawing.Point(373, 241);
            this.txt_PrecioTotal.MaxLength = 15;
            this.txt_PrecioTotal.Name = "txt_PrecioTotal";
            this.txt_PrecioTotal.ReadOnly = true;
            this.txt_PrecioTotal.Size = new System.Drawing.Size(194, 31);
            this.txt_PrecioTotal.TabIndex = 17;
            this.txt_PrecioTotal.TabStop = false;
            // 
            // txt_PrecioKG
            // 
            this.txt_PrecioKG.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_PrecioKG.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.txt_PrecioKG.Location = new System.Drawing.Point(373, 203);
            this.txt_PrecioKG.MaxLength = 15;
            this.txt_PrecioKG.Name = "txt_PrecioKG";
            this.txt_PrecioKG.ReadOnly = true;
            this.txt_PrecioKG.Size = new System.Drawing.Size(194, 31);
            this.txt_PrecioKG.TabIndex = 16;
            this.txt_PrecioKG.TabStop = false;
            // 
            // lbl_PrecioTotal
            // 
            this.lbl_PrecioTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_PrecioTotal.AutoSize = true;
            this.lbl_PrecioTotal.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecioTotal.Location = new System.Drawing.Point(185, 241);
            this.lbl_PrecioTotal.Name = "lbl_PrecioTotal";
            this.lbl_PrecioTotal.Size = new System.Drawing.Size(143, 25);
            this.lbl_PrecioTotal.TabIndex = 15;
            this.lbl_PrecioTotal.Text = "Precio total:";
            // 
            // lbl_PrecioKG
            // 
            this.lbl_PrecioKG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_PrecioKG.AutoSize = true;
            this.lbl_PrecioKG.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecioKG.Location = new System.Drawing.Point(185, 206);
            this.lbl_PrecioKG.Name = "lbl_PrecioKG";
            this.lbl_PrecioKG.Size = new System.Drawing.Size(154, 25);
            this.lbl_PrecioKG.TabIndex = 14;
            this.lbl_PrecioKG.Text = "Precio por kg";
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
            this.cob_Producto.TabIndex = 11;
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Producto.Location = new System.Drawing.Point(185, 123);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(119, 25);
            this.lbl_Producto.TabIndex = 10;
            this.lbl_Producto.Text = "Producto:";
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.DecimalPlaces = 2;
            this.nud_Cantidad.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.nud_Cantidad.Location = new System.Drawing.Point(310, 163);
            this.nud_Cantidad.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_Cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(257, 31);
            this.nud_Cantidad.TabIndex = 9;
            this.nud_Cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Cantidad.ValueChanged += new System.EventHandler(this.nud_Cantidad_ValueChanged);
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(185, 169);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(119, 25);
            this.lbl_Cantidad.TabIndex = 8;
            this.lbl_Cantidad.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(318, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compra";
            // 
            // frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.frm_Compra_Load);
            this.pnl_Fondo.ResumeLayout(false);
            this.pnl_Fondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Fondo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cob_Producto;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_PrecioTotal;
        private System.Windows.Forms.TextBox txt_PrecioKG;
        private System.Windows.Forms.Label lbl_PrecioTotal;
        private System.Windows.Forms.Label lbl_PrecioKG;
        private System.Windows.Forms.Button btn_Comprar;
    }
}