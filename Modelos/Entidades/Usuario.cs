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
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                string cadena = "INSERT INTO Usuarios (nombreUsuario, documentoUsuario, contraseniaUsuario, correoUsuario, idRol) " +
                                "VALUES (@nombreUsuario, @documentoUsuario, @contraseniaUsuario, @correoUsuario, @idRol)";

                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@documentoUsuario", documentoUsuario);
                comando.Parameters.AddWithValue("@contraseniaUsuario", contraseniaUsuario);
                comando.Parameters.AddWithValue("@correoUsuario", correoUsuario);
                comando.Parameters.AddWithValue("@idRol", idRol);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
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
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                StringBuilder queryUpdate = new StringBuilder();
                queryUpdate.Append("UPDATE Usuarios SET ");
                queryUpdate.Append("nombreUsuario = @nombreUsuario, ");
                queryUpdate.Append("documentoUsuario = @documentoUsuario, ");
                queryUpdate.Append("contraseniaUsuario = @contraseniaUsuario, ");
                queryUpdate.Append("correoUsuario = @correoUsuario, ");
                queryUpdate.Append("idRol = @idRol ");
                queryUpdate.Append("WHERE idUsuario = @idUsuario");

                SqlCommand comando = new SqlCommand(queryUpdate.ToString(), conexion);
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@documentoUsuario", documentoUsuario);
                comando.Parameters.AddWithValue("@contraseniaUsuario", contraseniaUsuario);
                comando.Parameters.AddWithValue("@correoUsuario", correoUsuario);
                comando.Parameters.AddWithValue("@idRol", idRol);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
                                      "INNER JOIN Roles R ON U.idRol = R.idRol " +
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
    }
}
