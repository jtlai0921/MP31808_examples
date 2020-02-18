using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//實作介面IShape -- 計算矩形面積
namespace Ex0812
{
   class Rectangle : IShape
   {
      private double width;  //欄位 - 寬
      private double height; //欄位 - 高

      public Rectangle(double width, double height)
      {
         this.width = width;
         this.height = height;
      }

      public double Area //實做介面屬性
      {
         get { return width * height; }
      }

      //覆寫ToString()方法
      public override string ToString()
      {
         return "矩形面積：" + string.Format($"{Area:F1}");
      }
   }
}
