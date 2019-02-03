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
        Category Select(int  id);
        List<Category> SelectAll();
        int Insert(Category category);
        int Update(Category category);
        int Delete(int id);
    }
}
