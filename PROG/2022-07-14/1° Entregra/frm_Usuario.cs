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
        #region Variables
        bool Correcto;
        bool visible1 = true;
        bool visible2 = true;
        bool visible3 = true;
        bool visible4 = true;
        int ListarPor = 0;
        #endregion

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
            Class_Metodos.VerificacionNumeros(e, "cedula");
        }
        private void txt_Agregar_Cedula_KeyUp(object sender, KeyEventArgs e)
        {
            Class_Metodos.picBorrarColor(txt_Agregar_Cedula, pic_Agregar_BorrarCedula);
        }
        private void txt_Agregar_Cedula_Leave(object sender, EventArgs e)
        {
            Class_Metodos.CedulaLeave(err_Usuario,pic_Agregar_BorrarCedula,txt_Agregar_Cedula);
        }

        private void txt_Agregar_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.VerificarNombre(e, txt_Agregar_Nombre);
        }
        private void txt_Agregar_Nombre_KeyUp(object sender, KeyEventArgs e)
        {
            Class_Metodos.picBorrarColor(txt_Agregar_Nombre, pic_Agregar_BorrarNombre);
        }
        private void txt_Agregar_Nombre_Leave(object sender, EventArgs e)
        {
            Class_Metodos.NombreLeave(err_Usuario, pic_Agregar_BorrarNombre, txt_Agregar_Nombre);
        }

        private void txt_Agregar_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.VerificarContraseña(e);
        }
        private void txt_Agregar_Contraseña_KeyUp(object sender, KeyEventArgs e)
        {
            Class_Metodos.picBorrarColor(txt_Agregar_Contraseña, pic_Agregar_BorrarContraseña);
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

        private void txt_Agregar_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.VerificarCorreo(e);
        }
        private void txt_Agregar_Correo_KeyUp(object sender, KeyEventArgs e)
        {
            Class_Metodos.picBorrarColor(txt_Agregar_Correo, pic_Agregar_BorrarCorreo);
        }
        private void txt_Agregar_Correo_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Agregar_Correo.Text, "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$") & !txt_Agregar_Correo.Text.Equals(""))
            {
                err_Usuario.SetError(pic_Agregar_BorrarCorreo, "Ingrese un correo valido (de esta forma \"nombre_apellido@gmail.com\")");
            }
            else
            {
                err_Usuario.SetError(pic_Agregar_BorrarCorreo, "");
            }
        }

        private void txt_Agregar_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.VerificacionNumeros(e, "telefono");
        }
        private void txt_Agregar_Telefono_KeyUp(object sender, KeyEventArgs e)
        {
            Class_Metodos.picBorrarColor(txt_Agregar_Telefono, pic_Agregar_BorrarTelefono);
        }
        private void txt_Agregar_Telefono_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Agregar_Telefono.Text, "^\\d{9}$") && !txt_Agregar_Telefono.Text.Equals(""))
            {
                Correcto = false;
                err_Usuario.SetError(pic_Agregar_BorrarTelefono, "Tiene que tener 8 digitos.");
            }
            else
            {
                err_Usuario.SetError(pic_Agregar_BorrarTelefono, "");
            }
        }

        private void pic_Agregar_BorrarCedula_Click(object sender, EventArgs e)
        {
            Class_Metodos.picBorrar(err_Usuario, pic_Agregar_BorrarCedula, pic_Agregar_BorrarCedula, txt_Agregar_Cedula);
        }
        private void pic_Agregar_BorrarNombre_Click(object sender, EventArgs e)
        {
            Class_Metodos.picBorrar(err_Usuario, pic_Agregar_BorrarNombre, pic_Agregar_BorrarNombre, txt_Agregar_Nombre);
        }
        private void pic_Agregar_BorrarContraseña_Click(object sender, EventArgs e)
        {
            Class_Metodos.picBorrar(err_Usuario, pic_Agregar_ContraseñaVisible, pic_Agregar_BorrarContraseña, txt_Agregar_Contraseña);
        }
        private void pic_Agregar_BorrarCorreo_Click(object sender, EventArgs e)
        {
            Class_Metodos.picBorrar(err_Usuario, pic_Agregar_BorrarCorreo, pic_Agregar_BorrarCorreo, txt_Agregar_Correo);
        }
        private void pic_Agregar_BorrarTelefono_Click(object sender, EventArgs e)
        {
            Class_Metodos.picBorrar(err_Usuario, pic_Agregar_BorrarTelefono, pic_Agregar_BorrarTelefono, txt_Agregar_Telefono);
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
            if (!Class_Metodos.VerificarCedula(txt_Agregar_Cedula.Text))
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
            if (!Regex.IsMatch(txt_Agregar_Correo.Text, "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$") & !txt_Agregar_Correo.Text.Equals(""))
                Correcto = false;
            if (!Regex.IsMatch(txt_Agregar_Telefono.Text, "^\\d{9}$") && !txt_Agregar_Telefono.Text.Equals(""))
                Correcto = false;
            if (Correcto)
            {
                MessageBox.Show("Funciona");
            }
        }
        #endregion
        #region Borrar
        private void txt_Borrar_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.VerificacionNumeros(e, "cedula");
        }
        private void txt_Borrar_Cedula_KeyUp(object sender, KeyEventArgs e)
        {
            Class_Metodos.picBorrarColor(txt_Borrar_Cedula, pic_Borrar_BorrarCedula);
            if (txt_Borrar_Cedula.TextLength == 8)
            {
                txt_Borrar_Nombre.Text = "Dylan";
                txt_Borrar_Contraseña.Text = "1234dylan☺";
                txt_Borrar_TipoUsuario.Text = "Administrativo";
            }
            else
            {
                txt_Borrar_Nombre.Text = "";
                txt_Borrar_Contraseña.Text = "";
                txt_Borrar_TipoUsuario.Text = "";
            }
        }
        private void txt_Borrar_Cedula_Leave(object sender, EventArgs e)
        {
            Class_Metodos.CedulaLeave(err_Usuario, pic_Borrar_BorrarCedula, txt_Borrar_Cedula);
        }

        private void pic_Borrar_BorrarCedula_Click(object sender, EventArgs e)
        {
            Class_Metodos.picBorrarAll(err_Usuario, pic_Borrar_BorrarCedula, txt_Borrar_Cedula, txt_Borrar_Nombre, txt_Borrar_Contraseña, txt_Borrar_TipoUsuario);
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
            if (!Class_Metodos.VerificarCedula(txt_Borrar_Cedula.Text))
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
            Class_Metodos.VerificacionNumeros(e, "cedula");
        }
        private void txt_Modificar_Cedula_KeyUp(object sender, KeyEventArgs e)
        {
            Class_Metodos.picBorrarColor(txt_Modificar_Cedula, pic_Modificar_BorrarCedula);
            if (txt_Modificar_Cedula.TextLength == 8)
            {
                txt_Modificar_Nombre.Text = "Dylan";
                txt_Modificar_Contraseña.Text = "1234dylan☺";
                cob_Modificar_TipoUsuario.SelectedIndex = 0;
                pic_Modificar_BorrarNombre.BackColor = System.Drawing.Color.Firebrick;
                pic_Modificar_BorrarContraseña.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                txt_Modificar_Nombre.Text = "";
                txt_Modificar_Contraseña.Text = "";
                cob_Modificar_TipoUsuario.SelectedIndex = 0;
                pic_Modificar_BorrarNombre.BackColor = System.Drawing.Color.IndianRed;
                pic_Modificar_BorrarContraseña.BackColor = System.Drawing.Color.IndianRed;
            }
            err_Usuario.SetError(pic_Modificar_BorrarNombre, "");
            err_Usuario.SetError(pic_Modificar_ContraseñaVisible, "");
        }
        private void txt_Modificar_Cedula_Leave(object sender, EventArgs e)
        {
            Class_Metodos.CedulaLeave(err_Usuario, pic_Modificar_BorrarCedula, txt_Modificar_Cedula);
        }

        private void txt_Modificar_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.VerificarNombre(e, txt_Modificar_Nombre);
        }
        private void txt_Modificar_Nombre_KeyUp(object sender, KeyEventArgs e)
        {
            Class_Metodos.picBorrarColor(txt_Modificar_Nombre, pic_Modificar_BorrarNombre);
        }
        private void txt_Modificar_Nombre_Leave(object sender, EventArgs e)
        {
            Class_Metodos.NombreLeave(err_Usuario, pic_Modificar_BorrarNombre, txt_Modificar_Nombre);
        }

        private void txt_Modificar_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.VerificarContraseña(e);
        }
        private void txt_Modificar_Contraseña_KeyUp(object sender, KeyEventArgs e)
        {
            Class_Metodos.picBorrarColor(txt_Modificar_Contraseña, pic_Modificar_BorrarContraseña);
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

        private void txt_Modificar_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.VerificarCorreo(e);
        }
        private void txt_Modificar_Correo_KeyUp(object sender, KeyEventArgs e)
        {
            Class_Metodos.picBorrarColor(txt_Modificar_Correo, pic_Modificar_BorrarCorreo);
        }
        private void txt_Modificar_Correo_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Modificar_Correo.Text, "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$") & !txt_Modificar_Correo.Text.Equals(""))
            {
                err_Usuario.SetError(pic_Modificar_BorrarCorreo, "Ingrese un correo valido (de esta forma \"nombre_apellido@gmail.com\")");
            }
            else
            {
                err_Usuario.SetError(pic_Modificar_BorrarCorreo, "");
            }
        }

        private void txt_Modificar_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.VerificacionNumeros(e, "telefono");
        }
        private void txt_Modificar_Telefono_KeyUp(object sender, KeyEventArgs e)
        {
            Class_Metodos.picBorrarColor(txt_Modificar_Telefono, pic_Modificar_BorrarTelefono);
        }
        private void txt_Modificar_Telefono_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Modificar_Telefono.Text, "^\\d{9}$") && !txt_Modificar_Telefono.Text.Equals(""))
            {
                Correcto = false;
                err_Usuario.SetError(pic_Modificar_BorrarTelefono, "Tiene que tener 8 digitos.");
            }
            else
            {
                err_Usuario.SetError(pic_Modificar_BorrarTelefono, "");
            }
        }

        private void pic_Modificar_BorrarCedula_Click(object sender, EventArgs e)
        {
            Class_Metodos.picBorrarAll(err_Usuario, pic_Modificar_BorrarCedula, txt_Modificar_Cedula, txt_Modificar_Nombre, txt_Modificar_Contraseña, txt_Modificar_Contraseña);
            err_Usuario.SetError(pic_Modificar_BorrarNombre, "");
            err_Usuario.SetError(pic_Modificar_ContraseñaVisible, "");
            cob_Modificar_TipoUsuario.SelectedIndex = 0;
            pic_Modificar_BorrarNombre.BackColor = System.Drawing.Color.IndianRed;
            pic_Modificar_BorrarContraseña.BackColor = System.Drawing.Color.IndianRed;
        }
        private void pic_Modificar_BorrarNombre_Click(object sender, EventArgs e)
        {
            Class_Metodos.picBorrar(err_Usuario, pic_Modificar_BorrarNombre, pic_Modificar_BorrarNombre, txt_Modificar_Nombre);
        }
        private void pic_Modificar_BorrarContraseña_Click(object sender, EventArgs e)
        {
            Class_Metodos.picBorrar(err_Usuario, pic_Modificar_ContraseñaVisible, pic_Modificar_BorrarContraseña, txt_Modificar_Contraseña);
        }
        private void pic_Modificar_BorrarCorreo_Click(object sender, EventArgs e)
        {
            Class_Metodos.picBorrar(err_Usuario, pic_Modificar_BorrarCorreo, pic_Modificar_BorrarCorreo, txt_Modificar_Correo);
        }
        private void pic_Modificar_BorrarTelefono_Click(object sender, EventArgs e)
        {
            Class_Metodos.picBorrar(err_Usuario, pic_Modificar_BorrarTelefono, pic_Modificar_BorrarTelefono, txt_Modificar_Telefono);
        }

        private void pic_ResetearNombre_Click(object sender, EventArgs e)
        {
            if (txt_Modificar_Cedula.TextLength == 8)
            {
                err_Usuario.SetError(pic_Modificar_BorrarNombre, "");
                txt_Modificar_Nombre.Text = "Dylan";
                pic_Modificar_BorrarNombre.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                err_Usuario.SetError(pic_Modificar_BorrarNombre, "");
                txt_Modificar_Nombre.Text = "";
                pic_Modificar_BorrarNombre.BackColor = System.Drawing.Color.IndianRed;
            }
        }
        private void pic_ResetearContraseña_Click(object sender, EventArgs e)
        {
            if (txt_Modificar_Cedula.TextLength == 8)
            {
                err_Usuario.SetError(pic_Modificar_ContraseñaVisible, "");
                txt_Modificar_Contraseña.Text = "1234dylan☺";
                pic_Modificar_BorrarContraseña.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                err_Usuario.SetError(pic_Modificar_ContraseñaVisible, "");
                txt_Modificar_Contraseña.Text = "";
                pic_Modificar_BorrarContraseña.BackColor = System.Drawing.Color.IndianRed;
            }
        }
        private void pic_ResetearTipoUsuario_Click(object sender, EventArgs e)
        {
            if (txt_Modificar_Cedula.TextLength == 8)
            {
                cob_Modificar_TipoUsuario.SelectedIndex = 0;
            }
            else
            {
                cob_Modificar_TipoUsuario.SelectedIndex = 0;
            }
        }
        private void pic_ResetearCorreo_Click(object sender, EventArgs e)
        {

        }
        private void pic_ResetearTelefono_Click(object sender, EventArgs e)
        {

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
            if (!Class_Metodos.VerificarCedula(txt_Modificar_Cedula.Text))
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
            if (ListarPor == 0)
            {
                Class_Metodos.VerificacionNumeros(e, "cedula");
            }
            else if (ListarPor == 1)
            {
                Class_Metodos.VerificarNombre(e, txt_Agregar_Nombre);
            }
            else
            {
                Class_Metodos.VerificarCorreo(e);
            }
        }
        private void txt_Listar_Cedula_KeyUp(object sender, KeyEventArgs e)
        {
            Class_Metodos.picBorrarColor(txt_Listar_Cedula, pic_Listar_BorrarCedula);
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
            Class_Metodos.CedulaLeave(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula);
        }

        private void pic_Listar_BorrarCedula_Click(object sender, EventArgs e)
        {
            Class_Metodos.picBorrarAll(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula, txt_Listar_Nombre, txt_Listar_Contraseña, txt_Listar_TipoUsuario);
            dgv_Listar.Rows.Clear();
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

        private void btn_Listar_Modificar_Click(object sender, EventArgs e)
        {
            if (!Class_Metodos.VerificarCedula(txt_Listar_Cedula.Text))
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
        private void btn_Listar_Borrar_Click(object sender, EventArgs e)
        {
            if (!Class_Metodos.VerificarCedula(txt_Listar_Cedula.Text))
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

        private void tsmi_Cedula_Click(object sender, EventArgs e)
        {
            Class_Metodos.picBorrarAll(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula, txt_Listar_Nombre, txt_Listar_Contraseña, txt_Listar_TipoUsuario);
            dgv_Listar.Rows.Clear();
            ListarPor = 0;
            txt_Listar_Cedula.MaxLength = 8;
            lbl_Listar_Cedula.Text = "Cedula:";
            dgv_Listar.Visible = false;
            btn_Listar_Borrar.Visible = true;
            btn_Listar_Modificar.Visible = true;
        }
        private void tsmi_Nombre_Click(object sender, EventArgs e)
        {
            Class_Metodos.picBorrarAll(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula, txt_Listar_Nombre, txt_Listar_Contraseña, txt_Listar_TipoUsuario);
            dgv_Listar.Rows.Clear();
            ListarPor = 1;
            txt_Listar_Cedula.MaxLength = 60;
            lbl_Listar_Cedula.Text = "Nombre:";
            dgv_Listar.Visible = true;
            btn_Listar_Borrar.Visible = false;
            btn_Listar_Modificar.Visible = false;
        }
        private void tsmi_Correo_Click(object sender, EventArgs e)
        {
            Class_Metodos.picBorrarAll(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula, txt_Listar_Nombre, txt_Listar_Contraseña, txt_Listar_TipoUsuario);
            dgv_Listar.Rows.Clear();
            ListarPor = 2;
            txt_Listar_Cedula.MaxLength = 80;
            lbl_Listar_Cedula.Text = "Correo:";
            dgv_Listar.Visible = true;
            btn_Listar_Borrar.Visible = false;
            btn_Listar_Modificar.Visible = false;
        }
        #endregion

    }
}
