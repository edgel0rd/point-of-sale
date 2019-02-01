using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.BaseModels
{
    public class Server
    {
        private String _ipAddress;

        public String Ip
        {
            get => _ipAddress;
            set
            {
                if (value != null)
                {
                    _ipAddress = value;
                    Properties.Settings.Default.DB_HOST = value;
                }
            }
        }
       
        public String User { get; }
        public String Password { get; }
        public String Database { get; }
        public Server()
        {
            Ip = "localhost";
            User = Properties.Settings.Default.DB_USER;
            Password = Properties.Settings.Default.DB_PASS;
            Database = Properties.Settings.Default.DB_NAME;
        }
        public Server(String ip)
        {
            Ip = ip;
            User = Properties.Settings.Default.DB_USER;
            Password = Properties.Settings.Default.DB_PASS;
            Database = Properties.Settings.Default.DB_NAME;
        }

        public String GetConnectionString()
        {
            return (
                $"server ={Ip}; " +
                $"user id = {User};" +
                $"password ={Password}; " +
                $"database ={Database}; " +
                "SslMode=none;"
            );
        }
        public String GetDbLessConnectionString()
        {
            return (
                $"server ={Ip}; " +
                $"user id = {User};" +
                $"password ={Password}; " +
                "SslMode=none;"
            );
        }
    }
}
