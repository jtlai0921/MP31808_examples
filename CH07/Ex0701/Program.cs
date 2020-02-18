using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Math類別
namespace Ex0701
{
   class Program
   {
      static void Main(string[] args)
      {
         Write("請輸入半徑值：");
         double radius = Convert.ToDouble(ReadLine());

         //圓面積PI*r*r，Math欄位PI提供圓周率，Pow指定冪次方
         double area = Math.PI * Math.Pow(radius, 2);

         //Round()方法輸出圓面積含4位小數
         WriteLine($"圓面積 = { Math.Round(area, 4):N4}");

         ReadKey();
      }
   }
}
