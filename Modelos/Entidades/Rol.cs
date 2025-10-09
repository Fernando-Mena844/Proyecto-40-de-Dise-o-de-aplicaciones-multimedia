using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Modelos.ConexionDB;

namespace Modelos
{
    public class Rol
    {
        public int idRol { get; set; }
        public string descripcionRol { get; set; }

        // Método para cargar roles desde la BD
        public static DataTable CargarRoles()
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                string query = "SELECT idRol, descripcionRol FROM Roles";

                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable tablaRoles = new DataTable();
                da.Fill(tablaRoles);

                return tablaRoles;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
