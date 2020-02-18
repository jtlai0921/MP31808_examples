using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 時間包含時、分、秒
   以Time類別設定時、分、秒欄位
   利用屬性來取得個別的儲存值
   然後以showTime()方法配合Format()方法輸出時間格式
*/
namespace Ex0806
{
   class Time   //基底類別
   {
      //定義私有欄位 - 時、分、秒
      private int hour;
      private int minute;
      private int second;

      public int Hour //實做屬性 Hour
      {
         get { return hour; }
         set
         { //時在0~24
            if (value >= 0 && value < 24)
               hour = value;
         }
      }

      public int Minute   //實做屬性 Mimute
      {
         get { return minute; }
         set
         {
            minute = ( //以「?:」取代if陳述式，進行條件判斷
               (value >= 0 && value < 60) ? value : 0);
         }
      }

      public int Second   //實做屬性 Second
      {
         get { return second; }
         set
         {
            second = ((value >= 0 && value < 60) ? value : 0);
         }
      }

      //判斷時間是否大於12來顯示上午或下午
      public string showTime()
      {
         string am = "上午"; string pm = "下午";
         //時採12小時制
         if (hour == 0 || hour == 12)
            hour = 12;
         else
            hour %= 12;

         //Fromat()方法回傳時制格式
         return string.Format($"{(hour < 12 ? am : pm)} " +
            $"{hour:D2}:{minute:D2}:{second}");
      }
   }
}