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
        private void Calculo(double critico, double valorGe, string tipo)
        {
            if (Convert.ToDouble(nud_Fertilizacion_cantidad.Value) == critico)
                MessageBox.Show("No es necesario fertilizar.");
            else
            {
                MessageBox.Show("Debe usar " + Convert.ToString((critico - Convert.ToDouble(nud_Fertilizacion_cantidad.Value)) * valorGe) + "kg de " + tipo + ".");
            }

        }
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
                lbl_Fertilizacion_Nitrogeno.Text = "Nitrógeno en suelo:";
                if (nud_Fertilizacion_IDSector.Value == 1)
                {
                    nud_Fertilizacion_cantidad.Maximum = 14;
                }
                else
                {
                    nud_Fertilizacion_cantidad.Maximum = 4.2M;
                }
            }
        }

        private void nud_Fertilizacion_IDSector_Leave(object sender, EventArgs e)
        {
            if (rdo_Fosforo.Checked == true)
            {
                nud_Fertilizacion_cantidad.Maximum = 14;
            }
            else if(nud_Fertilizacion_IDSector.Value == 1)
            {
                nud_Fertilizacion_cantidad.Maximum = 14;
            }
            else
            {
                nud_Fertilizacion_cantidad.Maximum = 4.2M;
            }
        }

        private void btn_Fertilizacion_Calcular_Click(object sender, EventArgs e)
        {
            if (rdo_Fosforo.Checked == true)
            {
                Calculo(14, 10, "fósforo");
            }
            else if (rdo_Nitrogeno.Checked == true)
            {
                if (nud_Fertilizacion_IDSector.Value == 1)
                {
                    Calculo(14, 5, "nitrógeno");
                }
                else
                {
                    Calculo(4.2, 45, "nitrógeno");
                }
            }
        }
        #endregion
        #region Ciclo
        private void txt_Ciclo_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class_Metodos.VerificacionNumeros(e, "ID");
        }
        private void txt_Ciclo_ID_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void pic_Ciclo_BorrarID_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ciclo_Aceptar_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
