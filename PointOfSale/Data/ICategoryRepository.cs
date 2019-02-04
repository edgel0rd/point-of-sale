using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Models;

namespace PointOfSale.Data
{
    public interface ICategoryRepository
    {
        Category Select(string identifier, string value);
        List<Category> SelectAll(string identifier, string value);
        int Insert(Category category);
        int Update(Category category);
        int Delete(string identifier, string value);
    }
}
