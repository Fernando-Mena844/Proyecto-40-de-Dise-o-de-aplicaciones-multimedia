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
            SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
            string consultaQuery = "select idCategoria as [Número de registro], descripcionCategoria as Categoría from Categorias";
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
        public static DataTable BuscarCategoria(string termino)
        {
            SqlConnection conectar = ConexionDB.ConexionDB.Conectar();
            string cadenaBuscar = "SELECT descripcionCategoria as [Categoria]" +
                "FROM Categorias " +
                $"WHERE descripcionCategoria LIKE '%{termino}%'";
            SqlDataAdapter data = new SqlDataAdapter(cadenaBuscar, conectar);
            DataTable tablaBuscar = new DataTable();
            data.Fill(tablaBuscar);
            return tablaBuscar;
        }

    }
}
