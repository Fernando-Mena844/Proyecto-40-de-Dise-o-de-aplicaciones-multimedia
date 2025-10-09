using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.ConexionDB
{
    public class ConexionDB
    {
        private static string servidor = ".\\SQLEXPRESS";
        private static string baseDatos = "Proyecto40_20220050_20250091";
        public static SqlConnection Conectar()
        {
            try
            {
                string cadenaConexion = $"Data Source={servidor};Initial Catalog={baseDatos};Integrated Security=True";
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar al servidor" + ex, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
