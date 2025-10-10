using System;
using System.Data;
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
            cargarClientes();
        }

        private void cargarClientes()
        {
            dgvData.DataSource = null;
            dgvData.DataSource = Clientes.CargarClientes();

            // Opcional: ajustar estilo
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.MultiSelect = false;
            dgvData.ReadOnly = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbBusca.SelectedIndex == -1 || string.IsNullOrEmpty(txtBusca.Text))
            {
                MessageBox.Show("Seleccione un campo y escriba un término de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string campo = cmbBusca.SelectedItem.ToString();
            string termino = txtBusca.Text;

            dgvData.DataSource = Clientes.BuscarCliente(campo, termino);
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            txtBusca.Clear();
            cmbBusca.SelectedIndex = -1;
            cargarClientes();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.CurrentRow != null)
            {
                // Aquí devolvemos el cliente seleccionado al formulario que abrió este modal
                int idCliente = Convert.ToInt32(dgvData.CurrentRow.Cells[0].Value);
                string nombreCliente = dgvData.CurrentRow.Cells[1].Value.ToString();

                // Guardamos en propiedades públicas para que el formulario padre pueda leerlo
                this.ClienteSeleccionadoId = idCliente;
                this.ClienteSeleccionadoNombre = nombreCliente;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        // Propiedades públicas para devolver el cliente seleccionado
        public int ClienteSeleccionadoId { get; private set; }
        public string ClienteSeleccionadoNombre { get; private set; }
    }
}
