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
    public partial class frm_Comercio : Form
    {
        public frm_Comercio()
        {
            InitializeComponent();
            cob_Compra_Producto.SelectedIndex = 0;
            cob_Venta_Producto.SelectedIndex = 0;
        }

        private void nud_Compra_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            txt_Compra_PrecioTotal.Text = Convert.ToString(nud_Compra_Cantidad.Value * Convert.ToDecimal(txt_Compra_PrecioKG.Text));
        }

        private void btn_Compra_Aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funciona");
            nud_Compra_Cantidad.Value = 1;
        }

        private void nud_Venta_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            txt_Venta_PrecioTotal.Text = Convert.ToString(nud_Venta_Cantidad.Value * Convert.ToDecimal(txt_Venta_PrecioKG.Text));
        }

        private void btn_Venta_Aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funciona");
            nud_Venta_Cantidad.Value = 1;
        }
    }
}
