using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//實作介面IShape -- 計算梯形面積
namespace Ex0812
{
   class Trapezoidal : IShape
   {
      private double onbottom; //上底
      private double underbm;  //下底
      private double high;     //高

      public Trapezoidal(double onbottom,
         double underbm, double high) //建構函式
      {
         this.onbottom = onbottom;
         this.underbm = underbm;
         this.high = high;
      }

      //實做介面屬性, 回傳梯形面積的值
      public double Area 
      {
         get{ return (onbottom * underbm) * high / 2; }
      }

      //覆寫ToString()方法
      public override string ToString() =>
         "梯形面積：" + string.Format($"{Area:F1}");
   }
}
