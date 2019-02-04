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
    public sealed class AoCustomer : ICustomerRepository
    {
        private Builder builder = Builder.Instance;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader rdr;
        private String query;
        private const string table = "customer";
        private AoCustomer()
        {
            conn = new MySqlConnection(Server.Instance.GetConnectionString());
        }
        private static readonly Lazy<AoCustomer> instance = new Lazy<AoCustomer>(() => new AoCustomer());
        public static AoCustomer Instance { get => instance.Value; }

        public Customer Select(string identifier, string value)
        {
            Customer customer = null;
            try
            {
                conn.Open();
                query = builder.SelectQuery(table, identifier);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, identifier, value);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    customer = new Customer(
                        rdr.GetInt32(0),
                        rdr.GetString(1),
                        rdr.GetDouble(3),
                        rdr.GetString(5),
                        rdr.IsDBNull(6) ? 0 : rdr.GetInt32(6),
                        rdr.GetDateTime(7),
                        rdr.IsDBNull(8) ? 0 : rdr.GetInt32(8),
                        rdr.GetDateTime(9)
                        );
                }
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return customer;
        }

        public List<Customer> SelectAll(string identifier, string value)
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                conn.Open();
                query = builder.SelectQuery(table, identifier);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, identifier, value);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    customers.Add(
                        new Customer(
                            rdr.GetInt32(0),
                            rdr.GetString(1),
                            rdr.GetDouble(3),
                            rdr.GetString(5),
                            rdr.IsDBNull(6) ? 0 : rdr.GetInt32(6),
                            rdr.GetDateTime(7),
                            rdr.IsDBNull(8) ? 0 : rdr.GetInt32(8),
                            rdr.GetDateTime(9)
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
            return customers;
        }

        public int Insert(Customer customer)
        {
            int result = 0;
            try
            {
                conn.Open();
                List<string> columns = new List<string> { "name", "phone_number", "create_uid", "write_uid"};
                query = builder.InsertQuery(table, columns);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, columns,new List<object> { customer.Name, customer.PhoneNumber, customer.CreateUid, customer.WriteUid });
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

        public int Update(Customer customer)
        {
            int result = 0;
            try
            {
                conn.Open();
                List<string> columns = new List<string> { "name", "points", "phone_number", "write_uid" };
                query = builder.InsertQuery(table, columns);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, columns, new List<object> { customer.Name, customer.Points, customer.PhoneNumber, customer.WriteUid }, customer.Id);
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
