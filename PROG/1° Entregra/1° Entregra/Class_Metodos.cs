using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1__Entregra
{
    internal class Class_Metodos
    {
        public static Form formulario;
        public static System.Drawing.Point posicion = new System.Drawing.Point(0, 5);

        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public static void AbrirFormulario<MiForm>(Panel pnl, bool cerrar, Label lbl, string text) where MiForm : Form, new()
        {
            if (Class_Metodos.formulario != pnl.Controls.OfType<MiForm>().FirstOrDefault() || !cerrar)
            {
                if (cerrar)
                    Class_Metodos.formulario.Close();
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnl.Controls.Add(formulario);
                pnl.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                lbl.Text = text;
            }
        }
        static public bool Validacion_Cedula(String Cedula)
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
        public static void Validacion_Ingreso_Numeros(KeyPressEventArgs e, String nombre)
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
        public static void Validacion_Ingreso_Nombre(KeyPressEventArgs e, TextBox txt_nombre)
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
        public static void Validacion_Ingreso_Contraseña(KeyPressEventArgs e)
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
        public static void Validacion_Ingreso_Correo(KeyPressEventArgs e)
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
        public static void Cedula_Leave(ErrorProvider err, PictureBox pic ,TextBox txt)
        {
            if (!Regex.IsMatch(txt.Text, "^\\d{7,8}$") && !txt.Text.Equals(""))
            {
                err.SetError(pic, "Tiene que tener 7 o 8 digitos.");
            }
            else if (!Class_Metodos.Validacion_Cedula(txt.Text) && !txt.Text.Equals(""))
            {
                err.SetError(pic, "Ingrese una cedula valida.");
            }
            else
            {
                err.SetError(pic, "");
            }
        }
        public static void Nombre_Leave(ErrorProvider err, PictureBox pic, TextBox txt)
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
        public static void Contraseña_Leave(ErrorProvider err, PictureBox pic, TextBox txt)
        {
            if ((!Regex.IsMatch(txt.Text, "\\d") || !Regex.IsMatch(txt.Text, "[a-zA-ZÀ-ÿ\u00f1\u00d1]") || !Regex.IsMatch(txt.Text, "[^0-9a-zA-ZÀ-ÿ\u00f1\u00d1]") || !Regex.IsMatch(txt.Text, "\\S{8,20}")) && !txt.Text.Equals(""))
            {
                err.SetError(pic, "Debe tener al menos 8 digitos, conteniendo letras, numeros y simbolos.");
            }
            else
            {
                err.SetError(pic, "");
            }
        }
        public static void Correo_Leave(ErrorProvider err, PictureBox pic, TextBox txt)
        {
            if (!Regex.IsMatch(txt.Text, "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$") && !txt.Text.Equals(""))
            {
                err.SetError(pic, "Ingrese un correo valido (de esta forma \"nombre_apellido@gmail.com\")");
            }
            else
            {
                err.SetError(pic, "");
            }
        }
        public static void Telefono_Leave(ErrorProvider err, PictureBox pic, TextBox txt)
        {
            if (!Regex.IsMatch(txt.Text, "^\\d{9}$") && !txt.Text.Equals(""))
            {
                err.SetError(pic, "Tiene que tener 8 digitos.");
            }
            else
            {
                err.SetError(pic, "");
            }
        }
        public static void PicBorrar_Color(TextBox txt, PictureBox pic)
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
        public static void PicBorrar(TextBox txt)
        {
            txt.Text = "";
            txt.Focus();
        } 
        public static void PicBorrar(ErrorProvider err, PictureBox pic, TextBox txt)
        {
            err.SetError(pic, "");
            txt.Text = "";
            txt.Focus();
        }
        public static bool PicVisible(bool visible, TextBox txt, PictureBox pic)
        {
            if (visible)
            {
                txt.PasswordChar = '\0';
                pic.Image = _1__Entregra.Properties.Resources.visibilityOFF;
                return false;
            }
            else
            {
                txt.PasswordChar = '*';
                pic.Image = _1__Entregra.Properties.Resources.visibilityON;
                return true;
            }
        }
        public static bool btnAceptar_Cedula(ErrorProvider err, PictureBox pic, TextBox txt)
        {
            if (!Class_Metodos.Validacion_Cedula(txt.Text))
            {
                if (txt.Text.Equals(""))
                    err.SetError(pic, "Ingrese una cedula");
                return false;
            }
            else
                return true;
        }
        public static bool btnAceptar_NuevaCedula(ErrorProvider err, PictureBox pic, TextBox txt)
        {
            if (!Class_Metodos.Validacion_Cedula(txt.Text) && !txt.Text.Equals(""))
                return false;
            else
                return true;
        }
        public static bool btnAceptar_Nombre(ErrorProvider err, PictureBox pic, TextBox txt, bool estado)
        {
            if (!Regex.IsMatch(txt.Text, "^[a-zA-Z0-9À-ÿ\u00f1\u00d1]+(\\s[a-zA-Z0-9À-ÿ\u00f1\u00d1]+)*$"))
            {
                if (txt.Text.Equals(""))
                    err.SetError(pic, "Ingrese un nombre");
                return false;
            }
            else
                return estado;
        }
        public static bool btnAceptar_Contraseña(ErrorProvider err, PictureBox pic, TextBox txt, bool estado)
        {
            if (!Regex.IsMatch(txt.Text, "\\d") || !Regex.IsMatch(txt.Text, "[a-zA-ZÀ-ÿ\u00f1\u00d1]") || !Regex.IsMatch(txt.Text, "[^0-9a-zA-ZÀ-ÿ\u00f1\u00d1]") || !Regex.IsMatch(txt.Text, "\\S{8,20}"))
            {
                if (txt.Text.Equals(""))
                    err.SetError(pic, "Ingrese una contraseña");
                return false;
            }
            else
                return estado;
        }
        public static bool btnAceptar_Correo(TextBox txt, bool estado)
        {
            if (!Regex.IsMatch(txt.Text, "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$") && !txt.Text.Equals(""))
                return false;
            else
                return estado;
        }
        public static bool btnAceptar_Telefono(TextBox txt, bool estado)
        {
            if (!Regex.IsMatch(txt.Text, "^\\d{9}$") && !txt.Text.Equals(""))
                return false;
            else
                return estado;
        }
        public static void btnAceptar_Limpiar(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt1.Focus();
        }
        public static int Tsmi_Click(DataGridView dgv, TextBox txt, Label lbl, Button btn1, Button btn2, int valor, int Max, string nombre, bool visible)
        {
            dgv.Rows.Clear();
            txt.MaxLength = Max;
            lbl.Text = nombre+":";
            dgv.Visible = !visible;
            btn1.Visible = visible;
            btn2.Visible = visible;
            return valor;
        }
        public static void Etapas(Button btn, Label lbl, String nombre, bool visible)
        {
            btn.Text = nombre;
            btn.Visible= visible;
            lbl.Visible = !visible;
        }
        public static void Calculo_Fertilizante(NumericUpDown nud, decimal critico, decimal valorGe, string tipo, Label lbl)
        {
            if (nud.Value == critico)
                lbl.Text = "No es necesario fertilizar.";
            else
                lbl.Text=("Debe usar " + Convert.ToString((critico - nud.Value) * valorGe) + "kg de " + tipo + ".");
            lbl.Visible = true;
        }
        public static void DarValor(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5, TextBox txt6, string text1, string text2, string text3, string text4, string text5, string text6)
        {
            txt1.Text = text1;
            txt2.Text = text2;
            txt3.Text = text3;
            txt4.Text = text4;
            txt5.Text = text5;
            if(txt6!=null)
            txt6.Text = text6;
        }
        public static System.Drawing.Point Posición_Medio(TabPage tp, Button btn)
        {
            //Coloca el Button horizontalmente en el medio del TabPage
            Class_Metodos.posicion.X = ((tp.Size.Width - btn.Size.Width)/2);
            Class_Metodos.posicion.Y = btn.Location.Y;
            return Class_Metodos.posicion;
        }
        public static System.Drawing.Point Posición_Debajo(Label lbl, Button btn, int num)
        {
            //Coloca el Button verticalmente debajo del Label
            Class_Metodos.posicion.Y = (Convert.ToInt16(lbl.Location.Y) + num);
            Class_Metodos.posicion.X = btn.Location.X;
            return Class_Metodos.posicion;
        }
    }
}
