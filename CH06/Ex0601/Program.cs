using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0601
{
   //自訂類別Student並設公開欄位-name
   class Student
   {
      public string name; //宣告類別欄位
   }

   //主控台應用程式所產生的類別Program
   class Program
   {
      static void Main(string[] args)
      {
         //第一個物件-tomas
         Student tomas = new Student();
         tomas.name = "Tomas Dalton";

         //第二個物件-emily
         Student emily = new Student();
         emily.name = "Emily VanCamp";

         WriteLine($"第一個學生：{tomas.name}");
         WriteLine($"第二個學生：{emily.name}");

         ReadKey();
      }
   }
}
