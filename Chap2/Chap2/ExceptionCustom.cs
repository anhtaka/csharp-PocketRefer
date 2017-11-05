using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ExceptionCustom
    {
        public class BaseCustomException : Exception { }        // 基本の例外クラス
        public class CustomException : BaseCustomException { }
        public static void Main()
        {
            try
            {
                throw new CustomException();
            }
            catch (BaseCustomException e)
            {
                // ユーザー定義例外の処理
                Console.WriteLine(e.Message);
            }
        }
    }
}
