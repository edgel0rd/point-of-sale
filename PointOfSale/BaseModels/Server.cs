using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.BaseModels
{
    public sealed class Server
    {
        public String Ip { get; }       
        public String User { get; }
        public String Password { get; }
        public String Database { get; }
        private Server()
        {
            Ip = Properties.Settings.Default.DB_HOST;
            User = Properties.Settings.Default.DB_USER;
            Password = Properties.Settings.Default.DB_PASS;
            Database = Properties.Settings.Default.DB_NAME;
        }
        public static readonly Lazy<Server> server = new Lazy<Server>(() => new Server());
        public static Server Instance
        {
            get => server.Value;
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
