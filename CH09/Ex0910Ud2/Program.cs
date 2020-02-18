using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// try/catch敘述加入when關鍵字
namespace Ex0910Ud2
{
   class Program
   {
      static void Main(string[] args)
      {
         Write("數值1：");
         int num1 = int.Parse(ReadLine());
         Write("數值2：");
         int num2 = int.Parse(ReadLine());
         int result = 0;

         try
         {
            result = num1 / num2;
            WriteLine($"Result = {result}");
         }

         //配合catch敘述做例外狀況的過濾
         catch (DivideByZeroException ex) when (num2 == 0)
         {
            WriteLine(ex.Message);//輸出錯誤訊息
         }
         ReadKey();
      }
   }
}
