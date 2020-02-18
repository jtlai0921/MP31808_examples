using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//泛型方法加入條件約束
namespace Ex0903
{
   class Program
   {
      static void Main(string[] args)
      {
         WriteLine($"{127}, {63}, {311} " +
            $"最大值：{checkData(127, 63, 311)}");
         WriteLine($"{115.372}, {12.147}, {167.258} " +
            $"最大值：{checkData(115.372, 12.147, 167.258)}");
         WriteLine($"{"Sunday"}, {"Monday"}, {"Tuesday"} 最大值：" +
            $"{checkData("Sunday", "Monday", "Tuesday")}");

         ReadKey();
      }

      //定義泛型方法以where加入條件約束，搭配IComparable<T>介面實作其型別引數
      private static T checkData<T>(T one, T two, T three)
            where T : IComparable<T>
      {
         T max = one;//假定第一個參數是最大值

         //呼叫CompareTo()方法將第一個參數和第二、第三個參數分別做比較
         if (two.CompareTo(max) > 0)
            max = two;
         if (three.CompareTo(max) > 0)
            max = three;
         return max;
      }
   }
}
