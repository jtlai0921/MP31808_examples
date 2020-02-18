using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//foreach讀取陣列元素
namespace Ex0501
{
   class Program
   {
      static void Main(string[] args)
      {
         //step1.宣告一維陣列
         int[] grade;
         //step2.初始化陣列元素
         grade = new int[] { 78, 65, 92, 85 };
         int index = 0;  //加入索引，由0開始
         //step3.讀取陣列元素
         foreach (int item in grade)
         {
            WriteLine($" {index} - {item}");
            index += 1; //遞增
         }
         ReadKey();
      }
   }
}
