using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;  //滙入靜態類別

namespace Ex0408
{
   class CalcNums
   {
      static void Main(string[] args)
      {
         int number = 0, sum = 0, count = 0;
         string endkey;

         //不加任何敘述的for廻圈
         for (; ; )
         {
            Write("請輸入數值：");
            number = int.Parse(ReadLine());
            count++;//計數器累計次數
            sum += number;//儲存數值

            Write("還要繼續嗎?(Y繼續N離開)");
            endkey = ReadLine();

            if (endkey == "y" || endkey == "Y")
               continue;//繼續執行
            else if (endkey == "n" || endkey == "N")
               break;//結束廻圈
         }

         WriteLine($"輸入{count}個數值，總計：{sum}");

         ReadKey();
      }
   }
}
