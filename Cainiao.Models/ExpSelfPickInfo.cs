using System;
using Common.Attributes;

namespace Cainiao.Models
{
    /// <summary>
    /// 自提记录表
    /// </summary>
    [Table("ExpSelfPickInfos")]
    [PrimaryKey("PickUpId", AutoIncrement = true)]
    public class ExpSelfPickInfo
    {
        public int PickUpId { get; set; }
        public int ExpId { get; set; }
        public string PickingCode { get; set; }
        public bool IsPickUp { get; set; }
        public DateTime PickingTime { get; set; }
        public DateTime InsertTime { get; set; }
    }
}