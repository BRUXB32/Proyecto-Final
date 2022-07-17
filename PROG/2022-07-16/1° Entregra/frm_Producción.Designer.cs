namespace _1__Entregra.Resources
{
    partial class frm_Producción
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
            this.tab_Produccion = new System.Windows.Forms.TabControl();
            this.tp_Notificaciones = new System.Windows.Forms.TabPage();
            this.dgv_Notificaciones_Listar = new System.Windows.Forms.DataGridView();
            this.col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Notificaciones_Titulo = new System.Windows.Forms.Label();
            this.tp_Ciclo = new System.Windows.Forms.TabPage();
            this.pic_Ciclo_BorrarID = new System.Windows.Forms.PictureBox();
            this.cob_Ciclo_Cultivo = new System.Windows.Forms.ComboBox();
            this.txt_Ciclo_ID = new System.Windows.Forms.TextBox();
            this.lbl_Ciclo_Cultivo = new System.Windows.Forms.Label();
            this.lbl_Ciclo_Titulo = new System.Windows.Forms.Label();
            this.btn_Ciclo_Aceptar = new System.Windows.Forms.Button();
            this.lbl_Ciclo_ID = new System.Windows.Forms.Label();
            this.tp_Fertilizacion = new System.Windows.Forms.TabPage();
            this.nud_Fertilizacion_IDSector = new System.Windows.Forms.NumericUpDown();
            this.nud_Fertilizacion_cantidad = new System.Windows.Forms.NumericUpDown();
            this.lbl_Fertilizacion_Nitrogeno = new System.Windows.Forms.Label();
            this.rdo_Fosforo = new System.Windows.Forms.RadioButton();
            this.rdo_Nitrogeno = new System.Windows.Forms.RadioButton();
            this.lbl_Fertilizacion_Titulo = new System.Windows.Forms.Label();
            this.btn_Fertilizacion_Calcular = new System.Windows.Forms.Button();
            this.lbl_Fertilizacion_ID = new System.Windows.Forms.Label();
            this.err_Produccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmd_Produccion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Fondo.SuspendLayout();
            this.tab_Produccion.SuspendLayout();
            this.tp_Notificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notificaciones_Listar)).BeginInit();
            this.tp_Ciclo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ciclo_BorrarID)).BeginInit();
            this.tp_Fertilizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Fertilizacion_IDSector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Fertilizacion_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Produccion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Fondo.Controls.Add(this.tab_Produccion);
            this.pnl_Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Fondo.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold);
            this.pnl_Fondo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(800, 450);
            this.pnl_Fondo.TabIndex = 0;
            // 
            // tab_Produccion
            // 
            this.tab_Produccion.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tab_Produccion.Controls.Add(this.tp_Notificaciones);
            this.tab_Produccion.Controls.Add(this.tp_Ciclo);
            this.tab_Produccion.Controls.Add(this.tp_Fertilizacion);
            this.tab_Produccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Produccion.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.tab_Produccion.Location = new System.Drawing.Point(0, 0);
            this.tab_Produccion.Name = "tab_Produccion";
            this.tab_Produccion.SelectedIndex = 0;
            this.tab_Produccion.Size = new System.Drawing.Size(800, 450);
            this.tab_Produccion.TabIndex = 2;
            // 
            // tp_Notificaciones
            // 
            this.tp_Notificaciones.Controls.Add(this.dgv_Notificaciones_Listar);
            this.tp_Notificaciones.Controls.Add(this.label_Notificaciones_Titulo);
            this.tp_Notificaciones.Location = new System.Drawing.Point(4, 37);
            this.tp_Notificaciones.Name = "tp_Notificaciones";
            this.tp_Notificaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Notificaciones.Size = new System.Drawing.Size(792, 409);
            this.tp_Notificaciones.TabIndex = 0;
            this.tp_Notificaciones.Text = "Notificaciones";
            this.tp_Notificaciones.UseVisualStyleBackColor = true;
            // 
            // dgv_Notificaciones_Listar
            // 
            this.dgv_Notificaciones_Listar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Notificaciones_Listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Notificaciones_Listar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Nombre,
            this.col_Cedula,
            this.col_Sector,
            this.col_Mensaje});
            this.dgv_Notificaciones_Listar.Location = new System.Drawing.Point(31, 109);
            this.dgv_Notificaciones_Listar.Name = "dgv_Notificaciones_Listar";
            this.dgv_Notificaciones_Listar.Size = new System.Drawing.Size(730, 190);
            this.dgv_Notificaciones_Listar.TabIndex = 124;
            // 
            // col_Nombre
            // 
            this.col_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_Nombre.FillWeight = 150F;
            this.col_Nombre.HeaderText = "Nombre";
            this.col_Nombre.Name = "col_Nombre";
            this.col_Nombre.Width = 126;
            // 
            // col_Cedula
            // 
            this.col_Cedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_Cedula.FillWeight = 150F;
            this.col_Cedula.HeaderText = "Cedula";
            this.col_Cedula.Name = "col_Cedula";
            this.col_Cedula.Width = 112;
            // 
            // col_Sector
            // 
            this.col_Sector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_Sector.HeaderText = "Sector";
            this.col_Sector.Name = "col_Sector";
            this.col_Sector.ReadOnly = true;
            this.col_Sector.Width = 106;
            // 
            // col_Mensaje
            // 
            this.col_Mensaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_Mensaje.FillWeight = 150F;
            this.col_Mensaje.HeaderText = "Mensaje";
            this.col_Mensaje.Name = "col_Mensaje";
            this.col_Mensaje.Width = 129;
            // 
            // label_Notificaciones_Titulo
            // 
            this.label_Notificaciones_Titulo.AutoSize = true;
            this.label_Notificaciones_Titulo.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold);
            this.label_Notificaciones_Titulo.Location = new System.Drawing.Point(260, 27);
            this.label_Notificaciones_Titulo.Name = "label_Notificaciones_Titulo";
            this.label_Notificaciones_Titulo.Size = new System.Drawing.Size(276, 41);
            this.label_Notificaciones_Titulo.TabIndex = 18;
            this.label_Notificaciones_Titulo.Text = "Notificaciones";
            // 
            // tp_Ciclo
            // 
            this.tp_Ciclo.Controls.Add(this.pic_Ciclo_BorrarID);
            this.tp_Ciclo.Controls.Add(this.cob_Ciclo_Cultivo);
            this.tp_Ciclo.Controls.Add(this.txt_Ciclo_ID);
            this.tp_Ciclo.Controls.Add(this.lbl_Ciclo_Cultivo);
            this.tp_Ciclo.Controls.Add(this.lbl_Ciclo_Titulo);
            this.tp_Ciclo.Controls.Add(this.btn_Ciclo_Aceptar);
            this.tp_Ciclo.Controls.Add(this.lbl_Ciclo_ID);
            this.tp_Ciclo.Location = new System.Drawing.Point(4, 37);
            this.tp_Ciclo.Name = "tp_Ciclo";
            this.tp_Ciclo.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Ciclo.Size = new System.Drawing.Size(792, 409);
            this.tp_Ciclo.TabIndex = 1;
            this.tp_Ciclo.Text = "Ciclo";
            this.tp_Ciclo.UseVisualStyleBackColor = true;
            // 
            // pic_Ciclo_BorrarID
            // 
            this.pic_Ciclo_BorrarID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Ciclo_BorrarID.BackColor = System.Drawing.Color.IndianRed;
            this.pic_Ciclo_BorrarID.Image = global::_1__Entregra.Properties.Resources.Close;
            this.pic_Ciclo_BorrarID.Location = new System.Drawing.Point(594, 108);
            this.pic_Ciclo_BorrarID.Name = "pic_Ciclo_BorrarID";
            this.pic_Ciclo_BorrarID.Size = new System.Drawing.Size(31, 31);
            this.pic_Ciclo_BorrarID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_Ciclo_BorrarID.TabIndex = 24;
            this.pic_Ciclo_BorrarID.TabStop = false;
            this.pic_Ciclo_BorrarID.Click += new System.EventHandler(this.pic_Ciclo_BorrarID_Click);
            // 
            // cob_Ciclo_Cultivo
            // 
            this.cob_Ciclo_Cultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_Ciclo_Cultivo.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.cob_Ciclo_Cultivo.FormattingEnabled = true;
            this.cob_Ciclo_Cultivo.Items.AddRange(new object[] {
            "Manzana",
            "Limon"});
            this.cob_Ciclo_Cultivo.Location = new System.Drawing.Point(357, 145);
            this.cob_Ciclo_Cultivo.Name = "cob_Ciclo_Cultivo";
            this.cob_Ciclo_Cultivo.Size = new System.Drawing.Size(268, 33);
            this.cob_Ciclo_Cultivo.TabIndex = 32;
            this.cob_Ciclo_Cultivo.Visible = false;
            // 
            // txt_Ciclo_ID
            // 
            this.txt_Ciclo_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Ciclo_ID.ContextMenuStrip = this.cmd_Produccion;
            this.txt_Ciclo_ID.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ciclo_ID.Location = new System.Drawing.Point(327, 108);
            this.txt_Ciclo_ID.MaxLength = 3;
            this.txt_Ciclo_ID.Name = "txt_Ciclo_ID";
            this.txt_Ciclo_ID.Size = new System.Drawing.Size(271, 31);
            this.txt_Ciclo_ID.TabIndex = 21;
            this.txt_Ciclo_ID.TextChanged += new System.EventHandler(this.txt_Ciclo_ID_TextChanged);
            this.txt_Ciclo_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ciclo_ID_KeyPress);
            // 
            // lbl_Ciclo_Cultivo
            // 
            this.lbl_Ciclo_Cultivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Ciclo_Cultivo.AutoSize = true;
            this.lbl_Ciclo_Cultivo.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ciclo_Cultivo.Location = new System.Drawing.Point(175, 148);
            this.lbl_Ciclo_Cultivo.Name = "lbl_Ciclo_Cultivo";
            this.lbl_Ciclo_Cultivo.Size = new System.Drawing.Size(96, 25);
            this.lbl_Ciclo_Cultivo.TabIndex = 31;
            this.lbl_Ciclo_Cultivo.Text = "Cultivo:";
            this.lbl_Ciclo_Cultivo.Visible = false;
            // 
            // lbl_Ciclo_Titulo
            // 
            this.lbl_Ciclo_Titulo.AutoSize = true;
            this.lbl_Ciclo_Titulo.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Ciclo_Titulo.Location = new System.Drawing.Point(298, 27);
            this.lbl_Ciclo_Titulo.Name = "lbl_Ciclo_Titulo";
            this.lbl_Ciclo_Titulo.Size = new System.Drawing.Size(108, 41);
            this.lbl_Ciclo_Titulo.TabIndex = 26;
            this.lbl_Ciclo_Titulo.Text = "Ciclo";
            // 
            // btn_Ciclo_Aceptar
            // 
            this.btn_Ciclo_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Ciclo_Aceptar.AutoSize = true;
            this.btn_Ciclo_Aceptar.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ciclo_Aceptar.Location = new System.Drawing.Point(357, 194);
            this.btn_Ciclo_Aceptar.Name = "btn_Ciclo_Aceptar";
            this.btn_Ciclo_Aceptar.Size = new System.Drawing.Size(126, 43);
            this.btn_Ciclo_Aceptar.TabIndex = 23;
            this.btn_Ciclo_Aceptar.Text = "Sembrar";
            this.btn_Ciclo_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Ciclo_Aceptar.Visible = false;
            this.btn_Ciclo_Aceptar.Click += new System.EventHandler(this.btn_Ciclo_Aceptar_Click);
            // 
            // lbl_Ciclo_ID
            // 
            this.lbl_Ciclo_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Ciclo_ID.AutoSize = true;
            this.lbl_Ciclo_ID.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ciclo_ID.Location = new System.Drawing.Point(175, 108);
            this.lbl_Ciclo_ID.Name = "lbl_Ciclo_ID";
            this.lbl_Ciclo_ID.Size = new System.Drawing.Size(118, 25);
            this.lbl_Ciclo_ID.TabIndex = 19;
            this.lbl_Ciclo_ID.Text = "ID sector:";
            // 
            // tp_Fertilizacion
            // 
            this.tp_Fertilizacion.Controls.Add(this.label1);
            this.tp_Fertilizacion.Controls.Add(this.nud_Fertilizacion_IDSector);
            this.tp_Fertilizacion.Controls.Add(this.nud_Fertilizacion_cantidad);
            this.tp_Fertilizacion.Controls.Add(this.lbl_Fertilizacion_Nitrogeno);
            this.tp_Fertilizacion.Controls.Add(this.rdo_Fosforo);
            this.tp_Fertilizacion.Controls.Add(this.rdo_Nitrogeno);
            this.tp_Fertilizacion.Controls.Add(this.lbl_Fertilizacion_Titulo);
            this.tp_Fertilizacion.Controls.Add(this.btn_Fertilizacion_Calcular);
            this.tp_Fertilizacion.Controls.Add(this.lbl_Fertilizacion_ID);
            this.tp_Fertilizacion.Location = new System.Drawing.Point(4, 37);
            this.tp_Fertilizacion.Name = "tp_Fertilizacion";
            this.tp_Fertilizacion.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Fertilizacion.Size = new System.Drawing.Size(792, 409);
            this.tp_Fertilizacion.TabIndex = 2;
            this.tp_Fertilizacion.Text = "Fertilización";
            this.tp_Fertilizacion.UseVisualStyleBackColor = true;
            // 
            // nud_Fertilizacion_IDSector
            // 
            this.nud_Fertilizacion_IDSector.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.nud_Fertilizacion_IDSector.Location = new System.Drawing.Point(448, 142);
            this.nud_Fertilizacion_IDSector.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nud_Fertilizacion_IDSector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Fertilizacion_IDSector.Name = "nud_Fertilizacion_IDSector";
            this.nud_Fertilizacion_IDSector.Size = new System.Drawing.Size(103, 31);
            this.nud_Fertilizacion_IDSector.TabIndex = 42;
            this.nud_Fertilizacion_IDSector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Fertilizacion_IDSector.Leave += new System.EventHandler(this.nud_Fertilizacion_IDSector_Leave);
            // 
            // nud_Fertilizacion_cantidad
            // 
            this.nud_Fertilizacion_cantidad.DecimalPlaces = 2;
            this.nud_Fertilizacion_cantidad.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.nud_Fertilizacion_cantidad.Location = new System.Drawing.Point(448, 184);
            this.nud_Fertilizacion_cantidad.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nud_Fertilizacion_cantidad.Name = "nud_Fertilizacion_cantidad";
            this.nud_Fertilizacion_cantidad.Size = new System.Drawing.Size(103, 31);
            this.nud_Fertilizacion_cantidad.TabIndex = 41;
            this.nud_Fertilizacion_cantidad.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // lbl_Fertilizacion_Nitrogeno
            // 
            this.lbl_Fertilizacion_Nitrogeno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Fertilizacion_Nitrogeno.AutoSize = true;
            this.lbl_Fertilizacion_Nitrogeno.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fertilizacion_Nitrogeno.Location = new System.Drawing.Point(206, 186);
            this.lbl_Fertilizacion_Nitrogeno.Name = "lbl_Fertilizacion_Nitrogeno";
            this.lbl_Fertilizacion_Nitrogeno.Size = new System.Drawing.Size(236, 25);
            this.lbl_Fertilizacion_Nitrogeno.TabIndex = 40;
            this.lbl_Fertilizacion_Nitrogeno.Text = "Nitrógeno en planta:";
            // 
            // rdo_Fosforo
            // 
            this.rdo_Fosforo.AutoSize = true;
            this.rdo_Fosforo.Location = new System.Drawing.Point(212, 107);
            this.rdo_Fosforo.Name = "rdo_Fosforo";
            this.rdo_Fosforo.Size = new System.Drawing.Size(113, 29);
            this.rdo_Fosforo.TabIndex = 39;
            this.rdo_Fosforo.TabStop = true;
            this.rdo_Fosforo.Text = "Fósforo";
            this.rdo_Fosforo.UseVisualStyleBackColor = true;
            this.rdo_Fosforo.CheckedChanged += new System.EventHandler(this.rdo_Fosforo_CheckedChanged);
            // 
            // rdo_Nitrogeno
            // 
            this.rdo_Nitrogeno.AutoSize = true;
            this.rdo_Nitrogeno.Location = new System.Drawing.Point(412, 107);
            this.rdo_Nitrogeno.Name = "rdo_Nitrogeno";
            this.rdo_Nitrogeno.Size = new System.Drawing.Size(139, 29);
            this.rdo_Nitrogeno.TabIndex = 38;
            this.rdo_Nitrogeno.TabStop = true;
            this.rdo_Nitrogeno.Text = "Nitrógeno";
            this.rdo_Nitrogeno.UseVisualStyleBackColor = true;
            this.rdo_Nitrogeno.CheckedChanged += new System.EventHandler(this.rdo_Nitrogeno_CheckedChanged);
            // 
            // lbl_Fertilizacion_Titulo
            // 
            this.lbl_Fertilizacion_Titulo.AutoSize = true;
            this.lbl_Fertilizacion_Titulo.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Fertilizacion_Titulo.Location = new System.Drawing.Point(273, 27);
            this.lbl_Fertilizacion_Titulo.Name = "lbl_Fertilizacion_Titulo";
            this.lbl_Fertilizacion_Titulo.Size = new System.Drawing.Size(246, 41);
            this.lbl_Fertilizacion_Titulo.TabIndex = 35;
            this.lbl_Fertilizacion_Titulo.Text = "Fertilización";
            // 
            // btn_Fertilizacion_Calcular
            // 
            this.btn_Fertilizacion_Calcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Fertilizacion_Calcular.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fertilizacion_Calcular.Location = new System.Drawing.Point(316, 239);
            this.btn_Fertilizacion_Calcular.Name = "btn_Fertilizacion_Calcular";
            this.btn_Fertilizacion_Calcular.Size = new System.Drawing.Size(126, 43);
            this.btn_Fertilizacion_Calcular.TabIndex = 32;
            this.btn_Fertilizacion_Calcular.Text = "Calcular";
            this.btn_Fertilizacion_Calcular.UseVisualStyleBackColor = true;
            this.btn_Fertilizacion_Calcular.Click += new System.EventHandler(this.btn_Fertilizacion_Calcular_Click);
            // 
            // lbl_Fertilizacion_ID
            // 
            this.lbl_Fertilizacion_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Fertilizacion_ID.AutoSize = true;
            this.lbl_Fertilizacion_ID.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fertilizacion_ID.Location = new System.Drawing.Point(206, 148);
            this.lbl_Fertilizacion_ID.Name = "lbl_Fertilizacion_ID";
            this.lbl_Fertilizacion_ID.Size = new System.Drawing.Size(156, 25);
            this.lbl_Fertilizacion_ID.TabIndex = 28;
            this.lbl_Fertilizacion_ID.Text = "ID del sector:";
            // 
            // err_Produccion
            // 
            this.err_Produccion.ContainerControl = this;
            // 
            // cmd_Produccion
            // 
            this.cmd_Produccion.Name = "cmd_Usuario";
            this.cmd_Produccion.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "...";
            this.label1.Visible = false;
            // 
            // frm_Producción
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Producción";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producción Agricola";
            this.pnl_Fondo.ResumeLayout(false);
            this.tab_Produccion.ResumeLayout(false);
            this.tp_Notificaciones.ResumeLayout(false);
            this.tp_Notificaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notificaciones_Listar)).EndInit();
            this.tp_Ciclo.ResumeLayout(false);
            this.tp_Ciclo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ciclo_BorrarID)).EndInit();
            this.tp_Fertilizacion.ResumeLayout(false);
            this.tp_Fertilizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Fertilizacion_IDSector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Fertilizacion_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Produccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Fondo;
        private System.Windows.Forms.TabControl tab_Produccion;
        private System.Windows.Forms.TabPage tp_Notificaciones;
        private System.Windows.Forms.Label label_Notificaciones_Titulo;
        private System.Windows.Forms.TabPage tp_Fertilizacion;
        private System.Windows.Forms.Label lbl_Fertilizacion_Titulo;
        private System.Windows.Forms.Button btn_Fertilizacion_Calcular;
        private System.Windows.Forms.Label lbl_Fertilizacion_ID;
        private System.Windows.Forms.DataGridView dgv_Notificaciones_Listar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Mensaje;
        private System.Windows.Forms.Label lbl_Fertilizacion_Nitrogeno;
        private System.Windows.Forms.RadioButton rdo_Fosforo;
        private System.Windows.Forms.RadioButton rdo_Nitrogeno;
        private System.Windows.Forms.ErrorProvider err_Produccion;
        private System.Windows.Forms.NumericUpDown nud_Fertilizacion_cantidad;
        private System.Windows.Forms.NumericUpDown nud_Fertilizacion_IDSector;
        private System.Windows.Forms.TabPage tp_Ciclo;
        private System.Windows.Forms.PictureBox pic_Ciclo_BorrarID;
        private System.Windows.Forms.ComboBox cob_Ciclo_Cultivo;
        private System.Windows.Forms.TextBox txt_Ciclo_ID;
        private System.Windows.Forms.Label lbl_Ciclo_Cultivo;
        private System.Windows.Forms.Label lbl_Ciclo_Titulo;
        private System.Windows.Forms.Button btn_Ciclo_Aceptar;
        private System.Windows.Forms.Label lbl_Ciclo_ID;
        private System.Windows.Forms.ContextMenuStrip cmd_Produccion;
        private System.Windows.Forms.Label label1;
    }
}