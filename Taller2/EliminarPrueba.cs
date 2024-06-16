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
    public partial class EliminarPrueba : Form
    {
        public EliminarPrueba()
        {
            InitializeComponent();
        }

        private void EliminarPrueba_Load(object sender, EventArgs e)
        {

            string query = "SELECT CodigoCliente, NombreCliente, Ciudad FROM Cliente WHERE Estado = 1";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataGrid.DataSource = data;
        }
    }
}
