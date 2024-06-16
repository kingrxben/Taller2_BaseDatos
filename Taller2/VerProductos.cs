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
    public partial class VerProductos : Form
    {
        public VerProductos()
        {
            InitializeComponent();
        }

        private void ModificarProducto_Click(object sender, EventArgs e)
        {
            ModificarProducto modificarProducto = new ModificarProducto();
            modificarProducto.Show();
        }

        private void DetalleProducto_Click(object sender, EventArgs e)
        {
            DetalleProducto detalleProducto = new DetalleProducto();
            detalleProducto.Show();
        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            IngresarProducto ingresarProducto = new IngresarProducto();
            ingresarProducto.Show();
        }

        private void EliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto eliminarProducto = new EliminarProducto();
            eliminarProducto.Show();
        }
    }
}
