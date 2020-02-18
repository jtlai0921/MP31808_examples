using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0611
{
   class Student
   {
      //靜態欄位，記錄物件
      public static int Count { get; private set; }

      //自動實做成員屬性：Name, Age
      public string Name { get; set; }
      public int Age { get; set; }

      //含有2個參數的建構函式
      public Student(string stuName, int stuAge)
      {
         Name = stuName; Age = stuAge;
         Count++;//建立物件時就累計
         WriteLine(
            $"第{Count}學生，名字 {Name,-8}，年齡{Age,3}");
      }
      ~Student() { }//解構函式
   }
}
