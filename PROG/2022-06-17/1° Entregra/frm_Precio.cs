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
    public partial class frm_Precio : Form
    {
        public frm_Precio()
        {
            InitializeComponent();
        }

        private void pic_BorrarCedula_Click(object sender, EventArgs e)
        {
            nud_Precio.Value=5.00m;
        }

        private void frm_Precio_Load(object sender, EventArgs e)
        {
            cob_Producto.SelectedIndex = 0;
            nud_Precio.Value=5.00m;
        }

        private void nud_Precio_ValueChanged(object sender, EventArgs e)
        {
            if (nud_Precio.Value == 5.00m)
            {
                pic_ResetearPrecio.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
               pic_ResetearPrecio.BackColor = System.Drawing.Color.Firebrick;
            }
        }

        private void nud_Precio_KeyUp(object sender, KeyEventArgs e)
        {
            if (nud_Precio.Value == 5.00m)
            {
                pic_ResetearPrecio.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                pic_ResetearPrecio.BackColor = System.Drawing.Color.Firebrick;
            }
        }

        private void pic_ResetearPrecio_Click(object sender, EventArgs e)
        {
            nud_Precio.Value = 5.00m;
        }
    }
}
