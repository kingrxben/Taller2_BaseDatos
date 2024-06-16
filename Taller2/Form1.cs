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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void VerClientes_Click(object sender, EventArgs e)
        {
            VerClientes verClientes = new VerClientes();
            verClientes.Show(); 
        }

        private void VerProductos_Click(object sender, EventArgs e)
        {
            IngresarProducto ingresarProducto = new IngresarProducto();
            ingresarProducto.Show();
        }

     
    }
}
