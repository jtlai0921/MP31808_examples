using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0606
{
   class Student
   {
      //自動實做屬性
      public int Number { get; }
      public string Name { get; set; }

      //以建構函式來初始化屬性值
      public Student(string title, int score)
      {
         WriteLine("呼叫了建構函式！");
         Number = score;//將接收的值指定給屬性
         Name = title;
      }

      //宣告類別方法--判別分數的等級      
      public void judgeFrom()
      {
         Write($"Hi! {Name}, ");

         if (Number >= 90)   //多重條件前斷
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
