using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0706
{
   /* calcNum()和calcNumeral()皆採用運算式主體
      無存取修飾詞，以private為存取範圍
      分別以傳值和傳址做呼叫，這兩個方法所得結果會不同 */
   class Difference
   {
      //使用傳值呼叫
      static void CalcNum(double figure) =>
         figure = Math.Pow(figure, 2);

      //使用傳址呼叫
      static void CalcNumeral(ref double figure) =>
         figure = Math.Pow(figure, 2);
      
      //主程式
      static void Main(string[] args)
      {
         Write("請輸入一個10~25數值：");
         double number = double.Parse(ReadLine());

         if (number < 10 || number > 25)
            Write("超出範圍，不做計算");
         else
         {
            CalcNum(number);   //傳值呼叫
            WriteLine($"傳值呼叫，數字 = {number}");
            CalcNumeral(ref number);   //傳址呼叫
            WriteLine($"傳址呼叫，數字 = {number}");
         }

         ReadKey();
      }
   }
}
