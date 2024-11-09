using Common.Attributes;

namespace Cainiao.Models
{
    [Table("EmpTypeInfos")]
    [PrimaryKey("EmpTypeId",AutoIncrement = true)]
    public class EmpTypeInfo
    {
        public int EmpTypeId { get; set; }
        public string EmpTypeName { get; set; }
        public string Remark { get; set; }
    }
}