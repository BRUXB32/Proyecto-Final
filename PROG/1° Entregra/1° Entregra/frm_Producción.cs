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
        #region Metodos
        private void SectorActivo(string text, decimal numero)
        {
            lbl_Fertilizacion_Nitrogeno.Text = text;
            nud_Fertilizacion_cantidad.Maximum = numero;
        }
        private void SectorReposo()
        {
            lbl_Fertilizacion_Nitrogeno.Text = "Sector en reposo";
            nud_Fertilizacion_cantidad.Visible = false;
            btn_Fertilizacion_Calcular.Visible = false;
        }
        private void IDVacio(bool vacio)
        {
            lbl_Fertilizacion_Nitrogeno.Visible = vacio;
            nud_Fertilizacion_cantidad.Visible = vacio;
            btn_Fertilizacion_Calcular.Visible = vacio;
        }
        #endregion
        public frm_Producción()
        {
            InitializeComponent();
            rdo_Fosforo.Checked = true;
        }

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
                lbl_Ciclo_Cultivo.Visible = false;
                btn_Ciclo_Aceptar.Visible = false;
            }
            else
            {
                if (Convert.ToInt16(txt_Ciclo_ID.Text) > 4)
                    txt_Ciclo_ID.Text = "4";
                if (Regex.IsMatch(txt_Ciclo_ID.Text, "^1$"))
                {
                    Class_Metodos.Etapas(btn_Ciclo_Aceptar, lbl_Ciclo_Cultivo, "Pazar a Z3.0", true);
                    btn_Ciclo_Aceptar.Location = Class_Metodos.Posición_Medio(tp_Ciclo, btn_Ciclo_Aceptar);
                }
                else if (Regex.IsMatch(txt_Ciclo_ID.Text, "^2$"))
                {
                    Class_Metodos.Etapas(btn_Ciclo_Aceptar, lbl_Ciclo_Cultivo, "Cosechar", true);
                    btn_Ciclo_Aceptar.Location = Class_Metodos.Posición_Medio(tp_Ciclo, btn_Ciclo_Aceptar);
                }
                else
                {
                    Class_Metodos.Etapas(btn_Ciclo_Aceptar, lbl_Ciclo_Cultivo, "", false);
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
                IDVacio(false);
            else
            {
                if (Convert.ToInt16(txt_Fertilizacion_ID.Text) > 4)
                    txt_Fertilizacion_ID.Text = "4";
                IDVacio(true);
                if (rdo_Fosforo.Checked == true)
                {
                    if (txt_Fertilizacion_ID.Text.Equals("1") || txt_Fertilizacion_ID.Text.Equals("2"))
                        SectorActivo("Fósforo en suelo:", 14);
                    else
                        SectorReposo();
                }
                else if (txt_Fertilizacion_ID.Text.Equals("1"))
                    SectorActivo("Nitrógeno en suelo:", 14);
                else if (txt_Fertilizacion_ID.Text.Equals("2"))
                    SectorActivo("Nitrógeno en planta:", 4.2M);
                else
                    SectorReposo();
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
                Class_Metodos.Calculo_Fertilizante(nud_Fertilizacion_cantidad, 14, 10, "fósforo", lbl_Fertilizacion_Resultado);
            }
            else if (rdo_Nitrogeno.Checked == true)
            {
                if (txt_Fertilizacion_ID.Text.Equals("1"))
                {
                    Class_Metodos.Calculo_Fertilizante(nud_Fertilizacion_cantidad, 14, 5, "nitrógeno", lbl_Fertilizacion_Resultado);
                }
                else
                {
                    Class_Metodos.Calculo_Fertilizante(nud_Fertilizacion_cantidad, 4.2M, 45, "nitrógeno", lbl_Fertilizacion_Resultado);
                }
            }
        }
        #endregion
        #region Pesticida
        private void txt_Pesticida_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.Validacion_Ingreso_Numeros(e, "ID");
        }
        private void txt_Pesticida_ID_TextChanged(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar_Color(txt_Pesticida_ID, pic_Pesticida_BorrarID);
            if (txt_Pesticida_ID.Text.Equals(""))
            {
                lbl_Pesticida_Resultado.Visible = false;
            }
            else
            {
                if (Convert.ToInt16(txt_Pesticida_ID.Text) > 4)
                    txt_Pesticida_ID.Text = "4";
                lbl_Pesticida_Resultado.Visible = true;
                if (txt_Pesticida_ID.Text.Equals("1")|| txt_Pesticida_ID.Text.Equals("2"))
                {
                    lbl_Pesticida_Resultado.Text = "Costo en pragicida: 160 dolares";
                }
                else
                {
                    lbl_Pesticida_Resultado.Text = "Sector en reposo";
                }
            }
        }

        private void pic_Pesticida_BorrarID_Click(object sender, EventArgs e)
        {
            Class_Metodos.PicBorrar(err_Produccion, pic_Pesticida_BorrarID, txt_Pesticida_ID);
        }
        #endregion
    }
}
