using _1__Entregra.Resources;
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
    public partial class frm_Base : Form
    {
        Point izquierda= new Point(549, 12);
        Point derecha = new Point(571, 12);
        Size Login = new Size(621, 326);
        Size NoLogin = new Size(988, 491);
        bool visible=true;

        private void LimpiarLogin()
        {
            txt_Cedula.Text = "";
            txt_Contraseña.Text = "";
            pic_BorrarCedula.BackColor = System.Drawing.Color.IndianRed;
            pic_BorrarContraseña.BackColor = System.Drawing.Color.IndianRed;
        }
        Form formulario;
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            
            formulario = pnl_Ingreso.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnl_Ingreso.Controls.Add(formulario);
                pnl_Ingreso.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        public frm_Base()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnl_ToolBar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pic_Agrandar_Click(object sender, EventArgs e)
        {
            pic_Agrandar.Visible = false;
            pic_Normal.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }
        private void pic_Normal_Click(object sender, EventArgs e)
        {
            pic_Agrandar.Visible = true;
            pic_Normal.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }
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
        private void pic_ContraseñaVisible_Click(object sender, EventArgs e)
        {
            if (visible)
            {
                txt_Contraseña.PasswordChar = '\0';
                pic_ContraseñaVisible.Image = _1__Entregra.Properties.Resources.visibilityOFF;
                visible = false;
            }
            else
            {
                txt_Contraseña.PasswordChar = '*';
                pic_ContraseñaVisible.Image = _1__Entregra.Properties.Resources.visibilityON;
                visible = true;
            }
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
            else if (!Regex.IsMatch(txt_Contraseña.Text, "\\d") | !Regex.IsMatch(txt_Contraseña.Text, "[a-zA-ZÀ-ÿ\u00f1\u00d1]") | !Regex.IsMatch(txt_Contraseña.Text, "[^0-9a-zA-ZÀ-ÿ\u00f1\u00d1]") | !Regex.IsMatch(txt_Contraseña.Text, "\\S{6,20}"))
            {
                MessageBox.Show("La contraseña debe tener al menos 6 digitos, conteniendo letras, numeros y simbolos.", "validación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Contraseña.Focus();
            }
            else
            {
                pic_Minimizar.Location = izquierda;
                pic_Agrandar.Visible = true;
                pnl_Menu.Enabled = true;
                pnl_Menu.Visible = true;
                pnl_Ingreso.SendToBack();
                pnl_Menu.Dock = DockStyle.Left;
                pnl_Ingreso.BringToFront();
                this.Size = NoLogin;
                pnl_ToolBar.BackColor= Color.Blue;
                if (txt_Cedula.Text.Equals("12345678")&&txt_Contraseña.Text.Equals("1234D.."))
                {
                    btn_Compra.Text = "Usuarios";
                    btn_Venta.Text = "Precios";
                    btn_Produccion.Visible = false;
                    btn_Sectores.Visible = false;
                    btn_Produccion.Text = "";
                    AbrirFormulario<frm_Usuario>();
                }
                else
                {
                    btn_Compra.Text = "Compra";
                    btn_Venta.Text = "Venta";
                    btn_Produccion.Visible = true;
                    btn_Sectores.Visible = true;
                    btn_Produccion.Text = "Producción";
                    AbrirFormulario<frm_Compra>();
                }
                LimpiarLogin();
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            formulario.Close();
            pic_Agrandar.Visible = false;
            pic_Normal.Visible= false;
            this.WindowState = FormWindowState.Normal;
            pnl_Menu.Visible = false;
            pnl_Menu.Enabled = false;
            pnl_Ingreso.SendToBack();
            pnl_Menu.Dock = DockStyle.None;
            pnl_Ingreso.BringToFront();
            this.Size = Login;
            pnl_ToolBar.BackColor = Color.DarkGreen;
            pic_Minimizar.Location = derecha;
            btn_Compra.Text = "Compra";
            btn_Venta.Text = "Venta";
            btn_Produccion.Text = "Produccion";
            txt_Contraseña.PasswordChar = '*';
        }

        private void btn_Compra_Click(object sender, EventArgs e)
        {
            if (btn_Compra.Text.Equals("Usuarios"))
            {
                formulario.Close();
                AbrirFormulario<frm_Usuario>();
            }
            else if(btn_Compra.Text.Equals("Compra"))
            {
                formulario.Close();
                AbrirFormulario<frm_Compra>();
            }
            else
            {
                MessageBox.Show("Si ve este mensaje, es que a surgido un error, contacte con un administrativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }
        private void btn_Venta_Click(object sender, EventArgs e)
        {
            if (btn_Venta.Text.Equals("Precios"))
            {
                formulario.Close();
                AbrirFormulario<frm_Precio>();
            }
            else if (btn_Venta.Text.Equals("Venta"))
            {
                formulario.Close();
                AbrirFormulario<frm_Venta>();
            }
            else
            {
                MessageBox.Show("Si ve este mensaje, es que a surgido un error, contacte con un administrativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }
        private void btn_Producción_Click(object sender, EventArgs e)
        {
            if (btn_Produccion.Text.Equals(""))
            {
                formulario.Close();
                //AbrirFormulario<frm_Usuario>();
            }
            else if (btn_Produccion.Text.Equals("Producción"))
            {
                formulario.Close();
                AbrirFormulario<frm_Producción>();
            }
            else
            {
                MessageBox.Show("Si ve este mensaje, es que a surgido un error, contacte con un administrativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }

        private void btn_Sectores_Click(object sender, EventArgs e)
        {
            formulario.Close();
            AbrirFormulario<frm_Sector>();
        }
    }
}
