using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// throw敘述丟出錯誤
namespace Ex0912
{
   class Program
   {
      static void Main(string[] args)
      {
         int month = 0;
         do
         {
            try
            {
               CheckMonth(month); //呼叫靜態方法
               break;
            }
            catch (ArgumentOutOfRangeException)
            {
               WriteLine("輸入月份不對");
            }
         } while (true);

         ReadKey();
      }

      //檢查月份
      public static int CheckMonth(int mon)
      {
         Write("請輸入月份：");
         mon = int.Parse(Console.ReadLine());
         if (mon > 12)
            throw new ArgumentOutOfRangeException();
         else
         {
            switch (mon)
            {
               case 2:
                  WriteLine($"{mon} 月只有28天");
                  break;
               case 4:
               case 6:
               case 9:
               case 11:
                  WriteLine($"{mon} 月有30天");
                  break;
               default:
                  WriteLine($"{mon} 月只有31天");
                  break;
            }
         }
         return mon;
      } 
   }
}
