using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//修改範例Ex0901的靜態方法ShowMessage()
namespace Ex0901Md
{
   class Program
   {
      static void Main(string[] args)
      {
         //宣告兩個陣列；one為數值，two為字串
         ushort[] one = { 11, 12, 13, 14, 15 };
         string[] two = { "Eric", "Andy", "Johon" };

         //靜態方法讀取陣列
         ShowMessage(one);
         ShowMessage(two);

         ReadKey();
      }

      //讀取陣列 - 使用泛型方法
      private static void ShowMessage<T>(T[] arrData)
      {
         foreach (T item in arrData)
            Write($"{item,-6} ");
         WriteLine();
      }
   }
}
