using System;
using Common.Attributes;

namespace Cainiao.Models
{
    [Table("ExpressInfos")]
    [PrimaryKey("ExpId", AutoIncrement = true)]
    public class ExpressInfo
    {
        public int ExpId { get; set; }
        public string ExpNumber { get; set; }
        public int StationId { get; set; }
        public int ShelfId { get; set; }
        public string Sender { get; set; }
        public string SendAddress { get; set; }
        public string Receiver { get; set; }
        public string ReceiveAddress { get; set; }
        public string ReceivePhone { get; set; }
        public string ExpRemark { get; set; }
        public string ExpState { get; set; }
        public string ExpType { get; set; }
        public DateTime EnterTime { get; set; }
        public string PickWay { get; set; }
    }
}