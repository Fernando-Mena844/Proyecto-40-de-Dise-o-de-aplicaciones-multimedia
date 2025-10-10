using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using Modelos.ConexionDB;

namespace Modelos
{
    public class Usuarios
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string documentoUsuario { get; set; }
        public string contraseniaUsuario { get; set; }
        public string correoUsuario { get; set; }
        public int idRol { get; set; } // FK hacia tabla Roles

        // Cargar todos los usuarios
        public static DataTable CargarUsuarios()
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                string consultaQuery = "SELECT U.idUsuario AS [ID], " +
                                       "U.nombreUsuario AS [Nombre], " +
                                       "U.documentoUsuario AS [Documento], " +
                                       "U.correoUsuario AS [Correo], " +
                                       "R.descripcionRol AS [Rol] " +
                                       "FROM Usuarios U " +
                                       "INNER JOIN Roles R ON U.rol_id = R.idRol";

                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                DataTable tablaCarga = new DataTable();
                add.Fill(tablaCarga);
                return tablaCarga;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
                return null;
            }
        }

        // Insertar usuario
        public bool InsertarUsuario()
        {
            SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
            SqlTransaction transaction = null;

            try
            {
                // Iniciar transacción
                transaction = conexion.BeginTransaction();

                // 1. Insertar en la tabla Usuarios
                string cadenaUsuario = "INSERT INTO Usuarios (nombreUsuario, documentoUsuario, contraseniaUsuario, correoUsuario, rol_id) " +
                                      "VALUES (@nombreUsuario, @documentoUsuario, @contraseniaUsuario, @correoUsuario, @rol_id); " +
                                      "SELECT SCOPE_IDENTITY();"; // Obtener el ID del usuario insertado

                SqlCommand comandoUsuario = new SqlCommand(cadenaUsuario, conexion, transaction);
                comandoUsuario.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                comandoUsuario.Parameters.AddWithValue("@documentoUsuario", documentoUsuario);
                comandoUsuario.Parameters.AddWithValue("@contraseniaUsuario", contraseniaUsuario);
                comandoUsuario.Parameters.AddWithValue("@correoUsuario", correoUsuario);
                comandoUsuario.Parameters.AddWithValue("@rol_id", idRol);

                // Ejecutar y obtener el ID del nuevo usuario
                int nuevoUsuarioId = Convert.ToInt32(comandoUsuario.ExecuteScalar());

                // 2. Si el rol es Cliente (idRol = 3), insertar en la tabla Clientes
                if (idRol == 3) // Asumiendo que 3 es el ID del rol Cliente
                {
                    string cadenaCliente = @"INSERT INTO Clientes (nombreCliente, documentoCliente, correoCliente, telefonoCliente) 
                                   VALUES (@nombreCliente, @documentoCliente, @correoCliente, @telefonoCliente)";

                    SqlCommand comandoCliente = new SqlCommand(cadenaCliente, conexion, transaction);
                    comandoCliente.Parameters.AddWithValue("@nombreCliente", nombreUsuario);
                    comandoCliente.Parameters.AddWithValue("@documentoCliente", documentoUsuario);
                    comandoCliente.Parameters.AddWithValue("@correoCliente", correoUsuario);
                    comandoCliente.Parameters.AddWithValue("@telefonoCliente", "000000000"); // Valor por defecto o pedir en el formulario

                    comandoCliente.ExecuteNonQuery();
                }

                // Confirmar transacción
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                // Revertir transacción en caso de error
                transaction?.Rollback();
                MessageBox.Show("Error al insertar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // Eliminar usuario
        public bool EliminarUsuario(int id)
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                string cadenaDelete = "DELETE FROM Usuarios WHERE idUsuario = @idUsuario";

                SqlCommand comando = new SqlCommand(cadenaDelete, conexion);
                comando.Parameters.AddWithValue("@idUsuario", id);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Actualizar usuario
        public bool ActualizarUsuario()
        {
            SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
            SqlTransaction transaction = null;

            try
            {
                transaction = conexion.BeginTransaction();

                StringBuilder queryUpdate = new StringBuilder();
                queryUpdate.Append("UPDATE Usuarios SET ");
                queryUpdate.Append("nombreUsuario = @nombreUsuario, ");
                queryUpdate.Append("documentoUsuario = @documentoUsuario, ");
                queryUpdate.Append("contraseniaUsuario = @contraseniaUsuario, ");
                queryUpdate.Append("correoUsuario = @correoUsuario, ");
                queryUpdate.Append("rol_id = @rol_id ");
                queryUpdate.Append("WHERE idUsuario = @idUsuario");

                SqlCommand comando = new SqlCommand(queryUpdate.ToString(), conexion, transaction);
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@documentoUsuario", documentoUsuario);
                comando.Parameters.AddWithValue("@contraseniaUsuario", contraseniaUsuario);
                comando.Parameters.AddWithValue("@correoUsuario", correoUsuario);
                comando.Parameters.AddWithValue("@rol_id", idRol);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);

                comando.ExecuteNonQuery();

                // Si el rol es Cliente, actualizar también en la tabla Clientes
                if (idRol == 3)
                {
                    string actualizarCliente = @"UPDATE Clientes 
                                       SET nombreCliente = @nombreCliente, 
                                           documentoCliente = @documentoCliente, 
                                           correoCliente = @correoCliente 
                                       WHERE documentoCliente = @documentoOriginal";

                    // Necesitarías tener el documento original para hacer el update
                    // Esto es una simplificación - deberías manejar mejor este caso
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Error al actualizar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Buscar usuario por nombre o documento
        public static DataTable BuscarUsuario(string termino)
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                string cadenaBuscar = "SELECT U.idUsuario AS [ID], " +
                                      "U.nombreUsuario AS [Nombre], " +
                                      "U.documentoUsuario AS [Documento], " +
                                      "U.correoUsuario AS [Correo], " +
                                      "R.descripcionRol AS [Rol] " +
                                      "FROM Usuarios U " +
                                      "INNER JOIN Roles R ON U.rol_id = R.idRol " +
                                      "WHERE U.nombreUsuario LIKE @termino OR U.documentoUsuario LIKE @termino";

                SqlDataAdapter data = new SqlDataAdapter(cadenaBuscar, conexion);
                data.SelectCommand.Parameters.AddWithValue("@termino", "%" + termino + "%");

                DataTable tablaBuscar = new DataTable();
                data.Fill(tablaBuscar);
                return tablaBuscar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message);
                return null;
            }
        }

        public static DataTable BuscarUsuario(string campo, string termino)
        {
            string columna = "";

            switch (campo)
            {
                case "Nro. Documento":
                    columna = "U.documentoUsuario";
                    break;
                case "Nombre":
                    columna = "U.nombreUsuario";
                    break;
                case "Correo":
                    columna = "U.correoUsuario";
                    break;
                case "Rol":
                    columna = "R.descripcionRol";
                    break;
                default:
                    return new DataTable();
            }

            try
            {
                using (SqlConnection conexion = ConexionDB.ConexionDB.Conectar())
                {
                    string query = $@"
                SELECT 
                    U.idUsuario AS [ID],
                    U.nombreUsuario AS [Nombre],
                    U.documentoUsuario AS [Documento],
                    U.correoUsuario AS [Correo],
                    R.descripcionRol AS [Rol]
                FROM Usuarios U
                INNER JOIN Roles R ON U.rol_id = R.idRol
                WHERE {columna} LIKE @termino";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@termino", "%" + termino + "%");

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tablaBuscar = new DataTable();
                    adaptador.Fill(tablaBuscar);
                    return tablaBuscar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
