using System;
using Common.Attributes;

namespace Cainiao.Models
{
    [Table("ExpDistributeInfos")]
    [PrimaryKey("DistributeId", AutoIncrement = true)]
    public class ExpDistributeInfo
    {
        public int DistributeId { get; set; }
        public int ExpId { get; set; }
        public int EmpId { get; set; }
        public bool IsSignFor { get; set; }
        public DateTime SignTime { get; set; }
        public DateTime DistributeTime { get; set; }
        public DateTime InsertTime { get; set; }
    }
}