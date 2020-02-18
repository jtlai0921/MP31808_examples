using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0810
{
   

   class Subject
   {
      static void Main(string[] args)
      {
         Write("請輸入名字：");
         string name = ReadLine();
         Write("請輸入學分數：");
         int total = int.Parse(ReadLine());
         Student first = new Student(total);
         Write($"Hi! {name}");
         first.ShowMessage();//呼叫類別的方法

         Console.ReadKey();
      }
   }
}
