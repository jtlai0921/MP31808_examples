using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

//條件運算子
namespace Ex0403
{
   class Program
   {
      static void Main(string[] args)
      {
         ushort guess = 79;
         Write("請輸入1~100的數值：");
         ushort result = ushort.Parse(ReadLine());

         //條件運算子?: result>one，顯示result，否則就顯示guess
         WriteLine(result > guess ?        //條件運算式
            $"{result} 大於預設值 {guess}" : //true敘述
            $"{result} 小於預設值 {guess}"); //false敘述

         //result > guess時，求guess平方根，否則算出result3次方
         WriteLine(result > guess ? //條件運算式
            $"{guess}平方根 = {Sqrt(guess):f6}" : //true
            $"{result}的3次方 = {Pow(result, 3):N0}"); //false
         ReadKey();
      }
   }
}
