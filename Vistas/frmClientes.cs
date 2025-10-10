using System;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Modelos;

namespace Vistas
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cargarClientes();
            limpiarCampos();
        }

        public void limpiarCampos()
        {
            txtid.Text = "0";
            txtNombre.Clear();
            txtNroDocumento.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtNombre.Focus();
        }

        public void cargarClientes()
        {
            dgvData.DataSource = null;
            dgvData.DataSource = Modelos.Clientes.CargarClientes();
        }

        private string ValidarCampos()
        {
            StringBuilder mensaje = new StringBuilder();

            if (string.IsNullOrEmpty(txtNombre.Text))
                mensaje.AppendLine("Debe ingresar el nombre del cliente");

            if (string.IsNullOrEmpty(txtNroDocumento.Text))
                mensaje.AppendLine("Debe ingresar un número de documento");

            if (string.IsNullOrEmpty(txtCorreo.Text))
                mensaje.AppendLine("Debe ingresar un correo electrónico");

            else
            {
                string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(txtCorreo.Text, patronCorreo))
                    mensaje.AppendLine("El correo electrónico no tiene un formato válido");
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
                mensaje.AppendLine("Debe ingresar un número de teléfono");

            return mensaje.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Modelos.Clientes cliente = new Modelos.Clientes();
            string mensaje = ValidarCampos();

            if (mensaje != string.Empty)
            {
                MessageBox.Show(mensaje, "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                cliente.nombreCliente = txtNombre.Text;
                cliente.documentoCliente = txtNroDocumento.Text;
                cliente.correoCliente = txtCorreo.Text;
                cliente.telefonoCliente = txtTelefono.Text;

                if (txtid.Text == "0") // Nuevo cliente
                {
                    cliente.InsertarCliente();
                }
                else // Editar cliente existente
                {
                    cliente.idClientes = int.Parse(txtid.Text);
                    cliente.EditarCliente(cliente.idClientes);
                }

                cargarClientes();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idCliente = int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString());
            Modelos.Clientes cliente = new Modelos.Clientes();

            DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar el cliente?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                if (cliente.EliminarCliente(idCliente))
                {
                    cargarClientes();
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Cliente no eliminado.", "Eliminación no realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.CurrentRow != null)
            {
                txtid.Text = dgvData.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
                txtNroDocumento.Text = dgvData.CurrentRow.Cells[2].Value.ToString();
                txtCorreo.Text = dgvData.CurrentRow.Cells[3].Value.ToString();
                txtTelefono.Text = dgvData.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbBusca.SelectedIndex == -1 || string.IsNullOrEmpty(txtBusca.Text))
            {
                MessageBox.Show("Seleccione un campo y escriba un término de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string campo = cmbBusca.SelectedItem.ToString();
            dgvData.DataSource = Modelos.Clientes.BuscarCliente(campo, txtBusca.Text);
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            cargarClientes();
            limpiarCampos();
            txtBusca.Clear();
            cmbBusca.SelectedIndex = -1;
        }

        private void txtNroDocumento_Leave(object sender, EventArgs e)
        {
            // Ajusta el patrón según tu país (ejemplo: DUI en El Salvador)
            string patron = @"^\d{8}-\d{1}$";
            if (!Regex.IsMatch(txtNroDocumento.Text, patron))
            {
                MessageBox.Show("El formato debe ser 00000000-0", "Formato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroDocumento.Focus();
            }
        }
    }
}