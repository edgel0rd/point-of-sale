using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Models;

namespace PointOfSale.Data
{
    public interface ITransactionLineRepository
    {
        TransactionLine Select(string identifier, string value);
        List<TransactionLine> SelectAll(string identifier, string value);
        int Insert(TransactionLine line);
        int Update(TransactionLine line);
        int Delete(string identifier, string value);

    }
}
