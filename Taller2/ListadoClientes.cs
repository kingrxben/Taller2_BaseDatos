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
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();
        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(c.CodigoCliente) FROM cliente c WHERE c.TipoCliente = @tipo;";
            string[] parametros = { "@tipo", "Premium" };

            string texto = ConnectMySQL.Instance.SelectQueryScalar(query, parametros);
            TotalPremiumBox.Text = texto;
        }

        private void ListaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT CodigoCliente,NombreCliente,Ciudad FROM cliente WHERE TipoCliente = @tipo AND Estado = 0";
            if (ListaTipo.Text == "Clientes Premium")
            {
                string[] parametros = { "@tipo", "Premium" };
                DataTable data = ConnectMySQL.Instance.SelectQuery(query, parametros);
                dataGridView1.DataSource = data;
            }
            else if (ListaTipo.Text == "Clientes normales")
            {
                string[] parametros = { "@tipo", "Normal" };
                DataTable data = ConnectMySQL.Instance.SelectQuery(query, parametros);
                dataGridView1.DataSource = data;
            } 
            else
            {
                string query2 = "SELECT CodigoCliente,NombreCliente,Ciudad FROM cliente WHERE Estado = 0";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query2);
                dataGridView1.DataSource = data;
            }
        }
    }
}
