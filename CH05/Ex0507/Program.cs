using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* 巢狀for讀取二維陣列元素
   讀取名字，再讀取分數，然後把二維陣列的每一欄分數相加
   巢狀for處理二維陣列：外層for讀取列註標，內層for讀取欄註標
*/
namespace Ex0507
{
   class Program
   {
      static void Main(string[] args)
      {                  
         int outer, inner;//巢狀for的計數器
         int[] sum = new int[3];//存放每個人的總分
         
         string[] name = { "Mary", "Tomas", "John" };

         //讀取名字並輸出，{0,7}表示預設7個欄位來存放
         foreach (string item in name)
         {
            Write("{0,7}", item);
         }
         WriteLine();

         int[,] score = {{75, 64, 96}, {55, 67, 39},
                   {45, 92, 85}, {71, 69, 81} };
         //GetLength()方法取得第1、2維陣列
         int row = score.GetLength(0);
         int column = score.GetLength(1);

         //讀取列數
         for (outer = 0; outer < row; outer++)
         {
            //讀取欄的元素
            for (inner = 0; inner < column; inner++)
            {
               Write($"{score[outer, inner],7}");
            }
            WriteLine();
            sum[0] += score[outer, 0];//第1欄分數相加
            sum[1] += score[outer, 1];//第2欄分數相加
            sum[2] += score[outer, 2];//第3欄分數相加
         }
         WriteLine("--------------------------");
         WriteLine($"Sum: {sum[0]} {sum[1],5} {sum[2],6}");

         ReadKey();
      }
   }
}
