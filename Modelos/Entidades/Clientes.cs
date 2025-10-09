using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Modelos
{
    public class Clientes
    {
        public int idClientes { get; set; }
        public string nombreCliente { get; set; }
        public string documentoCliente { get; set; }
        public string correoCliente { get; set; }
        public string telefonoCliente { get; set; }

        public static DataTable CargarClientes()
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                string consultaQuery = "select idCliente as [Número de registro], nombreCliente as Cliente, documentoCliente as Documento, correoCliente as Correo, telefonoCliente as Teléfono from Clientes";
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                DataTable tablaCarga = new DataTable();
                add.Fill(tablaCarga);
                return tablaCarga;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error a1 cargar datos" + ex);
                return null;
            }
        }

        public bool InsertarCliente()
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                string cadena = "insert into Clientes values (@nombreCliente, @documentoCliente, @correoCliente, @telefonoCliente)";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@nombreCliente", nombreCliente);
                comando.Parameters.AddWithValue("@documentoCliente", documentoCliente);
                comando.Parameters.AddWithValue("@correoCliente", correoCliente);
                comando.Parameters.AddWithValue("@telefonoCliente", telefonoCliente);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos" + ex, "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool EliminarCliente(int id)
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                string cadenaDelete = "DELETE FROM Clientes WHERE idCliente = @idCliente";
                SqlCommand comando = new SqlCommand(cadenaDelete, conexion);
                comando.Parameters.AddWithValue("@idCliente", id);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar datos" + ex, "Error al eliminar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool EditarCliente(int id)
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                string cadenaUpdate = "UPDATE Clientes SET nombreCliente = @nombreCliente, documentoCliente = @documentoCliente, correoCliente = @correoCliente, telefonoCliente = @telefonoCliente WHERE idCliente = @idCliente";
                SqlCommand comando = new SqlCommand(cadenaUpdate, conexion);
                comando.Parameters.AddWithValue("@nombreCliente", nombreCliente);
                comando.Parameters.AddWithValue("@documentoCliente", documentoCliente);
                comando.Parameters.AddWithValue("@correoCliente", correoCliente);
                comando.Parameters.AddWithValue("@telefonoCliente", telefonoCliente);
                comando.Parameters.AddWithValue("@idCliente", id);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar datos" + ex, "Error al editar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static DataTable BuscarCliente(string campo, string termino)
        {
            string columna = "";

            switch (campo)
            {
                case "Nro. Documento":
                    columna = "documentoCliente";
                    break;
                case "Nombre":
                    columna = "nombreCliente";
                    break;
                case "Correo":
                    columna = "correoCliente";
                    break;
                case "Teléfono":
                    columna = "telefonoCliente";
                    break;
                default:
                    return new DataTable();
            }

            try
            {
                using (SqlConnection conectar = ConexionDB.ConexionDB.Conectar())
                {
                    string query = $@"
                SELECT 
                    idCliente AS [Número de registro],
                    nombreCliente AS Cliente,
                    documentoCliente AS Documento,
                    correoCliente AS Correo,
                    telefonoCliente AS Teléfono
                FROM Clientes
                WHERE {columna} LIKE @termino";

                    SqlCommand comando = new SqlCommand(query, conectar);
                    comando.Parameters.AddWithValue("@termino", "%" + termino + "%");

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tablaBuscar = new DataTable();
                    adaptador.Fill(tablaBuscar);
                    return tablaBuscar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
