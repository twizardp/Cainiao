using System;

namespace Common.Attributes
{
    /// <summary>
    /// 列名特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public string ColumnName { get; protected set; }

        public ColumnAttribute(string columnName)
        {
            ColumnName = columnName;
        }
    }
}