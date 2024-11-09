using System;
using System.Data.SqlClient;
using System.Linq;
using Cainiao.DAL.Base;
using Common;

namespace Cainiao.DAL
{
    public class CreateSql
    {
        public static SqlModel CreateInsertSql<T>(T model, string columns, bool isReturn)
        {
            var type = typeof(T);
            var tableName = type.GetTableName();
            var primaryKeyName = type.GetPrimaryKeyName();

            if (type.IsAutoIncrement())
            {
                // 移除主键
                if (columns.Contains(primaryKeyName))
                    columns = RemoveStringItem(columns, primaryKeyName);
            }
            else
            {
                if (!columns.Contains(primaryKeyName))
                    throw new Exception("主键列不能为空");
            }

            var properties = PropertyHelper.GetProperties<T>(columns);
            var strCols = string.Join(",", properties.Select(x => x.GetColumnName()));
            var paraCols = string.Join(",", properties.Select(x => "@" + x.Name));
            var sql = $"INSERT INTO {tableName} ({strCols}) VALUES ({paraCols})";

            if (isReturn)
                sql += $";select @@IDENTITY";

            var sqlParams = properties.Select(p => new SqlParameter("@" + p.Name, p.GetValue(model) ?? DBNull.Value))
                .ToArray();

            return new SqlModel { Sql = sql, Paras = sqlParams };
        }


        /// <summary>
        /// 移除字符串（逗号分割）
        /// </summary>
        /// <param name="rawStr"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        private static string RemoveStringItem(string rawStr, string item)
        {
            if (rawStr is null || item is null) return rawStr;
            var strArr = rawStr.Split(',').ToList();
            if (strArr.Count <= 0) return rawStr;
            strArr.Remove(item);
            return string.Join(",", strArr);
        }
    }
}