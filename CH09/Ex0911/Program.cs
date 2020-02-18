using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//finally敘述
namespace Ex0911
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] number = new int[] { 11, 12, 13, 14, 15 };
         int count;
         //讀取陣列元素只有5個，For迴圈卻要讀取6個，會有例外狀況
         for (count = 0; count <= 5; count++)
         {
            //設定捕捉器
            try
            {
               Write($"number[{count}] = {number[count]}");
            }
            catch (IndexOutOfRangeException ex)
            {
               WriteLine(ex.ToString());
            }
            finally
            {
               WriteLine($"，第 {count} 個 ");
            }
         }
         ReadKey();
      }
   }
}
