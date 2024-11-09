using System;
using Common.Attributes;

namespace Cainiao.Models
{
    [Table("EmployeeInfos")]
    [PrimaryKey("EmpId", AutoIncrement = true)]
    public class EmployeeInfo
    {
        public int EmpId { get; set; }
        public string EmpNo { get; set; }
        public string EmpName { get; set; }
        public string EmpPYNo { get; set; }
        public string Sex { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public int StationId { get; set; }
        public int EmpTypeId { get; set; }
        public bool IsOn { get; set; }
        public string Remark { get; set; }
    }
}