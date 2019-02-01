using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.BaseModels
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUid { get; set; }
        public DateTime WriteDate { get; set; }
        public int WriteUid { get; set; }

        public BaseModel(int createUid,int writeUid)
        {
            CreateUid = createUid;
            WriteUid = writeUid;
        }

        public BaseModel(int id, DateTime createDate, int createUid, DateTime writeDate, int writeUid)
        {
            Id = id;
            CreateDate = createDate;
            CreateUid = createUid;
            WriteDate = writeDate;
            WriteUid = writeUid;
        }

    }
}
