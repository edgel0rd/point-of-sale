using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PointOfSale.Models;
using PointOfSale.BaseModels;

namespace PointOfSale.Data.AccessObjects
{
    public sealed class AoEmployee : IEmployeeRepository
    {
        private Builder builder = Builder.Instance;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader rdr;
        private String query;
        private const string table = "employee";
        private AoEmployee()
        {
            conn = new MySqlConnection(Server.Instance.GetConnectionString());
        }

        private static readonly Lazy<AoEmployee> instance = new Lazy<AoEmployee>(() => new AoEmployee());

        public static AoEmployee Instance { get => instance.Value; }

        public Employee Select(int id)
        {
            Employee result = null;
            try
            {
                conn.Open();
                query = builder.SelectQuery(table, "id");
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, "id", id.ToString());
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result = new Employee(
                        rdr.GetInt32(0),
                        rdr.GetString(1),
                        rdr.GetString(2),
                        rdr.GetString(3),
                        rdr.GetString(4),
                        (Employee.Account)Enum.Parse(typeof(Employee.Account), rdr.GetString(5)),
                        rdr.IsDBNull(6) ? 0 : rdr.GetInt32(6),
                        rdr.GetDateTime(7),
                        rdr.IsDBNull(8) ? 0 : rdr.GetInt32(8),
                        rdr.GetDateTime(9)
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

        public List<Employee> SelectAll()
        {
            List<Employee> result = new List<Employee>();
            try
            {
                conn.Open();
                query = $"SELECT * FROM {table}";
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result.Add(new Employee(
                        rdr.GetInt32(0),
                        rdr.GetString(1),
                        rdr.GetString(2),
                        rdr.GetString(3),
                        rdr.GetString(4),
                        (Employee.Account)Enum.Parse(typeof(Employee.Account), rdr.GetString(5)),
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
            return result;
        }

        public int Insert(Employee employee)
        {
            int result = 0;
            try
            {
                conn.Open();
                List<string> columns = new List<string> { "name", "role", "email", "password", "status", "create_uid" };
                query = builder.InsertQuery(table, columns);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, columns, new List<object> { employee.Name, employee.Role, employee.Email, employee.Password, employee.Status, employee.CreateUid });
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

        public int Update(Employee employee)
        {
            int result = 0;
            try
            {
                conn.Open();
                List<string> columns = new List<string> { "name", "role", "email", "password", "status", "write_uid", "id" };
                query = builder.UpdateQuery(table, columns);
                cmd = new MySqlCommand(query, conn);
                builder.PrepareCommand(cmd, columns, new List<object> { employee.Name, employee.Role, employee.Email, employee.Password, employee.Status, employee.WriteUid, employee.Id });
                result = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(query);
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
