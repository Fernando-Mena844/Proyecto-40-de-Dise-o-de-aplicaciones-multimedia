using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using Modelos.ConexionDB;

namespace Modelos
{
    public class Tickets
    {
        public int idTicket { get; set; }
        public string descripcionTicket { get; set; }
        public int categoria_id { get; set; }
        public int cliente_id { get; set; }
        public int usuario_id { get; set; }
        public DateTime fechaRecibido { get; set; }
        public DateTime? fechaEntrega { get; set; }


        // Método NUEVO: Cargar tickets según el rol del usuario
        public static DataTable CargarTicketsPorRol(int usuarioId, int rolId)
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                string consultaQuery = "";

                if (rolId == 3) // Si es Cliente (ID 3)
                {
                    consultaQuery = @"
                        SELECT 
                            T.idTicket AS [ID],
                            T.descripcionTicket AS [Descripción],
                            C.descripcionCategoria AS [Categoría],
                            T.fechaRecibido AS [Fecha Recibido],
                            T.fechaEntrega AS [Fecha Entrega]
                        FROM Tickets T
                        INNER JOIN Categorias C ON T.categoria_id = C.idCategoria
                        WHERE T.usuario_id = @usuarioId";
                }
                else // Si es Administrador o Técnico (ver todos)
                {
                    consultaQuery = @"
                        SELECT 
                            T.idTicket AS [ID],
                            T.descripcionTicket AS [Descripción],
                            C.descripcionCategoria AS [Categoría],
                            CL.nombreCliente AS [Cliente],
                            U.nombreUsuario AS [Usuario],
                            T.fechaRecibido AS [Fecha Recibido],
                            T.fechaEntrega AS [Fecha Entrega]
                        FROM Tickets T
                        INNER JOIN Categorias C ON T.categoria_id = C.idCategoria
                        INNER JOIN Clientes CL ON T.cliente_id = CL.idCliente
                        INNER JOIN Usuarios U ON T.usuario_id = U.idUsuario";
                }

                SqlCommand comando = new SqlCommand(consultaQuery, conexion);

                // Solo agregar parámetro si es Cliente
                if (rolId == 3)
                {
                    comando.Parameters.AddWithValue("@usuarioId", usuarioId);
                }

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tablaTickets = new DataTable();
                adaptador.Fill(tablaTickets);
                return tablaTickets;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tickets: " + ex.Message);
                return null;
            }
        }

        // Método NUEVO: Buscar tickets según el rol del usuario
        public static DataTable BuscarTicketPorRol(string campo, string termino, int usuarioId, int rolId)
        {
            string columna = "";

            switch (campo)
            {
                case "Descripción":
                    columna = "T.descripcionTicket";
                    break;
                case "Cliente":
                    columna = "CL.nombreCliente";
                    break;
                case "Usuario":
                    columna = "U.nombreUsuario";
                    break;
                case "Categoría":
                    columna = "C.descripcionCategoria";
                    break;
                default:
                    return new DataTable();
            }

            try
            {
                using (SqlConnection conexion = ConexionDB.ConexionDB.Conectar())
                {
                    string query = "";

                    if (rolId == 3) // Cliente
                    {
                        query = $@"
                            SELECT 
                                T.idTicket AS [ID],
                                T.descripcionTicket AS [Descripción],
                                C.descripcionCategoria AS [Categoría],
                                T.fechaRecibido AS [Fecha Recibido],
                                T.fechaEntrega AS [Fecha Entrega]
                            FROM Tickets T
                            INNER JOIN Categorias C ON T.categoria_id = C.idCategoria
                            WHERE T.usuario_id = @usuarioId AND {columna} LIKE @termino";
                    }
                    else // Administrador o Técnico
                    {
                        query = $@"
                            SELECT 
                                T.idTicket AS [ID],
                                T.descripcionTicket AS [Descripción],
                                C.descripcionCategoria AS [Categoría],
                                CL.nombreCliente AS [Cliente],
                                U.nombreUsuario AS [Usuario],
                                T.fechaRecibido AS [Fecha Recibido],
                                T.fechaEntrega AS [Fecha Entrega]
                            FROM Tickets T
                            INNER JOIN Categorias C ON T.categoria_id = C.idCategoria
                            INNER JOIN Clientes CL ON T.cliente_id = CL.idCliente
                            INNER JOIN Usuarios U ON T.usuario_id = U.idUsuario
                            WHERE {columna} LIKE @termino";
                    }

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@termino", "%" + termino + "%");

                    if (rolId == 3)
                    {
                        comando.Parameters.AddWithValue("@usuarioId", usuarioId);
                    }

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tablaBuscar = new DataTable();
                    adaptador.Fill(tablaBuscar);
                    return tablaBuscar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Cargar todos los tickets
        public static DataTable CargarTickets()
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                string consultaQuery = @"
                    SELECT 
                        T.idTicket AS [ID],
                        T.descripcionTicket AS [Descripción],
                        C.descripcionCategoria AS [Categoría],
                        CL.nombreCliente AS [Cliente],
                        U.nombreUsuario AS [Usuario],
                        T.fechaRecibido AS [Fecha Recibido],
                        T.fechaEntrega AS [Fecha Entrega]
                    FROM Tickets T
                    INNER JOIN Categorias C ON T.categoria_id = C.idCategoria
                    INNER JOIN Clientes CL ON T.cliente_id = CL.idCliente
                    INNER JOIN Usuarios U ON T.usuario_id = U.idUsuario";

                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                DataTable tablaCarga = new DataTable();
                add.Fill(tablaCarga);
                return tablaCarga;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tickets: " + ex.Message);
                return null;
            }
        }

        // Insertar ticket
        public bool InsertarTicket()
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                string cadena = @"INSERT INTO Tickets 
                                (descripcionTicket, categoria_id, cliente_id, usuario_id, fechaRecibido, fechaEntrega) 
                                VALUES (@descripcionTicket, @categoria_id, @cliente_id, @usuario_id, @fechaRecibido, @fechaEntrega)";

                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@descripcionTicket", descripcionTicket);
                comando.Parameters.AddWithValue("@categoria_id", categoria_id);
                comando.Parameters.AddWithValue("@cliente_id", cliente_id);
                comando.Parameters.AddWithValue("@usuario_id", usuario_id);
                comando.Parameters.AddWithValue("@fechaRecibido", fechaRecibido);
                comando.Parameters.AddWithValue("@fechaEntrega", (object)fechaEntrega ?? DBNull.Value);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Eliminar ticket
        public bool EliminarTicket(int id)
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                string cadenaDelete = "DELETE FROM Tickets WHERE idTicket = @idTicket";

                SqlCommand comando = new SqlCommand(cadenaDelete, conexion);
                comando.Parameters.AddWithValue("@idTicket", id);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Actualizar ticket
        public bool ActualizarTicket()
        {
            try
            {
                SqlConnection conexion = ConexionDB.ConexionDB.Conectar();
                StringBuilder queryUpdate = new StringBuilder();
                queryUpdate.Append("UPDATE Tickets SET ");
                queryUpdate.Append("descripcionTicket = @descripcionTicket, ");
                queryUpdate.Append("categoria_id = @categoria_id, ");
                queryUpdate.Append("cliente_id = @cliente_id, ");
                queryUpdate.Append("usuario_id = @usuario_id, ");
                queryUpdate.Append("fechaRecibido = @fechaRecibido, ");
                queryUpdate.Append("fechaEntrega = @fechaEntrega ");
                queryUpdate.Append("WHERE idTicket = @idTicket");

                SqlCommand comando = new SqlCommand(queryUpdate.ToString(), conexion);
                comando.Parameters.AddWithValue("@descripcionTicket", descripcionTicket);
                comando.Parameters.AddWithValue("@categoria_id", categoria_id);
                comando.Parameters.AddWithValue("@cliente_id", cliente_id);
                comando.Parameters.AddWithValue("@usuario_id", usuario_id);
                comando.Parameters.AddWithValue("@fechaRecibido", fechaRecibido);
                comando.Parameters.AddWithValue("@fechaEntrega", (object)fechaEntrega ?? DBNull.Value);
                comando.Parameters.AddWithValue("@idTicket", idTicket);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Buscar ticket por descripción, cliente o usuario
        public static DataTable BuscarTicket(string campo, string termino)
        {
            string columna = "";

            switch (campo)
            {
                case "Descripción":
                    columna = "T.descripcionTicket";
                    break;
                case "Cliente":
                    columna = "CL.nombreCliente";
                    break;
                case "Usuario":
                    columna = "U.nombreUsuario";
                    break;
                case "Categoría":
                    columna = "C.descripcionCategoria";
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
                            T.idTicket AS [ID],
                            T.descripcionTicket AS [Descripción],
                            C.descripcionCategoria AS [Categoría],
                            CL.nombreCliente AS [Cliente],
                            U.nombreUsuario AS [Usuario],
                            T.fechaRecibido AS [Fecha Recibido],
                            T.fechaEntrega AS [Fecha Entrega]
                        FROM Tickets T
                        INNER JOIN Categorias C ON T.categoria_id = C.idCategoria
                        INNER JOIN Clientes CL ON T.cliente_id = CL.idCliente
                        INNER JOIN Usuarios U ON T.usuario_id = U.idUsuario
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
                MessageBox.Show("Error al buscar ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}