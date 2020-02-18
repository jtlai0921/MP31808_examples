using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0801
{
   //Education繼承了School類別
   class Education : School
   {
      //自動實做屬性, 存放上課人數
      private int student { get; set; }

      public Education()//建構函式
      {
         subject = "英文會話";
         room = 1206;
         teacher = "Poe Dameron";
      }

      //定義子類別的方法，傳入學生數是否有達到15人以上
      public void Display(int people)
      {
         student = people;
         if (student < 15)         
            WriteLine($"只有{student}人，不會開課");         
         else
         {
            WriteLine($"科目:{subject}, 教室-{room}, " +
               $"\n老師:{teacher}, 學生人數 {student}");  
         }
      }
   }
}
