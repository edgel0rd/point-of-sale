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
        Item Select(int id);
        List<Item> SelectAll();
        int Insert(Item item);
        int Update(Item item);
        int Delete(int id);
    }
}
