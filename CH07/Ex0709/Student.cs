using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0709
{
   class Student
   {
      //靜態方法 : 傳遞長度不一的陣列，加入params關鍵字
      static void CalcScore(params int[] one)
      {
         int sum = 0; double average = 0.0;

         for (int count = 0; count < one.Length; count++)
            sum = sum + one[count]; //加總陣列元素

         average = (double)sum / one.Length; //求平均值
         WriteLine($"總分 = {sum}，平均 = {average:f3}");
      }

      //主程式
      static void Main(string[] args)
      {
         int[] score1 = { 78, 96, 45, 33 }; //宣告陣列並初始化
         Write("Peter 修了{0}科\n", score1.Length);
         CalcScore(score1);//呼叫靜態方法

         int[] score2 = { 95, 76, 55, 64, 74, 91, 87 };
         Write($"Robecca 修了{score1.Length}科\n");
         CalcScore(score2);

         ReadKey();
      }
   }
}
