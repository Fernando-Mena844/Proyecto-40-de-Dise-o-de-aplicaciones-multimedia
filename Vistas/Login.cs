using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using Modelos;
using Modelos.ConexionDB;

namespace Vistas
{
    public partial class Login : Form
    {
        public static Usuarios UsuarioLogueado { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                AutenticarUsuario();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoUsuario.Text))
            {
                MessageBox.Show("Por favor ingrese su usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocumentoUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Por favor ingrese su contraseña", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return false;
            }

            return true;
        }
        private void AutenticarUsuario()
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.Conectar())
                {
                    string query = @"
                SELECT 
                    U.idUsuario,
                    U.nombreUsuario,
                    U.documentoUsuario,
                    U.contraseniaUsuario,
                    U.correoUsuario,
                    U.rol_id,
                    R.descripcionRol
                FROM Usuarios U
                INNER JOIN Roles R ON U.rol_id = R.idRol
                WHERE U.documentoUsuario = @documentoUsuario 
                   OR U.correoUsuario = @documentoUsuario";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@documentoUsuario", txtDocumentoUsuario.Text.Trim());

                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        string contraseniaHash = reader["contraseniaUsuario"].ToString().Trim();
                        string contraseniaIngresada = txtClave.Text.Trim();

                        bool resultadoVerificacion = BCrypt.Net.BCrypt.Verify(contraseniaIngresada, contraseniaHash);

                        string mensajeDepuracion = $"Hash: {contraseniaHash}\n" +
                                                 $"Longitud hash: {contraseniaHash.Length}\n" +
                                                 $"Contraseña: {contraseniaIngresada}\n" +
                                                 $"Resultado: {resultadoVerificacion}";

                        if (resultadoVerificacion)
                        {
                            // Login exitoso...
                            UsuarioLogueado = new Usuarios
                            {
                                idUsuario = Convert.ToInt32(reader["idUsuario"]),
                                nombreUsuario = reader["nombreUsuario"].ToString(),
                                documentoUsuario = reader["documentoUsuario"].ToString(),
                                correoUsuario = reader["correoUsuario"].ToString(),
                                idRol = Convert.ToInt32(reader["rol_id"])
                            };

                            string rol = reader["descripcionRol"].ToString();

                            frmInicio formInicio = new frmInicio(UsuarioLogueado);
                            this.Hide();
                            formInicio.Show();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta", "Error de autenticación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtClave.Focus();
                            txtClave.SelectAll();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado", "Error de autenticación",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDocumentoUsuario.Focus();
                        txtDocumentoUsuario.SelectAll();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al autenticar usuario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
        private void txtDocumentoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtClave.Focus();
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar_Click(sender, e);
            }
        }
    }
}
