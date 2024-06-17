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
    public partial class VerClientes : Form
    {
        public VerClientes()
        {
            InitializeComponent();
        }

        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            IngresarCliente ingresarCliente = new IngresarCliente();
            ingresarCliente.Show();
        }

        private void EliminarCliente_Click(object sender, EventArgs e)
        {
            EliminarCliente eliminarCliente = new EliminarCliente();
            eliminarCliente.Show();
        }

        private void ActualizarStatusBoton_Click(object sender, EventArgs e)
        {
            ActualizarStatus actualizarStatus = new ActualizarStatus();
            actualizarStatus.Show();
        }

        private void ListClientesBoton_Click(object sender, EventArgs e)
        {
            ListadoClientes listadoClientes = new ListadoClientes();
            listadoClientes.Show();
        }
    }
}
