using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;

namespace Vistas
{
    public partial class mdClientes : Form
    {
        public mdClientes()
        {
            InitializeComponent();
        }

        private void mdClientes_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = null;
            dgvData.DataSource = Modelos.Clientes.CargarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Modelos.Clientes cliente = new Modelos.Clientes();
            string campo = cmbBusca.SelectedItem.ToString();
            if (string.IsNullOrEmpty(txtBusca.Text))
            {
                MessageBox.Show("Ingrese un término de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                dgvData.DataSource = Modelos.Clientes.BuscarCliente(campo, txtBusca.Text);
            }
        }
    }
}
