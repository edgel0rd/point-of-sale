using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PointOfSale
{
    public sealed class Builder
    {
        private Builder() { }
        private static readonly Lazy<Builder> instance = new Lazy<Builder>(() => new Builder());
        public static Builder Instance { get => instance.Value; }

        public string InsertQuery(string table, List<string> columns, string extra = "")
        {
            string comma = "";
            string result = "(";
            foreach(string col in columns)
            {
                result += $"{comma} `{col}`";
                comma = ",";
            }
            result += ") VALUES (";
            comma = "";
            foreach(string col in columns)
            {
                result += $"{comma} @{col}";
                comma = ",";
            }
            result += $"){extra}";

            return $"INSERT INTO `{table}` {result}";
        }

        public string UpdateQuery(string table, List<string> columns, string extra = "")
        {
            string comma = "";
            string result = "";
            foreach(string col in columns)
            {
                result += $"{comma}`{col}`=@{col}";
                comma = ", ";
            }
            result += " WHERE `id`=@id";
            return $"UPDATE `{table}` SET {result} {extra}";
        }

        public string DeleteQuery(string table, string identifier)
        {
            return $"DELETE FROM `{table}` WHERE `{identifier}`=@{identifier}";
        }

        public string SelectQuery(string table, string identifier)
        {
            return $"SELECT * FROM `{table}` WHERE `{identifier}`=@{identifier}";
        }

        public void PrepareCommand(MySqlCommand cmd,List<string> columns,List<object> values)
        {
            cmd.Prepare();
            foreach(string col in columns)
            {
                cmd.Parameters.AddWithValue($"@{col}", values[columns.IndexOf(col)].ToString());
            }
        }
        public void PrepareCommand(MySqlCommand cmd, string col, string value)
        {
            cmd.Prepare();
            cmd.Parameters.AddWithValue($"@{col}", value);
        }

    }
}
