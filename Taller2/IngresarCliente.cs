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
    public partial class IngresarCliente : Form
    {
        public IngresarCliente()
        {
            InitializeComponent();
        }

        private void AñadirBoton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO cliente(NombreCliente, Ciudad, TipoCliente) VALUES(@nombre, @ciudad, @tipo)";
            MySqlParameter[] parametros =
            {
                new MySqlParameter("@nombre", NombreBox.Text),
                new MySqlParameter("@ciudad", CiudadBox.Text),
                new MySqlParameter("@tipo", TipoBox.Text),
            };
            ConnectMySQL.Instance.ExecuteQuery(query, parametros);
            if (TipoBox.Text == "Normal")
            {
                MessageBox.Show("Cliente normal registrado con éxito");
            }
            else
            {
                MessageBox.Show("Cliente premium registrado con éxito");
            }
            /*
            if (TipoBox.Text == "Normal")
            {
                MySqlParameter[] parametros =
                {
                   new MySqlParameter("@nombre", NombreBox.Text),
                   new MySqlParameter("@ciudad", CiudadBox.Text),
                   new MySqlParameter("@tipo", 1)
                };
                ConnectMySQL.Instance.ExecuteQuery(query, parametros);
                MessageBox.Show("Cliente normal registrado con éxito");
            }
            else
            {
                MySqlParameter[] parametros =
                {
                    new MySqlParameter("@nombre", NombreBox.Text),
                    new MySqlParameter("@ciudad", CiudadBox.Text),
                    new MySqlParameter("@tipo", 2)
                };
                ConnectMySQL.Instance.ExecuteQuery(query, parametros);
                MessageBox.Show("Cliente Premium ingresado con éxito");
            }
            */
        }

        private void TipoBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
