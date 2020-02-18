using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0806
{
   //繼承了Time類別
   class DemoTime : Time
   {
      private int exHour { get; set; }
      private int exMinute { get; set; }
      private int exSecond { get; set; }

      //定義衍生類別建構式，含有3個參數 -- 時、分、秒
      public DemoTime(int hr, int mn, int sc)
      {
         exHour = hr;
         exMinute = mn;
         exSecond = sc;
      }

      //new修飾詞會遮敝原有的基底類別的方法
      new public string showTime()
      {
         return string.Format(
            $"{exHour:D2}:{ exMinute:D2}:{exSecond:D2}");
      }
   }
}