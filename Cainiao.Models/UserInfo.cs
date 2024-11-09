using Common.Attributes;

namespace Cainiao.Models
{
    [Table("UserInfos")]
    [PrimaryKey("UserId", AutoIncrement = true)]
    public class UserInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool UserState { get; set; }
    }
}