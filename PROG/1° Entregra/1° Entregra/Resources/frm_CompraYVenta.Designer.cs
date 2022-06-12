namespace _1__Entregra.Resources
{
    partial class frm_CompraYVenta
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
            this.SuspendLayout();
            // 
            // panel_Fondo
            // 
            this.panel_Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Fondo.Location = new System.Drawing.Point(0, 0);
            this.panel_Fondo.Name = "panel_Fondo";
            this.panel_Fondo.Size = new System.Drawing.Size(800, 450);
            this.panel_Fondo.TabIndex = 0;
            // 
            // frm_CompraYVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CompraYVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra y venta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Fondo;
    }
}