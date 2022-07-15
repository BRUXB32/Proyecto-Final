using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1__Entregra
{
    internal class Class_Metodos
    {
        static public bool VerificarCedula(String Cedula)
        {
            char[] digitos = Cedula.ToCharArray();
            int Valor = 0;
            int verificador = 0;
            if (Cedula.Length == 8)
            {
                Valor = ((Convert.ToInt32(digitos[0]) - 48) * 2 + (Convert.ToInt32(digitos[1]) - 48) * 9 + (Convert.ToInt32(digitos[2]) - 48) * 8 + (Convert.ToInt32(digitos[3]) - 48) * 7 + (Convert.ToInt32(digitos[4]) - 48) * 6 + (Convert.ToInt32(digitos[5]) - 48) * 3 + (Convert.ToInt32(digitos[6]) - 48) * 4);
                while (Convert.ToDouble(Valor) % 10 != 0)
                {
                    verificador++;
                    Valor++;
                }
                if (verificador == Convert.ToInt32(digitos[7] - 48))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (Cedula.Length == 7)
            {
                Valor = ((Convert.ToInt32(digitos[0]) - 48) * 9 + (Convert.ToInt32(digitos[1]) - 48) * 8 + (Convert.ToInt32(digitos[2]) - 48) * 7 + (Convert.ToInt32(digitos[3]) - 48) * 6 + (Convert.ToInt32(digitos[4]) - 48) * 3 + (Convert.ToInt32(digitos[5]) - 48) * 4);
                while (Convert.ToDouble(Valor) % 10 != 0)
                {
                    verificador++;
                    Valor++;
                }
                if (verificador == Convert.ToInt32(digitos[6] - 48))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static void VerificacionNumeros(KeyPressEventArgs e, String nombre)
        {
            if (e.KeyChar == 22)
            {
                e.Handled = true;
                MessageBox.Show("Pegar esta desabilitado.", "validación de "+ nombre+".", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Solo se admiten datos numéricos.", "validación de "+ nombre+".", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static void VerificarNombre(KeyPressEventArgs e, TextBox txt_nombre)
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
            else if (char.IsSeparator(e.KeyChar) && !(txt_nombre.TextLength == 0))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static void VerificarContraseña(KeyPressEventArgs e)
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
        public static void VerificarCorreo(KeyPressEventArgs e)
        {
            if (e.KeyChar == 22)
            {
                e.Handled = true;
                MessageBox.Show("Pegar esta desabilitado", "validación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (!Regex.IsMatch(Convert.ToString(e.KeyChar), "[.@_a-z1-9-]"))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros, letras minusculas, \".\", \"@\", \"-\" y \"_\"", "validación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static void CedulaLeave(ErrorProvider err, PictureBox pic ,TextBox txt)
        {
            if (!Regex.IsMatch(txt.Text, "^\\d{7,8}$")&& !txt.Text.Equals(""))
            {
                err.SetError(pic, "Tiene que tener 7 o 8 digitos.");
            }
            else if (!Class_Metodos.VerificarCedula(txt.Text) && !txt.Text.Equals(""))
            {
                err.SetError(pic, "Ingrese una cedula valida.");
            }
            else
            {
                err.SetError(pic, "");
            }
        }
        public static void NombreLeave(ErrorProvider err, PictureBox pic, TextBox txt)
        {
            if (!Regex.IsMatch(txt.Text, "^[a-zA-Z0-9À-ÿ\u00f1\u00d1]+(\\s[a-zA-Z0-9À-ÿ\u00f1\u00d1]+)*$") && !(txt.Text == ""))
            {
                err.SetError(pic, "Ingrese un nombre correcto");
            }
            else
            {
                err.SetError(pic, "");
            }
        }
        public static void ContraseñaLeave(ErrorProvider err, PictureBox pic, TextBox txt)
        {
            if ((!Regex.IsMatch(txt.Text, "\\d") | !Regex.IsMatch(txt.Text, "[a-zA-ZÀ-ÿ\u00f1\u00d1]") | !Regex.IsMatch(txt.Text, "[^0-9a-zA-ZÀ-ÿ\u00f1\u00d1]") | !Regex.IsMatch(txt.Text, "\\S{6,20}")) & !txt.Text.Equals(""))
            {
                err_Usuario.SetError(pic_Agregar_ContraseñaVisible, "Debe tener al menos 6 digitos, conteniendo letras, numeros y simbolos.");
            }
            else
            {
                err_Usuario.SetError(pic_Agregar_ContraseñaVisible, "");
            }
        }
        public static void picBorrarColor(TextBox txt, PictureBox pic)
        {
            if (txt.TextLength > 0)
            {
                pic.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                pic.BackColor = System.Drawing.Color.IndianRed;
            }
        }
        public static void picBorrar(ErrorProvider err, PictureBox pic, PictureBox pic2, TextBox txt)
        {
            err.SetError(pic, "");
            txt.Text = "";
            txt.Focus();
            pic2.BackColor = System.Drawing.Color.IndianRed;
        }
        public static void picBorrarAll(ErrorProvider err, PictureBox pic, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4)
        {
            err.SetError(pic, "");
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt1.Focus();
            pic.BackColor = System.Drawing.Color.IndianRed;
        }
    }
}
