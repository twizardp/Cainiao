using Common.Attributes;

namespace Cainiao.Models
{
    [Table("MenuInfos")]
    [PrimaryKey("MenuId", AutoIncrement = true)]
    public class MenuInfo
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public int ParentId { get; set; }
        public string MKey { get; set; }
        public string FrmURL { get; set; }
        public int MOrder { get; set; }
    }
}