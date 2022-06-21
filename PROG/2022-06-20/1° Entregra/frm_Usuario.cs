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
    public partial class frm_Usuario : Form
    {
        bool Correcto;
        bool visible1 = true;
        bool visible2 = true;
        bool visible3 = true;
        bool visible4 = true;

        public frm_Usuario()
        {
            InitializeComponent();
        }

        private void frm_Usuario_Load(object sender, EventArgs e)
        {
            cob_Agregar_TipoUsuario.SelectedIndex = 0;
            cob_Modificar_TipoUsuario.SelectedIndex = 0;
        }

        #region Agregar
        private void txt_Agregar_Cedula_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_Agregar_Cedula_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Agregar_Cedula.TextLength > 0)
            {
                pic_Agregar_BorrarCedula.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                pic_Agregar_BorrarCedula.BackColor = System.Drawing.Color.IndianRed;
            }
        }
        private void txt_Agregar_Cedula_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Agregar_Cedula.Text, "^\\d{8}$") && !txt_Agregar_Cedula.Text.Equals(""))
            {
                Correcto = false;
                err_Usuario.SetError(pic_Agregar_BorrarCedula, "Tiene que tener 8 digitos.");
            }
            else
            {
                err_Usuario.SetError(pic_Agregar_BorrarCedula, "");
            }
        }

        private void txt_Agregar_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 22)
            {
                e.Handled = true;
                MessageBox.Show("Pegar esta desabilitado", "validación de nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar) && !(txt_Agregar_Nombre.TextLength == 0))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txt_Agregar_Nombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Agregar_Nombre.TextLength > 0)
            {
                pic_Agregar_BorrarNombre.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                pic_Agregar_BorrarNombre.BackColor = System.Drawing.Color.IndianRed;
            }
        }
        private void txt_Agregar_Nombre_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Agregar_Nombre.Text, "^[a-zA-Z0-9À-ÿ\u00f1\u00d1]+(\\s[a-zA-Z0-9À-ÿ\u00f1\u00d1]+)*$") && !(txt_Agregar_Nombre.Text == ""))
            {
                err_Usuario.SetError(pic_Agregar_BorrarNombre, "Ingrese un nombre correcto");
            }
            else
            {
                err_Usuario.SetError(pic_Agregar_BorrarNombre, "");
            }
        }

        private void txt_Agregar_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_Agregar_Contraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Agregar_Contraseña.TextLength > 0)
            {
                pic_Agregar_BorrarContraseña.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                pic_Agregar_BorrarContraseña.BackColor = System.Drawing.Color.IndianRed;
            }
        }
        private void txt_Agregar_Contraseña_Leave(object sender, EventArgs e)
        {
            if ((!Regex.IsMatch(txt_Agregar_Contraseña.Text, "\\d") | !Regex.IsMatch(txt_Agregar_Contraseña.Text, "[a-zA-ZÀ-ÿ\u00f1\u00d1]") | !Regex.IsMatch(txt_Agregar_Contraseña.Text, "[^0-9a-zA-ZÀ-ÿ\u00f1\u00d1]") | !Regex.IsMatch(txt_Agregar_Contraseña.Text, "\\S{6,20}")) & !txt_Agregar_Contraseña.Text.Equals(""))
            {
                err_Usuario.SetError(pic_Agregar_ContraseñaVisible, "Debe tener al menos 6 digitos, conteniendo letras, numeros y simbolos.");
            }
            else
            {
                err_Usuario.SetError(pic_Agregar_ContraseñaVisible, "");
            }
        }

        private void pic_Agregar_BorrarCedula_Click(object sender, EventArgs e)
        {
            err_Usuario.SetError(pic_Agregar_BorrarCedula, "");
            txt_Agregar_Cedula.Text = "";
            txt_Agregar_Cedula.Focus();
            pic_Agregar_BorrarCedula.BackColor = System.Drawing.Color.IndianRed;
        }
        private void pic_Agregar_BorrarNombre_Click(object sender, EventArgs e)
        {
            txt_Agregar_Nombre.Text = "";
            txt_Agregar_Nombre.Focus();
            err_Usuario.SetError(pic_Agregar_BorrarNombre, "");
            pic_Agregar_BorrarNombre.BackColor = System.Drawing.Color.IndianRed;
        }
        private void pic_Agregar_BorrarContraseña_Click(object sender, EventArgs e)
        {
            err_Usuario.SetError(pic_Agregar_ContraseñaVisible, "");
            txt_Agregar_Contraseña.Text = "";
            txt_Agregar_Contraseña.Focus();
            pic_Agregar_BorrarContraseña.BackColor = System.Drawing.Color.IndianRed;
        }

        private void pic_Agregar_ContraseñaVisible_Click(object sender, EventArgs e)
        {
            if (visible1)
            {
                txt_Agregar_Contraseña.PasswordChar = '\0';
                pic_Agregar_ContraseñaVisible.Image = _1__Entregra.Properties.Resources.visibilityOFF;
                visible1 = false;
            }
            else
            {
                txt_Agregar_Contraseña.PasswordChar = '*';
                pic_Agregar_ContraseñaVisible.Image = _1__Entregra.Properties.Resources.visibilityON;
                visible1 = true;
            }
        }

        private void btn_Agregar_Aceptar_Click(object sender, EventArgs e)
        {

            Correcto = true;
            if (!Regex.IsMatch(txt_Agregar_Cedula.Text, "^\\d{8}$"))
            {
                Correcto = false;
                if(txt_Agregar_Cedula.Text.Equals(""))
                err_Usuario.SetError(pic_Agregar_BorrarCedula, "Ingrese una cedula");
            }
            if (!Regex.IsMatch(txt_Agregar_Contraseña.Text, "\\d") | !Regex.IsMatch(txt_Agregar_Contraseña.Text, "[a-zA-ZÀ-ÿ\u00f1\u00d1]") | !Regex.IsMatch(txt_Agregar_Contraseña.Text, "[^0-9a-zA-ZÀ-ÿ\u00f1\u00d1]") | !Regex.IsMatch(txt_Agregar_Contraseña.Text, "\\S{6,20}"))
            {
                Correcto = false;
                if(txt_Agregar_Contraseña.Text.Equals(""))
                err_Usuario.SetError(pic_Agregar_ContraseñaVisible, "Ingrese una contraseña");
            }
            if (!Regex.IsMatch(txt_Agregar_Nombre.Text, "^[a-zA-Z0-9À-ÿ\u00f1\u00d1]+(\\s[a-zA-Z0-9À-ÿ\u00f1\u00d1]+)*$"))
            {
                Correcto = false;
                if (txt_Agregar_Nombre.Text.Equals(""))
                err_Usuario.SetError(pic_Agregar_BorrarNombre, "Ingrese un nombre");
            }
            if (Correcto)
            {
                MessageBox.Show("Funciona");
            }
        }
        #endregion
        #region Borrar
        private void txt_Borrar_Cedula_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_Borrar_Cedula_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Borrar_Cedula.TextLength > 0)
            {
                pic_Borrar_BorrarCedula.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                pic_Borrar_BorrarCedula.BackColor = System.Drawing.Color.IndianRed;
            }
        }
        private void txt_Borrar_Cedula_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Borrar_Cedula.Text, "^\\d{8}$") && !txt_Borrar_Cedula.Text.Equals(""))
            {
                Correcto = false;
                err_Usuario.SetError(pic_Borrar_BorrarCedula, "Tiene que tener 8 digitos.");
            }
            else
            {
                err_Usuario.SetError(pic_Borrar_BorrarCedula, "");
            }
        }

        private void pic_Borrar_BorrarCedula_Click(object sender, EventArgs e)
        {
            err_Usuario.SetError(pic_Borrar_BorrarCedula, "");
            txt_Borrar_Cedula.Text = "";
            txt_Borrar_Nombre.Text = "";
            txt_Borrar_Contraseña.Text = "";
            txt_Borrar_TipoUsuario.Text = "";
            txt_Borrar_Cedula.Focus();
            pic_Borrar_BorrarCedula.BackColor = System.Drawing.Color.IndianRed;
        }

        private void pic_Borrar_ContraseñaVisible_Click(object sender, EventArgs e)
        {
            if (visible2)
            {
                txt_Borrar_Contraseña.PasswordChar = '\0';
                pic_Borrar_ContraseñaVisible.Image = _1__Entregra.Properties.Resources.visibilityOFF;
                visible2 = false;
            }
            else
            {
                txt_Borrar_Contraseña.PasswordChar = '*';
                pic_Borrar_ContraseñaVisible.Image = _1__Entregra.Properties.Resources.visibilityON;
                visible2 = true;
            }
        }

        private void btn_Borrar_Aceptar_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Borrar_Cedula.Text, "^\\d{8}$"))
            {
                if (txt_Borrar_Cedula.Text.Equals(""))
                    err_Usuario.SetError(pic_Borrar_BorrarCedula, "Ingrese una cedula");
                txt_Borrar_Cedula.Focus();
            }
            else
            {
                txt_Borrar_Cedula.Text = "";
                MessageBox.Show("Funciona");
            }
        }
        #endregion
        #region Modificar
        private void txt_Modificar_Cedula_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_Modificar_Cedula_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Modificar_Cedula.TextLength > 0)
            {
                pic_Modificar_BorrarCedula.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                pic_Modificar_BorrarCedula.BackColor = System.Drawing.Color.IndianRed;
            }
        }
        private void txt_Modificar_Cedula_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Modificar_Cedula.Text, "^\\d{8}$") && !txt_Modificar_Cedula.Text.Equals(""))
            {
                Correcto = false;
                err_Usuario.SetError(pic_Modificar_BorrarCedula, "Tiene que tener 8 digitos.");
            }
            else
            {
                err_Usuario.SetError(pic_Modificar_BorrarCedula, "");
            }
        }

        private void txt_Modificar_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 22)
            {
                e.Handled = true;
                MessageBox.Show("Pegar esta desabilitado", "validación de nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar) && !(txt_Modificar_Nombre.TextLength == 0))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txt_Modificar_Nombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Modificar_Nombre.TextLength > 0)
            {
                pic_Modificar_BorrarNombre.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                pic_Modificar_BorrarNombre.BackColor = System.Drawing.Color.IndianRed;
            }
        }
        private void txt_Modificar_Nombre_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Modificar_Nombre.Text, "^[a-zA-Z0-9À-ÿ\u00f1\u00d1]+(\\s[a-zA-Z0-9À-ÿ\u00f1\u00d1]+)*$") && !(txt_Modificar_Nombre.Text == ""))
            {
                err_Usuario.SetError(pic_Modificar_BorrarNombre, "Ingrese un nombre correcto");
            }
            else
            {
                err_Usuario.SetError(pic_Modificar_BorrarNombre, "");
            }
        }

        private void txt_Modificar_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_Modificar_Contraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Modificar_Contraseña.TextLength > 0)
            {
                pic_Modificar_BorrarContraseña.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                pic_Modificar_BorrarContraseña.BackColor = System.Drawing.Color.IndianRed;
            }
        }
        private void txt_Modificar_Contraseña_Leave(object sender, EventArgs e)
        {
            if ((!Regex.IsMatch(txt_Modificar_Contraseña.Text, "\\d") | !Regex.IsMatch(txt_Modificar_Contraseña.Text, "[a-zA-ZÀ-ÿ\u00f1\u00d1]") | !Regex.IsMatch(txt_Modificar_Contraseña.Text, "[^0-9a-zA-ZÀ-ÿ\u00f1\u00d1]") | !Regex.IsMatch(txt_Modificar_Contraseña.Text, "\\S{6,20}")) & !txt_Modificar_Contraseña.Text.Equals(""))
            {
                err_Usuario.SetError(pic_Modificar_ContraseñaVisible, "Debe tener al menos 6 digitos, conteniendo letras, numeros y simbolos.");
            }
            else
            {
                err_Usuario.SetError(pic_Modificar_ContraseñaVisible, "");
            }
        }

        private void pic_Modificar_BorrarCedula_Click(object sender, EventArgs e)
        {
            err_Usuario.SetError(pic_Modificar_BorrarCedula, "");
            txt_Modificar_Cedula.Text = "";
            txt_Modificar_Cedula.Focus();
            pic_Modificar_BorrarCedula.BackColor = System.Drawing.Color.IndianRed;
        }
        private void pic_Modificar_BorrarNombre_Click(object sender, EventArgs e)
        {
            txt_Modificar_Nombre.Text = "";
            txt_Modificar_Nombre.Focus();
            err_Usuario.SetError(pic_Modificar_BorrarNombre, "");
            pic_Modificar_BorrarNombre.BackColor = System.Drawing.Color.IndianRed;
        }
        private void pic_Modificar_BorrarContraseña_Click(object sender, EventArgs e)
        {
            err_Usuario.SetError(pic_Modificar_ContraseñaVisible, "");
            txt_Modificar_Contraseña.Text = "";
            txt_Modificar_Contraseña.Focus();
            pic_Modificar_BorrarContraseña.BackColor = System.Drawing.Color.IndianRed;
        }

        private void pic_Modificar_ContraseñaVisible_Click(object sender, EventArgs e)
        {
            if (visible3)
            {
                txt_Modificar_Contraseña.PasswordChar = '\0';
                pic_Modificar_ContraseñaVisible.Image = _1__Entregra.Properties.Resources.visibilityOFF;
                visible3 = false;
            }
            else
            {
                txt_Modificar_Contraseña.PasswordChar = '*';
                pic_Modificar_ContraseñaVisible.Image = _1__Entregra.Properties.Resources.visibilityON;
                visible3 = true;
            }
        }

        private void btn_Modificar_Aceptar_Click(object sender, EventArgs e)
        {
            Correcto = true;
            if (!Regex.IsMatch(txt_Modificar_Cedula.Text, "^\\d{8}$"))
            {
                Correcto = false;
                if (txt_Modificar_Cedula.Text.Equals(""))
                    err_Usuario.SetError(pic_Modificar_BorrarCedula, "Ingrese una cedula");
            }
            if (!Regex.IsMatch(txt_Modificar_Contraseña.Text, "\\d") | !Regex.IsMatch(txt_Modificar_Contraseña.Text, "[a-zA-ZÀ-ÿ\u00f1\u00d1]") | !Regex.IsMatch(txt_Modificar_Contraseña.Text, "[^0-9a-zA-ZÀ-ÿ\u00f1\u00d1]") | !Regex.IsMatch(txt_Modificar_Contraseña.Text, "\\S{6,20}"))
            {
                Correcto = false;
                if (txt_Modificar_Contraseña.Text.Equals(""))
                    err_Usuario.SetError(pic_Modificar_ContraseñaVisible, "Ingrese una contraseña");
            }
            if (!Regex.IsMatch(txt_Modificar_Nombre.Text, "^[a-zA-Z0-9À-ÿ\u00f1\u00d1]+(\\s[a-zA-Z0-9À-ÿ\u00f1\u00d1]+)*$"))
            {
                Correcto = false;
                if (txt_Modificar_Nombre.Text.Equals(""))
                    err_Usuario.SetError(pic_Modificar_BorrarNombre, "Ingrese un nombre");
            }
            if (Correcto)
            {
                MessageBox.Show("Funciona");
            }
        }
        #endregion
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
        }
        private void txt_Listar_Cedula_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Listar_Cedula.Text, "^\\d{8}$") && !txt_Listar_Cedula.Text.Equals(""))
            {
                Correcto = false;
                err_Usuario.SetError(pic_Listar_BorrarCedula, "Tiene que tener 8 digitos.");
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
            if (visible4)
            {
                txt_Listar_Contraseña.PasswordChar = '\0';
                pic_Listar_ContraseñaVisible.Image = _1__Entregra.Properties.Resources.visibilityOFF;
                visible4 = false;
            }
            else
            {
                txt_Listar_Contraseña.PasswordChar = '*';
                pic_Listar_ContraseñaVisible.Image = _1__Entregra.Properties.Resources.visibilityON;
                visible4 = true;
            }
        }

        private void btn_Listar_Borrar_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Listar_Cedula.Text, "^\\d{8}$"))
            {
                if (txt_Listar_Cedula.Text.Equals(""))
                    err_Usuario.SetError(pic_Listar_BorrarCedula, "Ingrese una cedula");
                txt_Listar_Cedula.Focus();
            }
            else
            {
                txt_Borrar_Cedula.Text = txt_Listar_Cedula.Text;
                tab_Usuario.SelectedTab = tp_Borrar;
                pic_Borrar_BorrarCedula.BackColor = System.Drawing.Color.Firebrick;
                txt_Listar_Cedula.Text = "";

            }
        }
        private void btn_Listar_Modificar_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Listar_Cedula.Text, "^\\d{8}$"))
            {
                if (txt_Listar_Cedula.Text.Equals(""))
                    err_Usuario.SetError(pic_Listar_BorrarCedula, "Ingrese una cedula");
                txt_Listar_Cedula.Focus();
            }
            else
            {
                txt_Modificar_Cedula.Text = txt_Listar_Cedula.Text;
                tab_Usuario.SelectedTab = tp_Modificar;
                pic_Modificar_BorrarCedula.BackColor = System.Drawing.Color.Firebrick;
                txt_Listar_Cedula.Text = "";
            }
        }
        #endregion

    }
}
