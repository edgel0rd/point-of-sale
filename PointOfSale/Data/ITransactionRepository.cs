using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Models;

namespace PointOfSale.Data
{
    public interface ITransactionRepository
    {
        Transaction Select(string identifier, string value);
        List<Transaction> SelectAll(string identifier, string value);
        List<Transaction> SelectToday();
        int Insert(Transaction transaction);
        int Update(Transaction transaction);
        int Delete(string identifier, string value);
    }
}
