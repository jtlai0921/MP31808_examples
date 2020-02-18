using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//方法的 Overloading
namespace Ex0704
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] number;//宣告陣列

         Write(
            "請選擇 1.輸入二個數值 2.輸入三個數值 \n或 按0離開:");
         int outcome = int.Parse(ReadLine());

         //依據選擇數值 -- 0, 1, 2 去呼叫不同參數的doWork
         if (outcome == 0)
            DoWork(); //呼叫方法，沒有引數

         else if (outcome == 1)
         {
            int size = 2;//設定陣列長度
            number = new int[size];//依據長度，重設陣列大小
            for (int i = 0; i < number.Length; i++)
            {
               Console.Write($"第{i + 1}個：");
               number[i] = int.Parse(ReadLine());
            }
            DoWork(number); //呼叫方法，以陣列為傳遞引數
         }

         else if (outcome == 2)
         {
            int size = 3;
            number = new int[size];
            for (int i = 0; i < number.Length; i++)
            {
               Write($"第{i + 1}個：");
               number[i] = int.Parse(ReadLine());
            }
            DoWork(number, 0);//呼叫方法
         }

         Console.ReadKey();
      }
      
      //方法多載1 - 無參數; 使用「運算式主體」定義方法 
      public static void DoWork() =>
         WriteLine("沒有輸入任何數值");

      //方法多載2 - 傳入陣列，兩數相加
      public static void DoWork(int[] one)
      {
         int total = 0;
         for (int i = 0; i < one.Length; i++)
            total += one[i];
         Write($"兩數相加：{total:n0}");
      }

      //方法多載3 - 傳入陣列，找出最大值相加
      public static void DoWork(int[] one, int max)
      {
         //利用Math.Max找出3個數的最大值
         max = Math.Max(one[0], Math.Max(one[1], one[2]));
         Write($"最大值：{max:n0}");
      }
   }
}
