using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0909
{
   class Program
   {
      //1.宣告委派
      delegate int Appoint(int i);

      static void Main(string[] args)
      {
         Write("請輸入1~100數值：");
         int num = int.Parse(ReadLine());
         if (num > 100 || num < 1)
            WriteLine("數值不對");
         else
         {
            //2.Lambda運算式取代委派方法；3.宣告委派物件deputation 
            Appoint deputation = number => number * number;
            //4.呼叫委派
            WriteLine($"運算結果：{deputation(num):n0}");
         }
         ReadKey();
      }
   }
}
