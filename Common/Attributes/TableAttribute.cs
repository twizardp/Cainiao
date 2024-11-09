using System;

namespace Common.Attributes
{
    /// <summary>
    /// 表名特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public string TableName { get; protected set; }

        public TableAttribute(string tableName)
        {
            TableName = tableName;
        }
    }
}