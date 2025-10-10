using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.ConexionDB;

namespace Modelos
{
  public  class Categorias
    {
        public int idCategorias { get; set; }
        public string descripcionCategoria { get; set; }

        public static DataTable CargarCategoria()
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.ConexionDB.Conectar())
                {
                    string query = "SELECT idCategoria, descripcionCategoria FROM Categorias";
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
                return null;
            }

        }
        public bool InsertarCategoria()
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                string cadena = "insert into Categorias values (@descripcionCategoria)";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@descripcionCategoria", descripcionCategoria);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos" + ex, "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool EliminarCategoria(int id)
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                string cadenaDelete = "DELETE FROM Categorias WHERE idCategoria = @idCategoria";
                SqlCommand comando = new SqlCommand(cadenaDelete, conexion);
                comando.Parameters.AddWithValue("@idCategoria", id);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar datos." + ex, "Error al eliminar datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool ActualizarCategoria(int id)
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                StringBuilder queryUpdate = new StringBuilder();
                queryUpdate.Append("UPDATE Categorias SET ");
                queryUpdate.Append("descripcionCategoria = @nombreCategoria ");
                queryUpdate.Append("WHERE idCategoria = @idCategoria");

                SqlCommand comando = new SqlCommand(queryUpdate.ToString(), conexion);
                comando.Parameters.AddWithValue("@nombreCategoria", descripcionCategoria);
                comando.Parameters.AddWithValue("@idCategoria", id);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar datos\n" + ex, "Error al actualizar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
