using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Array類別的Sort()方法排序
namespace Ex0502
{
   class Program
   {
      static void Main(string[] args)
      {
         //宣告陣列並初始化元素
         int[] number = { 56, 78, 9, 354 };

         Write("排序前：");
         //讀取排序前的陣列元素
         foreach (int element in number)
            Write($"{element,3} ");

         Array.Sort(number);//遞增排序
         //Array.Reverse(number);//反轉陣列元素

         Write("\n排序後：");
         //讀取排序後元素
         for (int item = 0; item < number.Length; item++)
            Write($"{number[item],3} ");
         WriteLine();

         ReadKey();
      }
   }
}
