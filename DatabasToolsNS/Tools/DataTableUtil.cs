using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DatabaseToolsNS.Tools
{
    public class DataTableUtil
    {
        public static void SetPropertiesFromDataRow(object obj, DataRow row)
        {
            var targetProperties = obj.GetType().GetProperties();

            foreach (DataColumn dataColumn in row.Table.Columns)
            {
                var targetProperty = targetProperties.FirstOrDefault(propertyInfo => (propertyInfo.Name ?? "") ==
                                     (dataColumn.ColumnName ?? ""));
                if (targetProperty != null && targetProperty.CanWrite)
                {
                    if((targetProperty.PropertyType.ToString().ToLower() ?? "" ).Equals("system.boolean"))
                    {
                        targetProperty.SetValue(obj, Convert.ToBoolean(row[dataColumn.ColumnName]), null);
                    }
                    else
                    {
                        targetProperty.SetValue(obj, row[dataColumn.ColumnName]);
                    }
                }
            }

        }

    }
}
