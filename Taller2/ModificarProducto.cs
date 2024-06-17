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
    public partial class ModificarProducto : Form
    {
        public ModificarProducto()
        {
            InitializeComponent();
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            string query = "SELECT NombreProducto FROM producto WHERE Estado = 0";
            DataTable nombres = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < nombres.Rows.Count; i++)
            {
                ListaProductosBox.Items.Add(nombres.Rows[i]["NombreProducto"]);
            }
        }

        private void ListaProductosBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT StockDisponible FROM producto WHERE NombreProducto = @nombre";
            string[] parametros = { "@nombre", ListaProductosBox.Text };
            string stock = ConnectMySQL.Instance.SelectQueryScalar(query, parametros);
            StockActualBox.Text = stock;

            string query2 = "SELECT Precio FROM producto WHERE NombreProducto = @nombre";
            string[] parametros2 = { "@nombre", ListaProductosBox.Text };
            string precio = ConnectMySQL.Instance.SelectQueryScalar(query2, parametros2);
            PrecioActualBox.Text = precio;
        }

        private void ActualizarStockBoton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE producto SET StockDisponible = @stock WHERE NombreProducto = @nombre";
            MySqlParameter[] parametros =
            {
                new MySqlParameter("@stock", int.Parse(StockActualBox.Text) + int.Parse(StockNuevoBox.Text)),
                new MySqlParameter("@nombre", ListaProductosBox.Text)
            };
            ConnectMySQL.Instance.ExecuteQuery(query, parametros);
            MessageBox.Show("Stock actualizado con éxito");
        }

        private void ActualizarPrecioBoton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE producto SET Precio = @precio WHERE NombreProducto = @nombre";
            MySqlParameter[] parametros =
            {
                new MySqlParameter("@precio", PrecioNuevoBox.Text),
                new MySqlParameter("@nombre", ListaProductosBox.Text)
            };
            ConnectMySQL.Instance.ExecuteQuery(query, parametros);
            MessageBox.Show("Precio actualizado con éxito");
        }
    }
}
