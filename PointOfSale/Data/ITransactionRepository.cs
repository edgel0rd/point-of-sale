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
        Transaction Select(int id);
        List<Transaction> SelectAll();
        List<Transaction> SelectToday();
        int Insert(Transaction transaction);
    }
}
