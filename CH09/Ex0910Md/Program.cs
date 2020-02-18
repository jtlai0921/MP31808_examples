using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0910Md
{
   class Program
   {
      static void Main(string[] args)
      {
         double numA = 56.0, numB = 0.0;
         double result = 0.0;
         if (numB == 0)
         {
            WriteLine("被除數為零，不能計算");
         }
         else
         {
            result = numA / numB;
            WriteLine(result);
         }
         ReadKey();
      }
   }
}
