using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//方法參數ref和out之不同
namespace Ex0711
{
   class Student
   {
      //定義靜態方法
      static void CalcScore(ref double chin, ref double eng,
            ref double math, out double sum)
      {
         chin *= 0.3;
         eng *= 0.3;
         math *= 0.4;
         sum = chin + eng + math;
      }

      //主程式
      static void Main(string[] args)
      {
         double total;
         Write("請輸入你的名字：");
         string name = ReadLine();
         Write("請輸入國文：");
         double chinese = double.Parse(ReadLine());
         Write("請輸入英文：");
         double english = double.Parse(ReadLine());
         Write("請輸入數學：");
         double mathem = double.Parse(ReadLine());

         //呼叫靜態方法，傳入各引數
         CalcScore(ref chinese, ref english,
            ref mathem, out total);
         WriteLine($"{name}");
         WriteLine($"國文 30% {chinese}，英文 30% {english}，" +
            $"數學 40% {mathem} \n合計 = {total}");

         ReadKey();
      }
   }
}
