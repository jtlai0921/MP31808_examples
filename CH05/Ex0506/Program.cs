using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//複製陣列
namespace Ex0506
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] fruit = {"orange", "apple", "lemon",
            "pineapple", "papaya", "guava"};

         //目的陣列，存放複製元素
         string[] produce = new string[fruit.Length];
         string[] product = new string[4];

         //使用CopyTo()方法，複製所有元素
         fruit.CopyTo(produce, 0);
         WriteLine("使用CopyTo()方法");
         foreach (string item in produce)
            Write($"{item},");
         WriteLine();

         //使用靜態方法Array.Copy()，複製前4個元素
         Array.Copy(fruit, product, 4);
         WriteLine("使用靜態方法Copy()");
         foreach (string item in product)
            Write($"{item}, ");
         WriteLine();

         ReadKey();
      }
   }
}
