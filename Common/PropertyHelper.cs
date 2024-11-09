using System.Linq;
using System.Reflection;

namespace Common
{
    public class PropertyHelper
    {
        public static PropertyInfo[] GetProperties<T>(string columnNames)
        {
            var type = typeof(T);
            var properties = type.GetProperties();
            if (string.IsNullOrEmpty(columnNames)) return properties;
            var columns = columnNames.ToLower().Split(',');
            properties = properties.Where(p => columns.Contains(p.GetColumnName().ToLower())).ToArray();

            return properties;
        }
    }
}