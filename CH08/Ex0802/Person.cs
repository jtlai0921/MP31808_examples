using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0802
{
   class Person   //基底類別
   {
      //Height, Hair自動實做屬性
      protected int Height { get; set; }
      protected string Hair { get; set; }

      //只用get擷取姓氏，return回傳其值，形成唯讀屬性
      protected string Surname
         { get { return "Cumberbatch"; } }

      //基礎類別的建構函式
      public Person()
      {
         Height = 170;
         Hair = "棕色";
      }

      //「運算式主體」宣告方法
      public void showMessage() => Console.WriteLine(
            $"父親 {Surname}，頭髮{Hair}，身高 = {Height} cm");
   }
}
