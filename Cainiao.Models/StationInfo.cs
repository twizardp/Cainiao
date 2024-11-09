using Common.Attributes;

namespace Cainiao.Models
{
    [Table("StationInfos")]
    [PrimaryKey("StationId", AutoIncrement = true)]
    public class StationInfo
    {
        public int StationId { get; set; }
        public string StationNo { get; set; }
        public string StationName { get; set; }
        public string StationPYNo { get; set; }
        public string Address { get; set; }
        public string Manager { get; set; }
        public string Phone { get; set; }
        public string Remark { get; set; }
        public bool IsRunning { get; set; }
    }
}