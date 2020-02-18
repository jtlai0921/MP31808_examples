using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//try/catch例外處理器
namespace Ex0910Ud
{
   class Program
   {
      static void Main(string[] args)
      {
         int numA = 56, numB = 0;

         //進行程式錯誤的捕捉
         try //被除數為零時進行錯誤處理
         {
            if (numB == 0)
               WriteLine("被除數是零");
            WriteLine(numA / numB);
         }

         //發生例外狀況的處理
         catch (DivideByZeroException ex)
         {
            WriteLine(ex.ToString());
         }

         WriteLine($"除數 {numA} 除以 {numB}");

         ReadKey();
      }
   }
   
}