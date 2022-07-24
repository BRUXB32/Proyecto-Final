namespace _1__Entregra
{
    partial class frm_Comercio
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
            this.components = new System.ComponentModel.Container();
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            this.tab_Comercio = new System.Windows.Forms.TabControl();
            this.tp_Comprar = new System.Windows.Forms.TabPage();
            this.btn_Compra_Aceptar = new System.Windows.Forms.Button();
            this.lbl_Compra_Producto = new System.Windows.Forms.Label();
            this.txt_Compra_PrecioTotal = new System.Windows.Forms.TextBox();
            this.lbl_Compra_Titulo = new System.Windows.Forms.Label();
            this.txt_Compra_PrecioKG = new System.Windows.Forms.TextBox();
            this.nud_Compra_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.cob_Compra_Producto = new System.Windows.Forms.ComboBox();
            this.lbl_Compra_PrecioTotal = new System.Windows.Forms.Label();
            this.lbl_Compra_Cantidad = new System.Windows.Forms.Label();
            this.lbl_Compra_PrecioKG = new System.Windows.Forms.Label();
            this.tp_Vender = new System.Windows.Forms.TabPage();
            this.btn_Venta_Aceptar = new System.Windows.Forms.Button();
            this.lbl_Venta_Producto = new System.Windows.Forms.Label();
            this.txt_Venta_PrecioTotal = new System.Windows.Forms.TextBox();
            this.lbl_Venta_Titulo = new System.Windows.Forms.Label();
            this.txt_Venta_PrecioKG = new System.Windows.Forms.TextBox();
            this.nud_Venta_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.cob_Venta_Producto = new System.Windows.Forms.ComboBox();
            this.lbl_Venta_PrecioTotal = new System.Windows.Forms.Label();
            this.lbl_Venta_Cantidad = new System.Windows.Forms.Label();
            this.lbl_Venta_PrecioKG = new System.Windows.Forms.Label();
            this.cmd_Comercio = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnl_Fondo.SuspendLayout();
            this.tab_Comercio.SuspendLayout();
            this.tp_Comprar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Compra_Cantidad)).BeginInit();
            this.tp_Vender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Venta_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Fondo.Controls.Add(this.tab_Comercio);
            this.pnl_Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Fondo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(800, 450);
            this.pnl_Fondo.TabIndex = 1;
            // 
            // tab_Comercio
            // 
            this.tab_Comercio.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tab_Comercio.Controls.Add(this.tp_Comprar);
            this.tab_Comercio.Controls.Add(this.tp_Vender);
            this.tab_Comercio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Comercio.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.tab_Comercio.Location = new System.Drawing.Point(0, 0);
            this.tab_Comercio.Name = "tab_Comercio";
            this.tab_Comercio.SelectedIndex = 0;
            this.tab_Comercio.Size = new System.Drawing.Size(800, 450);
            this.tab_Comercio.TabIndex = 1;
            // 
            // tp_Comprar
            // 
            this.tp_Comprar.Controls.Add(this.btn_Compra_Aceptar);
            this.tp_Comprar.Controls.Add(this.lbl_Compra_Producto);
            this.tp_Comprar.Controls.Add(this.txt_Compra_PrecioTotal);
            this.tp_Comprar.Controls.Add(this.lbl_Compra_Titulo);
            this.tp_Comprar.Controls.Add(this.txt_Compra_PrecioKG);
            this.tp_Comprar.Controls.Add(this.nud_Compra_Cantidad);
            this.tp_Comprar.Controls.Add(this.cob_Compra_Producto);
            this.tp_Comprar.Controls.Add(this.lbl_Compra_PrecioTotal);
            this.tp_Comprar.Controls.Add(this.lbl_Compra_Cantidad);
            this.tp_Comprar.Controls.Add(this.lbl_Compra_PrecioKG);
            this.tp_Comprar.Location = new System.Drawing.Point(4, 37);
            this.tp_Comprar.Name = "tp_Comprar";
            this.tp_Comprar.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Comprar.Size = new System.Drawing.Size(792, 409);
            this.tp_Comprar.TabIndex = 0;
            this.tp_Comprar.Text = "Comprar";
            this.tp_Comprar.UseVisualStyleBackColor = true;
            // 
            // btn_Compra_Aceptar
            // 
            this.btn_Compra_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Compra_Aceptar.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Compra_Aceptar.Location = new System.Drawing.Point(333, 265);
            this.btn_Compra_Aceptar.Name = "btn_Compra_Aceptar";
            this.btn_Compra_Aceptar.Size = new System.Drawing.Size(126, 43);
            this.btn_Compra_Aceptar.TabIndex = 28;
            this.btn_Compra_Aceptar.Text = "Comprar";
            this.btn_Compra_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Compra_Aceptar.Click += new System.EventHandler(this.btn_Compra_Aceptar_Click);
            // 
            // lbl_Compra_Producto
            // 
            this.lbl_Compra_Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Compra_Producto.AutoSize = true;
            this.lbl_Compra_Producto.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Compra_Producto.Location = new System.Drawing.Point(175, 108);
            this.lbl_Compra_Producto.Name = "lbl_Compra_Producto";
            this.lbl_Compra_Producto.Size = new System.Drawing.Size(119, 25);
            this.lbl_Compra_Producto.TabIndex = 24;
            this.lbl_Compra_Producto.Text = "Producto:";
            // 
            // txt_Compra_PrecioTotal
            // 
            this.txt_Compra_PrecioTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Compra_PrecioTotal.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.txt_Compra_PrecioTotal.Location = new System.Drawing.Point(363, 222);
            this.txt_Compra_PrecioTotal.MaxLength = 15;
            this.txt_Compra_PrecioTotal.Name = "txt_Compra_PrecioTotal";
            this.txt_Compra_PrecioTotal.ReadOnly = true;
            this.txt_Compra_PrecioTotal.Size = new System.Drawing.Size(194, 31);
            this.txt_Compra_PrecioTotal.TabIndex = 27;
            this.txt_Compra_PrecioTotal.TabStop = false;
            this.txt_Compra_PrecioTotal.Text = "5";
            // 
            // lbl_Compra_Titulo
            // 
            this.lbl_Compra_Titulo.AutoSize = true;
            this.lbl_Compra_Titulo.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Compra_Titulo.Location = new System.Drawing.Point(315, 27);
            this.lbl_Compra_Titulo.Name = "lbl_Compra_Titulo";
            this.lbl_Compra_Titulo.Size = new System.Drawing.Size(163, 41);
            this.lbl_Compra_Titulo.TabIndex = 23;
            this.lbl_Compra_Titulo.Text = "Compra";
            // 
            // txt_Compra_PrecioKG
            // 
            this.txt_Compra_PrecioKG.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Compra_PrecioKG.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.txt_Compra_PrecioKG.Location = new System.Drawing.Point(363, 184);
            this.txt_Compra_PrecioKG.MaxLength = 15;
            this.txt_Compra_PrecioKG.Name = "txt_Compra_PrecioKG";
            this.txt_Compra_PrecioKG.ReadOnly = true;
            this.txt_Compra_PrecioKG.Size = new System.Drawing.Size(194, 31);
            this.txt_Compra_PrecioKG.TabIndex = 26;
            this.txt_Compra_PrecioKG.TabStop = false;
            this.txt_Compra_PrecioKG.Text = "5";
            // 
            // nud_Compra_Cantidad
            // 
            this.nud_Compra_Cantidad.ContextMenuStrip = this.cmd_Comercio;
            this.nud_Compra_Cantidad.DecimalPlaces = 2;
            this.nud_Compra_Cantidad.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.nud_Compra_Cantidad.Location = new System.Drawing.Point(300, 144);
            this.nud_Compra_Cantidad.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_Compra_Cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Compra_Cantidad.Name = "nud_Compra_Cantidad";
            this.nud_Compra_Cantidad.Size = new System.Drawing.Size(257, 31);
            this.nud_Compra_Cantidad.TabIndex = 21;
            this.nud_Compra_Cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Compra_Cantidad.ValueChanged += new System.EventHandler(this.nud_Compra_Cantidad_ValueChanged);
            // 
            // cob_Compra_Producto
            // 
            this.cob_Compra_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_Compra_Producto.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.cob_Compra_Producto.FormattingEnabled = true;
            this.cob_Compra_Producto.Items.AddRange(new object[] {
            "Papas rosadas",
            "Zapallo criollo",
            "Trigo",
            "Cebada",
            "Manzanas",
            "Naranjas",
            "Limones",
            "Semilla papas rosadas",
            "Semilla zapallo criollo",
            "Semilla trigo",
            "Semilla cebada",
            "Plantines manzanas",
            "Plantines naranjas",
            "Plantines limones",
            "Fertilizante",
            "Pesticida"});
            this.cob_Compra_Producto.Location = new System.Drawing.Point(300, 105);
            this.cob_Compra_Producto.Name = "cob_Compra_Producto";
            this.cob_Compra_Producto.Size = new System.Drawing.Size(257, 33);
            this.cob_Compra_Producto.TabIndex = 23;
            // 
            // lbl_Compra_PrecioTotal
            // 
            this.lbl_Compra_PrecioTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Compra_PrecioTotal.AutoSize = true;
            this.lbl_Compra_PrecioTotal.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Compra_PrecioTotal.Location = new System.Drawing.Point(175, 225);
            this.lbl_Compra_PrecioTotal.Name = "lbl_Compra_PrecioTotal";
            this.lbl_Compra_PrecioTotal.Size = new System.Drawing.Size(143, 25);
            this.lbl_Compra_PrecioTotal.TabIndex = 25;
            this.lbl_Compra_PrecioTotal.Text = "Precio total:";
            // 
            // lbl_Compra_Cantidad
            // 
            this.lbl_Compra_Cantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Compra_Cantidad.AutoSize = true;
            this.lbl_Compra_Cantidad.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Compra_Cantidad.Location = new System.Drawing.Point(175, 146);
            this.lbl_Compra_Cantidad.Name = "lbl_Compra_Cantidad";
            this.lbl_Compra_Cantidad.Size = new System.Drawing.Size(119, 25);
            this.lbl_Compra_Cantidad.TabIndex = 20;
            this.lbl_Compra_Cantidad.Text = "Cantidad:";
            // 
            // lbl_Compra_PrecioKG
            // 
            this.lbl_Compra_PrecioKG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Compra_PrecioKG.AutoSize = true;
            this.lbl_Compra_PrecioKG.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Compra_PrecioKG.Location = new System.Drawing.Point(175, 187);
            this.lbl_Compra_PrecioKG.Name = "lbl_Compra_PrecioKG";
            this.lbl_Compra_PrecioKG.Size = new System.Drawing.Size(162, 25);
            this.lbl_Compra_PrecioKG.TabIndex = 24;
            this.lbl_Compra_PrecioKG.Text = "Precio por kg:";
            // 
            // tp_Vender
            // 
            this.tp_Vender.Controls.Add(this.btn_Venta_Aceptar);
            this.tp_Vender.Controls.Add(this.lbl_Venta_Producto);
            this.tp_Vender.Controls.Add(this.txt_Venta_PrecioTotal);
            this.tp_Vender.Controls.Add(this.lbl_Venta_Titulo);
            this.tp_Vender.Controls.Add(this.txt_Venta_PrecioKG);
            this.tp_Vender.Controls.Add(this.nud_Venta_Cantidad);
            this.tp_Vender.Controls.Add(this.cob_Venta_Producto);
            this.tp_Vender.Controls.Add(this.lbl_Venta_PrecioTotal);
            this.tp_Vender.Controls.Add(this.lbl_Venta_Cantidad);
            this.tp_Vender.Controls.Add(this.lbl_Venta_PrecioKG);
            this.tp_Vender.Location = new System.Drawing.Point(4, 37);
            this.tp_Vender.Name = "tp_Vender";
            this.tp_Vender.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Vender.Size = new System.Drawing.Size(792, 409);
            this.tp_Vender.TabIndex = 1;
            this.tp_Vender.Text = "Vender";
            this.tp_Vender.UseVisualStyleBackColor = true;
            // 
            // btn_Venta_Aceptar
            // 
            this.btn_Venta_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Venta_Aceptar.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Venta_Aceptar.Location = new System.Drawing.Point(333, 265);
            this.btn_Venta_Aceptar.Name = "btn_Venta_Aceptar";
            this.btn_Venta_Aceptar.Size = new System.Drawing.Size(126, 43);
            this.btn_Venta_Aceptar.TabIndex = 28;
            this.btn_Venta_Aceptar.Text = "Vender";
            this.btn_Venta_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Venta_Aceptar.Click += new System.EventHandler(this.btn_Venta_Aceptar_Click);
            // 
            // lbl_Venta_Producto
            // 
            this.lbl_Venta_Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Venta_Producto.AutoSize = true;
            this.lbl_Venta_Producto.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Venta_Producto.Location = new System.Drawing.Point(175, 108);
            this.lbl_Venta_Producto.Name = "lbl_Venta_Producto";
            this.lbl_Venta_Producto.Size = new System.Drawing.Size(119, 25);
            this.lbl_Venta_Producto.TabIndex = 24;
            this.lbl_Venta_Producto.Text = "Producto:";
            // 
            // txt_Venta_PrecioTotal
            // 
            this.txt_Venta_PrecioTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Venta_PrecioTotal.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.txt_Venta_PrecioTotal.Location = new System.Drawing.Point(363, 222);
            this.txt_Venta_PrecioTotal.MaxLength = 15;
            this.txt_Venta_PrecioTotal.Name = "txt_Venta_PrecioTotal";
            this.txt_Venta_PrecioTotal.ReadOnly = true;
            this.txt_Venta_PrecioTotal.Size = new System.Drawing.Size(194, 31);
            this.txt_Venta_PrecioTotal.TabIndex = 27;
            this.txt_Venta_PrecioTotal.TabStop = false;
            this.txt_Venta_PrecioTotal.Text = "5";
            // 
            // lbl_Venta_Titulo
            // 
            this.lbl_Venta_Titulo.AutoSize = true;
            this.lbl_Venta_Titulo.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Venta_Titulo.Location = new System.Drawing.Point(315, 27);
            this.lbl_Venta_Titulo.Name = "lbl_Venta_Titulo";
            this.lbl_Venta_Titulo.Size = new System.Drawing.Size(150, 41);
            this.lbl_Venta_Titulo.TabIndex = 23;
            this.lbl_Venta_Titulo.Text = "Vender";
            // 
            // txt_Venta_PrecioKG
            // 
            this.txt_Venta_PrecioKG.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Venta_PrecioKG.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.txt_Venta_PrecioKG.Location = new System.Drawing.Point(363, 184);
            this.txt_Venta_PrecioKG.MaxLength = 15;
            this.txt_Venta_PrecioKG.Name = "txt_Venta_PrecioKG";
            this.txt_Venta_PrecioKG.ReadOnly = true;
            this.txt_Venta_PrecioKG.Size = new System.Drawing.Size(194, 31);
            this.txt_Venta_PrecioKG.TabIndex = 26;
            this.txt_Venta_PrecioKG.TabStop = false;
            this.txt_Venta_PrecioKG.Text = "5";
            // 
            // nud_Venta_Cantidad
            // 
            this.nud_Venta_Cantidad.ContextMenuStrip = this.cmd_Comercio;
            this.nud_Venta_Cantidad.DecimalPlaces = 2;
            this.nud_Venta_Cantidad.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.nud_Venta_Cantidad.Location = new System.Drawing.Point(300, 144);
            this.nud_Venta_Cantidad.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_Venta_Cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Venta_Cantidad.Name = "nud_Venta_Cantidad";
            this.nud_Venta_Cantidad.Size = new System.Drawing.Size(257, 31);
            this.nud_Venta_Cantidad.TabIndex = 21;
            this.nud_Venta_Cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Venta_Cantidad.ValueChanged += new System.EventHandler(this.nud_Venta_Cantidad_ValueChanged);
            // 
            // cob_Venta_Producto
            // 
            this.cob_Venta_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_Venta_Producto.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.cob_Venta_Producto.FormattingEnabled = true;
            this.cob_Venta_Producto.Items.AddRange(new object[] {
            "Trigo",
            "Cebada"});
            this.cob_Venta_Producto.Location = new System.Drawing.Point(300, 105);
            this.cob_Venta_Producto.Name = "cob_Venta_Producto";
            this.cob_Venta_Producto.Size = new System.Drawing.Size(257, 33);
            this.cob_Venta_Producto.TabIndex = 23;
            // 
            // lbl_Venta_PrecioTotal
            // 
            this.lbl_Venta_PrecioTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Venta_PrecioTotal.AutoSize = true;
            this.lbl_Venta_PrecioTotal.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Venta_PrecioTotal.Location = new System.Drawing.Point(175, 225);
            this.lbl_Venta_PrecioTotal.Name = "lbl_Venta_PrecioTotal";
            this.lbl_Venta_PrecioTotal.Size = new System.Drawing.Size(143, 25);
            this.lbl_Venta_PrecioTotal.TabIndex = 25;
            this.lbl_Venta_PrecioTotal.Text = "Precio total:";
            // 
            // lbl_Venta_Cantidad
            // 
            this.lbl_Venta_Cantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Venta_Cantidad.AutoSize = true;
            this.lbl_Venta_Cantidad.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Venta_Cantidad.Location = new System.Drawing.Point(175, 146);
            this.lbl_Venta_Cantidad.Name = "lbl_Venta_Cantidad";
            this.lbl_Venta_Cantidad.Size = new System.Drawing.Size(119, 25);
            this.lbl_Venta_Cantidad.TabIndex = 20;
            this.lbl_Venta_Cantidad.Text = "Cantidad:";
            // 
            // lbl_Venta_PrecioKG
            // 
            this.lbl_Venta_PrecioKG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Venta_PrecioKG.AutoSize = true;
            this.lbl_Venta_PrecioKG.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Venta_PrecioKG.Location = new System.Drawing.Point(175, 187);
            this.lbl_Venta_PrecioKG.Name = "lbl_Venta_PrecioKG";
            this.lbl_Venta_PrecioKG.Size = new System.Drawing.Size(162, 25);
            this.lbl_Venta_PrecioKG.TabIndex = 24;
            this.lbl_Venta_PrecioKG.Text = "Precio por kg:";
            // 
            // cmd_Comercio
            // 
            this.cmd_Comercio.Name = "cmd_Usuario";
            this.cmd_Comercio.Size = new System.Drawing.Size(61, 4);
            // 
            // frm_Comercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Comercio";
            this.Text = "frm_Comercio";
            this.pnl_Fondo.ResumeLayout(false);
            this.tab_Comercio.ResumeLayout(false);
            this.tp_Comprar.ResumeLayout(false);
            this.tp_Comprar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Compra_Cantidad)).EndInit();
            this.tp_Vender.ResumeLayout(false);
            this.tp_Vender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Venta_Cantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Fondo;
        private System.Windows.Forms.TabControl tab_Comercio;
        private System.Windows.Forms.TabPage tp_Comprar;
        private System.Windows.Forms.Button btn_Compra_Aceptar;
        private System.Windows.Forms.TextBox txt_Compra_PrecioTotal;
        private System.Windows.Forms.TextBox txt_Compra_PrecioKG;
        private System.Windows.Forms.Label lbl_Compra_PrecioTotal;
        private System.Windows.Forms.Label lbl_Compra_PrecioKG;
        private System.Windows.Forms.ComboBox cob_Compra_Producto;
        private System.Windows.Forms.NumericUpDown nud_Compra_Cantidad;
        private System.Windows.Forms.Label lbl_Compra_Cantidad;
        private System.Windows.Forms.Label lbl_Compra_Producto;
        private System.Windows.Forms.Label lbl_Compra_Titulo;
        private System.Windows.Forms.TabPage tp_Vender;
        private System.Windows.Forms.Button btn_Venta_Aceptar;
        private System.Windows.Forms.Label lbl_Venta_Producto;
        private System.Windows.Forms.TextBox txt_Venta_PrecioTotal;
        private System.Windows.Forms.Label lbl_Venta_Titulo;
        private System.Windows.Forms.TextBox txt_Venta_PrecioKG;
        private System.Windows.Forms.NumericUpDown nud_Venta_Cantidad;
        private System.Windows.Forms.ComboBox cob_Venta_Producto;
        private System.Windows.Forms.Label lbl_Venta_PrecioTotal;
        private System.Windows.Forms.Label lbl_Venta_Cantidad;
        private System.Windows.Forms.Label lbl_Venta_PrecioKG;
        private System.Windows.Forms.ContextMenuStrip cmd_Comercio;
    }
}