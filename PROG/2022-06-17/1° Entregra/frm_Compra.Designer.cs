﻿namespace _1__Entregra.Resources
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
            this.panel_Fondo = new System.Windows.Forms.Panel();
            this.txt_PrecioTotal = new System.Windows.Forms.TextBox();
            this.txt_PrecioUnitario = new System.Windows.Forms.TextBox();
            this.lbl_PrecioTotal = new System.Windows.Forms.Label();
            this.lbl_PrecioUnitario = new System.Windows.Forms.Label();
            this.cob_Producto = new System.Windows.Forms.ComboBox();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Comprar = new System.Windows.Forms.Button();
            this.panel_Fondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Fondo
            // 
            this.panel_Fondo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Fondo.Controls.Add(this.btn_Comprar);
            this.panel_Fondo.Controls.Add(this.txt_PrecioTotal);
            this.panel_Fondo.Controls.Add(this.txt_PrecioUnitario);
            this.panel_Fondo.Controls.Add(this.lbl_PrecioTotal);
            this.panel_Fondo.Controls.Add(this.lbl_PrecioUnitario);
            this.panel_Fondo.Controls.Add(this.cob_Producto);
            this.panel_Fondo.Controls.Add(this.lbl_Producto);
            this.panel_Fondo.Controls.Add(this.nud_Cantidad);
            this.panel_Fondo.Controls.Add(this.lbl_Cantidad);
            this.panel_Fondo.Controls.Add(this.label1);
            this.panel_Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Fondo.Location = new System.Drawing.Point(0, 0);
            this.panel_Fondo.Name = "panel_Fondo";
            this.panel_Fondo.Size = new System.Drawing.Size(800, 450);
            this.panel_Fondo.TabIndex = 0;
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
            // txt_PrecioUnitario
            // 
            this.txt_PrecioUnitario.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_PrecioUnitario.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.txt_PrecioUnitario.Location = new System.Drawing.Point(373, 203);
            this.txt_PrecioUnitario.MaxLength = 15;
            this.txt_PrecioUnitario.Name = "txt_PrecioUnitario";
            this.txt_PrecioUnitario.ReadOnly = true;
            this.txt_PrecioUnitario.Size = new System.Drawing.Size(194, 31);
            this.txt_PrecioUnitario.TabIndex = 16;
            this.txt_PrecioUnitario.TabStop = false;
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
            // lbl_PrecioUnitario
            // 
            this.lbl_PrecioUnitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_PrecioUnitario.AutoSize = true;
            this.lbl_PrecioUnitario.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecioUnitario.Location = new System.Drawing.Point(185, 206);
            this.lbl_PrecioUnitario.Name = "lbl_PrecioUnitario";
            this.lbl_PrecioUnitario.Size = new System.Drawing.Size(182, 25);
            this.lbl_PrecioUnitario.TabIndex = 14;
            this.lbl_PrecioUnitario.Text = "Precio unitario:";
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
            this.nud_Cantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nud_Cantidad_KeyUp);
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
            // frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.frm_Compra_Load);
            this.panel_Fondo.ResumeLayout(false);
            this.panel_Fondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Fondo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cob_Producto;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_PrecioTotal;
        private System.Windows.Forms.TextBox txt_PrecioUnitario;
        private System.Windows.Forms.Label lbl_PrecioTotal;
        private System.Windows.Forms.Label lbl_PrecioUnitario;
        private System.Windows.Forms.Button btn_Comprar;
    }
}