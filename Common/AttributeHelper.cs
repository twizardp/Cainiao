using System;
using System.Reflection;
using Common.Attributes;

namespace Common
{
    public static class AttributeHelper
    {
        /// <summary>
        /// 获取映射表名
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetTableName(this Type type)
        {
            var tableName = string.Empty;
            var attribute = type.GetCustomAttribute<TableAttribute>();
            if (attribute != null)
                tableName = attribute.TableName;

            if (string.IsNullOrEmpty(tableName))
                tableName = type.Name;

            return tableName;
        }

        /// <summary>
        /// 获取映射列名
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static string GetColumnName(this PropertyInfo property)
        {
            var columnName = string.Empty;
            var attribute = property.GetCustomAttribute<ColumnAttribute>();

            if (attribute != null)
                columnName = attribute.ColumnName;

            if (string.IsNullOrEmpty(columnName))
                columnName = property.Name;

            return columnName;
        }

        /// <summary>
        /// 获取主键名
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetPrimaryKeyName(this Type type)
        {
            var primaryKeyName = string.Empty;
            var attribute = type.GetCustomAttribute<PrimaryKeyAttribute>();
            if (attribute != null)
                primaryKeyName = attribute.KeyName;

            return primaryKeyName;
        }

        /// <summary>
        /// 判断属性是否是主键
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static bool IsPrimaryKey(this PropertyInfo property)
        {
            var type = property.DeclaringType;
            var primaryKeyName = type.GetPrimaryKeyName(); // 获取类型的主键名
            var columnName = property.GetColumnName(); // 获取属性映射列名
            return (primaryKeyName == columnName);
        }

        /// <summary>
        /// 判断主键是否自增
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsAutoIncrement(this Type type)
        {
            var attribute = type.GetCustomAttribute<PrimaryKeyAttribute>();
            return attribute != null && attribute.AutoIncrement;
        }
    }
}