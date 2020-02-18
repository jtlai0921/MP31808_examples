using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //滙入靜態類別

//邏輯運算子
namespace Ex0315
{
   class Program
   {
      static void Main(string[] args)
      {
         int a = 25; int b = 55; int c = 147; int d = 223;
         bool result = false;

         //&&運算子需兩邊的運算式都成立才會回傳true
         WriteLine($"a = {a}, b = {b}, c = {c}, d = {d}");
         result = (b > a) && (d > c);
         WriteLine($"(a>b) && (c>d) = {result}");

         //||運算子只要一邊的運算式成立就會回傳true
         result = (a > b) || (c > d);
         WriteLine($"(a>b) || (c>d) = {result}");

         //!運算子做反相運算，a沒有大於b, 回傳false，反相後變成true
         result = !(a > b) ;         
         WriteLine($"!(a > b) = {result}");
         ReadKey();
      }
   }
}