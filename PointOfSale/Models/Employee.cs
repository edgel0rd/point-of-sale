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
        public string Name { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Employee(string name, string role, string email, string password, int id, int createUid, DateTime createDate, int writeUid, DateTime writeDate) : base(id, createDate, createUid, writeDate, writeUid)
        {
            Name = name;
            Role = role;
            Email = email;
            Password = password;
        }

        public Employee(string name, string role, string email, string password, int createUid, int writeUid) : base(createUid, writeUid)
        {
            Name = name;
            Role = role;
            Email = email;
            Password = password;
        }
    }
}
