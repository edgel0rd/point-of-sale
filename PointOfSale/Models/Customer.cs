using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BaseModels;

namespace PointOfSale.Models
{
    public class Customer : BaseModel
    {
        public string Name { get; set; }
        public double Points { get; set; }
        public string PhoneNumber { get; set; }
        
        public Customer(int id, string name, double points, string phoneNumber, int createUid, DateTime createDate, int writeUid, DateTime writeDate) : base(id,createDate,createUid,writeDate,writeUid)
        {
            Name = name;
            Points = points;
            PhoneNumber = phoneNumber;
        }

        public Customer(string name, double points,string phoneNumber, int createUid, int writeUid) : base(createUid, writeUid)
        {
            Name = name;
            Points = points;
            PhoneNumber = phoneNumber;
        }
    }
}
