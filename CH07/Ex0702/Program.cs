using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Random類別產生亂數
namespace Ex0702
{
   class Program
   {
      static void Main(string[] args)
      {
         /*建立隨機產生亂數的Random物件lotto
           利用DateTime結構的Ticks屬性(時間刻度)為亂數種子 */
         Random lotto = new Random((int)DateTime.Now.Ticks);
         //儲存隨機亂數
         byte[] item = new byte[6];
         //NextBytes()方法產生隨機的位元組陣列
         lotto.NextBytes(item);
         Write("樂透，有：");
         for (int count = 0; count < item.Length; count++)
         {
            //將第6個陣列元素做為特別獎
            if (count == 5)
            {
               byte special = item[count];
               WriteLine($"\n特別獎：{special}");
            }
            else
               Write($"{item[count],4}");
         }
         WriteLine();//換行
         ReadKey();
      }
   }
}