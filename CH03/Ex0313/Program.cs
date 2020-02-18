using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//使用指定運算子
namespace Ex0313
{
   class Program
   {
      static void Main(string[] args)
      {
         float num1 = 52.00F;
         float num2 = 123_788.655F;         
         WriteLine($"num1 = {num1}, num2 = {num2}");
         WriteLine($"num1 += num2, num1 = {num1 += num2:n3}");
         WriteLine($"num1 -= num2, num1 = {num1 -= num2:n3}");
         WriteLine($"num1 *= num2, num1 = {num1 *= num2:n3}");
         //重設變數num1、num2的值
         num1 = 123_788.655F; num2 = 52.0F; 
         WriteLine($"num1 /= num2, num1 = {num1 /= num2:n5}");
         WriteLine($"num1 %= num2, num1 = {num1 %= num2:n3}");
         ReadKey();
      }
   }
}
