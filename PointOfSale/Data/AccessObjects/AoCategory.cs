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
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader rdr;
        private String query;
        private AoCategory()
        {
            conn = new MySqlConnection(Server.Instance.GetConnectionString());
        }
        private static readonly Lazy<AoCategory> instance = new Lazy<AoCategory>(() => new AoCategory());
        public static AoCategory Instance { get => instance.Value; }
        
        public int Delete(int id)
        {
            int result = 0;
            try
            {
                conn.Open();
                query = "DELETE FROM category WHERE id=@id";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", id);
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
                query = "INSERT INTO category(name,description,create_uid,write_uid) VALUES(@name,@desc,@cuid,@wuid)";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", category.Id);
                cmd.Parameters.AddWithValue("@desc", category.Description);
                cmd.Parameters.AddWithValue("@cuid", category.CreateUid);
                cmd.Parameters.AddWithValue("@wuid", category.WriteUid);
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

        public Category Select(int id)
        {
            Category category = null;
            try
            {
                conn.Open();
                query = "SELECT * FROM category WHERE id=@id";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", id);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    category = new Category(
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
            return category;
        }

        public List<Category> SelectAll()
        {
            List<Category> categories = new List<Category>();
            try
            {
                conn.Open();
                query = "SELECT * FROM category";
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    categories.Add(new Category(
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
            return categories;
        }

        public int Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
