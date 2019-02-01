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
        public Category Category { get; set; }
        public int Stocks { get; set; }
        public double Price { get; set; }


        public Item(int writeUid, string name, Category category, int stocks, double price, int id, DateTime createDate, int createUid, DateTime writeDate) : base(id, createDate, createUid, writeDate, writeUid)
        {
            Name = name;
            Category = category;
            Stocks = stocks;
            Price = price;
        }

        public Item(string name, Category category, int stocks, double price, int createUid, int writeUid) : base(createUid, writeUid)
        {
            Name = name;
            Category = category;
            Stocks = stocks;
            Price = price;
        }
    }
}
