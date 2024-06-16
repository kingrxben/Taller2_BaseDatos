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
            string query = "SELECT * FROM cliente WHERE Estado = 1";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataGrid.DataSource = data;
        }

        
        private void Eliminar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE cliente SET Estado = 0 WHERE id = @id";
            MySqlParameter[] parametros =
            {
                new MySqlParameter("@id", dataGrid.CurrentCell.Value)
            };
            ConnectMySQL.Instance.ExecuteQuery(query, parametros);
            MessageBox.Show("Cliente eliminado con éxito");

            query = "SELECT id, nombre, ciudad FROM clientes WHERE estado = 0";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataGrid.DataSource = data;
        }
         
        
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
