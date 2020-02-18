using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;   //匯入靜態類別Console

//巢狀if敘述判斷輸入分數的等級
namespace Ex0404
{
   class Program
   {
      static void Main(string[] args)
      {
         Write("請輸入分數：");
         ushort score = ushort.Parse(ReadLine());
         //巢狀if第一層：大於或等於60分
         if (score >= 60)
         {
            //巢狀if第二層：大於或等於70分
            if (score >= 70)
            {
               //巢狀if第三層：大於或等於80分
               if (score >= 80)
               {
                  //條件運算子：大於或等於90分                  
                  WriteLine(score >= 90 ? 
                     $"分數 {score} A級" : $"分數 {score} B級");
               }
               else
                  WriteLine($"分數 {score} C級");
            }
            else
               WriteLine($"分數 {score} D級");
         }
         else
            WriteLine($"分數 {score} E級");

         ReadKey();
      }
   }
}
