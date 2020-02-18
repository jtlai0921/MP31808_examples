using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0806
{
   class Program
   {
      static void Main(string[] args)
      {
         //取得系統時間
         DateTime moment = DateTime.Now;

         //取得系統時間的時、分、秒
         int Hr = moment.Hour;   //時
         int Mun = moment.Minute;//分
         int Sed = moment.Second;//秒

         //建立物件以初始值方式設定時間
         Time oneTime = new Time
         {
            Hour = Hr + 8,
            Minute = Mun + 14,
            Second = Sed + 12
         };

         WriteLine($"時間：{oneTime.showTime()}");
         DemoTime TwentyFour = new DemoTime(Hr, Mun, Sed);
         WriteLine($"目前時間：{TwentyFour.showTime()}");

         //輸出目前的日期和時間
         /*string tm = String.Format($"今天日期：{DateTime.Now:d} " +
            $"時間：{DateTime.Now:t}");
         WriteLine(tm);*/

         ReadKey();
      }
   }
}
