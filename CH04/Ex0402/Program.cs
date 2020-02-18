using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//if敘述做單一條件判斷
namespace Ex0402
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.Write("請輸入分數：");
         //將輸入數值轉為int型別
         int grade = int.Parse(Console.ReadLine());

         //if敘述做單一條件判斷
         if (grade >= 60)
         {
            Console.WriteLine("考試通過...");//條件成立
         }
         else //條件不成立
            Console.WriteLine("多多加油!!");

         //使用三元運算子「? :」做條件判斷
         /*var result = (grade >= 60) ? "Passing..." : "Failed!!";
         WriteLine(result);*/
         ReadLine();
      }
   }
}
