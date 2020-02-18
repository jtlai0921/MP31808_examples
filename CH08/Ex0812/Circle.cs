using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//實作介面IShape -- 計算圓面積
namespace Ex0812
{
   class Circle : IShape
   {
      private double radius; //圓半徑

      //建構函式, 取得本身的半徑值
      public Circle(double radius) 
      {
         this.radius = radius;
      }

      //實做介面IShape定義的屬性, 回傳圓形面積的值
      public double Area 
      {
         get { return Math.Pow(radius, 2) * Math.PI; }
      }

      //運算式主體 - 覆寫ToString()方法
      public override string ToString() =>
         "圓形面積：" + string.Format($"{Area:F3}");
   }
}
