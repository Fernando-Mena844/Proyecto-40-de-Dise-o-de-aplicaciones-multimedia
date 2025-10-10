using System;
using System.Data;
using System.Windows.Forms;
using Modelos;

namespace Vistas
{
    public partial class frmTickets : Form
    {
        public frmTickets()
        {
            InitializeComponent();
        }

        private void frmTickets_Load(object sender, EventArgs e)
        {
            cargarTickets();
            cargarCategorias();
            limpiarCampos();

            // Configuración opcional del DataGridView
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.MultiSelect = false;
            dgvData.ReadOnly = true;
        }

        private void limpiarCampos()
        {
            txtid.Text = "0";
            txtNroDocumento.Clear();   // aquí usas el campo de descripción
            txtCliente.Clear();
            txtCliente.Tag = null;     // guardamos el ID del cliente en Tag
            cmbCategoria.SelectedIndex = -1;
            dtpFehcaRecibidoRegistro.Value = DateTime.Now;
            dtpFechaEntregadoRegistro.Value = DateTime.Now;
        }

        private void cargarTickets()
        {
            dgvData.DataSource = null;
            dgvData.DataSource = Tickets.CargarTickets();
        }

        private void cargarCategorias()
        {
            cmbCategoria.DataSource = Categorias.CargarCategoria();
            cmbCategoria.DisplayMember = "descripcionCategoria";
            cmbCategoria.ValueMember = "idCategoria";
            cmbCategoria.SelectedIndex = -1;

        }





        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

       

       

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Tickets ticket = new Tickets();

            // Validaciones básicas
            if (string.IsNullOrEmpty(txtNroDocumento.Text) || txtCliente.Tag == null || cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una descripción, seleccionar un cliente y una categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ticket.descripcionTicket = txtNroDocumento.Text;
            ticket.cliente_id = Convert.ToInt32(txtCliente.Tag);
            ticket.usuario_id = 3; // aquí deberías pasar el usuario logueado
            ticket.categoria_id = Convert.ToInt32(cmbCategoria.SelectedValue);
            ticket.fechaRecibido = dtpFehcaRecibidoRegistro.Value;
            ticket.fechaEntrega = dtpFechaEntregadoRegistro.Value;

            if (txtid.Text == "0")
            {
                try
                {
                    ticket.InsertarTicket();
                    cargarTickets();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    ticket.idTicket = int.Parse(txtid.Text);
                    ticket.ActualizarTicket();
                    cargarTickets();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            limpiarCampos();
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un ticket para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idTicket = Convert.ToInt32(dgvData.CurrentRow.Cells["ID"].Value);
            Tickets ticket = new Tickets();

            DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar el ticket?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                if (ticket.EliminarTicket(idTicket))
                {
                    cargarTickets();
                    limpiarCampos();
                }
            }

        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            using (mdClientes modal = new mdClientes())
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    txtCliente.Text = modal.ClienteSeleccionadoNombre;
                    txtCliente.Tag = modal.ClienteSeleccionadoId; // guardamos el ID en Tag
                }
            }
        }

        private void dgvData_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.CurrentRow != null)
            {
                txtid.Text = dgvData.CurrentRow.Cells["ID"].Value.ToString();
                txtNroDocumento.Text = dgvData.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtCliente.Text = dgvData.CurrentRow.Cells["Cliente"].Value.ToString();
                // Si incluyes idCliente en el SELECT, aquí puedes asignarlo a Tag
                cmbCategoria.Text = dgvData.CurrentRow.Cells["Categoria"].Value.ToString();
                dtpFehcaRecibidoRegistro.Value = Convert.ToDateTime(dgvData.CurrentRow.Cells["FechaRecibido"].Value);
                if (dgvData.CurrentRow.Cells["FechaEntrega"].Value != DBNull.Value)
                    dtpFechaEntregadoRegistro.Value = Convert.ToDateTime(dgvData.CurrentRow.Cells["FechaEntrega"].Value);
            }
        }

        
    }
}