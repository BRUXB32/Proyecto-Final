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

namespace _1__Entregra.Resources
{
    public partial class frm_Producción : Form
    {
        #region Variables
        Size isquierda = new Size(126, 43);
        Size derecha = new Size(184, 43);
        Point abajo = new Point(357, 194);
        Point arriba = new Point(357, 148);
        #endregion
        public frm_Producción()
        {
            InitializeComponent();
            rdo_Fosforo.Checked = true;
            cob_Ciclo_Cultivo.SelectedIndex = 0;
        }

        #region Fertilizacion
        private void rdo_Fosforo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Fosforo.Checked == true)
            {
                lbl_Fertilizacion_Nitrogeno.Text = "Fósforo en suelo:";
                nud_Fertilizacion_cantidad.Maximum = 14;
            }
        }
        private void rdo_Nitrogeno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Nitrogeno.Checked == true)
            {
                if (txt_Fertilizacion_ID.Text.Equals("1"))
                {
                    lbl_Fertilizacion_Nitrogeno.Text = "Nitrógeno en suelo:";
                    nud_Fertilizacion_cantidad.Maximum = 14;
                }
                else
                {
                    lbl_Fertilizacion_Nitrogeno.Text = "Nitrógeno en planta:";
                    nud_Fertilizacion_cantidad.Maximum = 4.2M;
                }
            }
        }

        private void txt_Fertilizacion_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Numeros(e, "ID");
        }
        private void txt_Fertilizacion_ID_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Fertilizacion_ID, pic_Fertilizacion_BorrarID);
            if (txt_Fertilizacion_ID.Text.Equals(""))
            {
                lbl_Fertilizacion_Nitrogeno.Visible = false;
                nud_Fertilizacion_cantidad.Visible = false;
                btn_Fertilizacion_Calcular.Visible = false;
            }
            else
            {
                lbl_Fertilizacion_Nitrogeno.Visible = true;
                nud_Fertilizacion_cantidad.Visible = true;
                btn_Fertilizacion_Calcular.Visible = true;
                if (rdo_Fosforo.Checked == true)
                {
                    nud_Fertilizacion_cantidad.Maximum = 14;
                }
                else if (txt_Fertilizacion_ID.Text.Equals("1"))
                {
                    lbl_Fertilizacion_Nitrogeno.Text = "Nitrógeno en suelo:";
                    nud_Fertilizacion_cantidad.Maximum = 14;
                }
                else
                {
                    lbl_Fertilizacion_Nitrogeno.Text = "Nitrógeno en planta:";
                    nud_Fertilizacion_cantidad.Maximum = 4.2M;
                }
            }
        }

        private void pic_Fertilizacion_BorrarID_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Produccion, pic_Fertilizacion_BorrarID, txt_Fertilizacion_ID);
        }

        private void btn_Fertilizacion_Calcular_Click(object sender, EventArgs e)
        {
            if (rdo_Fosforo.Checked == true)
            {
                Class_Metodos.Calculo_Fertilizante(nud_Fertilizacion_cantidad, 14, 10, "fósforo", label1);
            }
            else if (rdo_Nitrogeno.Checked == true)
            {
                if (txt_Fertilizacion_ID.Text.Equals("1"))
                {
                    Class_Metodos.Calculo_Fertilizante(nud_Fertilizacion_cantidad, 14, 5, "nitrógeno", label1);
                }
                else
                {
                    Class_Metodos.Calculo_Fertilizante(nud_Fertilizacion_cantidad, 4.2M, 45, "nitrógeno", label1);
                }
            }
        }
        #endregion
        #region Ciclo
        private void txt_Ciclo_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Numeros(e, "ID");
        }
        private void txt_Ciclo_ID_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Ciclo_ID, pic_Ciclo_BorrarID);
            if (txt_Ciclo_ID.Text.Equals(""))
            {
                Class_Metodos.Etapas(btn_Ciclo_Aceptar, lbl_Ciclo_Cultivo, cob_Ciclo_Cultivo, "", abajo, false);
                btn_Ciclo_Aceptar.Visible = false;
            }
            else
            {
                btn_Ciclo_Aceptar.Visible = true;
                if (Regex.IsMatch(txt_Ciclo_ID.Text, "^1$"))
                {
                    Class_Metodos.Etapas(btn_Ciclo_Aceptar, lbl_Ciclo_Cultivo, cob_Ciclo_Cultivo, "Sembrar", abajo, true);
                }
                else if (Regex.IsMatch(txt_Ciclo_ID.Text, "^2$"))
                {
                    Class_Metodos.Etapas(btn_Ciclo_Aceptar, lbl_Ciclo_Cultivo, cob_Ciclo_Cultivo, "Pazar a Z2.2", arriba, false);
                }
                else if (Regex.IsMatch(txt_Ciclo_ID.Text, "^3$"))
                {
                    Class_Metodos.Etapas(btn_Ciclo_Aceptar, lbl_Ciclo_Cultivo, cob_Ciclo_Cultivo, "Pazar a Z3.0", arriba, false);
                }
                else
                {
                    Class_Metodos.Etapas(btn_Ciclo_Aceptar, lbl_Ciclo_Cultivo, cob_Ciclo_Cultivo, "Cosechar", arriba, false);
                }
            }
        }

        private void pic_Ciclo_BorrarID_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Produccion, pic_Ciclo_BorrarID, txt_Ciclo_ID);
        }

        private void btn_Ciclo_Aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funciona");
            txt_Ciclo_ID.Text = "";
        }
        #endregion
        
    }
}
