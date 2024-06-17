using MySql.Data.MySqlClient;
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
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {
            string query = "SELECT CodigoProducto,NombreProducto,StockDisponible,Precio FROM producto WHERE Estado = 0";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataGridView1.DataSource = data;
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE producto SET Estado = 1 WHERE CodigoProducto = @id";
            MySqlParameter[] parametros =
            {
                new MySqlParameter("@id", dataGridView1.CurrentCell.Value)
            };
            ConnectMySQL.Instance.ExecuteQuery(query, parametros);
            MessageBox.Show("Producto eliminado con éxito");

            query = "SELECT CodigoProducto,NombreProducto,StockDisponible,Precio FROM producto WHERE Estado = 0";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
