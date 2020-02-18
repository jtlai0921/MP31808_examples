using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0812
{
   class DemoShape
   {
      static void Main(string[] args)
      {
         IShape[] molds = { //陣列初始化實作各類別物件
            new Circle(15.8),//圓
            new Trapezoidal(15.0, 17.0, 11.0), //梯形
            new Rectangle(14.0, 15.0) //矩形
         };
         WriteLine("求出各種面積");

         //讀取陣列元素
         foreach (IShape item in molds)
            WriteLine(item);

         ReadKey();
      }
   }
}
