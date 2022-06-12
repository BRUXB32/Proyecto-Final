using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1__Entregra
{
    public partial class frm_Login : Form
    {
        private void AbrirFormulario<MiForm>(Panel panelformularios) where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        public frm_Login()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_Agrandar_Click(object sender, EventArgs e)
        {
            pic_Agrandar.Visible=false;
            pic_Normal.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }
        private void pic_Normal_Click(object sender, EventArgs e)
        {
            pic_Agrandar.Visible = true;
            pic_Normal.Visible = false;
            this.WindowState = FormWindowState.Normal;
            
        }
        //549
        private void pic_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 22)
            {
                e.Handled = true;
                MessageBox.Show("Pegar esta desabilitado", "validación de cedula", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de cedula", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 22)
            {
                e.Handled = true;
                MessageBox.Show("Pegar esta desabilitado", "validación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se aceptan espacios", "validación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void panel_ToolBar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Cedula.Text = "";
            txt_Contraseña.Text = "";
            txt_Cedula.Focus();
        }

        private void pic_BorrarCedula_Click(object sender, EventArgs e)
        {
            txt_Cedula.Text = "";
            txt_Cedula.Focus();
            pic_BorrarCedula.BackColor = System.Drawing.Color.IndianRed;
        }

        private void pic_BorrarContraseña_Click(object sender, EventArgs e)
        {
            txt_Contraseña.Text = "";
            txt_Contraseña.Focus();
            pic_BorrarContraseña.BackColor = System.Drawing.Color.IndianRed;
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Cedula.Text, "^\\d{8}$"))
            {
                MessageBox.Show("Ingrese una cedula valida.", "validación de cedula", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Cedula.Focus();
            }
            else if (Regex.IsMatch(txt_Contraseña.Text, "\\s|^$"))
            {
                MessageBox.Show("Ingrese una contraseña valida.", "validación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Contraseña.Focus();
            }
            else if(!Regex.IsMatch(txt_Contraseña.Text, "\\d") | !Regex.IsMatch(txt_Contraseña.Text, "[a-zA-ZÀ-ÿ\u00f1\u00d1]") |!Regex.IsMatch(txt_Contraseña.Text, "[^0-9a-zA-ZÀ-ÿ\u00f1\u00d1]") | !Regex.IsMatch(txt_Contraseña.Text, "\\S{6,20}"))
            {
                MessageBox.Show("La contraseña debe tener al menos 6 digitos, conteniendo letras, numeros y simbolos.", "validación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Contraseña.Focus();
            }
            else
            {
                MessageBox.Show("Funciona", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Cedula.Text = "";
                txt_Contraseña.Text = "";
                txt_Cedula.Focus();
                pic_BorrarCedula.BackColor = System.Drawing.Color.IndianRed;
                pic_BorrarContraseña.BackColor = System.Drawing.Color.IndianRed;
                this.Width = 800;
                this.Height = 450;
                AbrirFormulario<Resources.frm_CompraYVenta>(panel_Fondo);
            }
        }

        private void txt_Cedula_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Cedula.TextLength > 0)
            {
                pic_BorrarCedula.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                pic_BorrarCedula.BackColor = System.Drawing.Color.IndianRed;
            }
        }

        private void txt_Contraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Contraseña.TextLength > 0)
            {
                pic_BorrarContraseña.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                pic_BorrarContraseña.BackColor = System.Drawing.Color.IndianRed;
            }
        }
    }
}
