using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BaseModels;

namespace PointOfSale.Models
{
    public class Transaction : BaseModel
    {
        public Customer Customer { get; set; }
        public List<Item> Items { get; set; }
        public double TotalPrice { get; set; }
        public bool Voided { get; set; }

        public Transaction(Customer customer, List<Item> items, double totalPrice, bool voided, int id, int createUid, DateTime createDate, int writeUid, DateTime writeDate) : base(id, createDate, createUid, writeDate, writeUid)
        {
            Customer = customer;
            Items = items;
            TotalPrice = totalPrice;
            Voided = voided;
        }

        public Transaction(Customer customer, List<Item> items, double totalPrice, bool voided, int createUid, int writeUid) : base(createUid,writeUid)
        {
            Customer = customer;
            Items = items;
            TotalPrice = totalPrice;
            Voided = voided;
        }
    }
}
