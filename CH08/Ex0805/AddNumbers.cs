using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0805
{
   class DiffNum   //基底類別
   {
      //靜態欄位變數
      public static int num1 = 45;
      public static int num2 = 125;
   }

   //繼承DiffNum類別
   class AddNumbers : DiffNum 
   {
      //隱藏欄位變數
      new public static int num1 = 175;

      static int result1 = num1 + num2;
      static int result2 = DiffNum.num1 + DiffNum.num2;

      //主程式
      static void Main(string[] args)
      {
         WriteLine($"{num1} + {num2} = {result1}");
         WriteLine($"{DiffNum.num1} + { DiffNum.num2}" +
            $" = {result2}");

         ReadKey();
      }
   }
}
