using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BaseModels;

namespace PointOfSale.Models
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Category(int id, string name, string description, int createUid, DateTime createDate, int writeUid, DateTime writeDate) : base(id, createDate, createUid, writeDate, writeUid)
        {
            Name = name;
            Description = description;
        }

        public Category(string name, string description, int createUid, int writeUid) : base(createUid, writeUid)
        {
            Name = name;
            Description = description;
        }
    }
}
