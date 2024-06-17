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
    public partial class IngresarProducto : Form
    {
        public IngresarProducto()
        {
            InitializeComponent();
        }

        private void AñadirBoton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO producto(NombreProducto, StockDisponible, Precio) VALUES(@nombre, @stock, @precio)";
            MySqlParameter[] parametros =
            {
                new MySqlParameter("@nombre", NombreProductoBox.Text),
                new MySqlParameter("@stock", StockBox.Text),
                new MySqlParameter("@precio", PrecioBox.Text),
            };
            ConnectMySQL.Instance.ExecuteQuery(query, parametros);
            MessageBox.Show("Producto registrado con éxito");
            
        }
    }
}
