using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using static System.Console; //滙入靜態類別

//使用關係運算子
namespace Ex0314
{
   class Program
   {
      static void Main(string[] args)
      {
         int a = 25; int b = 147; int c = 67;
         bool result = false;
         WriteLine($"a={a}, b={b}, c={c}");
         result = (a + b) > (a + c);
         WriteLine($"a+b > a+c, 回傳 {result}");
         result = (b - c) < (c - a);
         WriteLine($"b-c < c-a, 回傳 {result}");
         result = a == 25;
         WriteLine($"a == 25, 回傳 {result}");
         result = b != 25;
         WriteLine($"b != 25, 回傳 {result}");
         ReadKey();
      }
   }
}
