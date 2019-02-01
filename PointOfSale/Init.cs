using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BaseModels;
using MySql.Data.MySqlClient;

namespace PointOfSale
{
    public class Init
    {
        private MySqlConnection Conn;
        private MySqlCommand Cmd;
        private MySqlDataReader Reader;
        private Server mServer;

        private void CreateDatabase()
        {
            mServer = new Server(Properties.Settings.Default.DB_HOST);

            string query = $"CREATE DATABASE {Properties.Settings.Default.DB_NAME}";
            Cmd = new MySqlCommand
        }
    }
}
