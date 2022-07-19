namespace _1__Entregra
{
    partial class frm_Base
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmd_Login = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnl_ToolBar = new System.Windows.Forms.Panel();
            this.pic_Minimizar = new System.Windows.Forms.PictureBox();
            this.pic_Cerrar = new System.Windows.Forms.PictureBox();
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            this.pnl_Ingreso = new System.Windows.Forms.Panel();
            this.pic_ContraseñaVisible = new System.Windows.Forms.PictureBox();
            this.pic_User = new System.Windows.Forms.PictureBox();
            this.pic_Contraseña = new System.Windows.Forms.PictureBox();
            this.pic_BorrarContraseña = new System.Windows.Forms.PictureBox();
            this.pic_BorrarCedula = new System.Windows.Forms.PictureBox();
            this.lbl_Ingreso = new System.Windows.Forms.Label();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_Sectores = new System.Windows.Forms.Button();
            this.btn_Produccion = new System.Windows.Forms.Button();
            this.btn_Venta = new System.Windows.Forms.Button();
            this.btn_Compra = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Datos = new System.Windows.Forms.Button();
            this.pnl_ToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cerrar)).BeginInit();
            this.pnl_Fondo.SuspendLayout();
            this.pnl_Ingreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ContraseñaVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Contraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BorrarContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BorrarCedula)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_Login
            // 
            this.cmd_Login.Name = "cmd_Login";
            this.cmd_Login.Size = new System.Drawing.Size(61, 4);
            // 
            // pnl_ToolBar
            // 
            this.pnl_ToolBar.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_ToolBar.Controls.Add(this.pic_Minimizar);
            this.pnl_ToolBar.Controls.Add(this.pic_Cerrar);
            this.pnl_ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_ToolBar.Name = "pnl_ToolBar";
            this.pnl_ToolBar.Size = new System.Drawing.Size(621, 41);
            this.pnl_ToolBar.TabIndex = 3;
            this.pnl_ToolBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_ToolBar_MouseMove);
            // 
            // pic_Minimizar
            // 
            this.pic_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Minimizar.Image = global::_1__Entregra.Properties.Resources.Minimize;
            this.pic_Minimizar.Location = new System.Drawing.Point(571, 12);
            this.pic_Minimizar.Name = "pic_Minimizar";
            this.pic_Minimizar.Size = new System.Drawing.Size(16, 16);
            this.pic_Minimizar.TabIndex = 9;
            this.pic_Minimizar.TabStop = false;
            this.pic_Minimizar.Click += new System.EventHandler(this.pic_Minimizar_Click);
            // 
            // pic_Cerrar
            // 
            this.pic_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Cerrar.Image = global::_1__Entregra.Properties.Resources.Close;
            this.pic_Cerrar.Location = new System.Drawing.Point(593, 12);
            this.pic_Cerrar.Name = "pic_Cerrar";
            this.pic_Cerrar.Size = new System.Drawing.Size(16, 16);
            this.pic_Cerrar.TabIndex = 8;
            this.pic_Cerrar.TabStop = false;
            this.pic_Cerrar.Click += new System.EventHandler(this.pic_Cerrar_Click);
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.Controls.Add(this.pnl_Ingreso);
            this.pnl_Fondo.Controls.Add(this.pnl_Menu);
            this.pnl_Fondo.Controls.Add(this.pnl_ToolBar);
            this.pnl_Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Fondo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(621, 326);
            this.pnl_Fondo.TabIndex = 1;
            // 
            // pnl_Ingreso
            // 
            this.pnl_Ingreso.BackColor = System.Drawing.Color.SeaGreen;
            this.pnl_Ingreso.Controls.Add(this.pic_ContraseñaVisible);
            this.pnl_Ingreso.Controls.Add(this.pic_User);
            this.pnl_Ingreso.Controls.Add(this.pic_Contraseña);
            this.pnl_Ingreso.Controls.Add(this.pic_BorrarContraseña);
            this.pnl_Ingreso.Controls.Add(this.pic_BorrarCedula);
            this.pnl_Ingreso.Controls.Add(this.lbl_Ingreso);
            this.pnl_Ingreso.Controls.Add(this.btn_Ingresar);
            this.pnl_Ingreso.Controls.Add(this.txt_Contraseña);
            this.pnl_Ingreso.Controls.Add(this.txt_Cedula);
            this.pnl_Ingreso.Controls.Add(this.lbl_Contraseña);
            this.pnl_Ingreso.Controls.Add(this.lbl_Cedula);
            this.pnl_Ingreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Ingreso.Location = new System.Drawing.Point(0, 41);
            this.pnl_Ingreso.Name = "pnl_Ingreso";
            this.pnl_Ingreso.Size = new System.Drawing.Size(621, 285);
            this.pnl_Ingreso.TabIndex = 6;
            // 
            // pic_ContraseñaVisible
            // 
            this.pic_ContraseñaVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_ContraseñaVisible.BackColor = System.Drawing.Color.Transparent;
            this.pic_ContraseñaVisible.Image = global::_1__Entregra.Properties.Resources.visibilityON;
            this.pic_ContraseñaVisible.Location = new System.Drawing.Point(518, 131);
            this.pic_ContraseñaVisible.Name = "pic_ContraseñaVisible";
            this.pic_ContraseñaVisible.Size = new System.Drawing.Size(31, 31);
            this.pic_ContraseñaVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ContraseñaVisible.TabIndex = 26;
            this.pic_ContraseñaVisible.TabStop = false;
            this.pic_ContraseñaVisible.Click += new System.EventHandler(this.pic_ContraseñaVisible_Click);
            // 
            // pic_User
            // 
            this.pic_User.BackColor = System.Drawing.Color.Transparent;
            this.pic_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_User.Image = global::_1__Entregra.Properties.Resources.Usuario;
            this.pic_User.Location = new System.Drawing.Point(78, 98);
            this.pic_User.Name = "pic_User";
            this.pic_User.Size = new System.Drawing.Size(30, 30);
            this.pic_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_User.TabIndex = 25;
            this.pic_User.TabStop = false;
            // 
            // pic_Contraseña
            // 
            this.pic_Contraseña.BackColor = System.Drawing.Color.Transparent;
            this.pic_Contraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_Contraseña.Image = global::_1__Entregra.Properties.Resources.Password;
            this.pic_Contraseña.Location = new System.Drawing.Point(78, 131);
            this.pic_Contraseña.Name = "pic_Contraseña";
            this.pic_Contraseña.Size = new System.Drawing.Size(30, 30);
            this.pic_Contraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Contraseña.TabIndex = 24;
            this.pic_Contraseña.TabStop = false;
            // 
            // pic_BorrarContraseña
            // 
            this.pic_BorrarContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_BorrarContraseña.BackColor = System.Drawing.Color.IndianRed;
            this.pic_BorrarContraseña.Image = global::_1__Entregra.Properties.Resources.Close;
            this.pic_BorrarContraseña.Location = new System.Drawing.Point(481, 131);
            this.pic_BorrarContraseña.Name = "pic_BorrarContraseña";
            this.pic_BorrarContraseña.Size = new System.Drawing.Size(31, 31);
            this.pic_BorrarContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_BorrarContraseña.TabIndex = 10;
            this.pic_BorrarContraseña.TabStop = false;
            this.pic_BorrarContraseña.Click += new System.EventHandler(this.pic_BorrarContraseña_Click);
            // 
            // pic_BorrarCedula
            // 
            this.pic_BorrarCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_BorrarCedula.BackColor = System.Drawing.Color.IndianRed;
            this.pic_BorrarCedula.Image = global::_1__Entregra.Properties.Resources.Close;
            this.pic_BorrarCedula.Location = new System.Drawing.Point(481, 97);
            this.pic_BorrarCedula.Name = "pic_BorrarCedula";
            this.pic_BorrarCedula.Size = new System.Drawing.Size(31, 31);
            this.pic_BorrarCedula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_BorrarCedula.TabIndex = 9;
            this.pic_BorrarCedula.TabStop = false;
            this.pic_BorrarCedula.Click += new System.EventHandler(this.pic_BorrarCedula_Click);
            // 
            // lbl_Ingreso
            // 
            this.lbl_Ingreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Ingreso.AutoSize = true;
            this.lbl_Ingreso.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ingreso.Location = new System.Drawing.Point(236, 28);
            this.lbl_Ingreso.Name = "lbl_Ingreso";
            this.lbl_Ingreso.Size = new System.Drawing.Size(156, 41);
            this.lbl_Ingreso.TabIndex = 7;
            this.lbl_Ingreso.Text = "Ingreso";
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Ingresar.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.Location = new System.Drawing.Point(358, 179);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(126, 43);
            this.btn_Ingresar.TabIndex = 6;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Contraseña.ContextMenuStrip = this.cmd_Login;
            this.txt_Contraseña.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña.Location = new System.Drawing.Point(266, 131);
            this.txt_Contraseña.MaxLength = 20;
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(218, 31);
            this.txt_Contraseña.TabIndex = 4;
            this.txt_Contraseña.TextChanged += new System.EventHandler(this.txt_Contraseña_TextChanged);
            this.txt_Contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Contraseña_KeyPress);
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Cedula.ContextMenuStrip = this.cmd_Login;
            this.txt_Cedula.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cedula.Location = new System.Drawing.Point(266, 97);
            this.txt_Cedula.MaxLength = 8;
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(218, 31);
            this.txt_Cedula.TabIndex = 3;
            this.txt_Cedula.TextChanged += new System.EventHandler(this.txt_Cedula_TextChanged);
            this.txt_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cedula_KeyPress);
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contraseña.Location = new System.Drawing.Point(114, 131);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(146, 25);
            this.lbl_Contraseña.TabIndex = 2;
            this.lbl_Contraseña.Text = "Contraseña:";
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cedula.Location = new System.Drawing.Point(114, 97);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(95, 25);
            this.lbl_Cedula.TabIndex = 1;
            this.lbl_Cedula.Text = "Cedula:";
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_Menu.Controls.Add(this.btn_Datos);
            this.pnl_Menu.Controls.Add(this.btn_Sectores);
            this.pnl_Menu.Controls.Add(this.btn_Produccion);
            this.pnl_Menu.Controls.Add(this.btn_Venta);
            this.pnl_Menu.Controls.Add(this.btn_Compra);
            this.pnl_Menu.Controls.Add(this.btn_Volver);
            this.pnl_Menu.Enabled = false;
            this.pnl_Menu.Location = new System.Drawing.Point(42, 41);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(188, 285);
            this.pnl_Menu.TabIndex = 4;
            this.pnl_Menu.Visible = false;
            // 
            // btn_Sectores
            // 
            this.btn_Sectores.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Sectores.Location = new System.Drawing.Point(22, 202);
            this.btn_Sectores.Name = "btn_Sectores";
            this.btn_Sectores.Size = new System.Drawing.Size(145, 43);
            this.btn_Sectores.TabIndex = 4;
            this.btn_Sectores.Text = "Sectores";
            this.btn_Sectores.UseVisualStyleBackColor = true;
            this.btn_Sectores.Click += new System.EventHandler(this.btn_Sectores_Click);
            // 
            // btn_Produccion
            // 
            this.btn_Produccion.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Produccion.Location = new System.Drawing.Point(22, 153);
            this.btn_Produccion.Name = "btn_Produccion";
            this.btn_Produccion.Size = new System.Drawing.Size(145, 43);
            this.btn_Produccion.TabIndex = 3;
            this.btn_Produccion.Text = "Producción";
            this.btn_Produccion.UseVisualStyleBackColor = true;
            this.btn_Produccion.Click += new System.EventHandler(this.btn_Producción_Click);
            // 
            // btn_Venta
            // 
            this.btn_Venta.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Venta.Location = new System.Drawing.Point(22, 104);
            this.btn_Venta.Name = "btn_Venta";
            this.btn_Venta.Size = new System.Drawing.Size(145, 43);
            this.btn_Venta.TabIndex = 2;
            this.btn_Venta.Text = "Venta";
            this.btn_Venta.UseVisualStyleBackColor = true;
            this.btn_Venta.Click += new System.EventHandler(this.btn_Venta_Click);
            // 
            // btn_Compra
            // 
            this.btn_Compra.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Compra.Location = new System.Drawing.Point(22, 55);
            this.btn_Compra.Name = "btn_Compra";
            this.btn_Compra.Size = new System.Drawing.Size(145, 43);
            this.btn_Compra.TabIndex = 1;
            this.btn_Compra.Text = "Compra";
            this.btn_Compra.UseVisualStyleBackColor = true;
            this.btn_Compra.Click += new System.EventHandler(this.btn_Compra_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Volver.Location = new System.Drawing.Point(22, 6);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(145, 43);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Datos
            // 
            this.btn_Datos.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Datos.Location = new System.Drawing.Point(22, 251);
            this.btn_Datos.Name = "btn_Datos";
            this.btn_Datos.Size = new System.Drawing.Size(145, 43);
            this.btn_Datos.TabIndex = 5;
            this.btn_Datos.Text = "Datos";
            this.btn_Datos.UseVisualStyleBackColor = true;
            this.btn_Datos.Click += new System.EventHandler(this.btn_Datos_Click);
            // 
            // frm_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(621, 326);
            this.Controls.Add(this.pnl_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_ToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cerrar)).EndInit();
            this.pnl_Fondo.ResumeLayout(false);
            this.pnl_Ingreso.ResumeLayout(false);
            this.pnl_Ingreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ContraseñaVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Contraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BorrarContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BorrarCedula)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmd_Login;
        private System.Windows.Forms.Panel pnl_ToolBar;
        private System.Windows.Forms.PictureBox pic_Minimizar;
        private System.Windows.Forms.PictureBox pic_Cerrar;
        private System.Windows.Forms.Panel pnl_Fondo;
        private System.Windows.Forms.Panel pnl_Menu;
        public System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Panel pnl_Ingreso;
        private System.Windows.Forms.PictureBox pic_BorrarContraseña;
        private System.Windows.Forms.PictureBox pic_BorrarCedula;
        private System.Windows.Forms.Label lbl_Ingreso;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Label lbl_Cedula;
        public System.Windows.Forms.Button btn_Produccion;
        public System.Windows.Forms.Button btn_Venta;
        public System.Windows.Forms.Button btn_Compra;
        private System.Windows.Forms.PictureBox pic_Contraseña;
        private System.Windows.Forms.PictureBox pic_User;
        private System.Windows.Forms.PictureBox pic_ContraseñaVisible;
        public System.Windows.Forms.Button btn_Sectores;
        public System.Windows.Forms.Button btn_Datos;
    }
}

