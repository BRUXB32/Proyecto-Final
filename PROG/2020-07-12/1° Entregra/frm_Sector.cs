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
        private void frm_Sector_Load(object sender, EventArgs e)
        {
            cob_Agregar_TipoCultivo.SelectedIndex = 0;
            cob_Modificar_TipoCultivo.SelectedIndex = 0;
        }

        #region Agregar
        private void txt_Agregar_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 22)
            {
                e.Handled = true;
                MessageBox.Show("Pegar esta desabilitado", "validación de ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Solo se admiten datos numéricos", "validación de ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txt_Agregar_ID_KeyUp(object sender, KeyEventArgs e)
        {
            err_Sector.SetError(pic_Agregar_BorrarID, "");
            if (txt_Agregar_ID.TextLength > 0)
            {
                pic_Agregar_BorrarID.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                pic_Agregar_BorrarID.BackColor = System.Drawing.Color.IndianRed;
            }
        }

        private void pic_Agregar_BorrarID_Click(object sender, EventArgs e)
        {
            err_Sector.SetError(pic_Agregar_BorrarID, "");
            txt_Agregar_ID.Text = "";
            txt_Agregar_ID.Focus();
            pic_Agregar_BorrarID.BackColor = System.Drawing.Color.IndianRed;
        }

        private void btn_Agregar_Agregar_Click(object sender, EventArgs e)
        {
            if (txt_Agregar_ID.Text.Equals(""))
                err_Sector.SetError(pic_Agregar_BorrarID, "Ingrese una ID");
            else
                MessageBox.Show("Funciona");
        }
        #endregion
        #region Borrar
        private void txt_Borrar_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 22)
            {
                e.Handled = true;
                MessageBox.Show("Pegar esta desabilitado", "validación de ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Solo se admiten datos numéricos", "validación de ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txt_Borrar_ID_KeyUp(object sender, KeyEventArgs e)
        {
            err_Sector.SetError(pic_Borrar_BorrarID, "");
            if (txt_Borrar_ID.TextLength > 0)
            {
                pic_Borrar_BorrarID.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                pic_Borrar_BorrarID.BackColor = System.Drawing.Color.IndianRed;
            }
        }

        private void pic_Borrar_BorrarID_Click(object sender, EventArgs e)
        {
            err_Sector.SetError(pic_Borrar_BorrarID, "");
            txt_Borrar_ID.Text = "";
            txt_Borrar_ID.Focus();
            pic_Borrar_BorrarID.BackColor = System.Drawing.Color.IndianRed;
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
            if (e.KeyChar == 22)
            {
                e.Handled = true;
                MessageBox.Show("Pegar esta desabilitado", "validación de ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Solo se admiten datos numéricos", "validación de ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txt_Modificar_ID_KeyUp(object sender, KeyEventArgs e)
        {
            err_Sector.SetError(pic_Modificar_BorrarID, "");
            if (txt_Modificar_ID.TextLength > 0)
            {
                pic_Modificar_BorrarID.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                pic_Modificar_BorrarID.BackColor = System.Drawing.Color.IndianRed;
            }
        }

        private void pic_Modificar_BorrarID_Click(object sender, EventArgs e)
        {
            err_Sector.SetError(pic_Modificar_BorrarID, "");
            txt_Modificar_ID.Text = "";
            nud_Modificar_Tamaño.Value = 1;
            cob_Modificar_TipoCultivo.SelectedIndex = 0;
            txt_Modificar_ID.Focus();
            pic_Modificar_BorrarID.BackColor = System.Drawing.Color.IndianRed;
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
            if (e.KeyChar == 22)
            {
                e.Handled = true;
                MessageBox.Show("Pegar esta desabilitado", "validación de ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Solo se admiten datos numéricos", "validación de ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txt_Listar_ID_KeyUp(object sender, KeyEventArgs e)
        {
            err_Sector.SetError(pic_Listar_BorrarID, "");
            if (txt_Listar_ID.TextLength > 0)
            {
                pic_Listar_BorrarID.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                pic_Listar_BorrarID.BackColor = System.Drawing.Color.IndianRed;
            }
        }

        private void pic_Listar_BorrarID_Click(object sender, EventArgs e)
        {
            err_Sector.SetError(pic_Listar_BorrarID, "");
            txt_Listar_ID.Text = "";
            txt_Listar_ID.Focus();
            pic_Listar_BorrarID.BackColor = System.Drawing.Color.IndianRed;
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
