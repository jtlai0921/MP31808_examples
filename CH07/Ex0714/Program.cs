using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0714
{
   /* 定義 NumberStore 類別，以儲存整數值的陣列。
      FindNumber 方法會以傳址方式傳回第一個數字，
      此數字大於或等於傳遞為引數的數字。 
      如果數字未大於或等於引數，則方法會在索引 0 傳回數字。 */
   class NumberStore
   {
      int[] numbers = { 1, 3, 7, 15, 31, 63, 127, 255, 511, 1023 };

      public ref int FindNumber(int target)
      {
         for (int ctr = 0; ctr < numbers.Length; ctr++)
         {
            if (numbers[ctr] >= target)
               return ref numbers[ctr];
         }
         return ref numbers[0];
      }

      public override string ToString()
      {
         string retval = "";
         for (int ctr = 0; ctr < numbers.Length; ctr++)
         {
            retval += $"{numbers[ctr]} ";
         }
         return retval.Trim();
      }
   }

   /* 呼叫 NumberStore.FindNumber 方法
      來擷取大於或等於 16 的第一個值。 
      呼叫者接著會將方法所傳回的值加倍。 */
   class Program
   {
      //ref 傳回值和 ref 區域變數
      static void Main(string[] args)
      {
         var store = new NumberStore();
         Console.WriteLine($"Original sequence: {store.ToString()}");
         int number = 16;
         ref var value = ref store.FindNumber(number);
         value *= 2;
         Console.WriteLine($"New sequence:      {store.ToString()}");

         ReadKey();         
      }      
   }
}