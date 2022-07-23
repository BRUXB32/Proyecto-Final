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
        #region Variables
        Size login = new Size(621, 326);
        Size noLogin = new Size(988, 491);
        bool visible = true;
        int intentos = 3;
        #endregion
        private void AlAbrirForm(string text1, string text2, bool estado)
        {
            btn_Compra.Text = text1;
            btn_Venta.Text = text2;
            btn_Produccion.Visible = estado;
            btn_Sectores.Visible = estado;
            btn_Datos.Visible = estado;
            pnl_Menu.Enabled = true;
            pnl_Menu.Visible = true;
            pnl_Ingreso.SendToBack();
            pnl_Menu.Dock = DockStyle.Left;
            pnl_Ingreso.BringToFront();
            this.Size = noLogin;
            pnl_ToolBar.BackColor = Color.Blue;
            txt_Cedula.Text = "";
            txt_Contraseña.Text = "";
        }
        public frm_Base()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        #region ToolBar
        private void pnl_ToolBar_MouseMove(object sender, MouseEventArgs e)
        {
            Class_Metodos.ReleaseCapture();
            Class_Metodos.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pic_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Ingreso
        private void txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Numeros(e, "cedula");
        }
        private void txt_Cedula_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Cedula, pic_BorrarCedula);
        }

        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Contraseña(e);
        }
        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Contraseña, pic_BorrarContraseña);
        }

        private void pic_BorrarCedula_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(txt_Cedula);
        }
        private void pic_BorrarContraseña_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(txt_Contraseña);
        }
        private void pic_ContraseñaVisible_Click(object sender, EventArgs e)
        {
            visible = Class_Metodos.PicVisible(visible, txt_Contraseña, pic_ContraseñaVisible);
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (!Class_Metodos.Validacion_Cedula(txt_Cedula.Text))
            {
                MessageBox.Show("Ingrese una cedula valida.", "validación de cedula", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Cedula.Focus();
            }
            else if (Regex.IsMatch(txt_Contraseña.Text, "\\s|^$"))
            {
                MessageBox.Show("Ingrese una contraseña.", "validación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Contraseña.Focus();
            }
            else if (!Regex.IsMatch(txt_Contraseña.Text, "\\d") | !Regex.IsMatch(txt_Contraseña.Text, "[a-zA-ZÀ-ÿ\u00f1\u00d1]") | !Regex.IsMatch(txt_Contraseña.Text, "[^0-9a-zA-ZÀ-ÿ\u00f1\u00d1]") | !Regex.IsMatch(txt_Contraseña.Text, "\\S{6,20}"))
            {
                if (intentos > 0)
                {
                    MessageBox.Show("Contraseña incorrecta", "validación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Contraseña.Focus();
                    intentos--;
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                if (txt_Cedula.Text.Equals("12345672") && txt_Contraseña.Text.Equals("1234A.."))
                {
                    Class_Metodos.AbrirFormulario<frm_Usuario>(pnl_Ingreso, false, lbl_Toolbar_Titulo, "Usuario");
                    AlAbrirForm("Usuarios", "Precios", false);
                }
                else if (txt_Cedula.Text.Equals("10000008") && txt_Contraseña.Text.Equals("1234P.."))
                {
                    Class_Metodos.AbrirFormulario<frm_Compra>(pnl_Ingreso, false, lbl_Toolbar_Titulo, "Compra");
                    AlAbrirForm("Compra", "Venta", true);
                }
                else
                {
                    if (intentos > 0)
                    {
                        MessageBox.Show("Cedula o contraseña incorrecta", "validación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        intentos--;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }
        #endregion
        #region Menu
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            intentos = 3;
            Class_Metodos.formulario.Close();
            pnl_Menu.Visible = false;
            pnl_Menu.Enabled = false;
            pnl_Ingreso.SendToBack();
            pnl_Menu.Dock = DockStyle.None;
            pnl_Ingreso.BringToFront();
            this.Size = login;
            pnl_ToolBar.BackColor = Color.DarkGreen;
            btn_Compra.Text = "Compra";
            btn_Venta.Text = "Venta";
            btn_Produccion.Text = "Produccion";
            txt_Contraseña.PasswordChar = '*';
            lbl_Toolbar_Titulo.Text = "Ingresar";
        }

        private void btn_Compra_Click(object sender, EventArgs e)
        {
            if (btn_Compra.Text.Equals("Usuarios"))
            {
                Class_Metodos.AbrirFormulario<frm_Usuario>(pnl_Ingreso, true, lbl_Toolbar_Titulo, "Usuario");
            }
            else if(btn_Compra.Text.Equals("Compra"))
            {
                Class_Metodos.AbrirFormulario<frm_Compra>(pnl_Ingreso, true, lbl_Toolbar_Titulo, "Compra");
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
                Class_Metodos.AbrirFormulario<frm_Precio>(pnl_Ingreso, true, lbl_Toolbar_Titulo, "Precio");
            }
            else if (btn_Venta.Text.Equals("Venta"))
            {
                Class_Metodos.AbrirFormulario<frm_Venta>(pnl_Ingreso, true, lbl_Toolbar_Titulo, "Venta");
            }
            else
            {
                MessageBox.Show("Si ve este mensaje, es que a surgido un error, contacte con un administrativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }
        private void btn_Producción_Click(object sender, EventArgs e)
        {
            Class_Metodos.AbrirFormulario<frm_Producción>(pnl_Ingreso, true, lbl_Toolbar_Titulo, "Producción");
            
        }
        private void btn_Sectores_Click(object sender, EventArgs e)
        {
            Class_Metodos.AbrirFormulario<frm_Sector>(pnl_Ingreso, true, lbl_Toolbar_Titulo, "Sector");
        }
        private void btn_Datos_Click(object sender, EventArgs e)
        {
            Class_Metodos.AbrirFormulario<frm_Datos>(pnl_Ingreso, true, lbl_Toolbar_Titulo, "Datos");
        }
        #endregion


    }
}
