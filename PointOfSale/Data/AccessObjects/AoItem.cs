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
    public sealed class AoItem : IItemRepository
    {
        private Builder builder = Builder.Instance;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader rdr;
        private String query;
        private const string table = "item";
        private AoItem()
        {
            conn = new MySqlConnection(Server.Instance.GetConnectionString());
        }

        private static readonly Lazy<AoItem> instance = new Lazy<AoItem>(() => new AoItem());
        public static AoItem Instance { get => instance.Value; }

        public Item Select(string identifier, string value)
        {
            Item result = null;
            try
            {
                conn.Open();
                query = builder.SelectQuery(table, identifier);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, identifier, value);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result = new Item(
                            rdr.GetInt32(0),
                            rdr.GetString(1),
                            rdr.GetInt32(2),
                            rdr.GetInt32(3),
                            rdr.GetDouble(4),
                            rdr.IsDBNull(5) ? 0 : rdr.GetInt32(5),
                            rdr.GetDateTime(6),
                            rdr.IsDBNull(7) ? 0 : rdr.GetInt32(7),
                            rdr.GetDateTime(8)
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

        public List<Item> SelectAll(string identifier, string value)
        {
            List<Item> result = new List<Item>();
            try
            {
                conn.Open();
                query = builder.SelectQuery(table, identifier);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, identifier, value);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result.Add(new Item(
                            rdr.GetInt32(0),
                            rdr.GetString(1),
                            rdr.GetInt32(2),
                            rdr.GetInt32(3),
                            rdr.GetDouble(4),
                            rdr.IsDBNull(5) ? 0 : rdr.GetInt32(5),
                            rdr.GetDateTime(6),
                            rdr.IsDBNull(7) ? 0 : rdr.GetInt32(7),
                            rdr.GetDateTime(8)
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

        public int Insert(Item item)
        {
            int result = 0;
            try
            {
                conn.Open();
                List<string> columns = new List<string>() { "name", "category_id", "stocks", "price", "create_uid", "id" };
                query = builder.InsertQuery(table, columns);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, columns, new List<object> { item.Name, item.CategoryId, item.Stocks, item.Price, item.CreateUid, item.Id });
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

        public int Update(Item item)
        {
            int result = 0;
            try
            {
                conn.Open();
                List<string> columns = new List<string>() { "name", "category_id", "stocks", "price", "write_uid" };
                query = builder.UpdateQuery(table, columns);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, columns, new List<object> { item.Name, item.CategoryId, item.Stocks, item.Price, item.WriteUid }, item.Id);
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
