using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1__Entregra
{
    public partial class frm_Datos : Form
    {
        #region Variables
        bool visible;
        bool correcto;

        #endregion
        public frm_Datos()
        {
            InitializeComponent();
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Nombre(e, txt_Nombre);
        }
        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Nombre, pic_BorrarNombre);
        }
        private void txt_Nombre_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Nombre_Leave(err_Datos, pic_ResetearNombre, txt_Nombre);
        }

        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Contraseña(e);
        }
        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Contraseña, pic_BorrarContraseña);
        }
        private void txt_Contraseña_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Contraseña_Leave(err_Datos, pic_ContraseñaVisible, txt_Contraseña);
        }

        private void txt_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Correo(e);
        }
        private void txt_Correo_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Correo, pic_BorrarCorreo);
        }
        private void txt_Correo_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Correo_Leave(err_Datos, pic_ResetearCorreo, txt_Correo);
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Numeros(e, "telefono");
        }
        private void txt_Telefono_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Telefono, pic_BorrarTelefono);
        }
        private void txt_Telefono_Leave(object sender, EventArgs e)
        {
            Class_Metodos.Telefono_Leave(err_Datos,pic_ResetearTelefono, txt_Telefono);
        }

        private void pic_BorrarNombre_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Datos,pic_ResetearNombre, txt_Nombre);
        }
        private void pic_BorrarContraseña_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Datos, pic_ContraseñaVisible, txt_Contraseña);
        }
        private void pic_BorrarCorreo_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Datos, pic_ResetearCorreo, txt_Correo);
        }
        private void pic_BorrarTelefono_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Datos, pic_ResetearTelefono, txt_Telefono);
        }

        private void pic_ContraseñaVisible_Click(object sender, EventArgs e)
        {
            visible = Class_Metodos.PicVisible(visible, txt_Contraseña, pic_ContraseñaVisible);
        }

        private void pic_ResetearNombre_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Datos, pic_ResetearNombre, txt_Nombre);
            txt_Nombre.Text = "Productor";
        }
        private void pic_ResetearContraseña_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Datos, pic_ContraseñaVisible, txt_Contraseña);
            txt_Contraseña.Text = "1234Pro..";
        }
        private void pic_ResetearCorreo_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Datos, pic_ResetearCorreo, txt_Correo);
            txt_Correo.Text = "productor@gmail.com";
        }
        private void pic_ResetearTelefono_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Datos, pic_ResetearTelefono, txt_Telefono);
            txt_Telefono.Text = "123456782";
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            correcto = true;
            correcto = Class_Metodos.btnAceptar_Nombre(err_Datos, pic_ResetearNombre, txt_Nombre, correcto);
            correcto = Class_Metodos.btnAceptar_Contraseña(err_Datos, pic_ContraseñaVisible, txt_Contraseña, correcto);
            correcto = Class_Metodos.btnAceptar_Correo(txt_Correo, correcto);
            correcto = Class_Metodos.btnAceptar_Telefono(txt_Telefono, correcto);
            if (correcto)
            {
                MessageBox.Show("Funciona");
            }
        }
    }
}
