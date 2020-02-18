using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //匯入靜態類別Console

//if/else if進行多重條件判斷
namespace Ex0406
{
   class ManyConditions
   {
      static void Main(string[] args)
      {
         Write("請輸入你的結算額：");
         decimal result = decimal.Parse(Console.ReadLine());

         //取得輸入的result值，判斷繳交稅額等級
         if (result > 4400000)
         {
            result = result * 0.4M - 805000;
            WriteLine($"稅率40%，繳交稅額 = {result:N0}");
         }
         else if (result > 2350000)
         {
            result = result * 0.3M - 365000;
            WriteLine($"稅率30%，繳交稅額 = {result:N0}");
         }
         else if (result > 1170000)
         {
            result = result * 0.2M - 130000;
            WriteLine($"稅率20%，繳交稅額 = {result:N0}");
         }
         else if (result > 520000)
         {
            result = result * 0.12M - 36400;
            WriteLine($"稅率12%，繳交稅額 = {result:N0}");
         }
         else
         {
            result *= 0.05M;
            WriteLine($"稅率5%，繳交稅額 = {result:N0}");
         }
         ReadKey();
      }
   }
}
