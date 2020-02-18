using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//呼叫System名稱空間的Math類別的欄位PI，取得圓周率
namespace Ex0612
{
   class Circle
   {
      //第一個類別靜態方法--計算圓周長
      public static double calcPeriphery(string one)
      {
         double periphery = double.Parse(one);
         double result = periphery * Math.PI;
         return result;
      }

      //第二個類別靜態方法--計算圓面積
      public static double CalcArea(string two)
      {
         double area = double.Parse(two);
         double circleArea = 2 * area * area * Math.PI;
         return circleArea;
      }
   }
}
