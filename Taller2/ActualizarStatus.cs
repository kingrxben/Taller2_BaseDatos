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
    public partial class ActualizarStatus : Form
    {
        public ActualizarStatus()
        {
            InitializeComponent();
        }

        private void ActualizarStatus_Load(object sender, EventArgs e)
        {
            string query = "SELECT NombreCliente FROM cliente WHERE Estado = 0";
            DataTable nombres = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < nombres.Rows.Count; i++)
            {
                ListaClientesBox.Items.Add(nombres.Rows[i]["NombreCliente"]);
            }
        }

        private void ListaClientesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT TipoCliente FROM cliente WHERE NombreCliente = @nombre";
            string[] parametros = { "@nombre", ListaClientesBox.Text };
            string stock = ConnectMySQL.Instance.SelectQueryScalar(query, parametros);
            StatusActualBox.Text = stock;
        }

        private void ActualizarBoton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE cliente SET TipoCliente = @tipo WHERE NombreCliente = @nombre";
            MySqlParameter[] parametros =
            {
                new MySqlParameter("@tipo", StatusNuevoBox.Text),
                new MySqlParameter("@nombre", ListaClientesBox.Text)
            };
            ConnectMySQL.Instance.ExecuteQuery(query, parametros);
            MessageBox.Show("Status del cliente actualizado con éxito");
        }
    }
}
