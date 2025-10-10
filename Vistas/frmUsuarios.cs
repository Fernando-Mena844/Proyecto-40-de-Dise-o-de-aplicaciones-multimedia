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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            cargardatacombo();
           
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
            limpiarCampos();
            cargardatacombo();
            
        }

        public void limpiarCampos()
        {
            txtid.Text= "0";
            txtNroDocumento.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtClave.Clear();
            cmbRol.SelectedIndex = -1;
            txtNroDocumento.Focus();
        }

        private void cargarUsuarios()
        {
            dgvData.DataSource = null;
            dgvData.DataSource = Usuarios.CargarUsuarios();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            if (dgvData.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int idUsuario = Convert.ToInt32(dgvData.CurrentRow.Cells[0].Value);


            DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar el usuario?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                if (user.EliminarUsuario(idUsuario))
                {
                    cargarUsuarios();
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Usuario no eliminado.", "Eliminación no realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvData.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
            txtNroDocumento.Text = dgvData.CurrentRow.Cells[2].Value.ToString();
            txtCorreo.Text = dgvData.CurrentRow.Cells[3].Value.ToString();
            cmbRol.Text = dgvData.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();

            // Validaciones básicas
            if (string.IsNullOrEmpty(txtNroDocumento.Text) || string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtClave.Text) ||
                cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            user.documentoUsuario = txtNroDocumento.Text;
            user.nombreUsuario = txtNombre.Text;
            user.correoUsuario = txtCorreo.Text;
            user.contraseniaUsuario = Usuarios.HashPassword(txtClave.Text);
            user.idRol = Convert.ToInt32(cmbRol.SelectedValue);

            if (txtid.Text == "0") // Nuevo usuario
            {
                try
                {
                    user.InsertarUsuario();
                    cargarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Actualizar usuario existente
            {
                try
                {
                    user.idUsuario = int.Parse(txtid.Text);
                    user.ActualizarUsuario();
                    cargarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            limpiarCampos();
            cargarUsuarios();

        }

        private void cargardatacombo()
        {

            cmbRol.DataSource = Rol.CargarRoles();
            cmbRol.DisplayMember = "descripcionRol";
            cmbRol.ValueMember = "idRol";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string campo = cmbBusca.Text;
            string termino = txtBusca.Text;

            dgvData.DataSource = Usuarios.BuscarUsuario(campo, termino);

        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            cargarUsuarios();
            limpiarCampos();
            txtBusca.Clear();
            cmbBusca.SelectedIndex = -1;
        }
    }
}
