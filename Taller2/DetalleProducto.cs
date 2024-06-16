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
    public partial class DetalleProducto : Form
    {
        public DetalleProducto()
        {
            InitializeComponent();
        }

        private void Opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Opciones.Text == "Productos vendidos este año")
            {
                string query = "";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);
                dataGridView1.DataSource = data;
                SubtituloText.Text = "Productos vendidos este año";

            }else if (Opciones.Text == "Productos vendidos ultimos 2 años")
            {
                string query = "";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);
                dataGridView1.DataSource = data;
                SubtituloText.Text = "Productos vendidos ultimos 2 años";
            }else if (Opciones.Text == "Productos en venta")
            {
                string query = "SELECT NombreProducto FROM producto WHERE Estado = 1";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);
                dataGridView1.DataSource = data;
                SubtituloText.Text = "Productos en venta";
            }
        }
    }
}
