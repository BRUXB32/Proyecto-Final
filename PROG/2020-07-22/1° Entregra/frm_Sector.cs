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
    public partial class frm_Sector : Form
    {
        public frm_Sector()
        {
            InitializeComponent();
        }

        #region Agregar
        private void btn_Agregar_Agregar_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Funciona");
        }
        #endregion
        #region Borrar
        private void txt_Borrar_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Numeros(e, "ID");
        }
        private void txt_Borrar_ID_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Borrar_ID, pic_Borrar_BorrarID);
            err_Sector.SetError(pic_Borrar_BorrarID, "");
            if (txt_Borrar_ID.Text.Equals(""))
            {
                txt_Borrar_Tamaño.Text = "";
            }
            else
            {
                txt_Borrar_Tamaño.Text = "5";
            }
        }

        private void pic_Borrar_BorrarID_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Sector, pic_Borrar_BorrarID, txt_Borrar_ID);
        }

        private void btn_Borrar_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Borrar_ID.Text.Equals(""))
                err_Sector.SetError(pic_Borrar_BorrarID, "Ingrese una ID");
            else
                MessageBox.Show("Funciona");
        }
        #endregion
        #region Modificar
        private void txt_Modificar_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Numeros(e, "ID");
        }
        private void txt_Modificar_ID_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Modificar_ID, pic_Modificar_BorrarID);
            err_Sector.SetError(pic_Modificar_BorrarID, "");
            if (txt_Modificar_ID.Text.Equals(""))
            {
                nud_Modificar_Tamaño.Value = 1;
            }
            else
            {
                nud_Modificar_Tamaño.Value = 5;
            }
        }

        private void pic_Modificar_BorrarID_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Sector, pic_Modificar_BorrarID, txt_Modificar_ID);
            nud_Modificar_Tamaño.Value = 1;
        }

        private void pic_ResetearTamaño_Click(object sender, EventArgs e)
        {
            if (txt_Modificar_ID.Text.Equals(""))
            {
                nud_Modificar_Tamaño.Value = 1;
            }
            else
            {
                nud_Modificar_Tamaño.Value = 5;
            }
        }

        private void btn_Modificar_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Modificar_ID.Text.Equals(""))
                err_Sector.SetError(pic_Modificar_BorrarID, "Ingrese una ID");
            else
                MessageBox.Show("Funciona");
        }
        #endregion
        #region Listar
        private void txt_Listar_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Numeros(e, "ID");
        }
        private void txt_Listar_ID_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Listar_ID, pic_Listar_BorrarID);
            err_Sector.SetError(pic_Listar_BorrarID, "");
            if (txt_Listar_ID.Text.Equals(""))
            {
                txt_Listar_Tamaño.Text = "";
                txt_Listar_Cultivo.Text = "";
                txt_Listar_Etapa.Text = "";
            }
            else
            {
                txt_Listar_Tamaño.Text = "5";
                txt_Listar_Cultivo.Text = "Manzana";
                txt_Listar_Etapa.Text = "Z2.2";
            }
        }

        private void pic_Listar_BorrarID_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Sector, pic_Listar_BorrarID, txt_Listar_ID);
        }

        private void btn_Listar_Modificar_Click(object sender, EventArgs e)
        {
            if (txt_Listar_ID.Text.Equals(""))
                err_Sector.SetError(pic_Listar_BorrarID, "Ingrese una ID");
            else
            {
                txt_Modificar_ID.Text = txt_Listar_ID.Text;
                tab_Sector.SelectedTab = tp_Modificar;
                pic_Modificar_BorrarID.BackColor = System.Drawing.Color.Firebrick;
                txt_Listar_ID.Text = "";
            }
                
        }
        private void btn_Listar_Borrar_Click(object sender, EventArgs e)
        {
            if (txt_Listar_ID.Text.Equals(""))
                err_Sector.SetError(pic_Listar_BorrarID, "Ingrese una ID");
            else
            {
                txt_Borrar_ID.Text = txt_Listar_ID.Text;
                tab_Sector.SelectedTab = tp_Borrar;
                pic_Borrar_BorrarID.BackColor = System.Drawing.Color.Firebrick;
                txt_Listar_ID.Text = "";
            }
        }
        #endregion

        
    }
}
