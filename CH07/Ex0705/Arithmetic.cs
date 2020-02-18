using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0705
{
   /* 以計算等差級數和為前提
      前面章節作法，都是利用for廻圈，設定計數器的初值和終值
      讓使用者輸入起始值，末項和差值，求出差數和
   */
   class Arithmetic
   {
      //定義方法成員，使用private，同類別才能存取
      private int Progression(int first, int last,
            int diversity)
      {
         int sum = 0, temp = 0, number = 0;

         //檢查傳入的首項是否大於末項
         if (first < last)
         {  
            temp = first; //首項小於末項則予以置換
            first = last;
            last = temp;
         }

         number = (first - last) / diversity + 1;  //計算項數
         sum = (number * (first + last)) / 2;   //計算差數和
         return sum; //回傳計算結果
      }

      //主程式
      static void Main(string[] args)
      {
         //建立物件，呼叫方法成員
         Arithmetic copyValue = new Arithmetic();
         //輸入各項參數
         WriteLine("--等差級數和--");
         Write("請輸入起始值(首項)：");
         int first_value = int.Parse(ReadLine());
         Write("請輸入最後值(末項)：");
         int last_value = int.Parse(ReadLine());
         Write("請輸入差值：");
         int item = int.Parse(ReadLine());

         //呼叫方法成員
         int total = copyValue.Progression(
            first_value, last_value, item);

         //輸出等差級數和
         WriteLine($"{first_value}到{last_value}" +
            $"的差數和：{total:N0}");

         //輸出實引數內容
         WriteLine($"首項 = {first_value}，" +
            $"末項 = {last_value}，差值 = {item}");

         ReadKey();
      }
   }
}
