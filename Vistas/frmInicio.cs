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
    public partial class frmInicio : Form
    {
        private  Usuarios usuarioActual;
        private static Button MenuActivo = null;
        private static Form formularioActivo = null;

        public frmInicio(Usuarios usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            ConfigurarInterfazSegunRol();
        }

        private void ConfigurarInterfazSegunRol()
        {
            // Mostrar información del usuario
            lblUsuario.Text = $"Usuario: {usuarioActual.nombreUsuario}";

            // Configurar visibilidad de módulos según el rol
            switch (usuarioActual.idRol)
            {
                case 1: // Administrador - ve todo
                    // Todos los botones visibles
                    break;

                case 2: // Técnico - ocultar gestión de usuarios
                    btnUsuario.Visible = false;
                    break;

                case 3: // Cliente - solo ver tickets
                    btnUsuario.Visible = false;
                    btnCategoria.Visible = false;
                    btnClientes.Visible = false;
                    // Solo tickets visible
                    break;

                default:
                    break;
            }
        }
        private void AbrirFormulario(Button menu, Form formulario)
        {
            //if (MenuActivo != null)
            //{
            //    MenuActivo.BackColor = Color.FromArgb(243, 235, 235) ;
            //}
            //menu.BackColor = Color.White;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            //Configuracion de formulario
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.FromArgb(243, 235, 235);
            //Se agrega el formulario al contenedor
            pnlContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        // Color original y color activo
        Color colorOriginal = Color.FromArgb(243, 235, 235);
        Color colorActivo = Color.LightBlue;

        // Método para manejar el cambio de color
        private void ActivarBoton(Button botonActivo)
        {
            // Recorrer solo los botones dentro del GroupBox
            foreach (Control control in gbModulos.Controls)
            {
                if (control is Button boton)
                {
                    boton.BackColor = colorOriginal;
                }
            }

            // Activar el botón seleccionado
            botonActivo.BackColor = colorActivo;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Button)sender, new frmUsuarios());
            // Activar el botón presionado
            ActivarBoton(btnUsuario);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Button)sender, new frmCategorias());
            // Activar el botón presionado
            ActivarBoton(btnCategoria);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            AbrirFormulario((Button)sender, new frmClientes());
            // Activar el botón presionado
            ActivarBoton(btnClientes);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {

            AbrirFormulario((Button)sender, new frmTickets());
            // Activar el botón presionado
            ActivarBoton(btnTickets);
        }

        private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
