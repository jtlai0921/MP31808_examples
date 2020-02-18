using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0602
{
   class ShowApp
   {
      static void Main(string[] args)
      {
         //建立兩個物件並實體化
         Student tomas = new Student();
         Student emily = new Student();

         //ShowName()方法傳入參數
         tomas.ShowName("Toams Dalton");
         emily.ShowName("Emily VanCamp");

         //InputName()方法回傳參數值
         WriteLine($"第一個學生 {tomas.InputName()}");
         WriteLine($"第二個學生 {emily.InputName()}");
         ReadKey();
      }
   }
}
