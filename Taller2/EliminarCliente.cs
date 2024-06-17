using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Taller2
{
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void EliminarCLiente_Load(object sender, EventArgs e)
        {
            string query = "SELECT CodigoCliente,NombreCliente,TipoCliente FROM cliente WHERE Estado = 0";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataGridView1.DataSource = data;
        }


        private void Eliminar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE cliente SET Estado = 1 WHERE CodigoCliente = @id";
            MySqlParameter[] parametros =
            {
                new MySqlParameter("@id", dataGridView1.CurrentCell.Value)
            };
            ConnectMySQL.Instance.ExecuteQuery(query, parametros);
            MessageBox.Show("Cliente eliminado con éxito");

            query = "SELECT * FROM cliente WHERE Estado = 0";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
