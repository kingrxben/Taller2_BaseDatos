using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2
{
    public partial class VerVentas : Form
    {
        public VerVentas()
        {
            InitializeComponent();
        }

        private void IngresarVentaBoton_Click(object sender, EventArgs e)
        {
            IngresarVenta ingresarVenta = new IngresarVenta();
            ingresarVenta.Show();
        }
    }
}
