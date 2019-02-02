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
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public bool Voided { get; set; }

        public Transaction(int customerId, int employeeId, bool voided, int id, int createUid, DateTime createDate, int writeUid, DateTime writeDate) : base(id, createDate, createUid, writeDate, writeUid)
        {
            CustomerId = customerId;
            EmployeeId = employeeId;
            Voided = voided;
        }

        public Transaction(int customerId, int employeeId, bool voided, int createUid, int writeUid) : base(createUid,writeUid)
        {
            CustomerId = customerId;
            EmployeeId = employeeId;
            Voided = voided;
        }
    }
}
