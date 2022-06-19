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
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Fondo.Controls.Add(this.label1);
            this.pnl_Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Fondo.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold);
            this.pnl_Fondo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(800, 450);
            this.pnl_Fondo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producción";
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
            this.pnl_Fondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Fondo;
        private System.Windows.Forms.Label label1;
    }
}