using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BaseModels;

namespace PointOfSale.Models
{
    public class TransactionLine : BaseModel
    {
        public int TransactionId { get; set; }
        public int ItemId { get; set; }
        public double CurrentPrice { get; set; }
        public int Quantity { get; set; }

        public TransactionLine(int id, int transactionId, int itemId, double currentPrice, int quantity, int createUid, DateTime createDate, int writeUid, DateTime writeDate) : base(id,createDate,createUid,writeDate,writeUid)
        {
            TransactionId = transactionId;
            ItemId = itemId;
            CurrentPrice = currentPrice;
            Quantity = quantity;
        }

        public TransactionLine(int transactionId, int itemId, double currentPrice, int quantity, int createUid, int writeUid) : base(createUid, writeUid)
        {
            TransactionId = transactionId;
            ItemId = itemId;
            CurrentPrice = currentPrice;
            Quantity = quantity;
        }
    }
}
