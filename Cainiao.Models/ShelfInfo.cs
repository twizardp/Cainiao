using Common.Attributes;

namespace Cainiao.Models
{
    [Table("ShelfInfos")]
    [PrimaryKey("ShelfId", AutoIncrement = true)]
    public class ShelfInfo
    {
        public int ShelfId { get; set; }
        public string ShelfNo { get; set; }
        public string ShelfName { get; set; }
        public int StationId { get; set; }
        public string Address { get; set; }
        public string Remark { get; set; }
    }
}