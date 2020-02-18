using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//前置和後置運算
namespace Ex0311
{
   class Program
   {
      static void Main(string[] args)
      {
         //宣告變數num1, num2並指定初值
         int num1 = 5; int num2 = 10;

         //num2做後置運算-本身先加1再與num1運算
         int number = num1 + ++num2;
         Console.WriteLine("number = {0}, num2 = {1}",
            number, num2);

         //num2做前置運算-先與num1運算，本身再自行減1
         number = num1 + num2--;
         Console.WriteLine("number = {0}, num2 = {1}",
            number, num2);

         Console.ReadKey();
      }
   }
}
