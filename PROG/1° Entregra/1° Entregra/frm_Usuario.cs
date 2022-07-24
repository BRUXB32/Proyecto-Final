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
        bool correcto;
        bool visible1 = true;
        bool visible2 = true;
        bool visible3 = true;
        bool visible4 = true;
        int listarPor = 0;
        Point Abajo = new Point(326, 360);
        Point Arriba = new Point(326, 326);
        #endregion
        #region Metodos
        private void Administrativo(Label lbl, ComboBox cob, PictureBox pic, Button btn, bool estado)
        {
            lbl.Visible = !estado;
            cob.Visible = !estado;
            if (pic != null)
                pic.Visible = !estado;
        }
        private void HacerVisible(bool estado)
        {
            lbl_Listar_Nombre.Visible = estado;
            lbl_Listar_Contraseña.Visible = estado;
            lbl_Listar_Correo.Visible = estado;
            lbl_Listar_Telefono.Visible = estado;
            lbl_Listar_TipoUsuario.Visible = estado;
            lbl_Listar_Predio.Visible = estado;
            txt_Listar_Nombre.Visible = estado;
            txt_Listar_Contraseña.Visible = estado;
            txt_Listar_Correo.Visible = estado;
            txt_Listar_Telefono.Visible = estado;
            txt_Listar_TipoUsuario.Visible = estado;
            txt_Listar_Predio.Visible = estado;
        }
            
        #endregion

        public frm_Usuario()
        {
            InitializeComponent();
            cob_Agregar_TipoUsuario.SelectedIndex = 0;
            cob_Agregar_Predio.SelectedIndex = 0;
            cob_Modificar_TipoUsuario.SelectedIndex = 0;
            cob_Modificar_Predio.SelectedIndex = 0;
        }

        #region Agregar
        private void txt_Agregar_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Numeros(e, "cedula");
        }
        private void txt_Agregar_Cedula_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Cedula_Leave(err_Usuario,pic_Agregar_BorrarCedula,txt_Agregar_Cedula);
        }
        private void txt_Agregar_Cedula_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Agregar_Cedula, pic_Agregar_BorrarCedula);
        }

        private void txt_Agregar_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Nombre(e, txt_Agregar_Nombre);
        }
        private void txt_Agregar_Nombre_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Nombre_Leave(err_Usuario, pic_Agregar_BorrarNombre, txt_Agregar_Nombre);
        }
        private void txt_Agregar_Nombre_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Agregar_Nombre, pic_Agregar_BorrarNombre);
        }

        private void txt_Agregar_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Contraseña(e);
        }
        private void txt_Agregar_Contraseña_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Contraseña_Leave(err_Usuario, pic_Agregar_ContraseñaVisible, txt_Agregar_Contraseña);
        }
        private void txt_Agregar_Contraseña_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Agregar_Contraseña, pic_Agregar_BorrarContraseña);
        }

        private void txt_Agregar_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Correo(e);
        }
        private void txt_Agregar_Correo_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Correo_Leave(err_Usuario, pic_Agregar_BorrarCorreo, txt_Agregar_Correo);
        }
        private void txt_Agregar_Correo_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Agregar_Correo, pic_Agregar_BorrarCorreo);
        }

        private void txt_Agregar_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Numeros(e, "telefono");
        }
        private void txt_Agregar_Telefono_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Telefono_Leave(err_Usuario, pic_Agregar_BorrarTelefono, txt_Agregar_Telefono);
        }
        private void txt_Agregar_Telefono_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Agregar_Telefono, pic_Agregar_BorrarTelefono);
        }

        private void cob_Agregar_TipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob_Agregar_TipoUsuario.SelectedItem.Equals("Administrativo"))
            {
                Administrativo(lbl_Agregar_Predio, cob_Agregar_Predio, null, btn_Agregar_Aceptar, true);
                btn_Agregar_Aceptar.Location = Class_Metodos.Posición_Debajo(lbl_Agregar_TipoUsuario, btn_Agregar_Aceptar, 34);
            }
            else
            {
                Administrativo(lbl_Agregar_Predio, cob_Agregar_Predio, null, btn_Agregar_Aceptar, false);
                btn_Agregar_Aceptar.Location = Class_Metodos.Posición_Debajo(lbl_Agregar_Predio, btn_Agregar_Aceptar, 34);
            }
        }

        private void pic_Agregar_BorrarCedula_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Agregar_BorrarCedula, txt_Agregar_Cedula);
        }
        private void pic_Agregar_BorrarNombre_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Agregar_BorrarNombre, txt_Agregar_Nombre);
        }
        private void pic_Agregar_BorrarContraseña_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Agregar_ContraseñaVisible, txt_Agregar_Contraseña);
        }
        private void pic_Agregar_BorrarCorreo_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Agregar_BorrarCorreo, txt_Agregar_Correo);
        }
        private void pic_Agregar_BorrarTelefono_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Agregar_BorrarTelefono, txt_Agregar_Telefono);
        }

        private void pic_Agregar_ContraseñaVisible_Click(object sender, EventArgs e)
        {
            visible1 = Class_Metodos.PicVisible(visible1, txt_Agregar_Contraseña, pic_Agregar_ContraseñaVisible);
        }

        private void btn_Agregar_Aceptar_Click(object sender, EventArgs e)
        {
            correcto = Class_Metodos.btnAceptar_Cedula(err_Usuario, pic_Agregar_BorrarCedula, txt_Agregar_Cedula);
            correcto = Class_Metodos.btnAceptar_Nombre(err_Usuario, pic_Agregar_BorrarNombre, txt_Agregar_Nombre, correcto);
            correcto = Class_Metodos.btnAceptar_Contraseña(err_Usuario, pic_Agregar_ContraseñaVisible, txt_Agregar_Contraseña, correcto);
            correcto = Class_Metodos.btnAceptar_Correo(txt_Agregar_Correo, correcto);
            correcto = Class_Metodos.btnAceptar_Telefono(txt_Agregar_Telefono, correcto);
            if (correcto)
            {
                if (txt_Agregar_Cedula.Text.Equals("12345672") || txt_Agregar_Cedula.Text.Equals("10000008"))
                {
                    err_Usuario.SetError(pic_Agregar_BorrarCedula, "Esa cedula ya existe.");
                }
                else
                {
                    MessageBox.Show("Funciona");
                    Class_Metodos.btnAceptar_Limpiar(txt_Agregar_Cedula, txt_Agregar_Nombre, txt_Agregar_Contraseña, txt_Agregar_Correo, txt_Agregar_Telefono);
                }
            }
        }
        #endregion
        #region Borrar
        private void txt_Borrar_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Numeros(e, "cedula");
        }
        private void txt_Borrar_Cedula_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Cedula_Leave(err_Usuario, pic_Borrar_BorrarCedula, txt_Borrar_Cedula);
        }
        private void txt_Borrar_Cedula_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Borrar_Cedula, pic_Borrar_BorrarCedula);
            if (Class_Metodos.Validacion_Cedula(txt_Borrar_Cedula.Text))
            {
                if (txt_Borrar_Cedula.Text.Equals("12345672"))
                {
                    Class_Metodos.DarValor(txt_Borrar_Nombre, txt_Borrar_Contraseña, txt_Borrar_TipoUsuario, txt_Borrar_Correo, txt_Borrar_Telefono, txt_Borrar_Predio, "Administrativo", "1234Adm..", "Administrativo", "administrativo@gmail.com", "123456789", "");
                }
                else if (txt_Borrar_Cedula.Text.Equals("10000008"))
                {
                    Class_Metodos.DarValor(txt_Borrar_Nombre, txt_Borrar_Contraseña, txt_Borrar_TipoUsuario, txt_Borrar_Correo, txt_Borrar_Telefono, txt_Borrar_Predio, "Productor", "1234Pro..", "Productor", "productor@gmail.com", "123456782", "1");
                    txt_Borrar_Predio.Text = "1";
                }
                else
                {
                    Class_Metodos.DarValor(txt_Borrar_Nombre, txt_Borrar_Contraseña, txt_Borrar_TipoUsuario, txt_Borrar_Correo, txt_Borrar_Telefono, txt_Borrar_Predio, "", "", "", "", "", "");
                }
            }
            else
            {
                Class_Metodos.DarValor(txt_Borrar_Nombre, txt_Borrar_Contraseña, txt_Borrar_TipoUsuario, txt_Borrar_Correo, txt_Borrar_Telefono, txt_Borrar_Predio, "", "", "", "", "", "");
            }
        }

        private void pic_Borrar_BorrarCedula_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Borrar_BorrarCedula, txt_Borrar_Cedula);
        }

        private void pic_Borrar_ContraseñaVisible_Click(object sender, EventArgs e)
        {
            visible2 = Class_Metodos.PicVisible(visible2, txt_Borrar_Contraseña, pic_Borrar_ContraseñaVisible);
        }

        private void btn_Borrar_Aceptar_Click(object sender, EventArgs e)
        {
            if (Class_Metodos.btnAceptar_Cedula(err_Usuario, pic_Borrar_BorrarCedula, txt_Borrar_Cedula))
            {
                if (txt_Borrar_Cedula.Text.Equals("12345672") || txt_Borrar_Cedula.Text.Equals("10000008"))
                {
                    MessageBox.Show("Funciona.");
                    Class_Metodos.PicBorrar(err_Usuario, pic_Borrar_BorrarCedula, txt_Borrar_Cedula);
                }
                else
                {
                    err_Usuario.SetError(pic_Borrar_BorrarCedula, "No hay ningun usuario con esa cedula.");
                }
            }
            else
                txt_Borrar_Cedula.Focus();
        }
        #endregion
        #region Modificar
        private void txt_Modificar_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Numeros(e, "cedula");
        }
        private void txt_Modificar_Cedula_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Cedula_Leave(err_Usuario, pic_Modificar_BorrarCedula, txt_Modificar_Cedula);
        }
        private void txt_Modificar_Cedula_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Modificar_Cedula, pic_Modificar_BorrarCedula);
            if (cob_Modificar_Predio.Items.Contains("1"))
            {
                cob_Modificar_Predio.Items.Remove("1");
                cob_Modificar_Predio.SelectedIndex = 0;
            }
            if (Class_Metodos.Validacion_Cedula(txt_Modificar_Cedula.Text))
            {
                if (txt_Modificar_Cedula.Text.Equals("12345672"))
                {
                    Class_Metodos.DarValor(txt_Modificar_Nombre, txt_Modificar_NuevaCedula, txt_Modificar_Contraseña, txt_Modificar_Correo, txt_Modificar_Telefono, null, "Administrativo", "", "1234Adm..", "administrativo@gmail.com", "123456789", null);
                    cob_Modificar_TipoUsuario.SelectedIndex = 3;
                }
                else if (txt_Modificar_Cedula.Text.Equals("10000008"))
                {
                    Class_Metodos.DarValor(txt_Modificar_Nombre, txt_Modificar_NuevaCedula, txt_Modificar_Contraseña, txt_Modificar_Correo, txt_Modificar_Telefono, null, "Productor", "", "1234Pro..", "productor@gmail.com", "123456782", null);
                    cob_Modificar_TipoUsuario.SelectedIndex = 2;
                    cob_Modificar_Predio.Items.Insert(0, "1");
                    cob_Modificar_Predio.SelectedIndex = 0;
                }
                else
                {
                    Class_Metodos.DarValor(txt_Modificar_Nombre, txt_Modificar_NuevaCedula, txt_Modificar_Contraseña, txt_Modificar_Correo, txt_Modificar_Telefono, null, "", "", "", "", "", null);
                    cob_Modificar_TipoUsuario.SelectedIndex = 0;
                }
            }
            else
            {
                Class_Metodos.DarValor(txt_Modificar_Nombre, txt_Modificar_NuevaCedula, txt_Modificar_Contraseña, txt_Modificar_Correo, txt_Modificar_Telefono, null, "", "", "", "", "", null);
                cob_Modificar_TipoUsuario.SelectedIndex = 0;
            }
            err_Usuario.SetError(pic_Modificar_BorrarNuevaCedula, "");
            err_Usuario.SetError(pic_ResetearNombre, "");
            err_Usuario.SetError(pic_Modificar_ContraseñaVisible, "");
            err_Usuario.SetError(pic_ResetearCorreo, "");
            err_Usuario.SetError(pic_ResetearTelefono, "");
        }

        private void txt_Modificar_NuevaCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Numeros(e, "cedula");
        }
        private void txt_Modificar_NuevaCedula_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Cedula_Leave(err_Usuario, pic_Modificar_BorrarNuevaCedula, txt_Modificar_NuevaCedula);
        }
        private void txt_Modificar_NuevaCedula_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Modificar_NuevaCedula, pic_Modificar_BorrarNuevaCedula);
        }

        private void txt_Modificar_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Nombre(e, txt_Modificar_Nombre);
        }
        private void txt_Modificar_Nombre_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Nombre_Leave(err_Usuario, pic_ResetearNombre, txt_Modificar_Nombre);
        }
        private void txt_Modificar_Nombre_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Modificar_Nombre, pic_Modificar_BorrarNombre);
        }

        private void txt_Modificar_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Contraseña(e);
        }
        private void txt_Modificar_Contraseña_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Contraseña_Leave(err_Usuario, pic_Modificar_ContraseñaVisible, txt_Modificar_Contraseña);
        }
        private void txt_Modificar_Contraseña_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Modificar_Contraseña, pic_Modificar_BorrarContraseña);
        }

        private void txt_Modificar_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Correo(e);
        }
        private void txt_Modificar_Correo_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Correo_Leave(err_Usuario, pic_ResetearCorreo, txt_Modificar_Correo);
        }
        private void txt_Modificar_Correo_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Modificar_Correo, pic_Modificar_BorrarCorreo);
        }

        private void txt_Modificar_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Numeros(e, "telefono");
        }
        private void txt_Modificar_Telefono_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Telefono_Leave(err_Usuario, pic_ResetearTelefono, txt_Modificar_Telefono);
        }
        private void txt_Modificar_Telefono_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Modificar_Telefono, pic_Modificar_BorrarTelefono);
        }

        private void cob_Modificar_TipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob_Modificar_TipoUsuario.SelectedItem.Equals("Administrativo"))
            {
                Administrativo(lbl_Modificar_Predio, cob_Modificar_Predio, pic_ResetearPredio, btn_Modificar_Aceptar, true);
                btn_Modificar_Aceptar.Location = Class_Metodos.Posición_Debajo(lbl_Modificar_TipoUsuario, btn_Modificar_Aceptar, 34);
            }
            else
            {
                Administrativo(lbl_Modificar_Predio, cob_Modificar_Predio, pic_ResetearPredio, btn_Modificar_Aceptar, false);
                btn_Modificar_Aceptar.Location = Class_Metodos.Posición_Debajo(lbl_Modificar_Predio, btn_Modificar_Aceptar, 34);
            }

        }

        private void pic_Modificar_BorrarCedula_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Modificar_BorrarCedula, txt_Modificar_Cedula);
        }
        private void pic_Modificar_BorrarNuevaCedula_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Modificar_BorrarNuevaCedula, txt_Modificar_NuevaCedula);
        }
        private void pic_Modificar_BorrarNombre_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Modificar_BorrarNombre, txt_Modificar_Nombre);
        }
        private void pic_Modificar_BorrarContraseña_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Modificar_ContraseñaVisible, txt_Modificar_Contraseña);
        }
        private void pic_Modificar_BorrarCorreo_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Modificar_BorrarCorreo, txt_Modificar_Correo);
        }
        private void pic_Modificar_BorrarTelefono_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Modificar_BorrarTelefono, txt_Modificar_Telefono);
        }

        private void pic_ResetearNombre_Click(object sender, EventArgs e)
        {
            if (Class_Metodos.Validacion_Cedula(txt_Modificar_Cedula.Text))
            {
                if (txt_Modificar_Cedula.Text.Equals("12345672"))
                {
                    txt_Modificar_Nombre.Text = "Administrativo";
                    err_Usuario.SetError(pic_ResetearNombre, "");
                }
                else if (txt_Modificar_Cedula.Text.Equals("10000008"))
                {
                    txt_Modificar_Nombre.Text = "Productor";
                    err_Usuario.SetError(pic_ResetearNombre, "");
                }
                else
                    Class_Metodos.PicBorrar(err_Usuario, pic_ResetearNombre, txt_Modificar_Nombre);
            }
            else
                Class_Metodos.PicBorrar(err_Usuario, pic_ResetearNombre, txt_Modificar_Nombre);
        }
        private void pic_ResetearContraseña_Click(object sender, EventArgs e)
        {
            if (Class_Metodos.Validacion_Cedula(txt_Modificar_Cedula.Text))
            {
                if (txt_Modificar_Cedula.Text.Equals("12345672"))
                {
                    txt_Modificar_Contraseña.Text = "1234Adm..";
                    err_Usuario.SetError(pic_Modificar_ContraseñaVisible, "");
                }
                else if (txt_Modificar_Cedula.Text.Equals("10000008"))
                {
                    txt_Modificar_Contraseña.Text = "1234Pro..";
                    err_Usuario.SetError(pic_Modificar_ContraseñaVisible, "");
                }
                else
                    Class_Metodos.PicBorrar(err_Usuario, pic_Modificar_ContraseñaVisible, txt_Modificar_Contraseña);
            }
            else
                Class_Metodos.PicBorrar(err_Usuario, pic_Modificar_ContraseñaVisible, txt_Modificar_Contraseña);
        }
        private void pic_ResetearCorreo_Click(object sender, EventArgs e)
        {
            if (Class_Metodos.Validacion_Cedula(txt_Modificar_Cedula.Text))
            {
                if (txt_Modificar_Cedula.Text.Equals("12345672"))
                {
                    txt_Modificar_Correo.Text = "administrativo@gmail.com";
                    err_Usuario.SetError(pic_ResetearCorreo, "");
                }
                else if (txt_Modificar_Cedula.Text.Equals("10000008"))
                {
                    txt_Modificar_Correo.Text = "productor@gmail.com";
                    err_Usuario.SetError(pic_ResetearCorreo, "");
                }
                else
                    Class_Metodos.PicBorrar(err_Usuario, pic_ResetearCorreo, txt_Modificar_Correo);
            }
            else
                Class_Metodos.PicBorrar(err_Usuario, pic_ResetearCorreo, txt_Modificar_Correo);
        }
        private void pic_ResetearTelefono_Click(object sender, EventArgs e)
        {
            if (Class_Metodos.Validacion_Cedula(txt_Modificar_Cedula.Text))
            {
                if (txt_Modificar_Cedula.Text.Equals("12345672"))
                {
                    txt_Modificar_Telefono.Text = "123456789";
                    err_Usuario.SetError(pic_ResetearTelefono, "");
                }
                else if (txt_Modificar_Cedula.Text.Equals("10000008"))
                {
                    txt_Modificar_Telefono.Text = "123456782";
                    err_Usuario.SetError(pic_ResetearTelefono, "");
                }
                else
                    Class_Metodos.PicBorrar(err_Usuario, pic_ResetearTelefono, txt_Modificar_Telefono);
            }
            else
                Class_Metodos.PicBorrar(err_Usuario, pic_ResetearTelefono, txt_Modificar_Telefono);
        }
        private void pic_ResetearTipoUsuario_Click(object sender, EventArgs e)
        {
            if (Class_Metodos.Validacion_Cedula(txt_Modificar_Cedula.Text))
            {
                if (txt_Modificar_Cedula.Text.Equals("12345672"))
                {
                    cob_Modificar_TipoUsuario.SelectedIndex = 3;
                }
                else if (txt_Modificar_Cedula.Text.Equals("10000008"))
                {
                    cob_Modificar_TipoUsuario.SelectedIndex = 2;
                }
                else
                    cob_Modificar_TipoUsuario.SelectedIndex = 0;
            }
            else
                cob_Modificar_TipoUsuario.SelectedIndex = 0;
        }
        private void pic_ResetearPredio_Click(object sender, EventArgs e)
        {
            cob_Modificar_Predio.SelectedIndex = 0;
        }

        private void pic_Modificar_ContraseñaVisible_Click(object sender, EventArgs e)
        {
            visible3 = Class_Metodos.PicVisible(visible3, txt_Modificar_Contraseña, pic_Modificar_ContraseñaVisible);
        }

        private void btn_Modificar_Aceptar_Click(object sender, EventArgs e)
        {
            correcto = Class_Metodos.btnAceptar_Cedula(err_Usuario, pic_Modificar_BorrarCedula, txt_Modificar_Cedula);
            correcto = Class_Metodos.btnAceptar_NuevaCedula(err_Usuario, pic_Modificar_BorrarNuevaCedula, txt_Modificar_NuevaCedula);
            correcto = Class_Metodos.btnAceptar_Nombre(err_Usuario, pic_ResetearNombre, txt_Modificar_Nombre, correcto);
            correcto = Class_Metodos.btnAceptar_Contraseña(err_Usuario, pic_Modificar_ContraseñaVisible, txt_Modificar_Contraseña, correcto);
            correcto = Class_Metodos.btnAceptar_Correo(txt_Modificar_Correo, correcto);
            correcto = Class_Metodos.btnAceptar_Telefono(txt_Modificar_Telefono, correcto);
            if (correcto)
            {
                if (txt_Modificar_Cedula.Text.Equals("12345672"))
                {
                    if(txt_Modificar_NuevaCedula.Text.Equals("10000008"))
                        err_Usuario.SetError(pic_Modificar_BorrarNuevaCedula, "Esa cedula ya existe.");
                    else
                    {
                        MessageBox.Show("Funciona");
                        Class_Metodos.PicBorrar(err_Usuario, pic_Modificar_BorrarCedula, txt_Modificar_Cedula);
                    }
                }
                else if (txt_Modificar_Cedula.Text.Equals("10000008"))
                {
                    if (txt_Modificar_NuevaCedula.Text.Equals("12345672"))
                        err_Usuario.SetError(pic_Modificar_BorrarNuevaCedula, "Esa cedula ya existe.");
                    else
                    {
                        MessageBox.Show("Funciona");
                        Class_Metodos.PicBorrar(err_Usuario, pic_Modificar_BorrarCedula, txt_Modificar_Cedula);
                    }
                }
                else
                    err_Usuario.SetError(pic_Modificar_BorrarCedula, "No hay ningun usuario con esa cedula.");
            }
        }
        #endregion
        #region Listar
        private void txt_Listar_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (listarPor == 0)
            {
                Class_Metodos.Validacion_Ingreso_Numeros(e, "cedula");
            }
            else if (listarPor == 1)
            {
                Class_Metodos.Validacion_Ingreso_Nombre(e, txt_Listar_Cedula);
            }
            else
            {
                Class_Metodos.Validacion_Ingreso_Correo(e);
            }
        }
        private void txt_Listar_Cedula_Leave(object sender, EventArgs e)
        {
            if (listarPor == 0)
            {
                Class_Metodos.Cedula_Leave(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula);
            }
            else if (listarPor == 1)
            {
                Class_Metodos.Nombre_Leave(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula);
            }
            else
            {
                Class_Metodos.Correo_Leave(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula);
            }
            
        }
        private void txt_Listar_Cedula_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Listar_Cedula, pic_Listar_BorrarCedula);
            if (listarPor == 0)
                if (Class_Metodos.Validacion_Cedula(txt_Listar_Cedula.Text))
                {
                    if (txt_Listar_Cedula.Text.Equals("12345672"))
                    {
                        Class_Metodos.DarValor(txt_Listar_Nombre, txt_Listar_Contraseña, txt_Listar_TipoUsuario, txt_Listar_Correo, txt_Listar_Telefono, txt_Listar_Predio, "Administrativo", "1234Adm..", "Administrativo", "administrativo@gmail.com", "123456789", "");
                    }
                    else if (txt_Listar_Cedula.Text.Equals("10000008"))
                    {
                        Class_Metodos.DarValor(txt_Listar_Nombre, txt_Listar_Contraseña, txt_Listar_TipoUsuario, txt_Listar_Correo, txt_Listar_Telefono, txt_Listar_Predio, "Productor", "1234Pro..", "Productor", "productor@gmail.com", "123456782", "1");
                    }
                    else
                    {
                        Class_Metodos.DarValor(txt_Listar_Nombre, txt_Listar_Contraseña, txt_Listar_TipoUsuario, txt_Listar_Correo, txt_Listar_Telefono, txt_Listar_Predio, "", "", "", "", "", "");
                    }
                }
                else
                {
                    Class_Metodos.DarValor(txt_Listar_Nombre, txt_Listar_Contraseña, txt_Listar_TipoUsuario, txt_Listar_Correo, txt_Listar_Telefono, txt_Listar_Predio, "", "", "", "", "", "");
                }
        }

        private void pic_Listar_BorrarCedula_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula);
            dgv_Listar.Rows.Clear();
        }

        private void pic_Listar_ContraseñaVisible_Click(object sender, EventArgs e)
        {
            visible4 = Class_Metodos.PicVisible(visible4, txt_Listar_Contraseña, pic_Listar_ContraseñaVisible);
        }

        private void btn_Listar_Modificar_Click(object sender, EventArgs e)
        {
            if (Class_Metodos.btnAceptar_Cedula(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula))
            {
                if (txt_Listar_Cedula.Text.Equals("12345672") || txt_Listar_Cedula.Text.Equals("10000008"))
                {
                    txt_Modificar_Cedula.Text = txt_Listar_Cedula.Text;
                    tab_Usuario.SelectedTab = tp_Modificar;
                    txt_Listar_Cedula.Text = "";
                }
                else
                {
                    err_Usuario.SetError(pic_Borrar_BorrarCedula, "No hay ningun usuario con esa cedula.");
                }
            }
            else
                txt_Listar_Cedula.Focus();
        }
        private void btn_Listar_Borrar_Click(object sender, EventArgs e)
        {
            if (Class_Metodos.btnAceptar_Cedula(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula))
            {
                if (txt_Listar_Cedula.Text.Equals("12345672") || txt_Listar_Cedula.Text.Equals("10000008"))
                {
                    txt_Borrar_Cedula.Text = txt_Listar_Cedula.Text;
                    tab_Usuario.SelectedTab = tp_Borrar;
                    txt_Listar_Cedula.Text = "";
                }
                else
                {
                    err_Usuario.SetError(pic_Borrar_BorrarCedula, "No hay ningun usuario con esa cedula.");
                }
            }
            else
                txt_Listar_Cedula.Focus();
        }

        private void tsmi_Cedula_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula);
            listarPor = Class_Metodos.Tsmi_Click(dgv_Listar, txt_Listar_Cedula, lbl_Listar_Cedula, btn_Listar_Borrar, btn_Listar_Modificar, 0, 8, "Cedula", true);
            HacerVisible(true);
        }
        private void tsmi_Nombre_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula);
            listarPor = Class_Metodos.Tsmi_Click(dgv_Listar, txt_Listar_Cedula, lbl_Listar_Cedula, btn_Listar_Borrar, btn_Listar_Modificar, 1, 60, "Nombre", false);
            HacerVisible(false);
        }
        private void tsmi_Correo_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula);
            listarPor = Class_Metodos.Tsmi_Click(dgv_Listar, txt_Listar_Cedula, lbl_Listar_Cedula, btn_Listar_Borrar, btn_Listar_Modificar, 2, 80, "Correo", false);
            HacerVisible(false);
        }

        #endregion

        
    }
}
