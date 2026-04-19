using System;
using MySql.Data.MySqlClient;

namespace SimplyRugby_System
{
    /// <summary>
    /// Serves as the Data Access Layer (DAL) helper class.
    /// Centralizes and manages all underlying connections to the MySQL database.
    /// </summary>
    public static class DbHelper
    {
        /// <summary>
        /// The connection string defining the server parameters.
        /// Fix Attempt 2: Using 'Disabled' which is a common synonym for 'None' in older/specific drivers.
        /// If this still fails, please remove ';SslMode=Disabled' entirely from the string.
        /// </summary>
        private static readonly string connectionString = "Server=localhost;Database=simplyrugbydb;Uid=root;Pwd=123456;SslMode=Disabled;";

        /// <summary>
        /// Instantiates and returns an unopened MySQL database connection.
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            try
            {
                return new MySqlConnection(connectionString);
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Database initialization failed: {ex.Message}", ex);
            }
        }
    }
}