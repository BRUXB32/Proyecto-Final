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

        private void frm_Precio_Load(object sender, EventArgs e)
        {
            cob_Producto.SelectedIndex = 0;
            nud_Precio.Value = 5.00m;
        }

        private void pic_ResetearPrecio_Click(object sender, EventArgs e)
        {
            nud_Precio.Value = 5.00m;
        }

        private void btn_Cambiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funciona");
        }
    }
}
