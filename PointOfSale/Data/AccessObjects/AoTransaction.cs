using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PointOfSale.BaseModels;
using PointOfSale.Models;

namespace PointOfSale.Data.AccessObjects
{
    public sealed class AoTransaction : ITransactionRepository
    {
        private Builder builder = Builder.Instance;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader rdr;
        private String query;
        private const string table = "transaction";
        private AoTransaction()
        {
            conn = new MySqlConnection(Server.Instance.GetConnectionString());
        }

        private static readonly Lazy<AoTransaction> instance = new Lazy<AoTransaction>(() => new AoTransaction());

        public static AoTransaction Instance { get => instance.Value; }

        public Transaction Select(string identifier, string value)
        {
            Transaction result = null;
            try
            {
                conn.Open();
                query = builder.SelectQuery(table, identifier);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, identifier, value);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result = new Transaction(
                            rdr.GetInt32(0),
                            rdr.GetInt32(1),
                            rdr.GetInt32(2),
                            (Transaction.Status)Enum.ToObject(typeof(Transaction.Status), rdr.GetInt32(4)),
                            rdr.GetInt32(4),
                            rdr.GetDateTime(5),
                            rdr.GetInt32(6),
                            rdr.GetDateTime(7)
                            );
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public List<Transaction> SelectAll(string identifier, string value)
        {
            List<Transaction> result = new List<Transaction>();
            try
            {
                conn.Open();
                query = builder.SelectQuery(table, identifier);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, identifier, value);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result.Add(new Transaction(
                            rdr.GetInt32(0),
                            rdr.GetInt32(1),
                            rdr.GetInt32(2),
                            (Transaction.Status)Enum.Parse(typeof(Transaction.Status), rdr.GetString(3)),
                            rdr.IsDBNull(4) ? 0 : rdr.GetInt32(4),
                            rdr.GetDateTime(5),
                            rdr.IsDBNull(6) ? 0 : rdr.GetInt32(6),
                            rdr.GetDateTime(7)
                        ));
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public List<Transaction> SelectToday()
        {
            List<Transaction> result = new List<Transaction>();
            try
            {
                conn.Open();
                query = $"SELECT * FROM {table} WHERE create_date LIKE '{DateTime.Now.ToString("yyyy-MM-dd")}%' AND Condition = '1'";
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result.Add(new Transaction(
                            rdr.GetInt32(0),
                            rdr.GetInt32(1),
                            rdr.GetInt32(2),
                            (Transaction.Status)Enum.Parse(typeof(Transaction.Status), rdr.GetString(3)),
                            rdr.IsDBNull(5) ? 0 : rdr.GetInt32(5),
                            rdr.GetDateTime(5),
                            rdr.IsDBNull(6) ? 0 : rdr.GetInt32(6),
                            rdr.GetDateTime(7)
                        ));
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public int Insert(Transaction transaction)
        {
            int result = 0;
            try
            {
                conn.Open();
                List<string> columns = new List<string>() { "customer_id", "employee_id", "condition", "create_uid" };
                query = builder.InsertQuery(table, columns);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, columns, new List<object>() { transaction.CustomerId, transaction.EmployeeId, transaction.Condition, transaction.CreateUid });
                cmd.ExecuteNonQuery();
                result = (int)cmd.LastInsertedId;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public int Update(Transaction transaction)
        {
            int result = 0;
            try
            {
                conn.Open();
                List<string> columns = new List<string>() { "customer_id", "employee_id", "condition", "write_uid" };
                query = builder.UpdateQuery(table, columns);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, columns, new List<object>() { transaction.CustomerId, transaction.EmployeeId, transaction.Condition, transaction.WriteUid }, transaction.Id);
                result = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public int Delete(string identifier, string value)
        {
            int result = 0;
            try
            {
                conn.Open();
                query = builder.DeleteQuery(table, identifier);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, identifier, value);
                result = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
