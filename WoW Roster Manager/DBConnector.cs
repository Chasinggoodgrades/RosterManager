using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WoW_Roster_Manager
{
    internal class DBConnector
    {
        private const string ConnectionString = "server=localhost;user=root;database=users;port=3306;password=1234"; // Put DB Info Here


        private MySqlConnection connection;

        public DBConnector()
        {
            connection = new MySqlConnection(ConnectionString);
        }

        public void Connect()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connected to the database.");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"An error occurred while connecting to the database: {ex.Message}");
            }
        }

        public void Disconnect()
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Disconnected from the database.");
            }
        }


        public void ExecuteQuery(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"An error occurred while executing the query: {ex.Message}");
            }
        }

         /* Authenticate a user
         * @param username The username of the account
         * @param password The password of the account                     
         */
        public bool Authenticate(string username, string password)
        {
            string query = "SELECT * FROM accounts WHERE username = @username AND password = SHA(@password)";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /* Register a new account
         * @param username The username of the new account
         * @param password The password of the new account
         */
        public bool Register(string username, string password)
        {
            string query = "INSERT INTO accounts (username, password) VALUES (@username, SHA(@password))";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0; // If rows were affected, registration was successful
            }
        }
    }
}
