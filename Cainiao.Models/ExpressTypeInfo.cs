using Common.Attributes;

namespace Cainiao.Models
{
    [Table("ExpressTypeInfos")]
    [PrimaryKey("ETypeId", AutoIncrement = true)]
    public class ExpressTypeInfo
    {
        public int ETypeId { get; set; }
        public string ETypeName { get; set; }
        public string ETypePYNo { get; set; }
        public int ParentId { get; set; }
        public int OrderNum { get; set; }
        public string Remark { get; set; }
    }
}