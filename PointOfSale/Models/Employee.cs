using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BaseModels;

namespace PointOfSale.Models
{
    public class Employee : BaseModel
    {
        public enum Statuses
        {
            Active,
            Standby,
            Terminated
        }
        public enum Roles
        {
            Admin,
            Manager,
            Cashier
        }
        public string Name { get; set; }
        public Roles Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Statuses Status { get; set; }

        public Employee(int id, string name, Roles role, string email, string password, Statuses condition, int createUid, DateTime createDate, int writeUid, DateTime writeDate) : base(id, createDate, createUid, writeDate, writeUid)
        {
            Name = name;
            Role = role;
            Email = email;
            Password = password;
            Status = condition;
        }

        public Employee(string name, Roles role, string email, string password, int createUid, int writeUid, Statuses condition = Statuses.Active) : base(createUid, writeUid)
        {
            Name = name;
            Role = role;
            Email = email;
            Password = password;
            Status = condition;
        }


        
    }
}
