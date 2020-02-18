using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0710
{
   class DiffParams
   {
      static void Main(string[] args)
      {
         int[] two; //宣告一個陣列
         //呼叫處理陣列的靜態方法
         InitArray(ref two);

         Write("陣列元素：");
         for (int i = 0; i < two.Length; i++)
         {
            Write(two[i] + " ");
         }

         ReadKey(); //畫面暫停
      }

      //定義靜態方法
      static void InitArray(ref int[] one)
      {
         one = new int[5] { 21, 12, 32, 14, 5 };
      }
   }
}
