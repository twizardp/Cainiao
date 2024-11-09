using System;

namespace Common.Attributes
{
    /// <summary>
    /// 主键特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class PrimaryKeyAttribute : Attribute
    {
        public string KeyName { get; protected set; }
        public bool AutoIncrement = false;

        public PrimaryKeyAttribute(string keyName)
        {
            KeyName = keyName;
        }
    }
}