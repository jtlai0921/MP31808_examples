using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //匯入靜態類別Console

//巢狀for
namespace Ex0411
{
   class Program
   {
      static void Main(string[] args)
      {
         //外層for控制行數
         for (int one = 5; one >= 1; one--)
         {
            //內層for：控制輸出的數目
            for (int two = 1; two <= one; two++)
            {
               Write("*");
            }
            WriteLine();
         }
         ReadKey();
      }
   }
}
