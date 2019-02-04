using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Models;
using PointOfSale.BaseModels;
using MySql.Data.MySqlClient;

namespace PointOfSale.Data.AccessObjects
{
    public sealed class AoCategory : ICategoryRepository
    {
        private Builder builder = Builder.Instance;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader rdr;
        private String query;
        private const string table = "category";
        private AoCategory()
        {
            conn = new MySqlConnection(Server.Instance.GetConnectionString());
        }
        private static readonly Lazy<AoCategory> instance = new Lazy<AoCategory>(() => new AoCategory());
        public static AoCategory Instance { get => instance.Value; }
        
        public int Delete(string identifier, string value)
        {
            int result = 0;
            try
            {
                conn.Open();
                query = builder.DeleteQuery(table, identifier);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, identifier, value);
                result = (int)cmd.ExecuteNonQuery();
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

        public int Insert(Category category)
        {
            int result = 0;
            try
            {
                conn.Open();
                List<string> columns = new List<string>() { "name", "description", "create_uid" };
                query = builder.InsertQuery(table, columns);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, columns, new List<object> { category.Name, category.Description, category.CreateUid });
                result = (int)cmd.ExecuteNonQuery();
            }catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public Category Select(string identifier, string value)
        {
            Category result = null;
            try
            {
                conn.Open();
                query = builder.SelectQuery(table, identifier);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, identifier, value);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result = new Category(
                        rdr.GetInt32(0),
                        rdr.GetString(1),
                        rdr.GetString(2),
                        rdr.IsDBNull(3) ? 0 : rdr.GetInt32(3),
                        rdr.GetDateTime(4),
                        rdr.IsDBNull(5) ? 0 : rdr.GetInt32(5),
                        rdr.GetDateTime(6)
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

        public List<Category> SelectAll(string identifier, string value)
        {
            List<Category> result = new List<Category>();
            try
            {
                conn.Open();
                query = builder.SelectQuery(table, identifier);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, identifier, value);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result.Add(new Category(
                        rdr.GetInt32(0),
                        rdr.GetString(1),
                        rdr.GetString(2),
                        rdr.IsDBNull(3) ? 0 : rdr.GetInt32(3),
                        rdr.GetDateTime(4),
                        rdr.IsDBNull(5) ? 0 : rdr.GetInt32(5),
                        rdr.GetDateTime(6)
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

        public int Update(Category category)
        {
            int result = 0;
            try
            {
                conn.Open();
                List<string> columns = new List<string>() { "name", "description", "write_uid" };
                query = builder.UpdateQuery(table, columns);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, columns, new List<object>() { category.Name, category.Description, category.WriteUid }, category.Id);
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
