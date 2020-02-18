using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //滙入靜態類別

//使用常數
namespace Ex0305
{
   class Program
   {
      static void Main(string[] args)
      {
         //將換算單位宣告為常數，以area儲存結果
         const float Square = 3.0579F; 
         float area;
         Write("請輸入坪數：");
         //Parse()方法轉換為float型別
         area = float.Parse(Console.ReadLine());
         WriteLine($"{area}坪 = {Square * area}平方公尺");

         ReadKey(); //暫停螢幕
      }
   }
}
