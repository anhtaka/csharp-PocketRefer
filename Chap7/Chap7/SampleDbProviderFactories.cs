using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Chap7
{
    class SampleDbProviderFactories
    {
        static void Main(string[] args)
        {
            DataTable table = DbProviderFactories.GetFactoryClasses();
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn col in table.Columns)
                {
                    Console.WriteLine("{0}:\t{1}",col.ColumnName, row[col]);
                }
                DbProviderFactory fact = DbProviderFactories.GetFactory(row);
                //DbConnection conn = fact.CreateConnection();
                // ・・・　factから様々なDbXXXのオブジェクトを作成
                Console.WriteLine("-----------------------");
            }
        }
    }
}
