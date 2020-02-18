using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0608
{
   /* 定義一個無任何參數的建構函式
      屬性Hrs採用自動實做
      方法成員showTime()的參數tm接收輸入值
      再指派給屬性hour，判斷時間是上午還是下午
   */
   class TimeInfo
   {
      //預設建構函式，沒有任何參數
      public TimeInfo() { WriteLine("呼叫時間"); }

      //解構函式
      ~TimeInfo() { WriteLine("釋放資源"); }

      public int Hrs { get; set; } //自動實做屬性Hrs

      //定義方法，判斷取得時間是下午或下午
      public void ShowTime(int tm)
      {
         Hrs = tm;
         if (Hrs > 12)
         {
            Hrs %= 12;
            WriteLine($"時間是下午：{Hrs}點");
         }
         else
            WriteLine($"時間是上午：{Hrs}點");
      }
   }
}
