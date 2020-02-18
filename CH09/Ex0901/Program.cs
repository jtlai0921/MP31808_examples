using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0901
{
   class Program
   {
      static void Main(string[] args)
      {
         //宣告兩個不同型別陣列；one為數值，two為字串
         ushort[] one = { 11, 12, 13, 14, 15 };
         string[] two = { "Eric", "Andy", "Johon" };
         //靜態方法讀取陣列
         ShowMessage1(one);
         ShowMessage2(two);
         ReadKey();
      }

      //讀取陣列one - 數值
      private static void ShowMessage1(ushort[] arrData)
      {
         foreach (ushort item in arrData)
            Write($"{item, -6}");
         WriteLine();
      }

      //讀取陣列tow - 字串
      private static void ShowMessage2(string[] arrData)
      {
         foreach (string item in arrData)
            Write($"{item, -6}", item);
         WriteLine();
      }
   }
}
