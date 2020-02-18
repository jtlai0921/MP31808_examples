using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//物件初始設定式
namespace Ex0610
{
   class Program
   {
      static void Main(string[] args)
      {
         Student Mary = new Student { Math = 78, Eng = 65 };
         WriteLine("Mary: ");
         Write($"數學 {Mary.Math}");
         Write($", 英文 {Mary.Eng}");
         WriteLine($", 總分 = {Mary.sum()}");

         Student Tomas = new Student
            { Math = 83, Eng = 85, Comp = 61 };
         WriteLine("Tomas: ");
         Write($"數學 {Tomas.Math}");
         Write($", 英文 {Tomas.Eng}", Tomas.Eng);
         Write($", 計概 {Tomas.Comp}", Tomas.Comp);
         WriteLine($", 總分 = {Tomas.sum()}");

         ReadKey();
      }
   }
}
