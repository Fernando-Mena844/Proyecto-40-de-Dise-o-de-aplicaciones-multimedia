using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;

namespace Vistas
{
    public partial class frmClientes: Form
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
        }

        public void cargarClientes()
        {
            dgvData.DataSource = null;
            dgvData.DataSource = Modelos.Clientes.CargarClientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();

            if (dgvData.CurrentRow != null && dgvData.Rows.Count > 0)
            {
                txtid.Text = dgvData.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                txtid.Text = "0";
            }

            if ((txtid.Text == "0") || string.IsNullOrEmpty(txtid.Text))
            {
                string mensaje = string.Empty;
                try
                {
                    clientes.nombreCliente = txtNombre.Text;
                    clientes.documentoCliente = txtNroDocumento.Text;
                    clientes.correoCliente = txtCorreo.Text;
                    clientes.telefonoCliente = txtTelefono.Text;

                    if (string.IsNullOrEmpty(txtNombre.Text))
                    {
                        mensaje += "Debe ingresar el nombre del cliente\n";
                    }
                    if (string.IsNullOrEmpty(txtNroDocumento.Text))
                    {
                        mensaje += "Debe ingresar un número de documento.\n";
                    }
                    if (string.IsNullOrEmpty(txtCorreo.Text))
                    {
                        mensaje += "Debe ingresar un correo electrónico válido\n";
                    }
                    if (string.IsNullOrEmpty(txtTelefono.Text))
                    {
                        mensaje += "Debe ingresar un número de teléfono\n";
                    }

                    if (mensaje == string.Empty)
                    {
                        clientes.InsertarCliente();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                int idSeleccionado = int.Parse(txtid.Text);
                string mensaje = string.Empty;
                try
                {
                    clientes.idClientes=idSeleccionado;
                    clientes.nombreCliente=txtNombre.Text;
                    clientes.documentoCliente=txtNroDocumento.Text;
                    clientes.correoCliente=txtCorreo.Text;
                    if (string.IsNullOrEmpty(txtNombre.Text))
                    {
                        mensaje += "Debe ingresar el nombre del cliente\n";
                    }
                    if (string.IsNullOrEmpty(txtNroDocumento.Text))
                    {
                        mensaje += "Debe ingresar un número de documento.\n";
                    }
                    if (string.IsNullOrEmpty(txtCorreo.Text))
                    {
                        mensaje += "Debe ingresar un correo electrónico válido\n";
                    }
                    if (string.IsNullOrEmpty(txtTelefono.Text))
                    {
                        mensaje += "Debe ingresar un número de teléfono\n";
                    }

                    if (mensaje == string.Empty)
                    {
                        clientes.EditarCliente(idSeleccionado);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar datos" + ex, "Error al actualizar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            cargarClientes();
            limpiarCampos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            int idCategoria = int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString());
            DialogResult respuesta = MessageBox.Show($"¿Está seguro de eliminar el cliente?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                if (cliente.EliminarCliente(idCategoria) == true)
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
            txtid.Text = dgvData.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
            txtNroDocumento.Text = dgvData.CurrentRow.Cells[2].Value.ToString();
            txtCorreo.Text = dgvData.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvData.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            string campo = cmbBusca.SelectedItem.ToString();
            if (string.IsNullOrEmpty(txtBusca.Text))
            {
                MessageBox.Show("Ingrese un término de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                dgvData.DataSource = Clientes.BuscarCliente(campo, txtBusca.Text);
            }
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
