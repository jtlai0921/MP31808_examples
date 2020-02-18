using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0401
{
   class Program
   {
      static void Main(string[] args)
      {
         Write("請輸入分數：");
         //將輸入數值轉為int型別
         int score = int.Parse(ReadLine());

         //分數大於或等於60分才會顯示"Passing..."
         if (score >= 60)
         {
            WriteLine("Passing...");
         }
         ReadLine();//按Enter鍵才能關閉視窗
      }
   }
}
