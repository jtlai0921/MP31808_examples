using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //匯入靜態類別Console

//do/while廻圈
namespace Ex0410
{
   class Suppose
   {
      static void Main(string[] args)
      {
         bool guess = false;  //判斷是否有猜中
         int counter = 1; //儲存猜的次數

         //建立亂數物件rnd，呼叫Next()方法產生1~100之間的隨機數
         Random rnd = new Random();
         int value = rnd.Next(1, 100);

         do
         {
            Write("請輸入介於1~100之間的整數:");
            int keyin = Convert.ToInt32(ReadLine());
            if (keyin > value)
               WriteLine($"第{counter}次，{keyin}數字太大了!");
            else if (keyin < value)
               WriteLine($"第{counter}次，{keyin}數字太小了!!");
            else
            {
               WriteLine(
                  $"第{counter}次，終於猜中了，數字是{keyin}!!");
               guess = true;//表示猜對了
            }
            counter++;//累加猜的次數
         } while (!guess);//以guess做為條件判斷

         ReadKey();
      }
   }
}
