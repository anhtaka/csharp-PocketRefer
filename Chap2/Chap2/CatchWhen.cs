using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2
{
    class CatchWhen
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("test");
                // 結果：test
            }
            catch (Exception ex) when (ex.Message == "test")
            {
                Console.WriteLine(ex.Message);
            }
            // Messageプロパティが"test"以外の例外
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
