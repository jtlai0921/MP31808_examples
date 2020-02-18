using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0804
{
   class Person  //基底類別
   {
      private int baseSalary;//私有欄位

      //Name -- 自動實做屬性
      protected string Name { get; set; }

      //實做屬性，扣除保險費，以兩個if敘述來判斷value值
      public int BaseMoney
      {
         get { return baseSalary; }//回傳扣除費用的薪資

         set //依據薪資等級扣除保險費
         {
            if (value >= 22800 && value <= 36300)
            {
               if (value < 22800)
                  baseSalary = value - 456;
               else if (value < 25200)
                  baseSalary = value - 504;
               else if (value < 27600)
                  baseSalary = value - 552;
               else if (value < 30300)
                  baseSalary = value - 606;
               else if (value < 33300)
                  baseSalary = value - 666;
               else if (value < 36300)
                  baseSalary = value - 726;
            }
            else
               WriteLine("無法計算");
         }
      }

      public Person()//建構函式
      {
         Name = "Jason";
         BaseMoney = 32000;
      }

      public void Show()//定義成員方法
      {
         WriteLine($"員工{Name, 7}，實際薪水 {BaseMoney:C0}");
      }
      ~Person() { }//解構式清除物件
   }
}
