using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//使用for廻圈將數值1+2+3+...+10 
namespace Ex0407
{
   class Program
   {
      static void Main(string[] args)
      {
         int sum = 0;  //儲存加總結果         
         //變數k為計數器，廻圈每執行一次就自動加1
         for (int k = 1; k <= 10; k++)
         {            
            Console.WriteLine($" k = {k:d2}, sum = {sum += k:d2}");
         }         
         Console.ReadKey();
      }
   }
}
