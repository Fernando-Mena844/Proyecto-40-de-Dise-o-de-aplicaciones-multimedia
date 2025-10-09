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
    public partial class frmCategorias: Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            limpiarCampos();
        }

        public void limpiarCampos()
        {
            txtid.Text = "0";
            txtDescripcionCategoria.Clear();
            txtDescripcionCategoria.Focus();
        }
        private void cargarCategorias()
        {
            dgvData.DataSource = null;
            dgvData.DataSource = Modelos.Categorias.CargarCategoria();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Categorias cat = new Categorias();
            if (dgvData.CurrentRow != null && dgvData.Rows.Count>0) 
            {
                txtid.Text= dgvData.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                txtid.Text= "0";
            }
            if ((txtid.Text == "0") || string.IsNullOrEmpty(txtid.Text))
            {
                try
                {
                    cat.descripcionCategoria = txtDescripcionCategoria.Text;
                    if (txtDescripcionCategoria.Text == "")
                    {
                        MessageBox.Show("Debe ingresar una categoría", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtDescripcionCategoria.Focus();
                        return;
                    }
                    cat.InsertarCategoria();
                    cargarCategorias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar datos" + ex, "Error al registrar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                limpiarCampos();
                cargarCategorias();
            }
            else
            {
                try
                {
                    cat.idCategorias = int.Parse(txtid.Text);
                    cat.descripcionCategoria = txtDescripcionCategoria.Text;
                    if (txtDescripcionCategoria.Text == "")
                    {
                        MessageBox.Show("Debe ingresar una categoría", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtDescripcionCategoria.Focus();
                        return;
                    }
                    cat.ActualizarCategoria(int.Parse(txtid.Text));
                    cargarCategorias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar datos" + ex, "Error al actualizar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                limpiarCampos();
                cargarCategorias();
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text= dgvData.CurrentRow.Cells[0].Value.ToString();
            txtDescripcionCategoria.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Categorias cat = new Categorias();
            int idCategoria = int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString());
            DialogResult respuesta = MessageBox.Show($"¿Está seguro de eliminar la categoría?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                if (cat.EliminarCategoria(idCategoria) == true)
                {
                    cargarCategorias();
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Categoría no eliminada.", "Eliminación no realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
