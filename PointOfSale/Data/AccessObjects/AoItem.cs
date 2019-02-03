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

        }

        private static readonly Lazy<AoItem> instance = new Lazy<AoItem>(() => new AoItem());
        public static AoItem Instance { get => instance.Value; }

        public Item Select(int id)
        {
            Item result = null;
            try
            {
                conn.Open();
                query = builder.SelectQuery(table, "id");
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, "id", id.ToString());
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

        public List<Item> SelectAll()
        {
            List<Item> result = new List<Item>();
            try
            {
                conn.Open();
                query = $"SELECT * FROM {table}";
                cmd = new MySqlCommand(query, conn);
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
                builder.PrepareCommand(cmd, columns, new List<object> { item.Name, item.CategoryId, item.Stocks, item.Price, item.WriteUid });
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

        public int Delete(int id)
        {
            int result = 0;
            try
            {
                conn.Open();
                query = builder.DeleteQuery(table, "id");
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, "id", id.ToString());
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
