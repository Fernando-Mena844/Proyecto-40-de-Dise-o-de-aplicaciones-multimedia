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
        private static Usuarios usuarioActual;
        private static Button MenuActivo = null;
        private static Form formularioActivo = null;
        private static ContextMenuStrip MenuActivoCMS = null;

        public frmInicio()
        {
            InitializeComponent();

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


        // Método para abrir un formulario desde un ContextMenuStrip
        private void AbrirFormularioCMS(ContextMenuStrip menu, Form formulario)
        {
            //if (MenuActivoCMS != null)
            //{
            //    MenuActivoCMS.BackColor = Color.FromArgb(243, 235, 235);
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

        private void frmInicio_Load(object sender, EventArgs e)
        {

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
    }
}
