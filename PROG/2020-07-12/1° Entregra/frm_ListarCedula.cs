using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1__Entregra
{
    public partial class frm_ListarCedula : Form
    {
        bool visible = true;
        public frm_ListarCedula()
        {
            InitializeComponent();
        }

        #region Listar
        private void txt_Listar_Cedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Listar_Cedula_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Listar_Cedula.TextLength > 0)
            {
                pic_Listar_BorrarCedula.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                pic_Listar_BorrarCedula.BackColor = System.Drawing.Color.IndianRed;
            }
            if (txt_Listar_Cedula.TextLength == 8)
            {
                txt_Listar_Nombre.Text = "Dylan";
                txt_Listar_Contraseña.Text = "1234dylan☺";
                txt_Listar_TipoUsuario.Text = "Administrativo";
            }
            else
            {
                txt_Listar_Nombre.Text = "";
                txt_Listar_Contraseña.Text = "";
                txt_Listar_TipoUsuario.Text = "";
            }
        }

        private void txt_Listar_Cedula_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Listar_Cedula.Text, "^\\d{8}$") && !Regex.IsMatch(txt_Listar_Cedula.Text, "^\\d{7}$") && !txt_Listar_Cedula.Text.Equals(""))
            {
                err_Usuario.SetError(pic_Listar_BorrarCedula, "Tiene que tener 8 digitos.");
            }
            else if (!frm_Usuario.VerificarCedula(txt_Listar_Cedula.Text) && !txt_Listar_Cedula.Text.Equals(""))
            {
                err_Usuario.SetError(pic_Listar_BorrarCedula, "Ingrese una cedula valida.");
            }
            else
            {
                err_Usuario.SetError(pic_Listar_BorrarCedula, "");
            }
        }

        private void pic_Listar_BorrarCedula_Click(object sender, EventArgs e)
        {
            err_Usuario.SetError(pic_Listar_BorrarCedula, "");
            txt_Listar_Cedula.Text = "";
            txt_Listar_Nombre.Text = "";
            txt_Listar_Contraseña.Text = "";
            txt_Listar_TipoUsuario.Text = "";
            txt_Listar_Cedula.Focus();
            pic_Listar_BorrarCedula.BackColor = System.Drawing.Color.IndianRed;
        }

        private void pic_Listar_ContraseñaVisible_Click(object sender, EventArgs e)
        {
            if (visible)
            {
                txt_Listar_Contraseña.PasswordChar = '\0';
                pic_Listar_ContraseñaVisible.Image = _1__Entregra.Properties.Resources.visibilityOFF;
                visible = false;
            }
            else
            {
                txt_Listar_Contraseña.PasswordChar = '*';
                pic_Listar_ContraseñaVisible.Image = _1__Entregra.Properties.Resources.visibilityON;
                visible = true;
            }
        }

        private void btn_Listar_Modificar_Click(object sender, EventArgs e)
        {
            if (!frm_Usuario.VerificarCedula(txt_Listar_Cedula.Text))
            {
                if (txt_Listar_Cedula.Text.Equals(""))
                    err_Usuario.SetError(pic_Listar_BorrarCedula, "Ingrese una cedula");
                txt_Listar_Cedula.Focus();
            }
            else
            {
                //txt_Modificar_Cedula.Text = txt_Listar_Cedula.Text;
                //tab_Usuario.SelectedTab = tp_Modificar;
                //pic_Modificar_BorrarCedula.BackColor = System.Drawing.Color.Firebrick;
                txt_Listar_Cedula.Text = "";
            }
        }

        private void btn_Listar_Borrar_Click(object sender, EventArgs e)
        {
            if (!frm_Usuario.VerificarCedula(txt_Listar_Cedula.Text))
            {
                if (txt_Listar_Cedula.Text.Equals(""))
                    err_Usuario.SetError(pic_Listar_BorrarCedula, "Ingrese una cedula");
                txt_Listar_Cedula.Focus();
            }
            else
            {
                //txt_Borrar_Cedula.Text = txt_Listar_Cedula.Text;
                //tab_Usuario.SelectedTab = tp_Borrar;
                //pic_Borrar_BorrarCedula.BackColor = System.Drawing.Color.Firebrick;
                txt_Listar_Cedula.Text = "";
            }
        }
        #endregion
    }
}
