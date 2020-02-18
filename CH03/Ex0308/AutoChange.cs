using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;//匯入靜態類別Console

//自動轉換型別
namespace Ex0308
{
   class AutoChange
   {
      static void Main(string[] args)
      {
         //num1自動轉換為float
         int num1 = 125;
         float num2 = 64.78F;
         float result = num1 + num2;

         //以「字串插補」方式輸出
         WriteLine($"{num1} + {num2} = {result}");         

         ReadKey();
      }
   }
}
