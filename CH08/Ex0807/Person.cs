using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0807
{
   //基底類別Person有兩個屬性：Height設定身高，Hair設定髮色，採自動實做
   class Person 
   {
      //Height, Hair自動實做屬性
      protected int Height { get; set; }
      protected string Hair { get; set; }

      public Person()   //父類別的建構函式
      {
         Height = 170;
         Hair = "棕色";
      }

      //運算式主體定義成員方法 -- 輸出父類別屬性
      public virtual void ShowMessage() => Console.WriteLine(
         $"父親，頭髮{Hair}，身高 = {Height} cm");
   }
}
