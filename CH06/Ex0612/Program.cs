using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* 類別靜態方法
   Circle類別定義靜態方法，直接以類別名稱做存取
   分別計算圓周長或圓面積
*/
namespace Ex0612
{
   class Program
   {
      static void Main(string[] args)
      {
         double caliber, ridus = 0;
         Write("請選擇 1.計算圓周長，2.計算圓面積：");
         string wd = ReadLine();
         switch (wd)//依據輸入值做計算
         {
            case "1":
               Write("請輸入直徑：");
               //直接呼叫類別名稱做存取
               caliber = Circle.calcPeriphery(ReadLine());
               WriteLine($"圓周長 = {caliber:N5}");
               break;

            case "2":
               Write("請輸入半徑：");
               ridus = Circle.CalcArea(ReadLine());
               WriteLine($"圓面積 = {ridus:N5}");
               break;

            default:
               WriteLine("選擇錯誤");
               break;
         }
         ReadKey();
      }
   }
}
