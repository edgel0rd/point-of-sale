using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Models;

namespace PointOfSale.Data
{
    public interface IEmployeeRepository
    {
        Employee Select(string identifier, string value);
        List<Employee> SelectAll(string identifier, string value);
        int Insert(Employee employee);
        int Update(Employee employee);
        int Delete(string identifier, string value);

    }
}
