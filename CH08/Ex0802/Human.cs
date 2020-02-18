using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0802
{
   //Human是一個繼承Person的衍生類別，使用this關鍵字取得父類別屬性值
   class Human : Person //繼承了Person類別
   {
      //this取得父類別設定的屬性值
      public string this[string Surname]
      { get { return Surname; } }

      /* 衍生類別的建構函式可以重設屬性值
         使用this關鍵字取得父類別的屬性值 */
      public Human()
      {
         Height = 175;//設定新的身高
         this.Hair = Hair;//取得基底類別的屬性
      }

      //「運算式主體」宣告方法
      public void Show() => Console.WriteLine(
         $"我是第二代，我也是{Hair}頭髮，身高 ={Height} cm");
   }
}
