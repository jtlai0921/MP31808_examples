using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //滙入靜態類別

//宣告變數設定初值
namespace Ex0304
{
   class Program
   {
      static void Main(string[] args)
      {
         int num1 = 120; //宣告第一個變數並給初值
         int num2 = 42_578; //宣告第二個變數並給初值
         WriteLine($"數值一：{num1}，數值二：{num2}");
         WriteLine($"兩數相加： {(num1 + num2):N0}");

         ReadKey();
      }
   }
}
