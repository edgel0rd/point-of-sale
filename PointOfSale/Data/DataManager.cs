using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PointOfSale.Data
{
    public sealed class DataManager 
    {
        private DataManager()
        {

        }
        public static readonly Lazy<DataManager> instance = new Lazy<DataManager>(() => new DataManager());
        public static DataManager Instance
        {
            get => instance.Value;
        }

       

    }
}
