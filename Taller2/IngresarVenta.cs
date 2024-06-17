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
    public partial class IngresarVenta : Form
    {
        public IngresarVenta()
        {
            InitializeComponent();
        }

        private void IngresarVenta_Load(object sender, EventArgs e)
        {
            string query = "SELECT NombreCliente FROM cliente WHERE Estado = 0";
            DataTable nombres = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < nombres.Rows.Count; i++)
            {
                ListaClientes.Items.Add(nombres.Rows[i]["NombreCliente"]);
            }
            string query2 = "SELECT NombreProducto FROM producto WHERE Estado = 0";
            DataTable nombres2 = ConnectMySQL.Instance.SelectQuery(query2);
            for (int i = 0; i < nombres2.Rows.Count; i++)
            {
                ListaProductos.Items.Add(nombres2.Rows[i]["NombreProducto"]);
            }
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Producto";
            dataGridView1.Columns[1].Name = "Cantidad";
            dataGridView1.Columns[2].Name = "Total Producto";
        }

        private void ListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT CodigoCliente FROM cliente WHERE NombreCliente = @nombre";
            string[] parametros = { "@nombre", ListaClientes.Text };
            string codigo = ConnectMySQL.Instance.SelectQueryScalar(query, parametros);
            CodigoClienteBox.Text = codigo;

            string query2 = "SELECT TipoCliente FROM cliente WHERE NombreCliente = @nombre";
            string[] parametros2 = { "@nombre", ListaClientes.Text };
            string status = ConnectMySQL.Instance.SelectQueryScalar(query2, parametros2);
            StatusClienteBox.Text = status;
        }

        private void ListaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT Precio FROM producto WHERE NombreProducto = @nombre";
            string[] parametros = { "@nombre", ListaProductos.Text };
            string precio = ConnectMySQL.Instance.SelectQueryScalar(query, parametros);
            PrecioBox.Text = precio;
        }

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            double cantidad = double.Parse(CantidadBox.Text);
            double precio = double.Parse(PrecioBox.Text);
            double total = cantidad * precio;
            string[] fila = new string[] { ListaProductos.Text, CantidadBox.Text, total.ToString() };
            dataGridView1.Rows.Add(fila);
        }

        private void RealizarCompraBoton_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                string producto = filaSeleccionada.Cells["Producto"].Value.ToString();
                string cantidad = filaSeleccionada.Cells["Cantidad"].Value.ToString();
                string precio = filaSeleccionada.Cells["Total Producto"].Value.ToString();
                
            }
        }
    }
}
