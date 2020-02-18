using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0811
{
   class Subjects
   {
      static void Main(string[] args)
      {
         Write("請輸入名字：");
         string name = ReadLine();

         Write("請輸入學分數：");
         int total = int.Parse(ReadLine());

         Write("請選擇： 1.學生 2碩博生 ");
         int grade = int.Parse(ReadLine());

         Student first = new Student(grade, total);
         Write($"Hi! {name}");
         first.ShowMessage();

         ReadKey();
      }
   }
}
