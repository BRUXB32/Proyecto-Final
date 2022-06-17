using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1__Entregra.Resources
{
    public partial class frm_Venta : Form
    {
        public frm_Venta()
        {
            InitializeComponent();
        }

        private void frm_Venta_Load(object sender, EventArgs e)
        {
            cob_Producto.SelectedIndex = 0;
            txt_PrecioUnitario.Text = "5";
            txt_PrecioTotal.Text = Convert.ToString(Convert.ToInt32(nud_Cantidad.Value.ToString()) * 5);
        }

        private void nud_Cantidad_KeyUp(object sender, KeyEventArgs e)
        {
            txt_PrecioUnitario.Text = "5";
            txt_PrecioTotal.Text = Convert.ToString(Convert.ToInt32(nud_Cantidad.Value.ToString()) * 5);
        }

        private void nud_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            txt_PrecioUnitario.Text = "5";
            txt_PrecioTotal.Text = Convert.ToString(Convert.ToInt32(nud_Cantidad.Value.ToString()) * 5);
        }

        private void btn_Vender_Click(object sender, EventArgs e)
        {
            nud_Cantidad.Value = 1;
        }

        private void btn_Vender_Click_1(object sender, EventArgs e)
        {

        }
    }
}
