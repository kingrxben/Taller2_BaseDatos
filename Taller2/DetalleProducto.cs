using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2
{
    public partial class DetalleProducto : Form
    {
        public DetalleProducto()
        {
            InitializeComponent();
        }

        private void DetalleProductoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DetalleProductoBox.Text == "Productos vendidos este año")
            {
                string query = "";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);
                dataGridView1.DataSource = data;
                SubtituloText.Text = "Productos vendidos este año";

            }
            else if (DetalleProductoBox.Text == "Productos vendidos ultimos 2 años")
            {
                string query = "";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);
                dataGridView1.DataSource = data;
                SubtituloText.Text = "Productos vendidos ultimos 2 años";
            }
            else if (DetalleProductoBox.Text == "Productos en venta")
            {
                string query = "SELECT CodigoProducto,NombreProducto,Precio FROM producto WHERE Estado = 0";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);
                dataGridView1.DataSource = data;
                SubtituloText.Text = "Productos en venta";
            }
        }
    }
}
