using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Common.Bll.Extensibility
{
    public static class DataSetExtensions
    {
        public static Dictionary<string, List<List<string>>> AsDictionary(this DataSet dataset)
        {
            Dictionary<string, List<List<string>>> result = new Dictionary<string, List<List<string>>>();

            foreach (DataTable table  in dataset.Tables)
            {
                List<List<string>> tableContent = new List<List<string>>();

                foreach (DataRow row in table.Rows)
                {
                    tableContent.Add(row.ItemArray.Select(m => m.ToString()).ToList());
                }

                result.Add(table.TableName, tableContent);
            }

            return result;
        }
    }
}
