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
    public partial class frm_Compra : Form
    {
        public frm_Compra()
        {
            InitializeComponent();
        }

        private void frm_Compra_Load(object sender, EventArgs e)
        {
            cob_Producto.SelectedIndex = 0;
            txt_PrecioKG.Text = "5";
            txt_PrecioTotal.Text = Convert.ToString(Convert.ToDouble(nud_Cantidad.Value.ToString()) * 5);
        }

        private void nud_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            txt_PrecioKG.Text = "5";
            txt_PrecioTotal.Text = Convert.ToString(Convert.ToDouble(nud_Cantidad.Value.ToString()) * 5);
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funciona");
            nud_Cantidad.Value = 1;
        }
    }
}
