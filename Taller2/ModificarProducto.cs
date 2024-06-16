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

        /* 

        private void ListadoProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT stock FROM productos WHERE nombre = @nombre";
            string[] parameters = { "@nombre", ListadoProductos.Text };
            string stock = ConnectMySQL.Instance.SelectQueryScalar(query, parameters);
            StockActual.Text = stock;

            string query2 = "SELECT precio FROM productos WHERE nombre = @nombre";
            string[] parameters2 = { "@nombre", ListadoProductos.Text };
            string precio = ConnectMySQL.Instance.SelectQueryScalar(query2, parameters2);
            PrecioActual.Text = precio;
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            string query = "SELECT nombre FROM productos WHERE Estado = 0";
            DataTable nombres = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < nombres.Rows.Count; i++)
            {
                ListadoProductos.Items.Add(nombres.Rows[i]["nombre"]);
            }

        }

        
         private void StockButton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE productos SET stock = @stock WHERE nombre = @nombre";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@stock", int.Parse(StockActual.Text) + int.Parse(nuevoStock.Text)),
                new MySqlParameter("@nombre", ListadoProductos.Text)
            };
            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
        }

        private void PriceButton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE productos SET precio = @precio WHERE nombre = @nombre";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@precio", nuevoPrecio.Text),
                new MySqlParameter("@nombre", ListadoProductos.Text)
            };
            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
        }
         */

    }
}
