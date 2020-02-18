using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0312
{
   class Program
   {
      static void Main(string[] args)
      {
         int num1 = 14_652; int num2 = 35;
         //兩數相除，將變數num2轉為float型別
         float result = (float)num1/num2;

         WriteLine($"{num1} + {num2} = {(num1 + num2):n0}");
         WriteLine($"{num1} - {num2} = {(num1 - num2):n0}");
         WriteLine($"{num1} * {num2} = {(num1 * num2):n0}");
         //f5輸出含有小數5位的數值
         WriteLine($"{num1} / {num2} = {result:f5}");
         WriteLine($"{num1} % {num2} = {(num1 % num2):n0}");

         ReadKey();
      }
   }
}
