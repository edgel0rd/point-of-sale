using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Models;

namespace PointOfSale.Data
{
    public interface IItemRepository
    {
        Item Select(string identifier, string value);
        List<Item> SelectAll(string identifier, string value);
        int Insert(Item item);
        int Update(Item item);
        int Delete(string identifier, string value);
    }
}
