using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Models;
using MySql.Data.MySqlClient;
using PointOfSale.BaseModels;

namespace PointOfSale.Data.AccessObjects
{
    public sealed class AoTransactionLine : ITransactionLineRepository
    {
        private Builder builder = Builder.Instance;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader rdr;
        private String query;
        private const string table = "transaction_lines";

        private AoTransactionLine()
        {
            conn = new MySqlConnection(Server.Instance.GetConnectionString());
        }

        private static readonly Lazy<AoTransactionLine> instance = new Lazy<AoTransactionLine>(() => new AoTransactionLine());

        public static AoTransactionLine Instance { get => instance.Value; }

        public TransactionLine Select(string identifier, string value)
        {
            TransactionLine result = null;
            try
            {
                conn.Open();
                query = builder.SelectQuery(table, identifier);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, identifier, value);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result = new TransactionLine(
                        rdr.GetInt32(0), 
                        rdr.GetInt32(1),
                        rdr.GetInt32(2), 
                        rdr.GetDouble(3), 
                        rdr.GetInt32(4), 
                        rdr.GetInt32(5), 
                        rdr.GetDateTime(6), 
                        rdr.GetInt32(7), 
                        rdr.GetDateTime(8)
                        );
                }
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public List<TransactionLine> SelectAll(string identifier, string value)
        {
            List<TransactionLine> result = new List<TransactionLine>();
            try
            {
                conn.Open();
                query = builder.SelectQuery(identifier, value);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, identifier, value);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result.Add(new TransactionLine(
                        rdr.GetInt32(0),
                        rdr.GetInt32(1), 
                        rdr.GetInt32(2),
                        rdr.GetDouble(3), 
                        rdr.GetInt32(4), 
                        rdr.GetInt32(5),
                        rdr.GetDateTime(6), 
                        rdr.GetInt32(7),
                        rdr.GetDateTime(8)));
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

        public int Insert(TransactionLine line)
        {
            int result = 0;
            try
            {
                conn.Open();
                List<string> columns = new List<string>() { "transaction_id", "item_id", "current_price", "quantity", "create_uid" };
                query = builder.InsertQuery(table, columns);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, columns, new List<object>() { line.TransactionId, line.ItemId, line.CurrentPrice, line.Quantity, line.CreateUid });
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

        public int Update(TransactionLine line)
        {
            int result = 0;
            try
            {
                conn.Open();
                List<string> columns = new List<string>() { "transaction_id", "item_id", "current_price", "quantity", "write_uid" };
                query = builder.UpdateQuery(table, columns);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, columns, new List<object>() { line.TransactionId, line.ItemId, line.CurrentPrice, line.Quantity, line.WriteUid }, line.Id);
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
