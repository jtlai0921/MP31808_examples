using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0908
{
   class Lookfor
   {
      //1.定義委派，含有一個引數(數值)
      public delegate void Speculation(Int32[] numerical);

      //主程式
      static void Main(string[] args)
      {
         //建立一個陣列
         Int32[] figures =
            {21, 32, 33, 142, 115, 125, 317, 188, 192, 420};

         //建立物件
         FindNumbers searchNum = new FindNumbers();

         //以物件呼叫相關方法
         searchNum.IsOdd(figures);
         searchNum.IsEven(figures);
         searchNum.IsDivide3(figures);

         ReadKey();
      }
   }
}
