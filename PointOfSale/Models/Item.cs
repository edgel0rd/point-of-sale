using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BaseModels;

namespace PointOfSale.Models
{
    public class Item : BaseModel
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int Stocks { get; set; }
        public double Price { get; set; }


        public Item(int id, string name, int categoryId, int stocks, double price, int createUid, DateTime createDate, int writeUid, DateTime writeDate) : base(id, createDate, createUid, writeDate, writeUid)
        {
            Name = name;
            CategoryId = categoryId;
            Stocks = stocks;
            Price = price;
        }

        public Item(string name, int category, int stocks, double price, int createUid, int writeUid) : base(createUid, writeUid)
        {
            Name = name;
            CategoryId = category;
            Stocks = stocks;
            Price = price;
        }
    }
}
