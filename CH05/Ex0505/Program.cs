using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Array類別Resize()方法改變陣列大小
namespace Ex0505
{
   class Program
   {
      static void Main(string[] args)
      {
         //原來的陣列
         string[] fruit = 
            { "Orange", "Apple", "Banana", "Grape" };
         Write("原來陣列元素:");
         foreach (string item in fruit)
            Write($"{item, 7} ");

         //newSize > fruit : 將陣列變大
         Array.Resize(ref fruit, fruit.Length + 2);

         //加入陣列元素
         fruit[4] = "Waterlemon";
         fruit[5] = "Strawberry";

         WriteLine("\n改變後的陣列元素:");
         foreach (string item in fruit)
            Write($"{item,5} ");

         //newSize < fruit : 將陣列變小，多的元素捨棄
         Array.Resize(ref fruit, fruit.Length - 1);
         WriteLine("\n變小後的陣列元素:");
         foreach (string item in fruit)
            Write($"{item,5} ");

         ReadKey();
      }
   }
}
