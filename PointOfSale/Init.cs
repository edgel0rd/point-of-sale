using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BaseModels;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PointOfSale
{
    public class Init
    {

        private MySqlConnection conn = new MySqlConnection(Server.Instance.GetConnectionString());
        private MySqlCommand cmd;
        private MySqlDataReader reader;

        private void exec(string query)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
                Console.WriteLine("\n===================================\n" + query + "\n===================================\n");
            }
            finally
            {
                conn.Close();
            }
        }

        public void CreateDatabase()
        {
            string add = 
                "create_uid INT NULL, " +
                "create_date TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP, " +
                "write_uid INT NULL, " +
                "write_date TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP, " +
                "FOREIGN KEY(create_uid) REFERENCES employee(id), " +
                "FOREIGN KEY(write_uid) REFERENCES employee(id)";
            //DB
            MySqlConnection xconn = new MySqlConnection(Server.Instance.GetDbLessConnectionString());
            xconn.Open();
            cmd = new MySqlCommand($"CREATE DATABASE IF NOT EXISTS {Properties.Settings.Default.DB_NAME}", xconn);
            cmd.ExecuteNonQuery();
            xconn.Close();

            //employee
            exec($"CREATE TABLE IF NOT EXISTS employee(" +
                $"id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, " +
                $"name VARCHAR(128) NOT NULL, " +
                $"role ENUM('Administrator','Manager','Cashier') NOT NULL, " +
                $"email VARCHAR(128) NOT NULL UNIQUE KEY, " +
                $"password VARCHAR(128) NOT NULL, " +
                $"status ENUM('Active','Standby','Terminated') NOT NULL DEFAULT 'Active', " +
                $"{add});");

            //CUSTOMERS
            exec($"CREATE TABLE IF NOT EXISTS customer(" +
                $"id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, " +
                $"name VARCHAR(128) NOT NULL, " +
                $"points DOUBLE DEFAULT 0.00, " +
                $"phone_number VARCHAR(64), " +
                $"{add});");

            //CATEGORIES
            exec($"CREATE TABLE IF NOT EXISTS category(" +
                $"id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, " +
                $"name VARCHAR(128) NOT NULL, " +
                $"description VARCHAR(512), " +
                $"{add});");

            //ITEMS
            exec($"CREATE TABLE IF NOT EXISTS item(" +
                $"id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, " +
                $"name VARCHAR(128) NOT NULL, " +
                $"category_id INT, " +
                $"stocks INT NOT NULL DEFAULT 0, " +
                $"price DOUBLE DEFAULT 0.00, " +
                $"{add}, " +
                $"FOREIGN KEY(category_id) REFERENCES category(id));");

            //TRANSACTIONS
            exec($"CREATE TABLE IF NOT EXISTS transaction(" +
                $"id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, " +
                $"customer_id INT NULL, " +
                $"employee_id INT NOT NULL, " +
                $"status ENUM('Void','Valid') NOT NULL DEFAULT 'Valid', " +
                $"{add}, " +
                $"FOREIGN KEY(customer_id) REFERENCES employee(id));");

            //TRANSACTION LINES
            exec($"CREATE TABLE IF NOT EXISTS transaction_lines(" +
                $"id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, " +
                $"transaction_id INT NOT NULL, " +
                $"item_id INT NOT NULL, " +
                $"current_price DOUBLE NOT NULL DEFAULT 0.00, " +
                $"quantity INT NOT NULL DEFAULT 0, " +
                $"{add}, " +
                $"FOREIGN KEY(transaction_id) REFERENCES transaction(id), " +
                $"FOREIGN KEY(item_id) REFERENCES item(id));");
        }
    }
}
