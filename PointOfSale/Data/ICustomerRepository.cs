using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Models;

namespace PointOfSale.Data
{
    public interface ICustomerRepository
    {
        Customer Select(string identifier, string value);
        List<Customer> SelectAll(string identifier, string value);
        int Insert(Customer customer);
        int Update(Customer customer);
        int Delete(string identifier, string value);
    }
}
