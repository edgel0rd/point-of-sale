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
        public DateTime RegistrationDate { get; set; }
        
        public Customer(string name, double points, string phoneNumber, DateTime registrationDate, int id, DateTime createDate, int createUid, DateTime writeDate, int writeUid) : base(id,createDate,createUid,writeDate,writeUid)
        {
            Name = name;
            Points = points;
            PhoneNumber = phoneNumber;
            RegistrationDate = registrationDate;
        }

        public Customer(string name, double points,string phoneNumber, DateTime registrationDate, int createUid, int writeUid) : base(createUid, writeUid)
        {
            Name = name;
            Points = points;
            PhoneNumber = phoneNumber;
            RegistrationDate = registrationDate;
        }
    }
}
