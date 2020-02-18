using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; ////滙入靜態類別

//利用int取得字元的ASCII值，或將ASCII值以ToChar()方法轉為字元
namespace Ex0303
{
   class Program
   {
      static void Main(string[] args)
      {
         //將字元以型別int轉為ASCII值
         char chM = 'M';
         int num1 = (int)chM;

         /* 將ASCII值以型別char轉為字元，
            呼叫Convert類別的ToChar()方法轉為字元 */
         int num2 = 78;
         char chN = Convert.ToChar(78);         
         
         //輸出結果
         WriteLine($"字元 {chM}，ASCII值 = {num1}");
         WriteLine($"ASCII {num2}，字元 {chN}");

         ReadKey();
      }
   }
}
