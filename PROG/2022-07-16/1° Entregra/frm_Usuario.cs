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
        #endregion

        public frm_Usuario()
        {
            InitializeComponent();
            cob_Agregar_TipoUsuario.SelectedIndex = 0;
            cob_Modificar_TipoUsuario.SelectedIndex = 0;
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
                MessageBox.Show("Funciona");
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
                MessageBox.Show("Funciona");
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
            if (Class_Metodos.Validacion_Cedula(txt_Modificar_Cedula.Text))
            {
                txt_Modificar_NuevaCedula.Text = "";
                txt_Modificar_Nombre.Text = "Dylan";
                txt_Modificar_Contraseña.Text = "1234dylan☺";
                txt_Modificar_Correo.Text = "";
                txt_Modificar_Telefono.Text = "";
                cob_Modificar_TipoUsuario.SelectedIndex = 0;
            }
            else
            {
                txt_Modificar_NuevaCedula.Text = "";
                txt_Modificar_Nombre.Text = "";
                txt_Modificar_Contraseña.Text = "";
                txt_Modificar_Correo.Text = "";
                txt_Modificar_Telefono.Text = "";
                cob_Modificar_TipoUsuario.SelectedIndex = 0;
            }
            err_Usuario.SetError(pic_Modificar_BorrarNuevaCedula, "");
            err_Usuario.SetError(pic_Modificar_BorrarNombre, "");
            err_Usuario.SetError(pic_Modificar_ContraseñaVisible, "");
            err_Usuario.SetError(pic_Modificar_BorrarCorreo, "");
            err_Usuario.SetError(pic_Modificar_BorrarTelefono, "");
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
                MessageBox.Show("Funciona");
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
                txt_Modificar_Cedula.Text = txt_Listar_Cedula.Text;
                tab_Usuario.SelectedTab = tp_Modificar;
                txt_Listar_Cedula.Text = "";
            }
            else
                txt_Listar_Cedula.Focus();
        }
        private void btn_Listar_Borrar_Click(object sender, EventArgs e)
        {
            if (Class_Metodos.btnAceptar_Cedula(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula))
            {
                txt_Borrar_Cedula.Text = txt_Listar_Cedula.Text;
                tab_Usuario.SelectedTab = tp_Borrar;
                txt_Listar_Cedula.Text = "";
            }
            else
                txt_Listar_Cedula.Focus();
        }

        private void tsmi_Cedula_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_All(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula, txt_Listar_Nombre, txt_Listar_Contraseña, txt_Listar_TipoUsuario);
            listarPor = Class_Metodos.Tsmi_Click(dgv_Listar, txt_Listar_Cedula, lbl_Listar_Cedula, btn_Listar_Borrar, btn_Listar_Modificar, 0, 8, "Cedula", true);
        }
        private void tsmi_Nombre_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_All(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula, txt_Listar_Nombre, txt_Listar_Contraseña, txt_Listar_TipoUsuario);
            listarPor = Class_Metodos.Tsmi_Click(dgv_Listar, txt_Listar_Cedula, lbl_Listar_Cedula, btn_Listar_Borrar, btn_Listar_Modificar, 1, 60, "Nombre", false);
        }
        private void tsmi_Correo_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_All(err_Usuario, pic_Listar_BorrarCedula, txt_Listar_Cedula, txt_Listar_Nombre, txt_Listar_Contraseña, txt_Listar_TipoUsuario);
            listarPor = Class_Metodos.Tsmi_Click(dgv_Listar, txt_Listar_Cedula, lbl_Listar_Cedula, btn_Listar_Borrar, btn_Listar_Modificar, 2, 80, "Correo", false);
        }
        #endregion

        

        

        
    }
}
