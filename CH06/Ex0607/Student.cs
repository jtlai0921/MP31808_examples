using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0607
{
   class Student
   {
      //自動實做屬性
      public int Number { get; set; }
      public string Name { get; set; }

      //以建構函式來初始化屬性值
      public Student(string title, int score)
      {
         WriteLine("呼叫了建構函式！");
         Name = title;
         judgeFrom(score);//呼叫judgeFrom()方法
      }

      //解構函式
      ~Student()
      {
         WriteLine("解構函式清除物件！");
      }

      //宣告類別方法--判別分數的等級
      public void judgeFrom(int value)
      {
         Write($"Hi! {Name}, ");
         Number = value;//取得傳入的分數

         if (Number >= 90)
            WriteLine($"分數 {Number}, 表現優良！");

         else if (Number >= 80)
            WriteLine($"分數 {Number}, 表現不錯！");

         else if (Number >= 70)
            WriteLine($"分數 {Number}, 成績尚可！");

         else if (Number >= 60)
            WriteLine($"分數 {Number}, 通過考核！");

         else
            WriteLine($"分數 {Number},要多多努力...");
      }
   }
}
